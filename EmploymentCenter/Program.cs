using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using JsonSerializer = System.Text.Json.JsonSerializer;

namespace EmploymentCenter
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            EmploymentCenter center = new EmploymentCenter();
            try
            {
                using (StreamReader sr = new StreamReader("applicants.json"))
                {
                    center.Applicants = JsonConvert.DeserializeObject<List<Applicant>>(sr.ReadToEnd());
                }
                
            }
            catch (Exception)
            {
                // ignored
            }
            try
            {
                using (StreamReader sr = new StreamReader("offers.json"))
                {
                    center.AvailableOffers = JsonConvert.DeserializeObject<List<WorkOffer>>(sr.ReadToEnd());
                }
            }
            catch (Exception)
            {
                // ignored
            }
            
            Application.Run(new MainForm(center));
        }
    }
}