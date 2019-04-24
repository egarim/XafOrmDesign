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
using XafOrmDesign.Module.BusinessObjects.Results;

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

        private void CreatePersons()
        {
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