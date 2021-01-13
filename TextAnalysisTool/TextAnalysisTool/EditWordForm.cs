using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextAnalysisTool
{
    public partial class EditWordForm : Form
    {

        private String selectedWord;
        private Form1 mainForm;
        public EditWordForm(String selectedWord, Form1 mainForm)
        {
            InitializeComponent();
            this.selectedWord = selectedWord;
            this.mainForm = mainForm;
            String line = "";
            String position = "";
            foreach (var location in Global.GlobalWordTree.Find(new Word(selectedWord, 0, null)).Data.Locations) //iterate through each item in locations list
            {
                line += (location.Line + " ");
                position += (location.Position + " ");
            }

            //set all text boxes with correct values from tree, depends on selected item from parsed in list box
            this.word_txt.Text = Global.GlobalWordTree.Find(new Word(selectedWord, 0, null)).Data._Word;
            this.occ_txt.Text = Global.GlobalWordTree.Find(new Word(selectedWord, 0, null)).Data.Occurrences.ToString();
            this.line_txt.Text = line;
            this.pos_txt.Text = position;
        }

        private void save_btn_Click(object sender, EventArgs e)
        {
            try
            {
                LinkedList<Location> updatedLocationList = new LinkedList<Location>(); //create new locations list for to overwrite stored one

                //split into seperate values
                string[] lines = this.line_txt.Text.Split(' ', ',', '.', '?', ';');
                string[] positions = this.pos_txt.Text.Split(' ', ',', '.', '?', ';');

                int result;
                if ((lines.Length == positions.Length)&&(mainForm.IsValidWord(this.word_txt.Text))&&(int.TryParse(this.occ_txt.Text, out result)))//validation
                {

                    //iterate through each value of lines
                    for (int i = 0; i < lines.Length; i++)
                    {
                        if (lines[i] != "" && positions[i] != "") //check line and pos not empty
                        {
                            Location updateLocation = new Location(int.Parse(lines[i]), int.Parse(positions[i])); //create new location
                            updatedLocationList.AddLast(updateLocation); //add location to updated list
                        }
                    }

                    Global.GlobalWordTree.removeItem(new Word(selectedWord, 0, null)); //remove old word
                    Global.GlobalWordTree.InsertItem(new Word(this.word_txt.Text, result, updatedLocationList)); //insert updated word

                    mainForm.updateListBox(false);
                    mainForm.updateSearch();
                    this.Close(); //close edit form
                }
                else if(!(lines.Length == positions.Length))
                {
                    MessageBox.Show("Error - Please enter ensure there are the same quantity of lines as there is positions.");
                }
                else if (!(mainForm.IsValidWord(this.word_txt.Text)))
                {
                    MessageBox.Show("Error - Please enter a valid word.");
                }
                else if (!(int.TryParse(this.occ_txt.Text, out result)))
                {
                    MessageBox.Show("Error - Please enter integer.");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error - Please enter valid values.");
            }
        }
    }
}
