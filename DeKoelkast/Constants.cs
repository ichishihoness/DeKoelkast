using SQLite;
using System.IO;
using Microsoft.Maui.Storage;
using SQLitePCL;

namespace DeKoelkast
{
	public static class Constants
	{
		private const string DBFileName = "SQLiteKoelkast.db";

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