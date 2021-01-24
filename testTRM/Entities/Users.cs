using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using SQLite;
//using SQLiteNetExtensions.Extensions;

namespace testTRM.Entities
{
    [Table("users")]
    public class User
    {
        [PrimaryKey, AutoIncrement]
        public int id_user { get; set; }

        public string username { get; set; }

        public string password { get; set; }

        public string email { get; set; }

        public string birthday { get; set; }

        public override string ToString()
        {
            return $"[Username ID: Id={id_user}, Username={username}, Password={password}, Email={email}, Birthday={birthday}]";
        }
    }
}