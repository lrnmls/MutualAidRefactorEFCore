using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace MutualAid.Framework.DataFactory
{
    public abstract class BaseDataFactory<TEntity> : IDataFactory<TEntity> where TEntity : class
    {

        protected DbContext Context;

        protected string Schema = "";

        protected BaseDataFactory(DbContext context)
        {
            Context = context;
        }

        public virtual TEntity[] Seed { get; set; }

        public abstract void Generate();
    }
}
