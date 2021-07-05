namespace Сотрудники
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label адресLabel;
            System.Windows.Forms.Label дата_рожденияLabel;
            System.Windows.Forms.Label имяLabel;
            System.Windows.Forms.Label кодLabel;
            System.Windows.Forms.Label кодДолжностиLabel;
            System.Windows.Forms.Label кодКатегорииLabel;
            System.Windows.Forms.Label образованиеLabel;
            System.Windows.Forms.Label отчествоLabel;
            System.Windows.Forms.Label полLabel;
            System.Windows.Forms.Label телефонLabel;
            System.Windows.Forms.Label ученная_степеньLabel;
            System.Windows.Forms.Label фамилияLabel;
            System.Windows.Forms.Label зарплата_в_мес_рубLabel;
            this.адресTextBox = new System.Windows.Forms.TextBox();
            this.дата_рожденияDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.имяTextBox = new System.Windows.Forms.TextBox();
            this.кодTextBox = new System.Windows.Forms.TextBox();
            this.кодДолжностиTextBox = new System.Windows.Forms.TextBox();
            this.кодКатегорииTextBox = new System.Windows.Forms.TextBox();
            this.образованиеTextBox = new System.Windows.Forms.TextBox();
            this.отчествоTextBox = new System.Windows.Forms.TextBox();
            this.полTextBox = new System.Windows.Forms.TextBox();
            this.телефонTextBox = new System.Windows.Forms.TextBox();
            this.ученная_степеньTextBox = new System.Windows.Forms.TextBox();
            this.фамилияTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.зарплата_в_мес_рубTextBox = new System.Windows.Forms.TextBox();
            this.сотрудники_НИИBindingSource = new System.Windows.Forms.BindingSource(this.components);
            адресLabel = new System.Windows.Forms.Label();
            дата_рожденияLabel = new System.Windows.Forms.Label();
            имяLabel = new System.Windows.Forms.Label();
            кодLabel = new System.Windows.Forms.Label();
            кодДолжностиLabel = new System.Windows.Forms.Label();
            кодКатегорииLabel = new System.Windows.Forms.Label();
            образованиеLabel = new System.Windows.Forms.Label();
            отчествоLabel = new System.Windows.Forms.Label();
            полLabel = new System.Windows.Forms.Label();
            телефонLabel = new System.Windows.Forms.Label();
            ученная_степеньLabel = new System.Windows.Forms.Label();
            фамилияLabel = new System.Windows.Forms.Label();
            зарплата_в_мес_рубLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.сотрудники_НИИBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // адресLabel
            // 
            адресLabel.AutoSize = true;
            адресLabel.Location = new System.Drawing.Point(493, 112);
            адресLabel.Name = "адресLabel";
            адресLabel.Size = new System.Drawing.Size(41, 13);
            адресLabel.TabIndex = 1;
            адресLabel.Text = "Адрес:";
            // 
            // дата_рожденияLabel
            // 
            дата_рожденияLabel.AutoSize = true;
            дата_рожденияLabel.Location = new System.Drawing.Point(493, 32);
            дата_рожденияLabel.Name = "дата_рожденияLabel";
            дата_рожденияLabel.Size = new System.Drawing.Size(89, 13);
            дата_рожденияLabel.TabIndex = 3;
            дата_рожденияLabel.Text = "Дата рождения:";
            // 
            // имяLabel
            // 
            имяLabel.AutoSize = true;
            имяLabel.Location = new System.Drawing.Point(17, 83);
            имяLabel.Name = "имяLabel";
            имяLabel.Size = new System.Drawing.Size(32, 13);
            имяLabel.TabIndex = 7;
            имяLabel.Text = "Имя:";
            // 
            // кодLabel
            // 
            кодLabel.AutoSize = true;
            кодLabel.Location = new System.Drawing.Point(17, 31);
            кодLabel.Name = "кодLabel";
            кодLabel.Size = new System.Drawing.Size(29, 13);
            кодLabel.TabIndex = 9;
            кодLabel.Text = "Код:";
            // 
            // кодДолжностиLabel
            // 
            кодДолжностиLabel.AutoSize = true;
            кодДолжностиLabel.Location = new System.Drawing.Point(17, 161);
            кодДолжностиLabel.Name = "кодДолжностиLabel";
            кодДолжностиLabel.Size = new System.Drawing.Size(90, 13);
            кодДолжностиLabel.TabIndex = 11;
            кодДолжностиLabel.Text = "Код Должности:";
            // 
            // кодКатегорииLabel
            // 
            кодКатегорииLabel.AutoSize = true;
            кодКатегорииLabel.Location = new System.Drawing.Point(17, 135);
            кодКатегорииLabel.Name = "кодКатегорииLabel";
            кодКатегорииLabel.Size = new System.Drawing.Size(85, 13);
            кодКатегорииLabel.TabIndex = 13;
            кодКатегорииLabel.Text = "Код Категории:";
            кодКатегорииLabel.Click += new System.EventHandler(this.кодКатегорииLabel_Click);
            // 
            // образованиеLabel
            // 
            образованиеLabel.AutoSize = true;
            образованиеLabel.Location = new System.Drawing.Point(493, 61);
            образованиеLabel.Name = "образованиеLabel";
            образованиеLabel.Size = new System.Drawing.Size(78, 13);
            образованиеLabel.TabIndex = 15;
            образованиеLabel.Text = "Образование:";
            // 
            // отчествоLabel
            // 
            отчествоLabel.AutoSize = true;
            отчествоLabel.Location = new System.Drawing.Point(17, 109);
            отчествоLabel.Name = "отчествоLabel";
            отчествоLabel.Size = new System.Drawing.Size(57, 13);
            отчествоLabel.TabIndex = 17;
            отчествоLabel.Text = "Отчество:";
            // 
            // полLabel
            // 
            полLabel.AutoSize = true;
            полLabel.Location = new System.Drawing.Point(17, 187);
            полLabel.Name = "полLabel";
            полLabel.Size = new System.Drawing.Size(30, 13);
            полLabel.TabIndex = 19;
            полLabel.Text = "Пол:";
            // 
            // телефонLabel
            // 
            телефонLabel.AutoSize = true;
            телефонLabel.Location = new System.Drawing.Point(493, 138);
            телефонLabel.Name = "телефонLabel";
            телефонLabel.Size = new System.Drawing.Size(55, 13);
            телефонLabel.TabIndex = 21;
            телефонLabel.Text = "Телефон:";
            // 
            // ученная_степеньLabel
            // 
            ученная_степеньLabel.AutoSize = true;
            ученная_степеньLabel.Location = new System.Drawing.Point(493, 167);
            ученная_степеньLabel.Name = "ученная_степеньLabel";
            ученная_степеньLabel.Size = new System.Drawing.Size(97, 13);
            ученная_степеньLabel.TabIndex = 23;
            ученная_степеньLabel.Text = "Ученная степень:";
            // 
            // фамилияLabel
            // 
            фамилияLabel.AutoSize = true;
            фамилияLabel.Location = new System.Drawing.Point(17, 57);
            фамилияLabel.Name = "фамилияLabel";
            фамилияLabel.Size = new System.Drawing.Size(59, 13);
            фамилияLabel.TabIndex = 25;
            фамилияLabel.Text = "Фамилия:";
            // 
            // зарплата_в_мес_рубLabel
            // 
            зарплата_в_мес_рубLabel.AutoSize = true;
            зарплата_в_мес_рубLabel.Location = new System.Drawing.Point(493, 87);
            зарплата_в_мес_рубLabel.Name = "зарплата_в_мес_рубLabel";
            зарплата_в_мес_рубLabel.Size = new System.Drawing.Size(58, 13);
            зарплата_в_мес_рубLabel.TabIndex = 28;
            зарплата_в_мес_рубLabel.Text = "Зарплата ";
            зарплата_в_мес_рубLabel.Click += new System.EventHandler(this.зарплата_в_мес_рубLabel_Click);
            // 
            // адресTextBox
            // 
            this.адресTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.сотрудники_НИИBindingSource, "Адрес", true));
            this.адресTextBox.Location = new System.Drawing.Point(596, 109);
            this.адресTextBox.Name = "адресTextBox";
            this.адресTextBox.Size = new System.Drawing.Size(269, 20);
            this.адресTextBox.TabIndex = 2;
            // 
            // дата_рожденияDateTimePicker
            // 
            this.дата_рожденияDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.сотрудники_НИИBindingSource, "Дата_рождения", true));
            this.дата_рожденияDateTimePicker.Location = new System.Drawing.Point(596, 28);
            this.дата_рожденияDateTimePicker.Name = "дата_рожденияDateTimePicker";
            this.дата_рожденияDateTimePicker.Size = new System.Drawing.Size(269, 20);
            this.дата_рожденияDateTimePicker.TabIndex = 4;
            // 
            // имяTextBox
            // 
            this.имяTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.сотрудники_НИИBindingSource, "Имя", true));
            this.имяTextBox.Location = new System.Drawing.Point(120, 80);
            this.имяTextBox.Name = "имяTextBox";
            this.имяTextBox.Size = new System.Drawing.Size(269, 20);
            this.имяTextBox.TabIndex = 8;
            // 
            // кодTextBox
            // 
            this.кодTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.сотрудники_НИИBindingSource, "Код", true));
            this.кодTextBox.Location = new System.Drawing.Point(120, 24);
            this.кодTextBox.Name = "кодTextBox";
            this.кодTextBox.Size = new System.Drawing.Size(269, 20);
            this.кодTextBox.TabIndex = 10;
            // 
            // кодДолжностиTextBox
            // 
            this.кодДолжностиTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.сотрудники_НИИBindingSource, "КодДолжности", true));
            this.кодДолжностиTextBox.Location = new System.Drawing.Point(120, 158);
            this.кодДолжностиTextBox.Name = "кодДолжностиTextBox";
            this.кодДолжностиTextBox.Size = new System.Drawing.Size(269, 20);
            this.кодДолжностиTextBox.TabIndex = 12;
            // 
            // кодКатегорииTextBox
            // 
            this.кодКатегорииTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.сотрудники_НИИBindingSource, "КодКатегории", true));
            this.кодКатегорииTextBox.Location = new System.Drawing.Point(120, 132);
            this.кодКатегорииTextBox.Name = "кодКатегорииTextBox";
            this.кодКатегорииTextBox.Size = new System.Drawing.Size(269, 20);
            this.кодКатегорииTextBox.TabIndex = 14;
            // 
            // образованиеTextBox
            // 
            this.образованиеTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.сотрудники_НИИBindingSource, "Образование", true));
            this.образованиеTextBox.Location = new System.Drawing.Point(596, 54);
            this.образованиеTextBox.Name = "образованиеTextBox";
            this.образованиеTextBox.Size = new System.Drawing.Size(269, 20);
            this.образованиеTextBox.TabIndex = 16;
            // 
            // отчествоTextBox
            // 
            this.отчествоTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.сотрудники_НИИBindingSource, "Отчество", true));
            this.отчествоTextBox.Location = new System.Drawing.Point(120, 106);
            this.отчествоTextBox.Name = "отчествоTextBox";
            this.отчествоTextBox.Size = new System.Drawing.Size(269, 20);
            this.отчествоTextBox.TabIndex = 18;
            // 
            // полTextBox
            // 
            this.полTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.сотрудники_НИИBindingSource, "Пол", true));
            this.полTextBox.Location = new System.Drawing.Point(120, 184);
            this.полTextBox.Name = "полTextBox";
            this.полTextBox.Size = new System.Drawing.Size(269, 20);
            this.полTextBox.TabIndex = 20;
            // 
            // телефонTextBox
            // 
            this.телефонTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.сотрудники_НИИBindingSource, "Телефон", true));
            this.телефонTextBox.Location = new System.Drawing.Point(596, 135);
            this.телефонTextBox.Name = "телефонTextBox";
            this.телефонTextBox.Size = new System.Drawing.Size(269, 20);
            this.телефонTextBox.TabIndex = 22;
            // 
            // ученная_степеньTextBox
            // 
            this.ученная_степеньTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.сотрудники_НИИBindingSource, "Ученная_степень", true));
            this.ученная_степеньTextBox.Location = new System.Drawing.Point(596, 161);
            this.ученная_степеньTextBox.Name = "ученная_степеньTextBox";
            this.ученная_степеньTextBox.Size = new System.Drawing.Size(269, 20);
            this.ученная_степеньTextBox.TabIndex = 24;
            // 
            // фамилияTextBox
            // 
            this.фамилияTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.сотрудники_НИИBindingSource, "Фамилия", true));
            this.фамилияTextBox.Location = new System.Drawing.Point(120, 54);
            this.фамилияTextBox.Name = "фамилияTextBox";
            this.фамилияTextBox.Size = new System.Drawing.Size(269, 20);
            this.фамилияTextBox.TabIndex = 26;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(445, 216);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 39);
            this.button1.TabIndex = 27;
            this.button1.Text = "Сохранить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Location = new System.Drawing.Point(707, 216);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(135, 39);
            this.button2.TabIndex = 28;
            this.button2.Text = "Выйти";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // зарплата_в_мес_рубTextBox
            // 
            this.зарплата_в_мес_рубTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.сотрудники_НИИBindingSource, "Зарплата_в_мес_руб", true));
            this.зарплата_в_мес_рубTextBox.Location = new System.Drawing.Point(596, 80);
            this.зарплата_в_мес_рубTextBox.Name = "зарплата_в_мес_рубTextBox";
            this.зарплата_в_мес_рубTextBox.Size = new System.Drawing.Size(269, 20);
            this.зарплата_в_мес_рубTextBox.TabIndex = 29;
            // 
            // сотрудники_НИИBindingSource
            // 
            this.сотрудники_НИИBindingSource.DataSource = typeof(Сотрудники.Сотрудники_НИИ);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(910, 277);
            this.Controls.Add(зарплата_в_мес_рубLabel);
            this.Controls.Add(this.зарплата_в_мес_рубTextBox);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(адресLabel);
            this.Controls.Add(this.адресTextBox);
            this.Controls.Add(дата_рожденияLabel);
            this.Controls.Add(this.дата_рожденияDateTimePicker);
            this.Controls.Add(имяLabel);
            this.Controls.Add(this.имяTextBox);
            this.Controls.Add(кодLabel);
            this.Controls.Add(this.кодTextBox);
            this.Controls.Add(кодДолжностиLabel);
            this.Controls.Add(this.кодДолжностиTextBox);
            this.Controls.Add(кодКатегорииLabel);
            this.Controls.Add(this.кодКатегорииTextBox);
            this.Controls.Add(образованиеLabel);
            this.Controls.Add(this.образованиеTextBox);
            this.Controls.Add(отчествоLabel);
            this.Controls.Add(this.отчествоTextBox);
            this.Controls.Add(полLabel);
            this.Controls.Add(this.полTextBox);
            this.Controls.Add(телефонLabel);
            this.Controls.Add(this.телефонTextBox);
            this.Controls.Add(ученная_степеньLabel);
            this.Controls.Add(this.ученная_степеньTextBox);
            this.Controls.Add(фамилияLabel);
            this.Controls.Add(this.фамилияTextBox);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.сотрудники_НИИBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource сотрудники_НИИBindingSource;
        private System.Windows.Forms.TextBox адресTextBox;
        private System.Windows.Forms.DateTimePicker дата_рожденияDateTimePicker;
        private System.Windows.Forms.TextBox имяTextBox;
        private System.Windows.Forms.TextBox кодTextBox;
        private System.Windows.Forms.TextBox кодДолжностиTextBox;
        private System.Windows.Forms.TextBox кодКатегорииTextBox;
        private System.Windows.Forms.TextBox образованиеTextBox;
        private System.Windows.Forms.TextBox отчествоTextBox;
        private System.Windows.Forms.TextBox полTextBox;
        private System.Windows.Forms.TextBox телефонTextBox;
        private System.Windows.Forms.TextBox ученная_степеньTextBox;
        private System.Windows.Forms.TextBox фамилияTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox зарплата_в_мес_рубTextBox;
    }
}