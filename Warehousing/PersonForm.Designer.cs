using System.Drawing;
using System.Windows.Forms;

namespace Warehousing
{
    partial class PersonForm
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



            this.personDataGridView = new System.Windows.Forms.DataGridView();
            this.grpPerson = new System.Windows.Forms.GroupBox();
            this.btnCustomerRegister = new System.Windows.Forms.Button();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblStreet = new System.Windows.Forms.Label();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.lblNumber = new System.Windows.Forms.Label();
            this.txtStreet = new System.Windows.Forms.TextBox();
            this.lblProvince = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.cmbUserRole = new System.Windows.Forms.ComboBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblRole = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.lblCompanyName = new System.Windows.Forms.Label();
            this.txtCompanyName = new System.Windows.Forms.TextBox();
            this.lblNationalCode = new System.Windows.Forms.Label();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.txtNationalCode = new System.Windows.Forms.TextBox();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.txtProvince = new System.Windows.Forms.TextBox();
            this.grpPerson.SuspendLayout();
            this.SuspendLayout();

            this.personDataGridView.Location = new Point(12, 320);
            this.personDataGridView.Size = new Size(1000, 200);
            this.Controls.Add(personDataGridView);
            this.personDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.personDataGridView.AutoGenerateColumns = true;
            this.personDataGridView.ColumnHeadersHeight = 40;
            // 
            // grpPerson
            // 
            this.grpPerson.AutoSize = true;
            this.grpPerson.Controls.Add(this.btnCustomerRegister);
            this.grpPerson.Controls.Add(this.cmbUserRole);
            this.grpPerson.Controls.Add(this.txtFirstName);
            this.grpPerson.Controls.Add(this.lblFirstName);
            this.grpPerson.Controls.Add(this.lblStreet);
            this.grpPerson.Controls.Add(this.txtPhoneNumber);
            this.grpPerson.Controls.Add(this.lblPhoneNumber);
            this.grpPerson.Controls.Add(this.txtStreet);
            this.grpPerson.Controls.Add(this.lblProvince);
            this.grpPerson.Controls.Add(this.lblRole);
            this.grpPerson.Controls.Add(this.lblAddress);
            this.grpPerson.Controls.Add(this.lblLastName);
            this.grpPerson.Controls.Add(this.txtLastName);
            this.grpPerson.Controls.Add(this.txtCompanyName);
            this.grpPerson.Controls.Add(this.txtProvince);
            this.grpPerson.Controls.Add(this.txtNationalCode);
            this.grpPerson.Controls.Add(this.lblNationalCode);
            this.grpPerson.Controls.Add(this.lblCompanyName);
            this.grpPerson.Controls.Add(this.lblNumber);
            this.grpPerson.Controls.Add(this.txtNumber);
            this.grpPerson.Controls.Add(this.lblCity);
            this.grpPerson.Controls.Add(this.txtCity);
            this.grpPerson.Location = new System.Drawing.Point(14, 14);
            this.grpPerson.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpPerson.Name = "grpPerson";
            this.grpPerson.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpPerson.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.grpPerson.Size = new System.Drawing.Size(1029, 293);
            this.grpPerson.TabIndex = 0;
            this.grpPerson.TabStop = false;
            this.grpPerson.Text = "مشخصات شخص";
            // 
            // btnCustomerRegister
            // 
            this.btnCustomerRegister.Location = new System.Drawing.Point(693, 222);
            this.btnCustomerRegister.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCustomerRegister.Name = "btnCustomerRegister";
            this.btnCustomerRegister.Size = new System.Drawing.Size(288, 44);
            this.btnCustomerRegister.TabIndex = 9;
            this.btnCustomerRegister.Text = "ثبت مشتری";
            this.btnCustomerRegister.UseVisualStyleBackColor = true;
            this.btnCustomerRegister.Click += new System.EventHandler(this.btnCustomerRegister_Click);
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(20, 145);
            this.txtCity.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(190, 26);
            this.txtCity.TabIndex = 6;
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(231, 148);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(47, 18);
            this.lblCity.TabIndex = 12;
            this.lblCity.Text = "شهر :";
            // 
            // lblStreet
            // 
            this.lblStreet.AutoSize = true;
            this.lblStreet.Location = new System.Drawing.Point(538, 205);
            this.lblStreet.Name = "lblStreet";
            this.lblStreet.Size = new System.Drawing.Size(55, 18);
            this.lblStreet.TabIndex = 14;
            this.lblStreet.Text = "خیابان :";
            // 
            // txtNumber
            // 
            this.txtNumber.Location = new System.Drawing.Point(20, 202);
            this.txtNumber.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(190, 26);
            this.txtNumber.TabIndex = 8;
            // 
            // lblNumber
            // 
            this.lblNumber.AutoSize = true;
            this.lblNumber.Location = new System.Drawing.Point(231, 206);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(47, 18);
            this.lblNumber.TabIndex = 17;
            this.lblNumber.Text = "پلاک :";
            // 
            // txtStreet
            // 
            this.txtStreet.Location = new System.Drawing.Point(320, 201);
            this.txtStreet.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtStreet.Name = "txtStreet";
            this.txtStreet.Size = new System.Drawing.Size(195, 26);
            this.txtStreet.TabIndex = 7;
            // 
            // lblProvince
            // 
            this.lblProvince.AutoSize = true;
            this.lblProvince.Location = new System.Drawing.Point(538, 149);
            this.lblProvince.Name = "lblProvince";
            this.lblProvince.Size = new System.Drawing.Size(56, 18);
            this.lblProvince.TabIndex = 10;
            this.lblProvince.Text = "استان :";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(610, 147);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(52, 18);
            this.lblAddress.TabIndex = 4;
            this.lblAddress.Text = "آدرس :";
            // 
            // cmbUserRole
            // 
            this.cmbUserRole.FormattingEnabled = true;
            this.cmbUserRole.Location = new System.Drawing.Point(693, 41);
            this.cmbUserRole.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbUserRole.Name = "cmbUserRole";
            this.cmbUserRole.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmbUserRole.Size = new System.Drawing.Size(195, 26);
            this.cmbUserRole.TabIndex = 18;
            this.cmbUserRole.SelectedIndexChanged += new System.EventHandler(this.cmbUserRole_SelectedIndexChanged);
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(693, 89);
            this.txtFirstName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(195, 26);
            this.txtFirstName.TabIndex = 1;
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(910, 93);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(48, 18);
            this.lblFirstName.TabIndex = 0;
            this.lblFirstName.Text = "* نام :";
            // 
            // lblRole
            // 
            this.lblRole.AutoSize = true;
            this.lblRole.Location = new System.Drawing.Point(910, 41);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(53, 18);
            this.lblRole.TabIndex = 19;
            this.lblRole.Text = "عنوان :";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(538, 90);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(111, 18);
            this.lblLastName.TabIndex = 1;
            this.lblLastName.Text = "* نام خانوادگی :";
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(320, 86);
            this.txtLastName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(195, 26);
            this.txtLastName.TabIndex = 2;
            // 
            // lblCompanyName
            // 
            this.lblCompanyName.AutoSize = true;
            this.lblCompanyName.Location = new System.Drawing.Point(538, 42);
            this.lblCompanyName.Name = "lblCompanyName";
            this.lblCompanyName.Size = new System.Drawing.Size(82, 18);
            this.lblCompanyName.TabIndex = 20;
            this.lblCompanyName.Text = "نام شرکت :";
            // 
            // txtCompanyName
            // 
            this.txtCompanyName.Enabled = false;
            this.txtCompanyName.Location = new System.Drawing.Point(320, 38);
            this.txtCompanyName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCompanyName.Name = "txtCompanyName";
            this.txtCompanyName.Size = new System.Drawing.Size(195, 26);
            this.txtCompanyName.TabIndex = 21;
            // 
            // lblNationalCode
            // 
            this.lblNationalCode.AutoSize = true;
            this.lblNationalCode.Location = new System.Drawing.Point(231, 91);
            this.lblNationalCode.Name = "lblNationalCode";
            this.lblNationalCode.Size = new System.Drawing.Size(79, 18);
            this.lblNationalCode.TabIndex = 2;
            this.lblNationalCode.Text = "* کد ملی :";
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Location = new System.Drawing.Point(693, 148);
            this.txtPhoneNumber.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(195, 26);
            this.txtPhoneNumber.TabIndex = 4;
            // 
            // txtNationalCode
            // 
            this.txtNationalCode.Location = new System.Drawing.Point(20, 87);
            this.txtNationalCode.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNationalCode.Name = "txtNationalCode";
            this.txtNationalCode.Size = new System.Drawing.Size(190, 26);
            this.txtNationalCode.TabIndex = 3;
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.AutoSize = true;
            this.lblPhoneNumber.Location = new System.Drawing.Point(910, 152);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(101, 18);
            this.lblPhoneNumber.TabIndex = 3;
            this.lblPhoneNumber.Text = "شماره موبایل :";
            // 
            // txtProvince
            // 
            this.txtProvince.AutoCompleteCustomSource.AddRange(new string[] {
            "تهران",
            "آذربایجان شرقی",
            "آذربایجان غربی",
            "البرز",
            "زنجان",
            "قزوین",
            "کرمان",
            "فارس",
            "همدان",
            "اردبیل",
            "گیلان",
            "مازندران",
            "گلستان",
            "خراسان رضوی"});
            this.txtProvince.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtProvince.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtProvince.Location = new System.Drawing.Point(320, 144);
            this.txtProvince.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtProvince.Name = "txtProvince";
            this.txtProvince.Size = new System.Drawing.Size(195, 26);
            this.txtProvince.TabIndex = 5;
            // 
            // PersonForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 532);
            this.Controls.Add(this.grpPerson);
            this.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "PersonForm";
            this.Text = "فرم تعریف شخص";
            this.Load += new System.EventHandler(this.PersonForm_Load);
            this.grpPerson.ResumeLayout(false);
            this.grpPerson.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpPerson;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblNationalCode;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblNumber;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label lblPhoneNumber;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.TextBox txtStreet;
        private System.Windows.Forms.Label lblStreet;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.TextBox txtProvince;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label lblProvince;
        private System.Windows.Forms.Button btnCustomerRegister;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.TextBox txtNationalCode;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.ComboBox cmbUserRole;
        private System.Windows.Forms.TextBox txtCompanyName;
        private System.Windows.Forms.Label lblCompanyName;
        private System.Windows.Forms.DataGridView personDataGridView;
    }
}