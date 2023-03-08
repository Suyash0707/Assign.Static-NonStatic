using Assign.Static_NonStatic;

public class Program
{
    public static void Main()
    {
        Pattern.Pattern0();

        Pattern patternobj3 = new Pattern();
        patternobj3.Pattern1();

        Pattern3();

    }

    public int Number3 { get; set; }

    public void GetNumberFromUser3()
    {
        //Patterns patternobj4= new Patterns();

        Console.WriteLine("Please enter any number ");
        Number3 = Convert.ToInt32(Console.ReadLine());
        //return Number3;
    }

    public static void Pattern3()
    {
        Program programobj = new Program();
        programobj.GetNumberFromUser3();


        for (int i = 1; i <= programobj.Number3; i++)
        {
            for (int j = 1; j <= programobj.Number3; j++)
            {
                Console.Write(j + " ");
            }

            Console.WriteLine();
        }
    }
}
