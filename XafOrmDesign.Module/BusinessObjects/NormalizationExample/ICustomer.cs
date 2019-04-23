using System;
using System.Linq;

namespace XafOrmDesign.Module.BusinessObjects.NormalizationExample
{
    public interface ICustomer
    {
        string TaxId { get; set; }
    }
}