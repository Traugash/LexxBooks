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
using System.IO;

namespace LexBooksProject
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

        }

        public class MyUsersContext : DbContext
        {


            //Имя будущей БД можно указать через вызов конструктора базового класса 
            public MyUsersContext() : base("LexBooks")
            {

            }

            //Отражение таблиц БД на свойства с типом DbSet

            public DbSet<UsersData> userdatas { get; set; }//Таблица Userdata
            public DbSet<Books> books { get; set; }//Таблица Books
            public DbSet<Genres> genres { get; set; }//Таблица Genres
            public DbSet<Users> users { get; set; }//Таблица Users

        }




        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "lexBooksDataSet.Books". При необходимости она может быть перемещена или удалена.
            this.booksTableAdapter.Fill(this.lexBooksDataSet.Books);

        }

        public class UsersData//Это таблица UserData из Access
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

        private void button_quit2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {
                
        }

        private void buttom_Search_Click_1(object sender, EventArgs e)
        {
              //установка фильтра
               bindingSource1.Filter = "NameBooks = \'" + TextBox_Search_Book.Text + "\'";
        }

        private void ButtonAll_Click(object sender, EventArgs e)
        {
            //Сброс фильтра
            bindingSource1.Filter = null;
            bindingSource2.Filter = null;
        }
    }
}