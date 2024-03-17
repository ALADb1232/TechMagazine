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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            SetRoundedShape(panel1, 30);
            SetRoundedShape(panel2, 30);
            SetRoundedShape(panel3a, 30);
            int rowCount = dataGridView1.Rows.Count;
            label1.Text = "Количество товара: " + rowCount.ToString();
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
        bool a = true;
        int x, y;   
        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "уП07_ИСП2_КузнецовDataSet2.Роль". При необходимости она может быть перемещена или удалена.
            this.рольTableAdapter.Fill(this.уП07_ИСП2_КузнецовDataSet2.Роль);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "уП07_ИСП2_КузнецовDataSet2.Пользователь". При необходимости она может быть перемещена или удалена.
            this.пользовательTableAdapter.Fill(this.уП07_ИСП2_КузнецовDataSet2.Пользователь);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "уП07_ИСП2_КузнецовDataSet2.Каталог". При необходимости она может быть перемещена или удалена.
            this.каталогTableAdapter.Fill(this.уП07_ИСП2_КузнецовDataSet2.Каталог);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "уП07_ИСП2_КузнецовDataSet2.Товар". При необходимости она может быть перемещена или удалена.
            this.товарTableAdapter1.Fill(this.уП07_ИСП2_КузнецовDataSet2.Товар);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "уП07_ИСП2_КузнецовDataSet2.Каталог". При необходимости она может быть перемещена или удалена.
            this.каталогTableAdapter.Fill(this.уП07_ИСП2_КузнецовDataSet2.Каталог);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "уП07_ИСП2_КузнецовDataSet2.Роль". При необходимости она может быть перемещена или удалена.
            this.рольTableAdapter.Fill(this.уП07_ИСП2_КузнецовDataSet2.Роль);

        }
        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            panel1.Show();
        }
        private void pictureBox5_Click(object sender, EventArgs e)
        {
            panel1.Hide();
          
        }
        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                if (colorDialog1.ShowDialog() == DialogResult.OK)
                {
                    Color color1 = colorDialog1.Color;
                    if (colorDialog1.ShowDialog() == DialogResult.OK)
                    {
                        Color color2 = colorDialog1.Color;
                        int rowIndex = 0;
                        foreach (DataGridViewRow row in dataGridView1.Rows)
                        {
                            if (rowIndex % 2 == 0)
                            {
                                row.DefaultCellStyle.BackColor = color1;
                            }
                            else
                            {
                                row.DefaultCellStyle.BackColor = color2;
                            }
                            rowIndex++;
                        }
                        foreach (DataGridViewRow row in dataGridView1.Rows)
                        {
                            if (rowIndex % 2 == 0)
                            {
                                row.DefaultCellStyle.BackColor = color1;
                            }
                            else
                            {
                                row.DefaultCellStyle.BackColor = color2;
                            }
                            rowIndex++;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Произошла ошибка, интерфейс не изменен: " + ex.Message);
            }
        }
        private void button5_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            // установка шрифта 
            dataGridView1.Font = fontDialog1.Font;
            dataGridView2.Font = fontDialog1.Font;
            // установка цвета шрифта
            dataGridView1.ForeColor = fontDialog1.Color;
            dataGridView2.ForeColor = fontDialog1.Color;
        }
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
        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            this.товарTableAdapter1.Fill(this.уП07_ИСП2_КузнецовDataSet2.Товар);
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            panel2.Hide();
        }
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            panel2.Show();
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
            // стартовая позиция
            x = e.X;
            y = e.Y;
            a = false;//переменная , нажата ли кнопка мыши
        }
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            panel3a.Hide();
        }
        private void panel3_MouseUp(object sender, MouseEventArgs e)
        {
            a = true;
        }
        private void panel3_MouseMove(object sender, MouseEventArgs e)
        {
            if (!a)
            {
                Panel mPanel = (Panel)sender;
                mPanel.Left += e.X - x;
                mPanel.Top += e.Y - y;
            }
        }
        private void panel3_MouseDown(object sender, MouseEventArgs e)
        {
            Panel mPanel = (Panel)sender;
            // стартовая позиция
            x = e.X;
            y = e.Y;
            a = false;//переменная , нажата ли кнопка мыши
        }
        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            db db = new db();
            db.openconn();
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == ""|| textBox4.Text == "" || textBox5.Text == "" || comboBox1.Text == "")
            {
                MessageBox.Show("Заполните все поля!");
            }
            else
            {
                SqlCommand command = new SqlCommand("Insert into Пользователь(Имя, Фамилия, Отчество, Логин,Пароль,[Код Роли] ) VALUES ( @a,@b, @c, @d, @f, @e  )", db.getconn());
                {
                    command.Parameters.AddWithValue("@a", textBox1.Text);
                    command.Parameters.AddWithValue("@b", textBox2.Text);
                    command.Parameters.AddWithValue("@c", textBox3.Text);
                    command.Parameters.AddWithValue("@d", textBox4.Text);
                    command.Parameters.AddWithValue("@f", textBox5.Text);
                    command.Parameters.AddWithValue("@e", comboBox1.Text);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Пользователь добавлен");
                    db.closeconn();
                    this.пользовательTableAdapter.Fill(this.уП07_ИСП2_КузнецовDataSet2.Пользователь);
                }
            }
        }
        private void button7_Click(object sender, EventArgs e)
        {
            panel3a.Visible = true;
        }
        private void button9_Click(object sender, EventArgs e)
        {
            db db = new db();
            db.openconn();
            string query = ("DELETE Пользователь Товар [Код пользователя]=@id");
            SqlCommand command = new SqlCommand(query, db.getconn());
            command.Parameters.AddWithValue("@id", dataGridView1[0, dataGridView1.CurrentRow.Index].Value.ToString());
            command.ExecuteNonQuery();
            MessageBox.Show("Запись удалена");
            db.closeconn();
            this.пользовательTableAdapter.Fill(this.уП07_ИСП2_КузнецовDataSet2.Пользователь);
        }
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            panel4.Hide();
        }
        private void button10_Click(object sender, EventArgs e)
        {
            db db = new db();
            db.openconn();
            if (textBox6.Text == "" || textBox7.Text == "" || textBox8.Text == "" || textBox9.Text == "" || textBox10.Text == "")
            {
                MessageBox.Show("Заполните все поля!");
            }
            else
            {
                SqlCommand command = new SqlCommand("Insert into Товар([Код Каталога], Название, Цена, Описание,[Материал Изготовления]) VALUES ( @a,@b, @c, @d, @f)", db.getconn());
                {
                    command.Parameters.AddWithValue("@a", textBox10.Text);
                    command.Parameters.AddWithValue("@b", textBox7.Text);
                    command.Parameters.AddWithValue("@c", textBox6.Text);
                    command.Parameters.AddWithValue("@d", textBox8.Text);
                    command.Parameters.AddWithValue("@f", textBox9.Text);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Товар Добавлен");
                    db.closeconn();
                    this.товарTableAdapter1.Fill(this.уП07_ИСП2_КузнецовDataSet2.Товар);
                }
            }
        }
        private void panel4_MouseUp(object sender, MouseEventArgs e)
        {
            a = true;
        }
        private void panel4_MouseMove(object sender, MouseEventArgs e)
        {
            if (!a)
            {
                Panel mPanel = (Panel)sender;
                mPanel.Left += e.X - x;
                mPanel.Top += e.Y - y;
            }
        }
        private void panel4_MouseDown(object sender, MouseEventArgs e)
        {
            Panel mPanel = (Panel)sender;
            // стартовая позиция
            x = e.X;
            y = e.Y;
            a = false;//переменная , нажата ли кнопка мыши
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel4.Visible = true;
        }

        private void textBox10_KeyPress(object sender, KeyPressEventArgs e)
        {

                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                }
            


        }

        private void button2_Click(object sender, EventArgs e)
        {
            db db = new db();
            db.openconn();
            string query = ("DELETE FROM Товар WHERE [Код Товара]=@id");
            SqlCommand command = new SqlCommand(query, db.getconn());
            command.Parameters.AddWithValue("@id", dataGridView1[0, dataGridView1.CurrentRow.Index].Value.ToString());
            command.ExecuteNonQuery();
            MessageBox.Show("Запись удалена");
            db.closeconn();
            this.товарTableAdapter1.Fill(this.уП07_ИСП2_КузнецовDataSet2.Товар);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            // установка цвета формы
            panel1.BackColor = colorDialog1.Color;
            panel2.BackColor = colorDialog1.Color;
            panel3a.BackColor = colorDialog1.Color;
            Form2 form2 = new Form2();
            form2.BackColor = colorDialog1.Color;
        }
    }
}
