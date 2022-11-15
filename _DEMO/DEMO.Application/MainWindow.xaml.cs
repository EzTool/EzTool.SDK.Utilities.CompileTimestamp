using EzTool.SDK.Utilities.CompileTimestamp;

using System.Windows;

namespace DEMO.Application
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var objBuildDate = BuildDateTimeReader.ReadFrom();

                MessageBox.Show(objBuildDate.ToString($@"yyyy/MM/dd HH:mm:ss"));
            }
            catch (WithoutRequiredAttributeException pi_objException)
            {
                MessageBox.Show(pi_objException.Message);
            }
        }
    }
}
