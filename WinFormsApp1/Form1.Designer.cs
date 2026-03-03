namespace WinFormsApp1
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
            initialSum = new TextBox();
            maxIncrease = new TextBox();
            maxDeposit = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // initialSum
            // 
            initialSum.Location = new Point(77, 46);
            initialSum.Name = "initialSum";
            initialSum.Size = new Size(200, 23);
            initialSum.TabIndex = 0;
            initialSum.Text = "Первоначальный взнос";
            initialSum.TextChanged += textBox1_TextChanged;
            // 
            // maxIncrease
            // 
            maxIncrease.Location = new Point(77, 75);
            maxIncrease.Name = "maxIncrease";
            maxIncrease.Size = new Size(200, 23);
            maxIncrease.TabIndex = 1;
            maxIncrease.Text = "Максимальное увеличение вклада";
            // 
            // maxDeposit
            // 
            maxDeposit.Location = new Point(77, 105);
            maxDeposit.Name = "maxDeposit";
            maxDeposit.Size = new Size(200, 23);
            maxDeposit.TabIndex = 2;
            maxDeposit.Text = "Максимальный размер вклада";
            maxDeposit.TextChanged += textBox3_TextChanged;
            // 
            // button1
            // 
            button1.Location = new Point(77, 134);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 3;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(maxDeposit);
            Controls.Add(maxIncrease);
            Controls.Add(initialSum);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox initialSum;
        private TextBox maxIncrease;
        private TextBox maxDeposit;
        private Button button1;
    }
}
