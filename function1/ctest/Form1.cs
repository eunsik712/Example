using System;
using System.Diagnostics; // 디버그 창에 출력하기 위해 추가
using System.Windows.Forms;

namespace ctest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //name();
            //gong();
            int[] fianl = temp(10, 3);
            textBox1.Text = "몫: " + fianl[0] + ", 나머지: " + fianl[1];

        }

        //public void name()
        //{
        //    string[] strings = new string[10];

        //    string str1 = "동해 물과 백두산이";
        //    string str2 = "토요일에 먹는 토마토";
        //    string str3 = "질서 있는 퇴장";
        //    string str4 = "그 사람의 그림자는 그랬다.";
        //    string str5 = "삼성 갤럭시";
        //    string str6 = "오늘은 왠지 더 배고프다";
        //    string str7 = "이름,나이,전화번호"; // 띄어쓰기 없이 콤마만 씀
        //    string str8 = "우리 나라 만세";

        //    // 1. 숫자는 문자로 변환 (.ToString)
        //    strings[0] = str1.IndexOf("백두산").ToString();

        //    // 2. 숫자는 문자로 변환 (.ToString)
        //    strings[1] = str2.LastIndexOf("토").ToString();

        //    // 3. 참/거짓은 문자로 변환 (.ToString)
        //    strings[2] = str3.Contains("퇴").ToString();

        //    // 4. 이건 원래 맞음
        //    strings[3] = str4.Replace("그", "이");

        //    // 5. Insert는 (위치번호, 넣을문자) 순서임. "삼성" 글자의 위치를 찾아서 넣음.
        //    strings[4] = str5.Insert(str5.IndexOf("갤럭시"), "애플 ");

        //    // 6. Remove는 (위치번호, 지울개수) 순서임. "더" 위치 찾아서 1글자 지움.
        //    int indexDeo = str6.IndexOf("더");
        //    strings[5] = str6.Remove(indexDeo, 1);

        //    // 7. Split은 배열을 반환하므로, 그 중 첫 번째([0])만 가져옴
        //    strings[6] = str7.Split(',')[0];
        //    strings[7] = str7.Split(',')[1];
        //    strings[8] = str7.Split(',')[2];
        //    // 8. Substring은 (위치번호)를 넣어야 함. "나라" 위치부터 끝까지 자름.
        //    // 그리고 뒤에 세미콜론(;) 빠진 것 추가

        //    strings[9] = str8.Substring(str8.IndexOf("나라"), 2);


        //    // 결과 확인 (WinForms에서는 Console보다 Debug가 확인하기 좋습니다)
        //    // 출력창(Output)에서 확인 가능합니다.
        //    for (int i = 0; i < 10; i++)
        //    {
        //        textBox1.AppendText(strings[i] + "\r\n");
        //    }



        //public void gong()
        //{
        //    string[] temp = new string[3];
        //    string str = "멈추지 않는 한 얼마나 천천히 가는지는 중요하지 않다. -공자";
        //    string result1 = str.Remove(str.IndexOf("-"));

        //    textBox1.Text = result1;
        //    textBox1.Text += "\r\n";

        //    string[] splitWords = result1.Split();
        //    temp[0] = splitWords[3];
        //    temp[1] = splitWords[4];
        //    string targetWord = splitWords[5];
        //    temp[2] = targetWord.Remove(targetWord.Length - 1, 1);




        //    for (int i = 0; i < 3; i++)
        //    {
        //        textBox1.Text += temp[i];
        //        textBox1.Text += "\r\n";
        //    }

        //    string lastResult = str.Replace("-", "").Replace(".", "").Replace(" ", ",");
        //    textBox1.Text += lastResult;
        //    textBox1.Text += "\r\n";
        //}


        public int[] temp(int a, int b) 
        {
            int[] result = new int[2];
            result[0] = a / b;
            result[1] = a % b;

            return result;

        }





    }
}


