using System;
using System.IO;
using Xamarin.Forms;
using Calendar.Data;

namespace Calendar
{
    public partial class App : Application
    {
        static JobDatabase database;

        public static JobDatabase Database
        {
            get
            {
                if (database == null)
                {
                    database = new JobDatabase(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Jobs.db3"));
                }
                return database;
            }
        }

        public App()
        {
            InitializeComponent();
            MainPage = new NavigationPage(new JobsPage());
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}