namespace WindowsFormsWaterAt
{
    partial class FormBilet
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
            this.checkListServices = new System.Windows.Forms.CheckedListBox();
            this.btnBuy = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.labelFio = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.mTextDate = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.mTextCVV = new System.Windows.Forms.MaskedTextBox();
            this.mTextCard1 = new System.Windows.Forms.MaskedTextBox();
            this.mTextCard2 = new System.Windows.Forms.MaskedTextBox();
            this.mTextCard3 = new System.Windows.Forms.MaskedTextBox();
            this.mTextCard4 = new System.Windows.Forms.MaskedTextBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.labelSum = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // checkListServices
            // 
            this.checkListServices.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.checkListServices.FormattingEnabled = true;
            this.checkListServices.Items.AddRange(new object[] {
            "ну тут он выберет",
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.checkListServices.Location = new System.Drawing.Point(12, 42);
            this.checkListServices.Name = "checkListServices";
            this.checkListServices.Size = new System.Drawing.Size(192, 199);
            this.checkListServices.TabIndex = 0;
            this.checkListServices.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.checkListServices_ItemCheck);
            // 
            // btnBuy
            // 
            this.btnBuy.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBuy.Location = new System.Drawing.Point(210, 187);
            this.btnBuy.Name = "btnBuy";
            this.btnBuy.Size = new System.Drawing.Size(312, 23);
            this.btnBuy.TabIndex = 1;
            this.btnBuy.Text = "Купить";
            this.btnBuy.UseVisualStyleBackColor = true;
            this.btnBuy.Click += new System.EventHandler(this.btnBuy_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Location = new System.Drawing.Point(210, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(312, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Билет покупает";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelFio
            // 
            this.labelFio.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelFio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelFio.Location = new System.Drawing.Point(210, 35);
            this.labelFio.Name = "labelFio";
            this.labelFio.Size = new System.Drawing.Size(312, 23);
            this.labelFio.TabIndex = 3;
            this.labelFio.Text = "тут фио";
            this.labelFio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.Location = new System.Drawing.Point(210, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(312, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "Укажите данные карты";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mTextDate
            // 
            this.mTextDate.Location = new System.Drawing.Point(297, 155);
            this.mTextDate.Mask = "00\\/00";
            this.mTextDate.Name = "mTextDate";
            this.mTextDate.Size = new System.Drawing.Size(70, 20);
            this.mTextDate.TabIndex = 9;
            this.mTextDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mTextDate.ValidatingType = typeof(System.DateTime);
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(221, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 23);
            this.label4.TabIndex = 10;
            this.label4.Text = "Годен до";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(373, 153);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 23);
            this.label5.TabIndex = 12;
            this.label5.Text = "CVV";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mTextCVV
            // 
            this.mTextCVV.Location = new System.Drawing.Point(449, 156);
            this.mTextCVV.Mask = "000";
            this.mTextCVV.Name = "mTextCVV";
            this.mTextCVV.PasswordChar = '*';
            this.mTextCVV.Size = new System.Drawing.Size(70, 20);
            this.mTextCVV.TabIndex = 11;
            this.mTextCVV.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // mTextCard1
            // 
            this.mTextCard1.Location = new System.Drawing.Point(224, 130);
            this.mTextCard1.Mask = "0000";
            this.mTextCard1.Name = "mTextCard1";
            this.mTextCard1.Size = new System.Drawing.Size(67, 20);
            this.mTextCard1.TabIndex = 13;
            this.mTextCard1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // mTextCard2
            // 
            this.mTextCard2.Location = new System.Drawing.Point(297, 130);
            this.mTextCard2.Mask = "0000";
            this.mTextCard2.Name = "mTextCard2";
            this.mTextCard2.Size = new System.Drawing.Size(70, 20);
            this.mTextCard2.TabIndex = 14;
            this.mTextCard2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // mTextCard3
            // 
            this.mTextCard3.Location = new System.Drawing.Point(376, 130);
            this.mTextCard3.Mask = "0000";
            this.mTextCard3.Name = "mTextCard3";
            this.mTextCard3.Size = new System.Drawing.Size(67, 20);
            this.mTextCard3.TabIndex = 15;
            this.mTextCard3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // mTextCard4
            // 
            this.mTextCard4.Location = new System.Drawing.Point(449, 130);
            this.mTextCard4.Mask = "0000";
            this.mTextCard4.Name = "mTextCard4";
            this.mTextCard4.Size = new System.Drawing.Size(70, 20);
            this.mTextCard4.TabIndex = 16;
            this.mTextCard4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnBack
            // 
            this.btnBack.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBack.Location = new System.Drawing.Point(210, 216);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(312, 23);
            this.btnBack.TabIndex = 17;
            this.btnBack.Text = "Выход";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.Location = new System.Drawing.Point(210, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(312, 23);
            this.label2.TabIndex = 18;
            this.label2.Text = "Стоимость составляет";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelSum
            // 
            this.labelSum.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelSum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSum.Location = new System.Drawing.Point(210, 81);
            this.labelSum.Name = "labelSum";
            this.labelSum.Size = new System.Drawing.Size(312, 23);
            this.labelSum.TabIndex = 19;
            this.labelSum.Text = "500 руб.";
            this.labelSum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.Location = new System.Drawing.Point(12, 12);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(192, 23);
            this.label7.TabIndex = 20;
            this.label7.Text = "Услуги";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormBilet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 251);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.labelSum);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.mTextCard4);
            this.Controls.Add(this.mTextCard3);
            this.Controls.Add(this.mTextCard2);
            this.Controls.Add(this.mTextCard1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.mTextCVV);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.mTextDate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelFio);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBuy);
            this.Controls.Add(this.checkListServices);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FormBilet";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Покупка билета";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox checkListServices;
        private System.Windows.Forms.Button btnBuy;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelFio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox mTextDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox mTextCVV;
        private System.Windows.Forms.MaskedTextBox mTextCard1;
        private System.Windows.Forms.MaskedTextBox mTextCard2;
        private System.Windows.Forms.MaskedTextBox mTextCard3;
        private System.Windows.Forms.MaskedTextBox mTextCard4;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelSum;
        private System.Windows.Forms.Label label7;
    }
}