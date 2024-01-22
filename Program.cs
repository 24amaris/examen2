namespace examen.pb2;

class Program
{
    static void Main(string[] args)
    {
        var order = new Order
        {
            Customer = "Numele clientului este:",
            Date = DateTime.Parse
        }

        Console.WriteLine("Metoda de plata este: card, PayPal, wallet crypto");
        string paymentMethod = Console.ReadLine();
        }
    }
}