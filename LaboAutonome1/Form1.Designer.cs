
namespace LaboAutonome1
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Arith = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.ArithValidation = new System.Windows.Forms.CheckBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Compa = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.textBox14 = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.Arith.SuspendLayout();
            this.Compa.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Arith);
            this.tabControl1.Controls.Add(this.Compa);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 450);
            this.tabControl1.TabIndex = 0;
            // 
            // Arith
            // 
            this.Arith.Controls.Add(this.textBox10);
            this.Arith.Controls.Add(this.textBox9);
            this.Arith.Controls.Add(this.textBox8);
            this.Arith.Controls.Add(this.textBox7);
            this.Arith.Controls.Add(this.label3);
            this.Arith.Controls.Add(this.label2);
            this.Arith.Controls.Add(this.button1);
            this.Arith.Controls.Add(this.ArithValidation);
            this.Arith.Controls.Add(this.textBox3);
            this.Arith.Controls.Add(this.label1);
            this.Arith.Controls.Add(this.comboBox1);
            this.Arith.Controls.Add(this.textBox2);
            this.Arith.Controls.Add(this.textBox1);
            this.Arith.Location = new System.Drawing.Point(4, 24);
            this.Arith.Name = "Arith";
            this.Arith.Padding = new System.Windows.Forms.Padding(3);
            this.Arith.Size = new System.Drawing.Size(792, 422);
            this.Arith.TabIndex = 0;
            this.Arith.Text = "Arith";
            this.Arith.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(132, 187);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(475, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Effectuer";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // ArithValidation
            // 
            this.ArithValidation.AutoSize = true;
            this.ArithValidation.Location = new System.Drawing.Point(338, 143);
            this.ArithValidation.Name = "ArithValidation";
            this.ArithValidation.Size = new System.Drawing.Size(15, 14);
            this.ArithValidation.TabIndex = 5;
            this.ArithValidation.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(132, 225);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(475, 123);
            this.textBox3.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(132, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Voulez vous sauvegarder le resusltat?";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "+",
            "-",
            "*",
            "/"});
            this.comboBox1.Location = new System.Drawing.Point(300, 86);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 23);
            this.comboBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(494, 73);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(171, 23);
            this.textBox2.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(105, 73);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(171, 23);
            this.textBox1.TabIndex = 0;
            // 
            // Compa
            // 
            this.Compa.Controls.Add(this.textBox4);
            this.Compa.Controls.Add(this.textBox5);
            this.Compa.Controls.Add(this.textBox6);
            this.Compa.Controls.Add(this.textBox11);
            this.Compa.Controls.Add(this.label4);
            this.Compa.Controls.Add(this.label5);
            this.Compa.Controls.Add(this.button2);
            this.Compa.Controls.Add(this.checkBox1);
            this.Compa.Controls.Add(this.textBox12);
            this.Compa.Controls.Add(this.label6);
            this.Compa.Controls.Add(this.comboBox2);
            this.Compa.Controls.Add(this.textBox13);
            this.Compa.Controls.Add(this.textBox14);
            this.Compa.Location = new System.Drawing.Point(4, 24);
            this.Compa.Name = "Compa";
            this.Compa.Padding = new System.Windows.Forms.Padding(3);
            this.Compa.Size = new System.Drawing.Size(792, 422);
            this.Compa.TabIndex = 1;
            this.Compa.Text = "Compa";
            this.Compa.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(161, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Fraction 1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(555, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "Fraction 2";
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(105, 102);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(171, 23);
            this.textBox7.TabIndex = 9;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(494, 102);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(171, 23);
            this.textBox8.TabIndex = 10;
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(57, 86);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(42, 23);
            this.textBox9.TabIndex = 11;
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(446, 86);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(42, 23);
            this.textBox10.TabIndex = 12;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(450, 96);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(42, 23);
            this.textBox4.TabIndex = 25;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(61, 96);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(42, 23);
            this.textBox5.TabIndex = 24;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(498, 112);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(171, 23);
            this.textBox6.TabIndex = 23;
            // 
            // textBox11
            // 
            this.textBox11.Location = new System.Drawing.Point(109, 112);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(171, 23);
            this.textBox11.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(559, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 15);
            this.label4.TabIndex = 21;
            this.label4.Text = "Fraction 2";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(165, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 15);
            this.label5.TabIndex = 20;
            this.label5.Text = "Fraction 1";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(140, 197);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(475, 23);
            this.button2.TabIndex = 19;
            this.button2.Text = "Effectuer";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(346, 153);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(15, 14);
            this.checkBox1.TabIndex = 18;
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // textBox12
            // 
            this.textBox12.Location = new System.Drawing.Point(140, 235);
            this.textBox12.Multiline = true;
            this.textBox12.Name = "textBox12";
            this.textBox12.ReadOnly = true;
            this.textBox12.Size = new System.Drawing.Size(475, 123);
            this.textBox12.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(140, 152);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(200, 15);
            this.label6.TabIndex = 16;
            this.label6.Text = "Voulez vous sauvegarder le resusltat?";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "<",
            "<=",
            ">",
            ">=",
            "=="});
            this.comboBox2.Location = new System.Drawing.Point(304, 96);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 23);
            this.comboBox2.TabIndex = 15;
            // 
            // textBox13
            // 
            this.textBox13.Location = new System.Drawing.Point(498, 83);
            this.textBox13.Name = "textBox13";
            this.textBox13.Size = new System.Drawing.Size(171, 23);
            this.textBox13.TabIndex = 14;
            // 
            // textBox14
            // 
            this.textBox14.Location = new System.Drawing.Point(109, 83);
            this.textBox14.Name = "textBox14";
            this.textBox14.Size = new System.Drawing.Size(171, 23);
            this.textBox14.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Fraction";
            this.tabControl1.ResumeLayout(false);
            this.Arith.ResumeLayout(false);
            this.Arith.PerformLayout();
            this.Compa.ResumeLayout(false);
            this.Compa.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Arith;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox ArithValidation;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TabPage Compa;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.TextBox textBox13;
        private System.Windows.Forms.TextBox textBox14;
    }
}

