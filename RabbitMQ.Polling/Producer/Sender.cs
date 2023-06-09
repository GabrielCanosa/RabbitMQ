using RabbitMQ.Client;
using System.Text;

var factory = new ConnectionFactory() { HostName = "localhost" };
using (var connection = factory.CreateConnection())
{
    using (var channel = connection.CreateModel())
    {
        channel.QueueDeclare("PollingTestQueue", false, false, false, null);

        string message = "Hola! soy un mensaje de RabbitMQ";

        var body = Encoding.UTF8.GetBytes(message);

        channel.BasicPublish("", "PollingTestQueue", null, body);

        Console.WriteLine($"Sent message: {message}");
    }
}