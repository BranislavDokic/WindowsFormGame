namespace WinFormsApp4
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
            buttonCloseForm2 = new Button();
            buttonBreakout = new Button();
            labelWithNickName = new Label();
            SuspendLayout();
            // 
            // buttonCloseForm2
            // 
            buttonCloseForm2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            buttonCloseForm2.Location = new Point(624, 28);
            buttonCloseForm2.Name = "buttonCloseForm2";
            buttonCloseForm2.Size = new Size(146, 53);
            buttonCloseForm2.TabIndex = 0;
            buttonCloseForm2.Text = "Log out";
            buttonCloseForm2.UseVisualStyleBackColor = true;
            buttonCloseForm2.Click += buttonCloseForm2_Click;
            // 
            // buttonBreakout
            // 
            buttonBreakout.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            buttonBreakout.Location = new Point(293, 186);
            buttonBreakout.Name = "buttonBreakout";
            buttonBreakout.Size = new Size(168, 82);
            buttonBreakout.TabIndex = 2;
            buttonBreakout.Text = "Breakout Game";
            buttonBreakout.UseVisualStyleBackColor = true;
            buttonBreakout.Click += buttonBreakout_Click;
            // 
            // labelWithNickName
            // 
            labelWithNickName.AutoSize = true;
            labelWithNickName.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelWithNickName.Location = new Point(345, 60);
            labelWithNickName.Name = "labelWithNickName";
            labelWithNickName.Size = new Size(57, 21);
            labelWithNickName.TabIndex = 4;
            labelWithNickName.Text = "label1";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(labelWithNickName);
            Controls.Add(buttonBreakout);
            Controls.Add(buttonCloseForm2);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonCloseForm2;
        private Button buttonBreakout;
        private Label labelWithNickName;
    }
}