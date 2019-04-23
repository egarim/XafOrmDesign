using System;
using System.Linq;
using DevExpress.ExpressApp;
using DevExpress.Data.Filtering;
using DevExpress.Persistent.Base;
using DevExpress.ExpressApp.Updating;
using DevExpress.Xpo;
using DevExpress.ExpressApp.Xpo;
using DevExpress.Persistent.BaseImpl;
using XafOrmDesign.Module.BusinessObjects;

namespace XafOrmDesign.Module.DatabaseUpdate
{
    // For more typical usage scenarios, be sure to check out https://docs.devexpress.com/eXpressAppFramework/DevExpress.ExpressApp.Updating.ModuleUpdater
    public class Updater : ModuleUpdater
    {
        public Updater(IObjectSpace objectSpace, Version currentDBVersion) :
            base(objectSpace, currentDBVersion)
        {
        }

        public override void UpdateDatabaseAfterUpdateSchema()
        {
            base.UpdateDatabaseAfterUpdateSchema();
            //CreateCustomers();
            //this.ObjectSpace.CommitChanges();
            LoadCustomers();
        }

        private void CreateCustomers()
        {
            // Create new stopwatch
            System.Diagnostics.Stopwatch stopwatch = new System.Diagnostics.Stopwatch();

            // Begin timing
            stopwatch.Start();

            // Tasks performed by method

            for (int i = 0; i < 10000; i++)
            {
                CreateCustomer(i.ToString(), $"customer {i}", "El Salvador", Guid.NewGuid().ToString());
            }
            stopwatch.Stop();

            Console.WriteLine("Time taken : {0}", stopwatch.Elapsed.TotalMilliseconds);
        }

        private void LoadCustomers()
        {
            System.Diagnostics.Stopwatch stopwatch = new System.Diagnostics.Stopwatch();

            // Begin timing
            stopwatch.Start();
            var ListOfCustomers = this.ObjectSpace.CreateCollection(typeof(Customer)).Cast<Customer>().ToArray();
            // Stop timing
            stopwatch.Stop();

            Console.WriteLine("Time taken : {0}", stopwatch.Elapsed.TotalMilliseconds);
        }

        private void CreateCustomer(string Code, string Name, string Country, string TaxId)
        {
            Customer theObject = ObjectSpace.FindObject<Customer>(CriteriaOperator.Parse("Code=?", Code));
            if (theObject == null)
            {
                theObject = ObjectSpace.CreateObject<Customer>();
                theObject.DisplayName = Name;
                theObject.TaxId = TaxId;
            }
        }

        public override void UpdateDatabaseBeforeUpdateSchema()
        {
            base.UpdateDatabaseBeforeUpdateSchema();
            //if(CurrentDBVersion < new Version("1.1.0.0") && CurrentDBVersion > new Version("0.0.0.0")) {
            //    RenameColumn("DomainObject1Table", "OldColumnName", "NewColumnName");
            //}
        }
    }
}