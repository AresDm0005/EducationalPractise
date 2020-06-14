namespace Task8
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
            this.label1 = new System.Windows.Forms.Label();
            this.matrBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.resBox = new System.Windows.Forms.TextBox();
            this.goButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.verBox = new System.Windows.Forms.TextBox();
            this.rebBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(708, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Задание 8. Неориентированный граф задан матрицей инциденций. Найти все его точки " +
    "сочленения.";
            // 
            // matrBox
            // 
            this.matrBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.matrBox.Location = new System.Drawing.Point(12, 116);
            this.matrBox.Multiline = true;
            this.matrBox.Name = "matrBox";
            this.matrBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.matrBox.Size = new System.Drawing.Size(461, 182);
            this.matrBox.TabIndex = 1;
            this.matrBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.matrBox_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(9, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Матрица:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(476, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "Точки сочленения";
            // 
            // resBox
            // 
            this.resBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.resBox.Location = new System.Drawing.Point(479, 116);
            this.resBox.Multiline = true;
            this.resBox.Name = "resBox";
            this.resBox.ReadOnly = true;
            this.resBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.resBox.Size = new System.Drawing.Size(170, 182);
            this.resBox.TabIndex = 4;
            // 
            // goButton
            // 
            this.goButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.goButton.Location = new System.Drawing.Point(655, 268);
            this.goButton.Name = "goButton";
            this.goButton.Size = new System.Drawing.Size(133, 30);
            this.goButton.TabIndex = 5;
            this.goButton.Text = "Найти!";
            this.goButton.UseVisualStyleBackColor = true;
            this.goButton.Click += new System.EventHandler(this.goButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(9, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 18);
            this.label4.TabIndex = 7;
            this.label4.Text = "Число вершин:";
            // 
            // verBox
            // 
            this.verBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.verBox.Location = new System.Drawing.Point(126, 50);
            this.verBox.MaxLength = 3;
            this.verBox.Name = "verBox";
            this.verBox.Size = new System.Drawing.Size(79, 24);
            this.verBox.TabIndex = 8;
            this.verBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.rebBox_KeyPress);
            // 
            // rebBox
            // 
            this.rebBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rebBox.Location = new System.Drawing.Point(348, 53);
            this.rebBox.MaxLength = 3;
            this.rebBox.Name = "rebBox";
            this.rebBox.Size = new System.Drawing.Size(79, 24);
            this.rebBox.TabIndex = 10;
            this.rebBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.rebBox_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(231, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 18);
            this.label5.TabIndex = 9;
            this.label5.Text = "Число ребер:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 310);
            this.Controls.Add(this.rebBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.verBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.goButton);
            this.Controls.Add(this.resBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.matrBox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox matrBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox resBox;
        private System.Windows.Forms.Button goButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox verBox;
        private System.Windows.Forms.TextBox rebBox;
        private System.Windows.Forms.Label label5;
    }
}

