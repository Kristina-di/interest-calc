using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

// NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service" in code, svc and config file together.
public class Service : IInterestCalculations
{
    public decimal SimpleInterest(decimal _p, decimal _r, decimal _t)
    {
        
        return (_p * _r * _t);
        
    }

    public decimal SimplePlusPrincipalInterest(decimal _p, decimal _r, decimal _t)
    {
        
        return (_p * (1 + _r * _t));
        
    }

    public decimal CompoundInterest(decimal _p, decimal _r, decimal _n, decimal _t)
    {
        
        return (_p * (1 + _r / _n));
        
    }

    public decimal PeriodicCompoundInterest(decimal _p, decimal _r, decimal _t)
    {
        
        return (_p * (1 + _r));
        
    }

    public AllInterest CalculateAll(decimal _p, decimal _r, decimal _t, decimal _n)
    {
        


         decimal SimpleInterest;
         decimal SimplePlusPrincipalInterest;
         decimal CompoundInterest;
         decimal PeriodicCompoundInterest;

         SimpleInterest = (_p * _r * _t);
         SimplePlusPrincipalInterest = (_p * (1 + _r * _t));
         CompoundInterest = (_p * (1 + _r / _n));
         PeriodicCompoundInterest = (_p *(1 + _r));

         var allInterest = new AllInterest(SimpleInterest, SimplePlusPrincipalInterest, CompoundInterest, PeriodicCompoundInterest);

         return allInterest;

    }

   
}
