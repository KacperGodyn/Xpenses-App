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

namespace Xpenses
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public bool GetStartedSkipped = true;
        public MainWindow()
        {
            InitializeComponent();
            DataContext = this;
            
        }
        private void onGetStartedButtonClick(object sender, RoutedEventArgs e)
        {
            SetVisibilityCollapsedForGetStarted();

        }

        private void SetVisibilityCollapsedForGetStarted()
        {
            TextNameofApp.Visibility = Visibility.Collapsed;
            TextShortAppDesc.Visibility = Visibility.Collapsed;
            ButtonStart.Visibility = Visibility.Collapsed;
        }
        private void onAddIncomeButtonClick(object sender, RoutedEventArgs e)
        {
            PopupAddIncomeSource.Visibility = Visibility.Visible;
            SetVisibilityCollapsedForGetStarted();
        }
        private void onAddExpensesButtonClick(object sender, RoutedEventArgs e)
        {
            
        }
        public class IncomeSource
        {
            public string Title { get; set; }
            public decimal Value { get; set; }
            public string Description { get; set; }
        }
        private void ButtonCancelAddIncome_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ButtonConfirmAddIncome_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
