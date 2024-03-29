﻿namespace FuelStation.Win
{
    partial class frm_TransactionLines
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btn_EndEdit = new System.Windows.Forms.Button();
            this.btn_Back = new System.Windows.Forms.Button();
            this.btn_trl_Add = new System.Windows.Forms.Button();
            this.btn_trl_delete = new System.Windows.Forms.Button();
            this.btn_trl_save = new System.Windows.Forms.Button();
            this.grv_TransactionLine = new System.Windows.Forms.DataGridView();
            this.bsTransLine = new System.Windows.Forms.BindingSource(this.components);
            this.col_trl_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_ItemID = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.col_ItemPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_NetValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_DiscountPercent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_DiscountValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_TotalValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_transID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grv_TransactionLine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsTransLine)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_EndEdit
            // 
            this.btn_EndEdit.BackColor = System.Drawing.Color.Transparent;
            this.btn_EndEdit.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_EndEdit.ForeColor = System.Drawing.Color.Green;
            this.btn_EndEdit.Location = new System.Drawing.Point(1236, 145);
            this.btn_EndEdit.Name = "btn_EndEdit";
            this.btn_EndEdit.Size = new System.Drawing.Size(105, 35);
            this.btn_EndEdit.TabIndex = 38;
            this.btn_EndEdit.Text = "End Transaction";
            this.btn_EndEdit.UseVisualStyleBackColor = false;
            this.btn_EndEdit.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_Back
            // 
            this.btn_Back.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Back.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btn_Back.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Back.Location = new System.Drawing.Point(1394, 490);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(71, 39);
            this.btn_Back.TabIndex = 37;
            this.btn_Back.Text = "BACK";
            this.btn_Back.UseVisualStyleBackColor = false;
            // 
            // btn_trl_Add
            // 
            this.btn_trl_Add.BackColor = System.Drawing.Color.LimeGreen;
            this.btn_trl_Add.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_trl_Add.Location = new System.Drawing.Point(1236, 57);
            this.btn_trl_Add.Name = "btn_trl_Add";
            this.btn_trl_Add.Size = new System.Drawing.Size(105, 39);
            this.btn_trl_Add.TabIndex = 36;
            this.btn_trl_Add.Text = "+Add";
            this.btn_trl_Add.UseVisualStyleBackColor = false;
            this.btn_trl_Add.Click += new System.EventHandler(this.btn_trl_Add_Click);
            // 
            // btn_trl_delete
            // 
            this.btn_trl_delete.BackColor = System.Drawing.Color.Red;
            this.btn_trl_delete.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_trl_delete.Location = new System.Drawing.Point(1236, 102);
            this.btn_trl_delete.Name = "btn_trl_delete";
            this.btn_trl_delete.Size = new System.Drawing.Size(105, 39);
            this.btn_trl_delete.TabIndex = 35;
            this.btn_trl_delete.Text = "DEL";
            this.btn_trl_delete.UseVisualStyleBackColor = false;
            this.btn_trl_delete.Click += new System.EventHandler(this.btn_trl_delete_Click);
            // 
            // btn_trl_save
            // 
            this.btn_trl_save.BackColor = System.Drawing.Color.Gold;
            this.btn_trl_save.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_trl_save.Location = new System.Drawing.Point(1236, 12);
            this.btn_trl_save.Name = "btn_trl_save";
            this.btn_trl_save.Size = new System.Drawing.Size(105, 39);
            this.btn_trl_save.TabIndex = 33;
            this.btn_trl_save.Text = "Save";
            this.btn_trl_save.UseVisualStyleBackColor = false;
            this.btn_trl_save.Click += new System.EventHandler(this.btn_trl_save_Click);
            // 
            // grv_TransactionLine
            // 
            this.grv_TransactionLine.AllowUserToAddRows = false;
            this.grv_TransactionLine.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grv_TransactionLine.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grv_TransactionLine.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_trl_ID,
            this.col_ItemID,
            this.col_ItemPrice,
            this.col_Quantity,
            this.col_NetValue,
            this.col_DiscountPercent,
            this.col_DiscountValue,
            this.col_TotalValue,
            this.col_transID});
            this.grv_TransactionLine.Location = new System.Drawing.Point(5, 12);
            this.grv_TransactionLine.MultiSelect = false;
            this.grv_TransactionLine.Name = "grv_TransactionLine";
            this.grv_TransactionLine.RowTemplate.Height = 25;
            this.grv_TransactionLine.Size = new System.Drawing.Size(1225, 180);
            this.grv_TransactionLine.TabIndex = 32;
            this.grv_TransactionLine.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.grv_TransactionLine_DataError);
            // 
            // bsTransLine
            // 
            this.bsTransLine.CurrentItemChanged += new System.EventHandler(this.bsTransLine_CurrentItemChanged);
            // 
            // col_trl_ID
            // 
            this.col_trl_ID.DataPropertyName = "ID";
            this.col_trl_ID.HeaderText = "TransactionLine ID";
            this.col_trl_ID.Name = "col_trl_ID";
            this.col_trl_ID.Visible = false;
            // 
            // col_ItemID
            // 
            this.col_ItemID.DataPropertyName = "ItemID";
            this.col_ItemID.HeaderText = "Item ID";
            this.col_ItemID.Name = "col_ItemID";
            this.col_ItemID.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.col_ItemID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // col_ItemPrice
            // 
            this.col_ItemPrice.DataPropertyName = "ItemPrice";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.Format = "C2";
            this.col_ItemPrice.DefaultCellStyle = dataGridViewCellStyle7;
            this.col_ItemPrice.HeaderText = "Item Price";
            this.col_ItemPrice.Name = "col_ItemPrice";
            this.col_ItemPrice.ReadOnly = true;
            this.col_ItemPrice.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // col_Quantity
            // 
            this.col_Quantity.DataPropertyName = "Quantity";
            dataGridViewCellStyle8.Format = "N0";
            dataGridViewCellStyle8.NullValue = "0";
            this.col_Quantity.DefaultCellStyle = dataGridViewCellStyle8;
            this.col_Quantity.HeaderText = "Quantity";
            this.col_Quantity.Name = "col_Quantity";
            // 
            // col_NetValue
            // 
            this.col_NetValue.DataPropertyName = "NetValue";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.Format = "C2";
            dataGridViewCellStyle9.NullValue = "0";
            this.col_NetValue.DefaultCellStyle = dataGridViewCellStyle9;
            this.col_NetValue.HeaderText = "Net Value";
            this.col_NetValue.Name = "col_NetValue";
            this.col_NetValue.ReadOnly = true;
            // 
            // col_DiscountPercent
            // 
            this.col_DiscountPercent.DataPropertyName = "DiscountPercentage";
            dataGridViewCellStyle10.Format = "N1";
            dataGridViewCellStyle10.NullValue = "0";
            this.col_DiscountPercent.DefaultCellStyle = dataGridViewCellStyle10;
            this.col_DiscountPercent.HeaderText = "Discount Percentage";
            this.col_DiscountPercent.Name = "col_DiscountPercent";
            this.col_DiscountPercent.ReadOnly = true;
            // 
            // col_DiscountValue
            // 
            this.col_DiscountValue.DataPropertyName = "DiscountValue";
            dataGridViewCellStyle11.Format = "C2";
            dataGridViewCellStyle11.NullValue = null;
            this.col_DiscountValue.DefaultCellStyle = dataGridViewCellStyle11;
            this.col_DiscountValue.HeaderText = "Discount Value";
            this.col_DiscountValue.Name = "col_DiscountValue";
            this.col_DiscountValue.ReadOnly = true;
            // 
            // col_TotalValue
            // 
            this.col_TotalValue.DataPropertyName = "TotalValue";
            dataGridViewCellStyle12.Format = "C2";
            dataGridViewCellStyle12.NullValue = null;
            this.col_TotalValue.DefaultCellStyle = dataGridViewCellStyle12;
            this.col_TotalValue.HeaderText = "Total Value";
            this.col_TotalValue.Name = "col_TotalValue";
            // 
            // col_transID
            // 
            this.col_transID.DataPropertyName = "TransactionID";
            this.col_transID.HeaderText = "TransactionID";
            this.col_transID.Name = "col_transID";
            this.col_transID.Visible = false;
            // 
            // frm_TransactionLines
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1353, 636);
            this.Controls.Add(this.btn_EndEdit);
            this.Controls.Add(this.btn_Back);
            this.Controls.Add(this.btn_trl_Add);
            this.Controls.Add(this.btn_trl_delete);
            this.Controls.Add(this.btn_trl_save);
            this.Controls.Add(this.grv_TransactionLine);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "frm_TransactionLines";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TransactionLines";
            this.Load += new System.EventHandler(this.TransactionLines_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grv_TransactionLine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsTransLine)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Button btn_EndEdit;
        private Button btn_Back;
        private Button btn_trl_Add;
        private Button btn_trl_delete;
        private Button btn_trl_load;
        private Button btn_trl_save;
        private DataGridView grv_TransactionLine;
        private BindingSource bsTransLine;
        private DataGridViewTextBoxColumn col_trl_ID;
        private DataGridViewComboBoxColumn col_ItemID;
        private DataGridViewTextBoxColumn col_ItemPrice;
        private DataGridViewTextBoxColumn col_Quantity;
        private DataGridViewTextBoxColumn col_NetValue;
        private DataGridViewTextBoxColumn col_DiscountPercent;
        private DataGridViewTextBoxColumn col_DiscountValue;
        private DataGridViewTextBoxColumn col_TotalValue;
        private DataGridViewTextBoxColumn col_transID;
    }
}