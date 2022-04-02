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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace FinalProject
{
    /// <summary>
    /// Interaction logic for ModifyMemberPage.xaml
    /// </summary>
    public partial class ModifyMemberPage : Page
    {
        Object previousContent;
        LibraryMember toView;
        public ModifyMemberPage(Object _previousContent, LibraryMember _toView)
        {
            InitializeComponent();
            previousContent = _previousContent;
            toView = _toView;
            newName.Text = toView.Name;
        }
        private void btnUpdateMember_Click(object sender, RoutedEventArgs e)
        {
            if (newName.Text != toView.Name)
            {
                toView.Name = newName.Text;
                MessageBox.Show("Member Name Updated Successfully..!");
                Application.Current.MainWindow.Content = previousContent;
            }
            else
                MessageBox.Show("New member name is same as earlier. Please enter new member name..!");
        }
    }
}
