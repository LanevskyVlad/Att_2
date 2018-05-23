using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tools
{
    public class BinTreeSearch
    {
        private Node Root;
        public void Add(String str)
        {
            if (Root == null)
                Root = new Node(str);
            else
                Root.Add(str);
        }
        public bool Contains(string str) => Root == null ? false : Root.Contains(str);
        class Node
        {
            public string Value { get; set; }
            public Node Left { get; set; }
            public Node Right { get; set; }
            public void Add(string str)
            {
                switch (str.CompareTo(Value))
                {
                    case -1:
                        if (Left == null)
                            Left = new Node(str);
                        else
                            Left.Add(str);
                        break;
                    case 1:
                        if (Right == null)
                            Right = new Node(str);
                        else
                            Right.Add(str);
                        break;
                }
            }
            public bool Contains(string str)
            {
                switch (str.CompareTo(Value))
                {
                    case 0:
                        return true;
                    case -1:
                        if (Left == null)
                            return false;
                        else
                            return Left.Contains(str);
                    case 1:
                        if (Right == null)
                            return false;
                        else
                            return Right.Contains(str);
                    default:
                        return false;
                }
            }

            public Node(string value)
            {
                Value = value;
            }
        }
    }
}
