namespace DeKoelkast
{
	public static class Constants
	{
		private const string DBFileName = "SQLiteKoelkast.db";



		public static string DatabasePath
		{
			get
			{
				return Path.Combine(FileSystem.AppDataDirectory, DBFileName);
			}
		}
	}
}