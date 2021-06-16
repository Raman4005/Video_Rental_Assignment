namespace Video_Rental_Assignment
{
    partial class Video_Rental
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
            this.tab_Movie_rental = new System.Windows.Forms.TabControl();
            this.tab_Customer = new System.Windows.Forms.TabPage();
            this.DGV_Customer = new System.Windows.Forms.DataGridView();
            this.tab_Movie = new System.Windows.Forms.TabPage();
            this.DGV_movie = new System.Windows.Forms.DataGridView();
            this.tab_Rental = new System.Windows.Forms.TabPage();
            this.DGV_Rental = new System.Windows.Forms.DataGridView();
            this.tb_popularcustomer = new System.Windows.Forms.TabPage();
            this.DGV_popularcustomer = new System.Windows.Forms.DataGridView();
            this.tab_popularmovie = new System.Windows.Forms.TabPage();
            this.DGV_popularmovie = new System.Windows.Forms.DataGridView();
            this.Customer_panel = new System.Windows.Forms.Panel();
            this.text_mobile = new System.Windows.Forms.TextBox();
            this.lbl_address = new System.Windows.Forms.Label();
            this.lbl_Phone = new System.Windows.Forms.Label();
            this.lbl_lastname = new System.Windows.Forms.Label();
            this.lbl_firstname = new System.Windows.Forms.Label();
            this.text_address = new System.Windows.Forms.TextBox();
            this.text_lastname = new System.Windows.Forms.TextBox();
            this.text_firstname = new System.Windows.Forms.TextBox();
            this.Btn_Update_customdata = new System.Windows.Forms.Button();
            this.Btn_del_customer = new System.Windows.Forms.Button();
            this.Btn_Add_customer = new System.Windows.Forms.Button();
            this.Lbl_customer = new System.Windows.Forms.Label();
            this.Rental_panel = new System.Windows.Forms.Panel();
            this.Btn_Return = new System.Windows.Forms.Button();
            this.btn_Issue = new System.Windows.Forms.Button();
            this.Return_datePicker = new System.Windows.Forms.DateTimePicker();
            this.issue_datePicker = new System.Windows.Forms.DateTimePicker();
            this.text_TitleM = new System.Windows.Forms.TextBox();
            this.text_custName = new System.Windows.Forms.TextBox();
            this.lbl_returndate = new System.Windows.Forms.Label();
            this.lbl_issuedate = new System.Windows.Forms.Label();
            this.lbl_Mname = new System.Windows.Forms.Label();
            this.lbl_custname = new System.Windows.Forms.Label();
            this.Lbl_Rental = new System.Windows.Forms.Label();
            this.Movie_panel = new System.Windows.Forms.Panel();
            this.Text_Rental_Cost = new System.Windows.Forms.TextBox();
            this.lbl_rentalcost = new System.Windows.Forms.Label();
            this.text_genre = new System.Windows.Forms.TextBox();
            this.text_plot = new System.Windows.Forms.TextBox();
            this.text_copies = new System.Windows.Forms.TextBox();
            this.text_year = new System.Windows.Forms.TextBox();
            this.text_Rating = new System.Windows.Forms.TextBox();
            this.text_Title = new System.Windows.Forms.TextBox();
            this.lbl_genre = new System.Windows.Forms.Label();
            this.lbl_plot = new System.Windows.Forms.Label();
            this.lbl_copies = new System.Windows.Forms.Label();
            this.lbl_year = new System.Windows.Forms.Label();
            this.lbl_Rating = new System.Windows.Forms.Label();
            this.lbl_Title = new System.Windows.Forms.Label();
            this.Btn_updatemovie = new System.Windows.Forms.Button();
            this.Btn_delmovie = new System.Windows.Forms.Button();
            this.Btn_addmovie = new System.Windows.Forms.Button();
            this.Lbl_Movie = new System.Windows.Forms.Label();
            this.btn_allrented = new System.Windows.Forms.Button();
            this.btn_rentedout = new System.Windows.Forms.Button();
            this.tab_Movie_rental.SuspendLayout();
            this.tab_Customer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Customer)).BeginInit();
            this.tab_Movie.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_movie)).BeginInit();
            this.tab_Rental.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Rental)).BeginInit();
            this.tb_popularcustomer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_popularcustomer)).BeginInit();
            this.tab_popularmovie.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_popularmovie)).BeginInit();
            this.Customer_panel.SuspendLayout();
            this.Rental_panel.SuspendLayout();
            this.Movie_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // tab_Movie_rental
            // 
            this.tab_Movie_rental.Controls.Add(this.tab_Customer);
            this.tab_Movie_rental.Controls.Add(this.tab_Movie);
            this.tab_Movie_rental.Controls.Add(this.tab_Rental);
            this.tab_Movie_rental.Controls.Add(this.tb_popularcustomer);
            this.tab_Movie_rental.Controls.Add(this.tab_popularmovie);
            this.tab_Movie_rental.Location = new System.Drawing.Point(12, 12);
            this.tab_Movie_rental.Name = "tab_Movie_rental";
            this.tab_Movie_rental.SelectedIndex = 0;
            this.tab_Movie_rental.Size = new System.Drawing.Size(622, 242);
            this.tab_Movie_rental.TabIndex = 0;
            // 
            // tab_Customer
            // 
            this.tab_Customer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.tab_Customer.Controls.Add(this.DGV_Customer);
            this.tab_Customer.Location = new System.Drawing.Point(4, 22);
            this.tab_Customer.Name = "tab_Customer";
            this.tab_Customer.Padding = new System.Windows.Forms.Padding(3);
            this.tab_Customer.Size = new System.Drawing.Size(614, 216);
            this.tab_Customer.TabIndex = 0;
            this.tab_Customer.Text = "Customer";
            // 
            // DGV_Customer
            // 
            this.DGV_Customer.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.DGV_Customer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Customer.Location = new System.Drawing.Point(6, 3);
            this.DGV_Customer.Name = "DGV_Customer";
            this.DGV_Customer.Size = new System.Drawing.Size(602, 207);
            this.DGV_Customer.TabIndex = 0;
            this.DGV_Customer.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_Customer_CellContentClick);
            this.DGV_Customer.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_Customer_CellContentClick);
            // 
            // tab_Movie
            // 
            this.tab_Movie.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.tab_Movie.Controls.Add(this.DGV_movie);
            this.tab_Movie.Location = new System.Drawing.Point(4, 22);
            this.tab_Movie.Name = "tab_Movie";
            this.tab_Movie.Padding = new System.Windows.Forms.Padding(3);
            this.tab_Movie.Size = new System.Drawing.Size(614, 216);
            this.tab_Movie.TabIndex = 1;
            this.tab_Movie.Text = "Movie";
            // 
            // DGV_movie
            // 
            this.DGV_movie.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.DGV_movie.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_movie.Location = new System.Drawing.Point(6, 6);
            this.DGV_movie.Name = "DGV_movie";
            this.DGV_movie.Size = new System.Drawing.Size(602, 204);
            this.DGV_movie.TabIndex = 0;
            this.DGV_movie.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_Movie_CellContentClick);
            this.DGV_movie.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_Movie_CellContentClick);
            // 
            // tab_Rental
            // 
            this.tab_Rental.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tab_Rental.Controls.Add(this.DGV_Rental);
            this.tab_Rental.Location = new System.Drawing.Point(4, 22);
            this.tab_Rental.Name = "tab_Rental";
            this.tab_Rental.Padding = new System.Windows.Forms.Padding(3);
            this.tab_Rental.Size = new System.Drawing.Size(614, 216);
            this.tab_Rental.TabIndex = 2;
            this.tab_Rental.Text = "Rental";
            // 
            // DGV_Rental
            // 
            this.DGV_Rental.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.DGV_Rental.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.DGV_Rental.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Rental.Location = new System.Drawing.Point(6, 6);
            this.DGV_Rental.Name = "DGV_Rental";
            this.DGV_Rental.Size = new System.Drawing.Size(602, 207);
            this.DGV_Rental.TabIndex = 0;
            this.DGV_Rental.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_Rental_CellContentClick);
            this.DGV_Rental.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_Rental_CellContentClick);
            // 
            // tb_popularcustomer
            // 
            this.tb_popularcustomer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.tb_popularcustomer.Controls.Add(this.DGV_popularcustomer);
            this.tb_popularcustomer.Location = new System.Drawing.Point(4, 22);
            this.tb_popularcustomer.Name = "tb_popularcustomer";
            this.tb_popularcustomer.Padding = new System.Windows.Forms.Padding(3);
            this.tb_popularcustomer.Size = new System.Drawing.Size(614, 216);
            this.tb_popularcustomer.TabIndex = 3;
            this.tb_popularcustomer.Text = "Popular customer";
            // 
            // DGV_popularcustomer
            // 
            this.DGV_popularcustomer.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.DGV_popularcustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_popularcustomer.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.DGV_popularcustomer.Location = new System.Drawing.Point(6, 6);
            this.DGV_popularcustomer.Name = "DGV_popularcustomer";
            this.DGV_popularcustomer.Size = new System.Drawing.Size(602, 204);
            this.DGV_popularcustomer.TabIndex = 0;
            // 
            // tab_popularmovie
            // 
            this.tab_popularmovie.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.tab_popularmovie.Controls.Add(this.DGV_popularmovie);
            this.tab_popularmovie.Location = new System.Drawing.Point(4, 22);
            this.tab_popularmovie.Name = "tab_popularmovie";
            this.tab_popularmovie.Padding = new System.Windows.Forms.Padding(3);
            this.tab_popularmovie.Size = new System.Drawing.Size(614, 216);
            this.tab_popularmovie.TabIndex = 4;
            this.tab_popularmovie.Text = "Popular movie";
            // 
            // DGV_popularmovie
            // 
            this.DGV_popularmovie.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.DGV_popularmovie.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_popularmovie.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.DGV_popularmovie.Location = new System.Drawing.Point(6, 6);
            this.DGV_popularmovie.Name = "DGV_popularmovie";
            this.DGV_popularmovie.Size = new System.Drawing.Size(602, 204);
            this.DGV_popularmovie.TabIndex = 0;
            // 
            // Customer_panel
            // 
            this.Customer_panel.BackColor = System.Drawing.Color.White;
            this.Customer_panel.Controls.Add(this.text_mobile);
            this.Customer_panel.Controls.Add(this.lbl_address);
            this.Customer_panel.Controls.Add(this.lbl_Phone);
            this.Customer_panel.Controls.Add(this.lbl_lastname);
            this.Customer_panel.Controls.Add(this.lbl_firstname);
            this.Customer_panel.Controls.Add(this.text_address);
            this.Customer_panel.Controls.Add(this.text_lastname);
            this.Customer_panel.Controls.Add(this.text_firstname);
            this.Customer_panel.Controls.Add(this.Btn_Update_customdata);
            this.Customer_panel.Controls.Add(this.Btn_del_customer);
            this.Customer_panel.Controls.Add(this.Btn_Add_customer);
            this.Customer_panel.Controls.Add(this.Lbl_customer);
            this.Customer_panel.Location = new System.Drawing.Point(12, 260);
            this.Customer_panel.Name = "Customer_panel";
            this.Customer_panel.Size = new System.Drawing.Size(334, 195);
            this.Customer_panel.TabIndex = 1;
            // 
            // text_mobile
            // 
            this.text_mobile.Location = new System.Drawing.Point(132, 120);
            this.text_mobile.Name = "text_mobile";
            this.text_mobile.Size = new System.Drawing.Size(100, 20);
            this.text_mobile.TabIndex = 12;
            // 
            // lbl_address
            // 
            this.lbl_address.AutoSize = true;
            this.lbl_address.Location = new System.Drawing.Point(39, 157);
            this.lbl_address.Name = "lbl_address";
            this.lbl_address.Size = new System.Drawing.Size(45, 13);
            this.lbl_address.TabIndex = 11;
            this.lbl_address.Text = "Address";
            // 
            // lbl_Phone
            // 
            this.lbl_Phone.AutoSize = true;
            this.lbl_Phone.Location = new System.Drawing.Point(39, 120);
            this.lbl_Phone.Name = "lbl_Phone";
            this.lbl_Phone.Size = new System.Drawing.Size(38, 13);
            this.lbl_Phone.TabIndex = 10;
            this.lbl_Phone.Text = "Phone";
            // 
            // lbl_lastname
            // 
            this.lbl_lastname.AutoSize = true;
            this.lbl_lastname.Location = new System.Drawing.Point(39, 82);
            this.lbl_lastname.Name = "lbl_lastname";
            this.lbl_lastname.Size = new System.Drawing.Size(58, 13);
            this.lbl_lastname.TabIndex = 9;
            this.lbl_lastname.Text = "Last Name";
            // 
            // lbl_firstname
            // 
            this.lbl_firstname.AutoSize = true;
            this.lbl_firstname.Location = new System.Drawing.Point(39, 41);
            this.lbl_firstname.Name = "lbl_firstname";
            this.lbl_firstname.Size = new System.Drawing.Size(57, 13);
            this.lbl_firstname.TabIndex = 8;
            this.lbl_firstname.Text = "First Name";
            // 
            // text_address
            // 
            this.text_address.Location = new System.Drawing.Point(132, 157);
            this.text_address.Name = "text_address";
            this.text_address.Size = new System.Drawing.Size(100, 20);
            this.text_address.TabIndex = 7;
            // 
            // text_lastname
            // 
            this.text_lastname.Location = new System.Drawing.Point(132, 79);
            this.text_lastname.Name = "text_lastname";
            this.text_lastname.Size = new System.Drawing.Size(100, 20);
            this.text_lastname.TabIndex = 5;
            // 
            // text_firstname
            // 
            this.text_firstname.Location = new System.Drawing.Point(132, 41);
            this.text_firstname.Name = "text_firstname";
            this.text_firstname.Size = new System.Drawing.Size(100, 20);
            this.text_firstname.TabIndex = 4;
            // 
            // Btn_Update_customdata
            // 
            this.Btn_Update_customdata.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Btn_Update_customdata.ForeColor = System.Drawing.SystemColors.Control;
            this.Btn_Update_customdata.Location = new System.Drawing.Point(252, 138);
            this.Btn_Update_customdata.Name = "Btn_Update_customdata";
            this.Btn_Update_customdata.Size = new System.Drawing.Size(75, 32);
            this.Btn_Update_customdata.TabIndex = 3;
            this.Btn_Update_customdata.Text = "Update";
            this.Btn_Update_customdata.UseVisualStyleBackColor = false;
            this.Btn_Update_customdata.Click += new System.EventHandler(this.Btn_Update_customdata_Click);
            // 
            // Btn_del_customer
            // 
            this.Btn_del_customer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Btn_del_customer.ForeColor = System.Drawing.SystemColors.Control;
            this.Btn_del_customer.Location = new System.Drawing.Point(252, 82);
            this.Btn_del_customer.Name = "Btn_del_customer";
            this.Btn_del_customer.Size = new System.Drawing.Size(75, 34);
            this.Btn_del_customer.TabIndex = 2;
            this.Btn_del_customer.Text = "Delete";
            this.Btn_del_customer.UseVisualStyleBackColor = false;
            this.Btn_del_customer.Click += new System.EventHandler(this.Btn_del_customer_Click);
            // 
            // Btn_Add_customer
            // 
            this.Btn_Add_customer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Btn_Add_customer.ForeColor = System.Drawing.SystemColors.Control;
            this.Btn_Add_customer.Location = new System.Drawing.Point(252, 30);
            this.Btn_Add_customer.Name = "Btn_Add_customer";
            this.Btn_Add_customer.Size = new System.Drawing.Size(75, 35);
            this.Btn_Add_customer.TabIndex = 1;
            this.Btn_Add_customer.Text = "Add ";
            this.Btn_Add_customer.UseVisualStyleBackColor = false;
            this.Btn_Add_customer.Click += new System.EventHandler(this.Btn_Add_customer_Click);
            // 
            // Lbl_customer
            // 
            this.Lbl_customer.AutoSize = true;
            this.Lbl_customer.BackColor = System.Drawing.Color.Blue;
            this.Lbl_customer.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_customer.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Lbl_customer.Location = new System.Drawing.Point(111, 11);
            this.Lbl_customer.Name = "Lbl_customer";
            this.Lbl_customer.Size = new System.Drawing.Size(112, 19);
            this.Lbl_customer.TabIndex = 0;
            this.Lbl_customer.Text = "Customer details";
            // 
            // Rental_panel
            // 
            this.Rental_panel.BackColor = System.Drawing.Color.White;
            this.Rental_panel.Controls.Add(this.Btn_Return);
            this.Rental_panel.Controls.Add(this.btn_Issue);
            this.Rental_panel.Controls.Add(this.Return_datePicker);
            this.Rental_panel.Controls.Add(this.issue_datePicker);
            this.Rental_panel.Controls.Add(this.text_TitleM);
            this.Rental_panel.Controls.Add(this.text_custName);
            this.Rental_panel.Controls.Add(this.lbl_returndate);
            this.Rental_panel.Controls.Add(this.lbl_issuedate);
            this.Rental_panel.Controls.Add(this.lbl_Mname);
            this.Rental_panel.Controls.Add(this.lbl_custname);
            this.Rental_panel.Controls.Add(this.Lbl_Rental);
            this.Rental_panel.Location = new System.Drawing.Point(358, 260);
            this.Rental_panel.Name = "Rental_panel";
            this.Rental_panel.Size = new System.Drawing.Size(276, 221);
            this.Rental_panel.TabIndex = 2;
            // 
            // Btn_Return
            // 
            this.Btn_Return.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.Btn_Return.Location = new System.Drawing.Point(140, 183);
            this.Btn_Return.Name = "Btn_Return";
            this.Btn_Return.Size = new System.Drawing.Size(75, 35);
            this.Btn_Return.TabIndex = 13;
            this.Btn_Return.Text = "Return";
            this.Btn_Return.UseVisualStyleBackColor = false;
            this.Btn_Return.Click += new System.EventHandler(this.Btn_Return_Click);
            // 
            // btn_Issue
            // 
            this.btn_Issue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btn_Issue.Location = new System.Drawing.Point(36, 183);
            this.btn_Issue.Name = "btn_Issue";
            this.btn_Issue.Size = new System.Drawing.Size(75, 35);
            this.btn_Issue.TabIndex = 12;
            this.btn_Issue.Text = "Issue";
            this.btn_Issue.UseVisualStyleBackColor = false;
            this.btn_Issue.Click += new System.EventHandler(this.btn_Issue_Click);
            // 
            // Return_datePicker
            // 
            this.Return_datePicker.Location = new System.Drawing.Point(74, 157);
            this.Return_datePicker.Name = "Return_datePicker";
            this.Return_datePicker.Size = new System.Drawing.Size(199, 20);
            this.Return_datePicker.TabIndex = 11;
            // 
            // issue_datePicker
            // 
            this.issue_datePicker.Location = new System.Drawing.Point(74, 117);
            this.issue_datePicker.Name = "issue_datePicker";
            this.issue_datePicker.Size = new System.Drawing.Size(199, 20);
            this.issue_datePicker.TabIndex = 10;
            // 
            // text_TitleM
            // 
            this.text_TitleM.Location = new System.Drawing.Point(140, 72);
            this.text_TitleM.Name = "text_TitleM";
            this.text_TitleM.Size = new System.Drawing.Size(100, 20);
            this.text_TitleM.TabIndex = 9;
            // 
            // text_custName
            // 
            this.text_custName.Location = new System.Drawing.Point(140, 34);
            this.text_custName.Name = "text_custName";
            this.text_custName.Size = new System.Drawing.Size(100, 20);
            this.text_custName.TabIndex = 8;
            // 
            // lbl_returndate
            // 
            this.lbl_returndate.AutoSize = true;
            this.lbl_returndate.Location = new System.Drawing.Point(7, 162);
            this.lbl_returndate.Name = "lbl_returndate";
            this.lbl_returndate.Size = new System.Drawing.Size(65, 13);
            this.lbl_returndate.TabIndex = 7;
            this.lbl_returndate.Text = "Return Date";
            // 
            // lbl_issuedate
            // 
            this.lbl_issuedate.AutoSize = true;
            this.lbl_issuedate.Location = new System.Drawing.Point(7, 120);
            this.lbl_issuedate.Name = "lbl_issuedate";
            this.lbl_issuedate.Size = new System.Drawing.Size(58, 13);
            this.lbl_issuedate.TabIndex = 6;
            this.lbl_issuedate.Text = "Issue Date";
            // 
            // lbl_Mname
            // 
            this.lbl_Mname.AutoSize = true;
            this.lbl_Mname.Location = new System.Drawing.Point(7, 79);
            this.lbl_Mname.Name = "lbl_Mname";
            this.lbl_Mname.Size = new System.Drawing.Size(67, 13);
            this.lbl_Mname.TabIndex = 5;
            this.lbl_Mname.Text = "Movie Name";
            // 
            // lbl_custname
            // 
            this.lbl_custname.AutoSize = true;
            this.lbl_custname.Location = new System.Drawing.Point(7, 38);
            this.lbl_custname.Name = "lbl_custname";
            this.lbl_custname.Size = new System.Drawing.Size(80, 13);
            this.lbl_custname.TabIndex = 4;
            this.lbl_custname.Text = "Customer name";
            // 
            // Lbl_Rental
            // 
            this.Lbl_Rental.AutoSize = true;
            this.Lbl_Rental.BackColor = System.Drawing.Color.Blue;
            this.Lbl_Rental.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Rental.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Lbl_Rental.Location = new System.Drawing.Point(83, 13);
            this.Lbl_Rental.Name = "Lbl_Rental";
            this.Lbl_Rental.Size = new System.Drawing.Size(90, 19);
            this.Lbl_Rental.TabIndex = 0;
            this.Lbl_Rental.Text = "Rental details";
            // 
            // Movie_panel
            // 
            this.Movie_panel.BackColor = System.Drawing.Color.White;
            this.Movie_panel.Controls.Add(this.Text_Rental_Cost);
            this.Movie_panel.Controls.Add(this.lbl_rentalcost);
            this.Movie_panel.Controls.Add(this.text_genre);
            this.Movie_panel.Controls.Add(this.text_plot);
            this.Movie_panel.Controls.Add(this.text_copies);
            this.Movie_panel.Controls.Add(this.text_year);
            this.Movie_panel.Controls.Add(this.text_Rating);
            this.Movie_panel.Controls.Add(this.text_Title);
            this.Movie_panel.Controls.Add(this.lbl_genre);
            this.Movie_panel.Controls.Add(this.lbl_plot);
            this.Movie_panel.Controls.Add(this.lbl_copies);
            this.Movie_panel.Controls.Add(this.lbl_year);
            this.Movie_panel.Controls.Add(this.lbl_Rating);
            this.Movie_panel.Controls.Add(this.lbl_Title);
            this.Movie_panel.Controls.Add(this.Btn_updatemovie);
            this.Movie_panel.Controls.Add(this.Btn_delmovie);
            this.Movie_panel.Controls.Add(this.Btn_addmovie);
            this.Movie_panel.Controls.Add(this.Lbl_Movie);
            this.Movie_panel.Location = new System.Drawing.Point(657, 57);
            this.Movie_panel.Name = "Movie_panel";
            this.Movie_panel.Size = new System.Drawing.Size(265, 421);
            this.Movie_panel.TabIndex = 3;
            // 
            // Text_Rental_Cost
            // 
            this.Text_Rental_Cost.Location = new System.Drawing.Point(146, 204);
            this.Text_Rental_Cost.Name = "Text_Rental_Cost";
            this.Text_Rental_Cost.Size = new System.Drawing.Size(100, 20);
            this.Text_Rental_Cost.TabIndex = 19;
            // 
            // lbl_rentalcost
            // 
            this.lbl_rentalcost.AutoSize = true;
            this.lbl_rentalcost.Location = new System.Drawing.Point(25, 207);
            this.lbl_rentalcost.Name = "lbl_rentalcost";
            this.lbl_rentalcost.Size = new System.Drawing.Size(62, 13);
            this.lbl_rentalcost.TabIndex = 18;
            this.lbl_rentalcost.Text = "Rental Cost";
            // 
            // text_genre
            // 
            this.text_genre.Location = new System.Drawing.Point(146, 343);
            this.text_genre.Name = "text_genre";
            this.text_genre.Size = new System.Drawing.Size(100, 20);
            this.text_genre.TabIndex = 17;
            // 
            // text_plot
            // 
            this.text_plot.Location = new System.Drawing.Point(146, 302);
            this.text_plot.Name = "text_plot";
            this.text_plot.Size = new System.Drawing.Size(100, 20);
            this.text_plot.TabIndex = 16;
            // 
            // text_copies
            // 
            this.text_copies.Location = new System.Drawing.Point(146, 247);
            this.text_copies.Name = "text_copies";
            this.text_copies.Size = new System.Drawing.Size(100, 20);
            this.text_copies.TabIndex = 15;
            // 
            // text_year
            // 
            this.text_year.Location = new System.Drawing.Point(146, 148);
            this.text_year.Name = "text_year";
            this.text_year.Size = new System.Drawing.Size(100, 20);
            this.text_year.TabIndex = 14;
            // 
            // text_Rating
            // 
            this.text_Rating.Location = new System.Drawing.Point(146, 54);
            this.text_Rating.Name = "text_Rating";
            this.text_Rating.Size = new System.Drawing.Size(100, 20);
            this.text_Rating.TabIndex = 13;
            // 
            // text_Title
            // 
            this.text_Title.Location = new System.Drawing.Point(146, 101);
            this.text_Title.Name = "text_Title";
            this.text_Title.Size = new System.Drawing.Size(100, 20);
            this.text_Title.TabIndex = 12;
            // 
            // lbl_genre
            // 
            this.lbl_genre.AutoSize = true;
            this.lbl_genre.Location = new System.Drawing.Point(34, 346);
            this.lbl_genre.Name = "lbl_genre";
            this.lbl_genre.Size = new System.Drawing.Size(36, 13);
            this.lbl_genre.TabIndex = 10;
            this.lbl_genre.Text = "Genre";
            // 
            // lbl_plot
            // 
            this.lbl_plot.AutoSize = true;
            this.lbl_plot.Location = new System.Drawing.Point(36, 305);
            this.lbl_plot.Name = "lbl_plot";
            this.lbl_plot.Size = new System.Drawing.Size(25, 13);
            this.lbl_plot.TabIndex = 9;
            this.lbl_plot.Text = "Plot";
            // 
            // lbl_copies
            // 
            this.lbl_copies.AutoSize = true;
            this.lbl_copies.Location = new System.Drawing.Point(31, 254);
            this.lbl_copies.Name = "lbl_copies";
            this.lbl_copies.Size = new System.Drawing.Size(39, 13);
            this.lbl_copies.TabIndex = 8;
            this.lbl_copies.Text = "Copies";
            // 
            // lbl_year
            // 
            this.lbl_year.AutoSize = true;
            this.lbl_year.Location = new System.Drawing.Point(34, 148);
            this.lbl_year.Name = "lbl_year";
            this.lbl_year.Size = new System.Drawing.Size(29, 13);
            this.lbl_year.TabIndex = 7;
            this.lbl_year.Text = "Year";
            // 
            // lbl_Rating
            // 
            this.lbl_Rating.AutoSize = true;
            this.lbl_Rating.Location = new System.Drawing.Point(31, 54);
            this.lbl_Rating.Name = "lbl_Rating";
            this.lbl_Rating.Size = new System.Drawing.Size(38, 13);
            this.lbl_Rating.TabIndex = 6;
            this.lbl_Rating.Text = "Rating";
            // 
            // lbl_Title
            // 
            this.lbl_Title.AutoSize = true;
            this.lbl_Title.Location = new System.Drawing.Point(31, 101);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(27, 13);
            this.lbl_Title.TabIndex = 5;
            this.lbl_Title.Text = "Title";
            // 
            // Btn_updatemovie
            // 
            this.Btn_updatemovie.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Btn_updatemovie.ForeColor = System.Drawing.SystemColors.Control;
            this.Btn_updatemovie.Location = new System.Drawing.Point(187, 381);
            this.Btn_updatemovie.Name = "Btn_updatemovie";
            this.Btn_updatemovie.Size = new System.Drawing.Size(75, 37);
            this.Btn_updatemovie.TabIndex = 3;
            this.Btn_updatemovie.Text = "Update ";
            this.Btn_updatemovie.UseVisualStyleBackColor = false;
            this.Btn_updatemovie.Click += new System.EventHandler(this.Btn_updatemovie_Click);
            // 
            // Btn_delmovie
            // 
            this.Btn_delmovie.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Btn_delmovie.ForeColor = System.Drawing.SystemColors.Control;
            this.Btn_delmovie.Location = new System.Drawing.Point(105, 379);
            this.Btn_delmovie.Name = "Btn_delmovie";
            this.Btn_delmovie.Size = new System.Drawing.Size(75, 39);
            this.Btn_delmovie.TabIndex = 2;
            this.Btn_delmovie.Text = "Delete ";
            this.Btn_delmovie.UseVisualStyleBackColor = false;
            this.Btn_delmovie.Click += new System.EventHandler(this.Btn_delmovie_Click);
            // 
            // Btn_addmovie
            // 
            this.Btn_addmovie.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Btn_addmovie.ForeColor = System.Drawing.SystemColors.Control;
            this.Btn_addmovie.Location = new System.Drawing.Point(12, 379);
            this.Btn_addmovie.Name = "Btn_addmovie";
            this.Btn_addmovie.Size = new System.Drawing.Size(75, 40);
            this.Btn_addmovie.TabIndex = 1;
            this.Btn_addmovie.Text = "Add";
            this.Btn_addmovie.UseVisualStyleBackColor = false;
            this.Btn_addmovie.Click += new System.EventHandler(this.Btn_addmovie_Click);
            // 
            // Lbl_Movie
            // 
            this.Lbl_Movie.AutoSize = true;
            this.Lbl_Movie.BackColor = System.Drawing.Color.Blue;
            this.Lbl_Movie.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Movie.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Lbl_Movie.Location = new System.Drawing.Point(111, 18);
            this.Lbl_Movie.Name = "Lbl_Movie";
            this.Lbl_Movie.Size = new System.Drawing.Size(90, 19);
            this.Lbl_Movie.TabIndex = 0;
            this.Lbl_Movie.Text = "Movie details";
            // 
            // btn_allrented
            // 
            this.btn_allrented.BackColor = System.Drawing.Color.Cornsilk;
            this.btn_allrented.Location = new System.Drawing.Point(54, 461);
            this.btn_allrented.Name = "btn_allrented";
            this.btn_allrented.Size = new System.Drawing.Size(115, 41);
            this.btn_allrented.TabIndex = 4;
            this.btn_allrented.Text = "All Rented";
            this.btn_allrented.UseVisualStyleBackColor = false;
            this.btn_allrented.Click += new System.EventHandler(this.btn_allrented_Click);
            // 
            // btn_rentedout
            // 
            this.btn_rentedout.BackColor = System.Drawing.Color.Cornsilk;
            this.btn_rentedout.Location = new System.Drawing.Point(185, 461);
            this.btn_rentedout.Name = "btn_rentedout";
            this.btn_rentedout.Size = new System.Drawing.Size(133, 41);
            this.btn_rentedout.TabIndex = 5;
            this.btn_rentedout.Text = "Rented out";
            this.btn_rentedout.UseVisualStyleBackColor = false;
            this.btn_rentedout.Click += new System.EventHandler(this.btn_rentedout_Click);
            // 
            // Video_Rental
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(922, 537);
            this.Controls.Add(this.btn_rentedout);
            this.Controls.Add(this.btn_allrented);
            this.Controls.Add(this.Movie_panel);
            this.Controls.Add(this.Rental_panel);
            this.Controls.Add(this.Customer_panel);
            this.Controls.Add(this.tab_Movie_rental);
            this.Name = "Video_Rental";
            this.Text = "Video_Rental";
            this.tab_Movie_rental.ResumeLayout(false);
            this.tab_Customer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Customer)).EndInit();
            this.tab_Movie.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_movie)).EndInit();
            this.tab_Rental.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Rental)).EndInit();
            this.tb_popularcustomer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_popularcustomer)).EndInit();
            this.tab_popularmovie.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_popularmovie)).EndInit();
            this.Customer_panel.ResumeLayout(false);
            this.Customer_panel.PerformLayout();
            this.Rental_panel.ResumeLayout(false);
            this.Rental_panel.PerformLayout();
            this.Movie_panel.ResumeLayout(false);
            this.Movie_panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tab_Movie_rental;
        private System.Windows.Forms.TabPage tab_Customer;
        private System.Windows.Forms.TabPage tab_Movie;
        private System.Windows.Forms.TabPage tab_Rental;
        private System.Windows.Forms.DataGridView DGV_Customer;
        private System.Windows.Forms.DataGridView DGV_movie;
        private System.Windows.Forms.DataGridView DGV_Rental;
        private System.Windows.Forms.Panel Customer_panel;
        private System.Windows.Forms.Panel Rental_panel;
        private System.Windows.Forms.Panel Movie_panel;
        private System.Windows.Forms.Label Lbl_customer;
        private System.Windows.Forms.Label Lbl_Rental;
        private System.Windows.Forms.Label Lbl_Movie;
        private System.Windows.Forms.Button Btn_Update_customdata;
        private System.Windows.Forms.Button Btn_del_customer;
        private System.Windows.Forms.Button Btn_Add_customer;
        private System.Windows.Forms.Button Btn_updatemovie;
        private System.Windows.Forms.Button Btn_delmovie;
        private System.Windows.Forms.Button Btn_addmovie;
        private System.Windows.Forms.Label lbl_address;
        private System.Windows.Forms.Label lbl_Phone;
        private System.Windows.Forms.Label lbl_lastname;
        private System.Windows.Forms.Label lbl_firstname;
        private System.Windows.Forms.TextBox text_address;
        private System.Windows.Forms.TextBox text_lastname;
        private System.Windows.Forms.TextBox text_firstname;
        private System.Windows.Forms.TextBox text_mobile;
        private System.Windows.Forms.Label lbl_plot;
        private System.Windows.Forms.Label lbl_copies;
        private System.Windows.Forms.Label lbl_year;
        private System.Windows.Forms.Label lbl_Rating;
        private System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.Label lbl_genre;
        private System.Windows.Forms.TextBox text_year;
        private System.Windows.Forms.TextBox text_Rating;
        private System.Windows.Forms.TextBox text_Title;
        private System.Windows.Forms.TextBox text_plot;
        private System.Windows.Forms.TextBox text_copies;
        private System.Windows.Forms.TextBox text_genre;
        private System.Windows.Forms.DateTimePicker issue_datePicker;
        private System.Windows.Forms.TextBox text_TitleM;
        private System.Windows.Forms.TextBox text_custName;
        private System.Windows.Forms.Label lbl_returndate;
        private System.Windows.Forms.Label lbl_issuedate;
        private System.Windows.Forms.Label lbl_Mname;
        private System.Windows.Forms.Label lbl_custname;
        private System.Windows.Forms.DateTimePicker Return_datePicker;
        private System.Windows.Forms.TextBox Text_Rental_Cost;
        private System.Windows.Forms.Label lbl_rentalcost;
        private System.Windows.Forms.Button Btn_Return;
        private System.Windows.Forms.Button btn_Issue;
        private System.Windows.Forms.Button btn_allrented;
        private System.Windows.Forms.Button btn_rentedout;
        private System.Windows.Forms.TabPage tb_popularcustomer;
        private System.Windows.Forms.DataGridView DGV_popularcustomer;
        private System.Windows.Forms.TabPage tab_popularmovie;
        private System.Windows.Forms.DataGridView DGV_popularmovie;
    }
}

