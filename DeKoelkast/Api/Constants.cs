using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace DeKoelkast.Api
{
    public class Constants
    {
        public const string API_URL_TRUTH = "https://api.truthordarebot.xyz/v1/truth";
        private const string DBFileName = "TODDatabase";
        public const SQLiteOpenFlags flags =
                        SQLiteOpenFlags.ReadWrite |
                        SQLiteOpenFlags.Create |
                        SQLiteOpenFlags.SharedCache;
        public static string DatabasePath
        {
            get
            {
                return Path.Combine(FileSystem.AppDataDirectory, DBFileName);
            }
        }
    }
}