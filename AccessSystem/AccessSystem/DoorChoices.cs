using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessSystem
{
    public class DoorChoices
    {
        public static void Doorchoices()
        {
            var uksPeauks = new Peauks();
            var uksKöögiUks = new KöögiUks();
            var uksAndmeTöötlejateRuumiUks = new AndmeTöötlejateRuumiUks();
            var uksArendajateRuumiUks = new ArendajateRuumiUks();
            var uksÜlemusteRuumiUks = new ÜlemusteRuumiUks();
            Console.WriteLine("Which room would you like to enter?");
            Console.WriteLine("1."+ uksPeauks.DoorSign);
            Console.WriteLine("2."+uksKöögiUks.DoorSign);
            Console.WriteLine("3."+uksAndmeTöötlejateRuumiUks.DoorSign);
            Console.WriteLine("4."+uksArendajateRuumiUks.DoorSign);
            Console.WriteLine("5."+uksÜlemusteRuumiUks);
            string doorChoice = Console.ReadLine();
        }
    }
}
