using BaseBackend.Entities;
using System.Windows.Forms;

namespace Warehousing
{
    partial class OrderForm
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
            this.orderDataGridView = new System.Windows.Forms.DataGridView();
            this.grpOrder = new System.Windows.Forms.GroupBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblUnit = new System.Windows.Forms.Label();
            this.cmbUnit = new System.Windows.Forms.ComboBox();
            this.nudQuantity = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbAddress = new System.Windows.Forms.ComboBox();
            this.lblCustomer = new System.Windows.Forms.Label();
            this.cmbCustomer = new System.Windows.Forms.ComboBox();
            this.cmbProductName = new System.Windows.Forms.ComboBox();
            this.lblProductName = new System.Windows.Forms.Label();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.lblProductCategory = new System.Windows.Forms.Label();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnOrderRegistration = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.grpAction = new System.Windows.Forms.GroupBox();
            this.lblRial = new System.Windows.Forms.Label();
            this.txtTotalPrice = new System.Windows.Forms.TextBox();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblOrderDate = new System.Windows.Forms.Label();
            this.grpOperation = new System.Windows.Forms.GroupBox();
            this.btnSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.orderDataGridView)).BeginInit();
            this.grpOrder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).BeginInit();
            this.grpAction.SuspendLayout();
            this.grpOperation.SuspendLayout();
            this.SuspendLayout();
            // 
            // orderDataGridView
            // 
            this.orderDataGridView.AllowUserToAddRows = false;
            this.orderDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.orderDataGridView.ColumnHeadersHeight = 40;
            this.orderDataGridView.Location = new System.Drawing.Point(14, 372);
            this.orderDataGridView.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.orderDataGridView.Name = "orderDataGridView";
            this.orderDataGridView.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.orderDataGridView.Size = new System.Drawing.Size(969, 264);
            this.orderDataGridView.TabIndex = 0;
            this.orderDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.orderDataGridView_CellClick);
            this.orderDataGridView.Columns.Add("Id", "ردیف");
            this.orderDataGridView.Columns["Id"].ReadOnly = true;

            this.orderDataGridView.Columns.Add("ProductId", "کد محصول");
            this.orderDataGridView.Columns["ProductId"].ReadOnly = true;

            this.orderDataGridView.Columns.Add("ProductName", "نام محصول");
            this.orderDataGridView.Columns["ProductName"].ReadOnly = true;

            this.orderDataGridView.Columns.Add("Quantity", "تعداد سفارش");
            this.orderDataGridView.Columns["Quantity"].ReadOnly = true;

            this.orderDataGridView.Columns.Add("Unit", "واحد محصول");
            this.orderDataGridView.Columns["Unit"].ReadOnly = true;

            this.orderDataGridView.Columns.Add("Price", "قیمت محصول");
            this.orderDataGridView.Columns["Price"].ReadOnly = true;
            this.orderDataGridView.Columns["Price"].DefaultCellStyle.Format = "N0";

            this.orderDataGridView.Columns.Add("TotalProductPrice", "قیمت کل محصول");
            this.orderDataGridView.Columns["TotalProductPrice"].ReadOnly = true;
            this.orderDataGridView.Columns["TotalProductPrice"].DefaultCellStyle.Format = "N0";
            // 
            // grpOrder
            // 
            this.grpOrder.Controls.Add(this.lblAddress);
            this.grpOrder.Controls.Add(this.lblUnit);
            this.grpOrder.Controls.Add(this.cmbUnit);
            this.grpOrder.Controls.Add(this.nudQuantity);
            this.grpOrder.Controls.Add(this.label1);
            this.grpOrder.Controls.Add(this.cmbAddress);
            this.grpOrder.Controls.Add(this.lblCustomer);
            this.grpOrder.Controls.Add(this.cmbCustomer);
            this.grpOrder.Controls.Add(this.cmbProductName);
            this.grpOrder.Controls.Add(this.lblProductName);
            this.grpOrder.Controls.Add(this.lblQuantity);
            this.grpOrder.Controls.Add(this.cmbCategory);
            this.grpOrder.Controls.Add(this.lblProductCategory);
            this.grpOrder.Location = new System.Drawing.Point(14, 14);
            this.grpOrder.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpOrder.Name = "grpOrder";
            this.grpOrder.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpOrder.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.grpOrder.Size = new System.Drawing.Size(971, 240);
            this.grpOrder.TabIndex = 0;
            this.grpOrder.TabStop = false;
            this.grpOrder.Text = "سفارش جدید";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(430, 45);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(105, 18);
            this.lblAddress.TabIndex = 0;
            this.lblAddress.Text = "آدرس مشتری :";
            // 
            // lblUnit
            // 
            this.lblUnit.AutoSize = true;
            this.lblUnit.Location = new System.Drawing.Point(430, 190);
            this.lblUnit.Name = "lblUnit";
            this.lblUnit.Size = new System.Drawing.Size(112, 18);
            this.lblUnit.TabIndex = 0;
            this.lblUnit.Text = "* واحد محصول :";
            // 
            // cmbUnit
            // 
            this.cmbUnit.DisplayMember = "Name";
            this.cmbUnit.FormattingEnabled = true;
            this.cmbUnit.Location = new System.Drawing.Point(186, 187);
            this.cmbUnit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbUnit.Name = "cmbUnit";
            this.cmbUnit.Size = new System.Drawing.Size(211, 26);
            this.cmbUnit.TabIndex = 6;
            this.cmbUnit.ValueMember = "Id";
            // 
            // nudQuantity
            // 
            this.nudQuantity.Location = new System.Drawing.Point(619, 188);
            this.nudQuantity.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nudQuantity.Name = "nudQuantity";
            this.nudQuantity.Size = new System.Drawing.Size(211, 26);
            this.nudQuantity.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(34, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(898, 2);
            this.label1.TabIndex = 16;
            // 
            // cmbAddress
            // 
            this.cmbAddress.FormattingEnabled = true;
            this.cmbAddress.Location = new System.Drawing.Point(34, 37);
            this.cmbAddress.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbAddress.Name = "cmbAddress";
            this.cmbAddress.Size = new System.Drawing.Size(363, 26);
            this.cmbAddress.TabIndex = 2;
            // 
            // lblCustomer
            // 
            this.lblCustomer.AutoSize = true;
            this.lblCustomer.Location = new System.Drawing.Point(870, 41);
            this.lblCustomer.Name = "lblCustomer";
            this.lblCustomer.Size = new System.Drawing.Size(79, 18);
            this.lblCustomer.TabIndex = 0;
            this.lblCustomer.Text = "* مشتری :";
            // 
            // cmbCustomer
            // 
            this.cmbCustomer.DisplayMember = "FullName";
            this.cmbCustomer.FormattingEnabled = true;
            this.cmbCustomer.Location = new System.Drawing.Point(619, 37);
            this.cmbCustomer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbCustomer.Name = "cmbCustomer";
            this.cmbCustomer.Size = new System.Drawing.Size(211, 26);
            this.cmbCustomer.TabIndex = 1;
            this.cmbCustomer.ValueMember = "Id";
            // 
            // cmbProductName
            // 
            this.cmbProductName.DisplayMember = "ProductName";
            this.cmbProductName.FormattingEnabled = true;
            this.cmbProductName.Location = new System.Drawing.Point(186, 120);
            this.cmbProductName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbProductName.Name = "cmbProductName";
            this.cmbProductName.Size = new System.Drawing.Size(211, 26);
            this.cmbProductName.TabIndex = 4;
            this.cmbProductName.ValueMember = "Id";
            this.cmbProductName.SelectedIndexChanged += new System.EventHandler(this.cmbProductName_SelectedIndexChanged);
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Location = new System.Drawing.Point(424, 124);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(123, 18);
            this.lblProductName.TabIndex = 0;
            this.lblProductName.Text = "* انتخاب محصول :";
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Location = new System.Drawing.Point(857, 190);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(114, 18);
            this.lblQuantity.TabIndex = 0;
            this.lblQuantity.Text = "* تعداد محصول :";
            // 
            // cmbCategory
            // 
            this.cmbCategory.DisplayMember = "CategoryName";
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Location = new System.Drawing.Point(619, 120);
            this.cmbCategory.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(211, 26);
            this.cmbCategory.TabIndex = 3;
            this.cmbCategory.ValueMember = "Id";
            this.cmbCategory.SelectedIndexChanged += new System.EventHandler(this.cmbCategory_SelectedIndexChanged);
            // 
            // lblProductCategory
            // 
            this.lblProductCategory.AutoSize = true;
            this.lblProductCategory.Location = new System.Drawing.Point(857, 124);
            this.lblProductCategory.Name = "lblProductCategory";
            this.lblProductCategory.Size = new System.Drawing.Size(110, 18);
            this.lblProductCategory.TabIndex = 0;
            this.lblProductCategory.Text = "* گروه محصول :";
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(633, 40);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(106, 32);
            this.btnEdit.TabIndex = 9;
            this.btnEdit.Text = "ویرایش";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(745, 40);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(106, 32);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "حذف";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(857, 40);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(106, 32);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "اضافه";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnOrderRegistration
            // 
            this.btnOrderRegistration.Location = new System.Drawing.Point(6, 27);
            this.btnOrderRegistration.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnOrderRegistration.Name = "btnOrderRegistration";
            this.btnOrderRegistration.Size = new System.Drawing.Size(217, 55);
            this.btnOrderRegistration.TabIndex = 10;
            this.btnOrderRegistration.Text = "ثبت سفارش";
            this.btnOrderRegistration.UseVisualStyleBackColor = true;
            this.btnOrderRegistration.Click += new System.EventHandler(this.btnOrderRegistration_Click);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(342, 54);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(185, 23);
            this.comboBox2.TabIndex = 0;
            // 
            // grpAction
            // 
            this.grpAction.Controls.Add(this.lblRial);
            this.grpAction.Controls.Add(this.txtTotalPrice);
            this.grpAction.Controls.Add(this.lblTotalPrice);
            this.grpAction.Controls.Add(this.lblDate);
            this.grpAction.Controls.Add(this.lblOrderDate);
            this.grpAction.Location = new System.Drawing.Point(14, 643);
            this.grpAction.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpAction.Name = "grpAction";
            this.grpAction.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpAction.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.grpAction.Size = new System.Drawing.Size(969, 72);
            this.grpAction.TabIndex = 1;
            this.grpAction.TabStop = false;
            // 
            // lblRial
            // 
            this.lblRial.AutoSize = true;
            this.lblRial.Location = new System.Drawing.Point(101, 34);
            this.lblRial.Name = "lblRial";
            this.lblRial.Size = new System.Drawing.Size(31, 18);
            this.lblRial.TabIndex = 0;
            this.lblRial.Text = "ریال";
            // 
            // txtTotalPrice
            // 
            this.txtTotalPrice.Location = new System.Drawing.Point(176, 31);
            this.txtTotalPrice.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTotalPrice.Name = "txtTotalPrice";
            this.txtTotalPrice.ReadOnly = true;
            this.txtTotalPrice.Size = new System.Drawing.Size(190, 26);
            this.txtTotalPrice.TabIndex = 0;
            this.txtTotalPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.AutoSize = true;
            this.lblTotalPrice.Location = new System.Drawing.Point(400, 34);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(135, 18);
            this.lblTotalPrice.TabIndex = 0;
            this.lblTotalPrice.Text = "قیمت کل سفارش : ";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(745, 34);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(13, 18);
            this.lblDate.TabIndex = 0;
            this.lblDate.Text = ".";
            // 
            // lblOrderDate
            // 
            this.lblOrderDate.AutoSize = true;
            this.lblOrderDate.Location = new System.Drawing.Point(857, 34);
            this.lblOrderDate.Name = "lblOrderDate";
            this.lblOrderDate.Size = new System.Drawing.Size(101, 18);
            this.lblOrderDate.TabIndex = 0;
            this.lblOrderDate.Text = "تاریخ سفارش :";
            // 
            // grpOperation
            // 
            this.grpOperation.Controls.Add(this.btnSave);
            this.grpOperation.Controls.Add(this.btnEdit);
            this.grpOperation.Controls.Add(this.btnDelete);
            this.grpOperation.Controls.Add(this.btnOrderRegistration);
            this.grpOperation.Controls.Add(this.btnAdd);
            this.grpOperation.Location = new System.Drawing.Point(14, 262);
            this.grpOperation.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpOperation.Name = "grpOperation";
            this.grpOperation.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpOperation.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.grpOperation.Size = new System.Drawing.Size(971, 102);
            this.grpOperation.TabIndex = 2;
            this.grpOperation.TabStop = false;
            this.grpOperation.Text = "عملیات روی سفارش :";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(521, 40);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(106, 32);
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "اعمال تغییرات";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Visible = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(993, 727);
            this.Controls.Add(this.grpAction);
            this.Controls.Add(this.grpOperation);
            this.Controls.Add(this.orderDataGridView);
            this.Controls.Add(this.grpOrder);
            this.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "OrderForm";
            this.Text = "فرم سفارش جدید";
            this.Load += new System.EventHandler(this.OrderForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.orderDataGridView)).EndInit();
            this.grpOrder.ResumeLayout(false);
            this.grpOrder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).EndInit();
            this.grpAction.ResumeLayout(false);
            this.grpAction.PerformLayout();
            this.grpOperation.ResumeLayout(false);
            this.ResumeLayout(false);

        }


        #endregion

        private System.Windows.Forms.GroupBox grpOrder;
        private System.Windows.Forms.Label lblCustomer;
        private System.Windows.Forms.ComboBox cmbCustomer;
        private System.Windows.Forms.Button btnOrderRegistration;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.ComboBox cmbProductName;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.Label lblProductCategory;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.DataGridView orderDataGridView;
        private System.Windows.Forms.GroupBox grpAction;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.ComboBox cmbUnit;
        private System.Windows.Forms.Label lblUnit;
        private System.Windows.Forms.Label lblOrderDate;
        private System.Windows.Forms.GroupBox grpOperation;
        private System.Windows.Forms.ComboBox cmbAddress;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox txtTotalPrice;
        private System.Windows.Forms.Label lblRial;
        private System.Windows.Forms.Label lblTotalPrice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudQuantity;
        private System.Windows.Forms.Button btnSave;
    }
}