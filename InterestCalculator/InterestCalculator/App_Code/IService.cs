using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

// NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService" in both code and config file together.
[ServiceContract]
public interface IInterestCalculations
{

	[OperationContract]
	decimal SimpleInterest (decimal _p, decimal _r, decimal _t);

	[OperationContract]
    decimal SimplePlusPrincipalInterest(decimal _p, decimal _r, decimal _t);

	[OperationContract]
    decimal CompoundInterest(decimal _p, decimal _r, decimal _n, decimal _t);

	[OperationContract]
    decimal PeriodicCompoundInterest(decimal _p, decimal _r, decimal _t);

	[OperationContract]
    AllInterest CalculateAll(decimal _p, decimal _r, decimal _t, decimal _n);

	// TODO: Add your service operations here
}



// Use a data contract as illustrated in the sample below to add composite types to service operations.
[DataContract]
public class AllInterest
{
    public AllInterest(decimal simpleInterest, decimal simplePlusPrincipalInterest, decimal compoundInterest, decimal periodicCompoundInteres)
    {
        SimpleInterest = simpleInterest;
        SimplePlusPrincipalInterest = simplePlusPrincipalInterest;
        CompoundInterest = compoundInterest;
        PeriodicCompoundInterest = periodicCompoundInteres;
    }

    [DataMember]
    private decimal SimpleInterest { get; set; }

    [DataMember]
    private decimal SimplePlusPrincipalInterest { get; set; }

    [DataMember]
    private decimal CompoundInterest { get; set; }

    [DataMember]
    private decimal PeriodicCompoundInterest { get; set; }

}
