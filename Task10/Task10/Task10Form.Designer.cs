namespace Task10
{
    partial class Task10Form
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
            this.taskLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.nBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.arrayBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.resLabel = new System.Windows.Forms.Label();
            this.goButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // taskLabel
            // 
            this.taskLabel.AutoSize = true;
            this.taskLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.taskLabel.Location = new System.Drawing.Point(12, 9);
            this.taskLabel.Name = "taskLabel";
            this.taskLabel.Size = new System.Drawing.Size(797, 18);
            this.taskLabel.TabIndex = 0;
            this.taskLabel.Text = "Задание 10. Дано натуральное число n, действительные числа xi, ..., xn. Вычислить" +
    ": X1*Xn + X2*Xn-i + ... + Xn*X1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(32, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "N";
            // 
            // nBox
            // 
            this.nBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nBox.Location = new System.Drawing.Point(15, 58);
            this.nBox.Name = "nBox";
            this.nBox.Size = new System.Drawing.Size(50, 24);
            this.nBox.TabIndex = 2;
            this.nBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nBox_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(112, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "x1, x2, ..., xn";
            // 
            // arrayBox
            // 
            this.arrayBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.arrayBox.Location = new System.Drawing.Point(101, 58);
            this.arrayBox.Name = "arrayBox";
            this.arrayBox.Size = new System.Drawing.Size(708, 24);
            this.arrayBox.TabIndex = 4;
            this.arrayBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.arrayBox_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "Ответ:";
            // 
            // resLabel
            // 
            this.resLabel.AutoSize = true;
            this.resLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.resLabel.Location = new System.Drawing.Point(98, 98);
            this.resLabel.Name = "resLabel";
            this.resLabel.Size = new System.Drawing.Size(13, 18);
            this.resLabel.TabIndex = 6;
            this.resLabel.Text = "-";
            // 
            // goButton
            // 
            this.goButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.goButton.Location = new System.Drawing.Point(692, 92);
            this.goButton.Name = "goButton";
            this.goButton.Size = new System.Drawing.Size(117, 31);
            this.goButton.TabIndex = 7;
            this.goButton.Text = "Вычислить";
            this.goButton.UseVisualStyleBackColor = true;
            this.goButton.Click += new System.EventHandler(this.goButton_Click);
            // 
            // Task10Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(822, 137);
            this.Controls.Add(this.goButton);
            this.Controls.Add(this.resLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.arrayBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.taskLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Task10Form";
            this.Text = "Задание 10";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label taskLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox arrayBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label resLabel;
        private System.Windows.Forms.Button goButton;
    }
}

