namespace SerialActivator
{
    partial class MainForm
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
            this.SerialKeyTextBox = new System.Windows.Forms.TextBox();
            this.CheckerTextBox = new System.Windows.Forms.TextBox();
            this.SerialKeyLabel = new System.Windows.Forms.Label();
            this.CheckerLabel = new System.Windows.Forms.Label();
            this.GenerateButton = new System.Windows.Forms.Button();
            this.CheckButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SerialKeyTextBox
            // 
            this.SerialKeyTextBox.Location = new System.Drawing.Point(135, 49);
            this.SerialKeyTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.SerialKeyTextBox.Name = "SerialKeyTextBox";
            this.SerialKeyTextBox.Size = new System.Drawing.Size(350, 26);
            this.SerialKeyTextBox.TabIndex = 3;
            this.SerialKeyTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // CheckerTextBox
            // 
            this.CheckerTextBox.Location = new System.Drawing.Point(135, 102);
            this.CheckerTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.CheckerTextBox.Name = "CheckerTextBox";
            this.CheckerTextBox.Size = new System.Drawing.Size(350, 26);
            this.CheckerTextBox.TabIndex = 4;
            this.CheckerTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // SerialKeyLabel
            // 
            this.SerialKeyLabel.AutoSize = true;
            this.SerialKeyLabel.Location = new System.Drawing.Point(13, 57);
            this.SerialKeyLabel.Name = "SerialKeyLabel";
            this.SerialKeyLabel.Size = new System.Drawing.Size(80, 18);
            this.SerialKeyLabel.TabIndex = 2;
            this.SerialKeyLabel.Text = "Serial Key";
            // 
            // CheckerLabel
            // 
            this.CheckerLabel.AutoSize = true;
            this.CheckerLabel.Location = new System.Drawing.Point(16, 105);
            this.CheckerLabel.Name = "CheckerLabel";
            this.CheckerLabel.Size = new System.Drawing.Size(112, 18);
            this.CheckerLabel.TabIndex = 3;
            this.CheckerLabel.Text = "Serial Checker";
            // 
            // GenerateButton
            // 
            this.GenerateButton.Location = new System.Drawing.Point(506, 49);
            this.GenerateButton.Name = "GenerateButton";
            this.GenerateButton.Size = new System.Drawing.Size(90, 30);
            this.GenerateButton.TabIndex = 0;
            this.GenerateButton.Text = "Generate";
            this.GenerateButton.UseVisualStyleBackColor = true;
            this.GenerateButton.Click += new System.EventHandler(this.GenerateButton_Click);
            // 
            // CheckButton
            // 
            this.CheckButton.Location = new System.Drawing.Point(506, 102);
            this.CheckButton.Name = "CheckButton";
            this.CheckButton.Size = new System.Drawing.Size(90, 30);
            this.CheckButton.TabIndex = 2;
            this.CheckButton.Text = "Check";
            this.CheckButton.UseVisualStyleBackColor = true;
            this.CheckButton.Click += new System.EventHandler(this.CheckButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 182);
            this.Controls.Add(this.CheckButton);
            this.Controls.Add(this.GenerateButton);
            this.Controls.Add(this.CheckerLabel);
            this.Controls.Add(this.SerialKeyLabel);
            this.Controls.Add(this.CheckerTextBox);
            this.Controls.Add(this.SerialKeyTextBox);
            this.Font = new System.Drawing.Font("Arial", 12F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Serial Activator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox SerialKeyTextBox;
        private System.Windows.Forms.TextBox CheckerTextBox;
        private System.Windows.Forms.Label SerialKeyLabel;
        private System.Windows.Forms.Label CheckerLabel;
        private System.Windows.Forms.Button GenerateButton;
        private System.Windows.Forms.Button CheckButton;
    }
}

