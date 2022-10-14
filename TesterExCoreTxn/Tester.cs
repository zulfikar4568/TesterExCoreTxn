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
using OpcenterWikLibrary;

namespace TesterExCoreTxn
{
    public partial class Tester : KryptonForm
    {
        private List<string> collectionMessage = new List<string>();
        public Tester()
        {
            InitializeComponent();
            this.Palette = MyPalette;
            AddVersionNumber();
        }
        private string LogGenerator(string sMessage)
        {
            return $"[{DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss.fff", CultureInfo.InvariantCulture)}] {sMessage}";
        }
        private void AddLogs(string sMessage)
        {
            Lb_Logs.Items.Add(sMessage);
            collectionMessage.Add(sMessage);
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
            AddLogs(LogGenerator($"Success Start at LS"));
            AddLogs(LogGenerator($"Success MoveIn at LS"));
            AddLogs(LogGenerator($"Success MoveOut at LS"));
            AddLogs(LogGenerator($"Success MoveIn at PPA"));
            AddLogs(LogGenerator($"Success MoveOut at PPA"));
            AddLogs(LogGenerator($"Success MoveIn at HP"));
            AddLogs(LogGenerator($"Success MoveOut at HP"));
            AddLogs(LogGenerator($"Success MoveIn at FT"));
            AddLogs(LogGenerator($"Success MoveOut at FT"));
            AddLogs(LogGenerator($"Success MoveIn at VC"));
            AddLogs(LogGenerator($"Success MoveOut at VC"));
            AddLogs(LogGenerator($"Success MoveIn at W"));
            AddLogs(LogGenerator($"Success MoveOut at W"));
            AddLogs(LogGenerator($"Success MoveIn at BE"));
            AddLogs(LogGenerator($"Success MoveOut at BE"));
            generateFileReport("D:\\3. OPCENTER\\Opcenter 8.6 & MIO 4.0\\Document from Kenneth\\logs", this.collectionMessage);
        }

        private void Bt_Reset_Click(object sender, EventArgs e)
        {
            this.collectionMessage.Clear();
            Lb_Logs.Items.Clear();
        }


        public void generateFileReport(string locationFolder, List<string> messages)
        {
            StreamWriter oFile = null;
            Directory.CreateDirectory(locationFolder);
            if (Directory.Exists(locationFolder))
            {
                try
                {
                    string sDestinationFileName = locationFolder + "\\" + $"LogFile-{DateTime.Now.ToUniversalTime().Subtract(new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc)).TotalMilliseconds}.log";
                    oFile = new StreamWriter(sDestinationFileName);
                    foreach (var msg in messages)
                    {
                        oFile.WriteLine(msg);
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
