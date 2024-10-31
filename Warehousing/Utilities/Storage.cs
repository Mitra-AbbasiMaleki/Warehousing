using BaseBackend.Entities;
using BaseBackend.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Warehousing.Utilities
{
    public static class Storage
    {
        public static Warehouse centralWarehouse = new Warehouse(name: "مرکزی", location: "تهران");
        public static Warehouse wasteWarehouse = new Warehouse(name: "ضایعات", location: "کرج");
        public static List<Warehouse> warehouses = new List<Warehouse>() { centralWarehouse, wasteWarehouse };

        public static ProductCategory Electronics = new ProductCategory("الکترونیکی");
        public static ProductCategory Grocery = new ProductCategory("مواد غذایی");
        public static ProductCategory Clothing = new ProductCategory("پوشاک");
        public static ProductCategory Furniture = new ProductCategory("لوازم منزل");
        public static List<ProductCategory> categories = new List<ProductCategory>() { Electronics, Grocery, Clothing, Furniture };

        public static MeasurementUnit Kilogeram = new MeasurementUnit("کیلوگرم");
        public static MeasurementUnit Pieces = new MeasurementUnit("عدد");
        public static MeasurementUnit Litre = new MeasurementUnit("لیتر");
        public static MeasurementUnit Metr = new MeasurementUnit("متر");
        public static MeasurementUnit Set = new MeasurementUnit("دست");
        public static MeasurementUnit Pair = new MeasurementUnit("جفت");
        public static MeasurementUnit Box = new MeasurementUnit("جعبه");
        public static List<MeasurementUnit> units = new List<MeasurementUnit>() { Kilogeram, Pieces, Litre, Metr ,Set,Pair,Box};

        public static Product Mobile1 = new Product(name: "آیفون13", category: Electronics, quantity: 120, unit: Pieces, price: 320000000);
        public static Product Mobile2 = new Product(name: "سامسونگ s23", category: Electronics, quantity: 200, unit: Pieces, price: 450000000);
        public static Product Laptop = new Product(name: "ASUS لپ تاپ ", category: Electronics, quantity: 80, unit: Pieces, price: 540000000);
        public static Product Butter = new Product(name: "کره پاک", category: Grocery, quantity: 150, unit: Box, price: 200000, warehouse: centralWarehouse, expiryDate: new DateTime(2025, 05, 01), description: "delicious");
        public static Product Milk = new Product(name: "چیر پرچرب دامدادران", category: Grocery, quantity: 100, unit: Litre, price: 320000, warehouse: centralWarehouse, expiryDate: new DateTime(2024, 12, 10), description: "delicious");
        public static Product TShirt = new Product(name: "کت چرم ", category: Clothing, quantity: 120, unit: Pieces, price: 5400000);
        public static Product Sofa = new Product(name: "ست هفت نفره یاتاش ", category: Furniture, quantity: 50, unit: Set, price: 360000000);
        public static Product Table = new Product(name: "میز کامپیوتر ", category: Furniture, quantity: 50, unit: Pieces, price: 220000000);
        public static Product Rice = new Product(name: "برنج هاشمی", category: Grocery, quantity: 100, unit: Kilogeram, price: 23000000, warehouse: centralWarehouse, expiryDate: new DateTime(2024, 09, 01), description: "delicious");
        public static List<Product> products = new List<Product> { Mobile1, Mobile2, Laptop, Butter, Milk, TShirt, Rice, Table, Sofa };

        public static Address address1 = new Address(name:AddressTitle.WORK,province: "تهران", city: "تهران", street: "آزادی", number: "12");
        public static Address address2 = new Address(name: AddressTitle.WORK, province: "البرز", city: "کرج", street: "طالقانی", number: "54");
        public static Address address3 = new Address(name: AddressTitle.HOME, province: "آذربایجانشرقی", city: "تبریز", street: "شهناز", number: "78");
        public static Address address4 = new Address(name: AddressTitle.HOME, province: "اصفهان", city: "اصفهان", street: "کاشانی", number: "22");
        public static Address address5 = new Address(name: AddressTitle.WORK, province: "گیلان", city: "رشت", street: "بلوار امام", number: "65");
        public static Address address6 = new Address(name: AddressTitle.WORK, province: "مازندران", city: "ساری", street: "فرهنگ", number: "98");
        public static Address address7 = new Address(name: AddressTitle.HOME, province: "آذربایجان غربی", city: "ارومیه", street: "خیام", number: "31");
        public static Address address8 = new Address(name: AddressTitle.OTHER, province: "آذربایجان شرقی", city: "تبریز", street: "ولیعصر", number: "78");
        public static List<Address> Adresses = new List<Address>() { address1, address2, address3, address4, address5, address6, address7, address8 };

        public static SystemUser Admin = new SystemUser(role: UserRole.ADMIN, firstName: "میترا", lastName: "عباسی", nationalCode: "5310111107", phoneNumber: "09123456789", address: address1);
        public static SystemUser User = new SystemUser(role: UserRole.USER, firstName: "الهام", lastName: "ملکی", nationalCode: "7078184262", phoneNumber: "09987654321", address: address2);
        public static Customer customer1 = new Customer(role: UserRole.CUSTOMER, firstName: "علی", lastName: "علوی", nationalCode: "4320101014", phoneNumber: "09123456789", address: address3);
        public static Customer customer2 = new Customer(role: UserRole.CUSTOMER, firstName: "reza", lastName: "rezaee", nationalCode: "0295255684", phoneNumber: "09187664321", address: address4,otherAddress:address2);
        public static Customer customer3 = new Customer(role: UserRole.CUSTOMER, firstName: "محمد", lastName: "محمدی", nationalCode: "1678997242", phoneNumber: "09144542525", address: address7,otherAddress:address8);
        public static Supplier supplier1 = new Supplier(role: UserRole.SUPPLIER, companyName: "کاله", firstName: "احمد", lastName: "احمدی", nationalCode: "1971614866", phoneNumber: "09363636363", address: address5);
        public static Supplier supplier2 = new Supplier(role: UserRole.SUPPLIER, companyName: "LG", firstName: "طاها", lastName: "مرادی", nationalCode: "0937955027", phoneNumber: "09854565352", address: address6);
        public static List<Person> Persons = new List<Person>() { Admin, User, customer1, customer2, supplier1, supplier2 };
        public static List<Customer> Customers = new List<Customer>() { customer1, customer2,customer3 };
        public static List<Supplier> Suppliers = new List<Supplier>() { supplier1, supplier2 };
        public static List<SystemUser> SystemUsers = new List<SystemUser>() { Admin, User };
    }
}

