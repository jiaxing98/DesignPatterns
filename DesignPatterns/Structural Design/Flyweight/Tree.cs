using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight
{
    // The contextual object contains the extrinsic part of the tree
    // state. An application can create billions of these since they
    // are pretty small: just two integer coordinates and one
    // reference field.
    public class Tree
    {
        public int x, y;
        public TreeType type;

        public Tree(int x, int y, TreeType type)
        {
            this.x = x;
            this.y = y;
            this.type = type;
        }

        public void Draw()
        {
            type.Draw(x, y);
        }
    }

    // The Tree and the Forest classes are the flyweight's clients.
    // You can merge them if you don't plan to develop the Tree
    // class any further.
    public class Forest
    {
        public List<Tree> trees = new List<Tree> ();

        public void plantTree(int x, int y, string name, string color, string texture)
        {
            var type = TreeFactory.GetTreeType(name , color, texture);
            var tree = new Tree(x, y, type);
            trees.Add(tree);
        }

        public void Draw()
        {
            foreach (var item in trees)
                item.Draw();
        }
    }
}
