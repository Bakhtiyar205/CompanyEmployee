using Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.InterFaces
{
    public interface IRepository<T> where T:BaseEntity
    {
        bool Create(T entity);
        bool Update(T entity);
        bool Delete(T entity);
        T Get(Predicate<T> filter);
        List<T> GetAll(Predicate<T> filter);
    }
}
