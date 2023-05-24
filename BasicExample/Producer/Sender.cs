using RabbitMQ.Client;
using System.Text;

public class Sender
{
    private static void Main(string[] args)
    {
        var factory = new ConnectionFactory() { HostName = "localhost" };
        using (var connection = factory.CreateConnection())
        {
            using (var channel  = connection.CreateModel())
            {
                channel.QueueDeclare("BasicTestQueue", false, false, false, null);

                string message = "Hola! soy un mensaje de RabbitMQ";

                var body = Encoding.UTF8.GetBytes(message);

                channel.BasicPublish("", "BasicTestQueue", null, body);

                Console.WriteLine($"Sent message: {message}");
            }
        }
    }
}