using System;
using System.Diagnostics; // 콘솔 출력을 위해 필요
using System.Windows.Forms;

namespace class_drink
{
    // 사람.
    public partial class Customer
    {
        public int wallet; // 가진 돈

        public Customer(int money)
        {
            this.wallet = money;
        }

        // 돈을 지불하는 기능 (내 돈 줄어듦 -> 낸 돈 리턴)
        public int PayMoney(int amount)
        {
            this.wallet -= amount;
            return amount;
        }
    }

    // [2] 자판기 (Machine) - 부분 클래스
    public partial class Machine
    {
        public int currentMoney; // 자판기에 들어온 돈
        public string drinkName; // 음료 이름
        public int drinkPrice;   // 음료 가격

        public Machine(string name, int price)
        {
            this.drinkName = name;
            this.drinkPrice = price;
            this.currentMoney = 0;
        }

        // 돈 넣기 기능
        public void InsertCoin(int money)
        {
            this.currentMoney += money;
        }

        // 음료 뽑기 기능
        public string DispenseDrink()
        {
            if (this.currentMoney >= this.drinkPrice)
            {
                this.currentMoney -= this.drinkPrice;
                return $"[성공] {this.drinkName} 덜컹!";
            }
            else
            {
                return $"[실패] 잔액이 부족합니다. (현재: {this.currentMoney}원)";
            }
        }
    }

    // [3] 메인 실행부 (Form1)
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // 프로그램 시작하자마자 바로 콘솔 시뮬레이션 실행
            RunConsoleSimulation();
        }

        // 버튼 없이 코드로만 실행되는 함수
        public void RunConsoleSimulation()
        {
            Console.WriteLine("=== 자판기 시뮬레이션 시작 ===");

            // 1. 객체 생성 (준비)
            Customer student = new Customer(10000); // 만원 들고 온 학생
            Machine colaMachine = new Machine("제로콜라", 1500); // 1500원짜리 자판기

            Console.WriteLine($"학생 초기 자산: {student.wallet}원");
            Console.WriteLine($"자판기 음료: {colaMachine.drinkName} ({colaMachine.drinkPrice}원)");
            Console.WriteLine("-----------------------------");

            // 2. 동작 수행 (시나리오)

            // 학생이 2000원을 꺼낸다
            int cash = student.PayMoney(2000);
            Console.WriteLine($"1. 학생이 {cash}원을 꺼냈습니다.");

            // 자판기에 넣는다
            colaMachine.InsertCoin(cash);
            Console.WriteLine($"2. 자판기에 돈을 넣었습니다. (현재 투입금: {colaMachine.currentMoney}원)");

            // 음료를 뽑는다
            string result = colaMachine.DispenseDrink();
            Console.WriteLine($"3. 배출 결과: {result}");

            Console.WriteLine("-----------------------------");
            Console.WriteLine($"[최종] 학생 남은 돈: {student.wallet}원");
            Console.WriteLine($"[최종] 자판기 남은 돈(거스름돈): {colaMachine.currentMoney}원");

            // 윈폼이니까 메시지박스로도 한번 띄워줌
            MessageBox.Show("콘솔 출력 완료! 출력 창을 확인하세요.\n\n" + result);
        }
    }
}