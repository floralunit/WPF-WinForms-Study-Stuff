
namespace WinFormsApp_FormatOutputBox_59028
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
            this.groupBox_Input = new System.Windows.Forms.GroupBox();
            this.pictureBox_Preview = new System.Windows.Forms.PictureBox();
            this.listBox_Input = new System.Windows.Forms.ListBox();
            this.label_B = new System.Windows.Forms.Label();
            this.label_A = new System.Windows.Forms.Label();
            this.textBox_B = new System.Windows.Forms.TextBox();
            this.textBox_A = new System.Windows.Forms.TextBox();
            this.richTextBox_Output = new System.Windows.Forms.RichTextBox();
            this.button_Evaluate = new System.Windows.Forms.Button();
            this.button_Clear = new System.Windows.Forms.Button();
            this.groupBox_Input.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Preview)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox_Input
            // 
            this.groupBox_Input.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox_Input.Controls.Add(this.pictureBox_Preview);
            this.groupBox_Input.Controls.Add(this.listBox_Input);
            this.groupBox_Input.Controls.Add(this.label_B);
            this.groupBox_Input.Controls.Add(this.label_A);
            this.groupBox_Input.Controls.Add(this.textBox_B);
            this.groupBox_Input.Controls.Add(this.textBox_A);
            this.groupBox_Input.Location = new System.Drawing.Point(12, 283);
            this.groupBox_Input.Name = "groupBox_Input";
            this.groupBox_Input.Size = new System.Drawing.Size(712, 244);
            this.groupBox_Input.TabIndex = 0;
            this.groupBox_Input.TabStop = false;
            this.groupBox_Input.Text = "Выбор исходных данных";
            // 
            // pictureBox_Preview
            // 
            this.pictureBox_Preview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox_Preview.Image = global::WinFormsApp_FormatOutputBox_59028.Properties.Resources.Operation_None;
            this.pictureBox_Preview.InitialImage = global::WinFormsApp_FormatOutputBox_59028.Properties.Resources.Operation_None;
            this.pictureBox_Preview.Location = new System.Drawing.Point(454, 106);
            this.pictureBox_Preview.Name = "pictureBox_Preview";
            this.pictureBox_Preview.Size = new System.Drawing.Size(150, 50);
            this.pictureBox_Preview.TabIndex = 4;
            this.pictureBox_Preview.TabStop = false;
            // 
            // listBox_Input
            // 
            this.listBox_Input.BackColor = System.Drawing.Color.PeachPuff;
            this.listBox_Input.FormattingEnabled = true;
            this.listBox_Input.ItemHeight = 20;
            this.listBox_Input.Items.AddRange(new object[] {
            "<Нет действий>",
            ">>",
            ">>=",
            "^",
            "^="});
            this.listBox_Input.Location = new System.Drawing.Point(6, 40);
            this.listBox_Input.Name = "listBox_Input";
            this.listBox_Input.Size = new System.Drawing.Size(341, 184);
            this.listBox_Input.TabIndex = 5;
            this.listBox_Input.SelectedIndexChanged += new System.EventHandler(this.listBox_Input_SelectedIndexChanged);
            // 
            // label_B
            // 
            this.label_B.AutoSize = true;
            this.label_B.Location = new System.Drawing.Point(364, 204);
            this.label_B.Name = "label_B";
            this.label_B.Size = new System.Drawing.Size(111, 20);
            this.label_B.TabIndex = 3;
            this.label_B.Text = "Переменная B";
            // 
            // label_A
            // 
            this.label_A.AutoSize = true;
            this.label_A.Location = new System.Drawing.Point(370, 40);
            this.label_A.Name = "label_A";
            this.label_A.Size = new System.Drawing.Size(112, 20);
            this.label_A.TabIndex = 2;
            this.label_A.Text = "Переменная A";
            // 
            // textBox_B
            // 
            this.textBox_B.BackColor = System.Drawing.Color.PeachPuff;
            this.textBox_B.Location = new System.Drawing.Point(561, 197);
            this.textBox_B.Name = "textBox_B";
            this.textBox_B.Size = new System.Drawing.Size(125, 27);
            this.textBox_B.TabIndex = 1;
            this.textBox_B.TextChanged += new System.EventHandler(this.textBox_B_TextChanged);
            this.textBox_B.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_B_KeyPress);
            // 
            // textBox_A
            // 
            this.textBox_A.BackColor = System.Drawing.Color.PeachPuff;
            this.textBox_A.Location = new System.Drawing.Point(561, 40);
            this.textBox_A.Name = "textBox_A";
            this.textBox_A.Size = new System.Drawing.Size(125, 27);
            this.textBox_A.TabIndex = 0;
            this.textBox_A.TextChanged += new System.EventHandler(this.textBox_A_TextChanged);
            this.textBox_A.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_A_KeyPress);
            // 
            // richTextBox_Output
            // 
            this.richTextBox_Output.BackColor = System.Drawing.Color.Pink;
            this.richTextBox_Output.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.richTextBox_Output.Location = new System.Drawing.Point(12, 12);
            this.richTextBox_Output.Name = "richTextBox_Output";
            this.richTextBox_Output.ReadOnly = true;
            this.richTextBox_Output.Size = new System.Drawing.Size(711, 265);
            this.richTextBox_Output.TabIndex = 6;
            this.richTextBox_Output.Text = "";
            // 
            // button_Evaluate
            // 
            this.button_Evaluate.BackColor = System.Drawing.Color.Pink;
            this.button_Evaluate.Location = new System.Drawing.Point(12, 538);
            this.button_Evaluate.Name = "button_Evaluate";
            this.button_Evaluate.Size = new System.Drawing.Size(347, 29);
            this.button_Evaluate.TabIndex = 7;
            this.button_Evaluate.Text = "Выполнить расчет";
            this.button_Evaluate.UseVisualStyleBackColor = false;
            this.button_Evaluate.Click += new System.EventHandler(this.button_Evaluate_Click);
            // 
            // button_Clear
            // 
            this.button_Clear.BackColor = System.Drawing.Color.PeachPuff;
            this.button_Clear.Location = new System.Drawing.Point(376, 540);
            this.button_Clear.Name = "button_Clear";
            this.button_Clear.Size = new System.Drawing.Size(347, 29);
            this.button_Clear.TabIndex = 8;
            this.button_Clear.Text = "Очистить";
            this.button_Clear.UseVisualStyleBackColor = false;
            this.button_Clear.Click += new System.EventHandler(this.button_Clear_Click);
            // 
            // form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(735, 581);
            this.Controls.Add(this.button_Clear);
            this.Controls.Add(this.button_Evaluate);
            this.Controls.Add(this.richTextBox_Output);
            this.Controls.Add(this.groupBox_Input);
            this.Name = "form_Main";
            this.Text = "Форматный вывод данных";
            this.groupBox_Input.ResumeLayout(false);
            this.groupBox_Input.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Preview)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_Input;
        private System.Windows.Forms.PictureBox pictureBox_Preview;
        private System.Windows.Forms.ListBox listBox_Input;
        private System.Windows.Forms.Label label_B;
        private System.Windows.Forms.Label label_A;
        private System.Windows.Forms.TextBox textBox_B;
        private System.Windows.Forms.TextBox textBox_A;
        private System.Windows.Forms.RichTextBox richTextBox_Output;
        private System.Windows.Forms.Button button_Evaluate;
        private System.Windows.Forms.Button button_Clear;
    }
}

