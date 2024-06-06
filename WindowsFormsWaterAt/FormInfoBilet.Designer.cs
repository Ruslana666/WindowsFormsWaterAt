namespace WindowsFormsWaterAt
{
    partial class FormInfoBilet
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
            this.label1 = new System.Windows.Forms.Label();
            this.labelId = new System.Windows.Forms.Label();
            this.checkListServices = new System.Windows.Forms.CheckedListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.labelSum = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.labelDate = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "Уникальный идентификатор";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelId
            // 
            this.labelId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelId.Location = new System.Drawing.Point(12, 35);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(200, 23);
            this.labelId.TabIndex = 4;
            this.labelId.Text = "123";
            this.labelId.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // checkListServices
            // 
            this.checkListServices.Enabled = false;
            this.checkListServices.FormattingEnabled = true;
            this.checkListServices.Items.AddRange(new object[] {
            "Тут все услуги"});
            this.checkListServices.Location = new System.Drawing.Point(15, 84);
            this.checkListServices.Name = "checkListServices";
            this.checkListServices.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.checkListServices.Size = new System.Drawing.Size(197, 94);
            this.checkListServices.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(12, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(200, 23);
            this.label3.TabIndex = 6;
            this.label3.Text = "Список услуг";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelSum
            // 
            this.labelSum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSum.Location = new System.Drawing.Point(12, 256);
            this.labelSum.Name = "labelSum";
            this.labelSum.Size = new System.Drawing.Size(200, 23);
            this.labelSum.TabIndex = 8;
            this.labelSum.Text = "500 руб.";
            this.labelSum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(12, 230);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(200, 23);
            this.label5.TabIndex = 7;
            this.label5.Text = "Итоговая стоимость";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(15, 282);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(197, 23);
            this.btnBack.TabIndex = 9;
            this.btnBack.Text = "Вернуться";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // labelDate
            // 
            this.labelDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDate.Location = new System.Drawing.Point(15, 207);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(197, 23);
            this.labelDate.TabIndex = 11;
            this.labelDate.Text = "datetime";
            this.labelDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(15, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(197, 23);
            this.label4.TabIndex = 10;
            this.label4.Text = "Дата покупки";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormInfoBilet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(226, 314);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.labelSum);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.checkListServices);
            this.Controls.Add(this.labelId);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FormInfoBilet";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Электронный билет";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelId;
        private System.Windows.Forms.CheckedListBox checkListServices;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelSum;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.Label label4;
    }
}