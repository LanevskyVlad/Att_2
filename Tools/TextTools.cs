using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tools
{
    public  class TextTools
    {
        public List<string> TextA { get; set; }
        public List<string> TextB { get; set; }
        private BinTreeSearch BinTree;
        public TextTools(List<string> textA, List<string> textB)
        {
            TextA = textA;
            TextB = textB;
        }
        public List<string> GetTextC()
        {
            BinTree = new BinTreeSearch();
            for (int i = 0; i < TextB.Count; i++)
                BinTree.Add(TextB[i]);
            List<string> TextC = new List<string>();
            for (int i = 0; i < TextA.Count; i++)
                if (!BinTree.Contains(TextA[i]))
                    TextC.Add(TextA[i]);
            return TextC;
        }
    }
}
