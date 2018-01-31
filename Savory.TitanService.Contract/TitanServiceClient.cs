using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Description;
using System.Text;
using System.Threading.Tasks;

namespace Savory.TitanService.Contract
{
    [DebuggerStepThrough]
    public class TitanServiceClient : ClientBase<ITitanService>, ITitanService
    {
        public TitanServiceClient() :
            base(new ServiceEndpoint(ContractDescription.GetContract(typeof(ITitanService)), new BasicHttpBinding(), new EndpointAddress("http://localhost:8855/")))
        {
        }

        #region ITitanService Members
        public string GetConnString(string DBName)
        {
            return this.Channel.GetConnString(DBName);
        }
        #endregion
    }
}
