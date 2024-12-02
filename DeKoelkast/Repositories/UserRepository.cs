using System;
using SQLite;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DeKoelkast.MVVM.Models;
using System.Data.Common;


namespace DeKoelkast.Repositories
{
//    public class UserRepository
//    {
//        SQLiteConnection connection;

//        public string? statusMessage { get; set; }

//        public UserRepository()
//        {
//            connection = new SQLiteConnection(
//                Constants.DatabasePath,
//                Constants.flags);
//            connection.CreateTable<Users>();
//        }

//        public void AddOrUpdate(Users user)
//        {
//            int result = 0;
//            try
//            {


//                if (user.Id != 0)
//                {
//                    result = connection.Update(user);
//                    statusMessage = $"{result} row(s) updated";
//                }
//                else
//                {
//                    result = connection.Insert(user);
//                    statusMessage = $"{result} row(s) added";
//                }

//            }
//            catch (Exception ex)
//            {
//                statusMessage = $"Error: {ex.Message}";
//            }
//        }

//        public List<Users>? GetAll()
//        {
//            try
//            {
//                return connection.Table<Users>().ToList();
//            }
//            catch (Exception ex)
//            {
//                statusMessage = $"Error: {ex.Message}";
//            }
//            return null;
//        }

//        public Users? Get(int id)
//        {
//            try
//            {
//                return connection.Table<Users>().FirstOrDefault(x => x.Id == id);
//            }
//            catch (Exception ex)
//            {
//                statusMessage = $"Error: {ex.Message}";
//            }
//            return null;
//        }

//        public bool GetLogin(string userName, string passWord)
//        {
//            try
//            {
//                var result = connection.Table<Users>().FirstOrDefault(x => x.Username == userName && x.Password == passWord);
//                if (result == null) return false;
//            }
//            catch (Exception ex)
//            {
//                statusMessage = $"Error: {ex.Message}";
//                return false;
//            }
//            return true;
//        }

//        public void Delete(int userid)
//        {
//            try
//            {
//                Users user = Get(userid);
//                connection.Delete<Users>(userid);
//            }
//            catch (Exception ex)
//            {
//                statusMessage = $"Error: {ex.Message}";
//            }
//        }
//    }
}