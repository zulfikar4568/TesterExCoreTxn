using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
using CsvHelper;
using OpcenterWikLibrary;

namespace TesterExCoreTxn
{
    public partial class Tester : KryptonForm
    {
        private List<FormatLogger> collectionMessage = new List<FormatLogger>();
        public Tester()
        {
            InitializeComponent();
            this.Palette = MyPalette;
            AddVersionNumber();
        }
        private string LogGenerator(string sMessage, string status)
        {
            collectionMessage.Add(new FormatLogger() { Timestamp = DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss.fff", CultureInfo.InvariantCulture), Message = sMessage, Status = status });
            return $"[{DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss.fff", CultureInfo.InvariantCulture)}] {sMessage} {status}";
        }
        private void AddLogs(string sMessage)
        {
            Lb_Logs.Items.Add(sMessage);
            Lb_Logs.TopIndex = Lb_Logs.Items.Count - 1;
        }
        private void AddVersionNumber()
        {
            System.Reflection.Assembly assembly = System.Reflection.Assembly.GetExecutingAssembly();
            FileVersionInfo versionInfo = FileVersionInfo.GetVersionInfo(assembly.Location);

            this.Text += $" V.{versionInfo.FileVersion}";
        }

        private void Bt_Start_Click(object sender, EventArgs e)
        {
            AddLogs(LogGenerator($"Success Start at LS", "success"));
            AddLogs(LogGenerator($"Success MoveIn at LS", "success"));
            AddLogs(LogGenerator($"Success MoveOut at LS", "success"));
            AddLogs(LogGenerator($"Success MoveIn at PPA", "success"));
            AddLogs(LogGenerator($"Success MoveOut at PPA", "success"));
            AddLogs(LogGenerator($"Success MoveIn at HP", "success"));
            AddLogs(LogGenerator($"Success MoveOut at HP", "success"));
            AddLogs(LogGenerator($"Success MoveIn at FT", "success"));
            AddLogs(LogGenerator($"Success MoveOut at FT", "success"));
            AddLogs(LogGenerator($"Success MoveIn at VC", "success"));
            AddLogs(LogGenerator($"Success MoveOut at VC", "success"));
            AddLogs(LogGenerator($"Success MoveIn at W", "success"));
            AddLogs(LogGenerator($"Success MoveOut at W", "success"));
            AddLogs(LogGenerator($"Success MoveIn at BE", "success"));
            AddLogs(LogGenerator($"Success MoveOut at BE", "success"));
            generateFileReport("D:\\3. OPCENTER\\Opcenter 8.6 & MIO 4.0\\Document from Kenneth\\logs", this.collectionMessage);
        }

        private void Bt_Reset_Click(object sender, EventArgs e)
        {
            this.collectionMessage.Clear();
            Lb_Logs.Items.Clear();
        }


        public void generateFileReport(string locationFolder, List<FormatLogger> loggerObjects)
        {
            StreamWriter oFile = null;
            Directory.CreateDirectory(locationFolder);
            if (Directory.Exists(locationFolder))
            {
                try
                {
                    string sDestinationFileName = locationFolder + "\\" + $"LogFile-{DateTime.Now.ToUniversalTime().Subtract(new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc)).TotalMilliseconds}.csv";
                    using ( oFile = new StreamWriter(sDestinationFileName))
                    using (var csv = new CsvWriter(oFile, CultureInfo.InvariantCulture))
                    {
                        csv.WriteRecords(loggerObjects);
                    }
                }
                catch (Exception ex)
                {
                    EventLogUtil.LogErrorEvent(AppSettings.AssemblyName == ex.Source ? MethodBase.GetCurrentMethod().Name : MethodBase.GetCurrentMethod().Name + "." + ex.Source, ex);
                }
                finally
                {
                    if (oFile != null) oFile.Close();
                    if (oFile != null) oFile.Dispose();
                }
            }
        }
    }
}
