using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextAnalysisTool
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void open_btn_Click(object sender, EventArgs e)//allows user to open text file and load in into tree
        {

            OpenFileDialog ofd = new OpenFileDialog(); //create open file dialog
            ofd.Title = "Open Text File";
            ofd.Filter = "TXT files|*.txt";
            ofd.InitialDirectory = @"C:\";
            if (ofd.ShowDialog() == DialogResult.OK) //if file has been selected and is a txt file
            {
                try
                {
                    int lineNumber = 0;
                    int wordNumber = 0;
                    Global.GlobalWordTree = new AVLTree<Word>(); //reset tree, tree is global so can be used on all forms
                    word_listBox.Items.Clear(); //clear current list of words in GUI      
                    string path = ofd.FileName; //set path
                    string[] AllLines = File.ReadAllLines(path); //read in all lines of txt file

                    foreach (string line in AllLines) //for each line in text file
                    {
                        wordNumber = 0; //reset word number on each line
                        lineNumber++;
                        string[] words = line.Split(' ', ',', '.', '?', ';'); //split by whitepsace and puntuation
                        foreach (string w in words) //for each word in text file
                        {
                            if (w != "" && Global.GlobalWordTree.Contains(new Word(w.ToLower(), 0, null))) //if word is already in tree
                            {
                                wordNumber++;
                                Global.GlobalWordTree.Find(new Word(w.ToLower(), 0, null)).Data.Occurrences += 1; //increment occurrences
                                Global.GlobalWordTree.Find(new Word(w.ToLower(), 0, null)).Data.Locations.AddLast(new Location(lineNumber, wordNumber)); //add new Location to Locations list                          
                            }
                            else if (w != "")
                            {
                                wordNumber++;
                                LinkedList<Location> list = new LinkedList<Location>(); //create new locations list
                                list.AddLast(new Location(lineNumber, wordNumber)); //add first location
                                Global.GlobalWordTree.InsertItem(new Word(w.ToLower(), 1, list)); //insert word into tree
                            }
                        }
                    }
                    updateListBox(false);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error - " + ex.Message);
                }

            }

        }

        private void edit_btn_Click(object sender, EventArgs e)//brings up edit form and parses in selected word
        {
            try
            {
                string[] rawWord = word_listBox.SelectedItem.ToString().Split(' '); //removes occurence number if its displayed
                EditWordForm ewf = new EditWordForm(rawWord[0], this); //create instance of edit form and parse currently selected word in list box
                ewf.ShowDialog(); //show edit form 
            }
            catch (Exception)
            {
                MessageBox.Show("Error - Please select a word.");
            }
        }
        public void updateListBox(Boolean showOccurence) //displays contents of tree in listbox and updates number of unique words. Uses booleans for displaying occurence and displaying in alphabetical or reverse.
        {
            try
            {
                int uniqueWords = 0;
                word_listBox.Items.Clear();

                foreach (String word in getWordsInOrder()) //loop array and add each item to list box
                {
                    if (word != "")
                    {
                        if (showOccurence == true)
                        {
                            word_listBox.Items.Add(word + " " + Global.GlobalWordTree.Find(new Word(word, 0, null)).Data.Occurrences);
                        }
                        else if (showOccurence == false)
                        {
                            word_listBox.Items.Add(word);
                        }
                        uniqueWords += 1;
                        unique_txt.Text = uniqueWords.ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error - " + ex.Message);
            }

        }

        private void remove_btn_Click(object sender, EventArgs e)//removes a word from tree then updates GUI
        {
            try
            { 
                string[] rawWord = word_listBox.SelectedItem.ToString().Split(' '); //removes occurence number if its displayed
                Global.GlobalWordTree.removeItem(new Word(rawWord[0], 0, null)); //remove from tree
                updateListBox(false);
                updateSearch();
            }
            catch (Exception)
            {
                MessageBox.Show("Error - Please select a word.");
            }
        }

        private void concordance_btn_Click(object sender, EventArgs e)
        {
            updateListBox(true); //parses try so when the list updates it displays concordance too
        }

        private void search_txt_TextChanged(object sender, EventArgs e)//updates search results when search input changes
        {
            updateSearch();
        }

        public void updateSearch() //updates search results, used for if something changes elsewhere
        {
            try
            {
                if (search_txt.Text != "")//used to stop updates when nothing has been searched yet
                {
                    searchResults_listBox.Items.Clear();

                    foreach (String word in getWordsInOrder()) //checks each word to see if it contains string typed into the search
                    {
                        if (word != "")
                        {
                            if (word.Contains(search_txt.Text))
                            {
                                searchResults_listBox.Items.Add(word);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error - " + ex.Message);
            }
        }

        private void info_btn_Click(object sender, EventArgs e)//shows edit form for search portion
        {
            try
            {
                string[] rawWord = searchResults_listBox.SelectedItem.ToString().Split(' '); //removes occurence number if its displayed
                EditWordForm ewf = new EditWordForm(rawWord[0], this); //create instance of edit form and parse currently selected word in list box
                ewf.ShowDialog(); //show edit form  
            }
            catch (Exception)
            {
                MessageBox.Show("Error - Please select a word.");
            }
        }

        private void common_btn_Click(object sender, EventArgs e) //finds most common word
        {
            try
            {
                int tempOccurences = 0;
                int occurrenceOfWord = 0;
                String mostCommonWord = "";

                foreach (String word in getWordsInOrder())
                {
                    if (word != "")
                    {
                        occurrenceOfWord = Global.GlobalWordTree.Find(new Word(word, 0, null)).Data.Occurrences;
                        if (occurrenceOfWord > tempOccurences) //if current words occurences is greater than the currently stored occurences
                        {
                            tempOccurences = occurrenceOfWord;
                            mostCommonWord = Global.GlobalWordTree.Find(new Word(word, 0, null)).Data._Word;
                        }
                    }
                }
                word_listBox.Items.Clear();
                word_listBox.Items.Add(mostCommonWord + " " + Global.GlobalWordTree.Find(new Word(mostCommonWord, 0, null)).Data.Occurrences);
            }
            catch (Exception) { }
        }

        private void moreThan_btn_Click(object sender, EventArgs e) //find words that occur more than entered value
        {
            try
            {
                int result;
                if (int.TryParse(moreThan_txt.Text, out result))//integer validation
                {
                    word_listBox.Items.Clear();

                    int moreThan = result; //stores entered int

                    foreach (String word in getWordsInOrder())
                    {
                        if (word != "")
                        {
                            int occurrenceOfWord = Global.GlobalWordTree.Find(new Word(word, 0, null)).Data.Occurrences;
                            if (occurrenceOfWord > moreThan) //compare current word occurrences with entered int
                            {
                                word_listBox.Items.Add(word + " " + occurrenceOfWord);
                            }
                        }
                    }
                }
                else //if input cannot be parsed as int
                {
                    System.Windows.Forms.MessageBox.Show("Error - Please enter a valid integer and try again.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error - " + ex.Message);
            }
        }

        private void display_btn_Click(object sender, EventArgs e)//outputs words  by decreasing order of occurrence
        {
            try
            {
                Dictionary<string, int> wordDictionary = new Dictionary<string, int>(); //dictionary to store words and occurrences

                foreach (String word in getWordsInOrder())
                {
                    if (word != "")
                    {
                        wordDictionary.Add(word, Global.GlobalWordTree.Find(new Word(word, 0, null)).Data.Occurrences); //add each word and occurrence to dictionary
                    }
                }

                word_listBox.Items.Clear();
                foreach (KeyValuePair<string, int> pair in wordDictionary.OrderByDescending(key => key.Value)) //loop through in decending order
                {
                    word_listBox.Items.Add(pair.Key + " " + pair.Value);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error - " + ex.Message);
            }
        }

        private void collocation_btn_Click(object sender, EventArgs e)//display collocation between 2 words
        {
            int collocationCount = 0;
            try
            {
                string word1 = collocationIn1_txt.Text.ToLower();
                string word2 = collocationIn2_txt.Text.ToLower();
                Console.WriteLine(word1);
                Console.WriteLine(word2);

                if (IsValidWord(word1) && IsValidWord(word2)) //word validation
                {
                    
                    foreach (Location word1Location in Global.GlobalWordTree.Find(new Word(word1, 0, null)).Data.Locations)//loops each location in first word
                    {
                        foreach (Location word2Locations in Global.GlobalWordTree.Find(new Word(word2, 0, null)).Data.Locations)//loops each location in second word
                        {
                            if (word1Location.Line == word2Locations.Line)//if the 2 words are on the same line
                            {
                                if (word1Location.Position == word2Locations.Position - 1)//if word to is in the position 1 after word 1
                                {
                                    collocationCount += 1;
                                }
                            }
                        }
                    }
                    collocationOut_txt.Text = collocationCount.ToString();//display results
                }
                else //if word is not valid
                {
                    System.Windows.Forms.MessageBox.Show("Error - Please enter a valid words and try again.");
                }
            }
            catch (Exception) {
                collocationCount = 0;
                collocationOut_txt.Text = collocationCount.ToString();
            }
        }

        private string[] getWordsInOrder() { //returns array of words in tree after performing inOrder search, used to reduce code
            String buffer = "";
            Global.GlobalWordTree.InOrder(ref buffer);
            string[] words = buffer.Split(',');
            return words;
        }

        public bool IsValidWord(string word) //validate parsed word
        {
            return word.Length >= 1 && word.Length <= 45; //shortest english word is 1 letter, longest is 45 letters
        }

        private void help_btn_Click(object sender, EventArgs e)
        {
            HelpForm helpForm = new HelpForm(); 
            helpForm.ShowDialog(); 
        }
    }
}
