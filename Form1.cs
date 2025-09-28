using System;
using System.Windows.Forms;

namespace SimpleCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                double a = double.Parse(txtA.Text);
                double b = double.Parse(txtB.Text);
                string op = cbOperator.SelectedItem.ToString();
                double result = 0;

                switch (op)
                {
                    case "+": result = a + b; break;
                    case "-": result = a - b; break;
                    case "*": result = a * b; break;
                    case "/":
                        if (b != 0) result = a / b;
                        else
                        {
                            lblResult.Text = "Không thể chia cho 0";
                            return;
                        }
                        break;
                }

                lblResult.Text = "Kết quả: " + result.ToString();
            }
            catch
            {
                lblResult.Text = "Dữ liệu không hợp lệ!";
            }
        }
    }
}
