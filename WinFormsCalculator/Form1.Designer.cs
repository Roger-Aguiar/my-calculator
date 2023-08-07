namespace WinFormsCalculator
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
            label2 = new Label();
            TextBoxInvestmentValue = new TextBox();
            label3 = new Label();
            TextBoxInvestedValue = new TextBox();
            ButtonAddValue = new Button();
            RichTextBoxResult = new RichTextBox();
            ButtonCalculateProportion = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Black;
            label1.Font = new Font("Arial", 34F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(460, 54);
            label1.TabIndex = 1;
            label1.Text = "Proportion Calculus";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(12, 64);
            label2.Name = "label2";
            label2.Size = new Size(231, 23);
            label2.TabIndex = 2;
            label2.Text = "Enter the invested value: ";
            // 
            // TextBoxInvestmentValue
            // 
            TextBoxInvestmentValue.Font = new Font("Arial", 15F, FontStyle.Regular, GraphicsUnit.Point);
            TextBoxInvestmentValue.Location = new Point(310, 61);
            TextBoxInvestmentValue.Name = "TextBoxInvestmentValue";
            TextBoxInvestmentValue.Size = new Size(132, 30);
            TextBoxInvestmentValue.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(12, 100);
            label3.Name = "label3";
            label3.Size = new Size(292, 23);
            label3.TabIndex = 4;
            label3.Text = "Enter the value of each investor:";
            // 
            // TextBoxInvestedValue
            // 
            TextBoxInvestedValue.Font = new Font("Arial", 15F, FontStyle.Regular, GraphicsUnit.Point);
            TextBoxInvestedValue.Location = new Point(310, 97);
            TextBoxInvestedValue.Name = "TextBoxInvestedValue";
            TextBoxInvestedValue.Size = new Size(132, 30);
            TextBoxInvestedValue.TabIndex = 5;
            // 
            // ButtonAddValue
            // 
            ButtonAddValue.BackColor = Color.Gray;
            ButtonAddValue.Font = new Font("Arial", 15F, FontStyle.Regular, GraphicsUnit.Point);
            ButtonAddValue.Location = new Point(12, 133);
            ButtonAddValue.Name = "ButtonAddValue";
            ButtonAddValue.Size = new Size(430, 51);
            ButtonAddValue.TabIndex = 6;
            ButtonAddValue.Text = "Add Value";
            ButtonAddValue.UseVisualStyleBackColor = false;
            ButtonAddValue.Click += ButtonAddValue_Click;
            // 
            // RichTextBoxResult
            // 
            RichTextBoxResult.Font = new Font("Arial", 15F, FontStyle.Regular, GraphicsUnit.Point);
            RichTextBoxResult.Location = new Point(12, 190);
            RichTextBoxResult.Name = "RichTextBoxResult";
            RichTextBoxResult.Size = new Size(430, 249);
            RichTextBoxResult.TabIndex = 7;
            RichTextBoxResult.Text = "";
            // 
            // ButtonCalculateProportion
            // 
            ButtonCalculateProportion.BackColor = Color.Gray;
            ButtonCalculateProportion.Font = new Font("Arial", 15F, FontStyle.Regular, GraphicsUnit.Point);
            ButtonCalculateProportion.Location = new Point(12, 445);
            ButtonCalculateProportion.Name = "ButtonCalculateProportion";
            ButtonCalculateProportion.Size = new Size(430, 51);
            ButtonCalculateProportion.TabIndex = 8;
            ButtonCalculateProportion.Text = "Calculate proportion";
            ButtonCalculateProportion.UseVisualStyleBackColor = false;
            ButtonCalculateProportion.Click += ButtonCalculateProportion_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkGray;
            ClientSize = new Size(454, 508);
            Controls.Add(ButtonCalculateProportion);
            Controls.Add(RichTextBoxResult);
            Controls.Add(ButtonAddValue);
            Controls.Add(TextBoxInvestedValue);
            Controls.Add(label3);
            Controls.Add(TextBoxInvestmentValue);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "My calculator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label label2;
        private TextBox TextBoxInvestmentValue;
        private Label label3;
        private TextBox TextBoxInvestedValue;
        private Button ButtonAddValue;
        private RichTextBox RichTextBoxResult;
        private Button ButtonCalculateProportion;
    }
}