using System;
using System.Diagnostics;
using System.Linq;
using DevExpress.ExpressApp;
using DevExpress.Data.Filtering;
using DevExpress.Persistent.Base;
using DevExpress.ExpressApp.Updating;
using DevExpress.Xpo;
using DevExpress.ExpressApp.Xpo;
using DevExpress.Persistent.BaseImpl;
using XafOrmDesign.Module.BusinessObjects;
using XafOrmDesign.Module.BusinessObjects.NormalizationExample.Normalized;
using XafOrmDesign.Module.BusinessObjects.NormalizationExample;
using XafOrmDesign.Module.BusinessObjects.MemoryUsage;

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

            CreateResult("Create");
            CreateResult("Read");
            CreateResult("Update");
            CreateResult("Delete");
            CreateMemoryUsageResult("Read");
            this.ObjectSpace.CommitChanges();
        }

        private void CreateMemoryUsageResult(string Operation)
        {
            var MemoryUsageResult = this.ObjectSpace.GetObjectByKey<MemoryUsageResult>(Operation);
            if (MemoryUsageResult == null)
            {
                MemoryUsageResult = this.ObjectSpace.CreateObject<MemoryUsageResult>();
                MemoryUsageResult.Operation = Operation;
            }
        }

        private void CreateResult(string Operation)
        {
            var Insert = this.ObjectSpace.GetObjectByKey<CrudOperationResult>(Operation);
            if (Insert == null)
            {
                Insert = this.ObjectSpace.CreateObject<CrudOperationResult>();
                Insert.Operation = Operation;
            }
        }

        private void FindPerson()
        {
            // Tasks performed by method
        }

        private void CreatePersons()
        {
            for (int i = 0; i < 10000; i++)
            {
                var PersonWithoutIndex = ObjectSpace.CreateObject<PersonWithOutIndex>();
                var PersonWithIndex = ObjectSpace.CreateObject<PersonWithIndex>();

                PersonWithoutIndex.Name = $"Person {i}";
                PersonWithoutIndex.FullName = $"Full Person Name {i}";

                PersonWithIndex.Name = $"Person {i}";
                PersonWithIndex.FullName = $"Full Person Name {i}";
            }

            var JoseManuelOjedaWithOutIndex = ObjectSpace.CreateObject<PersonWithOutIndex>();
            JoseManuelOjedaWithOutIndex.Name = "Jose";
            JoseManuelOjedaWithOutIndex.FullName = "Jose Manuel Ojeda Melgar";

            var JoseManuelOjedaWithIndex = ObjectSpace.CreateObject<PersonWithIndex>();
            JoseManuelOjedaWithIndex.Name = "Jose";
            JoseManuelOjedaWithIndex.FullName = "Jose Manuel Ojeda Melgar";

            var RoccoOjedaWithOutIndex = ObjectSpace.CreateObject<PersonWithOutIndex>();
            RoccoOjedaWithOutIndex.Name = "Rocco";
            RoccoOjedaWithOutIndex.FullName = "Rocco Ojeda Melgar";

            var RoccoOjedaWithIndex = ObjectSpace.CreateObject<PersonWithOutIndex>();
            RoccoOjedaWithIndex.Name = "Rocco";
            RoccoOjedaWithIndex.FullName = "Rocco Ojeda Melgar";
        }

        private void CreateCustomers()
        {
            // Create new stopwatch
            System.Diagnostics.Stopwatch stopwatch = new System.Diagnostics.Stopwatch();

            // Begin timing
            stopwatch.Start();

            // Tasks performed by method

            stopwatch.Stop();

            Console.WriteLine("Time taken : {0}", stopwatch.Elapsed.TotalMilliseconds);
        }

        private void LoadCustomers()
        {
            System.Diagnostics.Stopwatch stopwatch = new System.Diagnostics.Stopwatch();
            var InitialMemory = GC.GetTotalMemory(false);
            // Begin timing
            stopwatch.Start();
            var ListOfCustomers = this.ObjectSpace.CreateCollection(typeof(Customer)).Cast<Customer>().ToArray();
            // Stop timing
            stopwatch.Stop();
            var FinalMemory = GC.GetTotalMemory(false);
            var TotalMemory = (FinalMemory - InitialMemory) / 1000;
            Debug.WriteLine(string.Format("{0}:{1}", "TotalMemory in KB", TotalMemory));
            Console.WriteLine("Time taken : {0}", stopwatch.Elapsed.TotalMilliseconds);
        }

        private void LoadCustomersFromView()
        {
            System.Diagnostics.Stopwatch stopwatch = new System.Diagnostics.Stopwatch();
            var InitialMemory = GC.GetTotalMemory(false);
            // Begin timing
            stopwatch.Start();
            var ListOfCustomers = this.ObjectSpace.CreateDataView(typeof(Customer), "Oid;TaxId", null, null);
            var ListOfCustomerCount = ListOfCustomers.Count;
            // Stop timing
            stopwatch.Stop();
            var FinalMemory = GC.GetTotalMemory(false);
            var TotalMemory = (FinalMemory - InitialMemory) / 1000;
            Debug.WriteLine(string.Format("{0}:{1}", "TotalMemory in KB", TotalMemory));
            Console.WriteLine("Time taken : {0}", stopwatch.Elapsed.TotalMilliseconds);
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