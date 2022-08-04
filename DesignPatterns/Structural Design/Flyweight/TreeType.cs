using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight
{
    // The flyweight class contains a portion of the state of a
    // tree. These fields store values that are unique for each
    // particular tree. For instance, you won't find here the tree
    // coordinates. But the texture and colors shared between many
    // trees are here. Since this data is usually BIG, you'd waste a
    // lot of memory by keeping it in each tree object. Instead, we
    // can extract texture, color and other repeating data into a
    // separate object which lots of individual tree objects can
    // reference.
    public class TreeType
    {
        public string name;
        public string color;
        public string texture;

        public TreeType(string name, string color, string texture)
        {
            this.name = name;
            this.color = color;
            this.texture = texture;
        }

        public void Draw(int x, int y)
        {
            Console.WriteLine($"Draw the {color} tree: {name} on the ({x}, {y}) coords");
        }
    }

    // Flyweight factory decides whether to re-use existing
    // flyweight or to create a new object.
    public class TreeFactory
    {
        //Collection of tree types
        public static List<TreeType> treeTypes = new List<TreeType>();

        public static TreeType GetTreeType(string name, string color, string texture)
        {
            var type = treeTypes.Find(x => x.name == name && x.color == color && x.texture == texture);

            if(type == null)
            {
                type = new TreeType(name, color, texture);
                treeTypes.Add(type);
            }

            return type;
        }
    }
}
