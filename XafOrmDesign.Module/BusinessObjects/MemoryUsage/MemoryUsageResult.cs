using System;
using System.Linq;
using System.Text;
using DevExpress.Xpo;
using DevExpress.ExpressApp;
using System.ComponentModel;
using DevExpress.ExpressApp.DC;
using DevExpress.Data.Filtering;
using DevExpress.Persistent.Base;
using System.Collections.Generic;
using DevExpress.ExpressApp.Model;
using DevExpress.Persistent.BaseImpl;
using DevExpress.Persistent.Validation;

namespace XafOrmDesign.Module.BusinessObjects.MemoryUsage
{
    [DefaultClassOptions]
    //[ImageName("BO_Contact")]
    //[DefaultProperty("DisplayMemberNameForLookupEditorsOfThisType")]
    //[DefaultListViewOptions(MasterDetailMode.ListViewOnly, false, NewItemRowPosition.None)]
    //[Persistent("DatabaseTableName")]
    // Specify more UI options using a declarative approach (https://documentation.devexpress.com/#eXpressAppFramework/CustomDocument112701).
    public class MemoryUsageResult : XPLiteObject
    { // Inherit from a different class to provide a custom primary key, concurrency and deletion behavior, etc. (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument113146.aspx).
        public MemoryUsageResult(Session session)
            : base(session)
        {
        }

        public override void AfterConstruction()
        {
            base.AfterConstruction();
            // Place your initialization code here (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument112834.aspx).
        }

        private string operation;
        private string percentage;
        private double partialObject;
        private double fullObject;

        [Browsable(true)]
        [Key(false)]
        [Size(SizeAttribute.DefaultStringMappingFieldSize)]
        public string Operation
        {
            get => operation;
            set => SetPropertyValue(nameof(Operation), ref operation, value);
        }

        public double FullObject
        {
            get => fullObject;
            set => SetPropertyValue(nameof(FullObject), ref fullObject, value);
        }

        public double PartialObject
        {
            get => partialObject;
            set => SetPropertyValue(nameof(PartialObject), ref partialObject, value);
        }

        [ModelDefault("DisplayFormat", "##.## %")]
        public string Percentage
        {
            get => percentage;
            set => SetPropertyValue(nameof(Percentage), ref percentage, value);
        }

        protected override void OnSaving()
        {
            if (FullObject > 0 && PartialObject > 0)
            {
                var Round = Math.Round((PartialObject * 100) / FullObject, 2);
                Percentage = Round.ToString() + "%";
            }

            base.OnSaving();
        }
    }
}