using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace HotelCaini_mobile.Models
{
    public class Review
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
    }
}
