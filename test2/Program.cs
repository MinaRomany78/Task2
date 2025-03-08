namespace test2
{
    internal class Program
    {
        //static void Calculator(double num1, double num2, string op)
        //{
        //    double total = 0;
        //    switch (op)
        //    {
        //        case "+":
        //            total = num1 + num2;
        //            break;
        //        case "-":
        //            total = num1 - num2;
        //            break;
        //        case "*":
        //            total = num1 * num2;
        //            break;
        //        case "/":
        //            total = num1 / num2;
        //            break;

        //    }
        //    Console.WriteLine($"result :{total}");


        //}
        static int Count(string text) {
            int count = 0;
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == ' ')
                  count++;                
            
            }
            return count;
        }
        static void Main(string[] args)
        {
            //Console.WriteLine("Enter your number");
            //double num1 = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("Enter anther number");
            //double num2 = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("Enter your operation +,-,*,/");
            //string Operational = Console.ReadLine();
            //Calculator(num1,num2, Operational);
            Console.WriteLine(" Enter your text");
            string text = Console.ReadLine();
            
            Console.WriteLine(Count(text)); 


        }
    }
}
