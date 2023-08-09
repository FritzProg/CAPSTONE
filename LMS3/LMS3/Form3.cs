using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace LMS3
{
    public partial class Form3 : Form
    {

        public Form3()
        {
            InitializeComponent();

            linkLabel1.Text = "click here";
            linkLabel1.Links.Add(0, linkLabel1.Text.Length, "http://cutternumber.com.ar/");
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            authorsnameTB.Text = "";
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            authorsnumberTB.Text = "";
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox3_Click(object sender, EventArgs e)
        {
            titleTB.Text = "";
        }

        private void textBox4_Click(object sender, EventArgs e)
        {
            accessionnumberTB.Text = "";
        }

        private void textBox5_Click(object sender, EventArgs e)
        {
            publicationTB.Text = "";
        }

        private void textBox6_Click(object sender, EventArgs e)
        {
            editionTB.Text = "";
        }

        private void textBox7_Click(object sender, EventArgs e)
        {
            pagesTB.Text = "";
        }

        private void textBox8_Click(object sender, EventArgs e)
        {
            yearTB.Text = "";
        }

        private void textBox9_Click(object sender, EventArgs e)
        {
            sourceoffundTB.Text = "";
        }

        private void textBox10_Click(object sender, EventArgs e)
        {
            isbnTB.Text = "";
        }

        private void textBox11_Click(object sender, EventArgs e)
        {
            subjectareaTB.Text = "";
        }

        private void textBox12_Click(object sender, EventArgs e)
        {
            deweydecimalTB.Text = "";
        }

        private void textBox13_Click(object sender, EventArgs e)
        {
            publisherTB.Text = "";
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            panel2.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {


            if ((authorsnameTB.Text == "Author's Name") || string.IsNullOrWhiteSpace(authorsnameTB.Text) &&
                (authorsnumberTB.Text == "Author's Number") || string.IsNullOrWhiteSpace(authorsnumberTB.Text)
                )
            {
                MessageBox.Show("Unable to Proceed, Please Add Author's Name and Author's Number", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if ((authorsnameTB.Text == "Author's Name") || string.IsNullOrWhiteSpace(authorsnameTB.Text)
                )
            {
                MessageBox.Show("Please Add Author's Name", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if ((authorsnumberTB.Text == "Author's Number") || string.IsNullOrWhiteSpace(authorsnumberTB.Text)
                )
            {
                MessageBox.Show("Please Add Author's Number", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                panel2.Visible = true;
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string authorname = authorsnameTB.Text;
            string authornumber = authorsnumberTB.Text;
            string booktitle = titleTB.Text;
            string accessionNumber = accessionnumberTB.Text;
            string bookpublication = publicationTB.Text;
            dateTimePicker1.CustomFormat = " ";
            string bookedition = editionTB.Text;
            string bookpages = pagesTB.Text;
            string bookyear = yearTB.Text;
            string booksourceoffund = sourceoffundTB.Text;
            string bookISBN = isbnTB.Text;
            string booksubjectarea = subjectareaTB.Text;
            string bookdeweydecimal = deweydecimalTB.Text;
            string bookpublisher = publisherTB.Text;
            string bookcopies = CopiesTB.Text;
            string bookGenre = GenreCB.Text;







            SqlConnection con = new SqlConnection();
            con.ConnectionString = " data source = MERRYCRIS\\SQLEXPRESS; database= dbLIBRARY1;integrated security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;


            //decimal decimalValue = decimal.Parse(bookdeweydecimal);


            //con.Open();
            //cmd.CommandText = "insert into tblBOOK (Accession_No,book_Title,book_Publication,book_DateReceived,book_Edition,book_Pages,book_Year,book_SourceofFund,book_ISBN,book_SubjectArea,book_Publisher,book_DeweyDecimal) values ('" + accessionNumber + "', '" + booktitle + "','" + bookpublication + "','" + dateTimePicker1.Value.Date + "','" + bookedition + "','" + bookpages + "','" + bookyear + "','" + booksourceoffund + "','" + bookISBN + "','" + booksubjectarea + "','" + bookpublisher + "','" + bookdeweydecimal + "')";
            //cmd.ExecuteNonQuery();
            //con.Close();



          //  SqlConnection con1 = new SqlConnection();
           // con1.ConnectionString = " data source = MERRYCRIS\\SQLEXPRESS; database= dbLIBRARY1;integrated security=True";
           // SqlCommand cmd1 = new SqlCommand();
           // cmd1.Connection = con1;

            //con1.Open();
            //cmd1.CommandText = "insert into tblAUTHORS (Author_Name,Author_No) values ('" + authorname + "','" + authornumber + "')";
            //cmd1.ExecuteNonQuery();
            //con1.Close();

            //MessageBox.Show("info saved");

            try
            {
                con.Open();
                cmd.CommandText = "insert into tblAUTHORS (Author_Name,Author_No) values ('" + authorname + "','" + authornumber + "')";
                cmd.ExecuteNonQuery();
                con.Close();

                // Proceed to tblBook if recorded
                con.Open();
                cmd.CommandText = "insert into tblBOOK (Accession_No,book_Title,book_Publication,book_DateReceived,book_Edition,book_Pages,book_Year,book_SourceofFund,book_ISBN,book_SubjectArea,book_Publisher,book_DeweyDecimal,book_Copies,book_Genre) values ('" + accessionNumber + "', '" + booktitle + "','" + bookpublication + "','" + dateTimePicker1.Value.Date + "','" + bookedition + "','" + bookpages + "','" + bookyear + "','" + booksourceoffund + "','" + bookISBN + "','" + booksubjectarea + "','" + bookpublisher + "','" + bookdeweydecimal + "', '" + bookcopies + "','" + bookGenre + "')";
                cmd.ExecuteNonQuery();
                con.Close();
                decimal decimalValue = decimal.Parse(bookdeweydecimal);

                MessageBox.Show("Data inserted successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to insert data. Error: " + ex.Message);

            }
            finally
            {
                con.Close();
                con.Close();
            }

            authorsnameTB.Text = "Author's Name";
            authorsnumberTB.Text = "Author's Number";
            titleTB.Text = "Title";
            accessionnumberTB.Text = "Accession Number";
            publicationTB.Text = "Publication";
            editionTB.Text = "Edition";
            pagesTB.Text = "Pages";
            yearTB.Text = "Year";
            sourceoffundTB.Text = "Source of Fund";
            isbnTB.Text = "ISBN";
            subjectareaTB.Text = "Subject Area";
            deweydecimalTB.Text = "Dewey Decimal";
            publisherTB.Text = "Publisher";






        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                Process.Start(new ProcessStartInfo
                {
                    FileName = "cmd",
                    Arguments = $"/c start {e.Link.LinkData}",
                    UseShellExecute = false,
                    RedirectStandardOutput = true,
                    CreateNoWindow = true
                });
            }
            catch (Exception ex)
            {

                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void textBox1_Click_1(object sender, EventArgs e)
        {
            CopiesTB.Text = "";
        }

        private void GenreCB_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
