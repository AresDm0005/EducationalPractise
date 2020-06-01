namespace Task6
{
    partial class Task6Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Task6Form));
            this.taskLabel = new System.Windows.Forms.Label();
            this.a1Box = new System.Windows.Forms.TextBox();
            this.a1 = new System.Windows.Forms.Label();
            this.a2 = new System.Windows.Forms.Label();
            this.a2Box = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.a3Box = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.mBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.nBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.resultLabel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.resultBox = new System.Windows.Forms.TextBox();
            this.goButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // taskLabel
            // 
            this.taskLabel.AutoSize = true;
            this.taskLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.taskLabel.Location = new System.Drawing.Point(12, 9);
            this.taskLabel.Name = "taskLabel";
            this.taskLabel.Size = new System.Drawing.Size(820, 54);
            this.taskLabel.TabIndex = 0;
            this.taskLabel.Text = resources.GetString("taskLabel.Text");
            // 
            // a1Box
            // 
            this.a1Box.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.a1Box.Location = new System.Drawing.Point(30, 100);
            this.a1Box.Name = "a1Box";
            this.a1Box.Size = new System.Drawing.Size(60, 24);
            this.a1Box.TabIndex = 1;
            this.a1Box.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Seq_KeyPress);
            // 
            // a1
            // 
            this.a1.AutoSize = true;
            this.a1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.a1.Location = new System.Drawing.Point(50, 80);
            this.a1.Name = "a1";
            this.a1.Size = new System.Drawing.Size(24, 18);
            this.a1.TabIndex = 2;
            this.a1.Text = "a1";
            // 
            // a2
            // 
            this.a2.AutoSize = true;
            this.a2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.a2.Location = new System.Drawing.Point(140, 80);
            this.a2.Name = "a2";
            this.a2.Size = new System.Drawing.Size(24, 18);
            this.a2.TabIndex = 4;
            this.a2.Text = "a2";
            // 
            // a2Box
            // 
            this.a2Box.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.a2Box.Location = new System.Drawing.Point(120, 100);
            this.a2Box.Name = "a2Box";
            this.a2Box.Size = new System.Drawing.Size(60, 24);
            this.a2Box.TabIndex = 2;
            this.a2Box.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Seq_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(230, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "a3";
            // 
            // a3Box
            // 
            this.a3Box.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.a3Box.Location = new System.Drawing.Point(210, 100);
            this.a3Box.Name = "a3Box";
            this.a3Box.Size = new System.Drawing.Size(60, 24);
            this.a3Box.TabIndex = 5;
            this.a3Box.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Seq_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(320, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 18);
            this.label4.TabIndex = 8;
            this.label4.Text = "M";
            // 
            // mBox
            // 
            this.mBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mBox.Location = new System.Drawing.Point(300, 100);
            this.mBox.Name = "mBox";
            this.mBox.Size = new System.Drawing.Size(60, 24);
            this.mBox.TabIndex = 7;
            this.mBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Params_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(410, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(19, 18);
            this.label5.TabIndex = 10;
            this.label5.Text = "N";
            // 
            // nBox
            // 
            this.nBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nBox.Location = new System.Drawing.Point(390, 100);
            this.nBox.Name = "nBox";
            this.nBox.Size = new System.Drawing.Size(60, 24);
            this.nBox.TabIndex = 9;
            this.nBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Params_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(12, 141);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(164, 18);
            this.label6.TabIndex = 11;
            this.label6.Text = "Выполнилось раньше:";
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.resultLabel.Location = new System.Drawing.Point(196, 141);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(16, 18);
            this.resultLabel.TabIndex = 12;
            this.resultLabel.Text = "1";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(12, 172);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(576, 18);
            this.label7.TabIndex = 13;
            this.label7.Text = "Элементы последовательности, в соответствии с тем что выполнилось раньше:";
            // 
            // resultBox
            // 
            this.resultBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.resultBox.Location = new System.Drawing.Point(15, 193);
            this.resultBox.Name = "resultBox";
            this.resultBox.Size = new System.Drawing.Size(814, 24);
            this.resultBox.TabIndex = 14;
            // 
            // goButton
            // 
            this.goButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.goButton.Location = new System.Drawing.Point(496, 98);
            this.goButton.Name = "goButton";
            this.goButton.Size = new System.Drawing.Size(116, 28);
            this.goButton.TabIndex = 15;
            this.goButton.Text = "Построить!";
            this.goButton.UseVisualStyleBackColor = true;
            this.goButton.Click += new System.EventHandler(this.goButton_Click);
            // 
            // Task6Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(841, 229);
            this.Controls.Add(this.goButton);
            this.Controls.Add(this.resultBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.nBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.mBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.a3Box);
            this.Controls.Add(this.a2);
            this.Controls.Add(this.a2Box);
            this.Controls.Add(this.a1);
            this.Controls.Add(this.a1Box);
            this.Controls.Add(this.taskLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Task6Form";
            this.Text = "Задание 6";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label taskLabel;
        private System.Windows.Forms.TextBox a1Box;
        private System.Windows.Forms.Label a1;
        private System.Windows.Forms.Label a2;
        private System.Windows.Forms.TextBox a2Box;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox a3Box;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox mBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox nBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox resultBox;
        private System.Windows.Forms.Button goButton;
    }
}

