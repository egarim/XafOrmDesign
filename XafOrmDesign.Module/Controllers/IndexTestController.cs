using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
using XafOrmDesign.Module.BusinessObjects;

namespace XafOrmDesign.Module.Controllers
{
    // For more typical usage scenarios, be sure to check out https://documentation.devexpress.com/eXpressAppFramework/clsDevExpressExpressAppViewControllertopic.aspx.
    public partial class IndexTestController : ViewController
    {
        public IndexTestController()
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

        private void saQueryWithIndex_Execute(object sender, SimpleActionExecuteEventArgs e)
        {
            StopWatch.Start(() =>
            {
                var ByFullName = this.ObjectSpace.FindObject<PersonWithOutIndex>(new BinaryOperator(nameof(PersonWithOutIndex.FullName), "Rocco Ojeda"));
            }, "Find person by name");
        }

        private void saQueryWithoutIndex_Execute(object sender, SimpleActionExecuteEventArgs e)
        {
            StopWatch.Start(() =>
            {
                var ByName = this.ObjectSpace.FindObject<PersonWithOutIndex>(new BinaryOperator(nameof(PersonWithOutIndex.Name), "Jose"));
            }, "Find person by name");
        }
    }
}