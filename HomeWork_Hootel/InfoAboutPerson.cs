using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Security.Cryptography.Xml;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace HomeWork_Hotel
{
    public partial class InfoAboutPerson : Form
    {
        public InfoAboutPerson()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }
        public new string _Name
        {
            get { return InfoName.Text; }
            set { InfoName.Text = value; }
        }
        public new string _Bday
        {
            get { return Info_bday.Text; }
            set { Info_bday.Text = value; }
        }
        public new string _Payment
        {
            get
            {
                return Info_payment.Text;
            }
            set
            {
                Info_payment.Text = value;
            }
        }
        public new char _Pets
        {
            get { return char.Parse(Info_pets.Text); }
            set
            {
                char a = char.Parse(Info_pets.Text);
                a = value;
            }
        }
        public new string _Days
        {
            get
            {
                return Info_days.Text;
            }
            set
            {

                Info_days.Text = value;
            }
        }
    }
}
