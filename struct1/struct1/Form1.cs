using System.Drawing;

namespace struct1
{
    public partial class Form1 : Form
    {
        //Point firstPoint = new Point(); // 첫 번째 값을 저장해둘 보관함
        //bool isFirstStep = true;

        public Form1()
        {
            InitializeComponent();
            inputUser();
        }



        // 구조체 선언
        public struct Point
        {
            public int x;
            public int y;
        }



        public static void inputUser()
        {
            Console.WriteLine("X 좌표를 입력하세요:");
            string? input = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("입력이 올바르지 않습니다. 다시 시도하세요.");
                return;
            }
            Point tempPoint = new Point();
            tempPoint.x = int.Parse(input);
            Console.WriteLine("Y 좌표를 입력하세요:");
            input = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("입력이 올바르지 않습니다. 다시 시도하세요.");
                return;
            }
            tempPoint.y = int.Parse(input);
            // 필요에 따라 tempPoint를 사용하거나 저장

            Console.WriteLine($"입력된 점: ({tempPoint.x}, {tempPoint.y})");

            Point secondPoint = new Point();

            Console.WriteLine("두번째 X 좌표를 입력하세요:");
            input = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("입력이 올바르지 않습니다. 다시 시도하세요.");
                return;
            }

            secondPoint.x = int.Parse(input);
            Console.WriteLine("두번째 Y 좌표를 입력하세요:");
            input = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("입력이 올바르지 않습니다. 다시 시도하세요.");
                return;
            }
            secondPoint.y = int.Parse(input);

            Console.WriteLine($"입력된 점: ({secondPoint.x}, {secondPoint.y})");

            Console.WriteLine($"두 점 사이의 거리: {CalculateDistance(tempPoint, secondPoint)}");

        }



        public static double CalculateDistance(Point p1, Point p2)
        {
            int deltaX = p2.x - p1.x;
            int deltaY = p2.y - p1.y;
            return Math.Sqrt(deltaX * deltaX + deltaY * deltaY);
        }

        // 선언된 구조체에 텍스트박스와 연동하여 값을 입력하고
        // 텍스트리설트의 입력
        //private void inputButton_Click(object sender, EventArgs e)
        //{
        //    int currentX = int.Parse(xBox.Text);
        //    int currentY = int.Parse(yBox.Text);

        //    if (isFirstStep)
        //    {
        //        firstPoint.x = currentX;
        //        firstPoint.y = currentY;

        //        textResult.AppendText($"첫 번째 점 저장: ({firstPoint.x}, {firstPoint.y})\r\n");

        //        xBox.Text = "";
        //        yBox.Text = "";
        //        xBox.Focus();
        //        isFirstStep = false;

        //    }
        //    else
        //    {
        //        textResult.AppendText($"두 번째 점: ({currentX}, {currentY})\r\n");

        //        int deltaX = currentX - firstPoint.x;
        //        int deltaY = currentY - firstPoint.y;

        //        textResult.AppendText($"변화량: Δx = {deltaX}, Δy = {deltaY}\r\n");
        //    }


        //}
















        private void xBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void yBox_TextChanged(object sender, EventArgs e)
        {

        }

        

        private void textResult_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
