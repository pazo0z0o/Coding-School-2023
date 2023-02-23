namespace FuelStation.Win
{
    partial class frm_Items
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
            this.grv_Items = new System.Windows.Forms.DataGridView();
            this.colID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_ItemType = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.col_Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Cost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Item_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grv_Items)).BeginInit();
            this.SuspendLayout();
            // 
            // grv_Items
            // 
            this.grv_Items.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grv_Items.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grv_Items.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colID,
            this.dataGridViewTextBoxColumn1,
            this.col_Description,
            this.col_ItemType,
            this.col_Price,
            this.col_Cost});
            this.grv_Items.Location = new System.Drawing.Point(0, 0);
            this.grv_Items.Name = "grv_Items";
            this.grv_Items.RowTemplate.Height = 25;
            this.grv_Items.Size = new System.Drawing.Size(556, 150);
            this.grv_Items.TabIndex = 0;
            // 
            // colID
            // 
            this.colID.HeaderText = "Item ID";
            this.colID.Name = "colID";
            this.colID.Visible = false;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Code";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // col_Description
            // 
            this.col_Description.HeaderText = "Description";
            this.col_Description.Name = "col_Description";
            // 
            // col_ItemType
            // 
            this.col_ItemType.HeaderText = "Item Type";
            this.col_ItemType.Name = "col_ItemType";
            this.col_ItemType.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.col_ItemType.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // col_Price
            // 
            this.col_Price.HeaderText = "Price";
            this.col_Price.Name = "col_Price";
            // 
            // col_Cost
            // 
            this.col_Cost.HeaderText = "Cost";
            this.col_Cost.Name = "col_Cost";
            // 
            // col_Item_ID
            // 
            this.col_Item_ID.HeaderText = "ItemID";
            this.col_Item_ID.Name = "col_Item_ID";
            this.col_Item_ID.Visible = false;
            // 
            // col_ID
            // 
            this.col_ID.HeaderText = "ID";
            this.col_ID.Name = "col_ID";
            this.col_ID.Visible = false;
            // 
            // col_Code
            // 
            this.col_Code.HeaderText = "Code";
            this.col_Code.Name = "col_Code";
            // 
            // frm_Items
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(911, 450);
            this.Controls.Add(this.grv_Items);
            this.Name = "frm_Items";
            this.Text = "frm_Items";
            ((System.ComponentModel.ISupportInitialize)(this.grv_Items)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView grv_Items;
        private DataGridViewTextBoxColumn col_Item_ID;
        private DataGridViewTextBoxColumn col_ID;
        private DataGridViewTextBoxColumn col_Code;
        private DataGridViewTextBoxColumn colID;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn col_Description;
        private DataGridViewComboBoxColumn col_ItemType;
        private DataGridViewTextBoxColumn col_Price;
        private DataGridViewTextBoxColumn col_Cost;
    }
}