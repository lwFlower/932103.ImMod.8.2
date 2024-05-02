using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Magic_Ball
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Random x = new Random();
        private void MagicPic_Click(object sender, EventArgs e)
        {
            double p = x.NextDouble();
            //double p = 0.95;
            labelP.Text = "p = " + p;
            int k = -1;
            double[] P = new double[7] {0.125,0.250,0.375, 0.500, 0.625,0.750, 0.875}; //сами отметки
            double[] prob = new double[8];

            //вычисляем промежутки
            prob[0] = P[0];
            for (int i = 1; i < 7; i++)
            {
                prob[i] = P[i] - P[i-1];
            }
            prob[7] = 1 - P[6];

            while (!(p <= 0))
            {
                k += 1;
                p -= prob[k];
            }
            labelK.Text = "k = " + k;
            switch (k)
            {
                case 0:
                    Answer.Text = "Подумай ещё раз";
                    break;
                case 1:
                    Answer.Text = "Тебе лучше не знать";
                    break;
                case 2:
                    Answer.Text = "Время покажет";
                    break;
                case 3:
                    Answer.Text = "Нельзя точно сказать";
                    break;
                case 4:
                    Answer.Text = "Скорее да, чем нет";
                    break;
                case 5:
                    Answer.Text = "Скорее нет, чем да";
                    break;
                case 6:
                    Answer.Text = "Спроси в другой раз";
                    break;
                case 7:
                    Answer.Text = "Это твоя судьба";
                    break;
            }
            Answer.Visible = true;
        }

        private void Question_TextChanged(object sender, EventArgs e)
        {
            Question.ForeColor = Color.Black;
        }

        private void Question_Click(object sender, EventArgs e)
        {
            Question.Text = "";
        }
    }
}
