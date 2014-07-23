using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ServiceModel;

namespace Artech.WcfServices.Contracts
{
    [ServiceContract]
    public interface ICal
    {
        [OperationContract]
        double Add(double x, double y);

        [OperationContract]
        double Subtract(double x, double y);

        [OperationContract]
        double Multiply(double x, double y);

        [OperationContract]
        double Divide(double x, double y);
    };
}


