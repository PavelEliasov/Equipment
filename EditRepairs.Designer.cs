namespace Equipment {
    partial class EditRepairs {
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
            this.label6 = new System.Windows.Forms.Label();
            this.TBPriceCopeckEdit = new System.Windows.Forms.TextBox();
            this.ApplyButton = new System.Windows.Forms.Button();
            this.canselbutton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.TBPriceGrnEdit = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TbDeTailsEdit = new System.Windows.Forms.TextBox();
            this.TBNameOfRepEdit = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(298, 220);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 13);
            this.label6.TabIndex = 25;
            this.label6.Text = "коп.";
            // 
            // TBPriceCopeckEdit
            // 
            this.TBPriceCopeckEdit.Location = new System.Drawing.Point(250, 217);
            this.TBPriceCopeckEdit.Multiline = true;
            this.TBPriceCopeckEdit.Name = "TBPriceCopeckEdit";
            this.TBPriceCopeckEdit.Size = new System.Drawing.Size(42, 21);
            this.TBPriceCopeckEdit.TabIndex = 24;
            this.TBPriceCopeckEdit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TBPriceCopeckEdit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBPriceCopeckEdit_KeyPress);
            // 
            // ApplyButton
            // 
            this.ApplyButton.Location = new System.Drawing.Point(342, 250);
            this.ApplyButton.Name = "ApplyButton";
            this.ApplyButton.Size = new System.Drawing.Size(75, 23);
            this.ApplyButton.TabIndex = 23;
            this.ApplyButton.Text = "Изменить";
            this.ApplyButton.UseVisualStyleBackColor = true;
            this.ApplyButton.Click += new System.EventHandler(this.ApplyButton_Click);
            // 
            // canselbutton
            // 
            this.canselbutton.Location = new System.Drawing.Point(342, 215);
            this.canselbutton.Name = "canselbutton";
            this.canselbutton.Size = new System.Drawing.Size(75, 23);
            this.canselbutton.TabIndex = 22;
            this.canselbutton.Text = "Отмена";
            this.canselbutton.UseVisualStyleBackColor = true;
            this.canselbutton.Click += new System.EventHandler(this.canselbutton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 250);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Дата окончания работ:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(136, 250);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(217, 220);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "грн.";
            // 
            // TBPriceGrnEdit
            // 
            this.TBPriceGrnEdit.Location = new System.Drawing.Point(109, 217);
            this.TBPriceGrnEdit.Multiline = true;
            this.TBPriceGrnEdit.Name = "TBPriceGrnEdit";
            this.TBPriceGrnEdit.Size = new System.Drawing.Size(102, 21);
            this.TBPriceGrnEdit.TabIndex = 18;
            this.TBPriceGrnEdit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TBPriceGrnEdit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBPriceGrnEdit_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 220);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Стоимость работ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Детальное описание";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Наименование работ";
            // 
            // TbDeTailsEdit
            // 
            this.TbDeTailsEdit.Location = new System.Drawing.Point(12, 91);
            this.TbDeTailsEdit.Multiline = true;
            this.TbDeTailsEdit.Name = "TbDeTailsEdit";
            this.TbDeTailsEdit.Size = new System.Drawing.Size(405, 108);
            this.TbDeTailsEdit.TabIndex = 14;
            // 
            // TBNameOfRepEdit
            // 
            this.TBNameOfRepEdit.Location = new System.Drawing.Point(12, 35);
            this.TBNameOfRepEdit.Multiline = true;
            this.TBNameOfRepEdit.Name = "TBNameOfRepEdit";
            this.TBNameOfRepEdit.Size = new System.Drawing.Size(405, 31);
            this.TBNameOfRepEdit.TabIndex = 13;
            // 
            // EditRepairs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 287);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TBPriceCopeckEdit);
            this.Controls.Add(this.ApplyButton);
            this.Controls.Add(this.canselbutton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TBPriceGrnEdit);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TbDeTailsEdit);
            this.Controls.Add(this.TBNameOfRepEdit);
            this.Name = "EditRepairs";
            this.Text = "EditRepairs";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TBPriceCopeckEdit;
        private System.Windows.Forms.Button ApplyButton;
        private System.Windows.Forms.Button canselbutton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TBPriceGrnEdit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TbDeTailsEdit;
        private System.Windows.Forms.TextBox TBNameOfRepEdit;
    }
}