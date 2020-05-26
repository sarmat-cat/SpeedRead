using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Speed_reading
{
    public partial class Form1 : Form
    {
        int window = 0;
        int read_1_cnt = 1;
        bool is_answered = false;
        string text = "текст тестовый, обычный такой";
        int correctAnswerCnt;
        Random rnd = new Random();
        Stopwatch TimeText = new Stopwatch();
        List<dynamic> Test = new List<dynamic>();
        List<int> UserAnsw = new List<int>();

        //||||||||||||||||||||||||||||||||||||||||||
        //Tren1...........начало....................
        //||||||||||||||||||||||||||||||||||||||||||

        int Tren1_mode;
        int Tren1_n = 7; //колличество значаний которыые будут показаны
        int Tren1_Statistick; //колличество правильных ответов
        int Tren1_i;
        string Tren1_value_s;
        int Tren1_value_n;
        int Tren1_Value_size;
        double Tren1_Speed;
        bool Tren1_Flag;
        Random rendomN = new Random();
        Stopwatch t = new Stopwatch();

        public void Tren1_Load()
        {
            text1finish.Hide();
            text1next.Hide();
            text1start.Show();
        }


        public void Tren1_Start(int mode)
        {
            text1start.Hide();
            Tren1_mode = mode;
            text_Tren1_Entr.Text = "";
            label_Tren1_Show.Text = "";
            Tren1_i = 0;
            Tren1_Value_size = 3;
            Tren1_Speed = 1;
            Tren1_Statistick = 0;
            Tren1_Iter();
        }

        public void Tren1_Iter()
        {
            Tren1_Flag = false;
            for (int i = 0; i < 3; i++)
            {
                label_Tren1_Show.Text = "            - - -";
                tabPage2.Refresh();
                Thread.Sleep((int)(300 * Tren1_Speed));

                label_Tren1_Show.Text = "";
                tabPage2.Refresh();
                Thread.Sleep((int)(300 * Tren1_Speed));
            }
            if (Tren1_mode == 0)
            {
                if (Tren1_i == 5)
                {
                    Tren1_Value_size++;
                }
                int min = (int)(Math.Pow(10, Tren1_Value_size - 1));
                Tren1_value_n = rendomN.Next(min, min * 10 - 1);
                label_Tren1_Show.Text = String.Format("          {0}",Tren1_value_n);
                tabPage2.Refresh();
                t.Start();
                Thread.Sleep((int)(300 * Tren1_Speed));
                t.Stop();
                t.Reset();
                label_Tren1_Show.Text = "";
                tabPage2.Refresh();
            }
            Tren1_Flag = true;
        }

        public void Tren1_Chek()
        {
            if (Tren1_Flag)
            {
                if (Tren1_value_n == int.Parse(text_Tren1_Entr.Text))
                {
                    text_Tren1_Entr.BackColor = Color.PaleGreen;
                    Tren1_Statistick++;

                }
                else
                {
                    text_Tren1_Entr.BackColor = Color.Salmon;

                }
                tabPage2.Refresh();
                Thread.Sleep(1000);
                text_Tren1_Entr.BackColor = Color.White;
                text_Tren1_Entr.Text = "";
                label_Tren1_Show.Text = "";
                Tren1_i++;
                tabPage2.Refresh();
                if (Tren1_i < Tren1_n)
                {
                    Tren1_Iter();
                }
                else
                {
                    label_Tren1_Show.Text = String.Format("Верно {0} из {1}", Tren1_Statistick, Tren1_n);
                    text1next.Show();
                }

            }
        }
        //|||||||||||||||||||||||||||||||||||||||||||
        //Tren1............конец.....................
        //|||||||||||||||||||||||||||||||||||||||||||


        //Загрузка тестовых вопросов и ваиантов ответов из текстового файла
        public void LoadTestData(string path)
        {
            using (StreamReader sr = new StreamReader(path, System.Text.Encoding.Default))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                { 
                    string que = line;
                    List<string> answer = new List<string>();
                    answer.Add(sr.ReadLine());
                    answer.Add(sr.ReadLine());
                    answer.Add(sr.ReadLine());
                    answer.Add(sr.ReadLine());
                    line = sr.ReadLine();
                    Test.Add(new
                    {
                        question = que,
                        answer,                        
                        correct = Int16.Parse(line)
                    });
                }
            }
        }
        //Загрузка вопроса с вариантами ответов на форму
        public void LoadTest(int IDquest)
        {
            grQuestion.Text = Test[IDquest].question;
            radioButton1.Text = Test[IDquest].answer[0];
            radioButton2.Text = Test[IDquest].answer[1];
            radioButton3.Text = Test[IDquest].answer[2];
            radioButton4.Text = Test[IDquest].answer[3];
        }
        //Запсук и проходка теста
        public void RunTestNext()
        {
            if (UserAnsw.Count < Test.Count )
            {
                LoadTest(UserAnsw.Count);
            }

        }
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
           // tabControl1.SelectedTab = tabPage1;
           // text1text.Text = "";
            tabControl2.SelectedTab = menuP1;
            return 0;
        }

        private int TestText1()
        {
           // tabControl1.SelectedTab = tabPage1;
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

            //Кнопка Начать
        private void Text1Start_Click(object sender, EventArgs e)
        {

            switch(tabControl1.SelectedTab.Name)
                {
                case "tabPage1":

                    webBrowser1.DocumentText = File.ReadAllText(@"read_1_" + read_1_cnt.ToString() + "_" + rnd.Next(1, 3).ToString() + ".html");
                    read_1_cnt = read_1_cnt >= 2 ? 1 : read_1_cnt + 1;     
            
                break;
                case "tabPage2":
                    Tren1_Start(0);
                    break;
                case "tabPage3":
                    webBrowser3.Visible = true;
                    int num = rnd.Next(1, 4);
                    webBrowser3.DocumentText = File.ReadAllText(@"read_3_"  + "1_" + num.ToString() + ".html");
                    LoadTestData(@"answ_3_" + "1_" + num.ToString() + ".txt");
                    break;
                default:

                break;
            }
 
            this.TimeText.Start();
            text1start.Hide();
            text1finish.Show();

        }
        //Кнопка Готово
        private void Text1Stop_Click(object sender, EventArgs e)
        {
            TimeText.Stop();
            long secods = TimeText.ElapsedMilliseconds / 1000;
            text1finish.Hide();
            text1next.Show();
            int countWord = 1;
            string statAnswer="";

            switch (tabControl1.SelectedTab.Name)
            {
                case "tabPage1":
                    text = webBrowser1.Document.Body.InnerText;
                    break;
                case "tabPage3":
                    if (webBrowser3.Visible)
                    {
                        text = webBrowser3.Document.Body.InnerText;
                        webBrowser3.Visible = false;
                        grBoxTestQuest.Visible = true;
                        LoadTest(0);
                    }
                    else
                    {
                        statAnswer = "Правильных от ветов "+ correctAnswerCnt.ToString() + " из " + Test.Count().ToString();
                        correctAnswerCnt = 0;
                    }
                    break;
                default:
                    text = "test";
                    break;
            }
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == ' ')
                {
                    countWord++;
                }
            }
            double minuts = secods / 60.0;
            infoText1.Text = String.Format("Отлично! Ваша скорость чтения составляет {0} слов в минуту \r{1}" , (int)(countWord / minuts), statAnswer);
        }
        //Следующее задание
        private void text1next_Click(object sender, EventArgs e)
        {
            Menu();
        }
        //Начать тренировку
        private void StartTest_Click(object sender, EventArgs e)
        {
            TestText1();
        }
        //Обработка события выбора ответа на вопрос теста
        private void radioButton_CheckedChanged(object sender, EventArgs e)
        {
            // приводим отправителя к элементу типа RadioButton
            RadioButton radioButton = (RadioButton)sender;
            if (radioButton.Checked)
            {
               // MessageBox.Show("Вы выбрали " + radioButton.Text + " ID = " + radioButton.Tag);
                //UserAnsw.Add(Convert.ToInt32(radioButton.Tag));
                is_answered = true;
                btnAnsw.Enabled = true;
            }
        }
        //Очистка выбранных радиокнопок в вопросах теста
        private void radioButton_Clear()
        {
            foreach (Control control in this.grQuestion.Controls)
            {
                if (control is RadioButton)
                {
                    RadioButton radio = control as RadioButton;
                    radio.Checked = false;
                }
            }
        }
        //Кнопка ответить на вопросы теста
        private void btnAnsw_Click(object sender, EventArgs e)
        {
            foreach (Control control in this.grQuestion.Controls)
            {
                if (control is RadioButton)
                {
                    RadioButton radio = control as RadioButton;
                    if (radio.Checked)
                    {
                        int userAnswer = Convert.ToInt32(radio.Tag);
                        if (userAnswer == Test[UserAnsw.Count].correct)
                        {
                            correctAnswerCnt++;
                        }
                        UserAnsw.Add(userAnswer);
                        
                        btnAnsw.Enabled = false;
                        //RunTestNext();
                        if (UserAnsw.Count < Test.Count)
                        {
                            LoadTest(UserAnsw.Count);
                            radioButton_Clear();
                        }
                        else
                        {
                            radioButton_Clear();
                            Text1Stop_Click(sender, e);
                            Test.Clear();
                            UserAnsw.Clear();
                            grBoxTestQuest.Visible = false;
                            //webBrowser3.Visible = true;
                        }

                    }
                }
            }
                
        }

        private void text_Tren1_Entr_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                Tren1_Chek();
            }
        }

        private void label_Tren1_Show_Click(object sender, EventArgs e)
        {

        }
    }
}
