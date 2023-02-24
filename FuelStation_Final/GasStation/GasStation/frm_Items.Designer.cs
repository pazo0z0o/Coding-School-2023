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
            this.components = new System.ComponentModel.Container();
            this.grv_Items = new System.Windows.Forms.DataGridView();
            this.col_Item_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_Back = new System.Windows.Forms.Button();
            this.btn_Close = new System.Windows.Forms.Button();
            this.btn_Item_delete = new System.Windows.Forms.Button();
            this.btn_Item_Load = new System.Windows.Forms.Button();
            this.btn_Item_save = new System.Windows.Forms.Button();
            this.bsItems = new System.Windows.Forms.BindingSource(this.components);
            this.colCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_ItemType = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.col_Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Cost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grv_Items)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsItems)).BeginInit();
            this.SuspendLayout();
            // 
            // grv_Items
            // 
            this.grv_Items.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grv_Items.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grv_Items.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCode,
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
            // btn_Back
            // 
            this.btn_Back.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Back.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btn_Back.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Back.Location = new System.Drawing.Point(616, 522);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(71, 39);
            this.btn_Back.TabIndex = 29;
            this.btn_Back.Text = "BACK";
            this.btn_Back.UseVisualStyleBackColor = false;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // btn_Close
            // 
            this.btn_Close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Close.BackColor = System.Drawing.Color.Red;
            this.btn_Close.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Close.Location = new System.Drawing.Point(614, 567);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(73, 39);
            this.btn_Close.TabIndex = 28;
            this.btn_Close.Text = "X Close";
            this.btn_Close.UseVisualStyleBackColor = false;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // btn_Item_delete
            // 
            this.btn_Item_delete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Item_delete.BackColor = System.Drawing.Color.Red;
            this.btn_Item_delete.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Item_delete.Location = new System.Drawing.Point(573, 97);
            this.btn_Item_delete.Name = "btn_Item_delete";
            this.btn_Item_delete.Size = new System.Drawing.Size(104, 39);
            this.btn_Item_delete.TabIndex = 26;
            this.btn_Item_delete.Text = "DEL";
            this.btn_Item_delete.UseVisualStyleBackColor = false;
            this.btn_Item_delete.Click += new System.EventHandler(this.btn_Item_delete_Click);
            // 
            // btn_Item_Load
            // 
            this.btn_Item_Load.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Item_Load.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btn_Item_Load.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Item_Load.Location = new System.Drawing.Point(573, 52);
            this.btn_Item_Load.Name = "btn_Item_Load";
            this.btn_Item_Load.Size = new System.Drawing.Size(104, 39);
            this.btn_Item_Load.TabIndex = 25;
            this.btn_Item_Load.Text = "Load";
            this.btn_Item_Load.UseVisualStyleBackColor = false;
            this.btn_Item_Load.Click += new System.EventHandler(this.btn_Item_Load_Click);
            // 
            // btn_Item_save
            // 
            this.btn_Item_save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Item_save.BackColor = System.Drawing.Color.Gold;
            this.btn_Item_save.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Item_save.Location = new System.Drawing.Point(573, 7);
            this.btn_Item_save.Name = "btn_Item_save";
            this.btn_Item_save.Size = new System.Drawing.Size(104, 39);
            this.btn_Item_save.TabIndex = 24;
            this.btn_Item_save.Text = "Save";
            this.btn_Item_save.UseVisualStyleBackColor = false;
            this.btn_Item_save.Click += new System.EventHandler(this.btn_Item_save_Click);
            // 
            // colCode
            // 
            this.colCode.DataPropertyName = "Code";
            this.colCode.HeaderText = "Code";
            this.colCode.Name = "colCode";
            // 
            // col_Description
            // 
            this.col_Description.DataPropertyName = "Description";
            this.col_Description.HeaderText = "Description";
            this.col_Description.Name = "col_Description";
            // 
            // col_ItemType
            // 
            this.col_ItemType.DataPropertyName = "ItemType";
            this.col_ItemType.HeaderText = "Item Type";
            this.col_ItemType.Name = "col_ItemType";
            this.col_ItemType.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.col_ItemType.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // col_Price
            // 
            this.col_Price.DataPropertyName = "Price";
            this.col_Price.HeaderText = "Price";
            this.col_Price.Name = "col_Price";
            // 
            // col_Cost
            // 
            this.col_Cost.DataPropertyName = "Cost";
            this.col_Cost.HeaderText = "Cost";
            this.col_Cost.Name = "col_Cost";
            // 
            // frm_Items
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 618);
            this.Controls.Add(this.btn_Back);
            this.Controls.Add(this.btn_Close);
            this.Controls.Add(this.btn_Item_delete);
            this.Controls.Add(this.btn_Item_Load);
            this.Controls.Add(this.btn_Item_save);
            this.Controls.Add(this.grv_Items);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frm_Items";
            this.Text = "frm_Items";
            this.Load += new System.EventHandler(this.frm_Items_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grv_Items)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsItems)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView grv_Items;
        private DataGridViewTextBoxColumn col_Item_ID;
        private DataGridViewTextBoxColumn col_ID;
        private DataGridViewTextBoxColumn col_Code;
        private Button btn_Back;
        private Button btn_Close;
        private Button btn_Item_delete;
        private Button btn_Item_Load;
        private Button btn_Item_save;
        private BindingSource bsItems;
        private DataGridViewTextBoxColumn colCode;
        private DataGridViewTextBoxColumn col_Description;
        private DataGridViewComboBoxColumn col_ItemType;
        private DataGridViewTextBoxColumn col_Price;
        private DataGridViewTextBoxColumn col_Cost;
    }
}