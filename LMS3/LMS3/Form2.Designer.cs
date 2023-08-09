namespace LMS3
{
    partial class Form2
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
            dataGridView1 = new DataGridView();
            panel1 = new Panel();
            genreCB = new ComboBox();
            copiesTB = new TextBox();
            button3 = new Button();
            button2 = new Button();
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
            authorsnumberTB = new TextBox();
            authorsnameTB = new TextBox();
            textBox1 = new TextBox();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(23, 134);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(851, 565);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellClick;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // panel1
            // 
            panel1.BackColor = Color.PeachPuff;
            panel1.Controls.Add(genreCB);
            panel1.Controls.Add(copiesTB);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(publisherTB);
            panel1.Controls.Add(deweydecimalTB);
            panel1.Controls.Add(subjectareaTB);
            panel1.Controls.Add(isbnTB);
            panel1.Controls.Add(sourceoffundTB);
            panel1.Controls.Add(yearTB);
            panel1.Controls.Add(pagesTB);
            panel1.Controls.Add(editionTB);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(dateTimePicker1);
            panel1.Controls.Add(publicationTB);
            panel1.Controls.Add(accessionnumberTB);
            panel1.Controls.Add(titleTB);
            panel1.Controls.Add(authorsnumberTB);
            panel1.Controls.Add(authorsnameTB);
            panel1.Location = new Point(898, 99);
            panel1.Name = "panel1";
            panel1.Size = new Size(683, 600);
            panel1.TabIndex = 1;
            panel1.Paint += panel1_Paint;
            // 
            // genreCB
            // 
            genreCB.FormattingEnabled = true;
            genreCB.Items.AddRange(new object[] { "Fiction", "Reference" });
            genreCB.Location = new Point(520, 412);
            genreCB.Name = "genreCB";
            genreCB.Size = new Size(151, 28);
            genreCB.TabIndex = 30;
            // 
            // copiesTB
            // 
            copiesTB.Location = new Point(386, 412);
            copiesTB.Multiline = true;
            copiesTB.Name = "copiesTB";
            copiesTB.Size = new Size(115, 36);
            copiesTB.TabIndex = 29;
            // 
            // button3
            // 
            button3.Location = new Point(526, 494);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 28;
            button3.Text = "CLOSE";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Location = new Point(407, 494);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 27;
            button2.Text = "SAVE";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // publisherTB
            // 
            publisherTB.Location = new Point(407, 353);
            publisherTB.Multiline = true;
            publisherTB.Name = "publisherTB";
            publisherTB.Size = new Size(212, 36);
            publisherTB.TabIndex = 26;
            // 
            // deweydecimalTB
            // 
            deweydecimalTB.Location = new Point(407, 295);
            deweydecimalTB.Multiline = true;
            deweydecimalTB.Name = "deweydecimalTB";
            deweydecimalTB.Size = new Size(212, 36);
            deweydecimalTB.TabIndex = 25;
            // 
            // subjectareaTB
            // 
            subjectareaTB.Location = new Point(407, 241);
            subjectareaTB.Multiline = true;
            subjectareaTB.Name = "subjectareaTB";
            subjectareaTB.Size = new Size(212, 36);
            subjectareaTB.TabIndex = 24;
            // 
            // isbnTB
            // 
            isbnTB.Location = new Point(407, 187);
            isbnTB.Multiline = true;
            isbnTB.Name = "isbnTB";
            isbnTB.Size = new Size(212, 36);
            isbnTB.TabIndex = 23;
            // 
            // sourceoffundTB
            // 
            sourceoffundTB.Location = new Point(407, 116);
            sourceoffundTB.Multiline = true;
            sourceoffundTB.Name = "sourceoffundTB";
            sourceoffundTB.Size = new Size(212, 36);
            sourceoffundTB.TabIndex = 22;
            // 
            // yearTB
            // 
            yearTB.Location = new Point(526, 61);
            yearTB.Multiline = true;
            yearTB.Name = "yearTB";
            yearTB.Size = new Size(93, 36);
            yearTB.TabIndex = 21;
            // 
            // pagesTB
            // 
            pagesTB.Location = new Point(407, 61);
            pagesTB.Multiline = true;
            pagesTB.Name = "pagesTB";
            pagesTB.Size = new Size(93, 36);
            pagesTB.TabIndex = 20;
            // 
            // editionTB
            // 
            editionTB.Location = new Point(79, 412);
            editionTB.Multiline = true;
            editionTB.Name = "editionTB";
            editionTB.Size = new Size(212, 36);
            editionTB.TabIndex = 19;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(77, 339);
            label4.Name = "label4";
            label4.Size = new Size(149, 20);
            label4.TabIndex = 18;
            label4.Text = "Select Date Received";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(79, 364);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 27);
            dateTimePicker1.TabIndex = 17;
            // 
            // publicationTB
            // 
            publicationTB.Location = new Point(77, 281);
            publicationTB.Multiline = true;
            publicationTB.Name = "publicationTB";
            publicationTB.Size = new Size(212, 36);
            publicationTB.TabIndex = 16;
            // 
            // accessionnumberTB
            // 
            accessionnumberTB.Location = new Point(77, 227);
            accessionnumberTB.Multiline = true;
            accessionnumberTB.Name = "accessionnumberTB";
            accessionnumberTB.Size = new Size(212, 36);
            accessionnumberTB.TabIndex = 15;
            // 
            // titleTB
            // 
            titleTB.Location = new Point(77, 173);
            titleTB.Multiline = true;
            titleTB.Name = "titleTB";
            titleTB.Size = new Size(212, 36);
            titleTB.TabIndex = 14;
            // 
            // authorsnumberTB
            // 
            authorsnumberTB.Location = new Point(72, 116);
            authorsnumberTB.Multiline = true;
            authorsnumberTB.Name = "authorsnumberTB";
            authorsnumberTB.Size = new Size(217, 34);
            authorsnumberTB.TabIndex = 4;
            // 
            // authorsnameTB
            // 
            authorsnameTB.Location = new Point(72, 58);
            authorsnameTB.Multiline = true;
            authorsnameTB.Name = "authorsnameTB";
            authorsnameTB.Size = new Size(217, 34);
            authorsnameTB.TabIndex = 3;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(329, 79);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(213, 27);
            textBox1.TabIndex = 2;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // button1
            // 
            button1.Location = new Point(23, 36);
            button1.Name = "button1";
            button1.Size = new Size(109, 44);
            button1.TabIndex = 3;
            button1.Text = "BACK";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(894, 711);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(panel1);
            Controls.Add(dataGridView1);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Panel panel1;
        private TextBox textBox1;
        private Button button1;
        private TextBox authorsnumberTB;
        private TextBox authorsnameTB;
        private TextBox publisherTB;
        private TextBox deweydecimalTB;
        private TextBox subjectareaTB;
        private TextBox isbnTB;
        private TextBox sourceoffundTB;
        private TextBox yearTB;
        private TextBox pagesTB;
        private TextBox editionTB;
        private Label label4;
        private DateTimePicker dateTimePicker1;
        private TextBox publicationTB;
        private TextBox accessionnumberTB;
        private TextBox titleTB;
        private Button button3;
        private Button button2;
        private ComboBox genreCB;
        private TextBox copiesTB;
    }
}