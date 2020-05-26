namespace Speed_reading
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.grBoxTestQuest = new System.Windows.Forms.GroupBox();
            this.grQuestion = new System.Windows.Forms.GroupBox();
            this.btnAnsw = new System.Windows.Forms.Button();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.webBrowser3 = new System.Windows.Forms.WebBrowser();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.webBrowser2 = new System.Windows.Forms.WebBrowser();
            this.text1start = new System.Windows.Forms.Button();
            this.text1finish = new System.Windows.Forms.Button();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.menuP1 = new System.Windows.Forms.TabPage();
            this.StartTest = new System.Windows.Forms.Button();
            this.infoMenu = new System.Windows.Forms.RichTextBox();
            this.text1P1 = new System.Windows.Forms.TabPage();
            this.text1next = new System.Windows.Forms.Button();
            this.infoText1 = new System.Windows.Forms.RichTextBox();
            this.text_Tren1_Entr = new System.Windows.Forms.RichTextBox();
            this.label_Tren1_Show = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.grBoxTestQuest.SuspendLayout();
            this.grQuestion.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.menuP1.SuspendLayout();
            this.text1P1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.ItemSize = new System.Drawing.Size(70, 20);
            this.tabControl1.Location = new System.Drawing.Point(208, 12);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(580, 658);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 0;
            this.tabControl1.TabStop = false;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.webBrowser1);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Size = new System.Drawing.Size(572, 630);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Разминка";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(3, 2);
            this.webBrowser1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(27, 25);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(566, 626);
            this.webBrowser1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label_Tren1_Show);
            this.tabPage2.Controls.Add(this.text_Tren1_Entr);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Size = new System.Drawing.Size(572, 630);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Тренировка";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.grBoxTestQuest);
            this.tabPage3.Controls.Add(this.webBrowser3);
            this.tabPage3.Location = new System.Drawing.Point(4, 24);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(572, 630);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Тест";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // grBoxTestQuest
            // 
            this.grBoxTestQuest.Controls.Add(this.grQuestion);
            this.grBoxTestQuest.Location = new System.Drawing.Point(21, 4);
            this.grBoxTestQuest.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grBoxTestQuest.Name = "grBoxTestQuest";
            this.grBoxTestQuest.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grBoxTestQuest.Size = new System.Drawing.Size(544, 599);
            this.grBoxTestQuest.TabIndex = 1;
            this.grBoxTestQuest.TabStop = false;
            this.grBoxTestQuest.Text = "Выберете ответы";
            this.grBoxTestQuest.Visible = false;
            // 
            // grQuestion
            // 
            this.grQuestion.Controls.Add(this.btnAnsw);
            this.grQuestion.Controls.Add(this.radioButton4);
            this.grQuestion.Controls.Add(this.radioButton3);
            this.grQuestion.Controls.Add(this.radioButton2);
            this.grQuestion.Controls.Add(this.radioButton1);
            this.grQuestion.Location = new System.Drawing.Point(52, 37);
            this.grQuestion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grQuestion.Name = "grQuestion";
            this.grQuestion.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grQuestion.Size = new System.Drawing.Size(419, 183);
            this.grQuestion.TabIndex = 5;
            this.grQuestion.TabStop = false;
            this.grQuestion.Text = "groupBox2";
            // 
            // btnAnsw
            // 
            this.btnAnsw.Enabled = false;
            this.btnAnsw.Location = new System.Drawing.Point(169, 148);
            this.btnAnsw.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAnsw.Name = "btnAnsw";
            this.btnAnsw.Size = new System.Drawing.Size(100, 28);
            this.btnAnsw.TabIndex = 4;
            this.btnAnsw.Text = "Ответить";
            this.btnAnsw.UseVisualStyleBackColor = true;
            this.btnAnsw.Click += new System.EventHandler(this.btnAnsw_Click);
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(8, 121);
            this.radioButton4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(110, 21);
            this.radioButton4.TabIndex = 3;
            this.radioButton4.TabStop = true;
            this.radioButton4.Tag = "4";
            this.radioButton4.Text = "radioButton4";
            this.radioButton4.UseVisualStyleBackColor = true;
            this.radioButton4.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(8, 92);
            this.radioButton3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(110, 21);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.TabStop = true;
            this.radioButton3.Tag = "3";
            this.radioButton3.Text = "radioButton3";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(8, 64);
            this.radioButton2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(110, 21);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Tag = "2";
            this.radioButton2.Text = "radioButton2";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(8, 36);
            this.radioButton1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(110, 21);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Tag = "1";
            this.radioButton1.Text = "radioButton1";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // webBrowser3
            // 
            this.webBrowser3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser3.Location = new System.Drawing.Point(0, 0);
            this.webBrowser3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.webBrowser3.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser3.Name = "webBrowser3";
            this.webBrowser3.Size = new System.Drawing.Size(572, 630);
            this.webBrowser3.TabIndex = 0;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.webBrowser2);
            this.tabPage4.Location = new System.Drawing.Point(4, 24);
            this.tabPage4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(572, 630);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Доп. материалы";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // webBrowser2
            // 
            this.webBrowser2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser2.Location = new System.Drawing.Point(0, 0);
            this.webBrowser2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.webBrowser2.MinimumSize = new System.Drawing.Size(27, 25);
            this.webBrowser2.Name = "webBrowser2";
            this.webBrowser2.Size = new System.Drawing.Size(572, 630);
            this.webBrowser2.TabIndex = 0;
            // 
            // text1start
            // 
            this.text1start.Location = new System.Drawing.Point(31, 242);
            this.text1start.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.text1start.Name = "text1start";
            this.text1start.Size = new System.Drawing.Size(133, 58);
            this.text1start.TabIndex = 0;
            this.text1start.Text = "Начать!";
            this.text1start.UseVisualStyleBackColor = true;
            this.text1start.Click += new System.EventHandler(this.Text1Start_Click);
            // 
            // text1finish
            // 
            this.text1finish.Location = new System.Drawing.Point(5, 528);
            this.text1finish.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.text1finish.Name = "text1finish";
            this.text1finish.Size = new System.Drawing.Size(180, 71);
            this.text1finish.TabIndex = 2;
            this.text1finish.Text = "Готово!";
            this.text1finish.UseVisualStyleBackColor = true;
            this.text1finish.Click += new System.EventHandler(this.Text1Stop_Click);
            // 
            // tabControl2
            // 
            this.tabControl2.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabControl2.Controls.Add(this.menuP1);
            this.tabControl2.Controls.Add(this.text1P1);
            this.tabControl2.Location = new System.Drawing.Point(5, 7);
            this.tabControl2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(200, 663);
            this.tabControl2.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl2.TabIndex = 1;
            this.tabControl2.TabStop = false;
            // 
            // menuP1
            // 
            this.menuP1.Controls.Add(this.StartTest);
            this.menuP1.Controls.Add(this.infoMenu);
            this.menuP1.Location = new System.Drawing.Point(4, 28);
            this.menuP1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.menuP1.Name = "menuP1";
            this.menuP1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.menuP1.Size = new System.Drawing.Size(192, 631);
            this.menuP1.TabIndex = 0;
            this.menuP1.Text = "menuP1";
            this.menuP1.UseVisualStyleBackColor = true;
            // 
            // StartTest
            // 
            this.StartTest.Location = new System.Drawing.Point(7, 206);
            this.StartTest.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.StartTest.Name = "StartTest";
            this.StartTest.Size = new System.Drawing.Size(179, 52);
            this.StartTest.TabIndex = 1;
            this.StartTest.Text = "Начать тренировку";
            this.StartTest.UseVisualStyleBackColor = true;
            this.StartTest.Click += new System.EventHandler(this.StartTest_Click);
            // 
            // infoMenu
            // 
            this.infoMenu.Location = new System.Drawing.Point(7, 7);
            this.infoMenu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.infoMenu.Name = "infoMenu";
            this.infoMenu.ReadOnly = true;
            this.infoMenu.Size = new System.Drawing.Size(179, 178);
            this.infoMenu.TabIndex = 0;
            this.infoMenu.Text = "";
            // 
            // text1P1
            // 
            this.text1P1.Controls.Add(this.text1next);
            this.text1P1.Controls.Add(this.infoText1);
            this.text1P1.Controls.Add(this.text1finish);
            this.text1P1.Controls.Add(this.text1start);
            this.text1P1.Location = new System.Drawing.Point(4, 28);
            this.text1P1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.text1P1.Name = "text1P1";
            this.text1P1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.text1P1.Size = new System.Drawing.Size(192, 631);
            this.text1P1.TabIndex = 1;
            this.text1P1.Text = "text1P1";
            this.text1P1.UseVisualStyleBackColor = true;
            // 
            // text1next
            // 
            this.text1next.Location = new System.Drawing.Point(31, 306);
            this.text1next.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.text1next.Name = "text1next";
            this.text1next.Size = new System.Drawing.Size(133, 58);
            this.text1next.TabIndex = 4;
            this.text1next.Text = "Следующее задание";
            this.text1next.UseVisualStyleBackColor = true;
            this.text1next.Click += new System.EventHandler(this.text1next_Click);
            // 
            // infoText1
            // 
            this.infoText1.Location = new System.Drawing.Point(4, 7);
            this.infoText1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.infoText1.Name = "infoText1";
            this.infoText1.ReadOnly = true;
            this.infoText1.Size = new System.Drawing.Size(183, 221);
            this.infoText1.TabIndex = 3;
            this.infoText1.Text = "";
            // 
            // text_Tren1_Entr
            // 
            this.text_Tren1_Entr.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.text_Tren1_Entr.Location = new System.Drawing.Point(83, 161);
            this.text_Tren1_Entr.Name = "text_Tren1_Entr";
            this.text_Tren1_Entr.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.text_Tren1_Entr.Size = new System.Drawing.Size(377, 66);
            this.text_Tren1_Entr.TabIndex = 0;
            this.text_Tren1_Entr.Text = "";
            this.text_Tren1_Entr.KeyDown += new System.Windows.Forms.KeyEventHandler(this.text_Tren1_Entr_KeyDown);
            // 
            // label_Tren1_Show
            // 
            this.label_Tren1_Show.AutoSize = true;
            this.label_Tren1_Show.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Tren1_Show.Location = new System.Drawing.Point(73, 50);
            this.label_Tren1_Show.Name = "label_Tren1_Show";
            this.label_Tren1_Show.Size = new System.Drawing.Size(254, 55);
            this.label_Tren1_Show.TabIndex = 1;
            this.label_Tren1_Show.Text = "            - - -";
            this.label_Tren1_Show.Click += new System.EventHandler(this.label_Tren1_Show_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 683);
            this.Controls.Add(this.tabControl2);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Speed reading";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.grBoxTestQuest.ResumeLayout(false);
            this.grQuestion.ResumeLayout(false);
            this.grQuestion.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabControl2.ResumeLayout(false);
            this.menuP1.ResumeLayout(false);
            this.text1P1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button text1start;
        private System.Windows.Forms.Button text1finish;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage menuP1;
        private System.Windows.Forms.TabPage text1P1;
        private System.Windows.Forms.Button StartTest;
        private System.Windows.Forms.RichTextBox infoMenu;
        private System.Windows.Forms.RichTextBox infoText1;
        private System.Windows.Forms.Button text1next;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.WebBrowser webBrowser2;
        private System.Windows.Forms.WebBrowser webBrowser3;
        private System.Windows.Forms.GroupBox grBoxTestQuest;
        private System.Windows.Forms.GroupBox grQuestion;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Button btnAnsw;
        private System.Windows.Forms.Label label_Tren1_Show;
        private System.Windows.Forms.RichTextBox text_Tren1_Entr;
    }
}

