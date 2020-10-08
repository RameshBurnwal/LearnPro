using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microservices.Order.QueueSettings;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Microservices.Order.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private IRabbitMQManager _manager;

        public ValuesController(IRabbitMQManager manager)
        {
            _manager = manager;
        }

        // GET api/values  
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            // other opreation  

            // if above operation succeed, publish a message to RabbitMQ  

            var num = new System.Random().Next(9000);

            // publish message  
            _manager.Publish(new
            {
                field1 = $"Hello-{num}",
                field2 = $"rabbit-{num}"
            }, "demo.exchange.topic.dotnetcore", "topic", "*.queue.durable.dotnetcore.#");

            return new string[] { "value1", "value2" };
        }
    }
}