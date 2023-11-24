using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Practice13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            Console.WriteLine(rnd.Next());
        }
        static void Exmp1()
        {
            List<int>col1 = new List<int>();
            Random random = new Random();
            for(int i=0;i<100; i++)
            {
                col1.Add(random.Next(1,100));
            }
            int max1 = 0;
            int x = 0;
            for(int i = 0; i < 100; i++)
            {
                if(col1.ElementAt(i)>max1)
                {
                    max1 = col1.ElementAt(i);
                    x = i;
                }
            }
            col1.RemoveAt(x);
            int max2 = 0;
            for (int i = 0; i < 99; i++)
            {
                if(col1.ElementAt(i)> max2)
                {
                    max2 = col1.ElementAt(i);
                }
            }
            Console.WriteLine(max1);
            Console.WriteLine(max2);
            for(int i = 0; i < 99; i++)
            {
                if(i%2==0)
                {
                    col1.Remove(i); 
                }
            }
        }
        static void Exmp2()
        {
            List<double> numbers = new List<double>();
            numbers.Add(1.3);
            numbers.Add(2.6);
            numbers.Add(3.8);
            numbers.Add(4.2);

            double sum = 0;
            for(int i = 0; i <numbers.Count; i++)
            {
                sum += numbers[i];
            }
            double average = sum / numbers.Count;
            Console.WriteLine(average);
        }
        static void Exmp3()
        {
            List<int> number1 = new List<int>();
            List<int> number2 = new List<int>();

            Random random = new Random();

            for (int i = 0; i < 10; i++)
            {
                number1.Add(random.Next(100));
            }
            int k = 9;
            for (int i = 0; i < 10; i++)
            {
                number2.Add(number1[k]);
                k--;
            }
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(number2 + " ");
            }
        }
        class Employee
        {
            public string Lastname { get; set; }
            public string Firstname { get; set; }
            public string Middlename { get; set; }
            public string Gender { get; set; }
            public int age { get; set; }

            public double salary { get; set; }
        }
        class service
        {
            private List<Employee> employees = null;
            public service()
            {
                employees = new List<Employee>();
            }
            public void addEmployee(string Firstname, string Lastname, string Middlename, string Gender, int age, int salary)
            {
                employees.Add(new Employee( )
                {
                    Firstname = Firstname,
                    Lastname = Lastname,
                    Gender = Gender,
                    age = age,
                    salary = salary
                
                });
            }
            public void showEmployee()
            {
                int k=1;
                int l = 1;
                foreach (Employee emp in employees)
                {
                    if (emp.salary < 100000)
                    {
                        emp.Id = k++;
                    }
                }
                foreach (Employee emp in employees.OrderBy());
            }

        }

    }
}
