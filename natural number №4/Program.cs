namespace natural_number__4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите любое натуральное число:");
            var A = Console.ReadLine();
            A = A.Replace("0",string.Empty);
            A = A.Replace("2",string.Empty);
            A = A.Replace("4",string.Empty);
            A = A.Replace("6",string.Empty);
            A = A.Replace("8",string.Empty);

        Console.WriteLine("Число, в котором нет четных цифр:"); 
            Console.WriteLine(A);
        }
    }
}