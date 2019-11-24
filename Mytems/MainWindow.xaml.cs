﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Data.OleDb;
using System.Data;



namespace Mytems
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        OleDbConnection con;

        public MainWindow()
        {
       
            InitializeComponent();
            con = new OleDbConnection();
            con.ConnectionString = "Provider=Microsoft.Jet.Oledb.4.0; Data Source=" + AppDomain.CurrentDomain.BaseDirectory + "\\MytemsDB.mdb";
         
        }
        

        private void btnFPass_Click(object sender, RoutedEventArgs e)
        {
            
            
        }

        private void BtnLogin_Click(object sender, RoutedEventArgs e)

        {
            OleDbCommand cmd = new OleDbCommand();
            if (con.State != ConnectionState.Open)
                con.Open();
            cmd.Connection = con;
            string User = this.txtUsarname.Text;
            string Password = this.txtPassword.Text;
            if (User == "" || Password == "")
            {
                MessageBox.Show("Insert User Name and Password");
                this.txtUsarname.Focus();
                return;
            }
            else
            {
                OleDbConnection oleDbConnection = new OleDbConnection();
                if (txtUsarname.Text != "")
                {
                    if (txtUsarname.IsEnabled == true)
                    {
                        cmd.CommandText = "select [id_Usuario], from Register where[Us]= " + this.txtUsarname + "and[Pass]= " + this.txtPassword + "";
                        if (txtPassword != ' [Pass] ')
                        {
                            MessageBox.Show("The Password is incorrect");
                        }
                        else
                        {
                            Home Home = new Home();
                            this.Hide();
                            Home.Show();
                            MessageBox.Show("Welcome Pleyer :D");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Empty field");
                }

            }
        }
        private void BtnRegister_Click(object sender, RoutedEventArgs e)
        {
            Register Regiswindow = new Register();
            Regiswindow.Show();
            this.Close();
        }


    }


     
    
}
