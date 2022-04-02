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
    /// Interaction logic for ModifyMediaPage.xaml
    /// </summary>
    public partial class ModifyMediaPage : Page
    {
        Object previousContent;
        Media toView;
        public ModifyMediaPage(Object _previousContent, Media _toView)
        {
            InitializeComponent();
            previousContent = _previousContent;
            toView = _toView;
            newName.Text = toView.Title;
            listingTypeBox.ItemsSource = (typeof(MediaType)).GetEnumValues();
        }
        private void btnUpdateMedia_Click(object sender, RoutedEventArgs e)
        {
            if (newName.Text != toView.Title)
            {
                toView.Title = newName.Text;
                toView.MediaType = (MediaType)listingTypeBox.SelectedItem;

                MessageBox.Show("Media Title & Type Updated Successfully..!");
                Application.Current.MainWindow.Content = previousContent;
            }
            else
                MessageBox.Show("New media name is same as earlier. Please enter new media name..!");
        }
    }
}
