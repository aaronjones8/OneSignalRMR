using OneSignalSDK.DotNet;
using OneSignalSDK.DotNet.Core.Debug;

namespace OneSignalRMR
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            OneSignal.Debug.LogLevel = LogLevel.VERBOSE;

            // OneSignal Initialization
            OneSignal.Initialize("632c48ff-3612-411a-9cfc-8d70cc6e81e1");

            // RequestPermissionAsync will show the notification permission prompt.
            // We recommend removing the following code and instead using an In-App Message to prompt for notification permission (See step 5)
            OneSignal.Notifications.RequestPermissionAsync(true);

            MainPage = new AppShell();
        }
    }
}
