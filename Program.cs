namespace Hw_2_2
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var BlackCandy = new Gift()
            {
                Name = "Roshen",
                weigtOfCandy = 0.50,
            };
            var WhiteChokolate = new Chokolate()
            {
                WhiteChokolate = true,
                DarkChokolate = false,
            };
            var WhiteCandy = new Gift()
            {
                Name = "Shogatten",
                weigtOfCandy = 0.50
            };
            var DarkChokolate = new Chokolate()
            {
                DarkChokolate = true,
                WhiteChokolate = false,
            };
            var setofwaffles = new Gift()
            {
                Name = "Loaker",
                weigtOfCandy = 0.200,
                waffles = new Waffles[]
                {
                    new Waffles(){waffles = "Трубочка",}, new Waffles() {waffles = "Черно Белая"}, new Waffles(){waffles = "Черный шоколад"},
                    new Waffles(){waffles = "Белый шоколад"},
                },
            };
            Gift NewGift = new Gift();
            int choise;
            int countOfIter = 0;
            void DoPackage(IBox pack)
            {
                pack.Package();
            }
            do
            {
                Console.WriteLine("Choose Sweet what you want ? :  \n1. BlackCandy \t2. WhiteCandy \t3. Waffles");
                choise  = int.Parse(Console.ReadLine());
                switch (choise)
                {
                    case 1:
                        NewGift.AddCandyGift(BlackCandy);
                        DoPackage(BlackCandy);
                        NewGift.ShowCandy();
                        break;
                    case 2:
                        NewGift.AddCandyGift(WhiteCandy);
                        DoPackage(WhiteCandy);
                        NewGift.ShowCandy();
                        break;
                    case 3:
                        NewGift.AddCandyGift(setofwaffles);
                        DoPackage(setofwaffles);
                        NewGift.ShowCandy();
                        break;
                    default:
                        break;
                }
                countOfIter++;
            }
            while (countOfIter != 3);

            NewGift.Sort();
            NewGift.SearchCandy();
        }
    }
}