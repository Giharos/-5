using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lib_5;

namespace Практическая_работа__5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Int32.TryParse(numFirstValue.Text, out int One) && Int32.TryParse(numSecondValue.Text, out int Two) &&
                Int32.TryParse(numThirdValue.Text, out int Three) && Int32.TryParse(number.Text, out int Chislo))
            {
                int firstNumber = Convert.ToInt32(numFirstValue.Text);
                int secondNumber = Convert.ToInt32(numSecondValue.Text);
                int thirdNumber = Convert.ToInt32(numThirdValue.Text);
                int chislo = Convert.ToInt32(number.Text);
                Lib_5.Triad triadNumbers = new Triad(firstNumber, secondNumber, thirdNumber, chislo);
                //Сумма
                triadNumbers.GetMultiplay1();
                //Вывод
                rez1.Text = triadNumbers.FirstNumber.ToString() + triadNumbers.SecondNumber.ToString() + triadNumbers.ThirdNumber.ToString();
            }
            else MessageBox.Show("Введите правильное значение");
            }


        private void button2_Click(object sender, EventArgs e)
        {
            if (Int32.TryParse(numFirstValue.Text, out int One) && Int32.TryParse(numSecondValue.Text, out int Two) &&
                Int32.TryParse(numThirdValue.Text, out int Three) && Int32.TryParse(number.Text, out int Chislo))
            {
                int firstNumber = Convert.ToInt32(numFirstValue.Text);
                int secondNumber = Convert.ToInt32(numSecondValue.Text);
                int thirdNumber = Convert.ToInt32(numThirdValue.Text);
                int chislo = Convert.ToInt32(number.Text);
                Lib_5.Triad triadNumbers = new Triad(firstNumber, secondNumber, thirdNumber, chislo);
                //Произведение
                triadNumbers.GetMultiplay2();
                //Вывод
                rez2.Text = triadNumbers.FirstNumber.ToString() + triadNumbers.SecondNumber.ToString() + triadNumbers.ThirdNumber.ToString();
            }
            else MessageBox.Show("Введите правильное значение");    
        }


        private void button3_Click(object sender, EventArgs e)
        {
            if (Int32.TryParse(numFirstValue.Text, out int One) && Int32.TryParse(numSecondValue.Text, out int Two) &&
                Int32.TryParse(numThirdValue.Text, out int Three) && Int32.TryParse(number.Text, out int Chislo))
            {
                int firstNumber = Convert.ToInt32(numFirstValue.Text);
                int secondNumber = Convert.ToInt32(numSecondValue.Text);
                int thirdNumber = Convert.ToInt32(numThirdValue.Text);
                int chislo = Convert.ToInt32(number.Text);
                Lib_5.Triad triadNumbers = new Triad(firstNumber, secondNumber, thirdNumber, chislo);
                //Произведение
                triadNumbers.Proverka();
                //Вывод
                if (triadNumbers.Proverka() == true) proverka.Text = "Числа равны";
                else proverka.Text = "Числа не равны";
            }
            else MessageBox.Show("Введите правильное значение");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Практическая работа №5\n" +
                "Создать класс Triad (тройка чисел). Создать необходимые методы и свойства. Определить методы с операциями сложения с числом, умножения на число, проверки на равенство. Создать перегруженный метод для сложения элементов одой триады с другой триадой.\n " +
                "Платов Андрей ИСП-31");
        }
    }
    }


