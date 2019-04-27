using System;
using System.Windows;
using Windows.Data.Xml.Dom;
using Windows.UI.Notifications;

namespace UseWindowsRuntime
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

        private void OnSendToast(object sender, RoutedEventArgs e)
        {
            try
            {
                string title = "Global Azure Boot Camp 2019 Linz";
                string timeString = $"{DateTime.Now:HH:mm:ss}";

                string toastXmlString =
                $@"<toast>
              <visual>
                <binding template='ToastGeneric'>
                  <text>{title}</text>
                  <text>{timeString}</text>
                  <text>Enjoy!</text>
                </binding>
              </visual>
            </toast>";

                var xmlDoc = new XmlDocument();
                xmlDoc.LoadXml(toastXmlString);

                var toastNotification = new ToastNotification(xmlDoc);
                var toastNotifier = ToastNotificationManager.CreateToastNotifier();
                toastNotifier.Show(toastNotification);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
