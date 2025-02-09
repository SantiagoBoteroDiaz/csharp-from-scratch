using System.Reflection;
using System.Runtime.ConstrainedExecution;

namespace HelloWorld
{
    class Program
    {

        static void Main()
        {
            /*Data Type*/
            DateOnly dateConverted = new DateOnly();
            string nameImput;
            string BirthdayInput;


            Console.WriteLine("Hola bienvenido al calculador de años");
            Console.WriteLine("Escribe tu nombre: ");
            nameImput = Console.ReadLine();
            Console.WriteLine($"Un gusto conocerte {nameImput}");
            Console.WriteLine("Escribe tu fecha de nacimiento en formato dd/mm/yy: ");
            BirthdayInput = Console.ReadLine();
            bool isDateValid = DateOnly.TryParse(BirthdayInput, out dateConverted);
            if (isDateValid == false) Console.WriteLine($"La fecha de nacimiento es invalida usted nos envio este dato erroneo {BirthdayInput} ");
            var person = new Person
            {
                Name = nameImput,
                Birthday = dateConverted,
                Age = DateTime.Now.Year - dateConverted.Year
            };
            Console.WriteLine($"Tu nombre: {nameImput}");
            Console.WriteLine($"Tu edad es: {person.Age} años");
            Console.ReadLine();
        }
        
    }
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public DateOnly Birthday { get; set; }
    }
}