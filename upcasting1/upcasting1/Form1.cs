namespace upcasting1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Animal animal = new Dog("호두");
            string message = animal.Speak();
            MessageBox.Show(message);
            // animal.Fetch() 부모 클래스에 호출 가능한 메서드가 없기 때문에 오류 발생
            // 다운캐스팅 필요
            string fetchMessage = ((Dog)animal).Fetch();
            MessageBox.Show(fetchMessage);
            // 자식의 메서드는 자식 클래스로 직접 캐스팅 호출을 해야 가능

            Animal cat = new Cat("나비");
            MessageBox.Show(cat.Speak());
            MessageBox.Show(((Cat)cat).Scratch());
        }

        public class Animal
        {
            protected string name;
            public Animal(string name)
            {
                this.name = name;
            }
            public virtual string Speak() => "울부 짖기!";

        }

        public class Dog : Animal
        {
            public Dog(string name) : base(name)
            {
            }
            public override string Speak() => "멍멍!";

            public string Fetch() => $"{name}가 공을 가져왔습니다!";
        }
        public class Cat : Animal
        {
            public Cat(string name) : base(name)
            {
            }
            public override string Speak() => "야옹!";
            
            public string Scratch() => $"{name}가 긁었습니다!";
        }

        public class Bird : Animal
        {
            public Bird(string name) : base(name)
            {
            }
            public override string Speak() => "짹짹!";

            public string Fly() => $"{name}가 날아갔습니다!";

        }



    }

}
