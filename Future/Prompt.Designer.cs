namespace Future {
    partial class Prompt {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.input_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(13, 13);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(481, 25);
            this.textBox1.TabIndex = 0;
            // 
            // input_button
            // 
            this.input_button.Location = new System.Drawing.Point(500, 12);
            this.input_button.Name = "input_button";
            this.input_button.Size = new System.Drawing.Size(75, 23);
            this.input_button.TabIndex = 1;
            this.input_button.Text = "입력";
            this.input_button.UseVisualStyleBackColor = true;
            // 
            // Prompt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 50);
            this.Controls.Add(this.input_button);
            this.Controls.Add(this.textBox1);
            this.Name = "Prompt";
            this.Text = "Prompt";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button input_button;
    }
}