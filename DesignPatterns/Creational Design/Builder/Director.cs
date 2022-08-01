using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    /// <summary>
    /// The Director class is only responsible for executing the building steps
    /// in a particular sequence. It's helpful when producing products
    /// according to a specific order of configuration. Strictly speaking,
    /// the director class is optional, since the client can control builders directly
    /// </summary>
    public class Director
    {
        private IBuilder? _builder;

        public void SetBuilder(IBuilder builder)
        {
            _builder = builder;
        }

        public void ConstructSportsCar(IBuilder builder, string name)
        {
            builder.Reset();
            builder.SetName(name);
            builder.SetSeats(2);
            builder.SetEngine("GTR X Engine");
            builder.SetGPS(false);
        }

        public void ConstructSUV(IBuilder builder, string name)
        {
            builder.Reset();
            builder.SetName(name);
            builder.SetSeats(4);
            builder.SetEngine("Honda Engine");
            builder.SetGPS(true);
        }
    }
}
