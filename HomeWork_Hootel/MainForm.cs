using System.Globalization;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using System.Text.RegularExpressions;
using System.Xml;
using System;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;
using static System.Windows.Forms.DataFormats;
using Microsoft.VisualBasic.ApplicationServices;
using System.Reflection;
using static System.Net.Mime.MediaTypeNames;
using HomeWork_Hotel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;
using System.Reflection.Emit;
using System.Xml.Linq;
using HomeWork_Hootel.Properties;

namespace HomeWork_Hotel
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            image.SizeMode = PictureBoxSizeMode.Zoom;
            StartPosition = FormStartPosition.CenterScreen;
            foreach (var line in File.ReadLines(@".\..\..\..\Info.txt"))
            {
                var array = line.Split("|");
                persons.Add(new Guest(array[0], array[1], array[2], array[3], array[4], array[5], array[6], char.Parse(array[7]), array[8], array[9]));
            }
            foreach (var a in persons)
            {
                Tabel.Rows.Add(a.full_name, a.status, a.room, a.check, a.departure);
            }
            for (int i = 0; i < Tabel.Rows.Count; i++)
            {
              
               if (Tabel[2,i].Value.ToString().Trim() != Tabel[2,Tabel.Rows.Count-1].Value.ToString().Trim())
                {
                    continue;
                }
                else
                {
                    Tabel.Rows.RemoveAt(i);
                    persons.RemoveAt(i);
                    break;
                }
                        
            }
        }
        int number;

        List<Guest> persons = new List<Guest>();

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            time.Text = DateTime.Now.ToString(" hh : mm : ss tt", CultureInfo.InvariantCulture);

        }

        private void Activate(object sender, EventArgs e)
        {
            Tabel.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            timer.Start();
        }

        private void free_status_CheckedChanged_1(object sender, EventArgs e)
        {
            for (int i = 0; i < Tabel.Rows.Count; i++)
                Tabel.Rows[i].Visible = Tabel[1, i].Value.ToString() == "свободно";
        }
        private void busy_status_CheckedChanged_1(object sender, EventArgs e)
        {
            for (int i = 0; i < Tabel.Rows.Count; i++)
                Tabel.Rows[i].Visible = Tabel[1, i].Value.ToString() == "занято";
        }

        private void discharged_status_CheckedChanged_1(object sender, EventArgs e)
        {
            for (int i = 0; i < Tabel.Rows.Count; i++)
                Tabel.Rows[i].Visible = Tabel[1, i].Value.ToString() == "выписывается";
        }

        private void reserved_status_CheckedChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < Tabel.Rows.Count; i++)
                Tabel.Rows[i].Visible = Tabel[1, i].Value.ToString() == "зарезервировано";
        }

        private void Clear(object sender, EventArgs e)
        {
            searching.Clear();
        }

        private void Tabel_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            button_info.Text = "Просмотр карточки";
            number = Tabel.CurrentCell.RowIndex;
            if (Tabel[0, number].Value.ToString().Trim() == "-")
                button_info.Text = "Заселить";
            name.Text = persons[number].full_name;
            status_.Text = persons[number].status;
            room.Text = "Номер " + persons[number].room;
            check.Text = persons[number].check;
            exit.Text = persons[number].departure;
            try
            {
                image.Image = System.Drawing.Image.FromFile(persons[number].image);
            }
            catch
            {
                MessageBox.Show("Фото нового гостя было выбрано из неверной папки");
            }
            if (name.Text.Equals("-"))
            {

                name.Text = "Номер никем не \nзаселен";
                closer.Hide();
            }
            else
            {
                closer.Hide();
            }

        }

        private void button_info_Click(object sender, EventArgs e)
        {
            try
            {
                InfoAboutPerson infoForm = new InfoAboutPerson
                {
                    _Name = persons[number].full_name,
                    _Bday = persons[number].bday,
                    _Pets = persons[number].animals,
                    _Payment = persons[number].payment,
                    _Days = persons[number].days
                };
                NewPerson create = new NewPerson()
                {
                    Number = persons[number].room
                };
                persons[number].full_name = infoForm._Name;
                persons[number].bday = infoForm._Bday;
                persons[number].animals = infoForm._Pets;
                persons[number].payment = infoForm._Payment.ToString();
                persons[number].days = infoForm._Days.ToString();
                if (persons[number].full_name.Equals("-"))
                {
                    create.Show();
                }
                else
                {
                    infoForm.Show();
                }
            }
            catch
            {
                MessageBox.Show("Для просмотра карточки выберите гостя");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < Tabel.Rows.Count; i++)
            {
                Tabel.Rows[i].Visible = false;
                for (int c = 0; c < Tabel.Columns.Count; c++)
                {
                    if (Tabel[c, i].Value.ToString() == searching.Text)
                    {
                        Tabel.Rows[i].Visible = true;
                        Tabel.Rows[i].DefaultCellStyle.BackColor = Color.Lavender;
                        break;
                    }
                }
            }

        }
    }
}

