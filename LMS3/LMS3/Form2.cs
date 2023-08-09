using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LMS3
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Hide();
        }

        int id;
        Int64 updateid;


        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                {
                    id = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                    Aid = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                }



                panel1.Visible = true;

                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source = MERRYCRIS\\SQLEXPRESS; database= dbLIBRARY1;integrated security=True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = "select * from tblBOOK where id = " + id + "";
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);

                cmd.CommandText = "select * from tblAUTHORS where Author_Id = " + Aid + "";
                SqlDataAdapter da1 = new SqlDataAdapter(cmd);
                DataSet ds1 = new DataSet();
                da1.Fill(ds1);

                updateid = Int64.Parse(ds.Tables[0].Rows[0][0].ToString());
                updateAuthor_Id = Int64.Parse(ds1.Tables[0].Rows[0][0].ToString());

                accessionnumberTB.Text = ds.Tables[0].Rows[0][1].ToString();
                titleTB.Text = ds.Tables[0].Rows[0][2].ToString();
                publicationTB.Text = ds.Tables[0].Rows[0][3].ToString();
                dateTimePicker1.Text = ds.Tables[0].Rows[0][4].ToString();
                editionTB.Text = ds.Tables[0].Rows[0][5].ToString();
                pagesTB.Text = ds.Tables[0].Rows[0][6].ToString();
                yearTB.Text = ds.Tables[0].Rows[0][7].ToString();
                sourceoffundTB.Text = ds.Tables[0].Rows[0][8].ToString();
                isbnTB.Text = ds.Tables[0].Rows[0][9].ToString();
                subjectareaTB.Text = ds.Tables[0].Rows[0][10].ToString();
                publisherTB.Text = ds.Tables[0].Rows[0][12].ToString();
                deweydecimalTB.Text = ds.Tables[0].Rows[0][11].ToString();
                copiesTB.Text = ds.Tables[0].Rows[0][13].ToString();
                genreCB.Text = ds.Tables[0].Rows[0][14].ToString();
                authorsnameTB.Text = ds1.Tables[0].Rows[0][1].ToString();
                authorsnumberTB.Text = ds1.Tables[0].Rows[0][2].ToString();
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            panel1.Visible = false;

            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = MERRYCRIS\\SQLEXPRESS; database= dbLIBRARY1;integrated security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "select * from tblBOOK, tblAUTHORS";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);

            dataGridView1.DataSource = ds.Tables[0];
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source = MERRYCRIS\\SQLEXPRESS; database= dbLIBRARY1;integrated security=True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = "select * from tblBOOK where book_Title LIKE '" + textBox1.Text + "%'";
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);

                dataGridView1.DataSource = ds.Tables[0];
            }
            else
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source = MERRYCRIS\\SQLEXPRESS; database= dblibrary;integrated security=True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = "select * from tblBOOK";
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);

                dataGridView1.DataSource = ds.Tables[0];
            }
        }

        private void button2_Click(object sender, EventArgs e)
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
            string bookcopies = copiesTB.Text;
            string bookGenre = genreCB.Text;

            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = MERRYCRIS\\SQLEXPRESS; database= dbLIBRARY1;integrated security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            decimal decimalValue = decimal.Parse(bookdeweydecimal);
            cmd.CommandText = "update tblBOOK set book_Title  = '" + booktitle + "', Accession_No = '" + accessionNumber + "', book_DateReceived = '" + dateTimePicker1.Value.Date + "', book_Publication = '" + bookpublication + "', book_Year = '" + bookyear + "', book_Publisher = '" + bookpublisher + "',book_Edition = '" + bookedition + "', book_Pages = '" + bookpages + "', book_SourceofFund = '" + booksourceoffund + "', book_ISBN = '" + bookISBN + "', book_DeweyDecimal = '" + bookdeweydecimal + "', book_SubjectArea = '" + booksubjectarea + "', book_Copies = '" + bookcopies + "', book_Genre = '" + bookGenre + "'where id = " + updateid + "";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);

            cmd.CommandText = "update tblAUTHORS set Author_Name = '" + authorname + "', Author_No = '" + authornumber + "'where Author_Id = " + updateAuthor_Id + "";
            SqlDataAdapter da1 = new SqlDataAdapter(cmd);
            DataSet ds1 = new DataSet();
            da1.Fill(ds1);

            MessageBox.Show("info updated");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }
        int Aid;
        Int64 updateAuthor_Id;
        public void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
