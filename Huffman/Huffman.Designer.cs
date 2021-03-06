
namespace Huffman
{
    partial class Huffman
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
            this.InputBox = new System.Windows.Forms.TextBox();
            this.BinaryBox = new System.Windows.Forms.TextBox();
            this.BinaryLabel = new System.Windows.Forms.Label();
            this.InputLabel = new System.Windows.Forms.Label();
            this.ConvertBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // InputBox
            // 
            this.InputBox.Location = new System.Drawing.Point(12, 27);
            this.InputBox.Multiline = true;
            this.InputBox.Name = "InputBox";
            this.InputBox.Size = new System.Drawing.Size(1228, 200);
            this.InputBox.TabIndex = 0;
            this.InputBox.TextChanged += new System.EventHandler(this.Inputbox_TextChanged);
            // 
            // BinaryBox
            // 
            this.BinaryBox.Location = new System.Drawing.Point(12, 258);
            this.BinaryBox.Multiline = true;
            this.BinaryBox.Name = "BinaryBox";
            this.BinaryBox.ReadOnly = true;
            this.BinaryBox.Size = new System.Drawing.Size(1228, 252);
            this.BinaryBox.TabIndex = 1;
            this.BinaryBox.TextChanged += new System.EventHandler(this.BinaryBox_TextChanged);
            // 
            // BinaryLabel
            // 
            this.BinaryLabel.AutoSize = true;
            this.BinaryLabel.Location = new System.Drawing.Point(12, 240);
            this.BinaryLabel.Name = "BinaryLabel";
            this.BinaryLabel.Size = new System.Drawing.Size(40, 15);
            this.BinaryLabel.TabIndex = 2;
            this.BinaryLabel.Text = "Binary";
            // 
            // InputLabel
            // 
            this.InputLabel.AutoSize = true;
            this.InputLabel.Location = new System.Drawing.Point(14, 9);
            this.InputLabel.Name = "InputLabel";
            this.InputLabel.Size = new System.Drawing.Size(35, 15);
            this.InputLabel.TabIndex = 3;
            this.InputLabel.Text = "Input";
            // 
            // ConvertBtn
            // 
            this.ConvertBtn.Location = new System.Drawing.Point(1109, 516);
            this.ConvertBtn.Name = "ConvertBtn";
            this.ConvertBtn.Size = new System.Drawing.Size(131, 110);
            this.ConvertBtn.TabIndex = 4;
            this.ConvertBtn.Text = "Convert!";
            this.ConvertBtn.UseVisualStyleBackColor = true;
            this.ConvertBtn.Click += new System.EventHandler(this.ConvertBtn_Click);
            // 
            // Huffman
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1252, 638);
            this.Controls.Add(this.ConvertBtn);
            this.Controls.Add(this.InputLabel);
            this.Controls.Add(this.BinaryLabel);
            this.Controls.Add(this.BinaryBox);
            this.Controls.Add(this.InputBox);
            this.Name = "Huffman";
            this.Text = "Huffman";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox InputBox;
        private System.Windows.Forms.TextBox BinaryBox;
        private System.Windows.Forms.Label BinaryLabel;
        private System.Windows.Forms.Label InputLabel;
        private System.Windows.Forms.Button ConvertBtn;
    }
}

