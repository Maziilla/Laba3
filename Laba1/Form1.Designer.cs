namespace Laba1
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
            this.dataSet1 = new System.Data.DataSet();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.cb_rast = new System.Windows.Forms.ComboBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.l_name = new System.Windows.Forms.Label();
            this.tb_FEr = new System.Windows.Forms.TextBox();
            this.tb_SEr = new System.Windows.Forms.TextBox();
            this.tb_Ri = new System.Windows.Forms.TextBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "NewDataSet";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tb_FEr);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(135, 52);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ошибки первого рода";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tb_Ri);
            this.groupBox2.Location = new System.Drawing.Point(12, 128);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(135, 52);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Верно";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tb_SEr);
            this.groupBox3.Location = new System.Drawing.Point(12, 70);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(135, 52);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Ошибки второго рода";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(204, 86);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Распознать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cb_rast
            // 
            this.cb_rast.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_rast.FormattingEnabled = true;
            this.cb_rast.Items.AddRange(new object[] {
            "Метод удержания",
            "Перекрёстная проверка"});
            this.cb_rast.Location = new System.Drawing.Point(17, 19);
            this.cb_rast.Name = "cb_rast";
            this.cb_rast.Size = new System.Drawing.Size(100, 21);
            this.cb_rast.TabIndex = 4;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.cb_rast);
            this.groupBox4.Location = new System.Drawing.Point(175, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(135, 52);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Количество полосок";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.l_name);
            this.groupBox5.Location = new System.Drawing.Point(175, 128);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(135, 52);
            this.groupBox5.TabIndex = 5;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Ваш образец это";
            // 
            // l_name
            // 
            this.l_name.AutoSize = true;
            this.l_name.Location = new System.Drawing.Point(26, 21);
            this.l_name.Name = "l_name";
            this.l_name.Size = new System.Drawing.Size(0, 13);
            this.l_name.TabIndex = 0;
            // 
            // tb_FEr
            // 
            this.tb_FEr.Location = new System.Drawing.Point(15, 19);
            this.tb_FEr.Name = "tb_FEr";
            this.tb_FEr.Size = new System.Drawing.Size(100, 20);
            this.tb_FEr.TabIndex = 0;
            // 
            // tb_SEr
            // 
            this.tb_SEr.Location = new System.Drawing.Point(15, 19);
            this.tb_SEr.Name = "tb_SEr";
            this.tb_SEr.Size = new System.Drawing.Size(100, 20);
            this.tb_SEr.TabIndex = 1;
            // 
            // tb_Ri
            // 
            this.tb_Ri.Location = new System.Drawing.Point(15, 21);
            this.tb_Ri.Name = "tb_Ri";
            this.tb_Ri.Size = new System.Drawing.Size(100, 20);
            this.tb_Ri.TabIndex = 2;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(12, 199);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(135, 20);
            this.numericUpDown1.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 282);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Распознавание животных";
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Data.DataSet dataSet1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cb_rast;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label l_name;
        private System.Windows.Forms.TextBox tb_FEr;
        private System.Windows.Forms.TextBox tb_Ri;
        private System.Windows.Forms.TextBox tb_SEr;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
    }
}

