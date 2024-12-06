using System.Runtime.InteropServices;
using DeKoelkast.Abstractions;
using Newtonsoft.Json.Serialization;
using SQLite;
using SQLiteNetExtensions.Attributes;
using SQLitePCL;

namespace DeKoelkast.MVVM.Models
{
    [Table("Products")]
    public class Products : TableData
    {
        [ForeignKey(typeof(Users))]
        public int UserId { get; set; }

        [Column("Productname"), Indexed, NotNull]
        public string? Productname { get; set; }

        [Column("Amount"), NotNull]
        public string? Amount { get; set; }

        [Column("Price"), NotNull]
        public string Price { get; set; }

        [Column("Icon"), NotNull]
        public string Icon { get; set; }
    }
}