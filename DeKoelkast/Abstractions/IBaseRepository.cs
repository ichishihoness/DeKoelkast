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

        T? GetEntity(int id);
        List<T>? GetEntities();

        void DeleteEntity(T entity);
    }
}