namespace Lab_1
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.DBConnectionClock = new System.Windows.Forms.ToolStripMenuItem();
            this.DisconnectFromDB = new System.Windows.Forms.ToolStripMenuItem();
            this.ConnectionsList = new System.Windows.Forms.ToolStripMenuItem();
            this.Label1 = new System.Windows.Forms.Button();
            this.label23 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.button1 = new System.Windows.Forms.Button();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button4 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DBConnectionClock,
            this.DisconnectFromDB,
            this.ConnectionsList});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // DBConnectionClock
            // 
            this.DBConnectionClock.Name = "DBConnectionClock";
            this.DBConnectionClock.Size = new System.Drawing.Size(96, 20);
            this.DBConnectionClock.Text = "Connect to DB";
            this.DBConnectionClock.Click += new System.EventHandler(this.DBConnectionClock_Click);
            // 
            // DisconnectFromDB
            // 
            this.DisconnectFromDB.Name = "DisconnectFromDB";
            this.DisconnectFromDB.Size = new System.Drawing.Size(125, 20);
            this.DisconnectFromDB.Text = "Disconnect from DB";
            this.DisconnectFromDB.Click += new System.EventHandler(this.DisconnectFromDB_Click);
            // 
            // ConnectionsList
            // 
            this.ConnectionsList.Name = "ConnectionsList";
            this.ConnectionsList.Size = new System.Drawing.Size(104, 20);
            this.ConnectionsList.Text = "ConnectionsList";
            this.ConnectionsList.Click += new System.EventHandler(this.ConnectionsList_Click);
            // 
            // Label1
            // 
            this.Label1.Location = new System.Drawing.Point(12, 38);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(135, 23);
            this.Label1.TabIndex = 1;
            this.Label1.Text = "Сколько Продуктов";
            this.Label1.UseVisualStyleBackColor = true;
            this.Label1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(178, 43);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(107, 13);
            this.label23.TabIndex = 2;
            this.label23.Text = "Сколько Продуктов";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 142);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(180, 170);
            this.listView1.TabIndex = 3;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 113);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Список продуктов";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Название продукта";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(472, 157);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(87, 23);
            this.button4.TabIndex = 5;
            this.button4.Text = "Транзакция";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem DBConnectionClock;
        private System.Windows.Forms.ToolStripMenuItem DisconnectFromDB;
        private System.Windows.Forms.ToolStripMenuItem ConnectionsList;
        private System.Windows.Forms.Button Label1;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button4;
    }
}

