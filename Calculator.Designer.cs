namespace TSA
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
            this.arithmetic = new System.Windows.Forms.Button();
            this.Statistics = new System.Windows.Forms.Button();
            this.Geometry = new System.Windows.Forms.Button();
            this.Algebra = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // arithmetic
            // 
            this.arithmetic.BackColor = System.Drawing.Color.Navy;
            this.arithmetic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.arithmetic.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.arithmetic.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.arithmetic.Location = new System.Drawing.Point(72, 120);
            this.arithmetic.Name = "arithmetic";
            this.arithmetic.Size = new System.Drawing.Size(65, 39);
            this.arithmetic.TabIndex = 1;
            this.arithmetic.Text = "Arithmetic";
            this.arithmetic.UseVisualStyleBackColor = false;
            this.arithmetic.Click += new System.EventHandler(this.fournum_Click);
            // 
            // Statistics
            // 
            this.Statistics.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.Statistics.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.Statistics.Location = new System.Drawing.Point(72, 198);
            this.Statistics.Name = "Statistics";
            this.Statistics.Size = new System.Drawing.Size(65, 37);
            this.Statistics.TabIndex = 2;
            this.Statistics.Text = "Statistics";
            this.Statistics.UseVisualStyleBackColor = true;
            this.Statistics.Click += new System.EventHandler(this.Statistics_Click);
            // 
            // Geometry
            // 
            this.Geometry.BackColor = System.Drawing.Color.Navy;
            this.Geometry.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.Geometry.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.Geometry.Location = new System.Drawing.Point(183, 120);
            this.Geometry.Name = "Geometry";
            this.Geometry.Size = new System.Drawing.Size(65, 39);
            this.Geometry.TabIndex = 3;
            this.Geometry.Text = "Geometry";
            this.Geometry.UseVisualStyleBackColor = false;
            this.Geometry.Click += new System.EventHandler(this.Geometry_Click);
            // 
            // Algebra
            // 
            this.Algebra.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.Algebra.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.Algebra.Location = new System.Drawing.Point(183, 198);
            this.Algebra.Name = "Algebra";
            this.Algebra.Size = new System.Drawing.Size(65, 37);
            this.Algebra.TabIndex = 4;
            this.Algebra.Text = "Algebra";
            this.Algebra.UseVisualStyleBackColor = true;
            this.Algebra.Click += new System.EventHandler(this.Algebra_Click);
            // 
            // Exit
            // 
            this.Exit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.Exit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.Exit.Location = new System.Drawing.Point(121, 270);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(78, 24);
            this.Exit.TabIndex = 5;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(46, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(247, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "All Purpose Calculator";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.pictureBox1.Location = new System.Drawing.Point(-3, -6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(335, 89);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Navy;
            this.ClientSize = new System.Drawing.Size(325, 334);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.Algebra);
            this.Controls.Add(this.Geometry);
            this.Controls.Add(this.Statistics);
            this.Controls.Add(this.arithmetic);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Calculator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion
        private System.Windows.Forms.Button arithmetic;
        private System.Windows.Forms.Button Statistics;
        private System.Windows.Forms.Button Geometry;
        private System.Windows.Forms.Button Algebra;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

