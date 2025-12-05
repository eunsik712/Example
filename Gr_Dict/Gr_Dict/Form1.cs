using System;
using System.Collections.Generic;
using System.IO; // 파일 입출력 필수
using System.Windows.Forms;

namespace Gr_Dict
{
    public partial class Form1 : Form
    {
        // 1. 데이터 저장소 (딕셔너리)
        Dictionary<string, string> dictLogin = new Dictionary<string, string>();
        Dictionary<string, string> dictPhone = new Dictionary<string, string>();

        // ★[중요] 아까 선택한 파일 위치를 기억할 변수
        string currentFilePath = "";

        public Form1()
        {
            InitializeComponent();
            LoadAccountData(); // 켜자마자 파일 불러오기
        }

        // [기능 1] 파일 불러오기
        private void LoadAccountData()
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "계정 파일(accounts.txt)을 선택해주세요";
            ofd.Filter = "텍스트 파일 (*.txt)|*.txt";
            ofd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                // ★ 파일 경로를 변수에 저장해둠 (나중에 저장할 때 쓰려고!)
                currentFilePath = ofd.FileName;

                using (StreamReader reader = new StreamReader(currentFilePath))
                {
                    while (!reader.EndOfStream)
                    {
                        string line = reader.ReadLine();
                        if (string.IsNullOrWhiteSpace(line)) continue;

                        string[] data = line.Split(',');

                        if (data.Length >= 2)
                        {
                            string id = data[0].Trim();
                            string pw = data[1].Trim();
                            string phone = (data.Length >= 3) ? data[2].Trim() : null;

                            if (!dictLogin.ContainsKey(id))
                            {
                                dictLogin.Add(id, pw);
                                dictPhone.Add(id, phone);
                            }
                        }
                    }
                }
                MessageBox.Show("불러오기 완료!", "준비");
            }
        }

        // [기능 2] 로그인 버튼 (기존과 동일)
        private void button1_Click(object sender, EventArgs e)
        {
            string id = idBox.Text.Trim();
            string pw = pwBox.Text.Trim();

            if (dictLogin.ContainsKey(id))
            {
                if (dictLogin[id] == pw)
                {
                    string phone = dictPhone[id] ?? "없음";
                    MessageBox.Show($"로그인 성공!\n전화번호: {phone}");
                }
                else MessageBox.Show("비밀번호 틀림!");
            }
            else MessageBox.Show("아이디 없음!");
        }

        // ★[기능 3] 회원가입 버튼 (새로 추가된 부분)
        private void btnRegister_Click_1(object sender, EventArgs e)
        {
            // 1. 입력값 가져오기
            string newId = idBox.Text.Trim();
            string newPw = pwBox.Text.Trim();
            string newPhone = phoneBox.Text.Trim(); // 새로 만든 박스

            // 2. 유효성 검사 (빈칸 체크)
            if (string.IsNullOrEmpty(newId) || string.IsNullOrEmpty(newPw))
            {
                MessageBox.Show("아이디와 비밀번호를 입력해주세요.");
                return;
            }

            // 3. 이미 있는 아이디인지 체크
            if (dictLogin.ContainsKey(newId))
            {
                MessageBox.Show("이미 존재하는 아이디입니다.");
                return;
            }

            // 4. 파일에 저장하기 (StreamWriter)
            // true 옵션: "덮어쓰지 말고 뒤에 이어써라(Append)" 라는 뜻
            try
            {
                using (StreamWriter writer = new StreamWriter(currentFilePath, true))
                {
                    // "아이디,비번,전화번호" 형식으로 한 줄 쓰기
                    string newLine = $"{newId},{newPw},{newPhone}";
                    writer.WriteLine(newLine);
                }

                // 5. 딕셔너리(메모리)에도 추가 (그래야 껐다 켜지 않아도 바로 로그인 됨)
                dictLogin.Add(newId, newPw);
                dictPhone.Add(newId, newPhone);

                MessageBox.Show("회원가입 완료! 저장되었습니다.");

                // 입력창 비워주기 (센스)
                idBox.Text = "";
                pwBox.Text = "";
                phoneBox.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"저장 중 오류 발생: {ex.Message}");
            }
        }

        
    }
}