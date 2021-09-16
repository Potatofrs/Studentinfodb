
namespace Studentinfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.idnum = new System.Windows.Forms.Label();
            this.idnumbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lname = new System.Windows.Forms.Label();
            this.fname = new System.Windows.Forms.Label();
            this.score = new System.Windows.Forms.Label();
            this.lnamebox = new System.Windows.Forms.TextBox();
            this.scorebox = new System.Windows.Forms.TextBox();
            this.fnamebox = new System.Windows.Forms.TextBox();
            this.submit = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Output = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // idnum
            // 
            this.idnum.AutoSize = true;
            this.idnum.Location = new System.Drawing.Point(18, 34);
            this.idnum.Name = "idnum";
            this.idnum.Size = new System.Drawing.Size(33, 13);
            this.idnum.TabIndex = 0;
            this.idnum.Text = "IDno ";
            this.idnum.Click += new System.EventHandler(this.label1_Click);
            // 
            // idnumbox
            // 
            this.idnumbox.BackColor = System.Drawing.SystemColors.Menu;
            this.idnumbox.Location = new System.Drawing.Point(84, 31);
            this.idnumbox.Name = "idnumbox";
            this.idnumbox.Size = new System.Drawing.Size(129, 20);
            this.idnumbox.TabIndex = 1;
            this.idnumbox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 29);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(237, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Please fill up the following information . ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // lname
            // 
            this.lname.AutoSize = true;
            this.lname.Location = new System.Drawing.Point(17, 70);
            this.lname.Name = "lname";
            this.lname.Size = new System.Drawing.Size(53, 13);
            this.lname.TabIndex = 3;
            this.lname.Text = "Lastname";
            // 
            // fname
            // 
            this.fname.AutoSize = true;
            this.fname.Location = new System.Drawing.Point(17, 102);
            this.fname.Name = "fname";
            this.fname.Size = new System.Drawing.Size(52, 13);
            this.fname.TabIndex = 4;
            this.fname.Text = "Firstname";
            this.fname.Click += new System.EventHandler(this.label4_Click);
            // 
            // score
            // 
            this.score.AutoSize = true;
            this.score.Location = new System.Drawing.Point(17, 137);
            this.score.Name = "score";
            this.score.Size = new System.Drawing.Size(56, 13);
            this.score.TabIndex = 5;
            this.score.Text = "QuizScore";
            // 
            // lnamebox
            // 
            this.lnamebox.BackColor = System.Drawing.SystemColors.Menu;
            this.lnamebox.Location = new System.Drawing.Point(84, 67);
            this.lnamebox.Name = "lnamebox";
            this.lnamebox.Size = new System.Drawing.Size(129, 20);
            this.lnamebox.TabIndex = 6;
            // 
            // scorebox
            // 
            this.scorebox.BackColor = System.Drawing.SystemColors.Menu;
            this.scorebox.Location = new System.Drawing.Point(84, 134);
            this.scorebox.Name = "scorebox";
            this.scorebox.Size = new System.Drawing.Size(129, 20);
            this.scorebox.TabIndex = 8;
            this.scorebox.TextChanged += new System.EventHandler(this.scorebox_TextChanged);
            // 
            // fnamebox
            // 
            this.fnamebox.BackColor = System.Drawing.SystemColors.Menu;
            this.fnamebox.Location = new System.Drawing.Point(84, 99);
            this.fnamebox.Name = "fnamebox";
            this.fnamebox.Size = new System.Drawing.Size(129, 20);
            this.fnamebox.TabIndex = 7;
            // 
            // submit
            // 
            this.submit.Location = new System.Drawing.Point(255, 544);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(90, 26);
            this.submit.TabIndex = 10;
            this.submit.Text = "Submit";
            this.submit.UseVisualStyleBackColor = true;
            this.submit.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Controls.Add(this.Output);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.scorebox);
            this.panel1.Controls.Add(this.fnamebox);
            this.panel1.Controls.Add(this.lnamebox);
            this.panel1.Controls.Add(this.score);
            this.panel1.Controls.Add(this.fname);
            this.panel1.Controls.Add(this.lname);
            this.panel1.Controls.Add(this.idnumbox);
            this.panel1.Controls.Add(this.idnum);
            this.panel1.Location = new System.Drawing.Point(11, 48);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(334, 473);
            this.panel1.TabIndex = 12;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel2.Location = new System.Drawing.Point(21, 15);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(288, 5);
            this.panel2.TabIndex = 14;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel3.Location = new System.Drawing.Point(21, 175);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(289, 5);
            this.panel3.TabIndex = 13;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // Output
            // 
            this.Output.BackColor = System.Drawing.SystemColors.Menu;
            this.Output.FormattingEnabled = true;
            this.Output.Location = new System.Drawing.Point(21, 227);
            this.Output.Name = "Output";
            this.Output.Size = new System.Drawing.Size(289, 212);
            this.Output.TabIndex = 15;
            this.Output.SelectedIndexChanged += new System.EventHandler(this.Output_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 202);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Information :";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(357, 582);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.label2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1920, 1080);
            this.Name = "Form1";
            this.Text = "Student Information ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label idnum;
        private System.Windows.Forms.TextBox idnumbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lname;
        private System.Windows.Forms.Label fname;
        private System.Windows.Forms.Label score;
        private System.Windows.Forms.TextBox lnamebox;
        private System.Windows.Forms.TextBox scorebox;
        private System.Windows.Forms.TextBox fnamebox;
        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ListBox Output;
        private System.Windows.Forms.Label label6;
    }
}

