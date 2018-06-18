using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Media.Imaging;

namespace MyNotesApp.Models
{
    class Person
    {
        /// <summary>
        /// Person's name
        /// </summary>
        public string FriendlyName { get; set; }
        /// <summary>
        /// Set true if Person already has a profile image setup
        /// </summary>
        public bool IsProfileImage { get; set; }
        /// <summary>
        /// Store Person's image of choice
        /// </summary>
        public BitmapImage Image { get; set; }

    }
}
