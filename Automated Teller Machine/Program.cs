using System;
using System.Windows.Forms;

namespace Automated_Teller_Machine
{
    static class Program
    {
        //to save which language is selected, false for farsi, true for english
        public static bool lang = false;

        //use in acctBalanceForm to save method used in last step
        //A for transfer money to other account       C for transfer money to other card
        //B for balance       W for withdraw    P for password change   R for bill pay (receipt)
        public static char state = ' ';

        //for saving Card Account Number as a Reference
        public static string accNum = "";

        //for saving Card Number as a Reference
        public static string accP1 = "";
        public static string accP2 = "";
        public static string accP3 = "";
        public static string accP4 = "";

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormSelectLanguage());
        }
    }
}
