using System;
using System.Collections.Generic;

namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Teacherlog v0.1 Early access");
            Console.WriteLine("///////////////////////////////");
            string name;
            string age_answer;
            int attempt = 0;
            int age;
            List<Student> lstStudents = new List<Student>();
            Console.WriteLine("Lets get started!");
            Console.WriteLine("What is your name?");

            name = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Hello " + name + "!");


            for (attempt = 0; attempt < 3;)
            {
                Console.WriteLine("Do you want to tell me your age?");
                age_answer = Console.ReadLine();
                attempt++;
                if (age_answer == "yes")
                {
                    Console.WriteLine("What is your age?");
                    age = Convert.ToInt32(Console.ReadLine());

                    break;
                }
                else if (age_answer == "no")
                {
                    Console.WriteLine("It is okay, you don't have to tell me your age");
                    break;
                }
                else if (attempt >= 3)
                {
                    Console.WriteLine("Lets just go ahead.. age isn't really that important anyways.");
                    break;
                }
                else
                {
                    Console.WriteLine("I didn't really understand that, lets try again. ( yes / no )");


                }

            }
            do
            {
                Console.Clear();
                Console.WriteLine("Lets work " + name + ", what do you want to do?");
                Console.WriteLine("");
                Console.WriteLine("1. Show your classes");
                Console.WriteLine("2. Add or edit a class");
                Console.WriteLine("3. Edit your information");
                Console.WriteLine("4. Exit");
                var UserInput = Console.ReadKey();
                int Bowl; // Variable to hold number
                if (char.IsDigit(UserInput.KeyChar))
                {
                    Bowl = int.Parse(UserInput.KeyChar.ToString());
                    Console.WriteLine("\nYou choose : {0}", Bowl); // Say what user inserted 
                    switch (Bowl)
                    {
                        case 1:
                            Console.WriteLine("classes");
                            Console.ReadKey();
                            break;
                            
                        case 2:
                            Console.WriteLine("edit");
                            foreach (Student currentSt in lstStudents)
                            {
                                foreach (var prop in currentSt.CustomProperties)
                                {
                                    Console.WriteLine(prop.Key + " " + prop.Value);
                                }

                            }

                            Student objStudent = new Student();
                            
                            Console.WriteLine("What is the firstname?");
                            string firstname = Console.ReadLine();
                            Console.WriteLine("What is the lastname?");
                            string lastname = Console.ReadLine();
                            objStudent.CustomProperties.Add(firstname, lastname);

                            objStudent.CustomProperties.Add("RollNo", 1);

                            lstStudents.Add(objStudent);

                            

                            
                            Console.ReadKey();
                            break;
                        case 3:
                            Console.WriteLine("information");
                            Console.ReadKey();
                            break;
                        case 4:
                            Console.WriteLine("exit");
                            Console.ReadKey();
                            break;
                        default:
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("\nTry again"); // Say what user inserted 
                }
            }
            while (true);








        }
    }
}
