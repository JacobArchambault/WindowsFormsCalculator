namespace WindowsFormsCalculator
{
    partial class Calculator
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
            this.addButton = new System.Windows.Forms.Button();
            this.multiplyButton = new System.Windows.Forms.Button();
            this.value1Textbox = new System.Windows.Forms.TextBox();
            this.value2Textbox = new System.Windows.Forms.TextBox();
            this.value1Label = new System.Windows.Forms.Label();
            this.value2Label = new System.Windows.Forms.Label();
            this.title = new System.Windows.Forms.Label();
            this.resultLabel = new System.Windows.Forms.Label();
            this.divideButton = new System.Windows.Forms.Button();
            this.subtractButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.Color.MidnightBlue;
            this.addButton.Location = new System.Drawing.Point(191, 238);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(112, 34);
            this.addButton.TabIndex = 0;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // multiplyButton
            // 
            this.multiplyButton.BackColor = System.Drawing.Color.MidnightBlue;
            this.multiplyButton.Location = new System.Drawing.Point(191, 158);
            this.multiplyButton.Name = "multiplyButton";
            this.multiplyButton.Size = new System.Drawing.Size(112, 34);
            this.multiplyButton.TabIndex = 1;
            this.multiplyButton.Text = "Multiply";
            this.multiplyButton.UseVisualStyleBackColor = false;
            this.multiplyButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // value1Textbox
            // 
            this.value1Textbox.Location = new System.Drawing.Point(191, 44);
            this.value1Textbox.Name = "value1Textbox";
            this.value1Textbox.Size = new System.Drawing.Size(112, 31);
            this.value1Textbox.TabIndex = 2;
            this.value1Textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // value2Textbox
            // 
            this.value2Textbox.Location = new System.Drawing.Point(191, 81);
            this.value2Textbox.Name = "value2Textbox";
            this.value2Textbox.Size = new System.Drawing.Size(112, 31);
            this.value2Textbox.TabIndex = 3;
            this.value2Textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // value1Label
            // 
            this.value1Label.AutoSize = true;
            this.value1Label.Location = new System.Drawing.Point(12, 44);
            this.value1Label.Name = "value1Label";
            this.value1Label.Size = new System.Drawing.Size(137, 25);
            this.value1Label.TabIndex = 4;
            this.value1Label.Text = "Enter first value:";
            // 
            // value2Label
            // 
            this.value2Label.AutoSize = true;
            this.value2Label.Location = new System.Drawing.Point(12, 81);
            this.value2Label.Name = "value2Label";
            this.value2Label.Size = new System.Drawing.Size(164, 25);
            this.value2Label.TabIndex = 5;
            this.value2Label.Text = "Enter second value:";
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.title.Location = new System.Drawing.Point(55, 9);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(200, 32);
            this.title.TabIndex = 6;
            this.title.Text = "Simple Calculator";
            // 
            // resultLabel
            // 
            this.resultLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.resultLabel.ForeColor = System.Drawing.Color.Yellow;
            this.resultLabel.Location = new System.Drawing.Point(44, 275);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(259, 25);
            this.resultLabel.TabIndex = 7;
            this.resultLabel.Text = "Value must be numeric and > 0";
            this.resultLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.resultLabel.Visible = false;
            // 
            // divideButton
            // 
            this.divideButton.BackColor = System.Drawing.Color.MidnightBlue;
            this.divideButton.Location = new System.Drawing.Point(191, 118);
            this.divideButton.Name = "divideButton";
            this.divideButton.Size = new System.Drawing.Size(112, 34);
            this.divideButton.TabIndex = 8;
            this.divideButton.Text = "Divide";
            this.divideButton.UseVisualStyleBackColor = false;
            this.divideButton.Click += new System.EventHandler(this.divideButton_Click);
            // 
            // subtractButton
            // 
            this.subtractButton.BackColor = System.Drawing.Color.MidnightBlue;
            this.subtractButton.Location = new System.Drawing.Point(191, 198);
            this.subtractButton.Name = "subtractButton";
            this.subtractButton.Size = new System.Drawing.Size(112, 34);
            this.subtractButton.TabIndex = 9;
            this.subtractButton.Text = "Subtract";
            this.subtractButton.UseVisualStyleBackColor = false;
            this.subtractButton.Click += new System.EventHandler(this.subtractButton_Click);
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Blue;
            this.ClientSize = new System.Drawing.Size(315, 308);
            this.Controls.Add(this.subtractButton);
            this.Controls.Add(this.divideButton);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.title);
            this.Controls.Add(this.value2Label);
            this.Controls.Add(this.value1Label);
            this.Controls.Add(this.value2Textbox);
            this.Controls.Add(this.value1Textbox);
            this.Controls.Add(this.multiplyButton);
            this.Controls.Add(this.addButton);
            this.ForeColor = System.Drawing.Color.Yellow;
            this.Name = "Calculator";
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.Button multiplyButton;
        private System.Windows.Forms.Label value1Label;
        private System.Windows.Forms.Label value2Label;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.TextBox value1Textbox;
        private System.Windows.Forms.TextBox value2Textbox;
        private System.Windows.Forms.Button divideButton;
        private System.Windows.Forms.Button subtractButton;
    }
}