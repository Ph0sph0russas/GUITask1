namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var initialSum = double.Parse(this.initialSumLabel.Text);
            var maxIncrease = double.Parse(this.maxIncreaseLabel.Text);
            var maxDeposit = double.Parse(this.maxDepositLabel.Text);

            var messageAnswers = Logic.calculateDepositInfo(initialSum, maxIncrease, maxDeposit);

            MessageBox.Show(messageAnswers);
        }
    }

    public class Logic
    {
        public static int getMonthOfExceededIncrease(double initialSum, double maxIncrease)
        {
            int answerTaskA = 0;

            double sumDeposit = 0;
            for (int i = 0; sumDeposit <= maxIncrease; initialSum = initialSum * 1.02)
            {

                sumDeposit = initialSum * 0.02;
                i = i + 1;
                answerTaskA = i;
            }
            return answerTaskA;
        }
        public static int getMonthOfExceededDeposit(double initialSum, double maxDeposit)
        {

            int answerTaskB = 0;
            for (int i = 0; initialSum <= maxDeposit; initialSum = initialSum * 1.02)
            {
                i = i + 1;
                answerTaskB = i;

            }
            return answerTaskB;
        }
        public static string calculateDepositInfo(double initialSum, double maxIncrease, double maxDeposit)
        {
            int answerTaskA = Logic.getMonthOfExceededIncrease(initialSum, maxIncrease);
            int answerTaskB = Logic.getMonthOfExceededDeposit(initialSum, maxDeposit);
            string messageAnswers = "Ответ под а)" + answerTaskA + "\n" + "Ответ под б)" + answerTaskB;
            return messageAnswers;
        }
    }

}
