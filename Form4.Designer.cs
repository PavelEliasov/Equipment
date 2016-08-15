namespace Equipment {
    partial class NewRepairs {
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
            this.TBNameOfRep = new System.Windows.Forms.TextBox();
            this.TbDeTails = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TBPriceGrn = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.TBPriceCopeck = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TBNameOfRep
            // 
            this.TBNameOfRep.Location = new System.Drawing.Point(12, 30);
            this.TBNameOfRep.Multiline = true;
            this.TBNameOfRep.Name = "TBNameOfRep";
            this.TBNameOfRep.Size = new System.Drawing.Size(403, 31);
            this.TBNameOfRep.TabIndex = 0;
            // 
            // TbDeTails
            // 
            this.TbDeTails.Location = new System.Drawing.Point(12, 86);
            this.TbDeTails.Multiline = true;
            this.TbDeTails.Name = "TbDeTails";
            this.TbDeTails.Size = new System.Drawing.Size(403, 108);
            this.TbDeTails.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Наименование работ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Детальное описание";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 215);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Стоимость работ";
            // 
            // TBPriceGrn
            // 
            this.TBPriceGrn.Location = new System.Drawing.Point(109, 212);
            this.TBPriceGrn.Multiline = true;
            this.TBPriceGrn.Name = "TBPriceGrn";
            this.TBPriceGrn.Size = new System.Drawing.Size(102, 21);
            this.TBPriceGrn.TabIndex = 5;
            this.TBPriceGrn.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TBPriceGrn.TextChanged += new System.EventHandler(this.TBPriceGrn_TextChanged);
            this.TBPriceGrn.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBPriceGrn_KeyPress);
            this.TBPriceGrn.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.TBPriceGrn_PreviewKeyDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(217, 215);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "грн.";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(136, 245);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 245);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Дата окончания работ:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(342, 212);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Отмена";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(342, 245);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 10;
            this.addButton.Text = "Добавить";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // TBPriceCopeck
            // 
            this.TBPriceCopeck.Location = new System.Drawing.Point(250, 212);
            this.TBPriceCopeck.Multiline = true;
            this.TBPriceCopeck.Name = "TBPriceCopeck";
            this.TBPriceCopeck.Size = new System.Drawing.Size(42, 21);
            this.TBPriceCopeck.TabIndex = 11;
            this.TBPriceCopeck.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TBPriceCopeck.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBPriceCopeck_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(298, 215);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "коп.";
            // 
            // NewRepairs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 282);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TBPriceCopeck);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TBPriceGrn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TbDeTails);
            this.Controls.Add(this.TBNameOfRep);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "NewRepairs";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TBNameOfRep;
        private System.Windows.Forms.TextBox TbDeTails;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TBPriceGrn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.TextBox TBPriceCopeck;
        private System.Windows.Forms.Label label6;
    }
}