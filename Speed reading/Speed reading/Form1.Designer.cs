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
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.text1start = new System.Windows.Forms.Button();
            this.text1finish = new System.Windows.Forms.Button();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.menuP1 = new System.Windows.Forms.TabPage();
            this.StartTest = new System.Windows.Forms.Button();
            this.infoMenu = new System.Windows.Forms.RichTextBox();
            this.text1P1 = new System.Windows.Forms.TabPage();
            this.text1next = new System.Windows.Forms.Button();
            this.infoText1 = new System.Windows.Forms.RichTextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.webBrowser2 = new System.Windows.Forms.WebBrowser();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.menuP1.SuspendLayout();
            this.text1P1.SuspendLayout();
            this.tabPage4.SuspendLayout();
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
            this.tabControl1.Location = new System.Drawing.Point(156, 10);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(435, 535);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 0;
            this.tabControl1.TabStop = false;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.webBrowser1);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage1.Size = new System.Drawing.Size(427, 507);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Разминка";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage2.Size = new System.Drawing.Size(427, 507);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Тренировка";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // text1start
            // 
            this.text1start.Location = new System.Drawing.Point(23, 197);
            this.text1start.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.text1start.Name = "text1start";
            this.text1start.Size = new System.Drawing.Size(100, 47);
            this.text1start.TabIndex = 0;
            this.text1start.Text = "Начать!";
            this.text1start.UseVisualStyleBackColor = true;
            this.text1start.Click += new System.EventHandler(this.Text1Start_Click);
            // 
            // text1finish
            // 
            this.text1finish.Location = new System.Drawing.Point(4, 429);
            this.text1finish.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.text1finish.Name = "text1finish";
            this.text1finish.Size = new System.Drawing.Size(135, 58);
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
            this.tabControl2.Location = new System.Drawing.Point(4, 6);
            this.tabControl2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(150, 539);
            this.tabControl2.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl2.TabIndex = 1;
            this.tabControl2.TabStop = false;
            // 
            // menuP1
            // 
            this.menuP1.Controls.Add(this.StartTest);
            this.menuP1.Controls.Add(this.infoMenu);
            this.menuP1.Location = new System.Drawing.Point(4, 25);
            this.menuP1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.menuP1.Name = "menuP1";
            this.menuP1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.menuP1.Size = new System.Drawing.Size(142, 510);
            this.menuP1.TabIndex = 0;
            this.menuP1.Text = "menuP1";
            this.menuP1.UseVisualStyleBackColor = true;
            // 
            // StartTest
            // 
            this.StartTest.Location = new System.Drawing.Point(5, 167);
            this.StartTest.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.StartTest.Name = "StartTest";
            this.StartTest.Size = new System.Drawing.Size(134, 42);
            this.StartTest.TabIndex = 1;
            this.StartTest.Text = "Начать тренировку";
            this.StartTest.UseVisualStyleBackColor = true;
            this.StartTest.Click += new System.EventHandler(this.StartTest_Click);
            // 
            // infoMenu
            // 
            this.infoMenu.Location = new System.Drawing.Point(5, 6);
            this.infoMenu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.infoMenu.Name = "infoMenu";
            this.infoMenu.ReadOnly = true;
            this.infoMenu.Size = new System.Drawing.Size(135, 145);
            this.infoMenu.TabIndex = 0;
            this.infoMenu.Text = "";
            // 
            // text1P1
            // 
            this.text1P1.Controls.Add(this.text1next);
            this.text1P1.Controls.Add(this.infoText1);
            this.text1P1.Controls.Add(this.text1finish);
            this.text1P1.Controls.Add(this.text1start);
            this.text1P1.Location = new System.Drawing.Point(4, 25);
            this.text1P1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.text1P1.Name = "text1P1";
            this.text1P1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.text1P1.Size = new System.Drawing.Size(142, 510);
            this.text1P1.TabIndex = 1;
            this.text1P1.Text = "text1P1";
            this.text1P1.UseVisualStyleBackColor = true;
            // 
            // text1next
            // 
            this.text1next.Location = new System.Drawing.Point(23, 249);
            this.text1next.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.text1next.Name = "text1next";
            this.text1next.Size = new System.Drawing.Size(100, 47);
            this.text1next.TabIndex = 4;
            this.text1next.Text = "Следующее задание";
            this.text1next.UseVisualStyleBackColor = true;
            this.text1next.Click += new System.EventHandler(this.text1next_Click);
            // 
            // infoText1
            // 
            this.infoText1.Location = new System.Drawing.Point(3, 6);
            this.infoText1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.infoText1.Name = "infoText1";
            this.infoText1.Size = new System.Drawing.Size(138, 180);
            this.infoText1.TabIndex = 3;
            this.infoText1.Text = "";
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 24);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(427, 507);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Тест";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.webBrowser2);
            this.tabPage4.Location = new System.Drawing.Point(4, 24);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(427, 507);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Доп. материалы";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(2, 2);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(423, 503);
            this.webBrowser1.TabIndex = 0;
            // 
            // webBrowser2
            // 
            this.webBrowser2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser2.Location = new System.Drawing.Point(0, 0);
            this.webBrowser2.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser2.Name = "webBrowser2";
            this.webBrowser2.Size = new System.Drawing.Size(427, 507);
            this.webBrowser2.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 555);
            this.Controls.Add(this.tabControl2);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Speed reading";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabControl2.ResumeLayout(false);
            this.menuP1.ResumeLayout(false);
            this.text1P1.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
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
    }
}

