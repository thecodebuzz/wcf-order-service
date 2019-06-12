using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace webapi_dotnetcore_client_channelfactory.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        // GET api/values
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            BasicHttpBinding myBinding = new BasicHttpBinding();
            EndpointAddress myEndpoint = new EndpointAddress("http://localhost:60141/Order.svc");
            ChannelFactory<IOrderService> myChannelFactory = 
            new ChannelFactory<IOrderService>(myBinding, myEndpoint);
            // Create a channel
            IOrderService wcfClient1 = myChannelFactory.CreateChannel();
            string result = wcfClient1.GetOrderData(id);
            return result;
        }

        

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
