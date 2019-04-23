using System;
using System.Linq;

namespace XafOrmDesign.Module.BusinessObjects.NormalizationExample
{
    public interface IParty
    {
        string Address { get; set; }
        string Email { get; set; }
        string PhoneNumber { get; set; }
    }
}