class Program
{
    public void Calulation()
    {
        int baseNumber = 2;
        int powerNumber;
        int i = 1;
        Console.Write("Enter power number :");
        powerNumber = int.Parse(Console.ReadLine());
        while (i <= powerNumber)
        {
            var returnNumber = Math.Pow(baseNumber, i);
            Console.Write("{0}^{1}={2}\n", baseNumber, i, returnNumber);
            i++;
        }
    }
}
class Result
{
    public static void Main(string[]args)
    {
        Program pro=new Program();
        pro.Calulation();
    }
}

