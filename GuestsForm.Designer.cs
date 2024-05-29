namespace Graduate_work
{
    partial class GuestsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GuestsForm));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.InfoGuestsTextBox = new System.Windows.Forms.TextBox();
            this.MailGuestsTextBox = new System.Windows.Forms.TextBox();
            this.PhoneGuestsTextBox = new System.Windows.Forms.TextBox();
            this.NameGuestsTextBox = new System.Windows.Forms.TextBox();
            this.InfoGuestsLabel = new System.Windows.Forms.Label();
            this.NameGuestsLabel = new System.Windows.Forms.Label();
            this.MailGuestsLabel = new System.Windows.Forms.Label();
            this.PhoneGuestsLabel = new System.Windows.Forms.Label();
            this.IDGuestsLabel = new System.Windows.Forms.Label();
            this.IDGuestsTextBox = new System.Windows.Forms.TextBox();
            this.NewButton = new System.Windows.Forms.Button();
            this.DelButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.EditButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ClearButton = new System.Windows.Forms.Button();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.SearchTextBox = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(50)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 9);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(844, 587);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(165)))), ((int)(((byte)(38)))));
            this.panel1.Controls.Add(this.InfoGuestsTextBox);
            this.panel1.Controls.Add(this.MailGuestsTextBox);
            this.panel1.Controls.Add(this.PhoneGuestsTextBox);
            this.panel1.Controls.Add(this.NameGuestsTextBox);
            this.panel1.Controls.Add(this.InfoGuestsLabel);
            this.panel1.Controls.Add(this.NameGuestsLabel);
            this.panel1.Controls.Add(this.MailGuestsLabel);
            this.panel1.Controls.Add(this.PhoneGuestsLabel);
            this.panel1.Controls.Add(this.IDGuestsLabel);
            this.panel1.Controls.Add(this.IDGuestsTextBox);
            this.panel1.Location = new System.Drawing.Point(850, 67);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(328, 143);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // InfoGuestsTextBox
            // 
            this.InfoGuestsTextBox.Location = new System.Drawing.Point(130, 114);
            this.InfoGuestsTextBox.Name = "InfoGuestsTextBox";
            this.InfoGuestsTextBox.Size = new System.Drawing.Size(190, 20);
            this.InfoGuestsTextBox.TabIndex = 10;
            // 
            // MailGuestsTextBox
            // 
            this.MailGuestsTextBox.Location = new System.Drawing.Point(130, 88);
            this.MailGuestsTextBox.Name = "MailGuestsTextBox";
            this.MailGuestsTextBox.Size = new System.Drawing.Size(190, 20);
            this.MailGuestsTextBox.TabIndex = 9;
            // 
            // PhoneGuestsTextBox
            // 
            this.PhoneGuestsTextBox.Location = new System.Drawing.Point(130, 62);
            this.PhoneGuestsTextBox.Name = "PhoneGuestsTextBox";
            this.PhoneGuestsTextBox.Size = new System.Drawing.Size(190, 20);
            this.PhoneGuestsTextBox.TabIndex = 8;
            // 
            // NameGuestsTextBox
            // 
            this.NameGuestsTextBox.Location = new System.Drawing.Point(130, 36);
            this.NameGuestsTextBox.Name = "NameGuestsTextBox";
            this.NameGuestsTextBox.Size = new System.Drawing.Size(190, 20);
            this.NameGuestsTextBox.TabIndex = 7;
            // 
            // InfoGuestsLabel
            // 
            this.InfoGuestsLabel.AutoSize = true;
            this.InfoGuestsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.InfoGuestsLabel.Location = new System.Drawing.Point(44, 117);
            this.InfoGuestsLabel.Name = "InfoGuestsLabel";
            this.InfoGuestsLabel.Size = new System.Drawing.Size(87, 13);
            this.InfoGuestsLabel.TabIndex = 6;
            this.InfoGuestsLabel.Text = "Информация:";
            // 
            // NameGuestsLabel
            // 
            this.NameGuestsLabel.AutoSize = true;
            this.NameGuestsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.NameGuestsLabel.Location = new System.Drawing.Point(78, 39);
            this.NameGuestsLabel.Name = "NameGuestsLabel";
            this.NameGuestsLabel.Size = new System.Drawing.Size(53, 13);
            this.NameGuestsLabel.TabIndex = 5;
            this.NameGuestsLabel.Text = "Ф.И.О.:";
            this.NameGuestsLabel.Click += new System.EventHandler(this.label4_Click);
            // 
            // MailGuestsLabel
            // 
            this.MailGuestsLabel.AutoSize = true;
            this.MailGuestsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.MailGuestsLabel.Location = new System.Drawing.Point(6, 91);
            this.MailGuestsLabel.Name = "MailGuestsLabel";
            this.MailGuestsLabel.Size = new System.Drawing.Size(125, 13);
            this.MailGuestsLabel.TabIndex = 4;
            this.MailGuestsLabel.Text = "Электронная почта:";
            // 
            // PhoneGuestsLabel
            // 
            this.PhoneGuestsLabel.AutoSize = true;
            this.PhoneGuestsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.PhoneGuestsLabel.Location = new System.Drawing.Point(20, 65);
            this.PhoneGuestsLabel.Name = "PhoneGuestsLabel";
            this.PhoneGuestsLabel.Size = new System.Drawing.Size(111, 13);
            this.PhoneGuestsLabel.TabIndex = 3;
            this.PhoneGuestsLabel.Text = "Номер телефона:";
            // 
            // IDGuestsLabel
            // 
            this.IDGuestsLabel.AutoSize = true;
            this.IDGuestsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.IDGuestsLabel.Location = new System.Drawing.Point(107, 13);
            this.IDGuestsLabel.Name = "IDGuestsLabel";
            this.IDGuestsLabel.Size = new System.Drawing.Size(24, 13);
            this.IDGuestsLabel.TabIndex = 1;
            this.IDGuestsLabel.Text = "ID:";
            this.IDGuestsLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // IDGuestsTextBox
            // 
            this.IDGuestsTextBox.Location = new System.Drawing.Point(130, 10);
            this.IDGuestsTextBox.Name = "IDGuestsTextBox";
            this.IDGuestsTextBox.Size = new System.Drawing.Size(190, 20);
            this.IDGuestsTextBox.TabIndex = 0;
            // 
            // NewButton
            // 
            this.NewButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(165)))), ((int)(((byte)(38)))));
            this.NewButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NewButton.Font = new System.Drawing.Font("Impact", 17F);
            this.NewButton.ForeColor = System.Drawing.Color.White;
            this.NewButton.Location = new System.Drawing.Point(850, 216);
            this.NewButton.Name = "NewButton";
            this.NewButton.Size = new System.Drawing.Size(328, 52);
            this.NewButton.TabIndex = 2;
            this.NewButton.Text = "Новая запись";
            this.NewButton.UseVisualStyleBackColor = false;
            this.NewButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // DelButton
            // 
            this.DelButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(165)))), ((int)(((byte)(38)))));
            this.DelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DelButton.Font = new System.Drawing.Font("Impact", 17F);
            this.DelButton.ForeColor = System.Drawing.Color.White;
            this.DelButton.Location = new System.Drawing.Point(850, 332);
            this.DelButton.Name = "DelButton";
            this.DelButton.Size = new System.Drawing.Size(328, 52);
            this.DelButton.TabIndex = 6;
            this.DelButton.Text = "Удалить";
            this.DelButton.UseVisualStyleBackColor = false;
            this.DelButton.Click += new System.EventHandler(this.DelButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(165)))), ((int)(((byte)(38)))));
            this.SaveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveButton.Font = new System.Drawing.Font("Impact", 17F);
            this.SaveButton.ForeColor = System.Drawing.Color.White;
            this.SaveButton.Location = new System.Drawing.Point(850, 390);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(328, 52);
            this.SaveButton.TabIndex = 7;
            this.SaveButton.Text = "Сохранить";
            this.SaveButton.UseVisualStyleBackColor = false;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // EditButton
            // 
            this.EditButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(165)))), ((int)(((byte)(38)))));
            this.EditButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditButton.Font = new System.Drawing.Font("Impact", 17F);
            this.EditButton.ForeColor = System.Drawing.Color.White;
            this.EditButton.Location = new System.Drawing.Point(850, 274);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(328, 52);
            this.EditButton.TabIndex = 8;
            this.EditButton.Text = "Изменить";
            this.EditButton.UseVisualStyleBackColor = false;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(165)))), ((int)(((byte)(38)))));
            this.panel2.Controls.Add(this.ClearButton);
            this.panel2.Controls.Add(this.UpdateButton);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.SearchTextBox);
            this.panel2.Location = new System.Drawing.Point(850, 9);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(328, 52);
            this.panel2.TabIndex = 9;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // ClearButton
            // 
            this.ClearButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(165)))), ((int)(((byte)(38)))));
            this.ClearButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ClearButton.BackgroundImage")));
            this.ClearButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClearButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClearButton.Font = new System.Drawing.Font("Impact", 17F);
            this.ClearButton.ForeColor = System.Drawing.Color.White;
            this.ClearButton.Location = new System.Drawing.Point(9, 9);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(33, 33);
            this.ClearButton.TabIndex = 12;
            this.ClearButton.UseVisualStyleBackColor = false;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // UpdateButton
            // 
            this.UpdateButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(165)))), ((int)(((byte)(38)))));
            this.UpdateButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("UpdateButton.BackgroundImage")));
            this.UpdateButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.UpdateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UpdateButton.Font = new System.Drawing.Font("Impact", 17F);
            this.UpdateButton.ForeColor = System.Drawing.Color.White;
            this.UpdateButton.Location = new System.Drawing.Point(48, 9);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(33, 33);
            this.UpdateButton.TabIndex = 10;
            this.UpdateButton.UseVisualStyleBackColor = false;
            this.UpdateButton.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel3.BackgroundImage")));
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel3.Location = new System.Drawing.Point(91, 9);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(33, 33);
            this.panel3.TabIndex = 12;
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.Location = new System.Drawing.Point(130, 9);
            this.SearchTextBox.Multiline = true;
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.Size = new System.Drawing.Size(190, 33);
            this.SearchTextBox.TabIndex = 11;
            this.SearchTextBox.TextChanged += new System.EventHandler(this.SearchTextBox_TextChanged);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(165)))), ((int)(((byte)(38)))));
            this.panel4.Location = new System.Drawing.Point(850, 448);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(328, 148);
            this.panel4.TabIndex = 11;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // GuestsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1185, 605);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.DelButton);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.NewButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GuestsForm";
            this.Text = "GuestsForm";
            this.Load += new System.EventHandler(this.GuestsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button NewButton;
        private System.Windows.Forms.Label IDGuestsLabel;
        private System.Windows.Forms.TextBox IDGuestsTextBox;
        private System.Windows.Forms.Label NameGuestsLabel;
        private System.Windows.Forms.Label MailGuestsLabel;
        private System.Windows.Forms.Label PhoneGuestsLabel;
        private System.Windows.Forms.TextBox InfoGuestsTextBox;
        private System.Windows.Forms.TextBox MailGuestsTextBox;
        private System.Windows.Forms.TextBox PhoneGuestsTextBox;
        private System.Windows.Forms.TextBox NameGuestsTextBox;
        private System.Windows.Forms.Label InfoGuestsLabel;
        private System.Windows.Forms.Button DelButton;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox SearchTextBox;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button ClearButton;
    }
}