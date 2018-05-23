namespace _3._1
{
    partial class Queue
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
            this.WorkBtn = new System.Windows.Forms.Button();
            this.SaveOutputBtn = new System.Windows.Forms.Button();
            this.Output = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Input = new System.Windows.Forms.TextBox();
            this.OpenInputBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.label3 = new System.Windows.Forms.Label();
            this.GetD = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.GetD)).BeginInit();
            this.SuspendLayout();
            // 
            // WorkBtn
            // 
            this.WorkBtn.Location = new System.Drawing.Point(578, 13);
            this.WorkBtn.Name = "WorkBtn";
            this.WorkBtn.Size = new System.Drawing.Size(201, 32);
            this.WorkBtn.TabIndex = 18;
            this.WorkBtn.Text = "удалить элементы ";
            this.WorkBtn.UseVisualStyleBackColor = true;
            this.WorkBtn.Click += new System.EventHandler(this.WorkBtn_Click);
            // 
            // SaveOutputBtn
            // 
            this.SaveOutputBtn.Enabled = false;
            this.SaveOutputBtn.Location = new System.Drawing.Point(138, 129);
            this.SaveOutputBtn.Name = "SaveOutputBtn";
            this.SaveOutputBtn.Size = new System.Drawing.Size(90, 32);
            this.SaveOutputBtn.TabIndex = 16;
            this.SaveOutputBtn.Text = "сохранить";
            this.SaveOutputBtn.UseVisualStyleBackColor = true;
            this.SaveOutputBtn.Click += new System.EventHandler(this.SaveOutputBtn_Click);
            // 
            // Output
            // 
            this.Output.Location = new System.Drawing.Point(12, 176);
            this.Output.Multiline = true;
            this.Output.Name = "Output";
            this.Output.ReadOnly = true;
            this.Output.Size = new System.Drawing.Size(767, 80);
            this.Output.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "выходной список";
            // 
            // Input
            // 
            this.Input.Location = new System.Drawing.Point(12, 60);
            this.Input.Multiline = true;
            this.Input.Name = "Input";
            this.Input.Size = new System.Drawing.Size(767, 63);
            this.Input.TabIndex = 12;
            // 
            // OpenInputBtn
            // 
            this.OpenInputBtn.Location = new System.Drawing.Point(138, 13);
            this.OpenInputBtn.Name = "OpenInputBtn";
            this.OpenInputBtn.Size = new System.Drawing.Size(90, 32);
            this.OpenInputBtn.TabIndex = 11;
            this.OpenInputBtn.Text = "открыть ";
            this.OpenInputBtn.UseVisualStyleBackColor = true;
            this.OpenInputBtn.Click += new System.EventHandler(this.OpenInputBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "входной список";
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "Input";
            this.openFileDialog.Filter = "Текстовый документ (*.txt)|*.txt|Все файлы|*.*";
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.FileName = "Output";
            this.saveFileDialog.Filter = "Текстовый документ (*.txt)|*.txt|Все файлы|*.*";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(330, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 17);
            this.label3.TabIndex = 19;
            this.label3.Text = "D = ";
            // 
            // GetD
            // 
            this.GetD.Location = new System.Drawing.Point(370, 19);
            this.GetD.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.GetD.Minimum = new decimal(new int[] {
            1000000,
            0,
            0,
            -2147483648});
            this.GetD.Name = "GetD";
            this.GetD.Size = new System.Drawing.Size(68, 22);
            this.GetD.TabIndex = 20;
            // 
            // Queue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 274);
            this.Controls.Add(this.GetD);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.WorkBtn);
            this.Controls.Add(this.SaveOutputBtn);
            this.Controls.Add(this.Output);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Input);
            this.Controls.Add(this.OpenInputBtn);
            this.Controls.Add(this.label1);
            this.Name = "Queue";
            this.Text = "Queue";
            ((System.ComponentModel.ISupportInitialize)(this.GetD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button WorkBtn;
        private System.Windows.Forms.Button SaveOutputBtn;
        private System.Windows.Forms.TextBox Output;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Input;
        private System.Windows.Forms.Button OpenInputBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown GetD;
    }
}

