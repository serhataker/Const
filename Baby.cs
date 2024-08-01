using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Const
{
    public class Baby
    {
        private string name;
        private string surName;
        private DateTime birthDate;

        public string Name { get { return name; }
        
        set { name = value; }
        }

        public string Surname { 
            get { return surName; }
            set { surName = value; } 

        }

        public DateTime BirthDate
        {

            get { return birthDate; }
            set { birthDate = value; }
        }

        public Baby()
        {
            Console.WriteLine("Ingaaaa");
            birthDate = DateTime.Now;
            
        }
        public  Baby(string name,string surName)
        {
            Console.WriteLine("Ingaaaa");
            this.Name = name;
            this.Surname = surName;
            this.birthDate=DateTime.Now;
        }
    }
}
