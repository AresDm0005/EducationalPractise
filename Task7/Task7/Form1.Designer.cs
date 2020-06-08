namespace Task7
{
    partial class Task7Form
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
            this.vecBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.resBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.goButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // taskLabel
            // 
            this.taskLabel.AutoSize = true;
            this.taskLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.taskLabel.Location = new System.Drawing.Point(12, 9);
            this.taskLabel.Name = "taskLabel";
            this.taskLabel.Size = new System.Drawing.Size(830, 36);
            this.taskLabel.TabIndex = 0;
            this.taskLabel.Text = "Задание 7. Доопределить заданную булеву функцию всеми возможными способами так, ч" +
    "тобы она была линейной.\rВыписать все вектора в лексикографическом порядке.";
            // 
            // vecBox
            // 
            this.vecBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.vecBox.Location = new System.Drawing.Point(12, 85);
            this.vecBox.MaxLength = 16;
            this.vecBox.Name = "vecBox";
            this.vecBox.Size = new System.Drawing.Size(827, 24);
            this.vecBox.TabIndex = 1;
            this.vecBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.vecBox_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(256, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(330, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "До 16 значений, для обознчения пропуска ввести * (звездочка)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Вектор:";
            // 
            // resBox
            // 
            this.resBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.resBox.Location = new System.Drawing.Point(12, 159);
            this.resBox.Multiline = true;
            this.resBox.Name = "resBox";
            this.resBox.ReadOnly = true;
            this.resBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.resBox.Size = new System.Drawing.Size(293, 127);
            this.resBox.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(190, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "Способы доопределения:";
            // 
            // goButton
            // 
            this.goButton.Location = new System.Drawing.Point(685, 256);
            this.goButton.Name = "goButton";
            this.goButton.Size = new System.Drawing.Size(154, 30);
            this.goButton.TabIndex = 6;
            this.goButton.Text = "Решить";
            this.goButton.UseVisualStyleBackColor = true;
            this.goButton.Click += new System.EventHandler(this.goButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(322, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 18);
            this.label4.TabIndex = 7;
            this.label4.Text = "Пример:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(322, 162);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(355, 36);
            this.label5.TabIndex = 8;
            this.label5.Text = "Функцию: 00000000****0000 можно доопределить\rдо линейной только так: 000000000000" +
    "0000";
            // 
            // Task7Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(845, 298);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.goButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.resBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.vecBox);
            this.Controls.Add(this.taskLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Task7Form";
            this.Text = "Задание 7";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label taskLabel;
        private System.Windows.Forms.TextBox vecBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox resBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button goButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

