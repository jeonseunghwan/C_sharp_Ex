namespace C_sharp_Ex
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void Btn_Show_All_Data_Type_Click(object sender, EventArgs e)
        {
            // �̰� �߰� ��
            // 20231029
            String A = "aA123!@#";
            float B = 123.434f;
            double C = 0.12345;

            MessageBox.Show(
                A + "\n" + 
                B.ToString() + "\n" +
                float.MaxValue + "\n" +
                C.ToString()+"\n" +
                double.MaxValue
                );

            MessageBox.Show($"�̷��� {B}  ǥ�� {C}  ����");
        }
    }
}