using System.Runtime.InteropServices;
using DeKoelkast.Abstractions;
using SQLite;
using SQLitePCL;

namespace DeKoelkast.MVVM.Models
{
    [Table("Products")]
    public class Products : TableData
    {
        public int UserId { get; set; }

        [Column("Productname"), Indexed, NotNull]
        public string? Productname { get; set; }

        [Column("Amount"), NotNull]
        public int? Amount { get; set; }

        [Column("Price"), NotNull]
        public decimal Price { get; set; }
    }
}