using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    //Use the Singleton pattern when a class in your
    //program should have just a single instance
    //available to all clients.
    public static class Main_Singleton
    {
        private static Database _databaseA;
        private static Database _databaseB;

        public static void Init()
        {
            _databaseA = Database.Instance;
            _databaseA.Query("SELECT * FROM tableA");
            _databaseA.NumberOfTimesDatabaseCalled();

            _databaseB = Database.Instance;
            _databaseB.Query("SELECT * FROM tableB");
            _databaseB.NumberOfTimesDatabaseCalled();
        }
    }
}
