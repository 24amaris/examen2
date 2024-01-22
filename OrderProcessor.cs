using System;
namespace examen.pb2
{
	public class OrderProcessor
	{
        public void FulfillOrder(Order order, PaymentSystem paymentSystem)
        {
            Console.WriteLine($"Procesarea comenzii pentru {order.Customer}," +
                $" Total: {order.Total}");
        }
    }
}

