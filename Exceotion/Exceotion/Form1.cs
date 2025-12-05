namespace Exceotion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // 텍스트인풋에 닉네임을 입력하지 않거나
                // 2글자 미만이거나
                // admin이 포함되어 있을 때 예외 발생
                if (string.IsNullOrEmpty(textInput.Text) || textInput.Text.Length < 2 || textInput.Text.Contains("admin"))
                {
                    throw new Exception("닉네임을 입력하거나 2글자 이상, admin은 포함 시킬 수 없습니다.");
                }
                else
                {
                    textResult.Text += textInput.Text + "\r\n";
                    textInput.Clear();
                    textInput.Focus();
                    MessageBox.Show("닉네임 등록 완료!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                textInput.Clear(); // 예외 발생 시 텍스트박스 내용 지우기
                textInput.Focus();
            }
        }
    }
}
