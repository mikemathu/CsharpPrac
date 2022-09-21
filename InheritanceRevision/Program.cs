using InheritanceRevision;

namespace Revision
{
    class Program
    {
        public class FileFormatException : Exception
        {
            public FileFormatException() : base()
            {

            }

            //constructor taking a string and instead of handling itself it lets inherited constructor hanlde it instead
            public FileFormatException(String s) : base(s)
            {
                throw new FileFormatException("Your file is not well formateted");
            }



        }
        static void Main(string[] args)
        {
            //Console.Write("Hello mike");
            /*  Employee emp1 = new Employee();
              emp1.Name = "Mathu";
              emp1.Age = 23;
              emp1.Id = 11327;
              emp1.Pay = 12000;*/
            /*Employee emp = new Employee() { Name = "Mike", Age = 23, Id = 35703436, Pay = 120000 };
            Console.WriteLine(emp.Name);*/
            // Manager mnger = new Manager() { Name = "Mike", Age = 23, Id = 35703436, Pay = 120000 };
            /*Manager mnger = new Manager("Mike", 23, 35703436,120000, "SB30/17/40163", 111) ;
           Console.WriteLine(mnger.Name);*/

            /*    SalesPerson fred = new SalesPerson
                {
                    Age = 31,
                    Name = "Fred",
                    SalesNumber = 50
                };

                fred.DisplayStats();*/

            //COMPARE GENERICS
            string one = "Hello World";
            string two = "Hello World ";
          /*  if (one.Equals(two))
            {
                Console.Write("String :");
                Console.Write("they are the same");
            }

            else
            {
                Console.Write("String :");
                Console.Write("Not the same");
            }*/

           /* Object o = one;
            Object t = two;*/

            Object o = "Mike";
            Object t = "Mike ";
            if (o.Equals(t))
            {
                Console.WriteLine();
                Console.Write("Object :");
                Console.Write("they are the same");
            }

            else
            {
                Console.WriteLine();
                Console.Write("Object :");
                Console.Write("Not the same");
            }


        }
    }
}