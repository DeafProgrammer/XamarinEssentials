using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using System.ComponentModel;
using Xamarin.Essentials;
using System.Windows.Input;
/* Author: James Anderson		Course: NMAD.261.01
Date: Spring 2022
Purpose of the file: Study Xamarin Essentials
Caveats: */
namespace XamarinEssentials
{
    public class Preferences : BindableObject
    {
        public Preferences()
        {
            ResetPrefs = new Command(OnResetPrefs);
        }

        public void OnResetPrefs()
        {
            Xamarin.Essentials.Preferences.Clear();
        }

        public ICommand ResetPrefs { private set; get; }

        public string Entry
        {
            get => Xamarin.Essentials.Preferences.Get("Entry", "");
            set
            {
                Xamarin.Essentials.Preferences.Set("Entry", value);
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(Entry));
            }
        }

        public bool IsChecked
        {
            get => Xamarin.Essentials.Preferences.Get("IsChecked", false);
            set 
            {
                Xamarin.Essentials.Preferences.Set("IsChecked", value);
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(IsChecked.ToString()));
            }
        }

        public bool SwitchInput
        {
            get => Xamarin.Essentials.Preferences.Get("SwitchInput", false);
            set
            {
                Xamarin.Essentials.Preferences.Set("SwitchInput", value);
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(SwitchInput.ToString()));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
