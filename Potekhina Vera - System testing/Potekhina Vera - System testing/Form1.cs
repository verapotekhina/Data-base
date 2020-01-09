using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Potekhina_Vera___System_testing
{
    public partial class Form1 : Form
    {
        private readonly OleDbConnectionStringBuilder connectString ;
        private OleDbConnection myConnection;
        
        public Form1()
        {
            InitializeComponent();
            connectString = new OleDbConnectionStringBuilder();
            connectString.Provider = "Microsoft.Jet.OLEDB.4.0";
            connectString.DataSource = @"Testing system.mdb";
            // создаем экземпляр класса OleDbConnection
            myConnection = new OleDbConnection(connectString.ConnectionString);
            // открываем соединение с БД
            myConnection.Open();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            // закрываем соединение с БД
            myConnection.Close();
        }

        OleDbDataAdapter da;
        DataTable dt = new DataTable();

        private void button_showTable_Click(object sender, EventArgs e)
        {
            BindingSource bs1 = new BindingSource();
            // создаем экземпляр класса OleDbConnection
            myConnection = new OleDbConnection(connectString.ConnectionString);
            // открываем соединение с БД
            myConnection.Open();
            var changeTable = comboBox1.SelectedItem.ToString();
            string sqlCommand = String.Format("SELECT * FROM {0}", changeTable);
            da = new OleDbDataAdapter(sqlCommand, myConnection);
            dt = new DataTable();
            
            //фиксирование изменений
            OleDbCommandBuilder bulder = new OleDbCommandBuilder(da); 
            da.UpdateCommand = bulder.GetUpdateCommand();
            da.InsertCommand = bulder.GetInsertCommand();
            da.DeleteCommand = bulder.GetDeleteCommand();
            
            da.Fill(dt);
            bs1.DataSource = dt;   
            //dataGridView1.DataSource = dt; //выводим в грид
            bindingNavigator1.BindingSource = bs1;
            dataGridView1.DataSource = bs1;

            myConnection.Close();
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            da.Update(dt);
            MessageBox.Show("Изменения успешно сохранены");
        }

        private void button_solutionsUser_Click(object sender, EventArgs e)
        {
            dt = new DataTable();
            dataGridView1.DataSource = new object();
            Form2 form2 = new Form2("Введите идентификатор пользователя:");
            form2.ShowDialog();
            var id = form2.DataMethod;
            
            myConnection = new OleDbConnection(connectString.ConnectionString);
            // открываем соединение с БД
            myConnection.Open();
            string sqlCommand = String.Format("SELECT Пользователи.Идентификатор_пользователя, Имя_пользователя, Фамилия_пользователя, Номер_задачи, Код_решения, Текст_решения " +
                                              "FROM Пользователи, Решение " +
                                              "WHERE Решение.Идентификатор_Пользователя = \"{0}\" AND Решение.Идентификатор_Пользователя = Пользователи.Идентификатор_Пользователя", id);
            da = new OleDbDataAdapter(sqlCommand, myConnection);

            da.Fill(dt);
            dataGridView1.DataSource = dt; //выводим в грид
            myConnection.Close();

        }
        
        private void button_tasksOfAuthors_Click(object sender, EventArgs e)
        {
            dt = new DataTable();
            dataGridView1.DataSource = new object();
            Form2 form2 = new Form2("Введите идентификатор автора:");
            form2.ShowDialog();
            var id = form2.DataMethod;
            
            myConnection = new OleDbConnection(connectString.ConnectionString);
            // открываем соединение с БД
            myConnection.Open();
            string sqlCommand = String.Format("SELECT DISTINCT Задача.Номер_задачи, Имя_автора, Фамилия_автора, Название_задачи, Сложность_задачи, Количество_верных_решений " +
                                              "FROM Авторы_задач, Архив_задач, Задача " +
                                              "WHERE Задача.Идентификатор_автора = \"{0}\" AND Архив_задач.Номер_задачи = Задача.Номер_задачи;", id);

            da = new OleDbDataAdapter(sqlCommand, myConnection);

            da.Fill(dt);
            dataGridView1.DataSource = dt; //выводим в грид
            myConnection.Close();

        }

        private void button_tasksWithComplexity_Click(object sender, EventArgs e)
        {
            dt = new DataTable();
            dataGridView1.DataSource = new object();
            Form2 form2 = new Form2("Введите верхнюю границу сложности:");
            form2.ShowDialog();
            var id = form2.DataMethod;
            
            myConnection = new OleDbConnection(connectString.ConnectionString);
            // открываем соединение с БД
            myConnection.Open();
            string sqlCommand = String.Format("SELECT Задача.Номер_задачи, Сложность_задачи, Название_задачи, Текст_задачи " +
                                              "FROM Задача, Архив_задач " +
                                              "WHERE Сложность_задачи < {0} AND Задача.Номер_задачи = Архив_задач.Номер_задачи " +
                                              "ORDER BY Сложность_задачи;", id);


            da = new OleDbDataAdapter(sqlCommand, myConnection);

            da.Fill(dt);
            dataGridView1.DataSource = dt; //выводим в грид
            myConnection.Close();

        }

        private void button_QuestionForTask_Click(object sender, EventArgs e)
        {
            dt = new DataTable();
            dataGridView1.DataSource = new object();
            Form2 form2 = new Form2("Введите номер задачи:");
            form2.ShowDialog();
            var id = form2.DataMethod;
            
            myConnection = new OleDbConnection(connectString.ConnectionString);
            // открываем соединение с БД
            myConnection.Open();
            string sqlCommand = String.Format("SELECT Номер_задачи, Текст_Вопроса, Текст_Ответа " +
                                              "FROM Вопрос_автору " +
                                              "WHERE Номер_задачи = \"{0}\"; ", id);

            da = new OleDbDataAdapter(sqlCommand, myConnection);

            da.Fill(dt);
            dataGridView1.DataSource = dt; //выводим в грид
            myConnection.Close();
        }

        private void button_topRating_Click(object sender, EventArgs e)
        {
            dt = new DataTable();
            dataGridView1.DataSource = new object();
            Form2 form2 = new Form2("Введите топ рейтинга:");
            form2.ShowDialog();
            var id = form2.DataMethod;
            
            myConnection = new OleDbConnection(connectString.ConnectionString);
            // открываем соединение с БД
            myConnection.Open();
            string sqlCommand = String.Format("SELECT Имя_пользователя, Фамилия_пользователя, Общий_рейтинг.Количество_решенных_задач, Общий_рейтинг.Позиция_в_рейтинге " +
                                              "FROM Общий_рейтинг, Пользователи " +
                                              "WHERE Общий_рейтинг.Позиция_в_рейтинге <= {0} AND Общий_рейтинг.Позиция_в_рейтинге= Пользователи.Позиция_в_рейтинге; ", id);
            
            da = new OleDbDataAdapter(sqlCommand, myConnection);

            da.Fill(dt);
            dataGridView1.DataSource = dt; //выводим в грид
            myConnection.Close();
        }

        private void button_solutionOnLanguage_Click(object sender, EventArgs e)
        {
            dt = new DataTable();
            dataGridView1.DataSource = new object();
            Form2 form2 = new Form2("Введите язык программирования:");
            form2.ShowDialog();
            var id = form2.DataMethod;
            
            myConnection = new OleDbConnection(connectString.ConnectionString);
            // открываем соединение с БД
            myConnection.Open();
            string sqlCommand = String.Format("SELECT Идентификатор_пользователя, Логин_пользователя, Текст_решения, Язык_программирования " +
                                              "FROM Решение " +
                                              "WHERE Язык_программирования = \"{0}\"; ", id);
            
            /*
             * SELECT Идентификатор_пользователя, Логин_пользователя, Текст_решения, Язык_программирования FROM Решение
WHERE Язык_программирования = [Введите язык];
             */
            da = new OleDbDataAdapter(sqlCommand, myConnection);

            da.Fill(dt);
            dataGridView1.DataSource = dt; //выводим в грид
            myConnection.Close();
        }
    }
}