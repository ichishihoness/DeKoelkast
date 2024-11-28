using SQLite;
using DeKoelkast.MVVM.Models;
using SQLitePCL;


namespace DeKoelkast
{
    public class UserRepository
    {
        SQLiteConnection connection;

        public string? statusMessage { get; set; }

        public UserRepository()
        {
            connection = new SQLiteConnection(
                Constants.DatabasePath, 
                Constants.flags);
            connection.CreateTable<Users>();
        }

        public void AddOrUpdate(Users username, string password)
        {
            int result = 0;
            try
            {


                if (username.Id != 0)
                {
                    result = connection.Update(username);
                    statusMessage = $"{result} row(s) updated";
                }
                else
                {
                    result = connection.Insert(username);
                    statusMessage = $"{result} row(s) added";
                }

            }
            catch (Exception ex)
            {
                statusMessage = $"Error: {ex.Message}";
            }
        }

        public List<Users>? GetAll()
        {
            try
            {
                return connection.Table<Users>().ToList();
            }
            catch (Exception ex)
            {
                statusMessage = $"Error: {ex.Message}";
            }
            return null;
        }

        public Users? Get(int id)
        {
            try
            {
                return connection.Table<Users>().FirstOrDefault(x => x.Id == id);
            }
            catch (Exception ex)
            {
                statusMessage = $"Error: {ex.Message}";
            }
            return null;
        }

        public void Delete(int userid)
        {
            try
            {
                Users user = Get(userid);
                connection.Delete<Users>(userid);
            }
            catch (Exception ex)
            {
                statusMessage = $"Error: {ex.Message}";
            }
        }
    }
}