using System;

namespace It_Academy
{
    class Program
    {
        
        static void Main()
        { 
            var chel = new Person();
            //chel.Name = null;        //использовал для проверки правильно ли все работает, т.к. с консоли ввести null нет возможности
            //chel.LastName = null;   //к слову, доступ к сеттерам я заприватил, потому что часть логики храится в методах класса
            //chel.Age = 0;
            chel.SetFullInfo();
            chel.GetFullInfo();



        }
    }
    
}