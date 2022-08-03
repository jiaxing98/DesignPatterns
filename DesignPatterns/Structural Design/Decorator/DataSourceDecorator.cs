using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    // The base decorator class follows the same interface as the
    // other components. The primary purpose of this class is to
    // define the wrapping interface for all concrete decorators.
    // The default implementation of the wrapping code might include
    // a field for storing a wrapped component and the means to
    // initialize it.
    public class DataSourceDecorator : IDataSource
    {
        protected IDataSource wrappee;

        public DataSourceDecorator(IDataSource source)
        {
            wrappee = source;
        }

        // Concrete decorators may call the parent implementation of
        // the operation instead of calling the wrapped object
        // directly. This approach simplifies extension of decorator
        // classes.
        public virtual void readData()
        {
            wrappee.readData();
        }

        // The base decorator simply delegates all work to the
        // wrapped component. Extra behaviors can be added in
        // concrete decorators.
        public virtual void writeData(string data)
        {
            wrappee.writeData(data);
        }
    }

    // Concrete decorators must call methods on the wrapped object,
    // but may add something of their own to the result. Decorators
    // can execute the added behavior either before or after the
    // call to a wrapped object.
    public class EncryptionDecorator : DataSourceDecorator
    {
        public EncryptionDecorator(IDataSource source) : base(source) { }

        public override void readData()
        {
            Console.WriteLine("Decrypting the data...");
            wrappee.readData();
        }

        public override void writeData(string data)
        {
            Console.WriteLine("Encrypting the data...");
            wrappee.writeData(data);
        }
    }

    public class CompressionDecorator : DataSourceDecorator
    {
        public CompressionDecorator(IDataSource source) : base(source) { }

        public override void readData()
        {
            Console.WriteLine("Decompressing the data...");
            wrappee.readData();
        }

        public override void writeData(string data)
        {
            Console.WriteLine("Compressing the data...");
            wrappee.writeData(data);
        }
    }
}
