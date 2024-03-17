using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Магазин_техники
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            SetRoundedShape(panel1, 30);
            SetRoundedShape(panel2, 30);
            maskedTextBox4.Height =90;
            maskedTextBox4.Text = "Поиск по каталогу";//подсказка
            maskedTextBox4.ForeColor = Color.Gray;
        }
        private void maskedTextBox4_Click(object sender, EventArgs e)
        {
            maskedTextBox4.Text = null;
            maskedTextBox4.ForeColor = Color.Black;
        }
        static void SetRoundedShape(Control control, int radius)
        {
            try
            {
                System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
                path.AddLine(radius, 0, control.Width - radius, 0);
                path.AddArc(control.Width - radius, 0, radius, radius, 270, 90);
                path.AddLine(control.Width, radius, control.Width, control.Height - radius);
                path.AddArc(control.Width - radius, control.Height - radius, radius, radius, 0, 90);
                path.AddLine(control.Width - radius, control.Height, radius, control.Height);
                path.AddArc(0, control.Height - radius, radius, radius, 90, 90);
                path.AddLine(0, control.Height - radius, 0, radius);
                path.AddArc(0, 0, radius, radius, 180, 90);
                control.Region = new Region(path);
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Произошла ошибка: " + ex.Message);
            }
        }
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            panel1.Hide();
        }
        private void roundButton2_Click(object sender, EventArgs e)
        {
            panel1.Show();
            textBox2.Text = "Логин";//подсказка
            textBox2.ForeColor = Color.Gray;
            maskedTextBox1.Text = "Пароль";//подсказка
            maskedTextBox1.ForeColor = Color.Gray;
        }
        bool a = true;
        int x, y;
        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            a = true;
        }
        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (!a)
            {
                Panel mPanel = (Panel)sender;
                mPanel.Left += e.X - x;
                mPanel.Top += e.Y - y;
            }
        }
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            Panel mPanel = (Panel)sender;
            // стартовая позиция
            x = e.X;
            y = e.Y;
            a = false;//переменная , нажата ли кнопка мыши
        }
        private void pictureBox5_Click(object sender, EventArgs e)
        {
            panel2.Hide();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            panel2.Show();
            panel1.Hide();
            textBox4.Text = "ФИО";//подсказка
            textBox4.ForeColor = Color.Gray;
            textBox5.Text = "Логин";//подсказка
            textBox5.ForeColor = Color.Gray;
            maskedTextBox2.Text = "Пароль";//подсказка
            maskedTextBox2.ForeColor = Color.Gray;
            maskedTextBox3.Text = "Повтор Пароля";//подсказка
            maskedTextBox3.ForeColor = Color.Gray;
        }
        private void panel2_MouseUp(object sender, MouseEventArgs e)
        {
            a = true;
        }
        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            if (!a)
            {
                Panel mPanel = (Panel)sender;
                mPanel.Left += e.X - x;
                mPanel.Top += e.Y - y;
            }
        }
        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            Panel mPanel = (Panel)sender;
            x = e.X;
            y = e.Y;
            a = false;
        }
        private void textBox2_Enter(object sender, EventArgs e)
        {
            textBox2.Text = null;
            textBox2.ForeColor = Color.Black;
        }
        private void textBox4_Enter(object sender, EventArgs e)
        {
            textBox4.Text = null;
            textBox4.ForeColor = Color.Black;
        }
        private void textBox5_Enter(object sender, EventArgs e)
        {
            textBox5.Text = null;
            textBox5.ForeColor = Color.Black;
        }
        private void pictureBox6_Click(object sender, EventArgs e)
        {
            maskedTextBox1.UseSystemPasswordChar = false;
        }
        private void maskedTextBox1_Click(object sender, EventArgs e)
        {
            maskedTextBox1.Text = null;
            maskedTextBox1.ForeColor = Color.Black;
            maskedTextBox1.UseSystemPasswordChar = true;
        }
        private void maskedTextBox2_Click(object sender, EventArgs e)
        {
            maskedTextBox2.Text = null;
            maskedTextBox2.ForeColor = Color.Black;
            maskedTextBox2.UseSystemPasswordChar = true;
        }
        private void maskedTextBox3_Click(object sender, EventArgs e)
        {
            maskedTextBox3.Text = null;
            maskedTextBox3.ForeColor = Color.Black;
            maskedTextBox3.UseSystemPasswordChar = true;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "уП07_ИСП2_КузнецовDataSet2.Пользователь". При необходимости она может быть перемещена или удалена.
            this.пользовательTableAdapter.Fill(this.уП07_ИСП2_КузнецовDataSet2.Пользователь);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "уП07_ИСП2_КузнецовDataSet2.Каталог". При необходимости она может быть перемещена или удалена.
            this.каталогTableAdapter.Fill(this.уП07_ИСП2_КузнецовDataSet2.Каталог);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "уП07_ИСП2_КузнецовDataSet.Заказ". При необходимости она может быть перемещена или удалена.
            this.заказTableAdapter.Fill(this.уП07_ИСП2_КузнецовDataSet.Заказ);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "уП07_ИСП2_КузнецовDataSet2.Товар". При необходимости она может быть перемещена или удалена.
            this.товарTableAdapter.Fill(this.уП07_ИСП2_КузнецовDataSet2.Товар);
        }
        private void button3_Click(object sender, EventArgs e)
        {
            panel2.Hide();
            panel1.Show();
            db db = new db();
            db.openconn();
            if (textBox4.Text == "" || textBox5.Text == "" || maskedTextBox2.Text == "" ||maskedTextBox3.Text == "")
            {
                MessageBox.Show("Заполните все поля!");
            }
            else
            {
                SqlCommand command = new SqlCommand("Insert into Пользователь(Имя, Фамилия, Отчество Логин,Пароль ) VALUES (@a,@b, @c, @d, @f)", db.getconn());
                {
                    command.Parameters.AddWithValue("@a", textBox4.Text);
                    command.Parameters.AddWithValue("@b", textBox5.Text);
                    command.Parameters.AddWithValue("@c", maskedTextBox2.Text);
                    command.Parameters.AddWithValue("@d", maskedTextBox3.Text);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Пользователь добавлен");
                    db.closeconn();
                    this.пользовательTableAdapter.Fill(this.уП07_ИСП2_КузнецовDataSet2.Пользователь);
                }
            }
        }
        private void maskedTextBox4_TextChanged(object sender, EventArgs e)
        {
        }
        private void maskedTextBox4_Enter(object sender, EventArgs e)
        {
            db db = new db();
            db.openconn();
            DataTable dt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter();
            SqlCommand command = new SqlCommand($"SELECT * FROM Товар WHERE Название LIKE '%{maskedTextBox4.Text}%' OR Описание LIKE '%{maskedTextBox4.Text}%'", db.getconn());
            adapter.SelectCommand = command;
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                db db = new db();
                db.openconn();
                DataTable dt = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter();
                SqlCommand command = new SqlCommand($"SELECT [Код роли] FROM Пользователь WHERE Логин='{textBox2.Text}' AND Пароль='{maskedTextBox1.Text}'",db.getconn());
                adapter.SelectCommand = command;
                adapter.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    string role = null;
                    foreach (DataRow row in dt.Rows)
                    {
                        role = row["Код роли"].ToString();
                        if (role.Contains("1"))
                        {
                            Form2 form2 = new Form2();
                            form2.Show();
                        }
                        if (role.Contains("3"))
                        {
                            panel1.Hide();
                        }
                        if (role.Contains("2"))
                        {
                            Form2 form2 = new Form2();
                            form2.Show();
                        }
                        db.closeconn();
                    }
                }
                roundButton2.Visible = false;
                label1.Visible = true;
            }
            catch (Exception ex)
            {
              MessageBox.Show(ex.Message);
            }
        }
    }
}
