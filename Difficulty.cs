using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prelab_1
{
    public class Difficulty
    {
        private int diff=0;
        private int X=1;
        private int Y=1;

        public int Diff
        {
            get { return diff; }
            set { diff = value; }
        }

        public int x
        {
            get { return X; }
            set { X = value; }
        }

        public int y
        {
            get { return Y; }
            set { Y = value; }
        }
    }
}
