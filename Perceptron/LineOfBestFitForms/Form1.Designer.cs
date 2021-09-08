namespace LineOfBestFitForms
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
            this.AddBtn = new System.Windows.Forms.Button();
            this.ClearBtn = new System.Windows.Forms.Button();
            this.XTextBox = new System.Windows.Forms.TextBox();
            this.YTextBox = new System.Windows.Forms.TextBox();
            this.XLabel = new System.Windows.Forms.Label();
            this.YLabel = new System.Windows.Forms.Label();
            this.EquationLabel = new System.Windows.Forms.Label();
            this.ResetBtn = new System.Windows.Forms.Button();
            this.TrainBtn = new System.Windows.Forms.Button();
            this.TrainLabel = new System.Windows.Forms.Label();
            this.TrainTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // AddBtn
            // 
            this.AddBtn.Location = new System.Drawing.Point(88, 217);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(128, 90);
            this.AddBtn.TabIndex = 0;
            this.AddBtn.Text = "Add Point";
            this.AddBtn.UseVisualStyleBackColor = true;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // ClearBtn
            // 
            this.ClearBtn.Location = new System.Drawing.Point(274, 217);
            this.ClearBtn.Name = "ClearBtn";
            this.ClearBtn.Size = new System.Drawing.Size(127, 90);
            this.ClearBtn.TabIndex = 1;
            this.ClearBtn.Text = "Clear";
            this.ClearBtn.UseVisualStyleBackColor = true;
            this.ClearBtn.Click += new System.EventHandler(this.ClearBtn_Click);
            // 
            // XTextBox
            // 
            this.XTextBox.Location = new System.Drawing.Point(115, 51);
            this.XTextBox.Name = "XTextBox";
            this.XTextBox.Size = new System.Drawing.Size(100, 26);
            this.XTextBox.TabIndex = 2;
            // 
            // YTextBox
            // 
            this.YTextBox.Location = new System.Drawing.Point(115, 97);
            this.YTextBox.Name = "YTextBox";
            this.YTextBox.Size = new System.Drawing.Size(100, 26);
            this.YTextBox.TabIndex = 3;
            // 
            // XLabel
            // 
            this.XLabel.AutoSize = true;
            this.XLabel.Location = new System.Drawing.Point(84, 54);
            this.XLabel.Name = "XLabel";
            this.XLabel.Size = new System.Drawing.Size(24, 20);
            this.XLabel.TabIndex = 4;
            this.XLabel.Text = "X:";
            // 
            // YLabel
            // 
            this.YLabel.AutoSize = true;
            this.YLabel.Location = new System.Drawing.Point(84, 97);
            this.YLabel.Name = "YLabel";
            this.YLabel.Size = new System.Drawing.Size(24, 20);
            this.YLabel.TabIndex = 5;
            this.YLabel.Text = "Y:";
            // 
            // EquationLabel
            // 
            this.EquationLabel.AutoSize = true;
            this.EquationLabel.Location = new System.Drawing.Point(455, 51);
            this.EquationLabel.Name = "EquationLabel";
            this.EquationLabel.Size = new System.Drawing.Size(77, 20);
            this.EquationLabel.TabIndex = 6;
            this.EquationLabel.Text = "Equation:";
            // 
            // ResetBtn
            // 
            this.ResetBtn.Location = new System.Drawing.Point(88, 341);
            this.ResetBtn.Name = "ResetBtn";
            this.ResetBtn.Size = new System.Drawing.Size(128, 79);
            this.ResetBtn.TabIndex = 7;
            this.ResetBtn.Text = "Reset Perceptron";
            this.ResetBtn.UseVisualStyleBackColor = true;
            this.ResetBtn.Click += new System.EventHandler(this.CalculateBtn_Click);
            // 
            // TrainBtn
            // 
            this.TrainBtn.Location = new System.Drawing.Point(274, 341);
            this.TrainBtn.Name = "TrainBtn";
            this.TrainBtn.Size = new System.Drawing.Size(127, 79);
            this.TrainBtn.TabIndex = 8;
            this.TrainBtn.Text = "Train";
            this.TrainBtn.UseVisualStyleBackColor = true;
            this.TrainBtn.Click += new System.EventHandler(this.TrainBtn_Click);
            // 
            // TrainLabel
            // 
            this.TrainLabel.AutoSize = true;
            this.TrainLabel.Location = new System.Drawing.Point(83, 147);
            this.TrainLabel.Name = "TrainLabel";
            this.TrainLabel.Size = new System.Drawing.Size(108, 20);
            this.TrainLabel.TabIndex = 9;
            this.TrainLabel.Text = "Train Amount:";
            // 
            // TrainTextBox
            // 
            this.TrainTextBox.Location = new System.Drawing.Point(197, 147);
            this.TrainTextBox.Name = "TrainTextBox";
            this.TrainTextBox.Size = new System.Drawing.Size(100, 26);
            this.TrainTextBox.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TrainTextBox);
            this.Controls.Add(this.TrainLabel);
            this.Controls.Add(this.TrainBtn);
            this.Controls.Add(this.ResetBtn);
            this.Controls.Add(this.EquationLabel);
            this.Controls.Add(this.YLabel);
            this.Controls.Add(this.XLabel);
            this.Controls.Add(this.YTextBox);
            this.Controls.Add(this.XTextBox);
            this.Controls.Add(this.ClearBtn);
            this.Controls.Add(this.AddBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.Button ClearBtn;
        private System.Windows.Forms.TextBox XTextBox;
        private System.Windows.Forms.TextBox YTextBox;
        private System.Windows.Forms.Label XLabel;
        private System.Windows.Forms.Label YLabel;
        private System.Windows.Forms.Label EquationLabel;
        private System.Windows.Forms.Button ResetBtn;
        private System.Windows.Forms.Button TrainBtn;
        private System.Windows.Forms.Label TrainLabel;
        private System.Windows.Forms.TextBox TrainTextBox;
    }
}

