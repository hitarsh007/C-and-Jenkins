using System;


namespace LoopandConditionalstatementsEg
{
    class ForEg
    {
        static void Main()
        {
            int table, n;
            Console.WriteLine("Enter the table to be printed");
            table = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the number");
            n = Convert.ToInt32(Console.ReadLine());

            //FOR loop(initialization; condition; increment/decrement)
            for (int i = 1; i<= n; i++)
            {
                table = i * n;

            }
            Console.WriteLine("The table of n is:{0}", n, table);
            Console.Read();


              

        }

    }

}








