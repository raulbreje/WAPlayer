using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WordPlayer.Gui
{

    public partial class SettingsMenu : Form
    {

        public static readonly string Mp3Format = ".mp3";
        public static readonly string WavFormat = ".wav";
        public static readonly string AacFormat = ".aac";
        public static readonly string AiffFormat = ".aiff";

        public SettingsMenu()
        {
            InitializeComponent();
        }

        public string[] GetSelectedAudioFormatsList()
        {
            var listOfFormatsStrings = new string[4];
            var index = 0;
            if (checkBox_aac.Checked == true)
            {
                listOfFormatsStrings[index++] = AacFormat;
            }
            if (checkBox_aiff.Checked == true)
            {
                listOfFormatsStrings[index++] = AiffFormat;
            }
            if (checkBox_wav.Checked == true)
            {
                listOfFormatsStrings[index++] = WavFormat;
            }
            if (checkBox_mp3.Checked == true)
            {
                listOfFormatsStrings[index] = Mp3Format;
            }
            return listOfFormatsStrings;
        }
    }
}

