namespace Session_16_PetShop
{
    partial class Form2
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.grdCustomers = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCusName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCusSurname = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPhone = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTIN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.bsCustomers = new System.Windows.Forms.BindingSource(this.components);
            this.grdEmployees = new DevExpress.XtraGrid.GridControl();
            this.Employees = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colEmpName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEmpID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEmpSurname = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEmpType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSalary = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.grdPet = new DevExpress.XtraGrid.GridControl();
            this.Pets = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.grdPetFood = new DevExpress.XtraGrid.GridControl();
            this.PetFood = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.grdTransactions = new DevExpress.XtraGrid.GridControl();
            this.Transactions = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.grdCustomers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsCustomers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdEmployees)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Employees)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdPet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pets)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdPetFood)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PetFood)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdTransactions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Transactions)).BeginInit();
            this.SuspendLayout();
            // 
            // grdCustomers
            // 
            this.grdCustomers.Location = new System.Drawing.Point(1, 3);
            this.grdCustomers.MainView = this.gridView1;
            this.grdCustomers.Name = "grdCustomers";
            this.grdCustomers.Size = new System.Drawing.Size(488, 160);
            this.grdCustomers.TabIndex = 27;
            this.grdCustomers.UseEmbeddedNavigator = true;
            this.grdCustomers.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.colCusName,
            this.colCusSurname,
            this.colPhone,
            this.colTIN});
            this.gridView1.GridControl = this.grdCustomers;
            this.gridView1.Name = "gridView1";
            this.gridView1.RowDeleting += new DevExpress.Data.RowDeletingEventHandler(this.gridView1_RowDeleting);
            this.gridView1.ValidateRow += new DevExpress.XtraGrid.Views.Base.ValidateRowEventHandler(this.gridView1_ValidateRow);
            this.gridView1.RowUpdated += new DevExpress.XtraGrid.Views.Base.RowObjectEventHandler(this.gridView1_RowUpdated);
            // 
            // colID
            // 
            this.colID.Caption = "Customer ID";
            this.colID.FieldName = "CustomerID";
            this.colID.Name = "colID";
            this.colID.Visible = true;
            this.colID.VisibleIndex = 0;
            // 
            // colCusName
            // 
            this.colCusName.Caption = "Name";
            this.colCusName.FieldName = "Name";
            this.colCusName.Name = "colCusName";
            this.colCusName.Visible = true;
            this.colCusName.VisibleIndex = 1;
            // 
            // colCusSurname
            // 
            this.colCusSurname.Caption = "Surname";
            this.colCusSurname.FieldName = "Surname";
            this.colCusSurname.Name = "colCusSurname";
            this.colCusSurname.Visible = true;
            this.colCusSurname.VisibleIndex = 2;
            // 
            // colPhone
            // 
            this.colPhone.Caption = "Phone";
            this.colPhone.FieldName = "Phone";
            this.colPhone.Name = "colPhone";
            this.colPhone.Visible = true;
            this.colPhone.VisibleIndex = 3;
            // 
            // colTIN
            // 
            this.colTIN.Caption = "TIN";
            this.colTIN.FieldName = "TIN";
            this.colTIN.Name = "colTIN";
            this.colTIN.Visible = true;
            this.colTIN.VisibleIndex = 4;
            // 
            // grdEmployees
            // 
            this.grdEmployees.Location = new System.Drawing.Point(1, 411);
            this.grdEmployees.MainView = this.Employees;
            this.grdEmployees.Name = "grdEmployees";
            this.grdEmployees.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemLookUpEdit1});
            this.grdEmployees.Size = new System.Drawing.Size(488, 161);
            this.grdEmployees.TabIndex = 28;
            this.grdEmployees.UseEmbeddedNavigator = true;
            this.grdEmployees.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.Employees});
            // 
            // Employees
            // 
            this.Employees.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colEmpID,
            this.colEmpName,
            this.colEmpSurname,
            this.colEmpType,
            this.colSalary});
            this.Employees.GridControl = this.grdEmployees;
            this.Employees.Name = "Employees";
            // 
            // colEmpName
            // 
            this.colEmpName.Caption = "Employee Name";
            this.colEmpName.FieldName = "EmpName";
            this.colEmpName.Name = "colEmpName";
            this.colEmpName.Visible = true;
            this.colEmpName.VisibleIndex = 0;
            // 
            // colEmpID
            // 
            this.colEmpID.Caption = "Employee ID";
            this.colEmpID.FieldName = "EmployeeID";
            this.colEmpID.Name = "colEmpID";
            this.colEmpID.Visible = true;
            this.colEmpID.VisibleIndex = 1;
            // 
            // colEmpSurname
            // 
            this.colEmpSurname.Caption = "Employee Surname";
            this.colEmpSurname.FieldName = "EmpSurname";
            this.colEmpSurname.Name = "colEmpSurname";
            this.colEmpSurname.Visible = true;
            this.colEmpSurname.VisibleIndex = 2;
            // 
            // colEmpType
            // 
            this.colEmpType.Caption = "Employee Post";
            this.colEmpType.FieldName = "EmpType";
            this.colEmpType.Name = "colEmpType";
            this.colEmpType.Visible = true;
            this.colEmpType.VisibleIndex = 3;
            // 
            // colSalary
            // 
            this.colSalary.Caption = "Salary ";
            this.colSalary.FieldName = "SalaryPerMonth";
            this.colSalary.Name = "colSalary";
            this.colSalary.Visible = true;
            this.colSalary.VisibleIndex = 4;
            // 
            // repositoryItemLookUpEdit1
            // 
            this.repositoryItemLookUpEdit1.AutoHeight = false;
            this.repositoryItemLookUpEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEdit1.Name = "repositoryItemLookUpEdit1";
            // 
            // grdPet
            // 
            this.grdPet.Location = new System.Drawing.Point(1000, 3);
            this.grdPet.MainView = this.Pets;
            this.grdPet.Name = "grdPet";
            this.grdPet.Size = new System.Drawing.Size(458, 151);
            this.grdPet.TabIndex = 29;
            this.grdPet.UseEmbeddedNavigator = true;
            this.grdPet.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.Pets});
            // 
            // Pets
            // 
            this.Pets.GridControl = this.grdPet;
            this.Pets.Name = "Pets";
            // 
            // grdPetFood
            // 
            this.grdPetFood.Location = new System.Drawing.Point(1000, 411);
            this.grdPetFood.MainView = this.PetFood;
            this.grdPetFood.Name = "grdPetFood";
            this.grdPetFood.Size = new System.Drawing.Size(458, 161);
            this.grdPetFood.TabIndex = 30;
            this.grdPetFood.UseEmbeddedNavigator = true;
            this.grdPetFood.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.PetFood});
            // 
            // PetFood
            // 
            this.PetFood.GridControl = this.grdPetFood;
            this.PetFood.Name = "PetFood";
            // 
            // grdTransactions
            // 
            this.grdTransactions.Location = new System.Drawing.Point(436, 200);
            this.grdTransactions.MainView = this.Transactions;
            this.grdTransactions.Name = "grdTransactions";
            this.grdTransactions.Size = new System.Drawing.Size(619, 178);
            this.grdTransactions.TabIndex = 31;
            this.grdTransactions.UseEmbeddedNavigator = true;
            this.grdTransactions.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.Transactions});
            // 
            // Transactions
            // 
            this.Transactions.GridControl = this.grdTransactions;
            this.Transactions.Name = "Transactions";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1459, 629);
            this.Controls.Add(this.grdTransactions);
            this.Controls.Add(this.grdPetFood);
            this.Controls.Add(this.grdPet);
            this.Controls.Add(this.grdEmployees);
            this.Controls.Add(this.grdCustomers);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdCustomers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsCustomers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdEmployees)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Employees)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdPet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pets)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdPetFood)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PetFood)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdTransactions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Transactions)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraGrid.GridControl grdCustomers;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colCusName;
        private DevExpress.XtraGrid.Columns.GridColumn colCusSurname;
        private DevExpress.XtraGrid.Columns.GridColumn colPhone;
        private DevExpress.XtraGrid.Columns.GridColumn colTIN;
        private BindingSource bsCustomers;
        private DevExpress.XtraGrid.GridControl grdEmployees;
        private DevExpress.XtraGrid.Views.Grid.GridView Employees;
        private DevExpress.XtraGrid.Columns.GridColumn colEmpName;
        private DevExpress.XtraGrid.Columns.GridColumn colEmpID;
        private DevExpress.XtraGrid.Columns.GridColumn colEmpSurname;
        private DevExpress.XtraGrid.Columns.GridColumn colEmpType;
        private DevExpress.XtraGrid.Columns.GridColumn colSalary;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit1;
        private DevExpress.XtraGrid.GridControl grdPet;
        private DevExpress.XtraGrid.Views.Grid.GridView Pets;
        private DevExpress.XtraGrid.GridControl grdPetFood;
        private DevExpress.XtraGrid.Views.Grid.GridView PetFood;
        private DevExpress.XtraGrid.GridControl grdTransactions;
        private DevExpress.XtraGrid.Views.Grid.GridView Transactions;
    }
}