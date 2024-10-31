using System;
using System.Windows.Forms;

namespace Warehousing
{
    partial class MainForm
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
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.personMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.newPersonMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.newProductMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.orderMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.newOrderMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.personMenu,
            this.productMenu,
            this.orderMenu});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(8, 3, 0, 3);
            this.menuStrip.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menuStrip.Size = new System.Drawing.Size(572, 29);
            this.menuStrip.TabIndex = 0;
            // 
            // personMenu
            // 
            this.personMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newPersonMenuItem});
            this.personMenu.Name = "personMenu";
            this.personMenu.Size = new System.Drawing.Size(127, 23);
            this.personMenu.Text = "مدیریت اشخاص";
            // 
            // newPersonMenuItem
            // 
            this.newPersonMenuItem.Name = "newPersonMenuItem";
            this.newPersonMenuItem.Size = new System.Drawing.Size(205, 24);
            this.newPersonMenuItem.Text = "تعریف شخص جدید";
            this.newPersonMenuItem.Click += new System.EventHandler(this.NewPersonMenuItem_Click);
            // 
            // productMenu
            // 
            this.productMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newProductMenu});
            this.productMenu.Name = "productMenu";
            this.productMenu.Size = new System.Drawing.Size(134, 23);
            this.productMenu.Text = "مدیریت محصولات";
            // 
            // newProductMenu
            // 
            this.newProductMenu.Name = "newProductMenu";
            this.newProductMenu.Size = new System.Drawing.Size(207, 24);
            this.newProductMenu.Text = "تعریف محصول جدید";
            this.newProductMenu.Click += new System.EventHandler(this.NewProductMenu_Click);
            // 
            // orderMenu
            // 
            this.orderMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newOrderMenu});
            this.orderMenu.Name = "orderMenu";
            this.orderMenu.Size = new System.Drawing.Size(142, 23);
            this.orderMenu.Text = "مدیریت سفارشات";
            // 
            // newOrderMenu
            // 
            this.newOrderMenu.Name = "newOrderMenu";
            this.newOrderMenu.Size = new System.Drawing.Size(213, 24);
            this.newOrderMenu.Text = "تعریف سفارش جدید";
            this.newOrderMenu.Click += new System.EventHandler(this.NewOrderMenu_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 343);
            this.Controls.Add(this.menuStrip);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MainForm";
            this.RightToLeftLayout = true;
            this.Text = "صفحه اصلی";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.menuStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip;
        private ToolStripMenuItem personMenu;
        private ToolStripMenuItem newPersonMenuItem;
        private ToolStripMenuItem productMenu;
        private ToolStripMenuItem newProductMenu;
        private ToolStripMenuItem orderMenu;
        private ToolStripMenuItem newOrderMenu;
    }
}