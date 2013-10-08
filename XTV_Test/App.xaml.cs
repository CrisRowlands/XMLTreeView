using Microsoft.Phone.Controls;
using System.Diagnostics;
using System.Windows;
using System.Windows.Navigation;

namespace XTV_Test
{
    public partial class App : Application
    {
        public static PhoneApplicationFrame RootFrame { get; private set; }
        private bool phoneApplicationInitialized = false;

        public App()
        {
            UnhandledException += Application_UnhandledException;
            InitializeComponent();
            InitializePhoneApplication();
        }
        private void InitializePhoneApplication()
        {
            if (phoneApplicationInitialized) return;
            RootFrame = new PhoneApplicationFrame();
            RootFrame.Navigated += CompleteInitializePhoneApplication;
            RootFrame.NavigationFailed += RootFrame_NavigationFailed;
            phoneApplicationInitialized = true;
        }
        private void CompleteInitializePhoneApplication(object sender, NavigationEventArgs e)
        {
            if (RootVisual != RootFrame) RootVisual = RootFrame;
            RootFrame.Navigated -= CompleteInitializePhoneApplication;
        }
        private void RootFrame_NavigationFailed(object sender, NavigationFailedEventArgs e)
        { if (Debugger.IsAttached) { Debugger.Break(); } }
        private void Application_UnhandledException(object sender, ApplicationUnhandledExceptionEventArgs e)
        { if (Debugger.IsAttached) { Debugger.Break(); } }
    }
}