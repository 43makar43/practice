using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Scripts
{
    public class Person
    {
        private string _firstName = "Анатолий";
        private string _secondName = "Кузин";
        private string _middleName = "Петрович";
        private double _money = 70000;

        public Person()
        {
           
        }

        public string FirstName
        {
            set
            {
                if (value == null)
                    _firstName = "Хуй";
                else
                    _firstName = value;
            }
            get { return _firstName; }
        }
        public string SecondName
        {
            set
            {
                if (value == null)
                    _secondName = "Хуй";
                else
                    _secondName = value;
            }
            get { return _secondName; }
        }
        public string MiddleName
        {
            set
            {
                if (value == null)
                    _middleName = "Хуй";
                else
                    _middleName = value;
            }
            get { return _middleName; }
        }
        public double Money
        {
            get { return _money; }
        }
    }
}
