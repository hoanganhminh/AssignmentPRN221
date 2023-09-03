using DataAccess;
using DataAccess.Repository;
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

namespace SalesWPFApp
{
    /// <summary>
    /// Interaction logic for WindowMembers.xaml
    /// </summary>
    public partial class WindowMembers : Window
    {
        Member a;
        public WindowMembers()
        {
            InitializeComponent();
        }

        public WindowMembers(Member member)
        {
            a = member;
            InitializeComponent();
            LoadUser();
        }

        void LoadUser ()
        {
            txtEmail.Text = a.Email;
            txtCountry.Text = a.Country;
            txtCompanyName.Text = a.CompanyName;
            txtCity.Text = a.City;
            txtPassword.Text = a.Password;
        }

        private void btnEdit_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Member member = new Member
                {
                    Email = txtEmail.Text,
                    City = txtCity.Text,
                    Country = txtCountry.Text,
                    MemberId = a.MemberId,
                    CompanyName = txtCompanyName.Text,
                    Password = txtPassword.Text,
                    Orders = a.Orders,
                    Role = a.Role                    
                };
                MemberDAO.UpdateMember(member);
                a = member;
                LoadUser();
                MessageBox.Show($"{member.Email} updated successfully", "Update member");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Edit Member");
            }
        }

        private void btnLogout_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Logout?", "Question", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                WindowLogin windowLogin = new WindowLogin();
                windowLogin.Show();
                this.Close();
            }
        }
    }
}
