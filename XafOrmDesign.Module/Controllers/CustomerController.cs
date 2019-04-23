using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using XafOrmDesign.Module.BusinessObjects.NormalizationExample.Normalized;
using DevExpress.Data.Filtering;
using DevExpress.ExpressApp;
using DevExpress.ExpressApp.Actions;
using DevExpress.ExpressApp.Editors;
using DevExpress.ExpressApp.Layout;
using DevExpress.ExpressApp.Model.NodeGenerators;
using DevExpress.ExpressApp.SystemModule;
using DevExpress.ExpressApp.Templates;
using DevExpress.ExpressApp.Utils;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.Validation;
using XafOrmDesign.Module.BusinessObjects.NormalizationExample.Denormalized;
using DevExpress.Xpo.DB;
using XafOrmDesign.Module.BusinessObjects.NormalizationExample;

namespace XafOrmDesign.Module.Controllers
{
    // For more typical usage scenarios, be sure to check out https://documentation.devexpress.com/eXpressAppFramework/clsDevExpressExpressAppViewControllertopic.aspx.
    public partial class CustomerController : ViewController
    {
        public CustomerController()
        {
            InitializeComponent();
            // Target required Views (via the TargetXXX properties) and create their Actions.
        }

        protected override void OnActivated()
        {
            base.OnActivated();
            // Perform various tasks depending on the target View.
        }

        protected override void OnViewControlsCreated()
        {
            base.OnViewControlsCreated();
            // Access and customize the target View control.
        }

        protected override void OnDeactivated()
        {
            // Unsubscribe from previously subscribed events and release other references and resources.
            base.OnDeactivated();
        }

        private void saCreateCustomerNormalizedForm_Execute(object sender, SimpleActionExecuteEventArgs e)
        {
            var Result = StopWatch.Start(() =>
            {
                var Os = this.Application.CreateObjectSpace();
                for (int i = 0; i < 10000; i++)
                {
                    var Customer = Os.CreateObject<Customer>();
                    Customer.DisplayName = $"customer {i}";
                    Customer.Code = $"Code {i}";
                    Customer.TaxId = "Abc123";
                    Os.CommitChanges();
                }
            }, "Insert Customers Normalized Schema");
            var Insert = this.ObjectSpace.GetObjectByKey<CrudOperationResult>("Create");
            Insert.Normalized = Result.Item2;
            this.ObjectSpace.CommitChanges();
        }

        private void saCreateCustomerDenormalizedForm_Execute(object sender, SimpleActionExecuteEventArgs e)
        {
            var Result = StopWatch.Start(() =>
            {
                var Os = this.Application.CreateObjectSpace();
                for (int i = 0; i < 10000; i++)
                {
                    var Customer = Os.CreateObject<CustomerDenormalized>();
                    Customer.DisplayName = $"customer {i}";
                    Customer.Code = $"Code {i}";
                    Customer.TaxId = "Abc123";
                    Os.CommitChanges();
                }
            }, "Insert Customers Denormalized Schema");
            var Insert = this.ObjectSpace.GetObjectByKey<CrudOperationResult>("Create");
            Insert.Denormalized = Result.Item2;
            this.ObjectSpace.CommitChanges();
        }

        private void saDeleteCustomersNormalized_Execute(object sender, SimpleActionExecuteEventArgs e)
        {
            var Result = StopWatch.Start(() =>
            {
                var Os = this.Application.CreateObjectSpace();
                Os.Delete(Os.CreateCollection(typeof(Customer), null));
                Os.CommitChanges();
            }, "Delete Customers Normalized Schema");
            var Delete = this.ObjectSpace.GetObjectByKey<CrudOperationResult>("Delete");
            Delete.Normalized = Result.Item2;
            this.ObjectSpace.CommitChanges();
        }

        private void saDeleteCustomersDenormalized_Execute(object sender, SimpleActionExecuteEventArgs e)
        {
            var Result = StopWatch.Start(() =>
            {
                var Os = this.Application.CreateObjectSpace();
                Os.Delete(Os.CreateCollection(typeof(CustomerDenormalized), null));
                Os.CommitChanges();
            }, "Delete Customers Denormalized Schema");
            var Delete = this.ObjectSpace.GetObjectByKey<CrudOperationResult>("Delete");
            Delete.Denormalized = Result.Item2;
            this.ObjectSpace.CommitChanges();
        }
    }
}