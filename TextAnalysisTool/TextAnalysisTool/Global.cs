using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextAnalysisTool
{
    static class Global
    {
        private static AVLTree<Word> wordTree = new AVLTree<Word>();

        public static AVLTree<Word> GlobalWordTree
        {
            get { return wordTree; }
            set { wordTree = value; }
        }
    }
}
