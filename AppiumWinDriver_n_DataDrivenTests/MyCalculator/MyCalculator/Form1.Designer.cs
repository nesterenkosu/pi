namespace MyCalculator
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
            this.tb_a = new System.Windows.Forms.TextBox();
            this.tb_b = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Go = new System.Windows.Forms.Button();
            this.lb_Result = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tb_a
            // 
            this.tb_a.Location = new System.Drawing.Point(95, 42);
            this.tb_a.Name = "tb_a";
            this.tb_a.Size = new System.Drawing.Size(103, 22);
            this.tb_a.TabIndex = 0;
            // 
            // tb_b
            // 
            this.tb_b.Location = new System.Drawing.Point(283, 42);
            this.tb_b.Name = "tb_b";
            this.tb_b.Size = new System.Drawing.Size(103, 22);
            this.tb_b.TabIndex = 0;
            this.tb_b.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(231, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(12, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "/";
            // 
            // btn_Go
            // 
            this.btn_Go.Location = new System.Drawing.Point(419, 42);
            this.btn_Go.Name = "btn_Go";
            this.btn_Go.Size = new System.Drawing.Size(75, 23);
            this.btn_Go.TabIndex = 2;
            this.btn_Go.Text = "=";
            this.btn_Go.UseVisualStyleBackColor = true;
            this.btn_Go.Click += new System.EventHandler(this.btn_Go_Click);
            // 
            // lb_Result
            // 
            this.lb_Result.AutoSize = true;
            this.lb_Result.Location = new System.Drawing.Point(537, 45);
            this.lb_Result.Name = "lb_Result";
            this.lb_Result.Size = new System.Drawing.Size(16, 17);
            this.lb_Result.TabIndex = 1;
            this.lb_Result.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 119);
            this.Controls.Add(this.btn_Go);
            this.Controls.Add(this.lb_Result);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_b);
            this.Controls.Add(this.tb_a);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_a;
        private System.Windows.Forms.TextBox tb_b;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Go;
        private System.Windows.Forms.Label lb_Result;
    }
}

