using DeKoelkast.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace DeKoelkast.Repositories
{
    public class BaseRepository<T> : IBaseRepository<T> where T : TableData, new()
    {
        SQLiteConnection connection;
        public string? StatusMessage { get; set; }


        public BaseRepository()
        {
            connection = new SQLiteConnection(Constants.DatabasePath, Constants.flags);
            connection.CreateTable<T>();
        }

        public void DeleteEntity(T entity)
        {
            try
            {
                connection.Delete(entity);
            }
            catch (Exception ex)
            {
                StatusMessage = $"Error {ex.Message}";
            }
        }

        public void Dispose()
        {
            connection.Dispose();
        }

        public List<T>? GetEntities()
        {
            try
            {
                return connection.Table<T>().ToList();
            }
            catch (Exception ex)
            {
                StatusMessage = $"Error {ex.Message}";
            }
            return null;
        }

        public T? GetEntity(int id)
        {
            try
            {
                return connection.Table<T>().FirstOrDefault(x => x.Id == id);
            }
            catch (Exception ex)
            {
                StatusMessage = $"Error {ex.Message}";
            }
            return null;
        }

        public void SaveEntity(T? entity)
        {
            int result = 0;
            if (entity != null)
            {
                try
                {
                    if (entity.Id != 0)
                    {
                        result = connection.Update(entity);
                        StatusMessage = $"{result} row(s) updated";
                    }
                    else
                    {
                        result = connection.Insert(entity);
                        StatusMessage = $"{result} row(s) added";
                    }
                }
                catch (Exception ex)
                {
                    StatusMessage = $"Error {ex.Message}";
                }
            }
        }
    }
}
