using System.Runtime.InteropServices;
using DeKoelkast.Abstractions;
using SQLite;
using SQLitePCL;

namespace DeKoelkast.MVVM.Models
{
    [Table("Users")]
    public class Users : TableData
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        [Column("Username"), Indexed, NotNull]
        public string? Username { get; set; }

        [Column("Password"), NotNull]
        public string? Password { get; set; }

        [Column("Balance"), NotNull]
        public decimal Balance { get; set; }

        [Column("Authorized"), NotNull]
        public bool Authorized { get; set; } = false;
    }
}


