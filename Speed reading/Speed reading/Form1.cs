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
        int read_1_cnt = 1;

        string text = "текст тестовый, обычный такой";

        Stopwatch TimeText = new Stopwatch();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            text1finish.Hide();
            webBrowser2.DocumentText = File.ReadAllText(@"tabl.html");
        }

        private int dispetchr (int window)
        {

            return window;
        }

        private int Menu()
        {
            tabControl1.SelectedTab = tabPage1;
           // text1text.Text = "";
            tabControl2.SelectedTab = menuP1;
            return 0;
        }

        private int TestText1()
        {
            tabControl1.SelectedTab = tabPage1;
            //text1text.Text = "";
            tabControl2.SelectedTab = text1P1;
            infoText1.Text = "описание задания и того что нужно сделать";
            text1finish.Hide();
            text1start.Show();
            text1next.Hide();
            return 0;
        }
        // Подумать!!!
        // В зависисмости от открытой вкладки (TabPage) 
        // применять разные действия по кликам 
        // через конструкцию switch case...
        // тогда кнопки управления будут общими
        private void Text1Start_Click(object sender, EventArgs e)
        {
            switch(tabControl1.SelectedTab.Name)
                {
                case "tabPage1":
                    Random rnd = new Random();
                    //text1text.Text = text;
                    //text1text.Text = File.ReadAllText(@"text_"+ rnd.Next(2,4).ToString() +".txt");
                    webBrowser1.DocumentText = File.ReadAllText(@"read_1_" + read_1_cnt.ToString() + "_" + rnd.Next(1, 3).ToString() + ".html");
                    // webBrowser.DocumentText = File.ReadAllText(@"read.html");
                    read_1_cnt = read_1_cnt >= 2 ? 1 : read_1_cnt + 1;     
            
                break;

                default:

                break;
            }


   
                
            
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
            text = webBrowser1.Document.Body.InnerText;
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
