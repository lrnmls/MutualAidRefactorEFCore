using System;
using System.Collections.Generic;
using System.Text;

namespace MutualAid.Framework.DataFactory
{
    public interface IDataFactory<out TEntity> where TEntity : class
    {
        TEntity[] Seed { get; }
        void Generate();
    }
}
