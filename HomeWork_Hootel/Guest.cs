using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Web;

namespace HomeWork_Hotel
{
    public class Guest
    {
        public string full_name;
        public string status;
        public string room;
        public string check;
        public string departure;
        public string days;
        public string payment;
        public char animals;
        public string image;
        public string bday;
        public Guest(string full_name, string status, string room, string check, string departure, string days, string payment, char animals, string image, string bday)
        {
            this.full_name = full_name;
            this.status = status;
            this.room = room;
            this.check = check;
            this.departure = departure;
            this.days = days;
            this.payment = payment;
            this.animals = animals;
            this.image = image;
            this.bday = bday;
        }
    }
}
