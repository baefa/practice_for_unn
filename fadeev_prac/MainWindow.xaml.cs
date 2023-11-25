
using System.Windows;

namespace fadeev_prac
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        SQLCommand sQLCommand = new SQLCommand();
        public MainWindow()
        {
            InitializeComponent();
            Loaded += Window_Loaded;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            sQLCommand.GetNameTable();
        }
    }
}
