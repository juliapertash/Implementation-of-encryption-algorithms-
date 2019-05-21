using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ev1_Click(object sender, EventArgs e)
        {
            string message = Mess.Text;
            Regex reg = new Regex("[0-1][0-1][0-1][0-1]");
            if(Regex.IsMatch(message, reg.ToString()))
            {
                int[] mess = new int[4];
                for (int i = 0; i < 4; i++)
                {
                    mess[i] = Convert.ToInt16(message[i]);
                }
                int sum1 = mess[1] + mess[2] + mess[3];
                int p4;
                if (sum1 % 2 == 0)
                    p4 = 0;
                else p4 = 1;
                int sum2 = mess[0] + mess[2] + mess[3];
                int p2;
                if (sum2 % 2 == 0)
                    p2 = 0;
                else p2 = 1;
                int sum3 = mess[0] + mess[3] + mess[1];
                int p1;
                if (sum3 % 2 == 0)
                    p1 = 0;
                else p1 = 1;
                string output = $"{p1}{p2}{message[0]}{p4}{message[1]}{message[2]}{message[3]}";
                Mess_code.Text = output;
            }
        }

        private void find_Click(object sender, EventArgs e)
        {
            string code = wrongmess.Text;
            Regex reg1 = new Regex("[0-1][0-1][0-1][0-1][0-1][0-1][0-1]");
            if (Regex.IsMatch(code, reg1.ToString()))
            {
                int[] codenums = new int[7];
                for (int i = 0; i < 7; i++)
                {
                    codenums[i] = (int)code[i];
                }
                int sum1 = codenums[0] + codenums[2] + codenums[4] + codenums[6];
                int n3;
                if (sum1 % 2 == 0)
                    n3 = 0;
                else n3 = 1;
                int sum2 = codenums[1] + codenums[2] + codenums[5] + codenums[6];
                int n2;
                if (sum2 % 2 == 0)
                    n2 = 0;
                else n2 = 1;
                int sum3 = codenums[3] + codenums[4] + codenums[5] + codenums[6];
                int n1;
                if (sum3 % 2 == 0)
                    n1 = 0;
                else n1 = 1;
                int k = 0;
                string dvoistr = $"{n1}{n2}{n3}";
                char[] ar = dvoistr.ToCharArray();
                Array.Reverse(ar); //Разворачивем массив
                dvoistr = new String(ar); //Записываем развернутый массив в строку

                for (int i = 0; i < dvoistr.Length; i++) //Посимвольно читаем строку
                {
                    k += Convert.ToInt32(dvoistr[i].ToString()) * Convert.ToInt32(Math.Pow(2, i)); //умножаем каждый имвол на 2 в соответствующей степени (степень = позиция)
                }
                if (k != 0)
                {
                    if (codenums[k - 1] == 49)
                        codenums[k - 1] = 48;
                    else codenums[k - 1] = 49;
                }
                string output = "";
                foreach (var a in codenums)
                {
                    output += (char)a;
                }
                final.Text = output;
            }
        }
    }
}
