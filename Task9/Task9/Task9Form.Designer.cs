namespace Task9
{
    partial class Task9Form
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
            this.label2 = new System.Windows.Forms.Label();
            this.arrayBox = new System.Windows.Forms.TextBox();
            this.rndButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.recResLabel = new System.Windows.Forms.Label();
            this.iterResLabel = new System.Windows.Forms.Label();
            this.goButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(705, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Задание 9. Задан линейный список целых чисел. Вычислить сумму всех его элементов " +
    "с помощью\rрекурсивной и нерекурсивной функций.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Элементы списка:";
            // 
            // arrayBox
            // 
            this.arrayBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.arrayBox.Location = new System.Drawing.Point(12, 78);
            this.arrayBox.Name = "arrayBox";
            this.arrayBox.Size = new System.Drawing.Size(611, 24);
            this.arrayBox.TabIndex = 2;
            this.arrayBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.arrayBox_KeyPress);
            // 
            // rndButton
            // 
            this.rndButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rndButton.Location = new System.Drawing.Point(629, 78);
            this.rndButton.Name = "rndButton";
            this.rndButton.Size = new System.Drawing.Size(100, 24);
            this.rndButton.TabIndex = 3;
            this.rndButton.Text = "Случайно";
            this.rndButton.UseVisualStyleBackColor = true;
            this.rndButton.Click += new System.EventHandler(this.rndButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(236, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(182, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Элементы разделяются пробелом";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(12, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 18);
            this.label4.TabIndex = 5;
            this.label4.Text = "Сумма:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(42, 147);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 18);
            this.label5.TabIndex = 6;
            this.label5.Text = "Рекурсивно:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(42, 190);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 18);
            this.label6.TabIndex = 7;
            this.label6.Text = "Нерекурсивно:";
            // 
            // recResLabel
            // 
            this.recResLabel.AutoSize = true;
            this.recResLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.recResLabel.Location = new System.Drawing.Point(201, 147);
            this.recResLabel.Name = "recResLabel";
            this.recResLabel.Size = new System.Drawing.Size(13, 18);
            this.recResLabel.TabIndex = 8;
            this.recResLabel.Text = "-";
            // 
            // iterResLabel
            // 
            this.iterResLabel.AutoSize = true;
            this.iterResLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.iterResLabel.Location = new System.Drawing.Point(201, 190);
            this.iterResLabel.Name = "iterResLabel";
            this.iterResLabel.Size = new System.Drawing.Size(13, 18);
            this.iterResLabel.TabIndex = 9;
            this.iterResLabel.Text = "-";
            // 
            // goButton
            // 
            this.goButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.goButton.Location = new System.Drawing.Point(600, 188);
            this.goButton.Name = "goButton";
            this.goButton.Size = new System.Drawing.Size(129, 24);
            this.goButton.TabIndex = 10;
            this.goButton.Text = "Суммировать";
            this.goButton.UseVisualStyleBackColor = true;
            this.goButton.Click += new System.EventHandler(this.goButton_Click);
            // 
            // Task9Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(738, 222);
            this.Controls.Add(this.goButton);
            this.Controls.Add(this.iterResLabel);
            this.Controls.Add(this.recResLabel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.rndButton);
            this.Controls.Add(this.arrayBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Task9Form";
            this.Text = "Задание 9";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox arrayBox;
        private System.Windows.Forms.Button rndButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label recResLabel;
        private System.Windows.Forms.Label iterResLabel;
        private System.Windows.Forms.Button goButton;
    }
}

