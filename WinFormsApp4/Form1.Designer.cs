namespace WinFormsApp4
{
    partial class Form1
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
            label1 = new Label();
            buttonLogIn = new Button();
            buttonCreatAcc = new Button();
            panelCreateAcaunt = new Panel();
            checkBox1 = new CheckBox();
            label5 = new Label();
            buttonCreateYourAcc = new Button();
            textBoxNewPassword = new TextBox();
            textBoxNewNick = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            panelLogIn = new Panel();
            checkBox2 = new CheckBox();
            label8 = new Label();
            label9 = new Label();
            buttonToLogIn = new Button();
            textBoxPassword = new TextBox();
            textBoxNickName = new TextBox();
            label7 = new Label();
            label6 = new Label();
            panelCreateAcaunt.SuspendLayout();
            panelLogIn.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(335, 22);
            label1.Name = "label1";
            label1.Size = new Size(78, 30);
            label1.TabIndex = 0;
            label1.Text = "Games";
            // 
            // buttonLogIn
            // 
            buttonLogIn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonLogIn.Location = new Point(155, 122);
            buttonLogIn.Name = "buttonLogIn";
            buttonLogIn.Size = new Size(141, 47);
            buttonLogIn.TabIndex = 1;
            buttonLogIn.Text = "Log in";
            buttonLogIn.UseVisualStyleBackColor = true;
            buttonLogIn.Click += buttonLogIn_Click;
            // 
            // buttonCreatAcc
            // 
            buttonCreatAcc.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonCreatAcc.Location = new Point(444, 122);
            buttonCreatAcc.Name = "buttonCreatAcc";
            buttonCreatAcc.Size = new Size(141, 47);
            buttonCreatAcc.TabIndex = 2;
            buttonCreatAcc.Text = "Create Acaunt";
            buttonCreatAcc.UseVisualStyleBackColor = true;
            buttonCreatAcc.Click += buttonCreatAcc_Click;
            // 
            // panelCreateAcaunt
            // 
            panelCreateAcaunt.Controls.Add(panelLogIn);
            panelCreateAcaunt.Controls.Add(checkBox1);
            panelCreateAcaunt.Controls.Add(label5);
            panelCreateAcaunt.Controls.Add(buttonCreateYourAcc);
            panelCreateAcaunt.Controls.Add(textBoxNewPassword);
            panelCreateAcaunt.Controls.Add(textBoxNewNick);
            panelCreateAcaunt.Controls.Add(label4);
            panelCreateAcaunt.Controls.Add(label3);
            panelCreateAcaunt.Controls.Add(label2);
            panelCreateAcaunt.Location = new Point(155, 204);
            panelCreateAcaunt.Name = "panelCreateAcaunt";
            panelCreateAcaunt.Size = new Size(430, 198);
            panelCreateAcaunt.TabIndex = 3;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(94, 130);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(55, 19);
            checkBox1.TabIndex = 7;
            checkBox1.Text = "Show";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.SpringGreen;
            label5.Location = new Point(264, 30);
            label5.Name = "label5";
            label5.Size = new Size(62, 21);
            label5.TabIndex = 6;
            label5.Text = "labela5";
            label5.Visible = false;
            // 
            // buttonCreateYourAcc
            // 
            buttonCreateYourAcc.Location = new Point(134, 165);
            buttonCreateYourAcc.Name = "buttonCreateYourAcc";
            buttonCreateYourAcc.Size = new Size(87, 30);
            buttonCreateYourAcc.TabIndex = 5;
            buttonCreateYourAcc.Text = "Create";
            buttonCreateYourAcc.UseVisualStyleBackColor = true;
            buttonCreateYourAcc.Click += buttonCreateYourAcc_Click;
            // 
            // textBoxNewPassword
            // 
            textBoxNewPassword.Location = new Point(94, 101);
            textBoxNewPassword.Name = "textBoxNewPassword";
            textBoxNewPassword.Size = new Size(171, 23);
            textBoxNewPassword.TabIndex = 4;
            textBoxNewPassword.UseSystemPasswordChar = true;
            // 
            // textBoxNewNick
            // 
            textBoxNewNick.Location = new Point(94, 57);
            textBoxNewNick.Name = "textBoxNewNick";
            textBoxNewNick.Size = new Size(171, 23);
            textBoxNewNick.TabIndex = 3;
            textBoxNewNick.Click += textBoxNewNick_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(28, 109);
            label4.Name = "label4";
            label4.Size = new Size(60, 15);
            label4.TabIndex = 2;
            label4.Text = "Password:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(19, 65);
            label3.Name = "label3";
            label3.Size = new Size(69, 15);
            label3.TabIndex = 1;
            label3.Text = "Nick Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(19, 6);
            label2.Name = "label2";
            label2.Size = new Size(202, 30);
            label2.TabIndex = 0;
            label2.Text = "Create Your Acaunt";
            // 
            // panelLogIn
            // 
            panelLogIn.Controls.Add(checkBox2);
            panelLogIn.Controls.Add(label8);
            panelLogIn.Controls.Add(label9);
            panelLogIn.Controls.Add(buttonToLogIn);
            panelLogIn.Controls.Add(textBoxPassword);
            panelLogIn.Controls.Add(textBoxNickName);
            panelLogIn.Controls.Add(label7);
            panelLogIn.Controls.Add(label6);
            panelLogIn.Location = new Point(0, 0);
            panelLogIn.Name = "panelLogIn";
            panelLogIn.Size = new Size(430, 198);
            panelLogIn.TabIndex = 7;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(106, 143);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(55, 19);
            checkBox2.TabIndex = 8;
            checkBox2.Text = "Show";
            checkBox2.UseVisualStyleBackColor = true;
            checkBox2.CheckedChanged += checkBox2_CheckedChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.ForeColor = Color.Red;
            label8.Location = new Point(94, 93);
            label8.Name = "label8";
            label8.Size = new Size(163, 15);
            label8.TabIndex = 7;
            label8.Text = "wrong password or nickname";
            label8.Visible = false;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(28, 7);
            label9.Name = "label9";
            label9.Size = new Size(135, 30);
            label9.TabIndex = 6;
            label9.Text = "Log In Panel";
            // 
            // buttonToLogIn
            // 
            buttonToLogIn.Location = new Point(109, 164);
            buttonToLogIn.Name = "buttonToLogIn";
            buttonToLogIn.Size = new Size(142, 31);
            buttonToLogIn.TabIndex = 4;
            buttonToLogIn.Text = "Log In";
            buttonToLogIn.UseVisualStyleBackColor = true;
            buttonToLogIn.Click += buttonToLogIn_Click;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(106, 114);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(145, 23);
            textBoxPassword.TabIndex = 3;
            textBoxPassword.UseSystemPasswordChar = true;
            // 
            // textBoxNickName
            // 
            textBoxNickName.Location = new Point(106, 68);
            textBoxNickName.Name = "textBoxNickName";
            textBoxNickName.Size = new Size(145, 23);
            textBoxNickName.TabIndex = 2;
            textBoxNickName.Click += textBoxNickName_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(37, 122);
            label7.Name = "label7";
            label7.Size = new Size(57, 15);
            label7.TabIndex = 1;
            label7.Text = "Password";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(28, 76);
            label6.Name = "label6";
            label6.Size = new Size(66, 15);
            label6.TabIndex = 0;
            label6.Text = "Nick Name";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panelCreateAcaunt);
            Controls.Add(buttonCreatAcc);
            Controls.Add(buttonLogIn);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            panelCreateAcaunt.ResumeLayout(false);
            panelCreateAcaunt.PerformLayout();
            panelLogIn.ResumeLayout(false);
            panelLogIn.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button buttonLogIn;
        private Button buttonCreatAcc;
        private Panel panelCreateAcaunt;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button buttonCreateYourAcc;
        private TextBox textBoxNewPassword;
        private TextBox textBoxNewNick;
        private Label label5;
        private Panel panelLogIn;
        private TextBox textBoxPassword;
        private TextBox textBoxNickName;
        private Label label7;
        private Label label6;
        private Button buttonToLogIn;
        private Label label9;
        private Label label8;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
    }
}