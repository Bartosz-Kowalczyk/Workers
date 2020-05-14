using System;
using System.Collections.Generic;

namespace Workers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Worker> myWorkers = new List<Worker>();
            string newName, newDepartment, newLogin, newPassword = "";

            AddNewWorker(); 

            void AddNewWorker()
            {
                Console.WriteLine("Podaj nazwisko:");
                newName = Console.ReadLine();
                Console.WriteLine("Podaj departmanet:");
                newDepartment = Console.ReadLine();
                Console.WriteLine("Podaj login:");
                newLogin = Console.ReadLine();

                while (newPassword.Length < 6)
                {
                    Console.WriteLine("Podaj hasło:");
                    newPassword = Console.ReadLine();

                    if (newPassword.Length < 6)
                    {
                        Console.WriteLine("Hasło musi posiadać przynajmniej 6 znaków.");
                    }
                    else
                    {
                        Console.WriteLine("Hasło prawidłowe. Użytkownik dodany do bazy.");
                        myWorkers.Add(new Worker() { name = newName, department = newDepartment, login = newLogin, password = newPassword });
                    }
                }
            }

            myWorkers.Add(new Worker() { name = "Kowalski" , department = "Księgowość" , login = "kow1265", password = "kdfh74t7" });
            myWorkers.Add(new Worker() { name = "Nowak", department = "Handel", login = "now467", password = "vhhyyt45" });

            foreach (Worker w in myWorkers)
                Console.WriteLine(w.name + " / " + w.department + " / " + w.login);

            Console.Read(); 
        }
    }
}
