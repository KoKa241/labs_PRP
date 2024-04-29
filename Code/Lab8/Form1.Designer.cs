
namespace Lab8
{
    partial class Form1
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
            this.button_calc = new System.Windows.Forms.Button();
            this.button_clear = new System.Windows.Forms.Button();
            this.button_exit = new System.Windows.Forms.Button();
            this.x1_textbox = new System.Windows.Forms.TextBox();
            this.x2_textbox = new System.Windows.Forms.TextBox();
            this.result_textbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.avarage_textbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button_calc
            // 
            this.button_calc.Location = new System.Drawing.Point(18, 265);
            this.button_calc.Name = "button_calc";
            this.button_calc.Size = new System.Drawing.Size(75, 23);
            this.button_calc.TabIndex = 0;
            this.button_calc.Text = "Обчислити";
            this.button_calc.UseVisualStyleBackColor = true;
            this.button_calc.Click += new System.EventHandler(this.button_calc_Click);
            // 
            // button_clear
            // 
            this.button_clear.Location = new System.Drawing.Point(133, 265);
            this.button_clear.Name = "button_clear";
            this.button_clear.Size = new System.Drawing.Size(75, 23);
            this.button_clear.TabIndex = 1;
            this.button_clear.Text = "Очистити";
            this.button_clear.UseVisualStyleBackColor = true;
            this.button_clear.Click += new System.EventHandler(this.button_clear_Click);
            // 
            // button_exit
            // 
            this.button_exit.Location = new System.Drawing.Point(244, 265);
            this.button_exit.Name = "button_exit";
            this.button_exit.Size = new System.Drawing.Size(75, 23);
            this.button_exit.TabIndex = 2;
            this.button_exit.Text = "Вихід";
            this.button_exit.UseVisualStyleBackColor = true;
            this.button_exit.Click += new System.EventHandler(this.button_exit_Click);
            // 
            // x1_textbox
            // 
            this.x1_textbox.Location = new System.Drawing.Point(219, 52);
            this.x1_textbox.Name = "x1_textbox";
            this.x1_textbox.Size = new System.Drawing.Size(100, 20);
            this.x1_textbox.TabIndex = 3;
            // 
            // x2_textbox
            // 
            this.x2_textbox.Location = new System.Drawing.Point(219, 108);
            this.x2_textbox.Name = "x2_textbox";
            this.x2_textbox.Size = new System.Drawing.Size(100, 20);
            this.x2_textbox.TabIndex = 4;
            // 
            // result_textbox
            // 
            this.result_textbox.Location = new System.Drawing.Point(219, 160);
            this.result_textbox.Name = "result_textbox";
            this.result_textbox.ReadOnly = true;
            this.result_textbox.Size = new System.Drawing.Size(100, 20);
            this.result_textbox.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Змінна X";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Змінна X2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Результат";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 209);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Середнє арифметичне";
            // 
            // avarage_textbox
            // 
            this.avarage_textbox.Location = new System.Drawing.Point(219, 209);
            this.avarage_textbox.Name = "avarage_textbox";
            this.avarage_textbox.ReadOnly = true;
            this.avarage_textbox.Size = new System.Drawing.Size(100, 20);
            this.avarage_textbox.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 315);
            this.Controls.Add(this.avarage_textbox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.result_textbox);
            this.Controls.Add(this.x2_textbox);
            this.Controls.Add(this.x1_textbox);
            this.Controls.Add(this.button_exit);
            this.Controls.Add(this.button_clear);
            this.Controls.Add(this.button_calc);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_calc;
        private System.Windows.Forms.Button button_clear;
        private System.Windows.Forms.Button button_exit;
        private System.Windows.Forms.TextBox x1_textbox;
        private System.Windows.Forms.TextBox x2_textbox;
        private System.Windows.Forms.TextBox result_textbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox avarage_textbox;
    }
}

