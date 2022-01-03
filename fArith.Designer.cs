namespace TSA
{
    partial class fArith
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
            this.label1 = new System.Windows.Forms.Label();
            this.arithmeticTextBox = new System.Windows.Forms.TextBox();
            this.seven = new System.Windows.Forms.Button();
            this.nine = new System.Windows.Forms.Button();
            this.eight = new System.Windows.Forms.Button();
            this.divide = new System.Windows.Forms.Button();
            this.clearall = new System.Windows.Forms.Button();
            this.clearpart = new System.Windows.Forms.Button();
            this.multiply = new System.Windows.Forms.Button();
            this.five = new System.Windows.Forms.Button();
            this.six = new System.Windows.Forms.Button();
            this.four = new System.Windows.Forms.Button();
            this.subtract = new System.Windows.Forms.Button();
            this.two = new System.Windows.Forms.Button();
            this.three = new System.Windows.Forms.Button();
            this.one = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Button();
            this.dec = new System.Windows.Forms.Button();
            this.zero = new System.Windows.Forms.Button();
            this.arithmeticEqualButton = new System.Windows.Forms.Button();
            this.arithback = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.labeCurrentOperation = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(85, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Arithmetic\r\n";
            // 
            // arithmeticTextBox
            // 
            this.arithmeticTextBox.ForeColor = System.Drawing.Color.Black;
            this.arithmeticTextBox.Location = new System.Drawing.Point(13, 75);
            this.arithmeticTextBox.Multiline = true;
            this.arithmeticTextBox.Name = "arithmeticTextBox";
            this.arithmeticTextBox.Size = new System.Drawing.Size(273, 20);
            this.arithmeticTextBox.TabIndex = 1;
            // 
            // seven
            // 
            this.seven.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.seven.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.seven.Location = new System.Drawing.Point(13, 102);
            this.seven.Name = "seven";
            this.seven.Size = new System.Drawing.Size(53, 50);
            this.seven.TabIndex = 2;
            this.seven.Text = "7";
            this.seven.UseVisualStyleBackColor = true;
            this.seven.Click += new System.EventHandler(this.seven_Click);
            // 
            // nine
            // 
            this.nine.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.nine.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.nine.Location = new System.Drawing.Point(127, 102);
            this.nine.Name = "nine";
            this.nine.Size = new System.Drawing.Size(49, 50);
            this.nine.TabIndex = 3;
            this.nine.Text = "9";
            this.nine.UseVisualStyleBackColor = true;
            this.nine.Click += new System.EventHandler(this.nine_Click);
            // 
            // eight
            // 
            this.eight.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.eight.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.eight.Location = new System.Drawing.Point(72, 102);
            this.eight.Name = "eight";
            this.eight.Size = new System.Drawing.Size(49, 50);
            this.eight.TabIndex = 4;
            this.eight.Text = "8";
            this.eight.UseVisualStyleBackColor = true;
            this.eight.Click += new System.EventHandler(this.eight_Click);
            // 
            // divide
            // 
            this.divide.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.divide.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.divide.Location = new System.Drawing.Point(182, 102);
            this.divide.Name = "divide";
            this.divide.Size = new System.Drawing.Size(49, 50);
            this.divide.TabIndex = 5;
            this.divide.Text = "/";
            this.divide.UseVisualStyleBackColor = true;
            this.divide.Click += new System.EventHandler(this.operator_click);
            // 
            // clearall
            // 
            this.clearall.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.clearall.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.clearall.Location = new System.Drawing.Point(237, 102);
            this.clearall.Name = "clearall";
            this.clearall.Size = new System.Drawing.Size(49, 50);
            this.clearall.TabIndex = 6;
            this.clearall.Text = "CE";
            this.clearall.UseVisualStyleBackColor = true;
            this.clearall.Click += new System.EventHandler(this.clearall_Click);
            // 
            // clearpart
            // 
            this.clearpart.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.clearpart.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.clearpart.Location = new System.Drawing.Point(237, 158);
            this.clearpart.Name = "clearpart";
            this.clearpart.Size = new System.Drawing.Size(49, 48);
            this.clearpart.TabIndex = 11;
            this.clearpart.Text = "C";
            this.clearpart.UseVisualStyleBackColor = true;
            this.clearpart.Click += new System.EventHandler(this.clearpart_Click);
            // 
            // multiply
            // 
            this.multiply.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.multiply.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.multiply.Location = new System.Drawing.Point(182, 158);
            this.multiply.Name = "multiply";
            this.multiply.Size = new System.Drawing.Size(49, 48);
            this.multiply.TabIndex = 10;
            this.multiply.Text = "*";
            this.multiply.UseVisualStyleBackColor = true;
            this.multiply.Click += new System.EventHandler(this.operator_click);
            // 
            // five
            // 
            this.five.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.five.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.five.Location = new System.Drawing.Point(72, 158);
            this.five.Name = "five";
            this.five.Size = new System.Drawing.Size(49, 48);
            this.five.TabIndex = 9;
            this.five.Text = "5";
            this.five.UseVisualStyleBackColor = true;
            this.five.Click += new System.EventHandler(this.five_Click);
            // 
            // six
            // 
            this.six.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.six.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.six.Location = new System.Drawing.Point(127, 158);
            this.six.Name = "six";
            this.six.Size = new System.Drawing.Size(49, 48);
            this.six.TabIndex = 8;
            this.six.Text = "6";
            this.six.UseVisualStyleBackColor = true;
            this.six.Click += new System.EventHandler(this.six_Click);
            // 
            // four
            // 
            this.four.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.four.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.four.Location = new System.Drawing.Point(13, 158);
            this.four.Name = "four";
            this.four.Size = new System.Drawing.Size(53, 48);
            this.four.TabIndex = 7;
            this.four.Text = "4";
            this.four.UseVisualStyleBackColor = true;
            this.four.Click += new System.EventHandler(this.four_Click);
            // 
            // subtract
            // 
            this.subtract.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.subtract.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.subtract.Location = new System.Drawing.Point(182, 212);
            this.subtract.Name = "subtract";
            this.subtract.Size = new System.Drawing.Size(49, 50);
            this.subtract.TabIndex = 15;
            this.subtract.Text = "-";
            this.subtract.UseVisualStyleBackColor = true;
            this.subtract.Click += new System.EventHandler(this.operator_click);
            // 
            // two
            // 
            this.two.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.two.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.two.Location = new System.Drawing.Point(72, 212);
            this.two.Name = "two";
            this.two.Size = new System.Drawing.Size(49, 50);
            this.two.TabIndex = 14;
            this.two.Text = "2";
            this.two.UseVisualStyleBackColor = true;
            this.two.Click += new System.EventHandler(this.two_Click);
            // 
            // three
            // 
            this.three.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.three.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.three.Location = new System.Drawing.Point(127, 212);
            this.three.Name = "three";
            this.three.Size = new System.Drawing.Size(49, 50);
            this.three.TabIndex = 13;
            this.three.Text = "3";
            this.three.UseVisualStyleBackColor = true;
            this.three.Click += new System.EventHandler(this.three_Click);
            // 
            // one
            // 
            this.one.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.one.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.one.Location = new System.Drawing.Point(13, 212);
            this.one.Name = "one";
            this.one.Size = new System.Drawing.Size(53, 50);
            this.one.TabIndex = 12;
            this.one.Text = "1";
            this.one.UseVisualStyleBackColor = true;
            this.one.Click += new System.EventHandler(this.one_Click);
            // 
            // add
            // 
            this.add.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.add.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.add.Location = new System.Drawing.Point(182, 268);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(49, 50);
            this.add.TabIndex = 17;
            this.add.Text = "+";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.operator_click);
            // 
            // dec
            // 
            this.dec.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.dec.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.dec.Location = new System.Drawing.Point(127, 268);
            this.dec.Name = "dec";
            this.dec.Size = new System.Drawing.Size(49, 50);
            this.dec.TabIndex = 16;
            this.dec.Text = ".";
            this.dec.UseVisualStyleBackColor = true;
            this.dec.Click += new System.EventHandler(this.dec_Click);
            // 
            // zero
            // 
            this.zero.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.zero.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.zero.Location = new System.Drawing.Point(13, 268);
            this.zero.Name = "zero";
            this.zero.Size = new System.Drawing.Size(108, 50);
            this.zero.TabIndex = 18;
            this.zero.Text = "0";
            this.zero.UseVisualStyleBackColor = true;
            this.zero.Click += new System.EventHandler(this.zero_Click);
            // 
            // arithmeticEqualButton
            // 
            this.arithmeticEqualButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.arithmeticEqualButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.arithmeticEqualButton.Location = new System.Drawing.Point(237, 212);
            this.arithmeticEqualButton.Name = "arithmeticEqualButton";
            this.arithmeticEqualButton.Size = new System.Drawing.Size(49, 106);
            this.arithmeticEqualButton.TabIndex = 19;
            this.arithmeticEqualButton.Text = "=";
            this.arithmeticEqualButton.UseVisualStyleBackColor = true;
            this.arithmeticEqualButton.Click += new System.EventHandler(this.arithmeticEqualButton_Click);
            // 
            // arithback
            // 
            this.arithback.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.arithback.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.arithback.Location = new System.Drawing.Point(100, 342);
            this.arithback.Name = "arithback";
            this.arithback.Size = new System.Drawing.Size(102, 44);
            this.arithback.TabIndex = 20;
            this.arithback.Text = "Main Form\r\n";
            this.arithback.UseVisualStyleBackColor = true;
            this.arithback.Click += new System.EventHandler(this.arithback_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.label2.Location = new System.Drawing.Point(12, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 21;
            // 
            // labeCurrentOperation
            // 
            this.labeCurrentOperation.AutoSize = true;
            this.labeCurrentOperation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.labeCurrentOperation.Location = new System.Drawing.Point(12, 59);
            this.labeCurrentOperation.Name = "labeCurrentOperation";
            this.labeCurrentOperation.Size = new System.Drawing.Size(0, 13);
            this.labeCurrentOperation.TabIndex = 22;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.pictureBox1.Location = new System.Drawing.Point(-4, -10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(318, 66);
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // fArith
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Navy;
            this.ClientSize = new System.Drawing.Size(302, 433);
            this.Controls.Add(this.labeCurrentOperation);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.arithback);
            this.Controls.Add(this.arithmeticEqualButton);
            this.Controls.Add(this.zero);
            this.Controls.Add(this.add);
            this.Controls.Add(this.dec);
            this.Controls.Add(this.subtract);
            this.Controls.Add(this.two);
            this.Controls.Add(this.three);
            this.Controls.Add(this.one);
            this.Controls.Add(this.clearpart);
            this.Controls.Add(this.multiply);
            this.Controls.Add(this.five);
            this.Controls.Add(this.six);
            this.Controls.Add(this.four);
            this.Controls.Add(this.clearall);
            this.Controls.Add(this.divide);
            this.Controls.Add(this.eight);
            this.Controls.Add(this.nine);
            this.Controls.Add(this.seven);
            this.Controls.Add(this.arithmeticTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "fArith";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fArith";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox arithmeticTextBox;
        private System.Windows.Forms.Button seven;
        private System.Windows.Forms.Button nine;
        private System.Windows.Forms.Button eight;
        private System.Windows.Forms.Button divide;
        private System.Windows.Forms.Button clearall;
        private System.Windows.Forms.Button clearpart;
        private System.Windows.Forms.Button multiply;
        private System.Windows.Forms.Button five;
        private System.Windows.Forms.Button six;
        private System.Windows.Forms.Button four;
        private System.Windows.Forms.Button subtract;
        private System.Windows.Forms.Button two;
        private System.Windows.Forms.Button three;
        private System.Windows.Forms.Button one;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button dec;
        private System.Windows.Forms.Button zero;
        private System.Windows.Forms.Button arithmeticEqualButton;
        private System.Windows.Forms.Button arithback;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labeCurrentOperation;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}