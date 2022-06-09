using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace AppConversionDesKMSFinale.Modèles
{
    public class User
    {
        [PrimaryKey, AutoIncrement]
        public string Username { get; set; }
        public string Password { get; set; }
        public string PhotoPath { get; set; }
    }
}
