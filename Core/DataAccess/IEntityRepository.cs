using Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Core.DataAccess
{
    // Generic constraint = kısıtlama
    // class : referans tip olabilir
    //IEntity : IEntity olabilir veya IEntity'i implement eden bir nesne olabilir.
    // new() : new'lenebilir olmalı. IEntity'i implement eden sınıflar parametresiz bir constructor'a sahip olmalı.
    public interface IEntityRepository<T> where T:class, IEntity, new()
    {
        List<T> GetAll(Expression<Func<T,bool>> filter = null);
        T Get(Expression<Func<T, bool>> filter);
        void Add(T entity);
        void Delete(T entity);
        void Update(T entity);
    }
}
