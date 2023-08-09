namespace LMS3
{
    partial class Form3
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
            panel1 = new Panel();
            button2 = new Button();
            button1 = new Button();
            linkLabel1 = new LinkLabel();
            label2 = new Label();
            authorsnumberTB = new TextBox();
            authorsnameTB = new TextBox();
            label1 = new Label();
            panel2 = new Panel();
            GenreCB = new ComboBox();
            CopiesTB = new TextBox();
            button3 = new Button();
            publisherTB = new TextBox();
            deweydecimalTB = new TextBox();
            subjectareaTB = new TextBox();
            isbnTB = new TextBox();
            sourceoffundTB = new TextBox();
            yearTB = new TextBox();
            pagesTB = new TextBox();
            editionTB = new TextBox();
            label4 = new Label();
            dateTimePicker1 = new DateTimePicker();
            publicationTB = new TextBox();
            accessionnumberTB = new TextBox();
            titleTB = new TextBox();
            label3 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(linkLabel1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(authorsnumberTB);
            panel1.Controls.Add(authorsnameTB);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(39, 41);
            panel1.Name = "panel1";
            panel1.Size = new Size(948, 304);
            panel1.TabIndex = 0;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ButtonFace;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(775, 159);
            button2.Name = "button2";
            button2.Size = new Size(156, 52);
            button2.TabIndex = 6;
            button2.Text = "BACK";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ButtonFace;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(775, 228);
            button1.Name = "button1";
            button1.Size = new Size(156, 52);
            button1.TabIndex = 5;
            button1.Text = "NEXT";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(204, 236);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(79, 20);
            linkLabel1.TabIndex = 4;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Click Here.";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(34, 235);
            label2.Name = "label2";
            label2.Size = new Size(176, 20);
            label2.TabIndex = 3;
            label2.Text = "No Author's Number Yet?";
            // 
            // authorsnumberTB
            // 
            authorsnumberTB.Location = new Point(34, 138);
            authorsnumberTB.Multiline = true;
            authorsnumberTB.Name = "authorsnumberTB";
            authorsnumberTB.Size = new Size(217, 34);
            authorsnumberTB.TabIndex = 2;
            authorsnumberTB.Text = "Author's Number";
            authorsnumberTB.Click += textBox2_Click;
            // 
            // authorsnameTB
            // 
            authorsnameTB.Location = new Point(34, 80);
            authorsnameTB.Multiline = true;
            authorsnameTB.Name = "authorsnameTB";
            authorsnameTB.Size = new Size(217, 34);
            authorsnameTB.TabIndex = 1;
            authorsnameTB.Text = "Author's Name";
            authorsnameTB.Click += textBox1_Click;
            authorsnameTB.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(220, 23);
            label1.TabIndex = 0;
            label1.Text = "AUTHOR'S INFORMATION";
            // 
            // panel2
            // 
            panel2.Controls.Add(GenreCB);
            panel2.Controls.Add(CopiesTB);
            panel2.Controls.Add(button3);
            panel2.Controls.Add(publisherTB);
            panel2.Controls.Add(deweydecimalTB);
            panel2.Controls.Add(subjectareaTB);
            panel2.Controls.Add(isbnTB);
            panel2.Controls.Add(sourceoffundTB);
            panel2.Controls.Add(yearTB);
            panel2.Controls.Add(pagesTB);
            panel2.Controls.Add(editionTB);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(dateTimePicker1);
            panel2.Controls.Add(publicationTB);
            panel2.Controls.Add(accessionnumberTB);
            panel2.Controls.Add(titleTB);
            panel2.Controls.Add(label3);
            panel2.Location = new Point(43, 364);
            panel2.Name = "panel2";
            panel2.Size = new Size(944, 483);
            panel2.TabIndex = 1;
            panel2.Paint += panel2_Paint;
            // 
            // GenreCB
            // 
            GenreCB.FlatStyle = FlatStyle.Flat;
            GenreCB.FormattingEnabled = true;
            GenreCB.Items.AddRange(new object[] { "Fiction", "Reference" });
            GenreCB.Location = new Point(458, 276);
            GenreCB.Name = "GenreCB";
            GenreCB.Size = new Size(151, 28);
            GenreCB.TabIndex = 15;
            GenreCB.Text = "Genre";
            GenreCB.SelectedIndexChanged += GenreCB_SelectedIndexChanged;
            // 
            // CopiesTB
            // 
            CopiesTB.Location = new Point(349, 273);
            CopiesTB.Multiline = true;
            CopiesTB.Name = "CopiesTB";
            CopiesTB.Size = new Size(97, 36);
            CopiesTB.TabIndex = 14;
            CopiesTB.Text = "Copies";
            CopiesTB.Click += textBox1_Click_1;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.ButtonFace;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            button3.Location = new Point(771, 413);
            button3.Name = "button3";
            button3.Size = new Size(156, 52);
            button3.TabIndex = 7;
            button3.Text = "CONFIRM";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // publisherTB
            // 
            publisherTB.Location = new Point(349, 217);
            publisherTB.Multiline = true;
            publisherTB.Name = "publisherTB";
            publisherTB.Size = new Size(212, 36);
            publisherTB.TabIndex = 13;
            publisherTB.Text = "Publisher";
            publisherTB.Click += textBox13_Click;
            // 
            // deweydecimalTB
            // 
            deweydecimalTB.Location = new Point(349, 159);
            deweydecimalTB.Multiline = true;
            deweydecimalTB.Name = "deweydecimalTB";
            deweydecimalTB.Size = new Size(212, 36);
            deweydecimalTB.TabIndex = 12;
            deweydecimalTB.Text = "Dewey Decimal";
            deweydecimalTB.Click += textBox12_Click;
            // 
            // subjectareaTB
            // 
            subjectareaTB.Location = new Point(349, 105);
            subjectareaTB.Multiline = true;
            subjectareaTB.Name = "subjectareaTB";
            subjectareaTB.Size = new Size(212, 36);
            subjectareaTB.TabIndex = 11;
            subjectareaTB.Text = "Subject Area";
            subjectareaTB.Click += textBox11_Click;
            // 
            // isbnTB
            // 
            isbnTB.Location = new Point(349, 51);
            isbnTB.Multiline = true;
            isbnTB.Name = "isbnTB";
            isbnTB.Size = new Size(212, 36);
            isbnTB.TabIndex = 10;
            isbnTB.Text = "ISBN";
            isbnTB.Click += textBox10_Click;
            // 
            // sourceoffundTB
            // 
            sourceoffundTB.Location = new Point(37, 397);
            sourceoffundTB.Multiline = true;
            sourceoffundTB.Name = "sourceoffundTB";
            sourceoffundTB.Size = new Size(212, 36);
            sourceoffundTB.TabIndex = 9;
            sourceoffundTB.Text = "Source of Fund";
            sourceoffundTB.Click += textBox9_Click;
            // 
            // yearTB
            // 
            yearTB.Location = new Point(156, 342);
            yearTB.Multiline = true;
            yearTB.Name = "yearTB";
            yearTB.Size = new Size(111, 36);
            yearTB.TabIndex = 8;
            yearTB.Text = "Year";
            yearTB.Click += textBox8_Click;
            // 
            // pagesTB
            // 
            pagesTB.Location = new Point(37, 342);
            pagesTB.Multiline = true;
            pagesTB.Name = "pagesTB";
            pagesTB.Size = new Size(111, 36);
            pagesTB.TabIndex = 7;
            pagesTB.Text = "Pages";
            pagesTB.Click += textBox7_Click;
            // 
            // editionTB
            // 
            editionTB.Location = new Point(37, 290);
            editionTB.Multiline = true;
            editionTB.Name = "editionTB";
            editionTB.Size = new Size(212, 36);
            editionTB.TabIndex = 6;
            editionTB.Text = "Edition";
            editionTB.Click += textBox6_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(35, 217);
            label4.Name = "label4";
            label4.Size = new Size(149, 20);
            label4.TabIndex = 5;
            label4.Text = "Select Date Received";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(37, 242);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 27);
            dateTimePicker1.TabIndex = 4;
            // 
            // publicationTB
            // 
            publicationTB.Location = new Point(35, 159);
            publicationTB.Multiline = true;
            publicationTB.Name = "publicationTB";
            publicationTB.Size = new Size(212, 36);
            publicationTB.TabIndex = 3;
            publicationTB.Text = "Publication";
            publicationTB.Click += textBox5_Click;
            // 
            // accessionnumberTB
            // 
            accessionnumberTB.Location = new Point(35, 105);
            accessionnumberTB.Multiline = true;
            accessionnumberTB.Name = "accessionnumberTB";
            accessionnumberTB.Size = new Size(212, 36);
            accessionnumberTB.TabIndex = 2;
            accessionnumberTB.Text = "Accession Number";
            accessionnumberTB.Click += textBox4_Click;
            // 
            // titleTB
            // 
            titleTB.Location = new Point(35, 51);
            titleTB.Multiline = true;
            titleTB.Name = "titleTB";
            titleTB.Size = new Size(212, 36);
            titleTB.TabIndex = 1;
            titleTB.Text = "Title";
            titleTB.Click += textBox3_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(-1, 0);
            label3.Name = "label3";
            label3.Size = new Size(182, 23);
            label3.TabIndex = 0;
            label3.Text = "BOOK INFORMATION";
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1038, 859);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Form3";
            Text = "Form3";
            Load += Form3_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox authorsnameTB;
        private Label label1;
        private Button button2;
        private Button button1;
        private LinkLabel linkLabel1;
        private Label label2;
        private TextBox authorsnumberTB;
        private Panel panel2;
        private Label label3;
        private Label label4;
        private DateTimePicker dateTimePicker1;
        private TextBox publicationTB;
        private TextBox accessionnumberTB;
        private TextBox titleTB;
        private TextBox yearTB;
        private TextBox pagesTB;
        private TextBox editionTB;
        private TextBox publisherTB;
        private TextBox deweydecimalTB;
        private TextBox subjectareaTB;
        private TextBox isbnTB;
        private TextBox sourceoffundTB;
        private Button button3;
        private ComboBox GenreCB;
        private TextBox CopiesTB;
    }
}