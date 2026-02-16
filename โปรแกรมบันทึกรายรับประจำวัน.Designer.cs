namespace DailyIncomeme
{
    partial class โปรแกรมบันทึกรายรับประจำวัน
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtIncomeID = new TextBox();
            lblIncomeName = new Label();
            cboCategory = new ComboBox();
            btnAdd = new Button();
            incomeid = new Label();
            txtIncomeName = new TextBox();
            label3 = new Label();
            lblType = new Label();
            cboPaymentMethod = new ComboBox();
            SuspendLayout();
            // 
            // txtIncomeID
            // 
            txtIncomeID.AccessibleName = "txtIncomeID";
            txtIncomeID.Location = new Point(559, 147);
            txtIncomeID.Name = "txtIncomeID";
            txtIncomeID.Size = new Size(100, 23);
            txtIncomeID.TabIndex = 0;
            txtIncomeID.TextChanged += textBox1_TextChanged;
            // 
            // lblIncomeName
            // 
            lblIncomeName.AutoSize = true;
            lblIncomeName.Location = new Point(489, 150);
            lblIncomeName.Name = "lblIncomeName";
            lblIncomeName.Size = new Size(53, 15);
            lblIncomeName.TabIndex = 1;
            lblIncomeName.Text = "ชื่อรายการ";
            lblIncomeName.Click += label1_Click;
            // 
            // cboCategory
            // 
            cboCategory.FormattingEnabled = true;
            cboCategory.Location = new Point(559, 189);
            cboCategory.Name = "cboCategory";
            cboCategory.Size = new Size(121, 23);
            cboCategory.TabIndex = 2;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(569, 269);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 3;
            btnAdd.Text = "เพิ่มรายการ";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // incomeid
            // 
            incomeid.AutoSize = true;
            incomeid.Location = new Point(483, 113);
            incomeid.Name = "incomeid";
            incomeid.Size = new Size(53, 15);
            incomeid.TabIndex = 4;
            incomeid.Text = "รหัสรายรับ";
            incomeid.Click += label2_Click;
            // 
            // txtIncomeName
            // 
            txtIncomeName.Location = new Point(559, 110);
            txtIncomeName.Name = "txtIncomeName";
            txtIncomeName.Size = new Size(100, 23);
            txtIncomeName.TabIndex = 5;
            txtIncomeName.Text = " ";
            txtIncomeName.TextChanged += textBox2_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(483, 229);
            label3.Name = "label3";
            label3.Size = new Size(52, 15);
            label3.TabIndex = 7;
            label3.Text = "จำนวนเงิน";
            label3.Click += label3_Click;
            // 
            // lblType
            // 
            lblType.AutoSize = true;
            lblType.Location = new Point(478, 189);
            lblType.Name = "lblType";
            lblType.Size = new Size(64, 15);
            lblType.TabIndex = 8;
            lblType.Text = " หมวดรายรับ";
            lblType.Click += lblType_Click;
            // 
            // cboPaymentMethod
            // 
            cboPaymentMethod.FormattingEnabled = true;
            cboPaymentMethod.Location = new Point(559, 229);
            cboPaymentMethod.Name = "cboPaymentMethod";
            cboPaymentMethod.Size = new Size(121, 23);
            cboPaymentMethod.TabIndex = 9;
            // 
            // โปรแกรมบันทึกรายรับประจำวัน
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(cboPaymentMethod);
            Controls.Add(lblType);
            Controls.Add(label3);
            Controls.Add(txtIncomeName);
            Controls.Add(incomeid);
            Controls.Add(btnAdd);
            Controls.Add(cboCategory);
            Controls.Add(lblIncomeName);
            Controls.Add(txtIncomeID);
            Name = "โปรแกรมบันทึกรายรับประจำวัน";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtIncomeID;
        private Label lblIncomeName;
        private ComboBox cboCategory;
        private Button btnAdd;
        private Label incomeid;
        private TextBox txtIncomeName;
        private Label label3;
        private Label lblType;
        private ComboBox cboPaymentMethod;
    }
}
