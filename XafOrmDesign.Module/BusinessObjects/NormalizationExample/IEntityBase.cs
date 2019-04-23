using System;
using System.Linq;

namespace XafOrmDesign.Module.BusinessObjects.NormalizationExample
{
    public interface IEntityBase
    {
        void AfterConstruction();

        string Code { get; set; }
        string DisplayName { get; set; }
    }
}