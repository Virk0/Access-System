using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessSystem
{
    public class DoorChoices2
    {
        public static void Doorchoices2()
        {
            var tööNooremArendaja = new NooremArendaja();
            var tööVanemArendaja = new VanemArendaja();
            var tööKoristaja = new Koristaja();
            var tööSpetsiaalKoristaja = new SpetsiaalKoristaja();
            var tööÜlemus = new Ülemus();
            var tööAndmeTöötleja = new AndmeTöötleja();
            var uksPeauks = new Peauks();
            var uksKöögiUks = new KöögiUks();
            var uksAndmeTöötlejateRuumiUks = new AndmeTöötlejateRuumiUks();
            var uksArendajateRuumiUks = new ArendajateRuumiUks();
            var uksÜlemusteRuumiUks = new ÜlemusteRuumiUks();
            Console.WriteLine("Which room would you like to enter?");
            Console.WriteLine("1." + uksPeauks.DoorSign);
            Console.WriteLine("2." + uksKöögiUks.DoorSign);
            Console.WriteLine("3." + uksAndmeTöötlejateRuumiUks.DoorSign);
            Console.WriteLine("4." + uksArendajateRuumiUks.DoorSign);
            Console.WriteLine("5." + uksÜlemusteRuumiUks.DoorSign);
            string doorChoice = Console.ReadLine();
            if (doorChoice == "1")
            {
                if ()
            }
        }
    }
}
