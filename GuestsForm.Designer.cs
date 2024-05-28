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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.IDGuestsTextBox = new System.Windows.Forms.TextBox();
            this.IDGuestsLabel = new System.Windows.Forms.Label();
            this.NewButton = new System.Windows.Forms.Button();
            this.PhoneGuestsLabel = new System.Windows.Forms.Label();
            this.MailGuestsLabel = new System.Windows.Forms.Label();
            this.NameGuestsLabel = new System.Windows.Forms.Label();
            this.InfoGuestsLabel = new System.Windows.Forms.Label();
            this.NameGuestsTextBox = new System.Windows.Forms.TextBox();
            this.PhoneGuestsTextBox = new System.Windows.Forms.TextBox();
            this.MailGuestsTextBox = new System.Windows.Forms.TextBox();
            this.InfoGuestsTextBox = new System.Windows.Forms.TextBox();
            this.DelButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.EditButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(477, 459);
            this.dataGridView1.TabIndex = 0;
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
            this.panel1.Location = new System.Drawing.Point(495, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(275, 147);
            this.panel1.TabIndex = 1;
            // 
            // IDGuestsTextBox
            // 
            this.IDGuestsTextBox.Location = new System.Drawing.Point(132, 10);
            this.IDGuestsTextBox.Name = "IDGuestsTextBox";
            this.IDGuestsTextBox.Size = new System.Drawing.Size(134, 20);
            this.IDGuestsTextBox.TabIndex = 0;
            // 
            // IDGuestsLabel
            // 
            this.IDGuestsLabel.AutoSize = true;
            this.IDGuestsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.IDGuestsLabel.Location = new System.Drawing.Point(108, 13);
            this.IDGuestsLabel.Name = "IDGuestsLabel";
            this.IDGuestsLabel.Size = new System.Drawing.Size(24, 13);
            this.IDGuestsLabel.TabIndex = 1;
            this.IDGuestsLabel.Text = "ID:";
            this.IDGuestsLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // NewButton
            // 
            this.NewButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(165)))), ((int)(((byte)(38)))));
            this.NewButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NewButton.Font = new System.Drawing.Font("Impact", 17F);
            this.NewButton.ForeColor = System.Drawing.Color.White;
            this.NewButton.Location = new System.Drawing.Point(495, 165);
            this.NewButton.Name = "NewButton";
            this.NewButton.Size = new System.Drawing.Size(275, 52);
            this.NewButton.TabIndex = 2;
            this.NewButton.Text = "Новая запись";
            this.NewButton.UseVisualStyleBackColor = false;
            this.NewButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // PhoneGuestsLabel
            // 
            this.PhoneGuestsLabel.AutoSize = true;
            this.PhoneGuestsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.PhoneGuestsLabel.Location = new System.Drawing.Point(21, 65);
            this.PhoneGuestsLabel.Name = "PhoneGuestsLabel";
            this.PhoneGuestsLabel.Size = new System.Drawing.Size(111, 13);
            this.PhoneGuestsLabel.TabIndex = 3;
            this.PhoneGuestsLabel.Text = "Номер телефона:";
            // 
            // MailGuestsLabel
            // 
            this.MailGuestsLabel.AutoSize = true;
            this.MailGuestsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.MailGuestsLabel.Location = new System.Drawing.Point(7, 94);
            this.MailGuestsLabel.Name = "MailGuestsLabel";
            this.MailGuestsLabel.Size = new System.Drawing.Size(125, 13);
            this.MailGuestsLabel.TabIndex = 4;
            this.MailGuestsLabel.Text = "Электронная почта:";
            // 
            // NameGuestsLabel
            // 
            this.NameGuestsLabel.AutoSize = true;
            this.NameGuestsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.NameGuestsLabel.Location = new System.Drawing.Point(79, 39);
            this.NameGuestsLabel.Name = "NameGuestsLabel";
            this.NameGuestsLabel.Size = new System.Drawing.Size(53, 13);
            this.NameGuestsLabel.TabIndex = 5;
            this.NameGuestsLabel.Text = "Ф.И.О.:";
            this.NameGuestsLabel.Click += new System.EventHandler(this.label4_Click);
            // 
            // InfoGuestsLabel
            // 
            this.InfoGuestsLabel.AutoSize = true;
            this.InfoGuestsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.InfoGuestsLabel.Location = new System.Drawing.Point(45, 120);
            this.InfoGuestsLabel.Name = "InfoGuestsLabel";
            this.InfoGuestsLabel.Size = new System.Drawing.Size(87, 13);
            this.InfoGuestsLabel.TabIndex = 6;
            this.InfoGuestsLabel.Text = "Информация:";
            // 
            // NameGuestsTextBox
            // 
            this.NameGuestsTextBox.Location = new System.Drawing.Point(132, 36);
            this.NameGuestsTextBox.Name = "NameGuestsTextBox";
            this.NameGuestsTextBox.Size = new System.Drawing.Size(134, 20);
            this.NameGuestsTextBox.TabIndex = 7;
            // 
            // PhoneGuestsTextBox
            // 
            this.PhoneGuestsTextBox.Location = new System.Drawing.Point(132, 62);
            this.PhoneGuestsTextBox.Name = "PhoneGuestsTextBox";
            this.PhoneGuestsTextBox.Size = new System.Drawing.Size(134, 20);
            this.PhoneGuestsTextBox.TabIndex = 8;
            // 
            // MailGuestsTextBox
            // 
            this.MailGuestsTextBox.Location = new System.Drawing.Point(132, 91);
            this.MailGuestsTextBox.Name = "MailGuestsTextBox";
            this.MailGuestsTextBox.Size = new System.Drawing.Size(134, 20);
            this.MailGuestsTextBox.TabIndex = 9;
            // 
            // InfoGuestsTextBox
            // 
            this.InfoGuestsTextBox.Location = new System.Drawing.Point(132, 117);
            this.InfoGuestsTextBox.Name = "InfoGuestsTextBox";
            this.InfoGuestsTextBox.Size = new System.Drawing.Size(134, 20);
            this.InfoGuestsTextBox.TabIndex = 10;
            // 
            // DelButton
            // 
            this.DelButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(165)))), ((int)(((byte)(38)))));
            this.DelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DelButton.Font = new System.Drawing.Font("Impact", 17F);
            this.DelButton.ForeColor = System.Drawing.Color.White;
            this.DelButton.Location = new System.Drawing.Point(633, 222);
            this.DelButton.Name = "DelButton";
            this.DelButton.Size = new System.Drawing.Size(137, 52);
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
            this.SaveButton.Location = new System.Drawing.Point(495, 280);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(275, 52);
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
            this.EditButton.Location = new System.Drawing.Point(495, 222);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(137, 52);
            this.EditButton.TabIndex = 8;
            this.EditButton.Text = "Изменить";
            this.EditButton.UseVisualStyleBackColor = false;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(165)))), ((int)(((byte)(38)))));
            this.panel2.Location = new System.Drawing.Point(495, 338);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(275, 133);
            this.panel2.TabIndex = 9;
            // 
            // GuestsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 483);
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
    }
}