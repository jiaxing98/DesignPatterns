using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public class Database
    {
        private static Database _instance;
        private static readonly object threadLock = new object();

        private int _count;

        public static Database Instance { 
            get
            {
                if (_instance == null)
                {
                    //Ensure that the instance hasn't yet been
                    //initialized by another thread while this one
                    //has been waiting for the lock's release.
                    lock(threadLock)
                    {
                        if(_instance == null) 
                            _instance = new Database();
                    }
                }
                return _instance;
            }
        }

        //The singleton's constructor should always ne private to
        //prevent direct construction calls with the 'new' keyword
        private Database()
        {
            //Some initialization code, such as the
            //actual connection to a database server
        }
    
        public void Query(string sql)
        {
            Console.WriteLine($"The SQL Query is {sql}.");
            _count += 1;
        }

        public void NumberOfTimesDatabaseCalled()
        {
            Console.WriteLine($"Number of Times Database Called: {_count}.");
        }
    }
}
