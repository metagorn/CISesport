using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CISesport
{
    public class Player
    {
        string name, lastname, studentid, major, displayname, maill, phone;
        private int age = 0;
        
        public Player(string name, string lastname, string studentid, string major, string displayname, string maill, 
            string phone, int age)
        {
            this.name = name;
            this.lastname = lastname;
            this.studentid = studentid;
            this.major = major;
            this.displayname = displayname;
            this.maill = maill;
            this.phone = phone;
            this.age = age;
        }
    }
}
