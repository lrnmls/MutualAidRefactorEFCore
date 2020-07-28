using Microsoft.EntityFrameworkCore;
using MutualAid.Data.Context;
using MutualAid.Framework.DataFactory;
using MutualAid.Framework.Entities;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace MutualAid.Data.DataFactory
{
    public abstract class BaseEntityDataFactory<TEntity> : BaseDataFactory<TEntity> where TEntity : BaseEntity
    {
        protected BaseEntityDataFactory(MutualAidContext mutualAidContext) : base(mutualAidContext)
        {

        }
        public abstract TEntity[] Seed { get; }

        public override void Generate()
        {
            Trace.WriteLine($"Generating {typeof(TEntity).Name}...");
            Context.Database.OpenConnection();
            try
            {
                var setIdentityInsertCommand = $"SET IDENTITY_INSERT [{typeof(TEntity).Name}] ON;";
                Context.Database.ExecuteSqlRaw(setIdentityInsertCommand);
                foreach (var baseEntity in Seed)
                {
                    if (!Context.Set<TEntity>().Any(b => b.Id == baseEntity.Id))
                    {
                        Context.Set<TEntity>().Add(baseEntity);
                    }
                    else
                    {
                        Context.Set<TEntity>().Update(baseEntity);
                    }
                }

                Context.SaveChanges();
            }
            catch (Exception ex)
            {
                Trace.WriteLine($"Error when seeding data for {typeof(TEntity).Name}...{ex}");
            }
            finally
            {
                var setIdentityInsertCommand = $"SET IDENTITY_INSERT [{typeof(TEntity).Name}] OFF;";
                Context.Database.ExecuteSqlRaw(setIdentityInsertCommand);
            }

            Trace.WriteLine("Done.");
        }
    }
}
