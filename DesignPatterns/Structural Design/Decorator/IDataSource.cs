using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public interface IDataSource
    {
        void readData();
        void writeData(string data);
    }

    public class FileDataSource : IDataSource
    {
        private string _fileName;
        private string _data = "";

        public FileDataSource(string fileName)
        {
            _fileName = fileName;
        }

        public void readData()
        {
            Console.WriteLine($"Reading from file {_fileName}, data: {_data}");
        }

        public void writeData(string data)
        {
            _data = data;
            Console.WriteLine($"Writing data: {data} to file {_fileName}");
        }
    }
}
