namespace _5
{
    partial class BinTree
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
            this.OpenBtnB = new System.Windows.Forms.Button();
            this.InputB = new System.Windows.Forms.TextBox();
            this.FiltrBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.OpenBtnA = new System.Windows.Forms.Button();
            this.OutputC = new System.Windows.Forms.TextBox();
            this.InputA = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // OpenBtnB
            // 
            this.OpenBtnB.Location = new System.Drawing.Point(410, 12);
            this.OpenBtnB.Name = "OpenBtnB";
            this.OpenBtnB.Size = new System.Drawing.Size(119, 30);
            this.OpenBtnB.TabIndex = 17;
            this.OpenBtnB.Text = "открыть файл";
            this.OpenBtnB.UseVisualStyleBackColor = true;
            this.OpenBtnB.Click += new System.EventHandler(this.OpenBtn_Click);
            // 
            // InputB
            // 
            this.InputB.Location = new System.Drawing.Point(410, 48);
            this.InputB.Multiline = true;
            this.InputB.Name = "InputB";
            this.InputB.Size = new System.Drawing.Size(392, 420);
            this.InputB.TabIndex = 16;
            // 
            // FiltrBtn
            // 
            this.FiltrBtn.Location = new System.Drawing.Point(808, 12);
            this.FiltrBtn.Name = "FiltrBtn";
            this.FiltrBtn.Size = new System.Drawing.Size(101, 30);
            this.FiltrBtn.TabIndex = 15;
            this.FiltrBtn.Text = "Выборка";
            this.FiltrBtn.UseVisualStyleBackColor = true;
            this.FiltrBtn.Click += new System.EventHandler(this.FiltrBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(166, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 17);
            this.label1.TabIndex = 13;
            this.label1.Text = "Текст A";
            // 
            // SaveBtn
            // 
            this.SaveBtn.Enabled = false;
            this.SaveBtn.Location = new System.Drawing.Point(1078, 12);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(124, 30);
            this.SaveBtn.TabIndex = 12;
            this.SaveBtn.Text = "сохранить файл";
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // OpenBtnA
            // 
            this.OpenBtnA.Location = new System.Drawing.Point(12, 12);
            this.OpenBtnA.Name = "OpenBtnA";
            this.OpenBtnA.Size = new System.Drawing.Size(119, 30);
            this.OpenBtnA.TabIndex = 11;
            this.OpenBtnA.Text = "открыть файл";
            this.OpenBtnA.UseVisualStyleBackColor = true;
            this.OpenBtnA.Click += new System.EventHandler(this.OpenBtn_Click);
            // 
            // OutputC
            // 
            this.OutputC.Location = new System.Drawing.Point(808, 48);
            this.OutputC.Multiline = true;
            this.OutputC.Name = "OutputC";
            this.OutputC.ReadOnly = true;
            this.OutputC.Size = new System.Drawing.Size(392, 420);
            this.OutputC.TabIndex = 10;
            // 
            // InputA
            // 
            this.InputA.Location = new System.Drawing.Point(12, 48);
            this.InputA.Multiline = true;
            this.InputA.Name = "InputA";
            this.InputA.Size = new System.Drawing.Size(392, 420);
            this.InputA.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(959, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 17);
            this.label2.TabIndex = 18;
            this.label2.Text = "Текст C";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(579, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 17);
            this.label3.TabIndex = 19;
            this.label3.Text = "Текст B";
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "Input.txt";
            this.openFileDialog.Filter = "Текстовый документ (*.txt)|*.txt|все файлы|*.*";
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.Filter = "Текстовый документ (*.txt)|*.txt|все файлы|*.*";
            // 
            // BinTree
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1217, 481);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.OpenBtnB);
            this.Controls.Add(this.InputB);
            this.Controls.Add(this.FiltrBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.OpenBtnA);
            this.Controls.Add(this.OutputC);
            this.Controls.Add(this.InputA);
            this.Name = "BinTree";
            this.Text = "BinTree";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button OpenBtnB;
        private System.Windows.Forms.TextBox InputB;
        private System.Windows.Forms.Button FiltrBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.Button OpenBtnA;
        private System.Windows.Forms.TextBox OutputC;
        private System.Windows.Forms.TextBox InputA;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
    }
}

