using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    //Use the Decorator pattern when you need to be able to assign
    //extra behaviors to objects at runtime without breaking the
    //code that uses these objects.

    //Use the pattern when it’s awkward or not possible to extend
    //an object’s behavior using inheritance.

    public static class Main_Decorator
    {
        public static SalaryManager manager;
        public static IDataSource source;
        public static void Init()
        {
            Configuration(false, false);
            manager = new SalaryManager(source);
            manager.Load();

            Console.WriteLine("--- <Encyption> ---");
            Configuration(true, false);
            manager = new SalaryManager(source);
            manager.Load();

            Console.WriteLine("--- <Compression> ---");
            Configuration(false, true);
            manager = new SalaryManager(source);
            manager.Load();
        }

        private static void Configuration(bool enabledEncryption, bool enabledCompression)
        {
            source = new FileDataSource("salary.dat");
            if(!enabledEncryption && !enabledCompression) 
                source.writeData("Hello World");

            if (enabledEncryption)
            {
                source = new EncryptionDecorator(source);
                source.writeData("E_Hello_World");
            }

            if (enabledCompression)
            {
                source = new CompressionDecorator(source);
                source.writeData("C_Hello_World");
            }
        }
    }

    public class SalaryManager
    {
        private IDataSource _source;

        public SalaryManager(IDataSource source)
        {
            _source = source;
        }

        public void Save()
        {
            _source.writeData("Hello World");
        }

        public void Load()
        {
            _source.readData();
        }
    }
}
