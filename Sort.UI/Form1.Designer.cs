﻿
namespace Sort.UI
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.Add_button = new System.Windows.Forms.Button();
            this.Add_textBox = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.feel_button = new System.Windows.Forms.Button();
            this.feel_textBox = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.Start_BubleSort_button = new System.Windows.Forms.Button();
            this.CoctailSort_button = new System.Windows.Forms.Button();
            this.InsertionSort_button = new System.Windows.Forms.Button();
            this.ShellSort_button = new System.Windows.Forms.Button();
            this.MergeSort_button = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.quickSort_button = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.Add_button);
            this.panel1.Controls.Add(this.Add_textBox);
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(361, 61);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Добавить чило";
            // 
            // Add_button
            // 
            this.Add_button.Location = new System.Drawing.Point(259, 25);
            this.Add_button.Name = "Add_button";
            this.Add_button.Size = new System.Drawing.Size(99, 24);
            this.Add_button.TabIndex = 1;
            this.Add_button.Text = "Добавить";
            this.Add_button.UseVisualStyleBackColor = true;
            this.Add_button.Click += new System.EventHandler(this.Add_button_Click);
            // 
            // Add_textBox
            // 
            this.Add_textBox.Location = new System.Drawing.Point(3, 27);
            this.Add_textBox.Name = "Add_textBox";
            this.Add_textBox.Size = new System.Drawing.Size(250, 22);
            this.Add_textBox.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.feel_button);
            this.panel2.Controls.Add(this.feel_textBox);
            this.panel2.Location = new System.Drawing.Point(13, 80);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(361, 61);
            this.panel2.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(274, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Заполнить массив случайными числами";
            // 
            // feel_button
            // 
            this.feel_button.Location = new System.Drawing.Point(259, 25);
            this.feel_button.Name = "feel_button";
            this.feel_button.Size = new System.Drawing.Size(99, 24);
            this.feel_button.TabIndex = 1;
            this.feel_button.Text = "Заполнить";
            this.feel_button.UseVisualStyleBackColor = true;
            this.feel_button.Click += new System.EventHandler(this.feel_button_Click);
            // 
            // feel_textBox
            // 
            this.feel_textBox.Location = new System.Drawing.Point(3, 27);
            this.feel_textBox.Name = "feel_textBox";
            this.feel_textBox.Size = new System.Drawing.Size(250, 22);
            this.feel_textBox.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(381, 13);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(646, 34);
            this.panel3.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 17);
            this.label3.TabIndex = 0;
            // 
            // Start_BubleSort_button
            // 
            this.Start_BubleSort_button.Location = new System.Drawing.Point(381, 53);
            this.Start_BubleSort_button.Name = "Start_BubleSort_button";
            this.Start_BubleSort_button.Size = new System.Drawing.Size(137, 23);
            this.Start_BubleSort_button.TabIndex = 3;
            this.Start_BubleSort_button.Text = "Buble Sort";
            this.Start_BubleSort_button.UseVisualStyleBackColor = true;
            this.Start_BubleSort_button.Click += new System.EventHandler(this.Start_BubleSort_button_Click);
            // 
            // CoctailSort_button
            // 
            this.CoctailSort_button.Location = new System.Drawing.Point(524, 53);
            this.CoctailSort_button.Name = "CoctailSort_button";
            this.CoctailSort_button.Size = new System.Drawing.Size(146, 24);
            this.CoctailSort_button.TabIndex = 4;
            this.CoctailSort_button.Text = "CoctailSort";
            this.CoctailSort_button.UseVisualStyleBackColor = true;
            this.CoctailSort_button.Click += new System.EventHandler(this.CoctailSort_button_Click);
            // 
            // InsertionSort_button
            // 
            this.InsertionSort_button.Location = new System.Drawing.Point(676, 51);
            this.InsertionSort_button.Name = "InsertionSort_button";
            this.InsertionSort_button.Size = new System.Drawing.Size(116, 28);
            this.InsertionSort_button.TabIndex = 5;
            this.InsertionSort_button.Text = "InsertionSort";
            this.InsertionSort_button.UseVisualStyleBackColor = true;
            this.InsertionSort_button.Click += new System.EventHandler(this.InsertionSort_button_Click);
            // 
            // ShellSort_button
            // 
            this.ShellSort_button.Location = new System.Drawing.Point(798, 51);
            this.ShellSort_button.Name = "ShellSort_button";
            this.ShellSort_button.Size = new System.Drawing.Size(96, 27);
            this.ShellSort_button.TabIndex = 6;
            this.ShellSort_button.Text = "ShellSort";
            this.ShellSort_button.UseVisualStyleBackColor = true;
            this.ShellSort_button.Click += new System.EventHandler(this.ShellSort_button_Click);
            // 
            // MergeSort_button
            // 
            this.MergeSort_button.Location = new System.Drawing.Point(716, 82);
            this.MergeSort_button.Name = "MergeSort_button";
            this.MergeSort_button.Size = new System.Drawing.Size(311, 25);
            this.MergeSort_button.TabIndex = 7;
            this.MergeSort_button.Text = "MergeSort";
            this.MergeSort_button.UseVisualStyleBackColor = true;
            this.MergeSort_button.Click += new System.EventHandler(this.MergeSort_button_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(900, 51);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 26);
            this.button1.TabIndex = 8;
            this.button1.Text = "SelectionSort";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // quickSort_button
            // 
            this.quickSort_button.Location = new System.Drawing.Point(381, 84);
            this.quickSort_button.Name = "quickSort_button";
            this.quickSort_button.Size = new System.Drawing.Size(329, 23);
            this.quickSort_button.TabIndex = 9;
            this.quickSort_button.Text = "QUICKSORT";
            this.quickSort_button.UseVisualStyleBackColor = true;
            this.quickSort_button.Click += new System.EventHandler(this.quickSort_button_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(378, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Время: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(560, 112);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(150, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Количество обменов:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(823, 112);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(164, 17);
            this.label6.TabIndex = 12;
            this.label6.Text = "Количество сравнений:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1039, 157);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.quickSort_button);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.MergeSort_button);
            this.Controls.Add(this.ShellSort_button);
            this.Controls.Add(this.InsertionSort_button);
            this.Controls.Add(this.CoctailSort_button);
            this.Controls.Add(this.Start_BubleSort_button);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Add_button;
        private System.Windows.Forms.TextBox Add_textBox;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button feel_button;
        private System.Windows.Forms.TextBox feel_textBox;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Start_BubleSort_button;
        private System.Windows.Forms.Button CoctailSort_button;
        private System.Windows.Forms.Button InsertionSort_button;
        private System.Windows.Forms.Button ShellSort_button;
        private System.Windows.Forms.Button MergeSort_button;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button quickSort_button;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

