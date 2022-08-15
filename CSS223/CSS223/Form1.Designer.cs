namespace CSS223
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
            this.components = new System.ComponentModel.Container();
            this.lblNumbr = new System.Windows.Forms.Label();
            this.lblInventoryNumber = new System.Windows.Forms.Label();
            this.lblCount = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblObjectName = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.txt_number = new System.Windows.Forms.TextBox();
            this.txt_inv = new System.Windows.Forms.TextBox();
            this.txt_count = new System.Windows.Forms.TextBox();
            this.txt_price = new System.Windows.Forms.TextBox();
            this.txt_obj = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.errPro = new System.Windows.Forms.ErrorProvider(this.components);
            this.chkAvailability = new System.Windows.Forms.CheckBox();
            this.chklst = new System.Windows.Forms.CheckedListBox();
            this.rbu = new System.Windows.Forms.RadioButton();
            this.rbnu = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errPro)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNumbr
            // 
            this.lblNumbr.AutoSize = true;
            this.lblNumbr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumbr.Location = new System.Drawing.Point(40, 39);
            this.lblNumbr.Name = "lblNumbr";
            this.lblNumbr.Size = new System.Drawing.Size(81, 25);
            this.lblNumbr.TabIndex = 0;
            this.lblNumbr.Text = "Number";
            this.lblNumbr.Click += new System.EventHandler(this.lblNumbr_Click);
            // 
            // lblInventoryNumber
            // 
            this.lblInventoryNumber.AutoSize = true;
            this.lblInventoryNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInventoryNumber.Location = new System.Drawing.Point(40, 117);
            this.lblInventoryNumber.Name = "lblInventoryNumber";
            this.lblInventoryNumber.Size = new System.Drawing.Size(166, 25);
            this.lblInventoryNumber.TabIndex = 1;
            this.lblInventoryNumber.Text = "Inventory Number";
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCount.Location = new System.Drawing.Point(40, 206);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(65, 25);
            this.lblCount.TabIndex = 2;
            this.lblCount.Text = "Count";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(262, 39);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(53, 25);
            this.lblDate.TabIndex = 3;
            this.lblDate.Text = "Date";
            // 
            // lblObjectName
            // 
            this.lblObjectName.AutoSize = true;
            this.lblObjectName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblObjectName.Location = new System.Drawing.Point(262, 117);
            this.lblObjectName.Name = "lblObjectName";
            this.lblObjectName.Size = new System.Drawing.Size(126, 25);
            this.lblObjectName.TabIndex = 4;
            this.lblObjectName.Text = "Object Name";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.Location = new System.Drawing.Point(262, 206);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(56, 25);
            this.lblPrice.TabIndex = 5;
            this.lblPrice.Text = "Price";
            // 
            // txt_number
            // 
            this.txt_number.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_number.Location = new System.Drawing.Point(45, 67);
            this.txt_number.Name = "txt_number";
            this.txt_number.Size = new System.Drawing.Size(161, 30);
            this.txt_number.TabIndex = 6;
            this.txt_number.TextChanged += new System.EventHandler(this.txt_number_TextChanged);
            // 
            // txt_inv
            // 
            this.txt_inv.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_inv.Location = new System.Drawing.Point(45, 154);
            this.txt_inv.Name = "txt_inv";
            this.txt_inv.Size = new System.Drawing.Size(161, 30);
            this.txt_inv.TabIndex = 7;
            // 
            // txt_count
            // 
            this.txt_count.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_count.Location = new System.Drawing.Point(45, 234);
            this.txt_count.Name = "txt_count";
            this.txt_count.Size = new System.Drawing.Size(161, 30);
            this.txt_count.TabIndex = 8;
            // 
            // txt_price
            // 
            this.txt_price.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_price.Location = new System.Drawing.Point(267, 234);
            this.txt_price.Name = "txt_price";
            this.txt_price.Size = new System.Drawing.Size(209, 30);
            this.txt_price.TabIndex = 9;
            this.txt_price.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // txt_obj
            // 
            this.txt_obj.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_obj.Location = new System.Drawing.Point(267, 154);
            this.txt_obj.Name = "txt_obj";
            this.txt_obj.Size = new System.Drawing.Size(209, 30);
            this.txt_obj.TabIndex = 10;
            this.txt_obj.TextChanged += new System.EventHandler(this.txt_obj_TextChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(267, 67);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 30);
            this.dateTimePicker1.TabIndex = 11;
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(630, 337);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(111, 45);
            this.btnAdd.TabIndex = 12;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(983, 337);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(111, 45);
            this.btnCancel.TabIndex = 13;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // dgv
            // 
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(482, 39);
            this.dgv.Name = "dgv";
            this.dgv.RowHeadersWidth = 51;
            this.dgv.RowTemplate.Height = 24;
            this.dgv.Size = new System.Drawing.Size(729, 246);
            this.dgv.TabIndex = 14;
            // 
            // errPro
            // 
            this.errPro.ContainerControl = this;
            // 
            // chkAvailability
            // 
            this.chkAvailability.AutoSize = true;
            this.chkAvailability.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkAvailability.Location = new System.Drawing.Point(12, 287);
            this.chkAvailability.Name = "chkAvailability";
            this.chkAvailability.Size = new System.Drawing.Size(129, 29);
            this.chkAvailability.TabIndex = 15;
            this.chkAvailability.Text = "IsAvailable";
            this.chkAvailability.UseVisualStyleBackColor = true;
            // 
            // chklst
            // 
            this.chklst.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chklst.FormattingEnabled = true;
            this.chklst.Items.AddRange(new object[] {
            "Transportation",
            "Instalation",
            "Loading"});
            this.chklst.Location = new System.Drawing.Point(152, 287);
            this.chklst.Name = "chklst";
            this.chklst.Size = new System.Drawing.Size(163, 79);
            this.chklst.TabIndex = 16;
            this.chklst.SelectedIndexChanged += new System.EventHandler(this.chklst_SelectedIndexChanged);
            // 
            // rbu
            // 
            this.rbu.AutoSize = true;
            this.rbu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbu.Location = new System.Drawing.Point(334, 287);
            this.rbu.Name = "rbu";
            this.rbu.Size = new System.Drawing.Size(91, 29);
            this.rbu.TabIndex = 17;
            this.rbu.TabStop = true;
            this.rbu.Text = "Urgent";
            this.rbu.UseVisualStyleBackColor = true;
            // 
            // rbnu
            // 
            this.rbnu.AutoSize = true;
            this.rbnu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbnu.Location = new System.Drawing.Point(334, 314);
            this.rbnu.Name = "rbnu";
            this.rbnu.Size = new System.Drawing.Size(126, 29);
            this.rbnu.TabIndex = 18;
            this.rbnu.TabStop = true;
            this.rbnu.Text = "Not Urgent";
            this.rbnu.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1223, 416);
            this.Controls.Add(this.rbnu);
            this.Controls.Add(this.rbu);
            this.Controls.Add(this.chklst);
            this.Controls.Add(this.chkAvailability);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.txt_obj);
            this.Controls.Add(this.txt_price);
            this.Controls.Add(this.txt_count);
            this.Controls.Add(this.txt_inv);
            this.Controls.Add(this.txt_number);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblObjectName);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblCount);
            this.Controls.Add(this.lblInventoryNumber);
            this.Controls.Add(this.lblNumbr);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errPro)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNumbr;
        private System.Windows.Forms.Label lblInventoryNumber;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblObjectName;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.TextBox txt_number;
        private System.Windows.Forms.TextBox txt_inv;
        private System.Windows.Forms.TextBox txt_count;
        private System.Windows.Forms.TextBox txt_price;
        private System.Windows.Forms.TextBox txt_obj;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.ErrorProvider errPro;
        private System.Windows.Forms.CheckBox chkAvailability;
        private System.Windows.Forms.CheckedListBox chklst;
        private System.Windows.Forms.RadioButton rbnu;
        private System.Windows.Forms.RadioButton rbu;
    }
}

