using System;
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
using System.Windows.Shapes;
using DataAccess.Repository;

namespace SalesWPFApp
{
    /// <summary>
    /// Interaction logic for WindowLogin.xaml
    /// </summary>
    public partial class WindowLogin : Window
    {
        public WindowLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            String message = "Invalid Credentials";
            Member a = new Member();
            try
            {
                a = DataAccess.MemberDAO.Login(txtEmail.Text.ToString(), txtPassword.Password.ToString());
                if (a == null)
                {
                    MessageBox.Show("Wrong Email or Password");
                }
                else
                {
                    if(a.Role == 2)
                    {
                        message = "2";
                    }
                    else if (a.Role == 1)
                    {
                        message = "1";
                    }
                }
                
            }
            catch (Exception ex)
            {
                message = ex.Message.ToString();
                WindowLogin windowLogin = new WindowLogin();
                windowLogin.Show();
                this.Close();
            }
            if (message == "1")
            {
                WindowMembers windowMembers = new WindowMembers(a);
                windowMembers.Show();
                this.Close();
            }
            else if (message == "2")
            {
                MainWindow mainWindow = new MainWindow();
                mainWindow.Show();
                this.Close();
            }
            else
            {
                WindowLogin windowLogin = new WindowLogin();
                windowLogin.Show();
                this.Close();
            }
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}