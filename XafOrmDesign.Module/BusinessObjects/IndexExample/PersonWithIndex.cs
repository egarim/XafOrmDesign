using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl;
using DevExpress.Xpo;
using System;
using System.Linq;

namespace XafOrmDesign.Module.BusinessObjects
{
    [DefaultClassOptions]
    [Indices("Name", "Name;Age", "Age;Email")]
    public class PersonWithIndex : BaseObject, IPersonWithOutIndex
    {
        private string email;
        private int age;
        private string fullName;
        private string name;

        [Size(SizeAttribute.DefaultStringMappingFieldSize)]
        public string Name
        {
            get => name;
            set => SetPropertyValue(nameof(Name), ref name, value);
        }

        [Indexed(Unique = true)]
        [Size(SizeAttribute.DefaultStringMappingFieldSize)]
        public string FullName
        {
            get => fullName;
            set => SetPropertyValue(nameof(FullName), ref fullName, value);
        }

        public int Age
        {
            get => age;
            set => SetPropertyValue(nameof(Age), ref age, value);
        }

        [Size(SizeAttribute.DefaultStringMappingFieldSize)]
        public string Email
        {
            get => email;
            set => SetPropertyValue(nameof(Email), ref email, value);
        }

        public PersonWithIndex()
        {
        }

        public PersonWithIndex(Session session) : base(session)
        {
        }
    }
}