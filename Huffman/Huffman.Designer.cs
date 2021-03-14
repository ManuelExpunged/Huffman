
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
            this.TreeLabel = new System.Windows.Forms.Label();
            this.TreeBox = new System.Windows.Forms.TextBox();
            this.SizeBox1 = new System.Windows.Forms.TextBox();
            this.SizeBox2 = new System.Windows.Forms.TextBox();
            this.SizeBox3 = new System.Windows.Forms.TextBox();
            this.Size1 = new System.Windows.Forms.Label();
            this.Size2 = new System.Windows.Forms.Label();
            this.Size3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // InputBox
            // 
            this.InputBox.Location = new System.Drawing.Point(14, 27);
            this.InputBox.Multiline = true;
            this.InputBox.Name = "InputBox";
            this.InputBox.Size = new System.Drawing.Size(306, 138);
            this.InputBox.TabIndex = 0;
            // 
            // BinaryBox
            // 
            this.BinaryBox.Location = new System.Drawing.Point(14, 186);
            this.BinaryBox.Multiline = true;
            this.BinaryBox.Name = "BinaryBox";
            this.BinaryBox.ReadOnly = true;
            this.BinaryBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.BinaryBox.Size = new System.Drawing.Size(394, 383);
            this.BinaryBox.TabIndex = 1;
            // 
            // BinaryLabel
            // 
            this.BinaryLabel.AutoSize = true;
            this.BinaryLabel.Location = new System.Drawing.Point(12, 168);
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
            this.ConvertBtn.Location = new System.Drawing.Point(326, 27);
            this.ConvertBtn.Name = "ConvertBtn";
            this.ConvertBtn.Size = new System.Drawing.Size(82, 138);
            this.ConvertBtn.TabIndex = 4;
            this.ConvertBtn.Text = "Convert!";
            this.ConvertBtn.UseVisualStyleBackColor = true;
            this.ConvertBtn.Click += new System.EventHandler(this.ConvertBtn_Click);
            // 
            // TreeLabel
            // 
            this.TreeLabel.AutoSize = true;
            this.TreeLabel.Location = new System.Drawing.Point(414, 9);
            this.TreeLabel.Name = "TreeLabel";
            this.TreeLabel.Size = new System.Drawing.Size(28, 15);
            this.TreeLabel.TabIndex = 6;
            this.TreeLabel.Text = "Tree";
            // 
            // TreeBox
            // 
            this.TreeBox.Location = new System.Drawing.Point(414, 27);
            this.TreeBox.Multiline = true;
            this.TreeBox.Name = "TreeBox";
            this.TreeBox.ReadOnly = true;
            this.TreeBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.TreeBox.Size = new System.Drawing.Size(826, 586);
            this.TreeBox.TabIndex = 7;
            // 
            // SizeBox1
            // 
            this.SizeBox1.Location = new System.Drawing.Point(14, 590);
            this.SizeBox1.Name = "SizeBox1";
            this.SizeBox1.ReadOnly = true;
            this.SizeBox1.Size = new System.Drawing.Size(130, 23);
            this.SizeBox1.TabIndex = 8;
            // 
            // SizeBox2
            // 
            this.SizeBox2.Location = new System.Drawing.Point(150, 590);
            this.SizeBox2.Name = "SizeBox2";
            this.SizeBox2.ReadOnly = true;
            this.SizeBox2.Size = new System.Drawing.Size(130, 23);
            this.SizeBox2.TabIndex = 10;
            // 
            // SizeBox3
            // 
            this.SizeBox3.Location = new System.Drawing.Point(286, 590);
            this.SizeBox3.Name = "SizeBox3";
            this.SizeBox3.ReadOnly = true;
            this.SizeBox3.Size = new System.Drawing.Size(122, 23);
            this.SizeBox3.TabIndex = 12;
            // 
            // Size1
            // 
            this.Size1.AutoSize = true;
            this.Size1.Location = new System.Drawing.Point(14, 572);
            this.Size1.Name = "Size1";
            this.Size1.Size = new System.Drawing.Size(84, 15);
            this.Size1.TabIndex = 9;
            this.Size1.Text = "Start size (8bit)";
            // 
            // Size2
            // 
            this.Size2.AutoSize = true;
            this.Size2.Location = new System.Drawing.Point(150, 572);
            this.Size2.Name = "Size2";
            this.Size2.Size = new System.Drawing.Size(109, 15);
            this.Size2.TabIndex = 11;
            this.Size2.Text = "Final size (w/o tree)";
            // 
            // Size3
            // 
            this.Size3.AutoSize = true;
            this.Size3.Location = new System.Drawing.Point(286, 572);
            this.Size3.Name = "Size3";
            this.Size3.Size = new System.Drawing.Size(54, 15);
            this.Size3.TabIndex = 13;
            this.Size3.Text = "Decrease";
            // 
            // Huffman
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1252, 625);
            this.Controls.Add(this.Size3);
            this.Controls.Add(this.SizeBox3);
            this.Controls.Add(this.Size2);
            this.Controls.Add(this.SizeBox2);
            this.Controls.Add(this.Size1);
            this.Controls.Add(this.SizeBox1);
            this.Controls.Add(this.TreeBox);
            this.Controls.Add(this.TreeLabel);
            this.Controls.Add(this.ConvertBtn);
            this.Controls.Add(this.InputLabel);
            this.Controls.Add(this.BinaryLabel);
            this.Controls.Add(this.BinaryBox);
            this.Controls.Add(this.InputBox);
            this.DoubleBuffered = true;
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
        private System.Windows.Forms.Label TreeLabel;
        private System.Windows.Forms.TextBox TreeBox;
        private System.Windows.Forms.Label Size1;
        private System.Windows.Forms.Label Size2;
        private System.Windows.Forms.Label Size3;
        private System.Windows.Forms.TextBox SizeBox1;
        private System.Windows.Forms.TextBox SizeBox2;
        private System.Windows.Forms.TextBox SizeBox3;
    }
}

