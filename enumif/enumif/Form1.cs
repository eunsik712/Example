using System.CodeDom.Compiler;
using System.Security.Cryptography;

namespace enumif
{
    public partial class Form1 : Form
    {
        Random rand = new Random();
        int comScore = 0;
        int userScore = 0;
        public Form1()
        {
            InitializeComponent();
        }

        public string ComChoice()
        {
            /*
             * 컴퓨터가 가위, 바위, 보 중 하나를 랜덤으로 선택
             * rand.Next(0,3) 0은 가위 1은 바위 2는 보
             */
            int num = rand.Next(0, 3);
            switch (num)
            {
                case 0: return "가위";
                case 1: return "바위";
                case 2: return "보";
                default: return string.Empty; // 모든 경로에서 값을 반환하도록 수정
            }
                

        }

        public void PlayGame(string userChoice)
        {
            string comChoice = ComChoice();
            if (userChoice == comChoice)
            {
                textResult.Text = "비겼습니다!" + "\r\n" + "컴퓨터: " + comChoice;
            }
            else if ((userChoice == "가위" && comChoice == "보") ||
                     (userChoice == "바위" && comChoice == "가위") ||
                     (userChoice == "보" && comChoice == "바위"))
            {
                textResult.Text = "이겼습니다!" + "\r\n" + "컴퓨터: " + comChoice;
                userScore++;
            }
            else
            {
                textResult.Text = "졌습니다!" + "\r\n" + "컴퓨터: " + comChoice;
                comScore++;
            }
            countBox1.Text = userScore.ToString(); // 유저 점수
            countBox2.Text = comScore.ToString(); // 마왕 점수

            CheckGameOver();
        }
        
        public void CheckGameOver()
        {
            if (userScore >= 3)
            {
                MessageBox.Show("유저가 이겼습니다! 게임을 종료합니다.");
                Application.Exit();
            }
            else if (comScore >= 3)
            {
                MessageBox.Show("마왕이 이겼습니다! 게임을 종료합니다.");
                Application.Exit();
            }
        }



        private void textResult_TextChanged(object sender, EventArgs e)
        {

        }
        private void countBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void ssButton_Click(object sender, EventArgs e)
        {
            /*
             * 내가 가위를 눌렀을때 컴퓨터가 가위면 비기고 바위면 지고 보면 이긴다
             * comrand 함수에서 나온 값에 따라 결과가 달라진다
             * 조건문으로 comrand의 값에 따라 결과를 출력한다
             */

            PlayGame("가위");
        }

        private void roButton_Click(object sender, EventArgs e)
        {
            PlayGame("바위");
        }

        private void ppButton_Click(object sender, EventArgs e)
        {
            PlayGame("보");
        }

        private void countBox1_TextChanged(object sender, EventArgs e)
        {
            // 유저 이긴횟수
            // 유저가 이겼을때마다 1씩 증가
           
            
        }
    }
}
