namespace twonumbershowAppl
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
            this.Anumberlabel = new System.Windows.Forms.Label();
            this.aNumberTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.twoTimesTextBox = new System.Windows.Forms.TextBox();
            this.showButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Anumberlabel
            // 
            this.Anumberlabel.AutoSize = true;
            this.Anumberlabel.Location = new System.Drawing.Point(56, 44);
            this.Anumberlabel.Name = "Anumberlabel";
            this.Anumberlabel.Size = new System.Drawing.Size(54, 13);
            this.Anumberlabel.TabIndex = 0;
            this.Anumberlabel.Text = "A Number";
            //.Anumberlabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // aNumberTextBox
            // 
            this.aNumberTextBox.Location = new System.Drawing.Point(167, 36);
            this.aNumberTextBox.Name = "aNumberTextBox";
            this.aNumberTextBox.Size = new System.Drawing.Size(100, 20);
            this.aNumberTextBox.TabIndex = 1;
            //.aNumberTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Two Times Value";
            // 
            // twoTimesTextBox
            // 
            this.twoTimesTextBox.Location = new System.Drawing.Point(167, 91);
            this.twoTimesTextBox.Name = "twoTimesTextBox";
            this.twoTimesTextBox.Size = new System.Drawing.Size(100, 20);
            this.twoTimesTextBox.TabIndex = 3;
            //.twoTimesTextBox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // showButton
            // 
            this.showButton.Location = new System.Drawing.Point(62, 174);
            this.showButton.Name = "showButton";
            this.showButton.Size = new System.Drawing.Size(155, 23);
            this.showButton.TabIndex = 4;
            this.showButton.Text = "Show Two Time";
            this.showButton.UseVisualStyleBackColor = true;
            this.showButton.Click += new System.EventHandler(this.showButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.showButton);
            this.Controls.Add(this.twoTimesTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.aNumberTextBox);
            this.Controls.Add(this.Anumberlabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Anumberlabel;
        private System.Windows.Forms.TextBox aNumberTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox twoTimesTextBox;
        private System.Windows.Forms.Button showButton;
    }
}

