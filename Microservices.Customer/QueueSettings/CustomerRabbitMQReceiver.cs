using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RabbitMQ.Client;

namespace Microservices.Customer.QueueSettings
{
    public class CustomerRabbitMQReceiver
    {
        public void InitializeRabbitMQListener()
        {
            var factory = new ConnectionFactory();
        }
    }
}
