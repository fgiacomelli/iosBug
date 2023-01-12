using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriggerProblemiOSRelease
{
    [INotifyPropertyChanged]
    public partial class MainPageViewModel 
    {
        [ObservableProperty]
        private bool enabled;

        [ObservableProperty]
        private string textLabel;

        public MainPageViewModel()
        {

            TextLabel = "Disabled!";
        }

        public void ButtonClicked()
        { 
            Enabled = !Enabled;
            TextLabel = Enabled ? "Enabled!" : "Disabled!";
        }
    }
}
