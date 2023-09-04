using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Core.DataAccess
{
    // Generic Constraint
    //clas referans tip 
    // IEntity : IEntity olabilir veya onu implemente eden bir nesne olabilir
    // new(): new'lenebilir olmalidir.
    public interface IEntityRepository<T> where T : class, IEntity,new()
    {
        List<T> GetAll(Expression<Func<T,bool>> filter=null);
        T Get(Expression<Func<T,bool>> filter);
        //Deletegate 
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
