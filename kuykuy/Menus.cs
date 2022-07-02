using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kuykuy
{
    class Menus
    {
        private int pilihan = 0;
        private string[] isi;
        //private List<string> Tampung;
        private string pesan;
        List<string> Tampung = new List<string>();

        public void Displaying()
        {
            bool status = true;
            while (status)
            {
                Console.Clear();
                for (int i = 0; i < isi.Length; i++)
                {
                    if (pilihan == i)
                    {
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.BackgroundColor = ConsoleColor.White;


                    }
                    Console.WriteLine("{0}.{1}", i, isi[i]);

                    if (pilihan == i)
                    {
                        Console.ResetColor();

                    }

                }

                var keyPressed = Console.ReadKey();
                if (keyPressed.Key == ConsoleKey.DownArrow)
                {
                    if (pilihan != isi.Length - 1)
                    {
                        pilihan++;
                    }
                }
                else if (keyPressed.Key == ConsoleKey.UpArrow)
                {
                    if (pilihan != 0)
                    {
                        pilihan--;
                    }
                }
                if (keyPressed.Key == ConsoleKey.Enter)
                {
                    status = false;
                }
            }
        }

        public void DisplayMenu()
        {
        
            isi = new string[]
            {
                "Daftar Menu","Pemesanan","Daftar Pesanan","Pembayaran","Exit"
            };
            
            Displaying();
            menup();

        }

        public void menup()
        {
            switch (pilihan)
            {
                case 0:
                    Console.Clear();
                    Pilihan1();
                    break;
                case 1:
                    Console.Clear();
                    Pilihan2();
                    break;
                case 2:
                    Console.Clear();
                    Pilihan3();
                    break;
                case 3:
                    Console.Clear();
                    break;
                case 4:
                    Environment.Exit(0);
                    break;
                default:
                    break;
            }
        }

        public void Pilihan1()
        {
            isi = new string[]
           {
                "Nasi Goreng","Magelangan","Bakmi Goreng","Bakmi Godhog"
           };
            Displaying();
            DisplayMenu();
        }


        public void Pilihan2()
        {
            pesan = " ";
            isi = new string[]
             {
                " Nasi Goreng\n   10.000"," Magelangan\n   12.000"," Bakmi Goreng\n   13.000"," Bakmi Godhog\n   11.000"
             };
            pilihan = 0;
            switch (pilihan)
            {
                case 0:
                   pesan = "Nasi Goreng  Rp.10.000";
                    break;
                case 1:
                    pesan = "Magelangan   Rp.12.000";
                    break;
                case 2:
                    pesan = "Bakmi Goreng  Rp.13.000";
                    break;
                case 3:
                    pesan = "Nasi Godhog  Rp.11.000";
                    break;
                default:
                    break;
            }
            Tampung.Add(pesan);
            
            Displaying();
            DisplayMenu();
        }

        public void Pilihan3()
        {
            for (int i = 0; i < Tampung.Count; i++)
            {
                Console.WriteLine(Tampung[i]);
            }

            Console.ReadKey();
            Displaying();
            DisplayMenu();
        }
    }
}
