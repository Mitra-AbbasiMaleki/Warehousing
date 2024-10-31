using BaseBackend.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Warehousing.DTOs;
using Warehousing.Utilities;

namespace Warehousing
{
    public partial class ProductForm : Form
    {
        public ProductForm()
        {
            InitializeComponent();
        }

        private void ProductForm_Load(object sender, EventArgs e)
        {
            cmbUnit.DataSource = Storage.units;
            cmbProductGroup.DataSource = Storage.categories;
            RefreshDataGridView();
        }

        private void btnProductRegistration_Click(object sender, EventArgs e)
        {
            //call validation
            if (!ISValidateProductForm())
                return;

            ProductCategory categorySelected =(ProductCategory)cmbProductGroup.SelectedItem;
            MeasurementUnit unitSelected = (MeasurementUnit)cmbUnit.SelectedItem;
            DateTime expirationDate = mtxExpiryDate.Text.ToExpirationDate();
            Warehouse warehouselected;
            if (chkCentralWarehouse.Checked)
            {
                warehouselected = Storage.centralWarehouse;  // اختصاص انبار مرکزی
            }
            else if (chkOtherWarehouse.Checked)
            {
                warehouselected = Storage.wasteWarehouse;  // اختصاص انبار دیگر
            }
            else
            {
                MessageBox.Show("لطفاً یک انبار انتخاب کنید.");
                return;
            }
 
            //DTO
            AddProduct addProduct = new AddProduct()
            {
                ProductName = txtProductName.Text,
                Category = categorySelected,
                Quantity = Convert.ToInt32(mtxFirstQuantity.Text),
                Price = Convert.ToDecimal(txtPrice.Text),
                ExpiryDate = expirationDate,
                Warehouse = warehouselected,
                Unit = unitSelected,
                Description = txtDescription.Text
            };
            //Add Product
            AddProduct(addProduct);
            //Show Messag
            MessageBox.Show("محصول با موفقیت ثبت شد");
            //Reset Form
            ResetProductForm();
        }
        public void AddProduct(AddProduct addProduct)
        {
            //creat object
            Product product = new Product(name:addProduct.ProductName,category:addProduct.Category,quantity:addProduct.Quantity,unit:addProduct.Unit,price:addProduct.Price,warehouse:addProduct.Warehouse,expiryDate:addProduct.ExpiryDate,description:addProduct.Description);
            Storage.products.Add(product);
            RefreshDataGridView();
        }
        private bool ISValidateProductForm()
        {
            if (string.IsNullOrEmpty(txtProductName.Text) ||
                string.IsNullOrEmpty(mtxFirstQuantity.Text) ||
                cmbUnit.SelectedItem == null||
                string.IsNullOrEmpty(txtPrice.Text))
            {
                MessageBox.Show("لطفا فیلدهای ضروری را پر کنید.");
                return false;
            }
            else
                return true;
        }
        private void ResetProductForm()
        {
            txtProductName.Text = string.Empty;
            cmbProductGroup.SelectedIndex = 0;
            mtxFirstQuantity.Text = string.Empty;
            cmbUnit.Text = string.Empty;
            txtPrice.Text = string.Empty;
            mtxExpiryDate.Text = string.Empty;
            txtSupplier.Text = string.Empty;
            txtDescription.Text = string.Empty;
        }
        private void RefreshDataGridView()
        {
            productDataGridView.DataSource = null;
            productDataGridView.DataSource = Storage.products;
            productDataGridView.Columns["Category"].Visible = false;
            productDataGridView.Columns["Unit"].Visible = false;
            productDataGridView.Columns["Warehouse"].Visible = false;
        }
    }
}
