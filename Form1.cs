using System.Windows.Forms;
using System.Threading;
namespace lab8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public long CalculateFibonacci(int n)
        {
            long a = 0;
            long b = 1;
            for (int i = 2; i <= n; i++)
            {
                long temp = a;
                a = b;
                b = temp + b;
            }
            return n > 0 ? b : a;
        }
        private async void BtnGenerate_Click(object sender, EventArgs e)
        {
           

            if (!int.TryParse(tbxInput.Text, out int n) || n < 0)
            {
                MessageBox.Show("Please enter a valid positive Integer");
                return;
            }

            listBoxResult.Items.Clear();

            await Task.Run(() =>
            {
                for (int i = 0; i < n; i++)
                {
                    
                    long fibNumber = CalculateFibonacci(i);
                    listBoxResult.Invoke(new Action(() =>
                    {
                        listBoxResult.Items.Add($"{fibNumber}");
                        
                    }));
                    Thread.Sleep(100);
                }
            });
        }
    }
}
