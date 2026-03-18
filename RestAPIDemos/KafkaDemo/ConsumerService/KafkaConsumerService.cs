
using Confluent.Kafka;
using ConsumerService.Model;
using Newtonsoft.Json;

namespace ConsumerService
{
    public class KafkaConsumerService:IHostedService
    {
        private readonly IConfiguration config;
        public KafkaConsumerService(IConfiguration config)
        {
            this.config=config;
        }

        public Task StartAsync(CancellationToken cancellationToken)
        {
            // ConsumerConfiguration

            ConsumerConfig cconfig = new ConsumerConfig
            {
                BootstrapServers = config["Kafka:Server"],
                GroupId="test_group"
            };
            // create and build KafkaConsumerBuilder

            using (var consumer= new ConsumerBuilder<Null,string>(cconfig).Build())
            {
                consumer.Subscribe(config["Kafka:Topic"]);
                var canceltoken = new CancellationTokenSource();

                try
                {
                    while(true)
                    {
                        var topicconsumer = consumer.Consume(canceltoken.Token);
                        var OrderData=JsonConvert.DeserializeObject<Order>(topicconsumer.Message.Value);

                        // now we have our data in Orderdata
                        // you may use it, here i am going to write it in a file

                        using (FileStream fs = new FileStream("Logs/orderlog.txt",FileMode.Append, FileAccess.Write))
                        {
                            using(StreamWriter sw = new StreamWriter(fs))
                            {
                                sw.WriteLine($"{OrderData.OrderId} {OrderData.ProductName}  {OrderData.ProductPrice}  {OrderData.Quantity}");
                            }

                        }
                    }
                }
                catch(OperationCanceledException ex)
                {
                    consumer.Close();
                }
            };
            return Task.CompletedTask;

        }

        public Task StopAsync(CancellationToken cancellationToken)
        {
            return Task.CompletedTask;
        }
    }
}
