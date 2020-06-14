namespace Task12
{
    partial class Task12Form
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
            this.arrayBox = new System.Windows.Forms.TextBox();
            this.rndButton = new System.Windows.Forms.Button();
            this.ascenBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.descenBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.randBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.insTrans1 = new System.Windows.Forms.Label();
            this.insComp1 = new System.Windows.Forms.Label();
            this.radTrans1 = new System.Windows.Forms.Label();
            this.radComp1 = new System.Windows.Forms.Label();
            this.radComp2 = new System.Windows.Forms.Label();
            this.radTrans2 = new System.Windows.Forms.Label();
            this.insComp2 = new System.Windows.Forms.Label();
            this.insTrans2 = new System.Windows.Forms.Label();
            this.radComp3 = new System.Windows.Forms.Label();
            this.radTrans3 = new System.Windows.Forms.Label();
            this.insComp3 = new System.Windows.Forms.Label();
            this.insTrans3 = new System.Windows.Forms.Label();
            this.goButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // taskLabel
            // 
            this.taskLabel.AutoSize = true;
            this.taskLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.taskLabel.Location = new System.Drawing.Point(12, 9);
            this.taskLabel.Name = "taskLabel";
            this.taskLabel.Size = new System.Drawing.Size(956, 18);
            this.taskLabel.TabIndex = 0;
            this.taskLabel.Text = "Задание 12. Выполнить сравнение сортировки простыми вставками и поразрядной сорти" +
    "ровки по количеству пересылок и сравнений.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Массив:";
            // 
            // arrayBox
            // 
            this.arrayBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.arrayBox.Location = new System.Drawing.Point(15, 64);
            this.arrayBox.Name = "arrayBox";
            this.arrayBox.Size = new System.Drawing.Size(670, 24);
            this.arrayBox.TabIndex = 2;
            // 
            // rndButton
            // 
            this.rndButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rndButton.Location = new System.Drawing.Point(691, 64);
            this.rndButton.Name = "rndButton";
            this.rndButton.Size = new System.Drawing.Size(269, 24);
            this.rndButton.TabIndex = 3;
            this.rndButton.Text = "Заполнить случайными значениями";
            this.rndButton.UseVisualStyleBackColor = true;
            this.rndButton.Click += new System.EventHandler(this.rndButton_Click);
            // 
            // ascenBox
            // 
            this.ascenBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ascenBox.Location = new System.Drawing.Point(15, 187);
            this.ascenBox.Name = "ascenBox";
            this.ascenBox.ReadOnly = true;
            this.ascenBox.Size = new System.Drawing.Size(517, 24);
            this.ascenBox.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "По возрастанию:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 245);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 18);
            this.label3.TabIndex = 7;
            this.label3.Text = "По убыванию";
            // 
            // descenBox
            // 
            this.descenBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.descenBox.Location = new System.Drawing.Point(15, 266);
            this.descenBox.Name = "descenBox";
            this.descenBox.ReadOnly = true;
            this.descenBox.Size = new System.Drawing.Size(517, 24);
            this.descenBox.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(12, 329);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 18);
            this.label4.TabIndex = 9;
            this.label4.Text = "Неупорядоченный";
            // 
            // randBox
            // 
            this.randBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.randBox.Location = new System.Drawing.Point(15, 350);
            this.randBox.Name = "randBox";
            this.randBox.ReadOnly = true;
            this.randBox.Size = new System.Drawing.Size(517, 24);
            this.randBox.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(12, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 18);
            this.label5.TabIndex = 10;
            this.label5.Text = "Упорядочен:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(630, 117);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 18);
            this.label6.TabIndex = 11;
            this.label6.Text = "Вставками:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(724, 104);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 18);
            this.label7.TabIndex = 12;
            this.label7.Text = "Сортировка";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(823, 117);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(101, 18);
            this.label8.TabIndex = 13;
            this.label8.Text = "Поразрядная";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(576, 135);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(84, 18);
            this.label9.TabIndex = 14;
            this.label9.Text = "пересылки";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(675, 135);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(80, 18);
            this.label10.TabIndex = 15;
            this.label10.Text = "сравнения";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(880, 135);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(80, 18);
            this.label11.TabIndex = 17;
            this.label11.Text = "сравнения";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(781, 135);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(84, 18);
            this.label12.TabIndex = 16;
            this.label12.Text = "пересылки";
            // 
            // insTrans1
            // 
            this.insTrans1.AutoSize = true;
            this.insTrans1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.insTrans1.Location = new System.Drawing.Point(604, 190);
            this.insTrans1.Name = "insTrans1";
            this.insTrans1.Size = new System.Drawing.Size(16, 18);
            this.insTrans1.TabIndex = 18;
            this.insTrans1.Text = "?";
            // 
            // insComp1
            // 
            this.insComp1.AutoSize = true;
            this.insComp1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.insComp1.Location = new System.Drawing.Point(702, 190);
            this.insComp1.Name = "insComp1";
            this.insComp1.Size = new System.Drawing.Size(16, 18);
            this.insComp1.TabIndex = 19;
            this.insComp1.Text = "?";
            // 
            // radTrans1
            // 
            this.radTrans1.AutoSize = true;
            this.radTrans1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radTrans1.Location = new System.Drawing.Point(812, 190);
            this.radTrans1.Name = "radTrans1";
            this.radTrans1.Size = new System.Drawing.Size(16, 18);
            this.radTrans1.TabIndex = 20;
            this.radTrans1.Text = "?";
            // 
            // radComp1
            // 
            this.radComp1.AutoSize = true;
            this.radComp1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radComp1.Location = new System.Drawing.Point(908, 190);
            this.radComp1.Name = "radComp1";
            this.radComp1.Size = new System.Drawing.Size(16, 18);
            this.radComp1.TabIndex = 21;
            this.radComp1.Text = "?";
            // 
            // radComp2
            // 
            this.radComp2.AutoSize = true;
            this.radComp2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radComp2.Location = new System.Drawing.Point(908, 269);
            this.radComp2.Name = "radComp2";
            this.radComp2.Size = new System.Drawing.Size(16, 18);
            this.radComp2.TabIndex = 25;
            this.radComp2.Text = "?";
            // 
            // radTrans2
            // 
            this.radTrans2.AutoSize = true;
            this.radTrans2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radTrans2.Location = new System.Drawing.Point(812, 269);
            this.radTrans2.Name = "radTrans2";
            this.radTrans2.Size = new System.Drawing.Size(16, 18);
            this.radTrans2.TabIndex = 24;
            this.radTrans2.Text = "?";
            // 
            // insComp2
            // 
            this.insComp2.AutoSize = true;
            this.insComp2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.insComp2.Location = new System.Drawing.Point(702, 269);
            this.insComp2.Name = "insComp2";
            this.insComp2.Size = new System.Drawing.Size(16, 18);
            this.insComp2.TabIndex = 23;
            this.insComp2.Text = "?";
            // 
            // insTrans2
            // 
            this.insTrans2.AutoSize = true;
            this.insTrans2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.insTrans2.Location = new System.Drawing.Point(604, 269);
            this.insTrans2.Name = "insTrans2";
            this.insTrans2.Size = new System.Drawing.Size(16, 18);
            this.insTrans2.TabIndex = 22;
            this.insTrans2.Text = "?";
            // 
            // radComp3
            // 
            this.radComp3.AutoSize = true;
            this.radComp3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radComp3.Location = new System.Drawing.Point(908, 353);
            this.radComp3.Name = "radComp3";
            this.radComp3.Size = new System.Drawing.Size(16, 18);
            this.radComp3.TabIndex = 29;
            this.radComp3.Text = "?";
            // 
            // radTrans3
            // 
            this.radTrans3.AutoSize = true;
            this.radTrans3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radTrans3.Location = new System.Drawing.Point(812, 353);
            this.radTrans3.Name = "radTrans3";
            this.radTrans3.Size = new System.Drawing.Size(16, 18);
            this.radTrans3.TabIndex = 28;
            this.radTrans3.Text = "?";
            // 
            // insComp3
            // 
            this.insComp3.AutoSize = true;
            this.insComp3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.insComp3.Location = new System.Drawing.Point(702, 353);
            this.insComp3.Name = "insComp3";
            this.insComp3.Size = new System.Drawing.Size(16, 18);
            this.insComp3.TabIndex = 27;
            this.insComp3.Text = "?";
            // 
            // insTrans3
            // 
            this.insTrans3.AutoSize = true;
            this.insTrans3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.insTrans3.Location = new System.Drawing.Point(604, 353);
            this.insTrans3.Name = "insTrans3";
            this.insTrans3.Size = new System.Drawing.Size(16, 18);
            this.insTrans3.TabIndex = 26;
            this.insTrans3.Text = "?";
            // 
            // goButton
            // 
            this.goButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.goButton.Location = new System.Drawing.Point(718, 390);
            this.goButton.Name = "goButton";
            this.goButton.Size = new System.Drawing.Size(242, 30);
            this.goButton.TabIndex = 30;
            this.goButton.Text = "Отсортировать";
            this.goButton.UseVisualStyleBackColor = true;
            this.goButton.Click += new System.EventHandler(this.goButton_Click);
            // 
            // Task12Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(976, 432);
            this.Controls.Add(this.goButton);
            this.Controls.Add(this.radComp3);
            this.Controls.Add(this.radTrans3);
            this.Controls.Add(this.insComp3);
            this.Controls.Add(this.insTrans3);
            this.Controls.Add(this.radComp2);
            this.Controls.Add(this.radTrans2);
            this.Controls.Add(this.insComp2);
            this.Controls.Add(this.insTrans2);
            this.Controls.Add(this.radComp1);
            this.Controls.Add(this.radTrans1);
            this.Controls.Add(this.insComp1);
            this.Controls.Add(this.insTrans1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.randBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.descenBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ascenBox);
            this.Controls.Add(this.rndButton);
            this.Controls.Add(this.arrayBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.taskLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Task12Form";
            this.Text = "Задание 12";
            this.Load += new System.EventHandler(this.Task12Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label taskLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox arrayBox;
        private System.Windows.Forms.Button rndButton;
        private System.Windows.Forms.TextBox ascenBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox descenBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox randBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label insTrans1;
        private System.Windows.Forms.Label insComp1;
        private System.Windows.Forms.Label radTrans1;
        private System.Windows.Forms.Label radComp1;
        private System.Windows.Forms.Label radComp2;
        private System.Windows.Forms.Label radTrans2;
        private System.Windows.Forms.Label insComp2;
        private System.Windows.Forms.Label insTrans2;
        private System.Windows.Forms.Label radComp3;
        private System.Windows.Forms.Label radTrans3;
        private System.Windows.Forms.Label insComp3;
        private System.Windows.Forms.Label insTrans3;
        private System.Windows.Forms.Button goButton;
    }
}

