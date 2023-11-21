using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace It_Academy
{
    class Club
    {
        private int age;
        public int ConfirmAge { get; set; }
        public int Age
        {
            get { return age; }
            set { age = value; }
        }


        public void club()
        {
            if(this.age >= ConfirmAge)
            Console.WriteLine( "добро пожаловать в клуб");
            else
                Console.WriteLine("Вы слишком мал");
        }


    }
}
