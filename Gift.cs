using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hw_2_2
{
    internal class Gift : IBox
    {
        public string Name { get; set; }
        public Waffles[] waffles { get; set; }
        public double weigtOfCandy { get; set; }
        public const int ArraySize = 3;
        private Gift[] NewYearGift = new Gift[ArraySize];
        private int CandyCount = 0;
        public double weightAllCandy = 0;
        private double GiftWeigt = 0;
        private int number;

        public void AddCandyGift(Gift t)
        {
            this.NewYearGift[this.CandyCount] = t;
            this.CandyCount++;
        }
        public void Package()
        {
            Console.WriteLine("Sweet number");
            this.number = int.Parse(Console.ReadLine());

            this.weightAllCandy = this.weigtOfCandy * this.number;
            Console.WriteLine();
            Console.WriteLine($"Sweet weight {this.weightAllCandy}");

            GiftWeigt += this.weightAllCandy;
            Console.WriteLine();
            Console.WriteLine($"Weigt Gift {GiftWeigt}");
        }

        public void ShowCandy()
        {
            Console.WriteLine("Gift have sweet: ");
            foreach (Gift candy in this.NewYearGift)
            {
                if (candy != null)
                {
                    Console.WriteLine("{ candy.Name} - { weightAllCandy}");
                }
            }
        }
        public void Sort()
        {
            for (int i = 0; i < this.NewYearGift.Length - 1; i++)
            {
                for (int j = i + 1; j < this.NewYearGift.Length; j++)
                {
                    if (this.NewYearGift[i].weightAllCandy > this.NewYearGift[j].weightAllCandy)
                    {
                        Gift temp = this.NewYearGift[i];
                        this.NewYearGift[i] = this.NewYearGift[j];
                        this.NewYearGift[j] = temp;
                    }
                }
            }

        }
        // Поиск конефет 
        public void SearchCandy()
        {
            double weight = 0.50;
            Gift foundCandy = null;
            foreach (Gift candy in this.NewYearGift)
            {
                if (candy.weigtOfCandy == weight)
                {
                    foundCandy = candy;
                    break;
                }

            }
            if (foundCandy != null)
            {
                Console.WriteLine();
                Console.WriteLine($"Sweet is '{foundCandy.Name}'");
            }
            else
            {
                Console.WriteLine($"Weight candy {weight} dont found in gift ");
            }
        }

    }
}
