namespace Equipment {
    partial class Form2 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.AddCansel = new System.Windows.Forms.Button();
            this.TBNameOfNewEq = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TBInvNum = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.addImageButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.TBWorkShop = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.TBResposible = new System.Windows.Forms.TextBox();
            this.AddNewEquipment = new System.Windows.Forms.Button();
            this.NewImagePB = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NewImagePB)).BeginInit();
            this.SuspendLayout();
            // 
            // AddCansel
            // 
            this.AddCansel.Location = new System.Drawing.Point(86, 190);
            this.AddCansel.Name = "AddCansel";
            this.AddCansel.Size = new System.Drawing.Size(75, 23);
            this.AddCansel.TabIndex = 0;
            this.AddCansel.Text = "Отмена";
            this.AddCansel.UseVisualStyleBackColor = true;
            this.AddCansel.Click += new System.EventHandler(this.button1_Click);
            // 
            // TBNameOfNewEq
            // 
            this.TBNameOfNewEq.Location = new System.Drawing.Point(5, 31);
            this.TBNameOfNewEq.Multiline = true;
            this.TBNameOfNewEq.Name = "TBNameOfNewEq";
            this.TBNameOfNewEq.Size = new System.Drawing.Size(135, 126);
            this.TBNameOfNewEq.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(2, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Название оборудования";
            // 
            // TBInvNum
            // 
            this.TBInvNum.Location = new System.Drawing.Point(193, 31);
            this.TBInvNum.Name = "TBInvNum";
            this.TBInvNum.Size = new System.Drawing.Size(62, 20);
            this.TBInvNum.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(146, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "ИНВ№";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(369, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(156, 145);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // addImageButton
            // 
            this.addImageButton.Location = new System.Drawing.Point(369, 190);
            this.addImageButton.Name = "addImageButton";
            this.addImageButton.Size = new System.Drawing.Size(156, 23);
            this.addImageButton.TabIndex = 6;
            this.addImageButton.Text = "Добавить изображение";
            this.addImageButton.UseVisualStyleBackColor = true;
            this.addImageButton.Click += new System.EventHandler(this.addImageButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(143, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Дата регистрации:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(146, 137);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(146, 61);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 17);
            this.label8.TabIndex = 13;
            this.label8.Text = "Цех:";
            // 
            // TBWorkShop
            // 
            this.TBWorkShop.Location = new System.Drawing.Point(193, 58);
            this.TBWorkShop.Name = "TBWorkShop";
            this.TBWorkShop.Size = new System.Drawing.Size(62, 20);
            this.TBWorkShop.TabIndex = 14;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(146, 87);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(46, 17);
            this.label12.TabIndex = 16;
            this.label12.Text = "Отв.:";
            // 
            // TBResposible
            // 
            this.TBResposible.Location = new System.Drawing.Point(193, 84);
            this.TBResposible.Name = "TBResposible";
            this.TBResposible.Size = new System.Drawing.Size(62, 20);
            this.TBResposible.TabIndex = 25;
            // 
            // AddNewEquipment
            // 
            this.AddNewEquipment.Location = new System.Drawing.Point(5, 190);
            this.AddNewEquipment.Name = "AddNewEquipment";
            this.AddNewEquipment.Size = new System.Drawing.Size(75, 23);
            this.AddNewEquipment.TabIndex = 26;
            this.AddNewEquipment.Text = "Добавить";
            this.AddNewEquipment.UseVisualStyleBackColor = true;
            this.AddNewEquipment.Click += new System.EventHandler(this.AddNewEquipment_Click);
            // 
            // NewImagePB
            // 
            this.NewImagePB.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.NewImagePB.Location = new System.Drawing.Point(385, 31);
            this.NewImagePB.Name = "NewImagePB";
            this.NewImagePB.Size = new System.Drawing.Size(126, 115);
            this.NewImagePB.TabIndex = 27;
            this.NewImagePB.TabStop = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 227);
            this.Controls.Add(this.NewImagePB);
            this.Controls.Add(this.AddNewEquipment);
            this.Controls.Add(this.TBResposible);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.TBWorkShop);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.addImageButton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TBInvNum);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TBNameOfNewEq);
            this.Controls.Add(this.AddCansel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New Equipment";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form2_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NewImagePB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddCansel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TBNameOfNewEq;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TBInvNum;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button addImageButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TBWorkShop;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox TBResposible;
        private System.Windows.Forms.Button AddNewEquipment;
        private System.Windows.Forms.PictureBox NewImagePB;
    }
}