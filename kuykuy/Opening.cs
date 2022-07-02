using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kuykuy
{
    class Opening
    {
        private int ak = 0;
        private string[] aku;
        public void Header1()
        {
            Console.SetWindowSize(52, 43);
            Console.SetBufferSize(52, 43);
            Console.WriteLine("\n\n\n\n");
            var n0 = "                 ######    ## ##                  ";
            var n1 = "                ##    ##   ## ##                  ";
            var n2 = "                ##       #########                ";
            var n3 = "                ##         ## ##                  ";
            var n4 = "                ##       #########                ";
            var n5 = "                ##    ##   ## ##                  ";
            var n6 = "                 ######    ## ##                  ";
            var h0 = "+--------------------------------------------------+\n";
            var h1 = "+                                                  +\n";
            var h2 = "+               * Pemrograman C# *                 +\n";
            var h3 = "+                                                  +\n";
            var h4 = "+--------------------------------------------------+\n";
            var h5 = "+--------------------------------------------------+\n";
            var h6 = "+            * Dibuat Oleh S1 IF 01 *              +\n";
            var h7 = "+--------------------------------------------------+\n";

            aku = new string[] {
                n0, n1, n2, n3, n4, n5, n6
            };
            for (int i = 0; i < 7; i++)
                Console.WriteLine(aku[i]);
            Console.WriteLine("\n\n\n\n");
            aku = new string[] {
                h0,h1,h2,h3,h4,h5,h6,h7,h7
            };
            for (int i = 0; i < 8; i++) {
                Console.WriteLine(string.Format("{0," + ((Console.WindowWidth / 2) + (aku[i].Length / 2)) + "}", aku[i]));
            }

            Console.Write("Press Any Key To Continue....");
            Console.ReadKey();
        }
    }
}
