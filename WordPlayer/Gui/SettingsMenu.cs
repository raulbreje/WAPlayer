using System;
using System.Resources;
using System.Windows.Forms;
using static System.String;

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
            var rm = Internal.Resources.SettingsResources.ResourceManager;
            rtb_reporter.Text = rm.GetString("reporter_quote");
            rtb_interviewed.Text = rm.GetString("interviewed_quote");
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

        private string rep = Empty;
        private string inte = Empty;

        public string getReporterQuoteSimulation()
        {
            return rep;
        }

        public string getInterviewedQuoteSimulation()
        {
            return inte;
        }

        private void btn_okay_Click(object sender, EventArgs e)
        {
            using (var resx = new ResXResourceWriter(@"D:\Private\Bachelor Degree Workspace\WordPlayer\VS Workspace\WordPlayer\WordPlayer\Internal\Resources\SettingsResources.resx"))
            {
                resx.AddResource("reporter_quote", rtb_reporter.Text);
                resx.AddResource("interviewed_quote", rtb_interviewed.Text);
            }
            rep = rtb_reporter.Text;
            inte = rtb_interviewed.Text;
            this.Close();
        }
    }
}

