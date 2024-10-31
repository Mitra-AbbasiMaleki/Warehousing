using BaseBackend.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Warehousing.DTOs;
using Warehousing.Utilities;

namespace Warehousing
{
    public partial class OrderForm : Form
    {
        OrderManager orderManager;
        OrderItem orderItem;
        OrderItem selectedItem;
        List<OrderItem> orderItems;
        DataGridViewRow selectedRow;
        Product selectedProduct;
        MeasurementUnit selectedunit;
        ProductCategory selectedCategory;
        decimal totalOrderPrice = 0;
        int quantity = 0;
        int nextid = 1;
        public OrderForm()
        {
            InitializeComponent();
            orderManager = new OrderManager();
            orderItems = new List<OrderItem>();
        }

        private void OrderForm_Load(object sender, EventArgs e)
        {
            lblDate.Text = DateTime.Now.ToShortDateString();
    
            // متصل کردن رویدادها به DataGridView
            orderDataGridView.CellValueChanged += orderDataGridView_CellClick;
            cmbCategory.SelectedIndexChanged += cmbCategory_SelectedIndexChanged;
            cmbProductName.SelectedIndexChanged += cmbProductName_SelectedIndexChanged;
            cmbCustomer.SelectedIndexChanged += cmbCustomer_SelectedIndexChanged;
            cmbCustomer.DataSource = Storage.Customers;       //نمایش نام مشتری
            cmbCustomer.DisplayMember = "FullName";
            cmbCustomer.ValueMember = "Id";
            cmbCategory.DataSource = Storage.categories;      //نمایش گروه محصولات
            cmbCategory.DisplayMember = "CategoryName";
            cmbCategory.ValueMember = "Id";
            nudQuantity.Value = 0;
            btnEdit.Enabled = false;                 //غیرفعال کردن کلید ویرایش
            orderDataGridView.Refresh();
        }
        //اضافه کرن محصول به لیست
        private void btnAdd_Click(object sender, EventArgs e)
        {
            //call validation
            if (!ISValidateOrderForm())
                return;
     
            selectedProduct = (Product)cmbProductName.SelectedItem;                //محصول انتخاب شده
            selectedunit = (MeasurementUnit)cmbUnit.SelectedItem;                  //واحد انتخاب شده
            selectedCategory = (ProductCategory)cmbCategory.SelectedItem;          //گروه انتخاب شده
            quantity = Convert.ToInt32(nudQuantity.Value);                         //تعداد محصول
            //DTO
            AddOrderItem addOrderItem = new AddOrderItem()
            {
                Id = nextid,
                ProductId=selectedProduct.Id,
                Product = selectedProduct,
                Quantity =quantity,
                Unit=selectedunit
            };
            if (orderManager.IsProductDuplicate(selectedProduct))
            {
                MessageBox.Show("محصول مورد نظر  قبلا اضافه شده");
                return;
            }
            else if (selectedProduct.IsInStock(quantity))
            {
                //ارسال برای اضافه کردن محصول
                AddOrderItem(addOrderItem);
                orderDataGridView.Refresh();
            }
            else
            {
                MessageBox.Show("موجودی کافی نیست");
                return;
            }
 
        }

        //تابعی برای اضافه کردن محصول به لیست
        private void AddOrderItem(AddOrderItem addOrderItem)
        {
            //creat object
            orderItem = new OrderItem(product: addOrderItem.Product, quantity: addOrderItem.Quantity,unit:selectedunit);
            if(orderManager.AddOrderItem(orderItem))//بررسی تکراری نبودن محصول و اضافه کردن محصول
            {
                AddOrderItemToShow(orderItem);    //نمایش محصول در DataGridView
                orderItems.Add(orderItem); // اضافه کردن محصول به لیست
            } 
        }

        //تابعی برای نمایش محصول اضافه شده در DataGridView
        private void AddOrderItemToShow(OrderItem orderItem)
        {
            if (orderDataGridView != null)
            {
                //محاسبه قیمت کل محصول
                decimal totalProductPrice = orderItem.Quantity * orderItem.Product.Price;
                totalOrderPrice += orderItem.TotalProductPrice;
                // اضافه کردن یک ردیف به DataGridView
                orderDataGridView.Rows.Add(nextid, orderItem.Product.Id, orderItem.Product.Name, orderItem.Quantity,orderItem.Unit.Name, orderItem.Product.Price, totalProductPrice);
                nextid++;
                txtTotalPrice.Text = totalOrderPrice.ToString("N0");  //نمایش صحیح فرمت عددی پول
                orderDataGridView.Refresh();
            }
        }

        //ثبت سفارش
        private void btnOrderRegistration_Click(object sender, EventArgs e)
        {
            Customer selectedCustomer = (Customer)cmbCustomer.SelectedItem;      //مشتری انتخاب شده
            Address selectedAddress = (Address)cmbAddress.SelectedItem;          // آدرس انتخاب شده
            //DTO
            AddOrder addOrder = new AddOrder()
            {
                Customer = selectedCustomer,
                OrderItems =orderItems,
                Address = selectedAddress
            };
            //ارسال برای ثبت سفارش
            AddOrder(addOrder);
        }
        
        //تابعی برای ثبت سفارش
        private void AddOrder(AddOrder addOrder)
        {
            //creat object
           Order newOrder = new Order(customerName: addOrder.Customer, orderItems: addOrder.OrderItems);
            //ساخت یک سفارش جدید
            orderManager.CreateOrder(customer: addOrder.Customer, ordeItems: addOrder.OrderItems);
            //Show Messag
            MessageBox.Show($" سفارش با( {nextid - 1} ) قلم محصول برای  ( {addOrder.Customer.FullName} ) با آدرس  ( {addOrder.Address.ShortAddress} ) ثبت شد.\n\t *با تشکر از خرید شما*");
            //reset Form
            ResetOrderForm();
        }

        //تابعی برای اعتبارسنجی فرم
        private bool ISValidateOrderForm()
        {
            if (cmbCategory.SelectedItem == null ||
                cmbProductName.SelectedItem == null ||
                cmbUnit.SelectedItem == null ||
                cmbUnit.SelectedItem == null ||
                cmbCustomer.SelectedItem == null ||
                nudQuantity.Value==0)
            {
                MessageBox.Show("لطفا فیلدهای ضروری را پر کنید.");
                return false;
            }
            else
                return true;
        }

        //تابعی برای ریست کردن فرم
        private void ResetOrderForm()
        {
            nextid = 1;
            nudQuantity.Value = 0;
            txtTotalPrice.Text = string.Empty;
            totalOrderPrice = 0;
            orderDataGridView.Rows.Clear();
        }

        private void cmbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            //مشخص کردن گروه محصول انتخاب شده
            selectedCategory = (ProductCategory)cmbCategory.SelectedItem;
            //بررسی میکند که گروه محصول انتخاب شده خالی نباشد
            if (selectedCategory != null)
            {
                // فیلتر کردن محصولات مرتبط با گروه انتخاب شده
                var filteredProducts = Storage.products.Where(p => p.Category.CategoryName == selectedCategory.CategoryName).ToList();

                // نمایش محصولات مرتبط با گروه در combobox
                cmbProductName.DataSource = filteredProducts;
                cmbProductName.DisplayMember = "Name";
            }
            else
                MessageBox.Show("لطفا ابتدا گروه محصولات را انتخاب کنید.");
        }

        private void cmbProductName_SelectedIndexChanged(object sender, EventArgs e)
        {
            //مشخص کردن محصول انتخاب شده
            Product selectedProduct = (Product)cmbProductName.SelectedItem;
            //بررسی میکند که محصول انتخاب شده خالی نباشد
            if (selectedProduct != null)
            {
                // فیلتر کردن واحد محصول مرتبط با محصول انتخاب شده
                var filteredUnites = Storage.units.Where(u => u.Name == selectedProduct.UnitName).ToList();

                // نمایش واحدهای مرتبط با محصول در combobox
                cmbUnit.DataSource = filteredUnites;
                cmbUnit.DisplayMember = "UnitName";
            }
            else
                MessageBox.Show("لطفا محصول مورد نظر خود راانتخاب کنید.");
        }

        private void cmbCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {
            //مشخص کردن مشتری انتخاب شده
            Customer selectedCustomer = (Customer)cmbCustomer.SelectedItem;
            //بررسی میکند که مشتری انتخاب شده خالی نباشد
            if (selectedCustomer!=null)
            {
                // فیلتر کردن آدرس مرتبط با مشتری انتخاب شده
                cmbAddress.DataSource = selectedCustomer.Addresses;
                cmbAddress.DisplayMember = "ShortAddress";
            }
            else
                MessageBox.Show("لطفا مشتری مورد نظر راانتخاب کنید.");
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            btnAdd.Enabled = false;       //غیر فعال سازی کلید اضافه
            btnSave.Visible = true;       //نمایش کلید ذخیره برای ثبت تغییرات
            if (selectedRow != null)
            {
                // ستون "تعداد" را قابل ویرایش کنید
                selectedRow.Cells["Quantity"].ReadOnly = false;

                // سلول ستون "تعداد" را انتخاب و ویرایش را آغاز کنید
                int rowIndex = selectedRow.Index;//ردیف انتخاب شده
                orderDataGridView.CurrentCell = orderDataGridView.Rows[rowIndex].Cells["Quantity"]; //انتخاب ستون تعداد در ردیف انتخاب  شده
                orderDataGridView.BeginEdit(true); // ورود به حالت ویرایش
                selectedItem = GetOrderItemFromSelectedRow();
                // غیرفعال‌سازی دکمه ویرایش تا از ویرایش تصادفی جلوگیری شود
                btnEdit.Enabled = false;
            }
            else
            {
                MessageBox.Show("لطفاً ابتدا یک ردیف را انتخاب کنید.");
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            btnAdd.Enabled = true;  //فعال کردن کلید اضافه
            btnSave.Visible = false; //مخفی کردن کلید ذخیره
            btnEdit.Enabled = false; //غیرفعال کردن کلید ویرایش

            if (orderItem != null)
            {
                int quantity;
                if (int.TryParse(selectedRow.Cells["Quantity"].Value.ToString(), out quantity))
                {
                    // به‌روزرسانی OrderItem با مقادیر جدید
                    selectedItem.Quantity = quantity;
                    selectedRow.Cells["TotalProductPrice"].Value = selectedItem.TotalProductPrice; // به‌روزرسانی قیمت کل
                    CalculateTotalOrderPrice();
                    selectedRow.Cells["Quantity"].ReadOnly = true;
                }
                else
                {
                    MessageBox.Show("مقدار وارد شده برای تعداد نامعتبر است.");
                }
            }
            else
            {
                MessageBox.Show("محصول مورد نظر پیدا نشد.");
            }
        }

        private void orderDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // بررسی اینکه روی یک ردیف کلیک شده است
            {
                orderDataGridView.Rows[e.RowIndex].Selected = true; // انتخاب ردیف
                selectedRow = orderDataGridView.Rows[e.RowIndex];
                btnEdit.Enabled = true; //فعال کردن کلید ویرایش
            }
        }
        private OrderItem GetOrderItemFromSelectedRow()
        {
            if (selectedRow != null)
            {
                int rowIndex = selectedRow.Index;
                var productName = selectedRow.Cells["ProductName"].Value.ToString();
                var quantity = Convert.ToInt32(selectedRow.Cells["Quantity"].Value);

                // جستجوی OrderItem بر اساس نام محصول
                return orderItems.FirstOrDefault(item => item.Product.Name == productName && item.Quantity == quantity);
            }
            return null;
        }
        private void CalculateTotalOrderPrice()
        {
            totalOrderPrice = 0;
            foreach (var orderItem in orderItems)
            totalOrderPrice += orderItem.TotalProductPrice;
            txtTotalPrice.Text = totalOrderPrice.ToString("N0");  //نمایش صحیح فرمت عددی پول
        }
    }
}

