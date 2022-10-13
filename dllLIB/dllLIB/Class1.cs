namespace dllLIB
{
    public class Class1
    {
        public static void PlusFunc(double x, double y)
        {
            double Sum = x + y;
            Console.WriteLine("{0} прибавить {1} = {2}", x, y, Sum);
            Console.ReadLine();
        }
        public static void MinusFunc(double x, double y)
        {
            double Min = x - y;
            Console.WriteLine("{0} вычесть {1} = {2}", x, y, Min);
            Console.ReadLine();
        }
        public static void UmnojitFunc(double x, double y)
        {
            double Umn = x * y;
            Console.WriteLine("{0} умножить на {1} = {2}", x, y, Umn);
            Console.ReadLine();
        }
        public static void RazdelitFunc(double x, double y)
        {
            double Razd = x / y;
            Console.WriteLine("{0} разделить {1} = {2}", x, y, Razd);
            Console.ReadLine();
        }
        public static void StepenFunc(double x, double y)
        {
            double Step = Math.Pow(x,y);
            Console.WriteLine("{0} в степени {1} = {2}", x, y, Step);
            Console.ReadLine();
        }
    }
}