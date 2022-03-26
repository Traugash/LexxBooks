using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;
using System.Data.OleDb;

namespace LexBooksProject
{
    public partial class Form1 : Form
    {
        public string conn;

        public Form1()
        {
            InitializeComponent();



            //conn = @"Provider=Microsoft.ACE.OLEDB.12.0; Data Source = C:\Users\corp.Traugash\Desktop\КУРСОВАЯ РАБОТА\Проект курсовой_new\LexBooksProject\LexBooksProject\LexBooks.accdb; Persist Security Info = True";
            conn = @"Provider=Microsoft.ACE.OLEDB.12.0; Data Source = C:\Users\Traugash\Desktop\Ученье СВЕТ\Учеба (СПО)\КУРСОВАЯ РАБОТА\Проект курсовой_new\LexBooksProject\LexBooksProject\LexBooks.accdb; Persist Security Info = True";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void buttom_quit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button_login_Click(object sender, EventArgs e)
        {
            OleDbConnection myConnection = new OleDbConnection(conn);

            string log = "", pas = "";

            string query_log = "SELECT DISTINCT UsersNick, Password FROM UsersData WHERE UsersNick='" + textBox_login.Text + "'";

            OleDbCommand command = new OleDbCommand(query_log, myConnection);

            OleDbDataReader reader = null;

            myConnection.Open();

            reader = command.ExecuteReader();
            while (reader.Read())
            {
                log = reader["UsersNick"].ToString();
                pas = reader["Password"].ToString();
            }

            myConnection.Close();


            if (textBox_login.Text == log && textBox2_pass.Text == pas)
            {
                Form2 fr2 = new Form2();
                fr2.Show();

                this.Hide();
            }
            else
            if (pas != textBox2_pass.Text)
            {
                textBox_login.Text = "";
                textBox2_pass.Text = "";

                MessageBox.Show("Вы ввели неправильный пароль");
            }
            else
            {
                textBox_login.Text = "";
                textBox2_pass.Text = "";

                MessageBox.Show("Вы ввели некорректные данные.");
            }
            //OleDbConnection myConnection = new OleDbConnection(conn);

            //string log, pas;

            //string query_log = "SELECT Usernick FROM UsersData WHERE Usernick = '" + textBox_login.Text + "'";
            //string query_pas = "SELECT Password FROM UsersData WHERE Usernick = '" + textBox2_pass.Text + "'";

            //OleDbCommand command = new OleDbCommand(query_log, myConnection);
            //OleDbCommand command2 = new OleDbCommand(query_pas, myConnection);

            //myConnection.Open();

            //log = command.ExecuteNonQuery().ToString();
            //pas = command2.ExecuteNonQuery().ToString();

            //myConnection.Close();


            //if (textBox_login.Text == log && textBox2_pass.Text == pas)
            //{
            //    Form2 fr2 = new Form2();
            //    fr2.Show();

            //    this.Hide();
            //}
            //else
            //if (pas != textBox2_pass.Text)
            //{
            //    textBox_login.Text = "";
            //    textBox2_pass.Text = "";

            //    MessageBox.Show("Вы ввели неправильный пароль");
            //}
            //else
            //{
            //    textBox_login.Text = "";
            //    textBox2_pass.Text = "";

            //    MessageBox.Show("Вы ввели некорректные данные.");
            //}

        }

        private void button_reg_Click(object sender, EventArgs e)
        {
            Form3_REG fr3 = new Form3_REG();
            fr3.Show();
        }
    }

    public class Userdata//Это таблица UserData из Access
    {
        public int Id { get; set; }
        public string Usernick { get; set; }
        public string Fullname { get; set; }
        public DateTime Creationdate { get; set; }
        public string Password { get; set; }

    }

    public class Books//Это таблица Books
    {
        public int Id { get; set; }
        public string Namebooks { get; set; }
        public string Author { get; set; }
        public int Pages { get; set; }
        public string Link { get; set; }

    }

    public class Genres//Это таблица Genres
    {
        public int Id { get; set; }
        public string Bookname { get; set; }
        public string Genre { get; set; }
        public DateTime Releasedate { get; set; }

    }

    public class Users//Это таблица Users
    {
        public int Id { get; set; }
        public string Usersnick { get; set; }
        public string Readbooks { get; set; }
        public string ProccessReading { get; set; }
    }


    
}
