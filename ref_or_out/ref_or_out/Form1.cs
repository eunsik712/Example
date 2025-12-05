namespace ref_or_out
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            first();
            third();
        }


        public void first()
        {
            int[] num = null;

            second(ref num);

            Console.WriteLine($"배열의 크기: {num.Length}");
            for (int i = 0; i < num.Length; i++)
            {
                Console.WriteLine($"배열의 {i}번째 원소: {num[i]}");
            }
        }

        public void second(ref int[] numbers)
        {
            numbers = new int[5];
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = i;
            }
        }


        public void third()
        {
            int[] result = null;

            fourth(out result, 2);

            Console.WriteLine($"배열의 크기: {result.Length}");
            for (int i = 0; i < result.Length; i++)
            {
                Console.WriteLine($"배열의 {i}번째 원소: {result[i]}");
            }
        }

        public void fourth(out int[] numbers, int size)
        {
            numbers = new int[size];
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = i;
            }
        }
    }
}
