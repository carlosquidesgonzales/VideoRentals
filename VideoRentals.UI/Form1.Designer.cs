namespace VideoRentals.UI
{
    partial class Form1
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabData = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cboG = new System.Windows.Forms.ComboBox();
            this.datePicker = new System.Windows.Forms.DateTimePicker();
            this.cboMV = new System.Windows.Forms.ComboBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.btnDeleteV = new System.Windows.Forms.Button();
            this.btnUpdateV = new System.Windows.Forms.Button();
            this.btnAddV = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cboMC = new System.Windows.Forms.ComboBox();
            this.txtEm = new System.Windows.Forms.TextBox();
            this.txtPh = new System.Windows.Forms.TextBox();
            this.txtLN = new System.Windows.Forms.TextBox();
            this.txtFN = new System.Windows.Forms.TextBox();
            this.btnDeleteC = new System.Windows.Forms.Button();
            this.btnUpdateC = new System.Windows.Forms.Button();
            this.btnAddC = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabRent = new System.Windows.Forms.TabPage();
            this.lblC = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.btnRent = new System.Windows.Forms.Button();
            this.cboRG = new System.Windows.Forms.ComboBox();
            this.cboRV = new System.Windows.Forms.ComboBox();
            this.cboRC = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.tabHistory = new System.Windows.Forms.TabPage();
            this.lstR = new System.Windows.Forms.ListView();
            this.rbReturned = new System.Windows.Forms.RadioButton();
            this.rbRented = new System.Windows.Forms.RadioButton();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.tabControl1.SuspendLayout();
            this.tabData.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabRent.SuspendLayout();
            this.tabHistory.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabData);
            this.tabControl1.Controls.Add(this.tabRent);
            this.tabControl1.Controls.Add(this.tabHistory);
            this.tabControl1.Location = new System.Drawing.Point(61, 48);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(2565, 1032);
            this.tabControl1.TabIndex = 1;
            // 
            // tabData
            // 
            this.tabData.Controls.Add(this.groupBox2);
            this.tabData.Controls.Add(this.groupBox1);
            this.tabData.Location = new System.Drawing.Point(12, 58);
            this.tabData.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tabData.Name = "tabData";
            this.tabData.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tabData.Size = new System.Drawing.Size(2541, 962);
            this.tabData.TabIndex = 0;
            this.tabData.Text = "Add Data";
            this.tabData.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cboG);
            this.groupBox2.Controls.Add(this.datePicker);
            this.groupBox2.Controls.Add(this.cboMV);
            this.groupBox2.Controls.Add(this.txtPrice);
            this.groupBox2.Controls.Add(this.txtTitle);
            this.groupBox2.Controls.Add(this.btnDeleteV);
            this.groupBox2.Controls.Add(this.btnUpdateV);
            this.groupBox2.Controls.Add(this.btnAddV);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(819, 46);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBox2.Size = new System.Drawing.Size(730, 670);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Modify Video";
            // 
            // cboG
            // 
            this.cboG.FormattingEnabled = true;
            this.cboG.Location = new System.Drawing.Point(236, 259);
            this.cboG.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.cboG.Name = "cboG";
            this.cboG.Size = new System.Drawing.Size(416, 45);
            this.cboG.TabIndex = 17;
            // 
            // datePicker
            // 
            this.datePicker.Location = new System.Drawing.Point(236, 346);
            this.datePicker.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(418, 44);
            this.datePicker.TabIndex = 6;
            // 
            // cboMV
            // 
            this.cboMV.FormattingEnabled = true;
            this.cboMV.Location = new System.Drawing.Point(236, 89);
            this.cboMV.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.cboMV.Name = "cboMV";
            this.cboMV.Size = new System.Drawing.Size(416, 45);
            this.cboMV.TabIndex = 16;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(236, 411);
            this.txtPrice.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(416, 44);
            this.txtPrice.TabIndex = 15;
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(236, 174);
            this.txtTitle.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(416, 44);
            this.txtTitle.TabIndex = 12;
            // 
            // btnDeleteV
            // 
            this.btnDeleteV.Location = new System.Drawing.Point(460, 509);
            this.btnDeleteV.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnDeleteV.Name = "btnDeleteV";
            this.btnDeleteV.Size = new System.Drawing.Size(196, 78);
            this.btnDeleteV.TabIndex = 10;
            this.btnDeleteV.Text = "Delete";
            this.btnDeleteV.UseVisualStyleBackColor = true;
            // 
            // btnUpdateV
            // 
            this.btnUpdateV.Location = new System.Drawing.Point(251, 509);
            this.btnUpdateV.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnUpdateV.Name = "btnUpdateV";
            this.btnUpdateV.Size = new System.Drawing.Size(196, 78);
            this.btnUpdateV.TabIndex = 9;
            this.btnUpdateV.Text = "Update";
            this.btnUpdateV.UseVisualStyleBackColor = true;
            // 
            // btnAddV
            // 
            this.btnAddV.Location = new System.Drawing.Point(42, 509);
            this.btnAddV.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnAddV.Name = "btnAddV";
            this.btnAddV.Size = new System.Drawing.Size(196, 78);
            this.btnAddV.TabIndex = 8;
            this.btnAddV.Text = "Add";
            this.btnAddV.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(63, 259);
            this.label10.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(110, 37);
            this.label10.TabIndex = 7;
            this.label10.Text = "Genre";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(63, 422);
            this.label9.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(94, 37);
            this.label9.TabIndex = 6;
            this.label9.Text = "Price";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(63, 346);
            this.label8.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 37);
            this.label8.TabIndex = 5;
            this.label8.Text = "Year";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(63, 174);
            this.label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 37);
            this.label7.TabIndex = 4;
            this.label7.Text = "Title";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(63, 89);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 37);
            this.label6.TabIndex = 3;
            this.label6.Text = "Video";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cboMC);
            this.groupBox1.Controls.Add(this.txtEm);
            this.groupBox1.Controls.Add(this.txtPh);
            this.groupBox1.Controls.Add(this.txtLN);
            this.groupBox1.Controls.Add(this.txtFN);
            this.groupBox1.Controls.Add(this.btnDeleteC);
            this.groupBox1.Controls.Add(this.btnUpdateC);
            this.groupBox1.Controls.Add(this.btnAddC);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(51, 46);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBox1.Size = new System.Drawing.Size(730, 670);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Modify Customer";
            // 
            // cboMC
            // 
            this.cboMC.FormattingEnabled = true;
            this.cboMC.Location = new System.Drawing.Point(258, 89);
            this.cboMC.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.cboMC.Name = "cboMC";
            this.cboMC.Size = new System.Drawing.Size(416, 45);
            this.cboMC.TabIndex = 12;
            // 
            // txtEm
            // 
            this.txtEm.Location = new System.Drawing.Point(258, 411);
            this.txtEm.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtEm.Name = "txtEm";
            this.txtEm.Size = new System.Drawing.Size(416, 44);
            this.txtEm.TabIndex = 11;
            // 
            // txtPh
            // 
            this.txtPh.Location = new System.Drawing.Point(258, 335);
            this.txtPh.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtPh.Name = "txtPh";
            this.txtPh.Size = new System.Drawing.Size(416, 44);
            this.txtPh.TabIndex = 10;
            // 
            // txtLN
            // 
            this.txtLN.Location = new System.Drawing.Point(258, 248);
            this.txtLN.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtLN.Name = "txtLN";
            this.txtLN.Size = new System.Drawing.Size(416, 44);
            this.txtLN.TabIndex = 9;
            // 
            // txtFN
            // 
            this.txtFN.Location = new System.Drawing.Point(258, 174);
            this.txtFN.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtFN.Name = "txtFN";
            this.txtFN.Size = new System.Drawing.Size(416, 44);
            this.txtFN.TabIndex = 8;
            // 
            // btnDeleteC
            // 
            this.btnDeleteC.Location = new System.Drawing.Point(490, 509);
            this.btnDeleteC.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnDeleteC.Name = "btnDeleteC";
            this.btnDeleteC.Size = new System.Drawing.Size(196, 78);
            this.btnDeleteC.TabIndex = 7;
            this.btnDeleteC.Text = "Delete";
            this.btnDeleteC.UseVisualStyleBackColor = true;
            // 
            // btnUpdateC
            // 
            this.btnUpdateC.Location = new System.Drawing.Point(281, 509);
            this.btnUpdateC.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnUpdateC.Name = "btnUpdateC";
            this.btnUpdateC.Size = new System.Drawing.Size(196, 78);
            this.btnUpdateC.TabIndex = 6;
            this.btnUpdateC.Text = "Update";
            this.btnUpdateC.UseVisualStyleBackColor = true;
            // 
            // btnAddC
            // 
            this.btnAddC.Location = new System.Drawing.Point(68, 509);
            this.btnAddC.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnAddC.Name = "btnAddC";
            this.btnAddC.Size = new System.Drawing.Size(196, 78);
            this.btnAddC.TabIndex = 5;
            this.btnAddC.Text = "Add";
            this.btnAddC.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(17, 416);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 37);
            this.label5.TabIndex = 4;
            this.label5.Text = "E-mail";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(15, 340);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 37);
            this.label4.TabIndex = 3;
            this.label4.Text = "Phone";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 253);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(182, 37);
            this.label3.TabIndex = 2;
            this.label3.Text = "Last Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 174);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(185, 37);
            this.label2.TabIndex = 1;
            this.label2.Text = "First Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 89);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Customer";
            // 
            // tabRent
            // 
            this.tabRent.Controls.Add(this.checkBox1);
            this.tabRent.Controls.Add(this.lblC);
            this.tabRent.Controls.Add(this.label12);
            this.tabRent.Controls.Add(this.btnRent);
            this.tabRent.Controls.Add(this.cboRG);
            this.tabRent.Controls.Add(this.cboRV);
            this.tabRent.Controls.Add(this.cboRC);
            this.tabRent.Controls.Add(this.label14);
            this.tabRent.Controls.Add(this.label13);
            this.tabRent.Controls.Add(this.label11);
            this.tabRent.Location = new System.Drawing.Point(12, 58);
            this.tabRent.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tabRent.Name = "tabRent";
            this.tabRent.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tabRent.Size = new System.Drawing.Size(2541, 962);
            this.tabRent.TabIndex = 1;
            this.tabRent.Text = "Rent a video";
            this.tabRent.UseVisualStyleBackColor = true;
            // 
            // lblC
            // 
            this.lblC.AutoSize = true;
            this.lblC.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblC.Location = new System.Drawing.Point(262, 327);
            this.lblC.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblC.Name = "lblC";
            this.lblC.Size = new System.Drawing.Size(0, 37);
            this.lblC.TabIndex = 18;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(21, 327);
            this.label12.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(87, 37);
            this.label12.TabIndex = 17;
            this.label12.Text = "Cost";
            // 
            // btnRent
            // 
            this.btnRent.Location = new System.Drawing.Point(471, 457);
            this.btnRent.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnRent.Name = "btnRent";
            this.btnRent.Size = new System.Drawing.Size(196, 78);
            this.btnRent.TabIndex = 16;
            this.btnRent.Text = "Rent";
            this.btnRent.UseVisualStyleBackColor = true;
            // 
            // cboRG
            // 
            this.cboRG.FormattingEnabled = true;
            this.cboRG.Location = new System.Drawing.Point(247, 150);
            this.cboRG.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.cboRG.Name = "cboRG";
            this.cboRG.Size = new System.Drawing.Size(416, 45);
            this.cboRG.TabIndex = 15;
            // 
            // cboRV
            // 
            this.cboRV.FormattingEnabled = true;
            this.cboRV.Location = new System.Drawing.Point(247, 231);
            this.cboRV.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.cboRV.Name = "cboRV";
            this.cboRV.Size = new System.Drawing.Size(416, 45);
            this.cboRV.TabIndex = 14;
            // 
            // cboRC
            // 
            this.cboRC.FormattingEnabled = true;
            this.cboRC.Location = new System.Drawing.Point(247, 70);
            this.cboRC.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.cboRC.Name = "cboRC";
            this.cboRC.Size = new System.Drawing.Size(416, 45);
            this.cboRC.TabIndex = 13;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(21, 237);
            this.label14.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(104, 37);
            this.label14.TabIndex = 4;
            this.label14.Text = "Video";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(13, 155);
            this.label13.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(110, 37);
            this.label13.TabIndex = 3;
            this.label13.Text = "Genre";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(13, 70);
            this.label11.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(164, 37);
            this.label11.TabIndex = 1;
            this.label11.Text = "Customer";
            // 
            // tabHistory
            // 
            this.tabHistory.Controls.Add(this.lstR);
            this.tabHistory.Controls.Add(this.rbReturned);
            this.tabHistory.Controls.Add(this.rbRented);
            this.tabHistory.Location = new System.Drawing.Point(12, 58);
            this.tabHistory.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tabHistory.Name = "tabHistory";
            this.tabHistory.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tabHistory.Size = new System.Drawing.Size(2541, 962);
            this.tabHistory.TabIndex = 2;
            this.tabHistory.Text = "History";
            this.tabHistory.UseVisualStyleBackColor = true;
            // 
            // lstR
            // 
            this.lstR.Location = new System.Drawing.Point(42, 146);
            this.lstR.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.lstR.Name = "lstR";
            this.lstR.Size = new System.Drawing.Size(853, 652);
            this.lstR.TabIndex = 2;
            this.lstR.UseCompatibleStateImageBehavior = false;
            // 
            // rbReturned
            // 
            this.rbReturned.AutoSize = true;
            this.rbReturned.Location = new System.Drawing.Point(344, 65);
            this.rbReturned.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.rbReturned.Name = "rbReturned";
            this.rbReturned.Size = new System.Drawing.Size(191, 41);
            this.rbReturned.TabIndex = 1;
            this.rbReturned.TabStop = true;
            this.rbReturned.Text = "Returned";
            this.rbReturned.UseVisualStyleBackColor = true;
            // 
            // rbRented
            // 
            this.rbRented.AutoSize = true;
            this.rbRented.Location = new System.Drawing.Point(42, 65);
            this.rbRented.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.rbRented.Name = "rbRented";
            this.rbRented.Size = new System.Drawing.Size(162, 41);
            this.rbRented.TabIndex = 0;
            this.rbRented.TabStop = true;
            this.rbRented.Text = "Rented";
            this.rbRented.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(1264, 243);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(216, 41);
            this.checkBox1.TabIndex = 19;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2776, 1191);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabData.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabRent.ResumeLayout(false);
            this.tabRent.PerformLayout();
            this.tabHistory.ResumeLayout(false);
            this.tabHistory.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabData;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cboG;
        private System.Windows.Forms.DateTimePicker datePicker;
        private System.Windows.Forms.ComboBox cboMV;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Button btnDeleteV;
        private System.Windows.Forms.Button btnUpdateV;
        private System.Windows.Forms.Button btnAddV;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cboMC;
        private System.Windows.Forms.TextBox txtEm;
        private System.Windows.Forms.TextBox txtPh;
        private System.Windows.Forms.TextBox txtLN;
        private System.Windows.Forms.TextBox txtFN;
        private System.Windows.Forms.Button btnDeleteC;
        private System.Windows.Forms.Button btnUpdateC;
        private System.Windows.Forms.Button btnAddC;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabRent;
        private System.Windows.Forms.Label lblC;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnRent;
        private System.Windows.Forms.ComboBox cboRG;
        private System.Windows.Forms.ComboBox cboRV;
        private System.Windows.Forms.ComboBox cboRC;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TabPage tabHistory;
        private System.Windows.Forms.ListView lstR;
        private System.Windows.Forms.RadioButton rbReturned;
        private System.Windows.Forms.RadioButton rbRented;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}

