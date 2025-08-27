using System;

namespace AdmissionEligibilityApp
{
    internal class AdmissionCheck
    {
        static void Main()
        {
            Console.Write("Input the marks obtained in Maths: ");
            int maths = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input the marks obtained in Physics: ");
            int physics = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input the marks obtained in Chemistry: ");
            int chemistry = Convert.ToInt32(Console.ReadLine());

            int totalMarks = maths + physics + chemistry;
            int mathsPhysicsTotal = maths + physics;

            if ((maths >= 65 && physics >= 55 && chemistry >= 50 && totalMarks >= 180) ||
                (mathsPhysicsTotal >= 140))
            {
                Console.WriteLine("The candidate is eligible for admission.");
            }
            else
            {
                Console.WriteLine("The candidate is not eligible for admission.");
            }
        }
    }
}
