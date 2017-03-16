using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App4
{
    class PresetPattern
    {
        private string name;
        private string backgroundImageSrc;

        public PresetPattern(string name, string backgroundImageSrc)
        {
            this.name = name;
            this.backgroundImageSrc = backgroundImageSrc;
        }

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        public string BackgroundImageSrc
        {
            get
            {
                return backgroundImageSrc;
            }
            set
            {
                backgroundImageSrc = value;
            }
        }
    }
}
