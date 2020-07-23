using System;
using System.IO;
using Xamarin.Forms;
using Calendar.Models;
using System.Reflection;
using System.Globalization;

namespace Calendar
{
    public partial class SettingsPage : ContentPage
    {

        public SettingsPage()
        {
            InitializeComponent();

            var _fileName = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Settings.txt");

            if (File.Exists(_fileName))
            {
                NameInput.Text = File.ReadAllText(_fileName);
            }
        }

        void NameCompleted(object sender, EventArgs e)
        {
            var _fileName = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Settings.txt");
            File.WriteAllText(_fileName, NameInput.Text);
        }
    }
}