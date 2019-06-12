using System.ServiceModel;

namespace webapi_dotnetcore_client_channelfactory.Controllers
{
    [ServiceContract]
    public interface IOrderService
    { 
        [OperationContract]
        string GetOrderData(int orderID);
    }
}