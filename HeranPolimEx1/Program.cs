using System;
using System.Globalization;
using HeranPolimEx1.Entites;
using System.Collections.Generic; 

namespace HeranPolimEx1
{
    class Program
    {
        static void Main(string[] args)
        {// Usa a lista de funcionario, para guardar as informações.
            List<Employee> list = new List<Employee>();

            Console.WriteLine("Enter the number of employees: ");
            int n = int.Parse(Console.ReadLine());// O usuario digita a quantidade de empregados.
            
            //fazamos um laço for para percorrer e guardar e lê os dados do funcionarios
            for(int i = 1;i <= n; i++)
            {
                Console.WriteLine($"Employee #{i} date: ");
                Console.Write("Outsourced (y/n)? ");//[é tercerizado ou não? ]
                char ch = char.Parse(Console.ReadLine());// salvei na variavél 
                Console.WriteLine("Name: ");
                string name = Console.ReadLine();
                Console.Write("Hours: ");
                int hours = int.Parse(Console.ReadLine());
                Console.Write("Value per Hours: ");
                double valuPerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                if(ch == 'y')// Vou fazer os testes, se o empregado for tercerizado, será add o valor a eles
                {
                    Console.WriteLine("Additional charge: ");
                    double additionalharge = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new OutsourcedEmployee(name, hours, valuPerHour, additionalharge));
                    // acima eu chamo a lista e salvo os dados de cada empregado se ele for tercerizado.
                }
                else     //Montamos o ELSE para instanciar o funcionario e add na lista, caso ele seja um funcionario comun.
                {
                    list.Add(new Employee(name, hours, valuPerHour));

                }
            }

            Console.WriteLine();
            Console.WriteLine(" PAYMENTS: ");
            foreach(Employee emp in list)//irei percorrer a lista ---(Para cada funcionario na minha list eu irei fazer? digo a baixo)
            {
                Console.WriteLine(emp.Name + " - $" + emp.Payment().ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}
