using MutualAid.Data.Context;
using MutualAid.Data.DataFactory;
using MutualAid.Data.Entities;
using MutualAid.Framework.DataFactory;
using MutualAid.Framework.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MutualAid.Data.Extensions
{
    public static class DbContextExtensions
    {
        public static void Seed(this MutualAidContext context)
        {
            var baseEntityFactories = new List<IDataFactory<BaseEntity>>()
            {
                new UserDataFactory(context)
            };

            baseEntityFactories.ForEach(sf => sf.Generate());
        }
    }
}