using System;
using System.Windows.Forms;

namespace switch1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // 1. Enum 정의 (맨 마지막에 '없음'을 추가해서 에러 처리에 씁니다)
        enum days
        {
            월요일,
            화요일,
            수요일,
            목요일,
            금요일,
            토요일,
            일요일,
            없음 // <-- 에러 확인용으로 추가하면 편합니다.
        }

        // 2. [수정됨] 문자열을 받아서 'days(Enum)' 타입을 반환하는 함수
        // 원래는 string을 반환하셨지만, Enum을 활용하려면 반환 타입이 days여야 합니다.
        days getDay(string userinput)
        {
            switch (userinput)
            {
                case "월요일": return days.월요일;
                case "화요일": return days.화요일;
                case "수요일": return days.수요일;
                case "목요일": return days.목요일;
                case "금요일": return days.금요일;
                case "토요일": return days.토요일;
                case "일요일": return days.일요일;
                default: return days.없음; // 요일이 아니면 '없음' 반환
            }
        }

        // 3. 버튼 클릭 이벤트 (여기가 핵심 로직입니다)
        private void btInput_Click(object sender, EventArgs e)
        {
            string input = textInput.Text; // 텍스트박스 내용 가져오기

            // 1단계: 문자열 -> Enum으로 변환 (getDay 함수 사용)
            days selectedDay = getDay(input);

            // 2단계: 에러 체크 및 메시지 출력
            if (selectedDay == days.없음)
            {
                textResult.Text = "오류: 올바른 요일(예: 월요일)을 입력해주세요!";
                return; // 함수 여기서 끝내기
            }

            // 3단계: Enum에 따라 재미난 메시지 출력 (문제의 요구사항)
            string message = "";
            switch (selectedDay)
            {
                case days.월요일:
                    message = "월요병... 커피가 필요해 ☕";
                    break;
                case days.화요일:
                    message = "아직 화요일이라니 🔥";
                    break;
                case days.수요일:
                    message = "일주일의 절반! 힘내자 💪";
                    break;
                case days.목요일:
                    message = "조금만 더 버티면 주말! 🏃";
                    break;
                case days.금요일:
                    message = "불금이다! 퇴근 준비! 🎉";
                    break;
                case days.토요일:
                    message = "늦잠 자는 날 💤";
                    break;
                case days.일요일:
                    message = "내일이 월요일이라니... 😱";
                    break;
            }

            // 결과 텍스트박스에 출력
            textResult.Text = message;
        }

        // 필요 없는 이벤트들 (그냥 두셔도 됩니다)
        private void textInput_TextChanged(object sender, EventArgs e) { }
        private void textResult_TextChanged(object sender, EventArgs e) { }
    }
}