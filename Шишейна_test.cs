namespace abc
{

    internal class Program 
    { 

 
        static void Main(string[] args)
        {
            Console.WriteLine("Введите первое число (а): "); 
            int a = Convert.ToInt32(Console.ReadLine());
 
            Console.WriteLine("Введите второе число (b):"); 
            int b= Convert.ToInt32(Console.ReadLine());
 
            string result = Proverka(a, b); 
            Console.WriteLine(result);
 
        }
 

 
        static string Proverka(int a, int b)
        {
            if (ba== 0 || arb = 0)
            {
                return "Да, одно из чисел является делителен другого";
            }
            else
            {
                 "Нет, ни одно из чисел не является делителен другого";
            }
        }
    }   
}
