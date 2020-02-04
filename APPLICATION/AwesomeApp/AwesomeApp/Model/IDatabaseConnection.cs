using System;
using System.Collections.Generic;
using System.IO;
using SQLite;
using System.Text;
using LocalDataAccess.Droid;
using AwesomeApp.Model;

[assembly: Xamarin.Forms.Dependency(typeof(DatabaseConnection_Android))]



namespace AwesomeApp.Model
{
    interface IDatabaseConnection
    {
        SQLite.SQLiteConnection DbConnection();
    }
}




namespace LocalDataAccess.Droid
{
    public class DatabaseConnection_Android : IDatabaseConnection
    {

        public SQLiteConnection DbConnection()
        {
            var dbName = "PhotoBoothProject_2020.db3";
            var path = Path.Combine(System.Environment.
              GetFolderPath(System.Environment.
              SpecialFolder.Personal), dbName);
            return new SQLiteConnection(path);
        }
    }

    public class Compte
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string email { get; set; }
        public int password { get; set; }

    }
}




