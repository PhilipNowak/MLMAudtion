using System;
using System.Collections.Generic;
using System.Text;

namespace MLM.Audtion.Core.Interfaces
{
    public interface IRepository<TEntity>
    {
        IEnumerable<TEntity> GetAll();
        TEntity Insert(TEntity entity);
        void Update(TEntity entity);
    }
}
