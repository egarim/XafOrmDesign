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
            // CustomerController
            // 
            this.Actions.Add(this.saCreateCustomerDenormalizedForm);
            this.Actions.Add(this.saCreateCustomerNormalizedForm);
            this.Actions.Add(this.saDeleteCustomersNormalized);
            this.Actions.Add(this.saDeleteCustomersDenormalized);

        }

        #endregion

        private DevExpress.ExpressApp.Actions.SimpleAction saCreateCustomerDenormalizedForm;
        private DevExpress.ExpressApp.Actions.SimpleAction saCreateCustomerNormalizedForm;
        private DevExpress.ExpressApp.Actions.SimpleAction saDeleteCustomersNormalized;
        private DevExpress.ExpressApp.Actions.SimpleAction saDeleteCustomersDenormalized;
    }
}
