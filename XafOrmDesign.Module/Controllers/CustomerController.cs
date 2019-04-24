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
using System.Diagnostics;
using XafOrmDesign.Module.BusinessObjects.MemoryUsage;

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
                    Customer.Email = "email@email.com";
                    Customer.PhoneNumber = "+795211111111";
                }
                Os.CommitChanges();
            }, "Insert Customers Normalized Schema");
            var Insert = this.ObjectSpace.GetObjectByKey<CrudOperationResult>("Create");
            Insert.Normalized = Result.Item2;
            this.ObjectSpace.CommitChanges();
        }

        private void saCreateCustomerDenormalizedForm_Execute(object sender, SimpleActionExecuteEventArgs e)
        {
            GC.Collect();
            var Result = StopWatch.Start(() =>
            {
                var Os = this.Application.CreateObjectSpace();
                for (int i = 0; i < 10000; i++)
                {
                    var Customer = Os.CreateObject<CustomerDenormalized>();
                    Customer.DisplayName = $"customer {i}";
                    Customer.Code = $"Code {i}";
                    Customer.TaxId = "Abc123";
                    Customer.Email = "email@email.com";
                    Customer.PhoneNumber = "+795211111111";
                }
                Os.CommitChanges();
            }, "Insert Customers Denormalized Schema");
            var Insert = this.ObjectSpace.GetObjectByKey<CrudOperationResult>("Create");
            Insert.Denormalized = Result.Item2;
            this.ObjectSpace.CommitChanges();
        }

        private void saDeleteCustomersNormalized_Execute(object sender, SimpleActionExecuteEventArgs e)
        {
            GC.Collect();
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
            GC.Collect();
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

        private void saReadCustomersNormalized_Execute(object sender, SimpleActionExecuteEventArgs e)
        {
            GC.Collect();
            var Result = StopWatch.Start(() =>
            {
                var Os = this.Application.CreateObjectSpace();

                var List = Os.CreateCollection(typeof(Customer), null).Cast<Customer>().ToList();
            }, "Read Customers Normalized Schema");
            var Delete = this.ObjectSpace.GetObjectByKey<CrudOperationResult>("Read");
            Delete.Normalized = Result.Item2;
            this.ObjectSpace.CommitChanges();
        }

        private void saReadCustomersDenormalized_Execute(object sender, SimpleActionExecuteEventArgs e)
        {
            GC.Collect();
            var Result = StopWatch.Start(() =>
            {
                var Os = this.Application.CreateObjectSpace();

                var List = Os.CreateCollection(typeof(CustomerDenormalized), null).Cast<CustomerDenormalized>().ToList();
            }, "Read Customers Denormalized Schema");
            var Delete = this.ObjectSpace.GetObjectByKey<CrudOperationResult>("Read");
            Delete.Denormalized = Result.Item2;
            this.ObjectSpace.CommitChanges();
        }

        private void saUpdateCustomerDenormalized_Execute(object sender, SimpleActionExecuteEventArgs e)
        {
            GC.Collect();
            var Result = StopWatch.Start(() =>
            {
                var Os = this.Application.CreateObjectSpace();

                var List = Os.CreateCollection(typeof(CustomerDenormalized), null).Cast<CustomerDenormalized>().ToList();
                foreach (var item in List)
                {
                    item.PhoneNumber = "+503778896";
                    item.Code = item.Code + "SV";
                }
            }, "Update Customers Denormalized Schema");
            var Update = this.ObjectSpace.GetObjectByKey<CrudOperationResult>("Update");
            Update.Denormalized = Result.Item2;
            this.ObjectSpace.CommitChanges();
        }

        private void saUpdateCustomerNormalized_Execute(object sender, SimpleActionExecuteEventArgs e)
        {
            GC.Collect();
            var Result = StopWatch.Start(() =>
            {
                var Os = this.Application.CreateObjectSpace();

                var List = Os.CreateCollection(typeof(Customer), null).Cast<Customer>().ToList();
                foreach (var item in List)
                {
                    item.PhoneNumber = "+503778896";
                    item.Code = item.Code + "SV";
                }
            }, "Update Customers Normalized Schema");
            var Update = this.ObjectSpace.GetObjectByKey<CrudOperationResult>("Update");
            Update.Normalized = Result.Item2;
            this.ObjectSpace.CommitChanges();
        }

        private void saReadFullObjects_Execute(object sender, SimpleActionExecuteEventArgs e)
        {
            GC.Collect();
            long TotalMemory = 0;
            var Result = StopWatch.Start(() =>
            {
                var Os = this.Application.CreateObjectSpace();
                var InitialMemory = GC.GetTotalMemory(false);

                var ListOfCustomers = Os.CreateCollection(typeof(Customer)).Cast<Customer>().ToArray();

                var FinalMemory = GC.GetTotalMemory(false);

                TotalMemory = (FinalMemory - InitialMemory) / 1000;
                Debug.WriteLine(string.Format("{0}:{1}", "TotalMemory in KB", TotalMemory));
            }, "Update Customers Normalized Schema");
            var Update = this.ObjectSpace.GetObjectByKey<MemoryUsageResult>("Read");
            Update.FullObject = Result.Item2;
            Update.FullObjectMemoryInKB = TotalMemory.ToString() + "Kb";
            this.ObjectSpace.CommitChanges();
        }

        private void saReadObjectsFromView_Execute(object sender, SimpleActionExecuteEventArgs e)
        {
            GC.Collect();
            long TotalMemory = 0;
            var Result = StopWatch.Start(() =>
            {
                var Os = this.Application.CreateObjectSpace();
                var InitialMemory = GC.GetTotalMemory(false);

                var ListOfCustomers = Os.CreateDataView(typeof(Customer), "TaxId", null, null);
                var ListOfCustomerCount = ListOfCustomers.Count;

                var FinalMemory = GC.GetTotalMemory(false);

                TotalMemory = (FinalMemory - InitialMemory) / 1000;
                Debug.WriteLine(string.Format("{0}:{1}", "TotalMemory in KB", TotalMemory));
            }, "Update Customers Normalized Schema");
            var Update = this.ObjectSpace.GetObjectByKey<MemoryUsageResult>("Read");
            Update.PartialObject = Result.Item2;
            Update.PartialObjectMemoryInKB = TotalMemory.ToString() + "Kb";
            this.ObjectSpace.CommitChanges();
        }

        private void saResetAllResults_Execute(object sender, SimpleActionExecuteEventArgs e)
        {
            var MemoryResults = this.ObjectSpace.CreateCollection(typeof(MemoryUsageResult)).Cast<MemoryUsageResult>();
            foreach (var item in MemoryResults)
            {
                item.PartialObject = 0;
                item.PartialObjectMemoryInKB = "";
                item.FullObject = 0;
                item.FullObjectMemoryInKB = "";
            }

            var CrudOperationResults = this.ObjectSpace.CreateCollection(typeof(CrudOperationResult)).Cast<CrudOperationResult>();
            foreach (var item in CrudOperationResults)
            {
                item.Normalized = 0;
                item.Denormalized = 0;
                item.Percentage = "";
            }
            this.View.ObjectSpace.CommitChanges();
        }
    }
}