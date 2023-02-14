using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace MobileApp.Models
{
    public class BakeryShop
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        [MaxLength(250), Unique]
        public string Description { get; set; }
        public string ShopName { get; set; }
        public string Adress { get; set; }
    }
}
