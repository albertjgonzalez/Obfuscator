namespace Obfuscator
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
            this.inputBox = new System.Windows.Forms.TextBox();
            this.outputBox = new System.Windows.Forms.TextBox();
            this.ObfuscateButton = new System.Windows.Forms.Button();
            this.copyButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // inputBox
            // 
            this.inputBox.Location = new System.Drawing.Point(12, 56);
            this.inputBox.Name = "inputBox";
            this.inputBox.Size = new System.Drawing.Size(217, 20);
            this.inputBox.TabIndex = 0;
            this.inputBox.TextChanged += new System.EventHandler(this.inputBox_TextChanged);
            this.inputBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.inputBox_KeyDown);
            // 
            // outputBox
            // 
            this.outputBox.Location = new System.Drawing.Point(12, 113);
            this.outputBox.Name = "outputBox";
            this.outputBox.Size = new System.Drawing.Size(217, 20);
            this.outputBox.TabIndex = 0;
            // 
            // ObfuscateButton
            // 
            this.ObfuscateButton.Location = new System.Drawing.Point(250, 56);
            this.ObfuscateButton.Name = "ObfuscateButton";
            this.ObfuscateButton.Size = new System.Drawing.Size(75, 23);
            this.ObfuscateButton.TabIndex = 1;
            this.ObfuscateButton.Text = "Obfuscate";
            this.ObfuscateButton.UseVisualStyleBackColor = true;
            this.ObfuscateButton.Click += new System.EventHandler(this.ObfuscateButton_Click);
            // 
            // copyButton
            // 
            this.copyButton.Location = new System.Drawing.Point(250, 113);
            this.copyButton.Name = "copyButton";
            this.copyButton.Size = new System.Drawing.Size(75, 23);
            this.copyButton.TabIndex = 1;
            this.copyButton.Text = "Copy";
            this.copyButton.UseVisualStyleBackColor = true;
            this.copyButton.Click += new System.EventHandler(this.copyButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 196);
            this.Controls.Add(this.copyButton);
            this.Controls.Add(this.ObfuscateButton);
            this.Controls.Add(this.outputBox);
            this.Controls.Add(this.inputBox);
            this.Name = "Form1";
            this.Text = "Obfuscator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox inputBox;
        private System.Windows.Forms.TextBox outputBox;
        private System.Windows.Forms.Button ObfuscateButton;
        private System.Windows.Forms.Button copyButton;
    }
}

