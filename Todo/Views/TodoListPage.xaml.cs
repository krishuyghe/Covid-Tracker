using System;
using System.IO;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace Todo
{
    public partial class TodoListPage : ContentPage
    {
        public TodoListPage()
        {
            InitializeComponent();
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();

            listView.ItemsSource = await App.Database.GetItemsAsync();
        }

        async void OnItemAdded(object sender, EventArgs e)
        {
            var text = new TodoItem();
            text.SelectedTime = DateTime.Now;
            await Navigation.PushAsync(new TodoItemPage
            {

                BindingContext = text
            }) ;
        }

        async void OnListItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem != null)
            {
                await Navigation.PushAsync(new TodoItemPage
                {
                    BindingContext = e.SelectedItem as TodoItem
                });
            }
        }
        async void OnSentClicked(object sender, EventArgs e)
        {
            var message = new EmailMessage
            {
                Subject = "Log info van Covid trakker applet",
                Body = "In bijlage de file",
            };

            var fn = "Attachment.txt";
            var file = Path.Combine(FileSystem.CacheDirectory, fn);
            var readDatabase = await App.Database.GetItemsAsync();
            string outputData = "";
            foreach (var record in readDatabase)
            {
                outputData += record.OutputData;

            }

            File.WriteAllText(file, outputData);

            message.Attachments.Add(new EmailAttachment(file));

            await Email.ComposeAsync(message);
        }
    }
}
