using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextAnalysisTool
{
    class Word : IComparable
    {
        private String _word; //underscore is used so no confliction with class name
        private int occurrences;
        private LinkedList<Location> locations;

        public Word(String word, int occurrences, LinkedList<Location> locations)
        {
            this._word = word;
            this.occurrences = occurrences;
            this.locations = locations;
        }
        
        public String _Word 
        {
            set { _word = value; }
            get { return _word; } 
        }

        public int Occurrences
        {
            set { occurrences = value; }
            get { return occurrences; }
        }

        public LinkedList<Location> Locations
        {
            set { locations = value; }
            get { return locations; }
        }
    
        public int CompareTo(object obj) //compares word (actual value, string) with parsed in obj, ovveride method
        {
            Word w = obj as Word;
            if (w != null)
                return this._Word.CompareTo(w._Word);
            else
                throw new ArgumentException("Object is not a Word");
        }

        public override string ToString() //ovveride tostring to return word (actual value, string)
        {
            return this._Word;
        }
    }
}
