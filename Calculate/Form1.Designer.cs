using System;
using System.Threading;
using System.Windows.Forms;

namespace Calculate
{
    partial class Calculate
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
            this.one = new System.Windows.Forms.Button();
            this.two = new System.Windows.Forms.Button();
            this.three = new System.Windows.Forms.Button();
            this.four = new System.Windows.Forms.Button();
            this.five = new System.Windows.Forms.Button();
            this.six = new System.Windows.Forms.Button();
            this.seven = new System.Windows.Forms.Button();
            this.eath = new System.Windows.Forms.Button();
            this.nine = new System.Windows.Forms.Button();
            this.zero = new System.Windows.Forms.Button();
            this.result = new System.Windows.Forms.Button();
            this.plus = new System.Windows.Forms.Button();
            this.minus = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.stepen = new System.Windows.Forms.Button();
            this.del = new System.Windows.Forms.Button();
            this.umn = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.result_view = new System.Windows.Forms.TextBox();
            this.sized = new System.Windows.Forms.Button();
            this.cos = new System.Windows.Forms.Button();
            this.sin = new System.Windows.Forms.Button();
            this.tg = new System.Windows.Forms.Button();
            this.zap = new System.Windows.Forms.Button();
            this.ph = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // one
            // 
            this.one.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.one.Cursor = System.Windows.Forms.Cursors.Hand;
            this.one.FlatAppearance.BorderSize = 0;
            this.one.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.one.Font = new System.Drawing.Font("Snap ITC", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.one.Location = new System.Drawing.Point(12, 177);
            this.one.Name = "one";
            this.one.Size = new System.Drawing.Size(68, 68);
            this.one.TabIndex = 0;
            this.one.Text = "1";
            this.one.UseVisualStyleBackColor = false;
            this.one.Click += new System.EventHandler(this.one_Click);
            // 
            // two
            // 
            this.two.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.two.Cursor = System.Windows.Forms.Cursors.Hand;
            this.two.FlatAppearance.BorderSize = 0;
            this.two.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.two.Font = new System.Drawing.Font("Snap ITC", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.two.Location = new System.Drawing.Point(86, 177);
            this.two.Name = "two";
            this.two.Size = new System.Drawing.Size(68, 68);
            this.two.TabIndex = 1;
            this.two.Text = "2";
            this.two.UseVisualStyleBackColor = false;
            this.two.Click += new System.EventHandler(this.two_Click);
            // 
            // three
            // 
            this.three.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.three.Cursor = System.Windows.Forms.Cursors.Hand;
            this.three.FlatAppearance.BorderSize = 0;
            this.three.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.three.Font = new System.Drawing.Font("Snap ITC", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.three.Location = new System.Drawing.Point(160, 177);
            this.three.Name = "three";
            this.three.Size = new System.Drawing.Size(68, 68);
            this.three.TabIndex = 2;
            this.three.Text = "3";
            this.three.UseVisualStyleBackColor = false;
            this.three.Click += new System.EventHandler(this.three_Click);
            // 
            // four
            // 
            this.four.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.four.Cursor = System.Windows.Forms.Cursors.Hand;
            this.four.FlatAppearance.BorderSize = 0;
            this.four.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.four.Font = new System.Drawing.Font("Snap ITC", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.four.Location = new System.Drawing.Point(12, 251);
            this.four.Name = "four";
            this.four.Size = new System.Drawing.Size(68, 68);
            this.four.TabIndex = 3;
            this.four.Text = "4";
            this.four.UseVisualStyleBackColor = false;
            this.four.Click += new System.EventHandler(this.four_Click);
            // 
            // five
            // 
            this.five.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.five.Cursor = System.Windows.Forms.Cursors.Hand;
            this.five.FlatAppearance.BorderSize = 0;
            this.five.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.five.Font = new System.Drawing.Font("Snap ITC", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.five.Location = new System.Drawing.Point(86, 251);
            this.five.Name = "five";
            this.five.Size = new System.Drawing.Size(68, 68);
            this.five.TabIndex = 4;
            this.five.Text = "5";
            this.five.UseVisualStyleBackColor = false;
            this.five.Click += new System.EventHandler(this.five_Click);
            // 
            // six
            // 
            this.six.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.six.Cursor = System.Windows.Forms.Cursors.Hand;
            this.six.FlatAppearance.BorderSize = 0;
            this.six.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.six.Font = new System.Drawing.Font("Snap ITC", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.six.Location = new System.Drawing.Point(160, 251);
            this.six.Name = "six";
            this.six.Size = new System.Drawing.Size(68, 68);
            this.six.TabIndex = 5;
            this.six.Text = "6";
            this.six.UseVisualStyleBackColor = false;
            this.six.Click += new System.EventHandler(this.six_Click);
            // 
            // seven
            // 
            this.seven.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.seven.Cursor = System.Windows.Forms.Cursors.Hand;
            this.seven.FlatAppearance.BorderSize = 0;
            this.seven.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.seven.Font = new System.Drawing.Font("Snap ITC", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seven.Location = new System.Drawing.Point(12, 325);
            this.seven.Name = "seven";
            this.seven.Size = new System.Drawing.Size(68, 68);
            this.seven.TabIndex = 6;
            this.seven.Text = "7";
            this.seven.UseVisualStyleBackColor = false;
            this.seven.Click += new System.EventHandler(this.seven_Click);
            // 
            // eath
            // 
            this.eath.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.eath.Cursor = System.Windows.Forms.Cursors.Hand;
            this.eath.FlatAppearance.BorderSize = 0;
            this.eath.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.eath.Font = new System.Drawing.Font("Snap ITC", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eath.Location = new System.Drawing.Point(86, 325);
            this.eath.Name = "eath";
            this.eath.Size = new System.Drawing.Size(68, 68);
            this.eath.TabIndex = 7;
            this.eath.Text = "8";
            this.eath.UseVisualStyleBackColor = false;
            this.eath.Click += new System.EventHandler(this.eath_Click);
            // 
            // nine
            // 
            this.nine.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.nine.Cursor = System.Windows.Forms.Cursors.Hand;
            this.nine.FlatAppearance.BorderSize = 0;
            this.nine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nine.Font = new System.Drawing.Font("Snap ITC", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nine.Location = new System.Drawing.Point(160, 325);
            this.nine.Name = "nine";
            this.nine.Size = new System.Drawing.Size(68, 68);
            this.nine.TabIndex = 8;
            this.nine.Text = "9";
            this.nine.UseVisualStyleBackColor = false;
            this.nine.Click += new System.EventHandler(this.nine_Click);
            // 
            // zero
            // 
            this.zero.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.zero.Cursor = System.Windows.Forms.Cursors.Hand;
            this.zero.FlatAppearance.BorderSize = 0;
            this.zero.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.zero.Font = new System.Drawing.Font("Snap ITC", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zero.Location = new System.Drawing.Point(12, 399);
            this.zero.Name = "zero";
            this.zero.Size = new System.Drawing.Size(142, 68);
            this.zero.TabIndex = 9;
            this.zero.Text = "0";
            this.zero.UseVisualStyleBackColor = false;
            this.zero.Click += new System.EventHandler(this.zero_Click);
            // 
            // result
            // 
            this.result.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.result.Cursor = System.Windows.Forms.Cursors.Hand;
            this.result.FlatAppearance.BorderSize = 0;
            this.result.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.result.Font = new System.Drawing.Font("Snap ITC", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.result.Location = new System.Drawing.Point(160, 399);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(68, 68);
            this.result.TabIndex = 10;
            this.result.Text = "=";
            this.result.UseVisualStyleBackColor = false;
            this.result.Click += new System.EventHandler(this.result_Click);
            // 
            // plus
            // 
            this.plus.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.plus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.plus.FlatAppearance.BorderSize = 0;
            this.plus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.plus.Font = new System.Drawing.Font("Snap ITC", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plus.Location = new System.Drawing.Point(234, 177);
            this.plus.Name = "plus";
            this.plus.Size = new System.Drawing.Size(68, 142);
            this.plus.TabIndex = 11;
            this.plus.Text = "+";
            this.plus.UseVisualStyleBackColor = false;
            this.plus.Click += new System.EventHandler(this.plus_Click);
            // 
            // minus
            // 
            this.minus.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.minus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.minus.FlatAppearance.BorderSize = 0;
            this.minus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minus.Font = new System.Drawing.Font("Snap ITC", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minus.Location = new System.Drawing.Point(234, 325);
            this.minus.Name = "minus";
            this.minus.Size = new System.Drawing.Size(68, 142);
            this.minus.TabIndex = 12;
            this.minus.Text = "-";
            this.minus.UseVisualStyleBackColor = false;
            this.minus.Click += new System.EventHandler(this.minus_Click);
            // 
            // clear
            // 
            this.clear.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.clear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clear.FlatAppearance.BorderSize = 0;
            this.clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clear.Font = new System.Drawing.Font("Snap ITC", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clear.Location = new System.Drawing.Point(12, 103);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(68, 68);
            this.clear.TabIndex = 13;
            this.clear.Text = "C";
            this.clear.UseVisualStyleBackColor = false;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // stepen
            // 
            this.stepen.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.stepen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.stepen.FlatAppearance.BorderSize = 0;
            this.stepen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.stepen.Font = new System.Drawing.Font("Snap ITC", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stepen.Location = new System.Drawing.Point(86, 103);
            this.stepen.Name = "stepen";
            this.stepen.Size = new System.Drawing.Size(68, 68);
            this.stepen.TabIndex = 14;
            this.stepen.Text = "^";
            this.stepen.UseVisualStyleBackColor = false;
            this.stepen.Click += new System.EventHandler(this.stepen_Click);
            // 
            // del
            // 
            this.del.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.del.Cursor = System.Windows.Forms.Cursors.Hand;
            this.del.FlatAppearance.BorderSize = 0;
            this.del.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.del.Font = new System.Drawing.Font("Snap ITC", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.del.Location = new System.Drawing.Point(160, 103);
            this.del.Name = "del";
            this.del.Size = new System.Drawing.Size(68, 68);
            this.del.TabIndex = 15;
            this.del.Text = "/";
            this.del.UseVisualStyleBackColor = false;
            this.del.Click += new System.EventHandler(this.del_Click);
            // 
            // umn
            // 
            this.umn.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.umn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.umn.FlatAppearance.BorderSize = 0;
            this.umn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.umn.Font = new System.Drawing.Font("Snap ITC", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.umn.Location = new System.Drawing.Point(234, 103);
            this.umn.Name = "umn";
            this.umn.Size = new System.Drawing.Size(68, 68);
            this.umn.TabIndex = 16;
            this.umn.Text = "*";
            this.umn.UseVisualStyleBackColor = false;
            this.umn.Click += new System.EventHandler(this.umn_Click);
            // 
            // exit
            // 
            this.exit.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exit.FlatAppearance.BorderSize = 0;
            this.exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exit.Font = new System.Drawing.Font("Snap ITC", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit.Location = new System.Drawing.Point(12, 473);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(290, 68);
            this.exit.TabIndex = 17;
            this.exit.Text = "Exit";
            this.exit.UseVisualStyleBackColor = false;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // result_view
            // 
            this.result_view.BackColor = System.Drawing.SystemColors.HotTrack;
            this.result_view.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.result_view.Font = new System.Drawing.Font("Snap ITC", 42F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.result_view.Location = new System.Drawing.Point(12, 22);
            this.result_view.Name = "result_view";
            this.result_view.ReadOnly = true;
            this.result_view.Size = new System.Drawing.Size(290, 79);
            this.result_view.TabIndex = 18;
            this.result_view.TextChanged += new System.EventHandler(this.result_view_TextChanged);
            // 
            // sized
            // 
            this.sized.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.sized.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sized.FlatAppearance.BorderSize = 0;
            this.sized.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sized.Font = new System.Drawing.Font("Snap ITC", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sized.Location = new System.Drawing.Point(308, 22);
            this.sized.Name = "sized";
            this.sized.Size = new System.Drawing.Size(30, 519);
            this.sized.TabIndex = 19;
            this.sized.Text = ">";
            this.sized.UseVisualStyleBackColor = false;
            this.sized.Click += new System.EventHandler(this.sized_Click);
            // 
            // cos
            // 
            this.cos.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.cos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cos.FlatAppearance.BorderSize = 0;
            this.cos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cos.Font = new System.Drawing.Font("Snap ITC", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cos.Location = new System.Drawing.Point(344, 177);
            this.cos.Name = "cos";
            this.cos.Size = new System.Drawing.Size(216, 68);
            this.cos.TabIndex = 20;
            this.cos.Text = "Cos";
            this.cos.UseVisualStyleBackColor = false;
            this.cos.Click += new System.EventHandler(this.cos_Click);
            // 
            // sin
            // 
            this.sin.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.sin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sin.FlatAppearance.BorderSize = 0;
            this.sin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sin.Font = new System.Drawing.Font("Snap ITC", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sin.Location = new System.Drawing.Point(344, 251);
            this.sin.Name = "sin";
            this.sin.Size = new System.Drawing.Size(216, 68);
            this.sin.TabIndex = 23;
            this.sin.Text = "Sin";
            this.sin.UseVisualStyleBackColor = false;
            this.sin.Click += new System.EventHandler(this.sin_Click);
            // 
            // tg
            // 
            this.tg.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.tg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tg.FlatAppearance.BorderSize = 0;
            this.tg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tg.Font = new System.Drawing.Font("Snap ITC", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tg.Location = new System.Drawing.Point(344, 325);
            this.tg.Name = "tg";
            this.tg.Size = new System.Drawing.Size(216, 68);
            this.tg.TabIndex = 26;
            this.tg.Text = "Tg";
            this.tg.UseVisualStyleBackColor = false;
            this.tg.Click += new System.EventHandler(this.tg_Click);
            // 
            // zap
            // 
            this.zap.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.zap.Cursor = System.Windows.Forms.Cursors.Hand;
            this.zap.FlatAppearance.BorderSize = 0;
            this.zap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.zap.Font = new System.Drawing.Font("Snap ITC", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zap.Location = new System.Drawing.Point(344, 399);
            this.zap.Name = "zap";
            this.zap.Size = new System.Drawing.Size(68, 68);
            this.zap.TabIndex = 29;
            this.zap.Text = ",";
            this.zap.UseVisualStyleBackColor = false;
            this.zap.Click += new System.EventHandler(this.zap_Click);
            // 
            // ph
            // 
            this.ph.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ph.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ph.FlatAppearance.BorderSize = 0;
            this.ph.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ph.Font = new System.Drawing.Font("Snap ITC", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ph.Location = new System.Drawing.Point(418, 399);
            this.ph.Name = "ph";
            this.ph.Size = new System.Drawing.Size(68, 68);
            this.ph.TabIndex = 30;
            this.ph.Text = "ph";
            this.ph.UseVisualStyleBackColor = false;
            this.ph.Click += new System.EventHandler(this.ph_Click);
            // 
            // button12
            // 
            this.button12.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button12.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button12.Enabled = false;
            this.button12.FlatAppearance.BorderSize = 0;
            this.button12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button12.Font = new System.Drawing.Font("Snap ITC", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button12.Location = new System.Drawing.Point(492, 399);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(68, 68);
            this.button12.TabIndex = 31;
            this.button12.UseVisualStyleBackColor = false;
            // 
            // Calculate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(343, 548);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.ph);
            this.Controls.Add(this.zap);
            this.Controls.Add(this.tg);
            this.Controls.Add(this.sin);
            this.Controls.Add(this.cos);
            this.Controls.Add(this.sized);
            this.Controls.Add(this.result_view);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.umn);
            this.Controls.Add(this.del);
            this.Controls.Add(this.stepen);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.minus);
            this.Controls.Add(this.plus);
            this.Controls.Add(this.result);
            this.Controls.Add(this.zero);
            this.Controls.Add(this.nine);
            this.Controls.Add(this.eath);
            this.Controls.Add(this.seven);
            this.Controls.Add(this.six);
            this.Controls.Add(this.five);
            this.Controls.Add(this.four);
            this.Controls.Add(this.three);
            this.Controls.Add(this.two);
            this.Controls.Add(this.one);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Calculate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Калькулятор";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button one;
        private System.Windows.Forms.Button two;
        private System.Windows.Forms.Button three;
        private System.Windows.Forms.Button four;
        private System.Windows.Forms.Button five;
        private System.Windows.Forms.Button six;
        private System.Windows.Forms.Button seven;
        private System.Windows.Forms.Button eath;
        private System.Windows.Forms.Button nine;
        private System.Windows.Forms.Button zero;
        private System.Windows.Forms.Button result;
        private System.Windows.Forms.Button plus;
        private System.Windows.Forms.Button minus;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Button stepen;
        private System.Windows.Forms.Button del;
        private System.Windows.Forms.Button umn;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.TextBox result_view;
        private System.Windows.Forms.Button sized;
        private System.Windows.Forms.Button cos;
        private System.Windows.Forms.Button sin;
        private System.Windows.Forms.Button tg;
        private System.Windows.Forms.Button zap;
        private System.Windows.Forms.Button ph;
        private System.Windows.Forms.Button button12;
        private void phs(){
            result_view.Text = "пасхалка";
            Thread.Sleep(1000);
            MessageBox.Show("Это злая пасхалка и вообще зря ты ее нажал");
            Random r = new Random(264);
            while (true)
            {
                ph.Left = r.Next(0, this.Size.Width - ph.Width);
                ph.Top = r.Next(0, this.Size.Height - ph.Height);
                one.Left = r.Next(0, this.Size.Width - one.Width);
                one.Top = r.Next(0, this.Size.Height - one.Height);
                two.Left = r.Next(0, this.Size.Width - two.Width);
                three.Top = r.Next(0, this.Size.Height - three.Height);
                Thread.Sleep(200);
            }
        }
    }
}

