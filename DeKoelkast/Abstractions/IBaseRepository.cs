using DeKoelkast.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeKoelkast.Abstractions
{
    public interface IBaseRepository<T> :IDisposable where T : TableData, new()
    {
        void SaveEntity(T entity);

        void SaveEntityWithChilderen(T entity, bool recursive = false);

        T? GetEntity(int id);
        List<T>? GetEntities();

        List<T>? GetEntitiesWithChildren(); 

        void DeleteEntity(T entity);

        void DeleteEntityWithChilderen(T entity);
    }
}