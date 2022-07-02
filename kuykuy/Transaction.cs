using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kuykuy
{
    class Transaction
    {
        public string Invoice { get; set; }
        public string CurrDate { get; set; }

        public Transaction()
        {
            Invoice = "N01/2019/001";
            CurrDate = Convert.ToDateTime(DateTime.Now).ToString("dd-MM-yy");
        }

        public void Sales()
        {
            var sales = $"Invoice: {Invoice}; CurrDate: {CurrDate} ";
            Console.WriteLine(string.Format("{0," + ((Console.WindowWidth / 2) + (sales.Length / 2)) + "}", sales));
        }


        public void Bayar()
        {

            //Console.WriteLine("Total Bayar = Rp. {0}",menu.Input());
            Console.WriteLine("==========================");
            Console.WriteLine("TERIMAKASIH ATAS KUNJUNGANNYA:)");
            Console.ReadLine();
        }
    }
}
