
namespace КалькуляторWINFORMS
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.Label_1 = new System.Windows.Forms.Label();
            this.boxlabel1 = new System.Windows.Forms.TextBox();
            this.Label_2 = new System.Windows.Forms.Label();
            this.boxlabel2 = new System.Windows.Forms.TextBox();
            this.Label_3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnschot = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.boxresult = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Label_1
            // 
            this.Label_1.AutoSize = true;
            this.Label_1.Location = new System.Drawing.Point(76, 33);
            this.Label_1.Name = "Label_1";
            this.Label_1.Size = new System.Drawing.Size(128, 13);
            this.Label_1.TabIndex = 0;
            this.Label_1.Text = "Выберете первое число";
            // 
            // boxlabel1
            // 
            this.boxlabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.boxlabel1.Location = new System.Drawing.Point(79, 62);
            this.boxlabel1.Name = "boxlabel1";
            this.boxlabel1.Size = new System.Drawing.Size(125, 26);
            this.boxlabel1.TabIndex = 1;
            this.boxlabel1.TextChanged += new System.EventHandler(this.boxlabel1_TextChanged);
            // 
            // Label_2
            // 
            this.Label_2.AutoSize = true;
            this.Label_2.Location = new System.Drawing.Point(277, 33);
            this.Label_2.Name = "Label_2";
            this.Label_2.Size = new System.Drawing.Size(127, 13);
            this.Label_2.TabIndex = 2;
            this.Label_2.Text = "Выберете второе число";
            // 
            // boxlabel2
            // 
            this.boxlabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.boxlabel2.Location = new System.Drawing.Point(280, 62);
            this.boxlabel2.Name = "boxlabel2";
            this.boxlabel2.Size = new System.Drawing.Size(124, 26);
            this.boxlabel2.TabIndex = 3;
            this.boxlabel2.TextChanged += new System.EventHandler(this.boxlabel2_TextChanged);
            // 
            // Label_3
            // 
            this.Label_3.AutoSize = true;
            this.Label_3.Location = new System.Drawing.Point(142, 121);
            this.Label_3.Name = "Label_3";
            this.Label_3.Size = new System.Drawing.Size(200, 13);
            this.Label_3.TabIndex = 4;
            this.Label_3.Text = "Выберите арифметическую операцию";
            // 
            // comboBox1
            // 
            this.comboBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "+Сложение",
            "-Вычитание",
            "*Умножение",
            "/Деление"});
            this.comboBox1.Location = new System.Drawing.Point(145, 160);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(197, 28);
            this.comboBox1.TabIndex = 5;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // btnschot
            // 
            this.btnschot.BackColor = System.Drawing.Color.Yellow;
            this.btnschot.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnschot.Location = new System.Drawing.Point(79, 232);
            this.btnschot.Name = "btnschot";
            this.btnschot.Size = new System.Drawing.Size(125, 50);
            this.btnschot.TabIndex = 6;
            this.btnschot.Text = "Посчитать";
            this.btnschot.UseVisualStyleBackColor = false;
            this.btnschot.Click += new System.EventHandler(this.btnschot_Click);
            // 
            // btnclear
            // 
            this.btnclear.BackColor = System.Drawing.Color.Yellow;
            this.btnclear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnclear.Location = new System.Drawing.Point(280, 232);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(125, 50);
            this.btnclear.TabIndex = 7;
            this.btnclear.Text = "Очистить";
            this.btnclear.UseVisualStyleBackColor = false;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // boxresult
            // 
            this.boxresult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.boxresult.Location = new System.Drawing.Point(79, 348);
            this.boxresult.Name = "boxresult";
            this.boxresult.Size = new System.Drawing.Size(325, 26);
            this.boxresult.TabIndex = 8;
            this.boxresult.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(183, 320);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Результат операции!\r\n";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(482, 386);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.boxresult);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.btnschot);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.Label_3);
            this.Controls.Add(this.boxlabel2);
            this.Controls.Add(this.Label_2);
            this.Controls.Add(this.boxlabel1);
            this.Controls.Add(this.Label_1);
            this.Name = "Form1";
            this.Text = "Калькулятор!";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Label_1;
        private System.Windows.Forms.TextBox boxlabel1;
        private System.Windows.Forms.Label Label_2;
        private System.Windows.Forms.TextBox boxlabel2;
        private System.Windows.Forms.Label Label_3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnschot;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.TextBox boxresult;
        private System.Windows.Forms.Label label1;
    }
}

