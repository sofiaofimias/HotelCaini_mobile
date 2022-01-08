using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace HotelCaini_mobile.Tables
{
    class RegUserTable
    {
        [PrimaryKey, AutoIncrement]
        public int UserID { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }

    }
}
