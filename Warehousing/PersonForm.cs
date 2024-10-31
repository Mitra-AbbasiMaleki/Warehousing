#nullable disable
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Warehousing.Utilities;
using BaseBackend.Entities;
using Warehousing.DTOs;
using BaseBackend.Enums;
using System.Drawing;

namespace Warehousing
{
    public partial class PersonForm : Form
    {
        public PersonForm()
        {
            InitializeComponent();
        }
        private void btnCustomerRegister_Click(object sender, EventArgs e)
        {
            //call validation
            if (!ISValidateRegistrationForm())
                return;

            //Add Person
            UserRole RoleSelected = (UserRole)cmbUserRole.SelectedItem;
            Address address = new Address()
            { Province = txtProvince.Text,
                City = txtCity.Text,
                Street = txtStreet.Text,
                Number = txtNumber.Text
            };
            AddPerson addPerson = new AddPerson()
            {
                Role = RoleSelected,
                FirstName = txtFirstName.Text.CleanName(),
                LastName = txtLastName.Text.CleanName(),
                NationalCode = txtNationalCode.Text,
                PhoneNumber = txtPhoneNumber.Text.CleanPhoneNumber(),
                Address = address, 
                CompanyName = txtCompanyName.Text,
            };
            if (cmbUserRole.SelectedIndex == 0)
            {
                MessageBox.Show("لطفاعنوان راانتخاب کنید.");
            }
            else
            {
                AddPerson(addPerson);
                //Message
                MessageBox.Show("مشتری با موفقیت ثبت شد");
                //Reset
                ResetCustomerForm();
            }
        }
        public void AddPerson(AddPerson addPerson)
        {
            //CreatObject
            switch (cmbUserRole.SelectedIndex)
            {
                case 1:
                case 2:
                    SystemUser systemUser = new SystemUser(role:addPerson.Role,firstName: addPerson.FirstName, lastName: addPerson.LastName, nationalCode: addPerson.NationalCode, phoneNumber: addPerson.PhoneNumber, address: addPerson.Address);
                    Storage.Persons.Add(systemUser);
                    RefreshDataGridView(Storage.Persons);
                    break;
                case 3:
                    Customer customer = new Customer(role: addPerson.Role, firstName: addPerson.FirstName, lastName: addPerson.LastName, nationalCode: addPerson.NationalCode, phoneNumber: addPerson.PhoneNumber, address: addPerson.Address);
                    Storage.Customers.Add(customer);
                    Storage.Persons.Add(customer);
                    RefreshDataGridView(Storage.Customers);
                    break;
                case 4:
                    Supplier supplier=new Supplier(role: addPerson.Role, companyName:addPerson.CompanyName, firstName: addPerson.FirstName, lastName: addPerson.LastName, nationalCode: addPerson.NationalCode, phoneNumber: addPerson.PhoneNumber, address: addPerson.Address);
                    Storage.Suppliers.Add(supplier);
                    Storage.Persons.Add(supplier);
                    RefreshDataGridView(Storage.Suppliers);
                    break;
                default:
                    MessageBox.Show("لطفاعنوان راانتخاب کنید.");
                    return;
            } 
        }
        private bool ISValidateRegistrationForm()
        {
            //Validate FirstName
            if (string.IsNullOrEmpty(txtFirstName.Text) || !CleanData.IsValidName(txtFirstName.Text))
                {
                    MessageBox.Show("لطفا نام را درست وارد کنید");
                    txtNationalCode.Text = string.Empty;
                    return false;
                }
            //Validate LastName
            if (string.IsNullOrEmpty(txtLastName.Text) || !CleanData.IsValidName(txtLastName.Text))
            {
                MessageBox.Show("لطفا نام خانوادگی را درست وارد کنید");
                txtNationalCode.Text = string.Empty;
                return false;
            }
            //Validate NationalCode
            if (string.IsNullOrEmpty(txtNationalCode.Text) || !CleanData.IsValidNationalCode(txtNationalCode.Text))
            {
                MessageBox.Show("لطفا کد ملی  را درست وارد کنید");
                txtNationalCode.Text = string.Empty;
                return false;
            }
            //Validate User Role
            if (cmbUserRole.SelectedIndex==0)
            {
                MessageBox.Show("لطفاعنوان راانتخاب کنید");
                return false;
            }
            else
                return true;
        }
        private void ResetCustomerForm()
        {
            cmbUserRole.SelectedIndex = 0;
            txtFirstName.Text = string.Empty;
            txtLastName.Text = string.Empty;
            txtNationalCode.Text = string.Empty;
            txtPhoneNumber.Text = string.Empty;
            txtProvince.Text = string.Empty;
            txtCity.Text = string.Empty;
            txtStreet.Text = string.Empty;
            txtNumber.Text = string.Empty;
        }

        private void PersonForm_Load(object sender, EventArgs e)
        {
            RefreshDataGridView(Storage.Persons);
            cmbUserRole.DataSource = Enum.GetValues(typeof(UserRole));
        }

        private void cmbUserRole_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmbUserRole.SelectedIndex)
            {
                case 1:
                case 2:
                    RefreshDataGridView(Storage.Persons); 
                    break;
                case 3:
                    RefreshDataGridView(Storage.Customers);
                    break;
                case 4:
                    txtCompanyName.Enabled = true;
                    RefreshDataGridView(Storage.Suppliers);
                    break;
                default:
                    RefreshDataGridView(Storage.Persons);
                    return;
            }
        }
        private void RefreshDataGridView<T>(List<T> list)
        {
            personDataGridView.DataSource = null;
            personDataGridView.DataSource =Storage.Persons;
        }
    }
}
