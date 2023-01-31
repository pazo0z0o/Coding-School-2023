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
            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Update = new System.Windows.Forms.Button();
            this.TxtBox1 = new System.Windows.Forms.TextBox();
            this.TxtBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.TxtBox3 = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.TxtBox4 = new System.Windows.Forms.TextBox();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.TxtBox5 = new System.Windows.Forms.TextBox();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.TxtBox6 = new System.Windows.Forms.TextBox();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.grvCustomers = new System.Windows.Forms.DataGridView();
            this.customerIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.surnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tINDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsCustomers = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grvCustomers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsCustomers)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Save
            // 
            this.btn_Save.Location = new System.Drawing.Point(755, 480);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(75, 23);
            this.btn_Save.TabIndex = 0;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.Location = new System.Drawing.Point(755, 567);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(75, 23);
            this.btn_Delete.TabIndex = 1;
            this.btn_Delete.Text = "Delete";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_Update
            // 
            this.btn_Update.Location = new System.Drawing.Point(755, 524);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(75, 23);
            this.btn_Update.TabIndex = 2;
            this.btn_Update.Text = "Update";
            this.btn_Update.UseVisualStyleBackColor = true;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // TxtBox1
            // 
            this.TxtBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtBox1.Location = new System.Drawing.Point(64, 30);
            this.TxtBox1.Multiline = true;
            this.TxtBox1.Name = "TxtBox1";
            this.TxtBox1.Size = new System.Drawing.Size(246, 122);
            this.TxtBox1.TabIndex = 3;
            this.TxtBox1.Visible = false;
            // 
            // TxtBox2
            // 
            this.TxtBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtBox2.Location = new System.Drawing.Point(64, 254);
            this.TxtBox2.Multiline = true;
            this.TxtBox2.Name = "TxtBox2";
            this.TxtBox2.Size = new System.Drawing.Size(246, 122);
            this.TxtBox2.TabIndex = 7;
            this.TxtBox2.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(235, 385);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Update";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(154, 385);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Delete";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Visible = false;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(64, 385);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 4;
            this.button3.Text = "Save";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Visible = false;
            // 
            // TxtBox3
            // 
            this.TxtBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtBox3.Location = new System.Drawing.Point(391, 30);
            this.TxtBox3.Multiline = true;
            this.TxtBox3.Name = "TxtBox3";
            this.TxtBox3.Size = new System.Drawing.Size(246, 122);
            this.TxtBox3.TabIndex = 11;
            this.TxtBox3.Visible = false;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(562, 161);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 10;
            this.button4.Text = "Update";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Visible = false;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(481, 161);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 9;
            this.button5.Text = "Delete";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Visible = false;
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.Location = new System.Drawing.Point(755, 606);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(75, 23);
            this.btn_Refresh.TabIndex = 8;
            this.btn_Refresh.Text = "Refresh";
            this.btn_Refresh.UseVisualStyleBackColor = true;
            this.btn_Refresh.Visible = false;
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // TxtBox4
            // 
            this.TxtBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtBox4.Location = new System.Drawing.Point(391, 254);
            this.TxtBox4.Multiline = true;
            this.TxtBox4.Name = "TxtBox4";
            this.TxtBox4.Size = new System.Drawing.Size(246, 122);
            this.TxtBox4.TabIndex = 15;
            this.TxtBox4.Visible = false;
            this.TxtBox4.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(562, 385);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 23);
            this.button7.TabIndex = 14;
            this.button7.Text = "Update";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Visible = false;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(481, 385);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 23);
            this.button8.TabIndex = 13;
            this.button8.Text = "Delete";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Visible = false;
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(391, 385);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(75, 23);
            this.button9.TabIndex = 12;
            this.button9.Text = "Save";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Visible = false;
            // 
            // TxtBox5
            // 
            this.TxtBox5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtBox5.Location = new System.Drawing.Point(684, 30);
            this.TxtBox5.Multiline = true;
            this.TxtBox5.Name = "TxtBox5";
            this.TxtBox5.Size = new System.Drawing.Size(246, 122);
            this.TxtBox5.TabIndex = 19;
            this.TxtBox5.Visible = false;
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(855, 161);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(75, 23);
            this.button10.TabIndex = 18;
            this.button10.Text = "Update";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Visible = false;
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(774, 161);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(75, 23);
            this.button11.TabIndex = 17;
            this.button11.Text = "Delete";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Visible = false;
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(684, 161);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(75, 23);
            this.button12.TabIndex = 16;
            this.button12.Text = "Save";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Visible = false;
            // 
            // TxtBox6
            // 
            this.TxtBox6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtBox6.Location = new System.Drawing.Point(684, 254);
            this.TxtBox6.Multiline = true;
            this.TxtBox6.Name = "TxtBox6";
            this.TxtBox6.Size = new System.Drawing.Size(246, 122);
            this.TxtBox6.TabIndex = 23;
            this.TxtBox6.Visible = false;
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(855, 385);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(75, 23);
            this.button13.TabIndex = 22;
            this.button13.Text = "Update";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Visible = false;
            // 
            // button14
            // 
            this.button14.Location = new System.Drawing.Point(774, 385);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(75, 23);
            this.button14.TabIndex = 21;
            this.button14.Text = "Delete";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Visible = false;
            // 
            // button15
            // 
            this.button15.Location = new System.Drawing.Point(684, 385);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(75, 23);
            this.button15.TabIndex = 20;
            this.button15.Text = "Save";
            this.button15.UseVisualStyleBackColor = true;
            this.button15.Visible = false;
            // 
            // grvCustomers
            // 
            this.grvCustomers.AutoGenerateColumns = false;
            this.grvCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvCustomers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.customerIDDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.surnameDataGridViewTextBoxColumn,
            this.phoneDataGridViewTextBoxColumn,
            this.tINDataGridViewTextBoxColumn});
            this.grvCustomers.DataSource = this.bsCustomers;
            this.grvCustomers.Location = new System.Drawing.Point(196, 480);
            this.grvCustomers.Name = "grvCustomers";
            this.grvCustomers.RowTemplate.Height = 25;
            this.grvCustomers.Size = new System.Drawing.Size(544, 149);
            this.grvCustomers.TabIndex = 24;
            // 
            // customerIDDataGridViewTextBoxColumn
            // 
            this.customerIDDataGridViewTextBoxColumn.DataPropertyName = "CustomerID";
            this.customerIDDataGridViewTextBoxColumn.HeaderText = "CustomerID";
            this.customerIDDataGridViewTextBoxColumn.Name = "customerIDDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // surnameDataGridViewTextBoxColumn
            // 
            this.surnameDataGridViewTextBoxColumn.DataPropertyName = "Surname";
            this.surnameDataGridViewTextBoxColumn.HeaderText = "Surname";
            this.surnameDataGridViewTextBoxColumn.Name = "surnameDataGridViewTextBoxColumn";
            // 
            // phoneDataGridViewTextBoxColumn
            // 
            this.phoneDataGridViewTextBoxColumn.DataPropertyName = "Phone";
            this.phoneDataGridViewTextBoxColumn.HeaderText = "Phone";
            this.phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
            // 
            // tINDataGridViewTextBoxColumn
            // 
            this.tINDataGridViewTextBoxColumn.DataPropertyName = "TIN";
            this.tINDataGridViewTextBoxColumn.HeaderText = "TIN";
            this.tINDataGridViewTextBoxColumn.Name = "tINDataGridViewTextBoxColumn";
            // 
            // bsCustomers
            // 
            this.bsCustomers.DataSource = typeof(Session_16.EF.Models.Customers);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(196, 462);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 15);
            this.label1.TabIndex = 25;
            this.label1.Text = "Customers";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1171, 629);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grvCustomers);
            this.Controls.Add(this.TxtBox6);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.button15);
            this.Controls.Add(this.TxtBox5);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.TxtBox4);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.TxtBox3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.btn_Refresh);
            this.Controls.Add(this.TxtBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.TxtBox1);
            this.Controls.Add(this.btn_Update);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_Save);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grvCustomers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsCustomers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btn_Save;
        private Button btn_Delete;
        private Button btn_Update;
        private TextBox TxtBox1;
        private TextBox TxtBox2;
        private Button button1;
        private Button button2;
        private Button button3;
        private TextBox TxtBox3;
        private Button button4;
        private Button button5;
        private Button btn_Refresh;
        private TextBox TxtBox4;
        private Button button7;
        private Button button8;
        private Button button9;
        private TextBox TxtBox5;
        private Button button10;
        private Button button11;
        private Button button12;
        private TextBox TxtBox6;
        private Button button13;
        private Button button14;
        private Button button15;
        private DataGridView grvCustomers;
        private DataGridViewTextBoxColumn customerIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn surnameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn tINDataGridViewTextBoxColumn;
        private BindingSource bsCustomers;
        private Label label1;
    }
}