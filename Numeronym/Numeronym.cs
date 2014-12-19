using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumeronymCreator
{
    public class NumeronymBuilder
    {
        private List<Char> word = new List<Char>();

        public void Append(Char ch) { word.Add(ch); }

        public bool IsEmpty() { return word.Count == 0; }

        public void Clear() { word.Clear(); }

        public override String ToString()
        {
            if (word.Count == 0) return "";

            int count = (word.Count <= 2) ? 0 : word.GetRange(1, word.Count-2).Distinct().Count();

            return word[0].ToString() + count.ToString() + word[word.Count-1].ToString();
        }
    }
}
