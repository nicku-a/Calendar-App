using System;
using System.IO;
using Xamarin.Forms;
using Calendar.Models;

namespace Calendar
{
    public partial class JobEntryPage : ContentPage
    {
        public JobEntryPage()
        {
            InitializeComponent();
        }

        async void OnSaveButtonClicked(object sender, EventArgs e)
        {
            var job = (Job)BindingContext;
            job.Date = DateTime.UtcNow;
            await App.Database.SaveJobAsync(job);
            await Navigation.PopAsync();
        }

        async void OnDeleteButtonClicked(object sender, EventArgs e)
        {
            var job = (Job)BindingContext;
            await App.Database.DeleteJobAsync(job);
            await Navigation.PopAsync();
        }
    }
}