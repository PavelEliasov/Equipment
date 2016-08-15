namespace Equipment {
    partial class Form3 {
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
            this.LBRepairs = new System.Windows.Forms.ListBox();
            this.TBDetails = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.addNewRepairsButton = new System.Windows.Forms.Button();
            this.EditRepairsButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.Price = new System.Windows.Forms.Label();
            this.TotalPrice = new System.Windows.Forms.Label();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.RepDate = new System.Windows.Forms.Label();
            this.lblRepDate = new System.Windows.Forms.Label();
            this.delRepairsbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LBRepairs
            // 
            this.LBRepairs.FormattingEnabled = true;
            this.LBRepairs.Location = new System.Drawing.Point(12, 36);
            this.LBRepairs.Name = "LBRepairs";
            this.LBRepairs.Size = new System.Drawing.Size(206, 160);
            this.LBRepairs.TabIndex = 0;
            this.LBRepairs.SelectedIndexChanged += new System.EventHandler(this.LBRepairs_SelectedIndexChanged);
            this.LBRepairs.Leave += new System.EventHandler(this.LBRepairs_Leave);
            // 
            // TBDetails
            // 
            this.TBDetails.Location = new System.Drawing.Point(227, 36);
            this.TBDetails.Multiline = true;
            this.TBDetails.Name = "TBDetails";
            this.TBDetails.ReadOnly = true;
            this.TBDetails.Size = new System.Drawing.Size(392, 113);
            this.TBDetails.TabIndex = 1;
            this.TBDetails.Text = "----";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Проделанные работы";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(224, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Детальное описание";
            // 
            // addNewRepairsButton
            // 
            this.addNewRepairsButton.Location = new System.Drawing.Point(12, 202);
            this.addNewRepairsButton.Name = "addNewRepairsButton";
            this.addNewRepairsButton.Size = new System.Drawing.Size(75, 23);
            this.addNewRepairsButton.TabIndex = 4;
            this.addNewRepairsButton.Text = "Добавить";
            this.addNewRepairsButton.UseVisualStyleBackColor = true;
            this.addNewRepairsButton.Click += new System.EventHandler(this.addNewRepairsButton_Click);
            // 
            // EditRepairsButton
            // 
            this.EditRepairsButton.Location = new System.Drawing.Point(93, 202);
            this.EditRepairsButton.Name = "EditRepairsButton";
            this.EditRepairsButton.Size = new System.Drawing.Size(45, 23);
            this.EditRepairsButton.TabIndex = 5;
            this.EditRepairsButton.Text = "Ред.";
            this.EditRepairsButton.UseVisualStyleBackColor = true;
            this.EditRepairsButton.Click += new System.EventHandler(this.EdirRepairsButton_Click);
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(544, 202);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(75, 23);
            this.backButton.TabIndex = 6;
            this.backButton.Text = "Назад";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.button3_Click);
            // 
            // Price
            // 
            this.Price.AutoSize = true;
            this.Price.Location = new System.Drawing.Point(224, 183);
            this.Price.Name = "Price";
            this.Price.Size = new System.Drawing.Size(97, 13);
            this.Price.TabIndex = 7;
            this.Price.Text = "Стоимость работ:";
            // 
            // TotalPrice
            // 
            this.TotalPrice.AutoSize = true;
            this.TotalPrice.Location = new System.Drawing.Point(224, 207);
            this.TotalPrice.Name = "TotalPrice";
            this.TotalPrice.Size = new System.Drawing.Size(123, 13);
            this.TotalPrice.TabIndex = 8;
            this.TotalPrice.Text = "Стоимость всех работ:";
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.AutoSize = true;
            this.lblTotalPrice.Location = new System.Drawing.Point(353, 207);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(16, 13);
            this.lblTotalPrice.TabIndex = 9;
            this.lblTotalPrice.Text = "---";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(327, 183);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(16, 13);
            this.lblPrice.TabIndex = 10;
            this.lblPrice.Text = "---";
            // 
            // RepDate
            // 
            this.RepDate.AutoSize = true;
            this.RepDate.Location = new System.Drawing.Point(224, 152);
            this.RepDate.Name = "RepDate";
            this.RepDate.Size = new System.Drawing.Size(121, 13);
            this.RepDate.TabIndex = 11;
            this.RepDate.Text = "Дата окончания работ";
            // 
            // lblRepDate
            // 
            this.lblRepDate.AutoSize = true;
            this.lblRepDate.Location = new System.Drawing.Point(353, 152);
            this.lblRepDate.Name = "lblRepDate";
            this.lblRepDate.Size = new System.Drawing.Size(16, 13);
            this.lblRepDate.TabIndex = 12;
            this.lblRepDate.Text = "---";
            // 
            // delRepairsbutton
            // 
            this.delRepairsbutton.Location = new System.Drawing.Point(144, 202);
            this.delRepairsbutton.Name = "delRepairsbutton";
            this.delRepairsbutton.Size = new System.Drawing.Size(75, 23);
            this.delRepairsbutton.TabIndex = 13;
            this.delRepairsbutton.Text = "Удалить";
            this.delRepairsbutton.UseVisualStyleBackColor = true;
            this.delRepairsbutton.Click += new System.EventHandler(this.delRepairsbutton_Click);
            // 
            // Form3
            // 
            this.ClientSize = new System.Drawing.Size(631, 242);
            this.Controls.Add(this.delRepairsbutton);
            this.Controls.Add(this.lblRepDate);
            this.Controls.Add(this.RepDate);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblTotalPrice);
            this.Controls.Add(this.TotalPrice);
            this.Controls.Add(this.Price);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.EditRepairsButton);
            this.Controls.Add(this.addNewRepairsButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TBDetails);
            this.Controls.Add(this.LBRepairs);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Activated += new System.EventHandler(this.Form3_Activated);
            this.Shown += new System.EventHandler(this.Form3_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox LBRepairs;
        private System.Windows.Forms.TextBox TBDetails;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button addNewRepairsButton;
        private System.Windows.Forms.Button EditRepairsButton;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Label Price;
        private System.Windows.Forms.Label TotalPrice;
        private System.Windows.Forms.Label lblTotalPrice;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label RepDate;
        private System.Windows.Forms.Label lblRepDate;
        private System.Windows.Forms.Button delRepairsbutton;
    }
}