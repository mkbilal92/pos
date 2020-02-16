using Demo.Database.Entities;
using System.Windows;

namespace Demo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            var dbContext = new DbContext();
           
            InitializeComponent();
        }
    }
}
