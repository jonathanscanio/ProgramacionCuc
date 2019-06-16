using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingApp.src.Repositories
{
    abstract class GeneralRepository
    {
        protected SQLiteConnection connection;       


        public GeneralRepository()
        {
            string projectPath = Directory.GetCurrentDirectory().Replace("\\ParkingApp\\bin\\Debug", "");
            connection = new SQLiteConnection("Data Source=" + projectPath+ "\\ParkingLotDataBase.db;Version=3;");
        }




    }
}
