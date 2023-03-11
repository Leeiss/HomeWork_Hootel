using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.LinkLabel;
using System.Collections;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Security.Policy;
using System.Xml.Linq;

namespace HomeWork_Hotel
{
    public partial class NewPerson : Form
    {
        string Image;
        string fileName = @".\..\..\..\Info.txt";
        public new string Number
        {
            get { return number.Text; }
            set { number.Text = value; }
        }

        public NewPerson()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                File.AppendAllText(@".\..\..\..\Info.txt", "\n");
                File.AppendAllText(@".\..\..\..\Info.txt", name.Text + "|" + status.SelectedItem + "|" + number.Text + "|" + date1.Text + "|" + date2.Text + "|" + days.Text + "|" + money.Text + "|" + pets.Text + "|" + ".\\..\\..\\..\\Resources\\"+Image + "|" + date3.Text);
                string[] lines = File.ReadAllLines(fileName);
                string[] readText = File.ReadAllLines(fileName);
                using (StreamWriter writer = new StreamWriter(fileName))
                    foreach (string line in readText)
                    {
                        if (!string.IsNullOrWhiteSpace(line))
                            writer.WriteLine(line);
                    }
            }
            catch
            {
                MessageBox.Show("Поля заполнены некорректно");
            }
            this.Close();

        }

        private void image_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "Image Files(*.BMP;*.JPG;*.GIF;*.PNG)|*.BMP;*.JPG;*.GIF;*.PNG|All files (*.*)|*.*";
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                char end;
                FileInfo address = new FileInfo(fileDialog.FileName);
                Image = address.Name;
            }

        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
