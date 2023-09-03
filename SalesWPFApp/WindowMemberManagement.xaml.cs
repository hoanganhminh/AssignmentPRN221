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
    /// Interaction logic for WindowMemberManagement.xaml
    /// </summary>
    public partial class WindowMemberManagement : Window
    {
        public WindowMemberManagement()
        {
            InitializeComponent();
            LoadMember();
        }
        public void LoadMember()
        {
            lvMember.ItemsSource = DataAccess.MemberDAO.GetMembers();
        }
        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }

        private void btnInsert_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Member member = new Member
                {
                    Email = txtEmail.Text,
                    City = txtCity.Text,
                    Country = txtCountry.Text,
                    CompanyName = txtCompanyName.Text,
                    Password = txtPassword.Text,
                    Role = int.Parse(txtRole.Text)
                };
                DataAccess.MemberDAO.InsertMember(member);
                LoadMember();
                MessageBox.Show($"{member.Email} updated successfully", "Update member");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Insert product");
            }
        }

        private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Member member = new Member
                {
                    Email = txtEmail.Text,
                    City = txtCity.Text,
                    Country = txtCountry.Text,
                    MemberId = int.Parse(txtMemberId.Text),
                    CompanyName = txtCompanyName.Text,
                    Password = txtPassword.Text,
                    Role = int.Parse(txtRole.Text)
                };
                DataAccess.MemberDAO.UpdateMember(member);
                LoadMember();
                MessageBox.Show($"{member.Email} updated successfully", "Update member");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Edit Member");
            }
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Are you sure delete this member?", "Question", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                try
                {
                    Member member = new Member
                    {
                        Email = txtEmail.Text,
                        City = txtCity.Text,
                        Country = txtCountry.Text,
                        MemberId = int.Parse(txtMemberId.Text),
                        CompanyName = txtCompanyName.Text,
                        Password = txtPassword.Text,
                        Role = int.Parse(txtRole.Text)
                    };
                    DataAccess.MemberDAO.RemoveMember(member);
                    LoadMember();
                    MessageBox.Show($"{member.Email} deleted successfully", "Delete member");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Remove Member");
                }
            }
        }
    }
}
