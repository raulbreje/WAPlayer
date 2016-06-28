using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordPlayer.Controller
{
    
    public class SettingsController
    {
        private string _reporterQuote = "Default Reporter: ";

        private string _interviewedQuote = "Default Interviewed";

        public SettingsController(string reporterQuote, string interviewedQuote)
        {
            _reporterQuote = reporterQuote;
            this._interviewedQuote = interviewedQuote;
        }
    }
}
