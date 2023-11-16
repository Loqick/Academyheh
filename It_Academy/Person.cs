using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace It_Academy
{
    class Person
    {
        private int? _age = null;
        private string _lastName ="Фамилия"; // добавил чтоб изначально там не хранилось null, даже если ничего не присваивать
        private string _name = "Имя";

        public int? Age
        {
            get { return _age;}

           private set
            {
                if (value > 0)
                {
                    _age = value;
                    return;

                }

                if (value == null)
                {
                    return;
                }

                else
                {
                    Console.WriteLine("Возраст не может быть <=0 ");
                    return;
                }
            }
        }


           
        public string LastName
        { 
            get{ return _lastName;}
            private set
            {
                if (value == null)
                {
                    Console.WriteLine("Фамилия не может быть null");
                    return;
                }

                else
                    _lastName = value;
            } 
        }
        public string Name
        {
            get
            { return _name;}
           private set
            {
                if (value == null)
                {
                    Console.WriteLine("Имя не может быть null");
                    return;
                }

                else
                    _name = value;
            }
        }
        public void GetFullInfo()
        {
            Console.WriteLine($"Age = {Age}\tName = {Name}\tLastName = {LastName}");
        }
        public void SetFullInfo()
        {
            Console.WriteLine("Введите возраст ");
            string ageImput = Console.ReadLine();
            if (int.TryParse(ageImput, out int age))
            {
                Age = age;
            }
            else
            {
                Console.WriteLine("Вы ввели неверное значение, будет присвоино значение по умолчанию: Null");
                Age = null;
            }

            Console.WriteLine("Введите имя ");
            string name = Console.ReadLine();
            Name = name;

            Console.WriteLine("Введите фамилию");
            string lastname = Console.ReadLine();
            LastName = lastname;
        }
    }
}
