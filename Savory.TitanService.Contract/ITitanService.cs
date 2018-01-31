using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Savory.TitanService.Contract
{
    /// <summary>
    /// 数据库连接串服务
    /// </summary>
    [ServiceContract]
    public interface ITitanService
    {
        /// <summary>
        /// 获取连接字符串
        /// </summary>
        [OperationContract]
        string GetConnString(string DBName);
    }
}
