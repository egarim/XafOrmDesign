using System;
using System.Linq;

namespace XafOrmDesign.Module.BusinessObjects
{
    public interface IPersonWithOutIndex
    {
        int Age { get; set; }
        string Email { get; set; }
        string FullName { get; set; }
        string Name { get; set; }
    }
}