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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            memberGrid.ItemsSource = Library.allMembers;
            mediaGrid.ItemsSource = Library.allMedia;
        }

        public void RefreshDataGrid()
        {
            memberGrid.ItemsSource = null;
            memberGrid.ItemsSource = Library.allMembers;

            mediaGrid.ItemsSource = null;
            mediaGrid.ItemsSource = Library.allMedia;
        }

        private void btnModifyMember_Click(object sender, RoutedEventArgs e)
        {
            if (memberGrid.SelectedItem != null)
            {
                this.Content = new ModifyMemberPage(this.Content, (LibraryMember)memberGrid.SelectedItem);
                RefreshDataGrid();
            }
            else
            {
                MessageBox.Show("You must select a listing in order to modify a name..!");
            }
        }

        private void btnModifyMedia_Click(object sender, RoutedEventArgs e)
        {
            if (mediaGrid.SelectedItem != null)
            {
                this.Content = new ModifyMediaPage(this.Content, (Media)mediaGrid.SelectedItem);
                RefreshDataGrid();
            }
            else
            {
                MessageBox.Show("You must select a listing in order to modify a name..!");
            }
        }

        private void btnLendMedia_Click(object sender, RoutedEventArgs e)
        {
            if (memberGrid.SelectedItem != null)
            {
                if (mediaGrid.SelectedItem != null)
                {
                    Media currentMedia = (Media)mediaGrid.SelectedItem;
                    LibraryMember currentMember = (LibraryMember)memberGrid.SelectedItem;

                    if (currentMedia.IsAvailable == true)
                    {
                        currentMedia.Borrower = currentMember.Name;
                        currentMedia.IsAvailable = false;
                        currentMedia.NoOfTimesLent++;
                        MessageBox.Show(currentMedia.Title + " has been lent out to " + currentMember.Name /*+ " Lented time is : " + currentMedia.NoOfTimesLent*/);
                        RefreshDataGrid();
                    }
                    else
                    {
                        MessageBox.Show(currentMedia.Title + " is not available to lent. ");
                    }
                }
                else
                {
                    MessageBox.Show("You must select a media listing in order to lent a media..!");
                }
            }
            else
            {
                MessageBox.Show("You must select a member listing in order to lent a media..!");
            }
        }

        private void btnReturnMedia_Click(object sender, RoutedEventArgs e)
        {
            if (mediaGrid.SelectedItem != null)
            {
                Media currentMedia = (Media)mediaGrid.SelectedItem;
                LibraryMember currentMember = (LibraryMember)memberGrid.SelectedItem;

                if (currentMedia.IsAvailable == false)
                {
                    MessageBox.Show(currentMedia.Title + " has been returned to the library by " + currentMedia.Borrower /*+ " Lented time is : " + currentMedia.NoOfTimesLent*/);
                    currentMedia.IsAvailable = true;
                    currentMedia.Borrower = "";
                    RefreshDataGrid();
                }
                else
                {
                    MessageBox.Show("You're performing a wrong action..! \n" + currentMedia.Title + " is available to lent. ");
                }
            }
            else
            {
                MessageBox.Show("Please select a particular media to return..!");
            }
        }

        private void btnDetailedView_Click(object sender, RoutedEventArgs e)
        {
            if (mediaGrid.SelectedItem != null)
            {
                Media selectedMedia = (Media)mediaGrid.SelectedItem;
                MessageBox.Show(selectedMedia.MediaInfo());
            }
            else
            {
                MessageBox.Show("Please select a particular row to see detailed information..!");
            }
        }
    }
}
