namespace XafOrmDesign.Module.Controllers
{
    partial class CustomerController
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.saCreateCustomerDenormalizedForm = new DevExpress.ExpressApp.Actions.SimpleAction(this.components);
            this.saCreateCustomerNormalizedForm = new DevExpress.ExpressApp.Actions.SimpleAction(this.components);
            this.saDeleteCustomersNormalized = new DevExpress.ExpressApp.Actions.SimpleAction(this.components);
            this.saDeleteCustomersDenormalized = new DevExpress.ExpressApp.Actions.SimpleAction(this.components);
            this.saReadCustomersNormalized = new DevExpress.ExpressApp.Actions.SimpleAction(this.components);
            this.saReadCustomersDenormalized = new DevExpress.ExpressApp.Actions.SimpleAction(this.components);
            this.saUpdateCustomerDenormalized = new DevExpress.ExpressApp.Actions.SimpleAction(this.components);
            this.saUpdateCustomerNormalized = new DevExpress.ExpressApp.Actions.SimpleAction(this.components);
            this.saReadFullObjects = new DevExpress.ExpressApp.Actions.SimpleAction(this.components);
            this.saReadObjectsFromView = new DevExpress.ExpressApp.Actions.SimpleAction(this.components);
            this.saResetAllResults = new DevExpress.ExpressApp.Actions.SimpleAction(this.components);
            // 
            // saCreateCustomerDenormalizedForm
            // 
            this.saCreateCustomerDenormalizedForm.Caption = "Insert Customer Denormalized Schema";
            this.saCreateCustomerDenormalizedForm.ConfirmationMessage = null;
            this.saCreateCustomerDenormalizedForm.Id = "d937428b-e147-41cb-8b74-8c68acd775a2";
            this.saCreateCustomerDenormalizedForm.ToolTip = null;
            this.saCreateCustomerDenormalizedForm.Execute += new DevExpress.ExpressApp.Actions.SimpleActionExecuteEventHandler(this.saCreateCustomerDenormalizedForm_Execute);
            // 
            // saCreateCustomerNormalizedForm
            // 
            this.saCreateCustomerNormalizedForm.Caption = "Insert Customer Normalized Schema";
            this.saCreateCustomerNormalizedForm.ConfirmationMessage = null;
            this.saCreateCustomerNormalizedForm.Id = "e04a128c-ebc0-4080-90af-834c3a2a7b37";
            this.saCreateCustomerNormalizedForm.ToolTip = null;
            this.saCreateCustomerNormalizedForm.Execute += new DevExpress.ExpressApp.Actions.SimpleActionExecuteEventHandler(this.saCreateCustomerNormalizedForm_Execute);
            // 
            // saDeleteCustomersNormalized
            // 
            this.saDeleteCustomersNormalized.Caption = "Delete Customers Normalized Schema";
            this.saDeleteCustomersNormalized.ConfirmationMessage = null;
            this.saDeleteCustomersNormalized.Id = "e3d4c43e-279d-4ddc-964c-d9bb1e7f3982";
            this.saDeleteCustomersNormalized.ToolTip = null;
            this.saDeleteCustomersNormalized.Execute += new DevExpress.ExpressApp.Actions.SimpleActionExecuteEventHandler(this.saDeleteCustomersNormalized_Execute);
            // 
            // saDeleteCustomersDenormalized
            // 
            this.saDeleteCustomersDenormalized.Caption = "Delete Customers Denormalized Schema";
            this.saDeleteCustomersDenormalized.ConfirmationMessage = null;
            this.saDeleteCustomersDenormalized.Id = "5d40052c-5cd7-470d-bcf5-23ef8cc085bf";
            this.saDeleteCustomersDenormalized.ToolTip = null;
            this.saDeleteCustomersDenormalized.Execute += new DevExpress.ExpressApp.Actions.SimpleActionExecuteEventHandler(this.saDeleteCustomersDenormalized_Execute);
            // 
            // saReadCustomersNormalized
            // 
            this.saReadCustomersNormalized.Caption = "Read Customers Normalized Schema";
            this.saReadCustomersNormalized.ConfirmationMessage = null;
            this.saReadCustomersNormalized.Id = "Delete Customers Normalized Schema";
            this.saReadCustomersNormalized.ToolTip = null;
            this.saReadCustomersNormalized.Execute += new DevExpress.ExpressApp.Actions.SimpleActionExecuteEventHandler(this.saReadCustomersNormalized_Execute);
            // 
            // saReadCustomersDenormalized
            // 
            this.saReadCustomersDenormalized.Caption = "Read Customers Denormalized Schema";
            this.saReadCustomersDenormalized.ConfirmationMessage = null;
            this.saReadCustomersDenormalized.Id = "Read Customers Denormalized Schema";
            this.saReadCustomersDenormalized.ToolTip = null;
            this.saReadCustomersDenormalized.Execute += new DevExpress.ExpressApp.Actions.SimpleActionExecuteEventHandler(this.saReadCustomersDenormalized_Execute);
            // 
            // saUpdateCustomerDenormalized
            // 
            this.saUpdateCustomerDenormalized.Caption = "Update Denormalized Schema";
            this.saUpdateCustomerDenormalized.ConfirmationMessage = null;
            this.saUpdateCustomerDenormalized.Id = "f9775072-c08b-4a72-9938-099e600316bd";
            this.saUpdateCustomerDenormalized.ToolTip = null;
            this.saUpdateCustomerDenormalized.Execute += new DevExpress.ExpressApp.Actions.SimpleActionExecuteEventHandler(this.saUpdateCustomerDenormalized_Execute);
            // 
            // saUpdateCustomerNormalized
            // 
            this.saUpdateCustomerNormalized.Caption = "Update Normalized Schema";
            this.saUpdateCustomerNormalized.ConfirmationMessage = null;
            this.saUpdateCustomerNormalized.Id = "f4f12163-bc4b-4e56-8d34-c2e43ba26b86";
            this.saUpdateCustomerNormalized.ToolTip = null;
            this.saUpdateCustomerNormalized.Execute += new DevExpress.ExpressApp.Actions.SimpleActionExecuteEventHandler(this.saUpdateCustomerNormalized_Execute);
            // 
            // saReadFullObjects
            // 
            this.saReadFullObjects.Caption = "Read Full Objects";
            this.saReadFullObjects.ConfirmationMessage = null;
            this.saReadFullObjects.Id = "2907813e-c660-4f2e-b9a8-e107b3af1f2d";
            this.saReadFullObjects.ToolTip = null;
            this.saReadFullObjects.Execute += new DevExpress.ExpressApp.Actions.SimpleActionExecuteEventHandler(this.saReadFullObjects_Execute);
            // 
            // saReadObjectsFromView
            // 
            this.saReadObjectsFromView.Caption = "Read Objects From View";
            this.saReadObjectsFromView.ConfirmationMessage = null;
            this.saReadObjectsFromView.Id = "0f88c16c-97c9-4875-8620-c691374a2c87";
            this.saReadObjectsFromView.ToolTip = null;
            this.saReadObjectsFromView.Execute += new DevExpress.ExpressApp.Actions.SimpleActionExecuteEventHandler(this.saReadObjectsFromView_Execute);
            // 
            // saResetAllResults
            // 
            this.saResetAllResults.Caption = "Reset Results";
            this.saResetAllResults.ConfirmationMessage = null;
            this.saResetAllResults.Id = "8cc49df4-c991-4ac2-bca5-a13945ea58fc";
            this.saResetAllResults.ToolTip = null;
            this.saResetAllResults.Execute += new DevExpress.ExpressApp.Actions.SimpleActionExecuteEventHandler(this.saResetAllResults_Execute);
            // 
            // CustomerController
            // 
            this.Actions.Add(this.saCreateCustomerDenormalizedForm);
            this.Actions.Add(this.saCreateCustomerNormalizedForm);
            this.Actions.Add(this.saDeleteCustomersNormalized);
            this.Actions.Add(this.saDeleteCustomersDenormalized);
            this.Actions.Add(this.saReadCustomersNormalized);
            this.Actions.Add(this.saReadCustomersDenormalized);
            this.Actions.Add(this.saUpdateCustomerDenormalized);
            this.Actions.Add(this.saUpdateCustomerNormalized);
            this.Actions.Add(this.saReadFullObjects);
            this.Actions.Add(this.saReadObjectsFromView);
            this.Actions.Add(this.saResetAllResults);

        }

        #endregion

        private DevExpress.ExpressApp.Actions.SimpleAction saCreateCustomerDenormalizedForm;
        private DevExpress.ExpressApp.Actions.SimpleAction saCreateCustomerNormalizedForm;
        private DevExpress.ExpressApp.Actions.SimpleAction saDeleteCustomersNormalized;
        private DevExpress.ExpressApp.Actions.SimpleAction saDeleteCustomersDenormalized;
        private DevExpress.ExpressApp.Actions.SimpleAction saReadCustomersNormalized;
        private DevExpress.ExpressApp.Actions.SimpleAction saReadCustomersDenormalized;
        private DevExpress.ExpressApp.Actions.SimpleAction saUpdateCustomerDenormalized;
        private DevExpress.ExpressApp.Actions.SimpleAction saUpdateCustomerNormalized;
        private DevExpress.ExpressApp.Actions.SimpleAction saReadFullObjects;
        private DevExpress.ExpressApp.Actions.SimpleAction saReadObjectsFromView;
        private DevExpress.ExpressApp.Actions.SimpleAction saResetAllResults;
    }
}
