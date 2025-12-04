using System;
using System.Windows.Forms;

namespace quest1
{
    public partial class Form1 : Form
    {
        // 난수 생성기
        Random rand = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        // 동전 던지기 판정 함수 (작성하신 내용 그대로 유지)
        public bool check(bool myGuess)
        {
            int number = rand.Next();
            bool actualSide;

            // 홀수=true, 짝수=false 가정
            if (number % 2 == 1)
            {
                actualSide = true;
            }
            else
            {
                actualSide = false;
            }

            // 내 예측과 실제 결과 비교
            if (myGuess == actualSide)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        // [핵심] 실제 버튼과 연결된 함수 (여기에 로직을 넣었습니다)
        private void button1_Click_1(object sender, EventArgs e)
        {
            bool userSelect = false;

            // -------------------------------------------------------
            // 1. 텍스트박스(textBox2) 입력 확인 (우선순위 1)
            // -------------------------------------------------------
            if (textBox2.Text.Trim().Length > 0)
            {
                // 사용자가 "True", "TRUE", " true " 등 어떻게 입력해도 처리되도록 변환
                string input = textBox2.Text.Trim().ToLower();

                if (input == "true")
                {
                    userSelect = true;
                }
                else if (input == "false")
                {
                    userSelect = false;
                }
                else
                {
                    // true/false가 아닌 엉뚱한 글자(예: "안녕")를 입력했을 때
                    text_result.Text = "에러: true 또는 false만 입력해주세요.";
                    return; // 여기서 함수를 끝내버립니다. (게임 진행 안 함)
                }
            }
            // -------------------------------------------------------
            // 2. 텍스트박스가 비어있으면 라디오 버튼 확인 (우선순위 2)
            // -------------------------------------------------------
            else
            {
                if (radioButtonTrue.Checked == true)
                {
                    userSelect = true;
                }
                else
                {
                    // True가 아니면 False 버튼이 체크된 것으로 간주
                    userSelect = false;
                }
            }

            // -------------------------------------------------------
            // 3. 승패 판정 및 결과 출력 (스크린샷 형식 맞춤)
            // -------------------------------------------------------
            bool isVictory = check(userSelect);

            // 출력할 메시지 만들기 (줄바꿈: \r\n)
            string message = "입력하신 값은 " + userSelect.ToString() + " 입니다!\r\n";
            message += "동전 던지기 결과...\r\n";

            if (isVictory)
            {
                message += "승리~!";
            }
            else
            {
                message += "패배..."; // 혹은 스크린샷에 맞춰 텍스트 조정
            }

            // 최종 출력
            text_result.Text = message;
        }


        // --- 아래는 사용하지 않지만 폼 디자이너 연결 때문에 남겨둔 빈 함수들 ---

        private void button1_Click(object sender, EventArgs e)
        {
            // (사용 안 함: 위의 button1_Click_1을 사용)
        }

        private void text_result_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }

        private void radioButtonFalse_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void radioButtonTrue_CheckedChanged_1(object sender, EventArgs e)
        {
        }
    }
}