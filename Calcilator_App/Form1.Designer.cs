namespace Calcilator_App
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxNum1 = new System.Windows.Forms.TextBox();
            this.textBoxNum2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonSum = new System.Windows.Forms.Button();
            this.labelResult = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labelResultInfo = new System.Windows.Forms.Label();
            this.buttonSub = new System.Windows.Forms.Button();
            this.buttonDif = new System.Windows.Forms.Button();
            this.buttonUmn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(107, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Calcilator_App.v1.0";
            // 
            // textBoxNum1
            // 
            this.textBoxNum1.Location = new System.Drawing.Point(110, 49);
            this.textBoxNum1.Name = "textBoxNum1";
            this.textBoxNum1.Size = new System.Drawing.Size(100, 20);
            this.textBoxNum1.TabIndex = 1;
            // 
            // textBoxNum2
            // 
            this.textBoxNum2.Location = new System.Drawing.Point(110, 86);
            this.textBoxNum2.Name = "textBoxNum2";
            this.textBoxNum2.Size = new System.Drawing.Size(100, 20);
            this.textBoxNum2.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Первое число:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Второе число:";
            // 
            // buttonSum
            // 
            this.buttonSum.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSum.Location = new System.Drawing.Point(243, 39);
            this.buttonSum.Name = "buttonSum";
            this.buttonSum.Size = new System.Drawing.Size(54, 44);
            this.buttonSum.TabIndex = 5;
            this.buttonSum.Text = "+";
            this.buttonSum.UseVisualStyleBackColor = true;
            this.buttonSum.Click += new System.EventHandler(this.buttonSum_Click);
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelResult.Location = new System.Drawing.Point(106, 124);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(30, 24);
            this.labelResult.TabIndex = 6;
            this.labelResult.Text = "23";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Результат:";
            // 
            // labelResultInfo
            // 
            this.labelResultInfo.AutoSize = true;
            this.labelResultInfo.Location = new System.Drawing.Point(101, 162);
            this.labelResultInfo.Name = "labelResultInfo";
            this.labelResultInfo.Size = new System.Drawing.Size(49, 13);
            this.labelResultInfo.TabIndex = 8;
            this.labelResultInfo.Text = "1 + 1 = 2";
            // 
            // buttonSub
            // 
            this.buttonSub.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSub.Location = new System.Drawing.Point(310, 39);
            this.buttonSub.Name = "buttonSub";
            this.buttonSub.Size = new System.Drawing.Size(54, 44);
            this.buttonSub.TabIndex = 9;
            this.buttonSub.Text = "-";
            this.buttonSub.UseVisualStyleBackColor = true;
            this.buttonSub.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonDif
            // 
            this.buttonDif.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDif.Location = new System.Drawing.Point(243, 101);
            this.buttonDif.Name = "buttonDif";
            this.buttonDif.Size = new System.Drawing.Size(54, 44);
            this.buttonDif.TabIndex = 10;
            this.buttonDif.Text = "/";
            this.buttonDif.UseVisualStyleBackColor = true;
            this.buttonDif.Click += new System.EventHandler(this.buttonDif_Click);
            // 
            // buttonUmn
            // 
            this.buttonUmn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonUmn.Location = new System.Drawing.Point(310, 101);
            this.buttonUmn.Name = "buttonUmn";
            this.buttonUmn.Size = new System.Drawing.Size(54, 44);
            this.buttonUmn.TabIndex = 11;
            this.buttonUmn.Text = "*";
            this.buttonUmn.UseVisualStyleBackColor = true;
            this.buttonUmn.Click += new System.EventHandler(this.buttonUmn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 201);
            this.Controls.Add(this.buttonUmn);
            this.Controls.Add(this.buttonDif);
            this.Controls.Add(this.buttonSub);
            this.Controls.Add(this.labelResultInfo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.buttonSum);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxNum2);
            this.Controls.Add(this.textBoxNum1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Calcilator_App";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxNum1;
        private System.Windows.Forms.TextBox textBoxNum2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonSum;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelResultInfo;
        private System.Windows.Forms.Button buttonSub;
        private System.Windows.Forms.Button buttonDif;
        private System.Windows.Forms.Button buttonUmn;
    }
}

