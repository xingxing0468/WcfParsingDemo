using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ServiceModel;
using System.ServiceModel.Description;
using System.Xml.XmlConfiguration;

using Artech.WcfServices.Contracts;
using Artech.WcfServices.Services;
namespace Hosting
{
    class Hosting
    {
        static void Main(string[] args)
        {
            ServiceHost host = new ServiceHost(typeof(CalServices));

            NetTcpBinding binding = new NetTcpBinding();
            binding.ReaderQuotas
        }
    }
}
