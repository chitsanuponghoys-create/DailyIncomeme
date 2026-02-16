namespace DailyIncomeme
{
    public partial class โปรแกรมบันทึกรายรับประจำวัน : Form
    {
        public โปรแกรมบันทึกรายรับประจำวัน()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cboCategory.Items.Add("เงินเดือน");
            cboCategory.Items.Add("ขายของ");
            cboCategory.Items.Add("อื่น ๆ");

            cboPaymentMethod.Items.Add("เงินสด");
            cboPaymentMethod.Items.Add("โอน");
            cboPaymentMethod.Items.Add("บัตร");
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtIncomeID.Text == "" || txtIncomeName.Text == "")
            {
                MessageBox.Show("กรุณากรอกข้อมูลให้ครบ");
                return;
            }

            MessageBox.Show(
                "รหัสรายการ: " + txtIncomeID.Text + "\n" +
                "ชื่อรายการ: " + txtIncomeName.Text + "\n" +
                "หมวดหมู่: " + cboCategory.Text + "\n" +
                "วิธีรับเงิน: " + cboPaymentMethod.Text
            );
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtAmount_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblType_Click(object sender, EventArgs e)
        {

        }
    }
}
