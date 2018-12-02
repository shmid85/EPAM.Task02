using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPAM.Task02._2._3.USER
{
    class User
    {
        private string name;
        private string sername;
        private string middlename;
        private DateTime birthdate;
        private int age;

        public string Name {
            get => name;
            set {



            }
        }
        public string Sername { get => sername; set => sername = value; }
        public string Middlename { get => middlename; set => middlename = value; }
        public DateTime Birthdate { get => birthdate; set => birthdate = value; }
        public int Age
        {
            get => age;
            set
            {
                if (value > 0)
                {
                    age = value;
                }
                else throw new ArgumentException("Возвраст долен быть больше нуля", nameof(age));
            }
        }
    }
}
