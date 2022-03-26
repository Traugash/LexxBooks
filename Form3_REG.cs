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

namespace LexBooksProject
{
    public partial class Form3_REG : Form
    {
        public Form3_REG()
        {
            InitializeComponent();
        }
        public class MyUsersContext : DbContext
        {


            //Имя будущей БД можно указать через вызов конструктора базового класса 
            public MyUsersContext() : base("LexBooksProject.Properties.Settings.LexBooksConnectionString1")
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

        }

        public class UsersData//Это таблица UserData из Access
        {
            public int Id { get; set; }
            public string Usernick { get; set; }
            public string Fullname { get; set; }
            
            public string Password { get; set; }

            public UsersData(int newId, string newNick, string newFull, string newPassword)
            {
                this.Id = newId;
                this.Usernick = newNick;
                this.Fullname = newFull;
                
                this.Password = newPassword;
            }

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            DataRow newRow = lexBooksDataSet11.Tables["UsersData"].NewRow();
            newRow["UsersNick"] = textBox1.Text;
            newRow["Password"] = textBox2.Text;
            lexBooksDataSet11.Tables["UsersData"].Rows.Add(newRow);
            int v = usersDataTableAdapter1.Update(lexBooksDataSet11.UsersData);

            MessageBox.Show("Вы зарегестрировались.");
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Form3_REG_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
