using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace ContactList
{
    public class ContactList
    {
        private string _name;

        public string Surname { get; set; }
        public string Address { get; set; }
        public List<string> PhoneNumbers { get; set; }

        public Contact() { }   

        public Contact(string name, string surname, string address, List<string> phoneNumbers)
        {
            _name = name.Length > 4 && name.Length < 10 ? name : throw new Exception("Inavlid name");
            _name = name;
            Surname = surname;
            Address = address;

            if (phoneNumbers.Count <= 5)
            {
                bool flag = true;

                for (int i = 0; i < phoneNumbers.Count; i++)
                {
                    if (!(phoneNumbers[i].Count() == 9 && (phoneNumbers[i].StartsWith("071") || phoneNumbers[i].StartsWith("070") ||
                        phoneNumbers[i].StartsWith("072") || phoneNumbers[i].StartsWith("075") || phoneNumbers[i].StartsWith("076") ||
                        phoneNumbers[i].StartsWith("077") || phoneNumbers[i].StartsWith("078"))))
                    {
                        flag = false;
                    }
                }
                if (flag)
                {
                    PhoneNumbers = phoneNumbers;
                }
            }
            else
            {
                throw new Exception("List has more the 5 elments");
            }
            
        }

        public string getName() 
        {
            //return Name; 
            return _name;
        }
        public string getNumbers()
        {
            string savePosition = "";
            for(int i = 0;i < PhoneNumbers.Count;i++)
            {
                for(int j = i; j < PhoneNumbers[i].Count(); j++)
                {
                    if (PhoneNumbers[i].CompareTo(PhoneNumbers[j])>0)
                    {
                        savePosition = PhoneNumbers[i];
                        PhoneNumbers[i] = PhoneNumbers[j];
                        PhoneNumbers[j] = savePosition;
                    }
                }

            }
            return PhoneNumbers;
        }
    }
    public string addNumber(string number)
    {
        if (PhoneNumbers.Count < 5)
        {
            PhoneNumbers.Add(number);
            return "Add a number";

        }
    }
}
