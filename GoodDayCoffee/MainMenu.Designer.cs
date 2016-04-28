﻿namespace GoodDayCoffee
{
    partial class MainMenu
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
            this.MainControlTab = new System.Windows.Forms.TabControl();
            this.HomePage = new System.Windows.Forms.TabPage();
            this.cb_SortBy = new System.Windows.Forms.ComboBox();
            this.label28 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.btn_Update = new System.Windows.Forms.Button();
            this.txt_Quantity = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_Origin = new System.Windows.Forms.TextBox();
            this.txt_Strength = new System.Windows.Forms.TextBox();
            this.txt_Type = new System.Windows.Forms.TextBox();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pb_Image = new System.Windows.Forms.PictureBox();
            this.dg_Coffee = new System.Windows.Forms.DataGridView();
            this.txt_Search = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.AddCoffeeTab = new System.Windows.Forms.TabPage();
            this.txt_CoffeeImage = new System.Windows.Forms.TextBox();
            this.label29 = new System.Windows.Forms.Label();
            this.btn_Add = new System.Windows.Forms.Button();
            this.txt_AddDesc = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.btn_SelectImage = new System.Windows.Forms.Button();
            this.pb_AddImage = new System.Windows.Forms.PictureBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txt_AddQuantity = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txt_AddPrice = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txt_AddStrength = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_addOrigin = new System.Windows.Forms.TextBox();
            this.txt_AddType = new System.Windows.Forms.TextBox();
            this.txt_AddName = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.EditCoffeeTab = new System.Windows.Forms.TabPage();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.txt_editCoffeeImage = new System.Windows.Forms.TextBox();
            this.label30 = new System.Windows.Forms.Label();
            this.btn_EditCoffee = new System.Windows.Forms.Button();
            this.txt_EditDesc = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.btn_EditImage = new System.Windows.Forms.Button();
            this.pb_EditImage = new System.Windows.Forms.PictureBox();
            this.label18 = new System.Windows.Forms.Label();
            this.txt_EditQuantity = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.txt_EditPrice = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.txt_EditStrength = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.txt_EditOrigin = new System.Windows.Forms.TextBox();
            this.txt_EditType = new System.Windows.Forms.TextBox();
            this.txt_EditName = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.OrderTab = new System.Windows.Forms.TabPage();
            this.TransactionTab = new System.Windows.Forms.TabPage();
            this.timerRefresh = new System.Windows.Forms.Timer(this.components);
            this.timerStockUpdate = new System.Windows.Forms.Timer(this.components);
            this.MainControlTab.SuspendLayout();
            this.HomePage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Image)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg_Coffee)).BeginInit();
            this.AddCoffeeTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_AddImage)).BeginInit();
            this.EditCoffeeTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_EditImage)).BeginInit();
            this.SuspendLayout();
            // 
            // MainControlTab
            // 
            this.MainControlTab.Controls.Add(this.HomePage);
            this.MainControlTab.Controls.Add(this.AddCoffeeTab);
            this.MainControlTab.Controls.Add(this.EditCoffeeTab);
            this.MainControlTab.Controls.Add(this.OrderTab);
            this.MainControlTab.Controls.Add(this.TransactionTab);
            this.MainControlTab.Location = new System.Drawing.Point(12, 12);
            this.MainControlTab.Name = "MainControlTab";
            this.MainControlTab.SelectedIndex = 0;
            this.MainControlTab.Size = new System.Drawing.Size(695, 360);
            this.MainControlTab.TabIndex = 0;
            // 
            // HomePage
            // 
            this.HomePage.Controls.Add(this.cb_SortBy);
            this.HomePage.Controls.Add(this.label28);
            this.HomePage.Controls.Add(this.label27);
            this.HomePage.Controls.Add(this.label26);
            this.HomePage.Controls.Add(this.btn_Update);
            this.HomePage.Controls.Add(this.txt_Quantity);
            this.HomePage.Controls.Add(this.label7);
            this.HomePage.Controls.Add(this.txt_Origin);
            this.HomePage.Controls.Add(this.txt_Strength);
            this.HomePage.Controls.Add(this.txt_Type);
            this.HomePage.Controls.Add(this.txt_Name);
            this.HomePage.Controls.Add(this.label6);
            this.HomePage.Controls.Add(this.label5);
            this.HomePage.Controls.Add(this.label4);
            this.HomePage.Controls.Add(this.label3);
            this.HomePage.Controls.Add(this.label2);
            this.HomePage.Controls.Add(this.pb_Image);
            this.HomePage.Controls.Add(this.dg_Coffee);
            this.HomePage.Controls.Add(this.txt_Search);
            this.HomePage.Controls.Add(this.label1);
            this.HomePage.Location = new System.Drawing.Point(4, 22);
            this.HomePage.Name = "HomePage";
            this.HomePage.Padding = new System.Windows.Forms.Padding(3);
            this.HomePage.Size = new System.Drawing.Size(687, 334);
            this.HomePage.TabIndex = 0;
            this.HomePage.Text = "Home";
            this.HomePage.UseVisualStyleBackColor = true;
            // 
            // cb_SortBy
            // 
            this.cb_SortBy.FormattingEnabled = true;
            this.cb_SortBy.Items.AddRange(new object[] {
            "Name",
            "Type",
            "Origin",
            "Strength",
            "Price",
            "Quantity"});
            this.cb_SortBy.Location = new System.Drawing.Point(532, 13);
            this.cb_SortBy.Name = "cb_SortBy";
            this.cb_SortBy.Size = new System.Drawing.Size(132, 21);
            this.cb_SortBy.TabIndex = 20;
            this.cb_SortBy.SelectedValueChanged += new System.EventHandler(this.cb_SortBy_SelectedValueChanged);
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(486, 16);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(44, 13);
            this.label28.TabIndex = 19;
            this.label28.Text = "Sort By:";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.BackColor = System.Drawing.Color.Transparent;
            this.label27.ForeColor = System.Drawing.Color.LightBlue;
            this.label27.Location = new System.Drawing.Point(486, 211);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(89, 13);
            this.label27.TabIndex = 18;
            this.label27.Text = "High Stock Level";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.BackColor = System.Drawing.Color.Transparent;
            this.label26.ForeColor = System.Drawing.Color.Salmon;
            this.label26.Location = new System.Drawing.Point(578, 211);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(87, 13);
            this.label26.TabIndex = 17;
            this.label26.Text = "Low Stock Level";
            // 
            // btn_Update
            // 
            this.btn_Update.Location = new System.Drawing.Point(522, 300);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(143, 23);
            this.btn_Update.TabIndex = 16;
            this.btn_Update.Text = "Update Stocks";
            this.btn_Update.UseVisualStyleBackColor = true;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // txt_Quantity
            // 
            this.txt_Quantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Quantity.Location = new System.Drawing.Point(503, 260);
            this.txt_Quantity.Name = "txt_Quantity";
            this.txt_Quantity.Size = new System.Drawing.Size(162, 26);
            this.txt_Quantity.TabIndex = 15;
            this.txt_Quantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(500, 240);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 18);
            this.label7.TabIndex = 14;
            this.label7.Text = "Quantity:";
            // 
            // txt_Origin
            // 
            this.txt_Origin.Location = new System.Drawing.Point(198, 303);
            this.txt_Origin.Name = "txt_Origin";
            this.txt_Origin.ReadOnly = true;
            this.txt_Origin.Size = new System.Drawing.Size(261, 20);
            this.txt_Origin.TabIndex = 13;
            // 
            // txt_Strength
            // 
            this.txt_Strength.Location = new System.Drawing.Point(198, 281);
            this.txt_Strength.Name = "txt_Strength";
            this.txt_Strength.ReadOnly = true;
            this.txt_Strength.Size = new System.Drawing.Size(261, 20);
            this.txt_Strength.TabIndex = 12;
            // 
            // txt_Type
            // 
            this.txt_Type.Location = new System.Drawing.Point(198, 259);
            this.txt_Type.Name = "txt_Type";
            this.txt_Type.ReadOnly = true;
            this.txt_Type.Size = new System.Drawing.Size(261, 20);
            this.txt_Type.TabIndex = 11;
            // 
            // txt_Name
            // 
            this.txt_Name.Location = new System.Drawing.Point(198, 237);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.ReadOnly = true;
            this.txt_Name.Size = new System.Drawing.Size(261, 20);
            this.txt_Name.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(141, 305);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Origin:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(141, 283);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Strength:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(141, 261);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Type:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(141, 240);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(140, 221);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Coffee";
            // 
            // pb_Image
            // 
            this.pb_Image.Location = new System.Drawing.Point(22, 221);
            this.pb_Image.Name = "pb_Image";
            this.pb_Image.Size = new System.Drawing.Size(111, 97);
            this.pb_Image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_Image.TabIndex = 3;
            this.pb_Image.TabStop = false;
            // 
            // dg_Coffee
            // 
            this.dg_Coffee.AllowUserToAddRows = false;
            this.dg_Coffee.AllowUserToDeleteRows = false;
            this.dg_Coffee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_Coffee.Location = new System.Drawing.Point(22, 45);
            this.dg_Coffee.MultiSelect = false;
            this.dg_Coffee.Name = "dg_Coffee";
            this.dg_Coffee.ReadOnly = true;
            this.dg_Coffee.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dg_Coffee.Size = new System.Drawing.Size(643, 163);
            this.dg_Coffee.TabIndex = 2;
            this.dg_Coffee.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_Coffee_CellClick);
            this.dg_Coffee.SelectionChanged += new System.EventHandler(this.dg_Coffee_SelectionChanged);
            // 
            // txt_Search
            // 
            this.txt_Search.Location = new System.Drawing.Point(69, 13);
            this.txt_Search.Name = "txt_Search";
            this.txt_Search.Size = new System.Drawing.Size(262, 20);
            this.txt_Search.TabIndex = 1;
            this.txt_Search.TextChanged += new System.EventHandler(this.txt_Search_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Search:";
            // 
            // AddCoffeeTab
            // 
            this.AddCoffeeTab.Controls.Add(this.txt_CoffeeImage);
            this.AddCoffeeTab.Controls.Add(this.label29);
            this.AddCoffeeTab.Controls.Add(this.btn_Add);
            this.AddCoffeeTab.Controls.Add(this.txt_AddDesc);
            this.AddCoffeeTab.Controls.Add(this.label16);
            this.AddCoffeeTab.Controls.Add(this.btn_SelectImage);
            this.AddCoffeeTab.Controls.Add(this.pb_AddImage);
            this.AddCoffeeTab.Controls.Add(this.label15);
            this.AddCoffeeTab.Controls.Add(this.txt_AddQuantity);
            this.AddCoffeeTab.Controls.Add(this.label14);
            this.AddCoffeeTab.Controls.Add(this.txt_AddPrice);
            this.AddCoffeeTab.Controls.Add(this.label13);
            this.AddCoffeeTab.Controls.Add(this.txt_AddStrength);
            this.AddCoffeeTab.Controls.Add(this.label12);
            this.AddCoffeeTab.Controls.Add(this.txt_addOrigin);
            this.AddCoffeeTab.Controls.Add(this.txt_AddType);
            this.AddCoffeeTab.Controls.Add(this.txt_AddName);
            this.AddCoffeeTab.Controls.Add(this.label11);
            this.AddCoffeeTab.Controls.Add(this.label10);
            this.AddCoffeeTab.Controls.Add(this.label9);
            this.AddCoffeeTab.Controls.Add(this.label8);
            this.AddCoffeeTab.Location = new System.Drawing.Point(4, 22);
            this.AddCoffeeTab.Name = "AddCoffeeTab";
            this.AddCoffeeTab.Padding = new System.Windows.Forms.Padding(3);
            this.AddCoffeeTab.Size = new System.Drawing.Size(687, 334);
            this.AddCoffeeTab.TabIndex = 1;
            this.AddCoffeeTab.Text = "Add Coffee";
            this.AddCoffeeTab.UseVisualStyleBackColor = true;
            // 
            // txt_CoffeeImage
            // 
            this.txt_CoffeeImage.Location = new System.Drawing.Point(8, 306);
            this.txt_CoffeeImage.Name = "txt_CoffeeImage";
            this.txt_CoffeeImage.Size = new System.Drawing.Size(301, 20);
            this.txt_CoffeeImage.TabIndex = 20;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(6, 292);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(73, 13);
            this.label29.TabIndex = 19;
            this.label29.Text = "Coffee Image:";
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(514, 292);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(150, 27);
            this.btn_Add.TabIndex = 18;
            this.btn_Add.Text = "Add Coffee";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // txt_AddDesc
            // 
            this.txt_AddDesc.Location = new System.Drawing.Point(338, 179);
            this.txt_AddDesc.Multiline = true;
            this.txt_AddDesc.Name = "txt_AddDesc";
            this.txt_AddDesc.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_AddDesc.Size = new System.Drawing.Size(326, 107);
            this.txt_AddDesc.TabIndex = 17;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(337, 165);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(97, 13);
            this.label16.TabIndex = 16;
            this.label16.Text = "Coffee Description:";
            // 
            // btn_SelectImage
            // 
            this.btn_SelectImage.Location = new System.Drawing.Point(551, 139);
            this.btn_SelectImage.Name = "btn_SelectImage";
            this.btn_SelectImage.Size = new System.Drawing.Size(111, 23);
            this.btn_SelectImage.TabIndex = 15;
            this.btn_SelectImage.Text = "Select Image";
            this.btn_SelectImage.UseVisualStyleBackColor = true;
            this.btn_SelectImage.Click += new System.EventHandler(this.btn_SelectImage_Click);
            // 
            // pb_AddImage
            // 
            this.pb_AddImage.Location = new System.Drawing.Point(423, 39);
            this.pb_AddImage.Name = "pb_AddImage";
            this.pb_AddImage.Size = new System.Drawing.Size(109, 123);
            this.pb_AddImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_AddImage.TabIndex = 14;
            this.pb_AddImage.TabStop = false;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(335, 39);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(73, 13);
            this.label15.TabIndex = 13;
            this.label15.Text = "Coffee Image:";
            // 
            // txt_AddQuantity
            // 
            this.txt_AddQuantity.Location = new System.Drawing.Point(7, 266);
            this.txt_AddQuantity.Name = "txt_AddQuantity";
            this.txt_AddQuantity.Size = new System.Drawing.Size(301, 20);
            this.txt_AddQuantity.TabIndex = 12;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(5, 252);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(83, 13);
            this.label14.TabIndex = 11;
            this.label14.Text = "Coffee Quantity:";
            // 
            // txt_AddPrice
            // 
            this.txt_AddPrice.Location = new System.Drawing.Point(8, 224);
            this.txt_AddPrice.Name = "txt_AddPrice";
            this.txt_AddPrice.Size = new System.Drawing.Size(301, 20);
            this.txt_AddPrice.TabIndex = 10;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 210);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(68, 13);
            this.label13.TabIndex = 9;
            this.label13.Text = "Coffee Price:";
            // 
            // txt_AddStrength
            // 
            this.txt_AddStrength.Location = new System.Drawing.Point(8, 182);
            this.txt_AddStrength.Name = "txt_AddStrength";
            this.txt_AddStrength.Size = new System.Drawing.Size(301, 20);
            this.txt_AddStrength.TabIndex = 8;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 168);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(84, 13);
            this.label12.TabIndex = 7;
            this.label12.Text = "Coffee Strength:";
            // 
            // txt_addOrigin
            // 
            this.txt_addOrigin.Location = new System.Drawing.Point(8, 139);
            this.txt_addOrigin.Name = "txt_addOrigin";
            this.txt_addOrigin.Size = new System.Drawing.Size(301, 20);
            this.txt_addOrigin.TabIndex = 6;
            // 
            // txt_AddType
            // 
            this.txt_AddType.Location = new System.Drawing.Point(8, 96);
            this.txt_AddType.Name = "txt_AddType";
            this.txt_AddType.Size = new System.Drawing.Size(301, 20);
            this.txt_AddType.TabIndex = 5;
            // 
            // txt_AddName
            // 
            this.txt_AddName.Location = new System.Drawing.Point(8, 53);
            this.txt_AddName.Name = "txt_AddName";
            this.txt_AddName.Size = new System.Drawing.Size(301, 20);
            this.txt_AddName.TabIndex = 4;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 125);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(71, 13);
            this.label11.TabIndex = 3;
            this.label11.Text = "Coffee Origin:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(7, 82);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(68, 13);
            this.label10.TabIndex = 2;
            this.label10.Text = "Coffee Type:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 39);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "Coffee Name:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(7, 10);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(119, 16);
            this.label8.TabIndex = 0;
            this.label8.Text = "Add New Coffee";
            // 
            // EditCoffeeTab
            // 
            this.EditCoffeeTab.Controls.Add(this.btn_Delete);
            this.EditCoffeeTab.Controls.Add(this.txt_editCoffeeImage);
            this.EditCoffeeTab.Controls.Add(this.label30);
            this.EditCoffeeTab.Controls.Add(this.btn_EditCoffee);
            this.EditCoffeeTab.Controls.Add(this.txt_EditDesc);
            this.EditCoffeeTab.Controls.Add(this.label17);
            this.EditCoffeeTab.Controls.Add(this.btn_EditImage);
            this.EditCoffeeTab.Controls.Add(this.pb_EditImage);
            this.EditCoffeeTab.Controls.Add(this.label18);
            this.EditCoffeeTab.Controls.Add(this.txt_EditQuantity);
            this.EditCoffeeTab.Controls.Add(this.label19);
            this.EditCoffeeTab.Controls.Add(this.txt_EditPrice);
            this.EditCoffeeTab.Controls.Add(this.label20);
            this.EditCoffeeTab.Controls.Add(this.txt_EditStrength);
            this.EditCoffeeTab.Controls.Add(this.label21);
            this.EditCoffeeTab.Controls.Add(this.txt_EditOrigin);
            this.EditCoffeeTab.Controls.Add(this.txt_EditType);
            this.EditCoffeeTab.Controls.Add(this.txt_EditName);
            this.EditCoffeeTab.Controls.Add(this.label22);
            this.EditCoffeeTab.Controls.Add(this.label23);
            this.EditCoffeeTab.Controls.Add(this.label24);
            this.EditCoffeeTab.Controls.Add(this.label25);
            this.EditCoffeeTab.Location = new System.Drawing.Point(4, 22);
            this.EditCoffeeTab.Name = "EditCoffeeTab";
            this.EditCoffeeTab.Padding = new System.Windows.Forms.Padding(3);
            this.EditCoffeeTab.Size = new System.Drawing.Size(687, 334);
            this.EditCoffeeTab.TabIndex = 2;
            this.EditCoffeeTab.Text = "Edit Coffee";
            this.EditCoffeeTab.UseVisualStyleBackColor = true;
            // 
            // btn_Delete
            // 
            this.btn_Delete.Location = new System.Drawing.Point(338, 292);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(150, 27);
            this.btn_Delete.TabIndex = 38;
            this.btn_Delete.Text = "Delete Coffee";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // txt_editCoffeeImage
            // 
            this.txt_editCoffeeImage.Location = new System.Drawing.Point(7, 308);
            this.txt_editCoffeeImage.Name = "txt_editCoffeeImage";
            this.txt_editCoffeeImage.Size = new System.Drawing.Size(301, 20);
            this.txt_editCoffeeImage.TabIndex = 22;
            this.txt_editCoffeeImage.Visible = false;
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(5, 294);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(73, 13);
            this.label30.TabIndex = 21;
            this.label30.Text = "Coffee Image:";
            this.label30.Visible = false;
            // 
            // btn_EditCoffee
            // 
            this.btn_EditCoffee.Location = new System.Drawing.Point(514, 292);
            this.btn_EditCoffee.Name = "btn_EditCoffee";
            this.btn_EditCoffee.Size = new System.Drawing.Size(150, 27);
            this.btn_EditCoffee.TabIndex = 37;
            this.btn_EditCoffee.Text = "Edit Coffee";
            this.btn_EditCoffee.UseVisualStyleBackColor = true;
            this.btn_EditCoffee.Click += new System.EventHandler(this.btn_EditCoffee_Click);
            // 
            // txt_EditDesc
            // 
            this.txt_EditDesc.Location = new System.Drawing.Point(338, 179);
            this.txt_EditDesc.Multiline = true;
            this.txt_EditDesc.Name = "txt_EditDesc";
            this.txt_EditDesc.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_EditDesc.Size = new System.Drawing.Size(326, 107);
            this.txt_EditDesc.TabIndex = 36;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(337, 165);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(97, 13);
            this.label17.TabIndex = 35;
            this.label17.Text = "Coffee Description:";
            // 
            // btn_EditImage
            // 
            this.btn_EditImage.Location = new System.Drawing.Point(551, 139);
            this.btn_EditImage.Name = "btn_EditImage";
            this.btn_EditImage.Size = new System.Drawing.Size(111, 23);
            this.btn_EditImage.TabIndex = 34;
            this.btn_EditImage.Text = "Select Image";
            this.btn_EditImage.UseVisualStyleBackColor = true;
            this.btn_EditImage.Click += new System.EventHandler(this.btn_EditImage_Click);
            // 
            // pb_EditImage
            // 
            this.pb_EditImage.Location = new System.Drawing.Point(423, 39);
            this.pb_EditImage.Name = "pb_EditImage";
            this.pb_EditImage.Size = new System.Drawing.Size(109, 123);
            this.pb_EditImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_EditImage.TabIndex = 33;
            this.pb_EditImage.TabStop = false;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(335, 39);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(73, 13);
            this.label18.TabIndex = 32;
            this.label18.Text = "Coffee Image:";
            // 
            // txt_EditQuantity
            // 
            this.txt_EditQuantity.Location = new System.Drawing.Point(7, 266);
            this.txt_EditQuantity.Name = "txt_EditQuantity";
            this.txt_EditQuantity.Size = new System.Drawing.Size(301, 20);
            this.txt_EditQuantity.TabIndex = 31;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(5, 252);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(83, 13);
            this.label19.TabIndex = 30;
            this.label19.Text = "Coffee Quantity:";
            // 
            // txt_EditPrice
            // 
            this.txt_EditPrice.Location = new System.Drawing.Point(8, 224);
            this.txt_EditPrice.Name = "txt_EditPrice";
            this.txt_EditPrice.Size = new System.Drawing.Size(301, 20);
            this.txt_EditPrice.TabIndex = 29;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(6, 210);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(68, 13);
            this.label20.TabIndex = 28;
            this.label20.Text = "Coffee Price:";
            // 
            // txt_EditStrength
            // 
            this.txt_EditStrength.Location = new System.Drawing.Point(8, 182);
            this.txt_EditStrength.Name = "txt_EditStrength";
            this.txt_EditStrength.Size = new System.Drawing.Size(301, 20);
            this.txt_EditStrength.TabIndex = 27;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(6, 168);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(84, 13);
            this.label21.TabIndex = 26;
            this.label21.Text = "Coffee Strength:";
            // 
            // txt_EditOrigin
            // 
            this.txt_EditOrigin.Location = new System.Drawing.Point(8, 139);
            this.txt_EditOrigin.Name = "txt_EditOrigin";
            this.txt_EditOrigin.Size = new System.Drawing.Size(301, 20);
            this.txt_EditOrigin.TabIndex = 25;
            // 
            // txt_EditType
            // 
            this.txt_EditType.Location = new System.Drawing.Point(8, 96);
            this.txt_EditType.Name = "txt_EditType";
            this.txt_EditType.Size = new System.Drawing.Size(301, 20);
            this.txt_EditType.TabIndex = 24;
            // 
            // txt_EditName
            // 
            this.txt_EditName.Location = new System.Drawing.Point(8, 53);
            this.txt_EditName.Name = "txt_EditName";
            this.txt_EditName.Size = new System.Drawing.Size(301, 20);
            this.txt_EditName.TabIndex = 23;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(6, 125);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(71, 13);
            this.label22.TabIndex = 22;
            this.label22.Text = "Coffee Origin:";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(7, 82);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(68, 13);
            this.label23.TabIndex = 21;
            this.label23.Text = "Coffee Type:";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(7, 39);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(72, 13);
            this.label24.TabIndex = 20;
            this.label24.Text = "Coffee Name:";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.Location = new System.Drawing.Point(7, 10);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(137, 16);
            this.label25.TabIndex = 19;
            this.label25.Text = "Edit Coffee Details";
            // 
            // OrderTab
            // 
            this.OrderTab.Location = new System.Drawing.Point(4, 22);
            this.OrderTab.Name = "OrderTab";
            this.OrderTab.Padding = new System.Windows.Forms.Padding(3);
            this.OrderTab.Size = new System.Drawing.Size(687, 334);
            this.OrderTab.TabIndex = 3;
            this.OrderTab.Text = "Orders";
            this.OrderTab.UseVisualStyleBackColor = true;
            // 
            // TransactionTab
            // 
            this.TransactionTab.Location = new System.Drawing.Point(4, 22);
            this.TransactionTab.Name = "TransactionTab";
            this.TransactionTab.Padding = new System.Windows.Forms.Padding(3);
            this.TransactionTab.Size = new System.Drawing.Size(687, 334);
            this.TransactionTab.TabIndex = 4;
            this.TransactionTab.Text = "Transactions";
            this.TransactionTab.UseVisualStyleBackColor = true;
            // 
            // timerRefresh
            // 
            this.timerRefresh.Enabled = true;
            this.timerRefresh.Interval = 3000;
            this.timerRefresh.Tick += new System.EventHandler(this.timerRefresh_Tick);
            // 
            // timerStockUpdate
            // 
            this.timerStockUpdate.Enabled = true;
            this.timerStockUpdate.Interval = 60000;
            this.timerStockUpdate.Tick += new System.EventHandler(this.timerStockUpdate_Tick);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 381);
            this.Controls.Add(this.MainControlTab);
            this.Name = "MainMenu";
            this.Text = "Main Menu";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.MainControlTab.ResumeLayout(false);
            this.HomePage.ResumeLayout(false);
            this.HomePage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Image)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg_Coffee)).EndInit();
            this.AddCoffeeTab.ResumeLayout(false);
            this.AddCoffeeTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_AddImage)).EndInit();
            this.EditCoffeeTab.ResumeLayout(false);
            this.EditCoffeeTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_EditImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl MainControlTab;
        private System.Windows.Forms.TabPage HomePage;
        private System.Windows.Forms.TabPage AddCoffeeTab;
        private System.Windows.Forms.TabPage EditCoffeeTab;
        private System.Windows.Forms.TabPage OrderTab;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.TextBox txt_Quantity;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_Origin;
        private System.Windows.Forms.TextBox txt_Strength;
        private System.Windows.Forms.TextBox txt_Type;
        private System.Windows.Forms.TextBox txt_Name;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pb_Image;
        private System.Windows.Forms.DataGridView dg_Coffee;
        private System.Windows.Forms.TextBox txt_Search;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TabPage TransactionTab;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.TextBox txt_AddDesc;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button btn_SelectImage;
        private System.Windows.Forms.PictureBox pb_AddImage;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txt_AddQuantity;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txt_AddPrice;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txt_AddStrength;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txt_addOrigin;
        private System.Windows.Forms.TextBox txt_AddType;
        private System.Windows.Forms.TextBox txt_AddName;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btn_EditCoffee;
        private System.Windows.Forms.TextBox txt_EditDesc;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button btn_EditImage;
        private System.Windows.Forms.PictureBox pb_EditImage;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txt_EditQuantity;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txt_EditPrice;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox txt_EditStrength;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox txt_EditOrigin;
        private System.Windows.Forms.TextBox txt_EditType;
        private System.Windows.Forms.TextBox txt_EditName;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.ComboBox cb_SortBy;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.TextBox txt_CoffeeImage;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.TextBox txt_editCoffeeImage;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Timer timerRefresh;
        private System.Windows.Forms.Timer timerStockUpdate;
    }
}