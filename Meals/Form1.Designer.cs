﻿namespace Meals
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdBtn2 = new System.Windows.Forms.RadioButton();
            this.rdBtn1 = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.checkBox7 = new System.Windows.Forms.CheckBox();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(132)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(17, 29);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(484, 596);
            this.panel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(225)))), ((int)(((byte)(255)))));
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.groupBox2);
            this.panel2.Location = new System.Drawing.Point(21, 19);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(444, 559);
            this.panel2.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.groupBox1.Controls.Add(this.rdBtn2);
            this.groupBox1.Controls.Add(this.rdBtn1);
            this.groupBox1.Font = new System.Drawing.Font("標楷體", 14F);
            this.groupBox1.Location = new System.Drawing.Point(20, 358);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(272, 125);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "外帶/內用";
            // 
            // rdBtn2
            // 
            this.rdBtn2.AutoSize = true;
            this.rdBtn2.Location = new System.Drawing.Point(13, 81);
            this.rdBtn2.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.rdBtn2.Name = "rdBtn2";
            this.rdBtn2.Size = new System.Drawing.Size(223, 28);
            this.rdBtn2.TabIndex = 1;
            this.rdBtn2.TabStop = true;
            this.rdBtn2.Text = "內用(每人加10元)";
            this.rdBtn2.UseVisualStyleBackColor = true;
            this.rdBtn2.CheckedChanged += new System.EventHandler(this.rdBtn2_CheckedChanged);
            // 
            // rdBtn1
            // 
            this.rdBtn1.AutoSize = true;
            this.rdBtn1.Location = new System.Drawing.Point(13, 39);
            this.rdBtn1.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.rdBtn1.Name = "rdBtn1";
            this.rdBtn1.Size = new System.Drawing.Size(79, 28);
            this.rdBtn1.TabIndex = 0;
            this.rdBtn1.TabStop = true;
            this.rdBtn1.Text = "外帶";
            this.rdBtn1.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label8.Location = new System.Drawing.Point(32, 509);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 24);
            this.label8.TabIndex = 16;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button2.Location = new System.Drawing.Point(304, 434);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(112, 42);
            this.button2.TabIndex = 1;
            this.button2.Text = "取消";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button1.Location = new System.Drawing.Point(304, 368);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 42);
            this.button1.TabIndex = 0;
            this.button1.Text = "結帳";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.groupBox2.Controls.Add(this.checkBox1);
            this.groupBox2.Controls.Add(this.textBox5);
            this.groupBox2.Controls.Add(this.textBox4);
            this.groupBox2.Controls.Add(this.checkBox2);
            this.groupBox2.Controls.Add(this.textBox6);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.textBox3);
            this.groupBox2.Controls.Add(this.checkBox3);
            this.groupBox2.Controls.Add(this.textBox7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.textBox2);
            this.groupBox2.Controls.Add(this.checkBox4);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.checkBox5);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.checkBox7);
            this.groupBox2.Controls.Add(this.checkBox6);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Font = new System.Drawing.Font("標楷體", 14F);
            this.groupBox2.Location = new System.Drawing.Point(4, 0);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(436, 341);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.checkBox1.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.checkBox1.Location = new System.Drawing.Point(24, 29);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(4);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(224, 28);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Tag = "";
            this.checkBox1.Text = "泡沫紅茶  [30元]";
            this.checkBox1.UseVisualStyleBackColor = false;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged_1);
            // 
            // textBox5
            // 
            this.textBox5.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBox5.Location = new System.Drawing.Point(292, 200);
            this.textBox5.Margin = new System.Windows.Forms.Padding(4);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(65, 36);
            this.textBox5.TabIndex = 7;
            this.textBox5.Text = "0";
            this.textBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBox5.Click += new System.EventHandler(this.textBox_Click);
            this.textBox5.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBox4.Location = new System.Drawing.Point(292, 156);
            this.textBox4.Margin = new System.Windows.Forms.Padding(4);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(65, 36);
            this.textBox4.TabIndex = 7;
            this.textBox4.Text = "0";
            this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBox4.Click += new System.EventHandler(this.textBox_Click);
            this.textBox4.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.checkBox2.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.checkBox2.Location = new System.Drawing.Point(24, 75);
            this.checkBox2.Margin = new System.Windows.Forms.Padding(4);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(224, 28);
            this.checkBox2.TabIndex = 1;
            this.checkBox2.Text = "珍珠奶茶  [35元]";
            this.checkBox2.UseVisualStyleBackColor = false;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged_1);
            // 
            // textBox6
            // 
            this.textBox6.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBox6.Location = new System.Drawing.Point(292, 242);
            this.textBox6.Margin = new System.Windows.Forms.Padding(4);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(65, 36);
            this.textBox6.TabIndex = 7;
            this.textBox6.Text = "0";
            this.textBox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBox6.Click += new System.EventHandler(this.textBox_Click);
            this.textBox6.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.label7.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label7.Location = new System.Drawing.Point(373, 294);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 24);
            this.label7.TabIndex = 14;
            this.label7.Text = "人";
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBox3.Location = new System.Drawing.Point(292, 112);
            this.textBox3.Margin = new System.Windows.Forms.Padding(4);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(65, 36);
            this.textBox3.TabIndex = 7;
            this.textBox3.Text = "0";
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBox3.Click += new System.EventHandler(this.textBox_Click);
            this.textBox3.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.checkBox3.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.checkBox3.Location = new System.Drawing.Point(24, 119);
            this.checkBox3.Margin = new System.Windows.Forms.Padding(4);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(224, 28);
            this.checkBox3.TabIndex = 2;
            this.checkBox3.Text = "木瓜牛奶  [40元]";
            this.checkBox3.UseVisualStyleBackColor = false;
            this.checkBox3.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged_1);
            // 
            // textBox7
            // 
            this.textBox7.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBox7.Location = new System.Drawing.Point(292, 285);
            this.textBox7.Margin = new System.Windows.Forms.Padding(4);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(65, 36);
            this.textBox7.TabIndex = 7;
            this.textBox7.Text = "0";
            this.textBox7.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBox7.Click += new System.EventHandler(this.textBox_Click);
            this.textBox7.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.label6.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label6.Location = new System.Drawing.Point(373, 251);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 24);
            this.label6.TabIndex = 13;
            this.label6.Text = "份";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBox2.Location = new System.Drawing.Point(292, 70);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(65, 36);
            this.textBox2.TabIndex = 7;
            this.textBox2.Text = "0";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBox2.Click += new System.EventHandler(this.textBox_Click);
            this.textBox2.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.checkBox4.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.checkBox4.Location = new System.Drawing.Point(24, 162);
            this.checkBox4.Margin = new System.Windows.Forms.Padding(4);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(224, 28);
            this.checkBox4.TabIndex = 3;
            this.checkBox4.Text = "柳橙純汁  [40元]";
            this.checkBox4.UseVisualStyleBackColor = false;
            this.checkBox4.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.label1.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(373, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 24);
            this.label1.TabIndex = 8;
            this.label1.Text = "杯";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.label5.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.Location = new System.Drawing.Point(373, 210);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 24);
            this.label5.TabIndex = 12;
            this.label5.Text = "份";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBox1.Location = new System.Drawing.Point(292, 26);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(65, 36);
            this.textBox1.TabIndex = 7;
            this.textBox1.Tag = "";
            this.textBox1.Text = "0";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBox1.Click += new System.EventHandler(this.textBox_Click);
            this.textBox1.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.checkBox5.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.checkBox5.Location = new System.Drawing.Point(24, 206);
            this.checkBox5.Margin = new System.Windows.Forms.Padding(4);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(224, 28);
            this.checkBox5.TabIndex = 4;
            this.checkBox5.Text = "漢堡Ａ餐 [100元]";
            this.checkBox5.UseVisualStyleBackColor = false;
            this.checkBox5.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.label2.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(373, 79);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 24);
            this.label2.TabIndex = 9;
            this.label2.Text = "杯";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.label4.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(373, 162);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 24);
            this.label4.TabIndex = 11;
            this.label4.Text = "杯";
            // 
            // checkBox7
            // 
            this.checkBox7.AutoSize = true;
            this.checkBox7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.checkBox7.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.checkBox7.Location = new System.Drawing.Point(24, 294);
            this.checkBox7.Margin = new System.Windows.Forms.Padding(4);
            this.checkBox7.Name = "checkBox7";
            this.checkBox7.Size = new System.Drawing.Size(224, 28);
            this.checkBox7.TabIndex = 6;
            this.checkBox7.Text = "內用每人 [ 10元]";
            this.checkBox7.UseVisualStyleBackColor = false;
            this.checkBox7.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged_1);
            // 
            // checkBox6
            // 
            this.checkBox6.AutoSize = true;
            this.checkBox6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.checkBox6.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.checkBox6.Location = new System.Drawing.Point(24, 250);
            this.checkBox6.Margin = new System.Windows.Forms.Padding(4);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(224, 28);
            this.checkBox6.TabIndex = 5;
            this.checkBox6.Text = "麥克雞塊 [120元]";
            this.checkBox6.UseVisualStyleBackColor = false;
            this.checkBox6.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.label3.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(373, 122);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 24);
            this.label3.TabIndex = 10;
            this.label3.Text = "杯";
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("標楷體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 23;
            this.listBox1.Location = new System.Drawing.Point(529, 92);
            this.listBox1.Margin = new System.Windows.Forms.Padding(4);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(411, 349);
            this.listBox1.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(953, 652);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.CheckBox checkBox7;
        private System.Windows.Forms.CheckBox checkBox6;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdBtn2;
        private System.Windows.Forms.RadioButton rdBtn1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox listBox1;
    }
}

