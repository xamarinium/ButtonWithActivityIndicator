using System;
using System.Threading.Tasks;

namespace ButtonWithActivityIndicator
{
    public partial class MainPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void OnClicked(object sender, EventArgs e)
        {
            ButtonWithSpinner.IsBusy = !ButtonWithSpinner.IsBusy;
                
            // simulate long time process
            if (ButtonWithSpinner.IsBusy)
            {
                await Task.Delay(3000);
                OnClicked(this, EventArgs.Empty);
            } 
        }
    }
}
