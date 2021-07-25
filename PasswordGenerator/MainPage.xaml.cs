using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using ShadePasswd;

namespace PasswordGenerator
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            List<Password.CombinationPart> parts = new List<Password.CombinationPart>();

            if (checkbox_letters.IsChecked) { parts.Add(Password.CombinationPart.Letters); }
            if (checkbox_special_chars.IsChecked) { parts.Add(Password.CombinationPart.SpecialChars); }
            if (checkbox_numbers.IsChecked) { parts.Add(Password.CombinationPart.Numbers); }
            //if (checkbox_random_words.IsChecked) {/*parts.Add(Password.CombinationPart.Words*/); }

            string password = Password.Generate(parts.ToArray(), Convert.ToInt32(entry_password_lenght.Text), checkbox_random_size.IsChecked);
            entry_new_password.IsEnabled = true;
            entry_new_password.Text = password;
        }
    }
}
