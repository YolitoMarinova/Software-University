using System;

namespace _09.PadawanEquipment
{
    class Program
    {
        static void Main()
        {
            double hasMoney = double.Parse(Console.ReadLine());
            int studentsCount = int.Parse(Console.ReadLine());
            double lightsabersPrice = double.Parse(Console.ReadLine());
            double robesPrice = double.Parse(Console.ReadLine());
            double beltsPrice = double.Parse(Console.ReadLine());

            double beltNum = 0;

            double sum = 0.00;

            if (studentsCount < 6)
            {
                sum = (lightsabersPrice * (studentsCount + Math.Ceiling(studentsCount * 0.1))) +
                    (studentsCount * robesPrice) + (studentsCount * beltsPrice);
            }
            else if (studentsCount >= 6)
            {
                beltNum = studentsCount / 6;
                sum = (lightsabersPrice * (studentsCount + Math.Ceiling(studentsCount * 0.1))) +
                  (studentsCount * robesPrice) + ((studentsCount-Math.Ceiling(beltNum)) * beltsPrice);
            }
            
            if (hasMoney >= sum)
            {
                Console.WriteLine($"The money is enough - it would cost {sum:F2}lv.");
            }
            else
            {
                double neededMoney = sum - hasMoney;
                Console.WriteLine($"Ivan Cho will need {neededMoney:F2}lv more.");
            }
        }
    }
}
