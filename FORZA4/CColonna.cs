using System.Collections.Generic;

namespace FORZA4
{
    internal class CColonna
    {
        private int x;
        public List<CPannello> pannelliColonna = new List<CPannello>();

        public CColonna(int X)
        {
            x = X;
            for (int i = 0; i < 6; i++)
            {
                CPannello pannello = new CPannello(x, i);
                pannelliColonna.Add(pannello);
            }
        }
    }
}