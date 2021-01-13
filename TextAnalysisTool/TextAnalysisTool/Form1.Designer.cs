namespace TextAnalysisTool
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.open_btn = new System.Windows.Forms.Button();
            this.word_listBox = new System.Windows.Forms.ListBox();
            this.edit_btn = new System.Windows.Forms.Button();
            this.remove_btn = new System.Windows.Forms.Button();
            this.display_btn = new System.Windows.Forms.Button();
            this.common_btn = new System.Windows.Forms.Button();
            this.moreThan_btn = new System.Windows.Forms.Button();
            this.concordance_btn = new System.Windows.Forms.Button();
            this.info_btn = new System.Windows.Forms.Button();
            this.collocation_btn = new System.Windows.Forms.Button();
            this.moreThan_txt = new System.Windows.Forms.TextBox();
            this.collocationIn2_txt = new System.Windows.Forms.TextBox();
            this.search_txt = new System.Windows.Forms.TextBox();
            this.searchResults_listBox = new System.Windows.Forms.ListBox();
            this.unique_txt = new System.Windows.Forms.TextBox();
            this.unique_lbl = new System.Windows.Forms.Label();
            this.search_lbl = new System.Windows.Forms.Label();
            this.collocationOut_txt = new System.Windows.Forms.TextBox();
            this.collocationIn1_txt = new System.Windows.Forms.TextBox();
            this.word1_lbl = new System.Windows.Forms.Label();
            this.word2_lbl = new System.Windows.Forms.Label();
            this.col_lbl = new System.Windows.Forms.Label();
            this.col_panel = new System.Windows.Forms.Panel();
            this.search_panel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.help_btn = new System.Windows.Forms.Button();
            this.col_panel.SuspendLayout();
            this.search_panel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // open_btn
            // 
            this.open_btn.Location = new System.Drawing.Point(10, 12);
            this.open_btn.Name = "open_btn";
            this.open_btn.Size = new System.Drawing.Size(75, 23);
            this.open_btn.TabIndex = 1;
            this.open_btn.Text = "Open File";
            this.open_btn.UseVisualStyleBackColor = true;
            this.open_btn.Click += new System.EventHandler(this.open_btn_Click);
            // 
            // word_listBox
            // 
            this.word_listBox.FormattingEnabled = true;
            this.word_listBox.Location = new System.Drawing.Point(12, 12);
            this.word_listBox.Name = "word_listBox";
            this.word_listBox.Size = new System.Drawing.Size(205, 290);
            this.word_listBox.TabIndex = 2;
            // 
            // edit_btn
            // 
            this.edit_btn.Location = new System.Drawing.Point(10, 38);
            this.edit_btn.Name = "edit_btn";
            this.edit_btn.Size = new System.Drawing.Size(75, 23);
            this.edit_btn.TabIndex = 3;
            this.edit_btn.Text = "Edit";
            this.edit_btn.UseVisualStyleBackColor = true;
            this.edit_btn.Click += new System.EventHandler(this.edit_btn_Click);
            // 
            // remove_btn
            // 
            this.remove_btn.Location = new System.Drawing.Point(10, 67);
            this.remove_btn.Name = "remove_btn";
            this.remove_btn.Size = new System.Drawing.Size(75, 23);
            this.remove_btn.TabIndex = 4;
            this.remove_btn.Text = "Remove";
            this.remove_btn.UseVisualStyleBackColor = true;
            this.remove_btn.Click += new System.EventHandler(this.remove_btn_Click);
            // 
            // display_btn
            // 
            this.display_btn.Location = new System.Drawing.Point(10, 96);
            this.display_btn.Name = "display_btn";
            this.display_btn.Size = new System.Drawing.Size(146, 23);
            this.display_btn.TabIndex = 5;
            this.display_btn.Text = "Display (Decreasing Order)";
            this.display_btn.UseVisualStyleBackColor = true;
            this.display_btn.Click += new System.EventHandler(this.display_btn_Click);
            // 
            // common_btn
            // 
            this.common_btn.Location = new System.Drawing.Point(10, 125);
            this.common_btn.Name = "common_btn";
            this.common_btn.Size = new System.Drawing.Size(146, 23);
            this.common_btn.TabIndex = 6;
            this.common_btn.Text = "Display Most Common";
            this.common_btn.UseVisualStyleBackColor = true;
            this.common_btn.Click += new System.EventHandler(this.common_btn_Click);
            // 
            // moreThan_btn
            // 
            this.moreThan_btn.Location = new System.Drawing.Point(10, 183);
            this.moreThan_btn.Name = "moreThan_btn";
            this.moreThan_btn.Size = new System.Drawing.Size(118, 23);
            this.moreThan_btn.TabIndex = 7;
            this.moreThan_btn.Text = "Occur More Than: ";
            this.moreThan_btn.UseVisualStyleBackColor = true;
            this.moreThan_btn.Click += new System.EventHandler(this.moreThan_btn_Click);
            // 
            // concordance_btn
            // 
            this.concordance_btn.Location = new System.Drawing.Point(10, 154);
            this.concordance_btn.Name = "concordance_btn";
            this.concordance_btn.Size = new System.Drawing.Size(146, 23);
            this.concordance_btn.TabIndex = 8;
            this.concordance_btn.Text = "Display Concordance";
            this.concordance_btn.UseVisualStyleBackColor = true;
            this.concordance_btn.Click += new System.EventHandler(this.concordance_btn_Click);
            // 
            // info_btn
            // 
            this.info_btn.Location = new System.Drawing.Point(163, 19);
            this.info_btn.Name = "info_btn";
            this.info_btn.Size = new System.Drawing.Size(75, 23);
            this.info_btn.TabIndex = 9;
            this.info_btn.Text = "Edit";
            this.info_btn.UseVisualStyleBackColor = true;
            this.info_btn.Click += new System.EventHandler(this.info_btn_Click);
            // 
            // collocation_btn
            // 
            this.collocation_btn.Location = new System.Drawing.Point(8, 72);
            this.collocation_btn.Name = "collocation_btn";
            this.collocation_btn.Size = new System.Drawing.Size(111, 23);
            this.collocation_btn.TabIndex = 10;
            this.collocation_btn.Text = "Find Collocation";
            this.collocation_btn.UseVisualStyleBackColor = true;
            this.collocation_btn.Click += new System.EventHandler(this.collocation_btn_Click);
            // 
            // moreThan_txt
            // 
            this.moreThan_txt.Location = new System.Drawing.Point(134, 184);
            this.moreThan_txt.Name = "moreThan_txt";
            this.moreThan_txt.Size = new System.Drawing.Size(100, 20);
            this.moreThan_txt.TabIndex = 11;
            // 
            // collocationIn2_txt
            // 
            this.collocationIn2_txt.Location = new System.Drawing.Point(89, 45);
            this.collocationIn2_txt.Name = "collocationIn2_txt";
            this.collocationIn2_txt.Size = new System.Drawing.Size(123, 20);
            this.collocationIn2_txt.TabIndex = 12;
            // 
            // search_txt
            // 
            this.search_txt.Location = new System.Drawing.Point(10, 21);
            this.search_txt.Name = "search_txt";
            this.search_txt.Size = new System.Drawing.Size(100, 20);
            this.search_txt.TabIndex = 13;
            this.search_txt.TextChanged += new System.EventHandler(this.search_txt_TextChanged);
            // 
            // searchResults_listBox
            // 
            this.searchResults_listBox.FormattingEnabled = true;
            this.searchResults_listBox.Location = new System.Drawing.Point(10, 47);
            this.searchResults_listBox.Name = "searchResults_listBox";
            this.searchResults_listBox.Size = new System.Drawing.Size(228, 121);
            this.searchResults_listBox.TabIndex = 14;
            // 
            // unique_txt
            // 
            this.unique_txt.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.unique_txt.Location = new System.Drawing.Point(10, 27);
            this.unique_txt.Name = "unique_txt";
            this.unique_txt.ReadOnly = true;
            this.unique_txt.Size = new System.Drawing.Size(97, 20);
            this.unique_txt.TabIndex = 15;
            // 
            // unique_lbl
            // 
            this.unique_lbl.AutoSize = true;
            this.unique_lbl.Location = new System.Drawing.Point(7, 11);
            this.unique_lbl.Name = "unique_lbl";
            this.unique_lbl.Size = new System.Drawing.Size(78, 13);
            this.unique_lbl.TabIndex = 16;
            this.unique_lbl.Text = "Unique Words:";
            // 
            // search_lbl
            // 
            this.search_lbl.AutoSize = true;
            this.search_lbl.Location = new System.Drawing.Point(11, 5);
            this.search_lbl.Name = "search_lbl";
            this.search_lbl.Size = new System.Drawing.Size(41, 13);
            this.search_lbl.TabIndex = 17;
            this.search_lbl.Text = "Search";
            // 
            // collocationOut_txt
            // 
            this.collocationOut_txt.Location = new System.Drawing.Point(196, 72);
            this.collocationOut_txt.Name = "collocationOut_txt";
            this.collocationOut_txt.ReadOnly = true;
            this.collocationOut_txt.Size = new System.Drawing.Size(42, 20);
            this.collocationOut_txt.TabIndex = 18;
            this.collocationOut_txt.Text = "0";
            // 
            // collocationIn1_txt
            // 
            this.collocationIn1_txt.Location = new System.Drawing.Point(89, 18);
            this.collocationIn1_txt.Name = "collocationIn1_txt";
            this.collocationIn1_txt.Size = new System.Drawing.Size(123, 20);
            this.collocationIn1_txt.TabIndex = 19;
            // 
            // word1_lbl
            // 
            this.word1_lbl.AutoSize = true;
            this.word1_lbl.Location = new System.Drawing.Point(7, 22);
            this.word1_lbl.Name = "word1_lbl";
            this.word1_lbl.Size = new System.Drawing.Size(76, 13);
            this.word1_lbl.TabIndex = 20;
            this.word1_lbl.Text = "Enter Word 1: ";
            // 
            // word2_lbl
            // 
            this.word2_lbl.AutoSize = true;
            this.word2_lbl.Location = new System.Drawing.Point(7, 48);
            this.word2_lbl.Name = "word2_lbl";
            this.word2_lbl.Size = new System.Drawing.Size(76, 13);
            this.word2_lbl.TabIndex = 21;
            this.word2_lbl.Text = "Enter Word 2: ";
            // 
            // col_lbl
            // 
            this.col_lbl.AutoSize = true;
            this.col_lbl.Location = new System.Drawing.Point(125, 77);
            this.col_lbl.Name = "col_lbl";
            this.col_lbl.Size = new System.Drawing.Size(65, 13);
            this.col_lbl.TabIndex = 22;
            this.col_lbl.Text = "Collocation: ";
            // 
            // col_panel
            // 
            this.col_panel.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.col_panel.Controls.Add(this.collocationOut_txt);
            this.col_panel.Controls.Add(this.collocationIn1_txt);
            this.col_panel.Controls.Add(this.word1_lbl);
            this.col_panel.Controls.Add(this.word2_lbl);
            this.col_panel.Controls.Add(this.col_lbl);
            this.col_panel.Controls.Add(this.collocation_btn);
            this.col_panel.Controls.Add(this.collocationIn2_txt);
            this.col_panel.Location = new System.Drawing.Point(498, 195);
            this.col_panel.Name = "col_panel";
            this.col_panel.Size = new System.Drawing.Size(249, 104);
            this.col_panel.TabIndex = 23;
            // 
            // search_panel
            // 
            this.search_panel.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.search_panel.Controls.Add(this.search_txt);
            this.search_panel.Controls.Add(this.search_lbl);
            this.search_panel.Controls.Add(this.info_btn);
            this.search_panel.Controls.Add(this.searchResults_listBox);
            this.search_panel.Location = new System.Drawing.Point(498, 12);
            this.search_panel.Name = "search_panel";
            this.search_panel.Size = new System.Drawing.Size(249, 177);
            this.search_panel.TabIndex = 24;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.Controls.Add(this.unique_lbl);
            this.panel1.Controls.Add(this.unique_txt);
            this.panel1.Location = new System.Drawing.Point(232, 235);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(251, 65);
            this.panel1.TabIndex = 25;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel2.Controls.Add(this.moreThan_btn);
            this.panel2.Controls.Add(this.concordance_btn);
            this.panel2.Controls.Add(this.edit_btn);
            this.panel2.Controls.Add(this.open_btn);
            this.panel2.Controls.Add(this.remove_btn);
            this.panel2.Controls.Add(this.display_btn);
            this.panel2.Controls.Add(this.common_btn);
            this.panel2.Controls.Add(this.moreThan_txt);
            this.panel2.Location = new System.Drawing.Point(232, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(251, 217);
            this.panel2.TabIndex = 26;
            // 
            // help_btn
            // 
            this.help_btn.Location = new System.Drawing.Point(661, 311);
            this.help_btn.Name = "help_btn";
            this.help_btn.Size = new System.Drawing.Size(87, 23);
            this.help_btn.TabIndex = 12;
            this.help_btn.Text = "HELP";
            this.help_btn.UseVisualStyleBackColor = true;
            this.help_btn.Click += new System.EventHandler(this.help_btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(759, 346);
            this.Controls.Add(this.help_btn);
            this.Controls.Add(this.word_listBox);
            this.Controls.Add(this.col_panel);
            this.Controls.Add(this.search_panel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "Form1";
            this.Text = "Text Analysis";
            this.col_panel.ResumeLayout(false);
            this.col_panel.PerformLayout();
            this.search_panel.ResumeLayout(false);
            this.search_panel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button open_btn;
        private System.Windows.Forms.ListBox word_listBox;
        private System.Windows.Forms.Button edit_btn;
        private System.Windows.Forms.Button remove_btn;
        private System.Windows.Forms.Button display_btn;
        private System.Windows.Forms.Button common_btn;
        private System.Windows.Forms.Button moreThan_btn;
        private System.Windows.Forms.Button concordance_btn;
        private System.Windows.Forms.Button info_btn;
        private System.Windows.Forms.Button collocation_btn;
        private System.Windows.Forms.TextBox moreThan_txt;
        private System.Windows.Forms.TextBox collocationIn2_txt;
        private System.Windows.Forms.TextBox search_txt;
        private System.Windows.Forms.ListBox searchResults_listBox;
        private System.Windows.Forms.TextBox unique_txt;
        private System.Windows.Forms.Label unique_lbl;
        private System.Windows.Forms.Label search_lbl;
        private System.Windows.Forms.TextBox collocationOut_txt;
        private System.Windows.Forms.TextBox collocationIn1_txt;
        private System.Windows.Forms.Label word1_lbl;
        private System.Windows.Forms.Label word2_lbl;
        private System.Windows.Forms.Label col_lbl;
        private System.Windows.Forms.Panel col_panel;
        private System.Windows.Forms.Panel search_panel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button help_btn;
    }
}

