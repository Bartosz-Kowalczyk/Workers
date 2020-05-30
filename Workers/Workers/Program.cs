using System;
using System.Collections.Generic;
using System.Linq;
using MyGenerators;

namespace Workers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Worker> myWorkers = new List<Worker>();
            string newName, newDepartment, newLogin, newPassword = "";
            int passSize = 8;

            myWorkers.Add(new Worker() { name = "Kowalski", department = "Księgowość", login = "kow1265", password = "kdfh74t7" });
            myWorkers.Add(new Worker() { name = "Nowak", department = "Handel", login = "now467", password = "vhhyyt45" });
            myWorkers.Add(new Worker() { name = "Piątkowski", department = "IT", login = "pia286", password = "sdfgr546" });
            myWorkers.Add(new Worker() { name = "Kociemba", department = "Marketing", login = "koc909", password = "sdfrtb45" });
            myWorkers.Add(new Worker() { name = "Małysz", department = "HR", login = "mal334", password = "sjkduy56" });
            myWorkers.Add(new Worker() { name = "Zarzycki", department = "IT", login = "zar846", password = "sdfhjk345" });

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

            void ShowWorkers()
            {
                myWorkers = myWorkers.OrderBy(p => p.name).ToList();
                myWorkers.ForEach(p => Console.WriteLine(p.name));
            }

            void SetNewPass()
            {
                myWorkers.ForEach(p => p.password = NewPasswords.GeneratePassword(true, true, true, false, passSize));
            }

            void SelectWorkers()
            {
                var wrks = from w in myWorkers
                           where w.department == "IT"
                           || w.department == "HR"
                           select w;
            }

            ShowWorkers();
            SetNewPass();
            SelectWorkers(); 

            Console.Read();

       


        }
    }
}
