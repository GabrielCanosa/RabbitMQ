using RabbitMQ.Client;
using System.Text;

var cts = new CancellationTokenSource();
var token = cts.Token;

var factory = new ConnectionFactory() { HostName = "localhost" };
using (var connection = factory.CreateConnection())
using (var channel = connection.CreateModel())
{
    BasicGetResult result;
    while (true)
    {
        result = BasicGetMessage(channel);
        Thread.Sleep(2000);
    }
}

static BasicGetResult BasicGetMessage(IModel channel)
{
    BasicGetResult result = channel.BasicGet("PollingTestQueue", true);
    if (result == null)
        Console.WriteLine("There are no message in the queue");
    else
    {
        var body = result.Body.ToArray();
        var message = Encoding.UTF8.GetString(body);
        Console.WriteLine($"Received message: **  {message}  **");
    }

    return result;
}