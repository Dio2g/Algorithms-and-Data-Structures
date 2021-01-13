using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextAnalysisTool
{
    class Location
    {
        private int line;
        private int position;

        public Location(int line, int position) {
            this.line = line;
            this.position = position;
        }

        public int Line
        {
            set { line = value; }
            get { return line; }
        }

        public int Position
        {
            set { position = value; }
            get { return position; }
        }
    }
}
