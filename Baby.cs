using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Const
{
    public class Baby
    {
        private string name;// baby's name field
        private string surName;// baby's surname field
        private DateTime birthDate;// baby's birth date field

        public string Name { get { return name; } //create to the Name Property
        
        set { name = value; }
        }

        public string Surname { //create to the SurName Property
        
            get { return surName; }
            set { surName = value; } 

        }

        public DateTime BirthDate //create to the Birth Date Property
        {

            get { return birthDate; }
            set { birthDate = value; }
        }

        public Baby() // Cosntructor method any parametres for baby instance
        {
            Console.WriteLine("Ingaaaa");//result the message
            BirthDate = DateTime.Now;//assign the datebirth property date at now

        }
        public  Baby(string name,string surName)// Cosntructor method with name surname parametres for baby instance
        {
            Console.WriteLine("Ingaaaa");
            this.Name = name;// assaign to the Name property variable
            this.Surname = surName; //assign to the  sur anme Name property variable
            this.BirthDate=DateTime.Now; //assign the datebirth property date at now
        }
    }
}
