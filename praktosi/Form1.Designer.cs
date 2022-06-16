namespace praktosi
{
    partial class Form1
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
            this.textA = new System.Windows.Forms.TextBox();
            this.textB = new System.Windows.Forms.TextBox();
            this.textK = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.resultText = new System.Windows.Forms.TextBox();
            this.textR = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textS = new System.Windows.Forms.TextBox();
            this.textD = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textA
            // 
            this.textA.Location = new System.Drawing.Point(96, 16);
            this.textA.Name = "textA";
            this.textA.Size = new System.Drawing.Size(100, 23);
            this.textA.TabIndex = 0;
            // 
            // textB
            // 
            this.textB.Location = new System.Drawing.Point(96, 45);
            this.textB.Name = "textB";
            this.textB.Size = new System.Drawing.Size(100, 23);
            this.textB.TabIndex = 1;
            // 
            // textK
            // 
            this.textK.Location = new System.Drawing.Point(96, 74);
            this.textK.Name = "textK";
            this.textK.Size = new System.Drawing.Size(100, 23);
            this.textK.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(202, 44);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "посчитать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Длина A";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Ширина B";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Стоимость K";
            // 
            // resultText
            // 
            this.resultText.Location = new System.Drawing.Point(283, 44);
            this.resultText.Name = "resultText";
            this.resultText.Size = new System.Drawing.Size(100, 23);
            this.resultText.TabIndex = 7;
            // 
            // textR
            // 
            this.textR.Location = new System.Drawing.Point(658, 45);
            this.textR.Name = "textR";
            this.textR.Size = new System.Drawing.Size(100, 23);
            this.textR.TabIndex = 8;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(673, 73);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "посчитать";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(664, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "Радиус R";
            // 
            // textS
            // 
            this.textS.Location = new System.Drawing.Point(658, 102);
            this.textS.Name = "textS";
            this.textS.Size = new System.Drawing.Size(100, 23);
            this.textS.TabIndex = 11;
            this.textS.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textD
            // 
            this.textD.Location = new System.Drawing.Point(658, 131);
            this.textD.Name = "textD";
            this.textD.Size = new System.Drawing.Size(100, 23);
            this.textD.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(593, 105);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 15);
            this.label5.TabIndex = 13;
            this.label5.Text = "Площадь";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(610, 134);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 15);
            this.label6.TabIndex = 14;
            this.label6.Text = "Длина";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textD);
            this.Controls.Add(this.textS);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textR);
            this.Controls.Add(this.resultText);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textK);
            this.Controls.Add(this.textB);
            this.Controls.Add(this.textA);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textA;
        private System.Windows.Forms.TextBox textB;
        private System.Windows.Forms.TextBox textK;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox resultText;
        private System.Windows.Forms.TextBox textR;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textS;
        private System.Windows.Forms.TextBox textD;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}
