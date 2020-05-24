using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Speed_reading
{
    public partial class Form1 : Form
    {
        int window = 0;

        string text = "текст тестовый, обычный такой";

        Stopwatch TimeText = new Stopwatch();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            text1finish.Hide();
        }

        private int dispetchr (int window)
        {

            return window;
        }

        private int Menu()
        {
            tabControl1.SelectedTab = textP2;
            text1text.Text = "";
            tabControl2.SelectedTab = menuP1;
            return 0;
        }

        private int TestText1()
        {
            tabControl1.SelectedTab = textP2;
            text1text.Text = "";
            tabControl2.SelectedTab = text1P1;
            infoText1.Text = "описание задания и того что нужно сделать";
            text1finish.Hide();
            text1start.Show();
            text1next.Hide();
            return 0;
        }

        private void Text1Start_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            text1text.Text = text;
            text1text.Text = File.ReadAllText(@"text_"+ rnd.Next(2,4).ToString() +".txt");
            webBrowser.DocumentText = File.ReadAllText(@"read.html");
            this.TimeText.Start();
            text1start.Hide();
            text1finish.Show();

        }

        private void Text1Stop_Click(object sender, EventArgs e)
        {
            TimeText.Stop();
            long secods = TimeText.ElapsedMilliseconds / 1000;
            text1finish.Hide();
            text1next.Show();
            int countWord = 1;
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == ' ')
                {
                    countWord++;
                }
            }
            double minuts = secods / 60.0;
            infoText1.Text = String.Format("Отлично! Ваша скорость чтения составляет {0} слов в минуту", countWord / minuts);
        }

        private void text1next_Click(object sender, EventArgs e)
        {
            Menu();
        }

        private void StartTest_Click(object sender, EventArgs e)
        {
            TestText1();
        }

        
    }
}
