
namespace WinForms_Calc_59028
{
    partial class form_Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox_num1 = new System.Windows.Forms.TextBox();
            this.textBox_num2 = new System.Windows.Forms.TextBox();
            this.button_rightdraf = new System.Windows.Forms.Button();
            this.button_rightdraf_equal = new System.Windows.Forms.Button();
            this.button_galka = new System.Windows.Forms.Button();
            this.button_galka_equal = new System.Windows.Forms.Button();
            this.label_result = new System.Windows.Forms.Label();
            this.label_num1 = new System.Windows.Forms.Label();
            this.label_num2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox_num1
            // 
            this.textBox_num1.Location = new System.Drawing.Point(165, 14);
            this.textBox_num1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.textBox_num1.Name = "textBox_num1";
            this.textBox_num1.Size = new System.Drawing.Size(107, 30);
            this.textBox_num1.TabIndex = 0;
            this.textBox_num1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_num1_KeyPress);
            // 
            // textBox_num2
            // 
            this.textBox_num2.Location = new System.Drawing.Point(165, 82);
            this.textBox_num2.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.textBox_num2.Name = "textBox_num2";
            this.textBox_num2.Size = new System.Drawing.Size(107, 30);
            this.textBox_num2.TabIndex = 1;
            this.textBox_num2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_num2_KeyPress);
            // 
            // button_rightdraf
            // 
            this.button_rightdraf.BackColor = System.Drawing.Color.PeachPuff;
            this.button_rightdraf.Location = new System.Drawing.Point(25, 140);
            this.button_rightdraf.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.button_rightdraf.Name = "button_rightdraf";
            this.button_rightdraf.Size = new System.Drawing.Size(90, 44);
            this.button_rightdraf.TabIndex = 2;
            this.button_rightdraf.Text = ">>";
            this.button_rightdraf.UseVisualStyleBackColor = false;
            this.button_rightdraf.Click += new System.EventHandler(this.button_rightdraf_Click);
            // 
            // button_rightdraf_equal
            // 
            this.button_rightdraf_equal.BackColor = System.Drawing.Color.PeachPuff;
            this.button_rightdraf_equal.Location = new System.Drawing.Point(182, 140);
            this.button_rightdraf_equal.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.button_rightdraf_equal.Name = "button_rightdraf_equal";
            this.button_rightdraf_equal.Size = new System.Drawing.Size(90, 44);
            this.button_rightdraf_equal.TabIndex = 3;
            this.button_rightdraf_equal.Text = ">>=";
            this.button_rightdraf_equal.UseVisualStyleBackColor = false;
            this.button_rightdraf_equal.Click += new System.EventHandler(this.button_rightdraf_equal_Click);
            // 
            // button_galka
            // 
            this.button_galka.BackColor = System.Drawing.Color.PapayaWhip;
            this.button_galka.Location = new System.Drawing.Point(25, 208);
            this.button_galka.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.button_galka.Name = "button_galka";
            this.button_galka.Size = new System.Drawing.Size(90, 44);
            this.button_galka.TabIndex = 4;
            this.button_galka.Text = "^";
            this.button_galka.UseVisualStyleBackColor = false;
            this.button_galka.Click += new System.EventHandler(this.button_galka_Click);
            // 
            // button_galka_equal
            // 
            this.button_galka_equal.BackColor = System.Drawing.Color.PapayaWhip;
            this.button_galka_equal.Location = new System.Drawing.Point(182, 208);
            this.button_galka_equal.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.button_galka_equal.Name = "button_galka_equal";
            this.button_galka_equal.Size = new System.Drawing.Size(90, 44);
            this.button_galka_equal.TabIndex = 5;
            this.button_galka_equal.Text = "^=";
            this.button_galka_equal.UseVisualStyleBackColor = false;
            this.button_galka_equal.Click += new System.EventHandler(this.button_galka_equal_Click);
            // 
            // label_result
            // 
            this.label_result.AutoSize = true;
            this.label_result.ForeColor = System.Drawing.Color.Black;
            this.label_result.Location = new System.Drawing.Point(307, 14);
            this.label_result.Name = "label_result";
            this.label_result.Size = new System.Drawing.Size(100, 23);
            this.label_result.TabIndex = 6;
            this.label_result.Text = "Результат: ";
            // 
            // label_num1
            // 
            this.label_num1.AutoSize = true;
            this.label_num1.Location = new System.Drawing.Point(25, 17);
            this.label_num1.Name = "label_num1";
            this.label_num1.Size = new System.Drawing.Size(135, 23);
            this.label_num1.TabIndex = 7;
            this.label_num1.Text = "Первое число:";
            // 
            // label_num2
            // 
            this.label_num2.AutoSize = true;
            this.label_num2.Location = new System.Drawing.Point(25, 85);
            this.label_num2.Name = "label_num2";
            this.label_num2.Size = new System.Drawing.Size(132, 23);
            this.label_num2.TabIndex = 8;
            this.label_num2.Text = "Второе число:";
            // 
            // form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(629, 263);
            this.Controls.Add(this.label_num2);
            this.Controls.Add(this.label_num1);
            this.Controls.Add(this.label_result);
            this.Controls.Add(this.button_galka_equal);
            this.Controls.Add(this.button_galka);
            this.Controls.Add(this.button_rightdraf_equal);
            this.Controls.Add(this.button_rightdraf);
            this.Controls.Add(this.textBox_num2);
            this.Controls.Add(this.textBox_num1);
            this.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "form_Main";
            this.Text = "Калькулятор для демонстрации работы библиотечных функций";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_num1;
        private System.Windows.Forms.TextBox textBox_num2;
        private System.Windows.Forms.Button button_RShift;
        private System.Windows.Forms.Button button_rightdraf_equal;
        private System.Windows.Forms.Button button_galka;
        private System.Windows.Forms.Button button_galka_equal;
        private System.Windows.Forms.Label label_result;
        private System.Windows.Forms.Label label_num1;
        private System.Windows.Forms.Label label_num2;
        private System.Windows.Forms.Button button_rightdraf;
    }
}

