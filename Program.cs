namespace Impartire;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Deimpartitul: ");
        int deimp = int.Parse(Console.ReadLine());
        Console.WriteLine("Impartitorul: ");
        int imp = int.Parse(Console.ReadLine());

        if (deimp % imp == 0)
        {
            Console.WriteLine("Catul este " + deimp / imp);
        }
        else
            do
            {
                Console.WriteLine("Cele 2 nu se pot imparti exact, datile din nou");
                Console.WriteLine("Deimpartitul: ");
                deimp = int.Parse(Console.ReadLine());
                Console.WriteLine("Impartitorul: ");
                imp = int.Parse(Console.ReadLine());
            } while (deimp % imp != 0);

    }
}