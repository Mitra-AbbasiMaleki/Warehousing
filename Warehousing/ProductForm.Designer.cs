using BaseBackend.Entities;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Warehousing
{
    partial class ProductForm
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
            this.grpNewPruduct = new System.Windows.Forms.GroupBox();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.chkOtherWarehouse = new System.Windows.Forms.CheckBox();
            this.chkCentralWarehouse = new System.Windows.Forms.CheckBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.cmbProductGroup = new System.Windows.Forms.ComboBox();
            this.lblProductGroup = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.mtxExpiryDate = new System.Windows.Forms.MaskedTextBox();
            this.lblExpiryDate = new System.Windows.Forms.Label();
            this.btnProductRegistration = new System.Windows.Forms.Button();
            this.txtSupplier = new System.Windows.Forms.TextBox();
            this.lblSupplier = new System.Windows.Forms.Label();
            this.lblWarehous = new System.Windows.Forms.Label();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.lblRial = new System.Windows.Forms.Label();
            this.lblProductName = new System.Windows.Forms.Label();
            this.cmbUnit = new System.Windows.Forms.ComboBox();
            this.lblUnit = new System.Windows.Forms.Label();
            this.mtxFirstQuantity = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.productDataGridView = new System.Windows.Forms.DataGridView();
            this.grpNewPruduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // grpNewPruduct
            // 
            this.grpNewPruduct.AutoSize = true;
            this.grpNewPruduct.Controls.Add(this.txtProductName);
            this.grpNewPruduct.Controls.Add(this.chkOtherWarehouse);
            this.grpNewPruduct.Controls.Add(this.chkCentralWarehouse);
            this.grpNewPruduct.Controls.Add(this.txtDescription);
            this.grpNewPruduct.Controls.Add(this.lblDescription);
            this.grpNewPruduct.Controls.Add(this.cmbProductGroup);
            this.grpNewPruduct.Controls.Add(this.lblProductGroup);
            this.grpNewPruduct.Controls.Add(this.txtPrice);
            this.grpNewPruduct.Controls.Add(this.lblPrice);
            this.grpNewPruduct.Controls.Add(this.mtxExpiryDate);
            this.grpNewPruduct.Controls.Add(this.lblExpiryDate);
            this.grpNewPruduct.Controls.Add(this.btnProductRegistration);
            this.grpNewPruduct.Controls.Add(this.txtSupplier);
            this.grpNewPruduct.Controls.Add(this.lblSupplier);
            this.grpNewPruduct.Controls.Add(this.lblWarehous);
            this.grpNewPruduct.Controls.Add(this.lblQuantity);
            this.grpNewPruduct.Controls.Add(this.lblRial);
            this.grpNewPruduct.Controls.Add(this.lblProductName);
            this.grpNewPruduct.Controls.Add(this.cmbUnit);
            this.grpNewPruduct.Controls.Add(this.lblUnit);
            this.grpNewPruduct.Controls.Add(this.mtxFirstQuantity);
            this.grpNewPruduct.Controls.Add(this.label1);
            this.grpNewPruduct.Location = new System.Drawing.Point(10, 10);
            this.grpNewPruduct.Name = "grpNewPruduct";
            this.grpNewPruduct.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.grpNewPruduct.Size = new System.Drawing.Size(984, 379);
            this.grpNewPruduct.TabIndex = 0;
            this.grpNewPruduct.TabStop = false;
            this.grpNewPruduct.Text = "مشخصات کالا";
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(590, 87);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(285, 26);
            this.txtProductName.TabIndex = 1;
            // 
            // chkOtherWarehouse
            // 
            this.chkOtherWarehouse.AutoSize = true;
            this.chkOtherWarehouse.Location = new System.Drawing.Point(590, 201);
            this.chkOtherWarehouse.Name = "chkOtherWarehouse";
            this.chkOtherWarehouse.Size = new System.Drawing.Size(79, 22);
            this.chkOtherWarehouse.TabIndex = 7;
            this.chkOtherWarehouse.Text = "انبار دیگر";
            this.chkOtherWarehouse.UseVisualStyleBackColor = true;
            // 
            // chkCentralWarehouse
            // 
            this.chkCentralWarehouse.AutoSize = true;
            this.chkCentralWarehouse.Location = new System.Drawing.Point(730, 201);
            this.chkCentralWarehouse.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.chkCentralWarehouse.Name = "chkCentralWarehouse";
            this.chkCentralWarehouse.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chkCentralWarehouse.Size = new System.Drawing.Size(94, 22);
            this.chkCentralWarehouse.TabIndex = 6;
            this.chkCentralWarehouse.Text = "انبار مرکزی";
            this.chkCentralWarehouse.UseVisualStyleBackColor = true;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(118, 255);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(285, 26);
            this.txtDescription.TabIndex = 10;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(423, 258);
            this.lblDescription.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(72, 18);
            this.lblDescription.TabIndex = 0;
            this.lblDescription.Text = "توضیحات :";
            // 
            // cmbProductGroup
            // 
            this.cmbProductGroup.DisplayMember = "CategoryName";
            this.cmbProductGroup.FormattingEnabled = true;
            this.cmbProductGroup.Location = new System.Drawing.Point(118, 87);
            this.cmbProductGroup.Name = "cmbProductGroup";
            this.cmbProductGroup.Size = new System.Drawing.Size(285, 26);
            this.cmbProductGroup.TabIndex = 2;
            this.cmbProductGroup.ValueMember = "Id";
            // 
            // lblProductGroup
            // 
            this.lblProductGroup.AutoSize = true;
            this.lblProductGroup.Location = new System.Drawing.Point(423, 90);
            this.lblProductGroup.Name = "lblProductGroup";
            this.lblProductGroup.Size = new System.Drawing.Size(82, 18);
            this.lblProductGroup.TabIndex = 0;
            this.lblProductGroup.Text = "* گروه کالا :";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(223, 141);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(180, 26);
            this.txtPrice.TabIndex = 5;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(422, 146);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(98, 18);
            this.lblPrice.TabIndex = 0;
            this.lblPrice.Text = "* قیمت خرید :";
            // 
            // mtxExpiryDate
            // 
            this.mtxExpiryDate.Location = new System.Drawing.Point(245, 199);
            this.mtxExpiryDate.Mask = "00/00/0000";
            this.mtxExpiryDate.Name = "mtxExpiryDate";
            this.mtxExpiryDate.Size = new System.Drawing.Size(158, 26);
            this.mtxExpiryDate.TabIndex = 8;
            // 
            // lblExpiryDate
            // 
            this.lblExpiryDate.AutoSize = true;
            this.lblExpiryDate.Location = new System.Drawing.Point(423, 202);
            this.lblExpiryDate.Name = "lblExpiryDate";
            this.lblExpiryDate.Size = new System.Drawing.Size(84, 18);
            this.lblExpiryDate.TabIndex = 0;
            this.lblExpiryDate.Text = "تاریخ انقضا :";
            // 
            // btnProductRegistration
            // 
            this.btnProductRegistration.Location = new System.Drawing.Point(36, 305);
            this.btnProductRegistration.Margin = new System.Windows.Forms.Padding(4);
            this.btnProductRegistration.Name = "btnProductRegistration";
            this.btnProductRegistration.Size = new System.Drawing.Size(380, 48);
            this.btnProductRegistration.TabIndex = 11;
            this.btnProductRegistration.Text = "ثبت کالا";
            this.btnProductRegistration.UseVisualStyleBackColor = true;
            this.btnProductRegistration.Click += new System.EventHandler(this.btnProductRegistration_Click);
            // 
            // txtSupplier
            // 
            this.txtSupplier.Location = new System.Drawing.Point(664, 255);
            this.txtSupplier.Name = "txtSupplier";
            this.txtSupplier.Size = new System.Drawing.Size(211, 26);
            this.txtSupplier.TabIndex = 9;
            // 
            // lblSupplier
            // 
            this.lblSupplier.AutoSize = true;
            this.lblSupplier.Location = new System.Drawing.Point(881, 258);
            this.lblSupplier.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSupplier.Name = "lblSupplier";
            this.lblSupplier.Size = new System.Drawing.Size(92, 18);
            this.lblSupplier.TabIndex = 0;
            this.lblSupplier.Text = " تامین کننده :";
            // 
            // lblWarehous
            // 
            this.lblWarehous.AutoSize = true;
            this.lblWarehous.Location = new System.Drawing.Point(881, 204);
            this.lblWarehous.Name = "lblWarehous";
            this.lblWarehous.Size = new System.Drawing.Size(40, 18);
            this.lblWarehous.TabIndex = 0;
            this.lblWarehous.Text = "انبار :";
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Location = new System.Drawing.Point(881, 146);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(97, 18);
            this.lblQuantity.TabIndex = 0;
            this.lblQuantity.Text = "* مقدار اولیه :";
            // 
            // lblRial
            // 
            this.lblRial.AutoSize = true;
            this.lblRial.Location = new System.Drawing.Point(169, 144);
            this.lblRial.Name = "lblRial";
            this.lblRial.Size = new System.Drawing.Size(31, 18);
            this.lblRial.TabIndex = 0;
            this.lblRial.Text = "ریال";
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Location = new System.Drawing.Point(881, 90);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(73, 18);
            this.lblProductName.TabIndex = 0;
            this.lblProductName.Text = "* نام کالا :";
            // 
            // cmbUnit
            // 
            this.cmbUnit.DisplayMember = "Name";
            this.cmbUnit.FormattingEnabled = true;
            this.cmbUnit.Location = new System.Drawing.Point(590, 141);
            this.cmbUnit.Name = "cmbUnit";
            this.cmbUnit.Size = new System.Drawing.Size(102, 26);
            this.cmbUnit.TabIndex = 4;
            this.cmbUnit.ValueMember = "Id";
            // 
            // lblUnit
            // 
            this.lblUnit.AutoSize = true;
            this.lblUnit.Location = new System.Drawing.Point(698, 146);
            this.lblUnit.Name = "lblUnit";
            this.lblUnit.Size = new System.Drawing.Size(46, 18);
            this.lblUnit.TabIndex = 0;
            this.lblUnit.Text = "واحد :";
            // 
            // mtxFirstQuantity
            // 
            this.mtxFirstQuantity.Location = new System.Drawing.Point(768, 141);
            this.mtxFirstQuantity.Mask = "00000";
            this.mtxFirstQuantity.Name = "mtxFirstQuantity";
            this.mtxFirstQuantity.Size = new System.Drawing.Size(107, 26);
            this.mtxFirstQuantity.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(704, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(254, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "قسمت های ستاره دار حتما باید پر شود";
            // 
            // productDataGridView
            // 
            this.productDataGridView.Location = new System.Drawing.Point(5, 395);
            this.productDataGridView.Name = "productDataGridView";
            this.productDataGridView.Size = new System.Drawing.Size(990, 200);
            this.productDataGridView.TabIndex = 0;
            // 
            // ProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1007, 617);
            this.Controls.Add(this.grpNewPruduct);
            this.Controls.Add(this.productDataGridView);
            this.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "ProductForm";
            this.Text = "فرم تعریف کالای جدید";
            this.Load += new System.EventHandler(this.ProductForm_Load);
            this.grpNewPruduct.ResumeLayout(false);
            this.grpNewPruduct.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpNewPruduct;
        private System.Windows.Forms.Label lblProductGroup;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.ComboBox cmbProductGroup;
        private System.Windows.Forms.Label lblUnit;
        private System.Windows.Forms.ComboBox cmbUnit;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Label lblRial;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.MaskedTextBox mtxExpiryDate;
        private System.Windows.Forms.Label lblExpiryDate;
        private System.Windows.Forms.TextBox txtSupplier;
        private System.Windows.Forms.Label lblSupplier;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Button btnProductRegistration;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblWarehous;
        private System.Windows.Forms.CheckBox chkCentralWarehouse;
        private System.Windows.Forms.MaskedTextBox mtxFirstQuantity;
        private System.Windows.Forms.DataGridView productDataGridView;
        private System.Windows.Forms.CheckBox chkOtherWarehouse;
    }
}