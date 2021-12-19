
namespace Генератор_паролей
{
    partial class Регистрация
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
            this.TBPass2 = new System.Windows.Forms.TextBox();
            this.TBPass = new System.Windows.Forms.TextBox();
            this.TBLogin = new System.Windows.Forms.TextBox();
            this.TBName = new System.Windows.Forms.TextBox();
            this.labelLogin = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelPass2 = new System.Windows.Forms.Label();
            this.labelPass = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.BTReget = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TBPass2
            // 
            this.TBPass2.Font = new System.Drawing.Font("Segoe Script", 14F, System.Drawing.FontStyle.Bold);
            this.TBPass2.Location = new System.Drawing.Point(107, 376);
            this.TBPass2.Name = "TBPass2";
            this.TBPass2.Size = new System.Drawing.Size(313, 37);
            this.TBPass2.TabIndex = 2;
            this.TBPass2.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // TBPass
            // 
            this.TBPass.Font = new System.Drawing.Font("Segoe Script", 14F, System.Drawing.FontStyle.Bold);
            this.TBPass.Location = new System.Drawing.Point(107, 293);
            this.TBPass.Name = "TBPass";
            this.TBPass.Size = new System.Drawing.Size(313, 37);
            this.TBPass.TabIndex = 3;
            this.TBPass.TextChanged += new System.EventHandler(this.TBPass_TextChanged);
            // 
            // TBLogin
            // 
            this.TBLogin.Font = new System.Drawing.Font("Segoe Script", 14F, System.Drawing.FontStyle.Bold);
            this.TBLogin.Location = new System.Drawing.Point(107, 208);
            this.TBLogin.Name = "TBLogin";
            this.TBLogin.Size = new System.Drawing.Size(313, 37);
            this.TBLogin.TabIndex = 4;
            this.TBLogin.TextChanged += new System.EventHandler(this.textBoxLogin_TextChanged);
            // 
            // TBName
            // 
            this.TBName.Font = new System.Drawing.Font("Segoe Script", 14F, System.Drawing.FontStyle.Bold);
            this.TBName.Location = new System.Drawing.Point(107, 122);
            this.TBName.Name = "TBName";
            this.TBName.Size = new System.Drawing.Size(313, 37);
            this.TBName.TabIndex = 5;
            this.TBName.TextChanged += new System.EventHandler(this.textBoxMail_TextChanged);
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.Font = new System.Drawing.Font("Segoe Script", 14F, System.Drawing.FontStyle.Bold);
            this.labelLogin.Location = new System.Drawing.Point(104, 174);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(81, 31);
            this.labelLogin.TabIndex = 6;
            this.labelLogin.Text = "Логин";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Segoe Script", 14F, System.Drawing.FontStyle.Bold);
            this.labelName.Location = new System.Drawing.Point(101, 88);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(64, 31);
            this.labelName.TabIndex = 7;
            this.labelName.Text = "Имя";
            this.labelName.Click += new System.EventHandler(this.labelMail_Click);
            // 
            // labelPass2
            // 
            this.labelPass2.AutoSize = true;
            this.labelPass2.Font = new System.Drawing.Font("Segoe Script", 14F, System.Drawing.FontStyle.Bold);
            this.labelPass2.Location = new System.Drawing.Point(104, 342);
            this.labelPass2.Name = "labelPass2";
            this.labelPass2.Size = new System.Drawing.Size(215, 31);
            this.labelPass2.TabIndex = 8;
            this.labelPass2.Text = "Повторите пароль";
            // 
            // labelPass
            // 
            this.labelPass.AutoSize = true;
            this.labelPass.Font = new System.Drawing.Font("Segoe Script", 14F, System.Drawing.FontStyle.Bold);
            this.labelPass.Location = new System.Drawing.Point(104, 259);
            this.labelPass.Name = "labelPass";
            this.labelPass.Size = new System.Drawing.Size(87, 31);
            this.labelPass.TabIndex = 9;
            this.labelPass.Text = "Пароль";
            this.labelPass.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe Script", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(149, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(263, 53);
            this.label5.TabIndex = 10;
            this.label5.Text = "Регистрация";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Segoe Script", 8F, System.Drawing.FontStyle.Bold);
            this.checkBox1.Location = new System.Drawing.Point(107, 436);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(313, 21);
            this.checkBox1.TabIndex = 11;
            this.checkBox1.Text = "я согласен на обработку персональных данных";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // BTReget
            // 
            this.BTReget.Font = new System.Drawing.Font("Segoe Script", 14F, System.Drawing.FontStyle.Bold);
            this.BTReget.Location = new System.Drawing.Point(12, 491);
            this.BTReget.Name = "BTReget";
            this.BTReget.Size = new System.Drawing.Size(253, 41);
            this.BTReget.TabIndex = 12;
            this.BTReget.Text = "Зарегистрироваться";
            this.BTReget.UseVisualStyleBackColor = true;
            this.BTReget.Click += new System.EventHandler(this.button1_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe Script", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(282, 491);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(248, 41);
            this.button1.TabIndex = 13;
            this.button1.Text = "Назад к авторизации";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Регистрация
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(247)))), ((int)(((byte)(148)))));
            this.ClientSize = new System.Drawing.Size(542, 592);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BTReget);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.labelPass);
            this.Controls.Add(this.labelPass2);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.labelLogin);
            this.Controls.Add(this.TBName);
            this.Controls.Add(this.TBLogin);
            this.Controls.Add(this.TBPass);
            this.Controls.Add(this.TBPass2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Регистрация";
            this.Text = "Регистрация";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TBPass2;
        private System.Windows.Forms.TextBox TBPass;
        private System.Windows.Forms.TextBox TBLogin;
        private System.Windows.Forms.TextBox TBName;
        private System.Windows.Forms.Label labelLogin;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelPass2;
        private System.Windows.Forms.Label labelPass;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button BTReget;
        private System.Windows.Forms.Button button1;
    }
}