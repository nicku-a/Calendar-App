using System;
using System.IO;
using Xamarin.Forms;
using Calendar.Models;
using System.Reflection;
using System.Globalization;

namespace Calendar
{
    public partial class JobEntryPage : ContentPage
    {
        public JobEntryPage()
        {
            InitializeComponent();
        }

        void OnLowButtonClicked(object sender, EventArgs e)
        {
            var job = (Job)BindingContext;
            job.Priority = "Low";
        }

        void OnMediumButtonClicked(object sender, EventArgs e)
        {
            var job = (Job)BindingContext;
            job.Priority = "Medium";
        }

        void OnHighButtonClicked(object sender, EventArgs e)
        {
            var job = (Job)BindingContext;
            job.Priority = "High";
        }

        async void OnSaveButtonClicked(object sender, EventArgs e)
        {
            var job = (Job)BindingContext;
            job.DateDeadline = DateDeadlinePicker.Date;
            job.TaskDuration = DurationPicker.Time;
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