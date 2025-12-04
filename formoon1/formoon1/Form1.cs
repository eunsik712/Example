namespace formoon1
{
    public partial class Form1 : Form
    {
        Random rand = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        // [요구사항 4-1] 이름과 성적을 받아서 "학생1의 점수: 42점" 형태의 문자열을 만들어주는 함수
        public string MakeScoreString(string name, int score)
        {
            // 이 함수는 재료(이름, 점수)를 넣으면 완성된 문장을 뱉어줍니다.
            return name + "의 점수: " + score + "점" + "\r\n";
        }

        // 버튼을 눌렀을 때 실행 (학생 수 입력 -> 결과 출력)
        private void button1_Click_1(object sender, EventArgs e)
        {
            // 1. 기존 결과 지우기 (깔끔하게)
            textBox1.Clear();

            // 2. 학생 수 입력받기 (textBoxInput이라는 텍스트박스가 있다고 가정)
            // 숫자가 아닌 걸 입력했을 때 튕기지 않게 TryParse 사용 (지난번에 배우셨죠?)
            if (!int.TryParse(textInput.Text, out int studentCount))
            {
                MessageBox.Show("학생 수는 숫자만 입력해주세요!");
                return;
            }

            // 3. 입력된 학생 수만큼 반복
            for (int i = 0; i < studentCount; i++)
            {
                // [중요 수정] 랜덤 점수 생성은 반복문 '안'에서 해야 매번 달라집니다.
                // 문제 요구사항: 0 ~ 100점 (101은 포함 안됨)
                int score = rand.Next(0, 101);

                // 학생 이름 만들기 (학생1, 학생2...)
                string name = "학생" + (i + 1);

                // [요구사항 4-1 사용] 위에서 만든 함수를 불러와서 문장을 받아옴
                string resultLine = MakeScoreString(name, score);

                // 결과 출력창에 이어 붙이기
                textBox1.Text += resultLine;
            }
        }

        // --------------------------------------------------------
        // 만약 버튼 없이 생성자나 다른 곳에서 바로 실행하고 싶으시면 
        // 아래 함수를 쓰셔도 되지만, 보통은 버튼 이벤트에 넣습니다.
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textInput_TextChanged(object sender, EventArgs e)
        {

        }
    }
}