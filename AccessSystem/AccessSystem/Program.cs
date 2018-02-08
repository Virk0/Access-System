using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessSystem
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var tööNooremArendaja = new NooremArendaja();
            var tööVanemArendaja = new VanemArendaja();
            var tööKoristaja = new Koristaja();
            var tööSpetsiaalKoristaja = new SpetsiaalKoristaja();
            var tööÜlemus = new Ülemus();
            var tööAndmeTöötleja = new AndmeTöötleja();
            var UserJob = "";
            Console.WriteLine("Choose your job");
            Console.WriteLine("Options are:");
            Console.WriteLine("1." + tööKoristaja.Name);
            Console.WriteLine("2." + tööSpetsiaalKoristaja.Name);
            Console.WriteLine("3." + tööNooremArendaja.Name);
            Console.WriteLine("4." + tööVanemArendaja.Name);
            Console.WriteLine("5." + tööAndmeTöötleja.Name);
            Console.WriteLine("6." + tööÜlemus.Name);
            string choiceJob = Console.ReadLine();
            if (choiceJob == "1")
            {
                UserJob = tööKoristaja.Name;
                Console.WriteLine("Would you like to know the access level of this job?\n[Y/N]");
                string choiceJob2 = Console.ReadLine();
                if (choiceJob2 == "Y")
                {
                    tööKoristaja.defineJob();
                }
                if (choiceJob2 == "N")
                {
                    Console.WriteLine("Your choice");
                }
                Console.ReadLine();
                DoorChoices.Doorchoices();
            }
            if (choiceJob == "2")
            {
                UserJob = tööSpetsiaalKoristaja.Name;
                Console.WriteLine("Would you like to know the access level of this job?\n[Y/N]");
                string choiceJob2 = Console.ReadLine();
                if (choiceJob2 == "Y")
                {
                    tööSpetsiaalKoristaja.defineJob();
                }
                if (choiceJob2 == "N")
                {
                    Console.WriteLine("Your choice");
                }
                Console.ReadLine();
                DoorChoices.Doorchoices();
            }
            if (choiceJob == "3")
            {
                UserJob = tööNooremArendaja.Name;
                Console.WriteLine("Would you like to know the access level of this job?\n[Y/N]");
                string choiceJob2 = Console.ReadLine();
                if (choiceJob2 == "Y")
                {
                    tööNooremArendaja.defineJob();
                }
                if (choiceJob2 == "N")
                {
                    Console.WriteLine("Your choice");
                }
                Console.ReadLine();
                DoorChoices.Doorchoices();
            }
            if (choiceJob == "4")
            {
                UserJob = tööVanemArendaja.Name;
                Console.WriteLine("Would you like to know the access level of this job?\n[Y/N]");
                string choiceJob2 = Console.ReadLine();
                if (choiceJob2 == "Y")
                {
                    tööVanemArendaja.defineJob();
                }
                if (choiceJob2 == "N")
                {
                    Console.WriteLine("Your choice");
                }
                Console.ReadLine();
                DoorChoices.Doorchoices();
            }
            if (choiceJob == "5")
            {
                UserJob = tööAndmeTöötleja.Name;
                Console.WriteLine("Would you like to know the access level of this job?\n[Y/N]");
                string choiceJob2 = Console.ReadLine();
                if (choiceJob2 == "Y")
                {
                    tööAndmeTöötleja.defineJob();
                }
                if (choiceJob2 == "N")
                {
                    Console.WriteLine("Your choice");
                }
                Console.ReadLine();
                DoorChoices.Doorchoices();
            }
            if (choiceJob == "6")
            {
                UserJob = tööÜlemus.Name;
                Console.WriteLine("Would you like to know the access level of this job?\n[Y/N]");
                string choiceJob2 = Console.ReadLine();
                if (choiceJob2 == "Y")
                {
                    tööÜlemus.defineJob();
                }
                if (choiceJob2 == "N")
                {
                    Console.WriteLine("Your choice");
                }
                Console.ReadLine();
                DoorChoices.Doorchoices();

            }
        }
    }
}
