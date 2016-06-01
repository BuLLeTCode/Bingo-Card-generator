using System;
using System.Linq;

namespace BingoCards
{
    class Program
    {
        public static string[] GetCard()
        {
            string[] bingoCards = new string[24];

            for (int i = 0; i < 24; i++)
            {
                string bingo;
                if (i < 5)
                {
                    do
                    {
                        bingo = GenerateBingElement("B", 1, 15);
                    } while (bingoCards.Contains(bingo));

                    bingoCards.SetValue(bingo, i);
                }
                else if (i < 10)
                {
                    do
                    {
                        bingo = GenerateBingElement("I", 16, 30);
                    } while (bingoCards.Contains(bingo));

                    bingoCards.SetValue(bingo, i);
                }
                else if (i < 14)
                {
                    do
                    {
                        bingo = GenerateBingElement("N", 31, 45);
                    } while (bingoCards.Contains(bingo));
                    bingoCards.SetValue(bingo, i);
                }
                else if (i < 19)
                {
                    do
                    {
                        bingo = GenerateBingElement("G", 46, 60);
                    } while (bingoCards.Contains(bingo));
                    bingoCards.SetValue(bingo, i);
                }
                else if (i < 24)
                {
                    do
                    {
                        bingo = GenerateBingElement("O", 61, 75);
                    } while (bingoCards.Contains(bingo));
                    bingoCards.SetValue(bingo, i);
                }
            }

            return bingoCards;
        }

        private static string GenerateBingElement(string letter, int minValue, int maxValue)
        {
            var rand = new Random();
            return letter + Convert.ToString(rand.Next(minValue, maxValue));
        }

        static void Main()
        {
            foreach (var card in GetCard())
            {
                Console.WriteLine(card);
            }
            Console.ReadKey();

            var cards = GetCard();
            Console.WriteLine("LEN" + cards.Length);
            Console.WriteLine("Dist" + cards.ToList().Distinct().Count());
            foreach (var distCard in cards.ToList().Distinct())
            {
                Console.WriteLine(distCard);
            }
            Console.ReadKey();
        }
    }
}
