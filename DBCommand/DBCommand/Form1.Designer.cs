﻿namespace DBCommand
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.sqlConnection1 = new System.Data.SqlClient.SqlConnection();
            this.sqlCommand1 = new System.Data.SqlClient.SqlCommand();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.sqlCommand2 = new System.Data.SqlClient.SqlCommand();
            this.ResultTextBox = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.sqlCommand3 = new System.Data.SqlClient.SqlCommand();
            this.CityTextBox = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.sqlCommand4 = new System.Data.SqlClient.SqlCommand();
            this.button5 = new System.Windows.Forms.Button();
            this.CategoryNameTextBox = new System.Windows.Forms.TextBox();
            this.OrdYearTextBox = new System.Windows.Forms.TextBox();
            this.sqlCommand5 = new System.Data.SqlClient.SqlCommand();
            this.SuspendLayout();
            // 
            // sqlConnection1
            // 
            this.sqlConnection1.ConnectionString = "Data Source=DESKTOP-IHB5LCD\\SQLEXPRESS;Initial Catalog=Northwind;Integrated Secur" +
    "ity=True";
            this.sqlConnection1.FireInfoMessageEventOnUserErrors = false;
            // 
            // sqlCommand1
            // 
            this.sqlCommand1.CommandText = "SELECT CustomerID, CompanyName FROM Customers";
            this.sqlCommand1.Connection = this.sqlConnection1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(28, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Запрос данных";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(156, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(166, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Вызов процедуры";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // sqlCommand2
            // 
            this.sqlCommand2.Connection = this.sqlConnection1;
            // 
            // ResultTextBox
            // 
            this.ResultTextBox.Location = new System.Drawing.Point(409, 109);
            this.ResultTextBox.Name = "ResultTextBox";
            this.ResultTextBox.Size = new System.Drawing.Size(310, 20);
            this.ResultTextBox.TabIndex = 2;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(28, 57);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(173, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "Создание таблицы";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // sqlCommand3
            // 
            this.sqlCommand3.Connection = this.sqlConnection1;
            // 
            // CityTextBox
            // 
            this.CityTextBox.Location = new System.Drawing.Point(28, 109);
            this.CityTextBox.Name = "CityTextBox";
            this.CityTextBox.Size = new System.Drawing.Size(100, 20);
            this.CityTextBox.TabIndex = 4;
            this.CityTextBox.Text = "London";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(173, 109);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(149, 23);
            this.button4.TabIndex = 5;
            this.button4.Text = "Запрос с параметром";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // sqlCommand4
            // 
            this.sqlCommand4.CommandText = "SELECT CustomerID, CompanyName, City FROM Customers WHERE City = @City";
            this.sqlCommand4.Connection = this.sqlConnection1;
            this.sqlCommand4.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@City", System.Data.SqlDbType.NVarChar, 15, "City")});
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(28, 171);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(173, 23);
            this.button5.TabIndex = 6;
            this.button5.Text = "Процедура с параметром";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // CategoryNameTextBox
            // 
            this.CategoryNameTextBox.Location = new System.Drawing.Point(235, 173);
            this.CategoryNameTextBox.Name = "CategoryNameTextBox";
            this.CategoryNameTextBox.Size = new System.Drawing.Size(443, 20);
            this.CategoryNameTextBox.TabIndex = 7;
            this.CategoryNameTextBox.Text = "Beverages";
            // 
            // OrdYearTextBox
            // 
            this.OrdYearTextBox.Location = new System.Drawing.Point(235, 221);
            this.OrdYearTextBox.Name = "OrdYearTextBox";
            this.OrdYearTextBox.Size = new System.Drawing.Size(435, 20);
            this.OrdYearTextBox.TabIndex = 8;
            this.OrdYearTextBox.Text = "1997";
            // 
            // sqlCommand5
            // 
            this.sqlCommand5.CommandText = "SalesByCategory";
            this.sqlCommand5.CommandType = System.Data.CommandType.StoredProcedure;
            this.sqlCommand5.Connection = this.sqlConnection1;
            this.sqlCommand5.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@CategoryName", System.Data.SqlDbType.NVarChar),
            new System.Data.SqlClient.SqlParameter("@OrdYear", System.Data.SqlDbType.NVarChar)});
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.OrdYearTextBox);
            this.Controls.Add(this.CategoryNameTextBox);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.CityTextBox);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.ResultTextBox);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Data.SqlClient.SqlConnection sqlConnection1;
        private System.Data.SqlClient.SqlCommand sqlCommand1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Data.SqlClient.SqlCommand sqlCommand2;
        private System.Windows.Forms.TextBox ResultTextBox;
        private System.Windows.Forms.Button button3;
        private System.Data.SqlClient.SqlCommand sqlCommand3;
        private System.Windows.Forms.TextBox CityTextBox;
        private System.Windows.Forms.Button button4;
        private System.Data.SqlClient.SqlCommand sqlCommand4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox CategoryNameTextBox;
        private System.Windows.Forms.TextBox OrdYearTextBox;
        private System.Data.SqlClient.SqlCommand sqlCommand5;
    }
}

