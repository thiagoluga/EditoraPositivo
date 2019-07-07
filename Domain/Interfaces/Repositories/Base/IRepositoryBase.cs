using Domain.Entities.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Interfaces.Repositories.Base
{
    public interface IRepositoryBase<TEntity, TId> 
        where TEntity : class 
        where TId: struct
    {
        TEntity Adicionar(TEntity entity);

        bool Existe(Func<TEntity, bool> where);
    }
}
