using System.Collections.Generic;
using System.Web.Http;

namespace WebApplication4.Controllers
{
    public class MessageController : ApiController
    {
        public static IDictionary<string, string> hashDictionary = new Dictionary<string, string>();
        [System.Web.Http.HttpPost]
        public string Post(string id)
        {
            var hashValue = CrypterHelper.Encrypt(id);
            if(!hashDictionary.ContainsKey(hashValue))
                hashDictionary.Add(hashValue, id);
            return hashValue;

        }
        public string Get(string id)
        {
            if(hashDictionary.ContainsKey(id))
                return hashDictionary[id];
            else
                return "Message not found";  
        }
    }
}
