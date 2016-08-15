namespace Equipment {
    partial class Form1 {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent() {
            this.LBEquipments = new System.Windows.Forms.ListBox();
            this.AddNewItemButton = new System.Windows.Forms.Button();
            this.EditMainButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.detailsButton = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.FileStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddEquipmentTool = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.информацияОПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.FileNotExisTB = new System.Windows.Forms.TextBox();
            this.MainPB = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Main_lbl_Date = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.Main_lbl_Resp = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.Main_lbl_WorkSh = new System.Windows.Forms.Label();
            this.Main_lbl_Inventory = new System.Windows.Forms.Label();
            this.Main_lbl_ID = new System.Windows.Forms.Label();
            this.WorkSh = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.delEqbutton = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MainPB)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // LBEquipments
            // 
            this.LBEquipments.FormattingEnabled = true;
            this.LBEquipments.Location = new System.Drawing.Point(12, 68);
            this.LBEquipments.Name = "LBEquipments";
            this.LBEquipments.Size = new System.Drawing.Size(189, 173);
            this.LBEquipments.TabIndex = 0;
            this.LBEquipments.SelectedIndexChanged += new System.EventHandler(this.LBEquipments_SelectedIndexChanged);
            // 
            // AddNewItemButton
            // 
            this.AddNewItemButton.Location = new System.Drawing.Point(12, 250);
            this.AddNewItemButton.Name = "AddNewItemButton";
            this.AddNewItemButton.Size = new System.Drawing.Size(65, 23);
            this.AddNewItemButton.TabIndex = 1;
            this.AddNewItemButton.Text = "Добавить";
            this.AddNewItemButton.UseVisualStyleBackColor = true;
            this.AddNewItemButton.Click += new System.EventHandler(this.AddNewItemButton_Click);
            // 
            // EditMainButton
            // 
            this.EditMainButton.Location = new System.Drawing.Point(83, 250);
            this.EditMainButton.Name = "EditMainButton";
            this.EditMainButton.Size = new System.Drawing.Size(37, 23);
            this.EditMainButton.TabIndex = 2;
            this.EditMainButton.Text = "Ред.";
            this.EditMainButton.UseVisualStyleBackColor = true;
            this.EditMainButton.Click += new System.EventHandler(this.EditMainButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(9, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ремонтные работы:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 311);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(386, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Общая стоимость ремонтных работ всего оборудования:";
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.AutoSize = true;
            this.lblTotalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTotalPrice.Location = new System.Drawing.Point(393, 311);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(64, 17);
            this.lblTotalPrice.TabIndex = 6;
            this.lblTotalPrice.Text = "1200000";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(466, 311);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "грн.";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(9, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(204, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Наименование оборудования";
            // 
            // detailsButton
            // 
            this.detailsButton.Location = new System.Drawing.Point(229, 16);
            this.detailsButton.Name = "detailsButton";
            this.detailsButton.Size = new System.Drawing.Size(90, 23);
            this.detailsButton.TabIndex = 9;
            this.detailsButton.Text = "Детальнее...";
            this.detailsButton.UseVisualStyleBackColor = true;
            this.detailsButton.Click += new System.EventHandler(this.detailsButton_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileStripMenuItem,
            this.справкаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(544, 24);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // FileStripMenuItem
            // 
            this.FileStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddEquipmentTool,
            this.ExitToolStripMenuItem});
            this.FileStripMenuItem.Name = "FileStripMenuItem";
            this.FileStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.FileStripMenuItem.Text = "Файл";
            // 
            // AddEquipmentTool
            // 
            this.AddEquipmentTool.Name = "AddEquipmentTool";
            this.AddEquipmentTool.Size = new System.Drawing.Size(217, 22);
            this.AddEquipmentTool.Text = "Добавить оборудование...";
            this.AddEquipmentTool.Click += new System.EventHandler(this.AddEquipmentTool_Click);
            // 
            // ExitToolStripMenuItem
            // 
            this.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
            this.ExitToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
            this.ExitToolStripMenuItem.Text = "Выход";
            this.ExitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.информацияОПрограммеToolStripMenuItem});
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.справкаToolStripMenuItem.Text = "Справка";
            // 
            // информацияОПрограммеToolStripMenuItem
            // 
            this.информацияОПрограммеToolStripMenuItem.Name = "информацияОПрограммеToolStripMenuItem";
            this.информацияОПрограммеToolStripMenuItem.Size = new System.Drawing.Size(233, 22);
            this.информацияОПрограммеToolStripMenuItem.Text = "Информация о программе...";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.groupBox1.Controls.Add(this.FileNotExisTB);
            this.groupBox1.Controls.Add(this.MainPB);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(203, 68);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(330, 172);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Информация";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // FileNotExisTB
            // 
            this.FileNotExisTB.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.FileNotExisTB.Location = new System.Drawing.Point(215, 53);
            this.FileNotExisTB.Multiline = true;
            this.FileNotExisTB.Name = "FileNotExisTB";
            this.FileNotExisTB.Size = new System.Drawing.Size(84, 76);
            this.FileNotExisTB.TabIndex = 2;
            this.FileNotExisTB.Text = "Файл не загружен, либо был перемещён";
            // 
            // MainPB
            // 
            this.MainPB.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.MainPB.Location = new System.Drawing.Point(193, 32);
            this.MainPB.Name = "MainPB";
            this.MainPB.Size = new System.Drawing.Size(126, 115);
            this.MainPB.TabIndex = 1;
            this.MainPB.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel1.Controls.Add(this.Main_lbl_Date);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.Main_lbl_Resp);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.Main_lbl_WorkSh);
            this.panel1.Controls.Add(this.Main_lbl_Inventory);
            this.panel1.Controls.Add(this.Main_lbl_ID);
            this.panel1.Controls.Add(this.WorkSh);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Location = new System.Drawing.Point(6, 22);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(181, 144);
            this.panel1.TabIndex = 0;
            // 
            // Main_lbl_Date
            // 
            this.Main_lbl_Date.AutoSize = true;
            this.Main_lbl_Date.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Main_lbl_Date.Location = new System.Drawing.Point(60, 117);
            this.Main_lbl_Date.Name = "Main_lbl_Date";
            this.Main_lbl_Date.Size = new System.Drawing.Size(23, 17);
            this.Main_lbl_Date.TabIndex = 18;
            this.Main_lbl_Date.Text = "---";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label14.Location = new System.Drawing.Point(3, 117);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(51, 17);
            this.label14.TabIndex = 17;
            this.label14.Text = "Дата:";
            // 
            // Main_lbl_Resp
            // 
            this.Main_lbl_Resp.AutoSize = true;
            this.Main_lbl_Resp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Main_lbl_Resp.Location = new System.Drawing.Point(50, 90);
            this.Main_lbl_Resp.Name = "Main_lbl_Resp";
            this.Main_lbl_Resp.Size = new System.Drawing.Size(18, 17);
            this.Main_lbl_Resp.TabIndex = 16;
            this.Main_lbl_Resp.Text = "--";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(3, 90);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(46, 17);
            this.label12.TabIndex = 15;
            this.label12.Text = "Отв.:";
            // 
            // Main_lbl_WorkSh
            // 
            this.Main_lbl_WorkSh.AutoSize = true;
            this.Main_lbl_WorkSh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Main_lbl_WorkSh.Location = new System.Drawing.Point(50, 63);
            this.Main_lbl_WorkSh.Name = "Main_lbl_WorkSh";
            this.Main_lbl_WorkSh.Size = new System.Drawing.Size(23, 17);
            this.Main_lbl_WorkSh.TabIndex = 14;
            this.Main_lbl_WorkSh.Text = "---";
            // 
            // Main_lbl_Inventory
            // 
            this.Main_lbl_Inventory.AutoSize = true;
            this.Main_lbl_Inventory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Main_lbl_Inventory.Location = new System.Drawing.Point(70, 37);
            this.Main_lbl_Inventory.Name = "Main_lbl_Inventory";
            this.Main_lbl_Inventory.Size = new System.Drawing.Size(23, 17);
            this.Main_lbl_Inventory.TabIndex = 13;
            this.Main_lbl_Inventory.Text = "---";
            // 
            // Main_lbl_ID
            // 
            this.Main_lbl_ID.AutoSize = true;
            this.Main_lbl_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Main_lbl_ID.Location = new System.Drawing.Point(40, 10);
            this.Main_lbl_ID.Name = "Main_lbl_ID";
            this.Main_lbl_ID.Size = new System.Drawing.Size(23, 17);
            this.Main_lbl_ID.TabIndex = 12;
            this.Main_lbl_ID.Text = "---";
            // 
            // WorkSh
            // 
            this.WorkSh.AutoSize = true;
            this.WorkSh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.WorkSh.Location = new System.Drawing.Point(3, 63);
            this.WorkSh.Name = "WorkSh";
            this.WorkSh.Size = new System.Drawing.Size(41, 17);
            this.WorkSh.TabIndex = 2;
            this.WorkSh.Text = "Цех:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(3, 37);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 17);
            this.label7.TabIndex = 1;
            this.label7.Text = "№ Инв.";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(3, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "ID:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.detailsButton);
            this.groupBox2.Location = new System.Drawing.Point(203, 240);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(330, 45);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            // 
            // delEqbutton
            // 
            this.delEqbutton.Location = new System.Drawing.Point(126, 250);
            this.delEqbutton.Name = "delEqbutton";
            this.delEqbutton.Size = new System.Drawing.Size(75, 23);
            this.delEqbutton.TabIndex = 13;
            this.delEqbutton.Text = "Удалить";
            this.delEqbutton.UseVisualStyleBackColor = true;
            this.delEqbutton.Click += new System.EventHandler(this.delEqbutton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 354);
            this.Controls.Add(this.delEqbutton);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblTotalPrice);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.EditMainButton);
            this.Controls.Add(this.AddNewItemButton);
            this.Controls.Add(this.LBEquipments);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Equipment Main";
            this.Activated += new System.EventHandler(this.Form1_Activated);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MainPB)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox LBEquipments;
        private System.Windows.Forms.Button AddNewItemButton;
        private System.Windows.Forms.Button EditMainButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblTotalPrice;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button detailsButton;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem FileStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AddEquipmentTool;
        private System.Windows.Forms.ToolStripMenuItem ExitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem информацияОПрограммеToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox MainPB;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label WorkSh;
        private System.Windows.Forms.Label Main_lbl_WorkSh;
        private System.Windows.Forms.Label Main_lbl_Inventory;
        private System.Windows.Forms.Label Main_lbl_ID;
        private System.Windows.Forms.Label Main_lbl_Resp;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label Main_lbl_Date;
        private System.Windows.Forms.TextBox FileNotExisTB;
        private System.Windows.Forms.Button delEqbutton;
    }
}

