// This is a personal academic project. Dear PVS-Studio, please check it.
// PVS-Studio Static Code Analyzer for C, C++, C#, and Java: https://pvs-studio.com

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Elgamal.Classes;

namespace Elgamal.Forms
{
    public partial class MainForm : Form
    {
        private long p = 0;
        private long x = 0;
        private long y = 0;
        private long g = 0;
        private long[] rands;
        private long[] a;
        private long[] b;
        private string text;
        private long[] long_text;
        private char[] char_text;

        private void MakeRand(long size)
        {
            Random random = new Random();
            rands = new long[size];
            for (long i = 0; i < size; i++)
            {
                rands[i] = random.Next(250, (int)p - 2);
            }
        }
        public string Encryption(string text, long p, long x)
        {
            string output = String.Empty;
            this.p = p;
            this.x = x;
            long size = text.Length;
            a = new long[size];
            b = new long[size];
            MakeRand(size);
            Tolong(text);
            Primitive(p);
            y = MultiplicationModulo(g, x, p);
            for (long i = 0; i < size; i++)
            {
                a[i] = MultiplicationModulo(g, rands[i], p);
                b[i] = (long_text[i] * MultiplicationModulo(y, rands[i], p)) % p;
                output += (a[i] + " " + b[i] + " ");
            }
            return output;
        }
        private long Multiplication(long a, long b, long n) // a*b mod n - умножение a на b по модулю n
        {
            long sum = 0;
            for (long i = 0; i < b; i++)
            {
                sum += a;
                if (sum >= n)
                {
                    sum -= n;
                }
            }
            return sum;
        }
        public string Decryption(string text, long p, long x)
        {
            string output = String.Empty;
            this.p = p;
            this.x = x;
            Primitive(p);
            y = MultiplicationModulo(g, x, p);
            string[] array_string = text.Split(' ');
            int size = array_string.Length / 2;
            long[] array = new long[size * 2];
            for (int i = 0; i < size * 2; i++)
            {
                array[i] = long.Parse(array_string[i]);
            }
            a = new long[size];
            b = new long[size];
            char_text = new char[size];
            for (int i = 0, j = 1, k = 0; j < size * 2; i += 2, j += 2, k++)
            {
                a[k] = array[i];
                b[k] = array[j];
            }
            for (int i = 0; i < size; i++)
            {
                char_text[i] = (char)((b[i] * MultiplicationModulo(a[i], p - 1 - x, p)) % p);
                output += (char_text[i]);
            }
            return output;
        }
        private void Tolong(string text)
        {
            long[] numbers = new long[text.Length];
            for (int i = 0; i < text.Length; i++)
            {
                numbers[i] = (long)text[i];
            }
            long_text = numbers;
        }
        private bool IsSimple(long p)
        {
            if (p == 1)
            {
                return false;
            }
            long i = 2;
            while (i * i <= p)
            {
                if (p % i == 0)
                {
                    return false;
                }
                i++;
            }
            return true;
        }
        private void Primitive(long p)
        {
            g = 2;
            bool flag = true;
            while (true)
            {
                if (MultiplicationModulo(g, p - 1, p) == 1)
                {
                    for (long i = 1; i < p - 1; i++)
                    {

                        if (MultiplicationModulo(g, i, p) == 1)
                        {
                            flag = false;
                            break;
                        }
                    }
                    if (flag)
                    {
                        break;
                    }
                }
                flag = true;
                g++;
            }
        }
        private long MultiplicationModulo(long g, long f, long p)
        {
            long temp = g;
            long G = g;
            string fstring = Convert.ToString(f, 2);
            for (int i = 1; i < fstring.Length; i++)
            {
                if (fstring[i] == '1')
                {
                    temp = (temp * temp * G) % p;
                }
                else
                {
                    temp = (temp * temp) % p;
                }
            }
            return temp;
        }

        public MainForm()
        {
            InitializeComponent();
        }

        private void справкаToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            InfoForm infoForm = new InfoForm();
            infoForm.ShowDialog();
            infoForm.Dispose();
        }

        private void оПрограммеToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AboutProgramForm aboutProgramForm = new AboutProgramForm();
            aboutProgramForm.ShowDialog();
            aboutProgramForm.Dispose();
        }

        private void оАвтореToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutAuthorForm aboutAuthorForm = new AboutAuthorForm();
            aboutAuthorForm.ShowDialog();
            aboutAuthorForm.Dispose();
        }

        private void btn_Encrypt_Click(object sender, EventArgs e)
        {
            int.TryParse(tb_p.Text, out int p);
            int.TryParse(tb_x.Text, out int x);
            if (IsSimple(p) || x > (p - 1))
            {
                tb_Output.Text = null;
                tb_Output.Text = Encryption(tb_Input.Text, p, x);
                tb_Input.Text = null;
            }
            else
            {
                MessageBox.Show("Введите для 'p' простое число", "Некорректный ввод", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void btn_Decrypt_Click(object sender, EventArgs e)
        {
            int.TryParse(tb_p.Text, out int p);
            int.TryParse(tb_x.Text, out int x);
            if (IsSimple(p) || x > (p - 1))
            {
                tb_Input.Text = null;
                tb_Input.Text = Decryption(tb_Output.Text, p, x);
                tb_Output.Text = null;
            }
            else
            {
                MessageBox.Show("Введите для 'p' простое число", "Некорректный ввод", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
    }

    /*public class ElGamal_Algorithm
    {
        private long p = 0;
        private long x = 0;
        private long y = 0;
        private long g = 0;
        private long[] rands;
        private long[] a;
        private long[] b;
        private string text;
        private long[] long_text;
        private char[] char_text;
        private void MakeRand(long size)
        {
            Random random = new Random();
            rands = new long[size];
            for (long i = 0; i < size; i++)
            {
                rands[i] = random.Next(250, (int)p - 2);
            }
        }
        public void Encryption(string text, long p, long x)
        {
            this.p = p;
            this.x = x;
            long size = text.Length;
            a = new long[size];
            b = new long[size];
            MakeRand(size);
            Tolong(text);
            Primitive(p);
            y = MultiplicationModulo(g, x, p);
            for (long i = 0; i < size; i++)
            {
                a[i] = MultiplicationModulo(g, rands[i], p);
                b[i] = (long_text[i] * MultiplicationModulo(y, rands[i], p)) % p;
                Console.Write(a[i] + ";" + b[i] + ";");
            }
            Console.WriteLine($"\nПри у = {y},p = {p},g = {g},x = {x}");
        }
        private long Multiplication(long a, long b, long n) // a*b mod n - умножение a на b по модулю n
        {
            long sum = 0;
            for (long i = 0; i < b; i++)
            {
                sum += a;
                if (sum >= n)
                {
                    sum -= n;
                }
            }
            return sum;
        }
        public void Decryption(string text, long p, long x)
        {
            this.p = p;
            this.x = x;
            Primitive(p);
            y = MultiplicationModulo(g, x, p);
            string[] array_string = text.Split(';');
            int size = array_string.Length / 2;
            long[] array = new long[size * 2];
            for (int i = 0; i < size * 2; i++)
            {
                array[i] = long.Parse(array_string[i]);
            }
            a = new long[size];
            b = new long[size];
            char_text = new char[size];
            for (int i = 0, j = 1, k = 0; j < size * 2; i += 2, j += 2, k++)
            {
                a[k] = array[i];
                b[k] = array[j];
            }
            for (int i = 0; i < size; i++)
            {
                char_text[i] = (char)((b[i] * MultiplicationModulo(a[i], p - 1 - x, p)) % p);
                Console.Write(char_text[i]);
            }
        }
        private void Tolong(string text)
        {
            long[] numbers = new long[text.Length];
            for (int i = 0; i < text.Length; i++)
            {
                numbers[i] = (long)text[i];
            }
            long_text = numbers;
        }
        private bool IsSimple(long p)
        {
            if (p == 1)
            {
                return false;
            }
            long i = 2;
            while (i * i <= p)
            {
                if (p % i == 0)
                {
                    return false;
                }
                i++;
            }
            return true;
        }
        private void Primitive(long p)
        {
            g = 2;
            bool flag = true;
            while (true)
            {
                if (MultiplicationModulo(g, p - 1, p) == 1)
                {
                    for (long i = 1; i < p - 1; i++)
                    {

                        if (MultiplicationModulo(g, i, p) == 1)
                        {
                            flag = false;
                            break;
                        }
                    }
                    if (flag)
                    {
                        break;
                    }
                }
                flag = true;
                g++;
            }
        }
        private long MultiplicationModulo(long g, long f, long p)
        {
            long temp = g;
            long G = g;
            string fstring = Convert.ToString(f, 2);
            for (int i = 1; i < fstring.Length; i++)
            {
                if (fstring[i] == '1')
                {
                    temp = (temp * temp * G) % p;
                }
                else
                {
                    temp = (temp * temp) % p;
                }
            }
            return temp;
        }
    }*/
}
