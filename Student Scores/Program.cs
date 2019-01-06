using System;

namespace Student_Scores
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal MathScore = 0;
            decimal EnglishScore = 0;
            decimal PhysicsScore = 0;
            decimal ChemistryScore = 0;
            decimal BiologyScore = 0;
            decimal EconomicsScore = 0;
            decimal LiteratureScore = 0;
            decimal YorubaScore = 0;
                     
            
            Console.WriteLine("Hello User!");

            Console.Write("Enter Your Mathematics Score: ");
            MathScore = Decimal.Parse(Console.ReadLine());

            Console.Write("Enter Your English Score: ");
            EnglishScore = Decimal.Parse(Console.ReadLine());
            
            Console.Write("Enter Your Physics Score: ");
            PhysicsScore = Decimal.Parse(Console.ReadLine());

            Console.Write("Enter Your Chemistry Score: ");
            ChemistryScore = Decimal.Parse(Console.ReadLine());

            Console.Write("Enter Your Biology Score: ");
            BiologyScore = Decimal.Parse(Console.ReadLine());

            Console.Write("Enter Your Economics Score: ");
            EconomicsScore = Decimal.Parse(Console.ReadLine());

            Console.Write("Enter Your Literature Score: ");
            LiteratureScore = Decimal.Parse(Console.ReadLine());

            Console.Write("Enter Your Yoruba Score: ");
            YorubaScore = Decimal.Parse(Console.ReadLine());

            decimal average = (MathScore + EnglishScore + PhysicsScore + ChemistryScore + BiologyScore + EconomicsScore + LiteratureScore + YorubaScore) / 8;
            
            
            Console.WriteLine("Your Average Score is: " + average);
            if (average > 69)
            {
                Console.Write("Your Final Grade is: A");
            }
            if (average > 59 && average < 70)
            {
                Console.Write("Your Final Grade is: B");
            }
            if (average > 49 && average < 60)
            {
                Console.Write("Your Final Grade is: C");
            }
            if (average > 39 && average < 50)
            {
                Console.Write("Your Final Grade is: D");
            }
            Console.ReadLine();

        }
    }
}
