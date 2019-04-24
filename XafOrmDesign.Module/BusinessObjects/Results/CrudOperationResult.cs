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

namespace XafOrmDesign.Module.BusinessObjects.Results
{
    [DefaultClassOptions]
    public class CrudOperationResult : XPLiteObject
    { // Inherit from a different class to provide a custom primary key, concurrency and deletion behavior, etc. (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument113146.aspx).
        public CrudOperationResult(Session session)
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
        private double denormalized;
        private double normalized;

        [Browsable(true)]
        [Key(false)]
        [Size(SizeAttribute.DefaultStringMappingFieldSize)]
        public string Operation
        {
            get => operation;
            set => SetPropertyValue(nameof(Operation), ref operation, value);
        }

        public double Normalized
        {
            get => normalized;
            set => SetPropertyValue(nameof(Normalized), ref normalized, value);
        }

        public double Denormalized
        {
            get => denormalized;
            set => SetPropertyValue(nameof(Denormalized), ref denormalized, value);
        }

        [ModelDefault("DisplayFormat", "##.## %")]
        public string Percentage
        {
            get => percentage;
            set => SetPropertyValue(nameof(Percentage), ref percentage, value);
        }

        protected override void OnSaving()
        {
            if (Normalized > 0 && Denormalized > 0)
            {
                var Round = Math.Round((Denormalized * 100) / Normalized, 2);
                Percentage = Round.ToString() + "%";
            }

            base.OnSaving();
        }
    }
}