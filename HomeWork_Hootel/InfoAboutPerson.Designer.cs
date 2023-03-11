namespace HomeWork_Hotel
{
    partial class InfoAboutPerson
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
            this.InfoName = new System.Windows.Forms.Label();
            this.Info_bday = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Info_days = new System.Windows.Forms.Label();
            this.payment = new System.Windows.Forms.Label();
            this.Info_payment = new System.Windows.Forms.Label();
            this.Info_pets = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Gainsboro;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("XO Courser", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.SlateBlue;
            this.label1.Location = new System.Drawing.Point(30, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(328, 43);
            this.label1.TabIndex = 0;
            this.label1.Text = "Карточка гостя";
            // 
            // InfoName
            // 
            this.InfoName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.InfoName.AutoSize = true;
            this.InfoName.BackColor = System.Drawing.Color.Gainsboro;
            this.InfoName.Font = new System.Drawing.Font("XO Courser", 10.125F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic)
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.InfoName.ForeColor = System.Drawing.Color.Black;
            this.InfoName.Location = new System.Drawing.Point(321, 35);
            this.InfoName.Name = "InfoName";
            this.InfoName.Size = new System.Drawing.Size(334, 31);
            this.InfoName.TabIndex = 20;
            this.InfoName.Text = "Иванов Иван Иванович";
            // 
            // Info_bday
            // 
            this.Info_bday.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Info_bday.AutoSize = true;
            this.Info_bday.BackColor = System.Drawing.Color.Gainsboro;
            this.Info_bday.Font = new System.Drawing.Font("XO Courser", 10.125F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic)
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.Info_bday.ForeColor = System.Drawing.Color.Black;
            this.Info_bday.Location = new System.Drawing.Point(481, 124);
            this.Info_bday.Name = "Info_bday";
            this.Info_bday.Size = new System.Drawing.Size(174, 31);
            this.Info_bday.TabIndex = 21;
            this.Info_bday.Text = "24.08.2000";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Gainsboro;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Font = new System.Drawing.Font("XO Courser", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.SlateBlue;
            this.label3.Location = new System.Drawing.Point(10, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(264, 38);
            this.label3.TabIndex = 22;
            this.label3.Text = "Дата рождения";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Gainsboro;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Font = new System.Drawing.Font("XO Courser", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.SlateBlue;
            this.label4.Location = new System.Drawing.Point(10, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 38);
            this.label4.TabIndex = 23;
            this.label4.Text = "ФИО";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Gainsboro;
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.InfoName);
            this.groupBox2.Controls.Add(this.Info_bday);
            this.groupBox2.Location = new System.Drawing.Point(30, 101);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(669, 261);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            // 
            // splitter1
            // 
            this.splitter1.BackColor = System.Drawing.Color.Gainsboro;
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(6, 988);
            this.splitter1.TabIndex = 32;
            this.splitter1.TabStop = false;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("XO Courser", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(484, 901);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 27);
            this.label2.TabIndex = 51;
            this.label2.Text = "С животными";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.Control;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Font = new System.Drawing.Font("XO Courser", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.SlateBlue;
            this.label5.Location = new System.Drawing.Point(44, 525);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(272, 35);
            this.label5.TabIndex = 52;
            this.label5.Text = "Количество дней";
            // 
            // Info_days
            // 
            this.Info_days.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Info_days.AutoSize = true;
            this.Info_days.Font = new System.Drawing.Font("XO Courser", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.Info_days.Location = new System.Drawing.Point(649, 522);
            this.Info_days.Name = "Info_days";
            this.Info_days.Size = new System.Drawing.Size(36, 37);
            this.Info_days.TabIndex = 53;
            this.Info_days.Text = "0";
            // 
            // payment
            // 
            this.payment.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)));
            this.payment.AutoSize = true;
            this.payment.BackColor = System.Drawing.SystemColors.Control;
            this.payment.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.payment.Font = new System.Drawing.Font("XO Courser", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.payment.ForeColor = System.Drawing.Color.SlateBlue;
            this.payment.Location = new System.Drawing.Point(44, 417);
            this.payment.Name = "payment";
            this.payment.Size = new System.Drawing.Size(131, 38);
            this.payment.TabIndex = 24;
            this.payment.Text = "Оплата";
            // 
            // Info_payment
            // 
            this.Info_payment.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Info_payment.AutoSize = true;
            this.Info_payment.BackColor = System.Drawing.SystemColors.Control;
            this.Info_payment.Font = new System.Drawing.Font("XO Courser", 10.875F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic)
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.Info_payment.ForeColor = System.Drawing.Color.Black;
            this.Info_payment.Location = new System.Drawing.Point(589, 424);
            this.Info_payment.Name = "Info_payment";
            this.Info_payment.Size = new System.Drawing.Size(100, 33);
            this.Info_payment.TabIndex = 54;
            this.Info_payment.Text = "10000";
            // 
            // Info_pets
            // 
            this.Info_pets.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Info_pets.AutoSize = true;
            this.Info_pets.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Info_pets.Font = new System.Drawing.Font("XO Courser", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Info_pets.ForeColor = System.Drawing.Color.SlateBlue;
            this.Info_pets.Location = new System.Drawing.Point(661, 899);
            this.Info_pets.Name = "Info_pets";
            this.Info_pets.Size = new System.Drawing.Size(28, 29);
            this.Info_pets.TabIndex = 55;
            this.Info_pets.Text = "-";
            // 
            // InfoAboutPerson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(724, 988);
            this.Controls.Add(this.Info_pets);
            this.Controls.Add(this.Info_payment);
            this.Controls.Add(this.payment);
            this.Controls.Add(this.Info_days);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label1);
            this.MinimumSize = new System.Drawing.Size(750, 1059);
            this.Name = "InfoAboutPerson";
            this.Text = "О госте";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label InfoName;
        private Label Info_bday;
        private Label label3;
        private Label label4;
        private GroupBox groupBox2;
        private Splitter splitter1;
        private Label label2;
        private Label label5;
        private Label Info_days;
        private Label payment;
        private Label Info_payment;
        private Label Info_pets;
    }
}