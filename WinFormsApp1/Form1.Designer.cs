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
            initialSumLabel = new TextBox();
            maxIncreaseLabel = new TextBox();
            maxDepositLabel = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // initialSumLabel
            // 
            initialSumLabel.Location = new Point(77, 46);
            initialSumLabel.Name = "initialSumLabel";
            initialSumLabel.Size = new Size(200, 23);
            initialSumLabel.TabIndex = 0;
            initialSumLabel.Text = "Первоначальный взнос";
            initialSumLabel.TextChanged += textBox1_TextChanged;
            // 
            // maxIncreaseLabel
            // 
            maxIncreaseLabel.Location = new Point(77, 75);
            maxIncreaseLabel.Name = "maxIncreaseLabel";
            maxIncreaseLabel.Size = new Size(200, 23);
            maxIncreaseLabel.TabIndex = 1;
            maxIncreaseLabel.Text = "Максимальное увеличение вклада";
            // 
            // maxDepositLabel
            // 
            maxDepositLabel.Location = new Point(77, 105);
            maxDepositLabel.Name = "maxDepositLabel";
            maxDepositLabel.Size = new Size(200, 23);
            maxDepositLabel.TabIndex = 2;
            maxDepositLabel.Text = "Максимальный размер вклада";
            maxDepositLabel.TextChanged += textBox3_TextChanged;
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
            Controls.Add(maxDepositLabel);
            Controls.Add(maxIncreaseLabel);
            Controls.Add(initialSumLabel);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox initialSumLabel;
        private TextBox maxIncreaseLabel;
        private TextBox maxDepositLabel;
        private Button button1;
    }
}
