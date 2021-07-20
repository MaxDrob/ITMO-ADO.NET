﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Configuration;


namespace Lab_1
{
    public partial class Form1 : Form
    {
        OleDbConnection connection = new OleDbConnection();
        string testConnect = @"Provider=SQLOLEDB.1;
            Integrated Security=SSPI;
            Persist Security Info=False;
            Initial Catalog=Northwind;
            Data Source=DESKTOP-IHB5LCD\SQLEXPRESS";

        public Form1()


        {
            InitializeComponent();
            this.connection.StateChange += new System.Data.StateChangeEventHandler(this.connection_StateChange);

        }
        static string GetConnectionStringByName(string name)
        {

            string returnValue = null;
            ConnectionStringSettings settings = ConfigurationManager.ConnectionStrings[name];

            if (settings != null)
            {
                returnValue = settings.ConnectionString;
            }

            return returnValue;
        }

        //string testConnect = GetConnectionStringByName("DBConnect.NorthwindConnectionString");

        private void connection_StateChange(object sender, System.Data.StateChangeEventArgs e)
        {
            DBConnectionClock.Enabled = (e.CurrentState == ConnectionState.Closed);
            DisconnectFromDB.Enabled = (e.CurrentState == ConnectionState.Open);

        }

        private void DBConnectionClock_Click(object sender, EventArgs e)
        {
            try
            {
                if (connection.State != ConnectionState.Open)
                {
                    connection.ConnectionString = testConnect;
                    connection.Open();
                    MessageBox.Show("Соединение с базой установлено");
                }
                else

                    MessageBox.Show("Соединение с базой данных уже установлено");
            }

            catch (SqlException XcpSQL)
            {
                foreach (SqlError se in XcpSQL.Errors)
                {
                    MessageBox.Show(se.Message,
                    "Источник ошибки: " + se.Source,
                    MessageBoxButtons.OK,
                   MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Unexpected exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void DisconnectFromDB_Click(object sender, EventArgs e)
        {
            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
                MessageBox.Show("Соединение с базой данных закрыто");
            }
            else

                MessageBox.Show("Соединение с базой данных уже закрыто");
        }

        private void ConnectionsList_Click(object sender, EventArgs e)
        {
            ConnectionStringSettingsCollection settings = ConfigurationManager.ConnectionStrings;
            if (settings != null)
            {
                foreach (ConnectionStringSettings cs in settings)
                {
                    MessageBox.Show("Connection name: " + cs.Name);
                    MessageBox.Show("Provider name:" + cs.ProviderName);
                    MessageBox.Show("connection string: " + cs.ConnectionString);
                }
            }
        }
    }
}
