namespace struct2
{
    public partial class Form1 : Form
    {
        Student[] student = new Student[3];
        public Form1()
        {
            InitializeComponent();
            userInput();
            ReadText();
        }

        struct Student
        {
            public string name;
            public int age;
            public double score;
        }

        public void userInput()
        {
            Console.WriteLine("학생 정보 입력(3명)");
            for(int i = 0; i < student.Length; i++)
            {
                Console.Write("이름: ");
                student[i].name = Console.ReadLine();
                Console.Write("나이: ");
                student[i].age = int.Parse(Console.ReadLine());
                Console.Write("점수: ");
                student[i].score = double.Parse(Console.ReadLine());
            }
        }

        public void ReadText()
        {
            
            for(int i = 0; i < student.Length; i++)
            {
                string info = $"이름: {student[i].name}, 나이: {student[i].age}, 점수: {student[i].score}\n";
                Console.WriteLine(info);
            }


            
        }

    }
}
