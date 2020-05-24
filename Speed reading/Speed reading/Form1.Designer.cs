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
            this.textP2 = new System.Windows.Forms.TabPage();
            this.text1text = new System.Windows.Forms.RichTextBox();
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
            this.webBrowser = new System.Windows.Forms.WebBrowser();
            this.tabControl1.SuspendLayout();
            this.textP2.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.menuP1.SuspendLayout();
            this.text1P1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabControl1.Controls.Add(this.textP2);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.ItemSize = new System.Drawing.Size(60, 20);
            this.tabControl1.Location = new System.Drawing.Point(208, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(580, 659);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 0;
            this.tabControl1.TabStop = false;
            // 
            // textP2
            // 
            this.textP2.Controls.Add(this.text1text);
            this.textP2.Location = new System.Drawing.Point(4, 24);
            this.textP2.Name = "textP2";
            this.textP2.Padding = new System.Windows.Forms.Padding(3);
            this.textP2.Size = new System.Drawing.Size(572, 631);
            this.textP2.TabIndex = 0;
            this.textP2.Text = "textP2";
            this.textP2.UseVisualStyleBackColor = true;
            // 
            // text1text
            // 
            this.text1text.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.text1text.BackColor = System.Drawing.SystemColors.Window;
            this.text1text.Location = new System.Drawing.Point(8, 8);
            this.text1text.Name = "text1text";
            this.text1text.ReadOnly = true;
            this.text1text.Size = new System.Drawing.Size(700, 743);
            this.text1text.TabIndex = 1;
            this.text1text.Text = "";
            this.text1text.ZoomFactor = 1.4F;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.webBrowser);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(572, 631);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // text1start
            // 
            this.text1start.Location = new System.Drawing.Point(31, 242);
            this.text1start.Name = "text1start";
            this.text1start.Size = new System.Drawing.Size(134, 58);
            this.text1start.TabIndex = 0;
            this.text1start.Text = "Начать!";
            this.text1start.UseVisualStyleBackColor = true;
            this.text1start.Click += new System.EventHandler(this.Text1Start_Click);
            // 
            // text1finish
            // 
            this.text1finish.Location = new System.Drawing.Point(6, 528);
            this.text1finish.Name = "text1finish";
            this.text1finish.Size = new System.Drawing.Size(180, 72);
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
            this.tabControl2.Location = new System.Drawing.Point(6, 8);
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
            this.menuP1.Name = "menuP1";
            this.menuP1.Padding = new System.Windows.Forms.Padding(3);
            this.menuP1.Size = new System.Drawing.Size(192, 631);
            this.menuP1.TabIndex = 0;
            this.menuP1.Text = "menuP1";
            this.menuP1.UseVisualStyleBackColor = true;
            // 
            // StartTest
            // 
            this.StartTest.Location = new System.Drawing.Point(7, 206);
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
            this.text1P1.Name = "text1P1";
            this.text1P1.Padding = new System.Windows.Forms.Padding(3);
            this.text1P1.Size = new System.Drawing.Size(192, 631);
            this.text1P1.TabIndex = 1;
            this.text1P1.Text = "text1P1";
            this.text1P1.UseVisualStyleBackColor = true;
            // 
            // text1next
            // 
            this.text1next.Location = new System.Drawing.Point(31, 306);
            this.text1next.Name = "text1next";
            this.text1next.Size = new System.Drawing.Size(134, 58);
            this.text1next.TabIndex = 4;
            this.text1next.Text = "Следующее задание";
            this.text1next.UseVisualStyleBackColor = true;
            this.text1next.Click += new System.EventHandler(this.text1next_Click);
            // 
            // infoText1
            // 
            this.infoText1.Location = new System.Drawing.Point(4, 7);
            this.infoText1.Name = "infoText1";
            this.infoText1.Size = new System.Drawing.Size(182, 220);
            this.infoText1.TabIndex = 3;
            this.infoText1.Text = "";
            // 
            // webBrowser
            // 
            this.webBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser.Location = new System.Drawing.Point(3, 3);
            this.webBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser.Name = "webBrowser";
            this.webBrowser.Size = new System.Drawing.Size(566, 625);
            this.webBrowser.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 683);
            this.Controls.Add(this.tabControl2);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Speed reading";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.textP2.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabControl2.ResumeLayout(false);
            this.menuP1.ResumeLayout(false);
            this.text1P1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage textP2;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button text1start;
        private System.Windows.Forms.RichTextBox text1text;
        private System.Windows.Forms.Button text1finish;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage menuP1;
        private System.Windows.Forms.TabPage text1P1;
        private System.Windows.Forms.Button StartTest;
        private System.Windows.Forms.RichTextBox infoMenu;
        private System.Windows.Forms.RichTextBox infoText1;
        private System.Windows.Forms.Button text1next;
        private System.Windows.Forms.WebBrowser webBrowser;
    }
}

