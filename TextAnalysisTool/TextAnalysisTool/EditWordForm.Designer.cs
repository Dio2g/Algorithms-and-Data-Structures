namespace TextAnalysisTool
{
    partial class EditWordForm
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
            this.wordName_lbl = new System.Windows.Forms.Label();
            this.occ_lbl = new System.Windows.Forms.Label();
            this.line_lbl = new System.Windows.Forms.Label();
            this.pos_lbl = new System.Windows.Forms.Label();
            this.save_btn = new System.Windows.Forms.Button();
            this.word_txt = new System.Windows.Forms.TextBox();
            this.occ_txt = new System.Windows.Forms.TextBox();
            this.line_txt = new System.Windows.Forms.TextBox();
            this.pos_txt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // wordName_lbl
            // 
            this.wordName_lbl.AutoSize = true;
            this.wordName_lbl.Location = new System.Drawing.Point(12, 29);
            this.wordName_lbl.Name = "wordName_lbl";
            this.wordName_lbl.Size = new System.Drawing.Size(39, 13);
            this.wordName_lbl.TabIndex = 0;
            this.wordName_lbl.Text = "Word: ";
            // 
            // occ_lbl
            // 
            this.occ_lbl.AutoSize = true;
            this.occ_lbl.Location = new System.Drawing.Point(12, 69);
            this.occ_lbl.Name = "occ_lbl";
            this.occ_lbl.Size = new System.Drawing.Size(71, 13);
            this.occ_lbl.TabIndex = 1;
            this.occ_lbl.Text = "Occurences: ";
            // 
            // line_lbl
            // 
            this.line_lbl.AutoSize = true;
            this.line_lbl.Location = new System.Drawing.Point(12, 112);
            this.line_lbl.Name = "line_lbl";
            this.line_lbl.Size = new System.Drawing.Size(33, 13);
            this.line_lbl.TabIndex = 2;
            this.line_lbl.Text = "Line: ";
            // 
            // pos_lbl
            // 
            this.pos_lbl.AutoSize = true;
            this.pos_lbl.Location = new System.Drawing.Point(12, 157);
            this.pos_lbl.Name = "pos_lbl";
            this.pos_lbl.Size = new System.Drawing.Size(55, 13);
            this.pos_lbl.TabIndex = 3;
            this.pos_lbl.Text = "Positions: ";
            // 
            // save_btn
            // 
            this.save_btn.Location = new System.Drawing.Point(195, 205);
            this.save_btn.Name = "save_btn";
            this.save_btn.Size = new System.Drawing.Size(75, 23);
            this.save_btn.TabIndex = 4;
            this.save_btn.Text = "Save";
            this.save_btn.UseVisualStyleBackColor = true;
            this.save_btn.Click += new System.EventHandler(this.save_btn_Click);
            // 
            // word_txt
            // 
            this.word_txt.Location = new System.Drawing.Point(83, 26);
            this.word_txt.Name = "word_txt";
            this.word_txt.Size = new System.Drawing.Size(369, 20);
            this.word_txt.TabIndex = 5;
            // 
            // occ_txt
            // 
            this.occ_txt.Location = new System.Drawing.Point(83, 66);
            this.occ_txt.Name = "occ_txt";
            this.occ_txt.Size = new System.Drawing.Size(369, 20);
            this.occ_txt.TabIndex = 6;
            // 
            // line_txt
            // 
            this.line_txt.Location = new System.Drawing.Point(83, 109);
            this.line_txt.Name = "line_txt";
            this.line_txt.Size = new System.Drawing.Size(369, 20);
            this.line_txt.TabIndex = 7;
            // 
            // pos_txt
            // 
            this.pos_txt.Location = new System.Drawing.Point(83, 154);
            this.pos_txt.Name = "pos_txt";
            this.pos_txt.Size = new System.Drawing.Size(369, 20);
            this.pos_txt.TabIndex = 8;
            // 
            // EditWordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 240);
            this.Controls.Add(this.pos_txt);
            this.Controls.Add(this.line_txt);
            this.Controls.Add(this.occ_txt);
            this.Controls.Add(this.word_txt);
            this.Controls.Add(this.save_btn);
            this.Controls.Add(this.pos_lbl);
            this.Controls.Add(this.line_lbl);
            this.Controls.Add(this.occ_lbl);
            this.Controls.Add(this.wordName_lbl);
            this.Name = "EditWordForm";
            this.Text = "EditWordForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label wordName_lbl;
        private System.Windows.Forms.Label occ_lbl;
        private System.Windows.Forms.Label line_lbl;
        private System.Windows.Forms.Label pos_lbl;
        private System.Windows.Forms.Button save_btn;
        private System.Windows.Forms.TextBox word_txt;
        private System.Windows.Forms.TextBox occ_txt;
        private System.Windows.Forms.TextBox line_txt;
        private System.Windows.Forms.TextBox pos_txt;
    }
}