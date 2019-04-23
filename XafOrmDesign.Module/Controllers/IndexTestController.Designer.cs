namespace XafOrmDesign.Module.Controllers
{
    partial class IndexTestController
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
            this.saQueryWithIndex = new DevExpress.ExpressApp.Actions.SimpleAction(this.components);
            this.saQueryWithoutIndex = new DevExpress.ExpressApp.Actions.SimpleAction(this.components);
            // 
            // saQueryWithIndex
            // 
            this.saQueryWithIndex.Caption = "Query with index";
            this.saQueryWithIndex.ConfirmationMessage = null;
            this.saQueryWithIndex.Id = "be379229-fd97-4e8f-ab02-cdfcd1189bad";
            this.saQueryWithIndex.ToolTip = null;
            this.saQueryWithIndex.Execute += new DevExpress.ExpressApp.Actions.SimpleActionExecuteEventHandler(this.saQueryWithIndex_Execute);
            // 
            // saQueryWithoutIndex
            // 
            this.saQueryWithoutIndex.Caption = null;
            this.saQueryWithoutIndex.ConfirmationMessage = null;
            this.saQueryWithoutIndex.Id = "7bbe8aad-a884-4f39-b96e-209fbbe45b3a";
            this.saQueryWithoutIndex.ToolTip = null;
            this.saQueryWithoutIndex.Execute += new DevExpress.ExpressApp.Actions.SimpleActionExecuteEventHandler(this.saQueryWithoutIndex_Execute);
            // 
            // IndexTestController
            // 
            this.Actions.Add(this.saQueryWithIndex);
            this.Actions.Add(this.saQueryWithoutIndex);

        }

        #endregion

        private DevExpress.ExpressApp.Actions.SimpleAction saQueryWithIndex;
        private DevExpress.ExpressApp.Actions.SimpleAction saQueryWithoutIndex;
    }
}
