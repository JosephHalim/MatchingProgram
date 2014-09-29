namespace StudyGuide
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblCorrect = new System.Windows.Forms.Label();
            this.lblIncorrect = new System.Windows.Forms.Label();
            this.lblData = new System.Windows.Forms.Label();
            this.lblNumberRemaining = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnAddTxtFile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(46, 28);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(155, 316);
            this.listBox1.TabIndex = 0;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(267, 28);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(740, 316);
            this.listBox2.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(267, 361);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 39);
            this.button1.TabIndex = 2;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(880, 415);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(106, 41);
            this.button2.TabIndex = 3;
            this.button2.Text = "Close Program";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 384);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Correct:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 406);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Incorrect:";
            // 
            // lblCorrect
            // 
            this.lblCorrect.AutoSize = true;
            this.lblCorrect.Location = new System.Drawing.Point(124, 387);
            this.lblCorrect.Name = "lblCorrect";
            this.lblCorrect.Size = new System.Drawing.Size(35, 13);
            this.lblCorrect.TabIndex = 6;
            this.lblCorrect.Text = "label3";
            // 
            // lblIncorrect
            // 
            this.lblIncorrect.AutoSize = true;
            this.lblIncorrect.Location = new System.Drawing.Point(124, 406);
            this.lblIncorrect.Name = "lblIncorrect";
            this.lblIncorrect.Size = new System.Drawing.Size(35, 13);
            this.lblIncorrect.TabIndex = 7;
            this.lblIncorrect.Text = "label4";
            // 
            // lblData
            // 
            this.lblData.Location = new System.Drawing.Point(12, 361);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(106, 23);
            this.lblData.TabIndex = 8;
            this.lblData.Text = "Number Remaining:";
            // 
            // lblNumberRemaining
            // 
            this.lblNumberRemaining.AutoSize = true;
            this.lblNumberRemaining.Location = new System.Drawing.Point(124, 361);
            this.lblNumberRemaining.Name = "lblNumberRemaining";
            this.lblNumberRemaining.Size = new System.Drawing.Size(35, 13);
            this.lblNumberRemaining.TabIndex = 9;
            this.lblNumberRemaining.Text = "label3";
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(270, 406);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(103, 40);
            this.btnReset.TabIndex = 10;
            this.btnReset.Text = "Reset Data";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnAddTxtFile
            // 
            this.btnAddTxtFile.Location = new System.Drawing.Point(409, 361);
            this.btnAddTxtFile.Name = "btnAddTxtFile";
            this.btnAddTxtFile.Size = new System.Drawing.Size(103, 40);
            this.btnAddTxtFile.TabIndex = 11;
            this.btnAddTxtFile.Text = "Add Text File";
            this.btnAddTxtFile.UseVisualStyleBackColor = true;
            this.btnAddTxtFile.Click += new System.EventHandler(this.btnAddTxtFile_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1036, 492);
            this.Controls.Add(this.btnAddTxtFile);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.lblNumberRemaining);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.lblIncorrect);
            this.Controls.Add(this.lblCorrect);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblCorrect;
        private System.Windows.Forms.Label lblIncorrect;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Label lblNumberRemaining;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnAddTxtFile;
    }
}

