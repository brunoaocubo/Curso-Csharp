using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private string targetFolder = @"C:\Users\bruno.carvalho\Desktop\[TESTE] DESTINO EXTRATOS";

        Dictionary<string, string> employesToRename = new Dictionary<string, string>()
        {
            {"11", "RD" },{"12", "NC"},{"4", "PT"},{"1", "CL"},{"3","MN"},{"5","SU"},{"17","VT"}
        };

        Dictionary<string, string> employesSpecificBradesco = new Dictionary<string, string>()
        {
            {"323845", "3" }, {"400718", "1"}
        };

        Dictionary<string, string> employesSpecificSantander = new Dictionary<string, string>()
        {
            {"290006988", "RG"}
        };

        public Dictionary<string, Dictionary<string, string>> employesPort = new Dictionary<string, Dictionary<string, string>>()
        {
            {"001", 
                new Dictionary<string, string>()
                {
                    {"11", "510"},{"5", "701" }
                }   
            },
            {"033",
                new Dictionary<string, string>()
                {
                    {"4", "412"},{"3", "316" },{"11", "523"},{"1", "111" },{"5", "707"},{"17", "171" },{"12", "360"},{"290006988", "524" }
                }
            },
            {"341",
                new Dictionary<string, string>()
                {
                    {"4", "404"},{"3", "301" },{"11", "515"},{"1", "105" },{"5", "705"},{"12", "351"}
                }
            },
            {"237",
                new Dictionary<string, string>()
                {
                    {"4", "402"},{"3", "311" },{"11", "501"},{"1", "110" },{"5", "706"},{"12", "359"},{"323845", "311" },{"400718", "110"}
                }
            }
        };
        
        
        public Form1()
        {
            InitializeComponent();
            
        }

        private void btnExecute_Click(object sender, EventArgs e)
        {
            RenameBankExtracts();
        }

        private void RenameBankExtracts()
        {
            DateTime time = DateTime.Now;
            int maxRangeDays = 3;
            decimal limitSeconds = maxRangeDays * 86400;
            List<string> logs = new List<string>();
            string pattern = @"EXT\.(\d{3})\.(\d+)(\d{2})(\d{2})(\d{2})\d{2}\.RET";

            Dictionary<string, string> bank_folders = new Dictionary<string, string>()
            {
                {"001", @"C:\Users\bruno.carvalho\Desktop\[TESTE] ORIGEM EXTRATOS\001" },
                {"033", @"C:\Users\bruno.carvalho\Desktop\[TESTE] ORIGEM EXTRATOS\033" },
                {"237", @"C:\Users\bruno.carvalho\Desktop\[TESTE] ORIGEM EXTRATOS\237" },
                {"341", @"C:\Users\bruno.carvalho\Desktop\[TESTE] ORIGEM EXTRATOS\341" }
            };

            foreach (KeyValuePair<string, string> key in bank_folders)
            {
                if (!Directory.Exists(key.Value))
                {
                    logs.Add($"Pasta não encontrada: {key.Value}");
                    continue;
                }

                string[] files = Directory.GetFiles(key.Value);
                foreach (string file in files)
                {
                    Match match = Regex.Match(file, pattern);

                    if (!match.Success) {
                        logs.Add($"Arquivo Ignorado (padrão inválido): {file}");
                        continue;
                    }

                    string bankId = match.Groups[1].ToString();
                    string cod = match.Groups[2].ToString();
                    string day = match.Groups[3].ToString();
                    string month = match.Groups[4].ToString();
                    string year = match.Groups[5].ToString();

                    if(bankId != key.Key)
                    {
                        logs.Add($"Banco {bankId} diferente da pasta {key.Key} : {file}");
                        continue;
                    }

                    string date_file = $"{day}{month}{year}";
                    if (File.GetCreationTime(file) < DateTime.Now.AddDays(-maxRangeDays)){
                        Console.WriteLine($"O arquivo: {file} foi criado a mais de 3 dias.");
                        continue;
                    }

                    Console.WriteLine($"O arquivo: {file} foi criado a menos de 3 dias. Realizando o processo...");



                }

                string targetSubFolders = $@"{targetFolder}\{key.Key}";
                if (!Directory.Exists(targetSubFolders))
                {
                    Directory.CreateDirectory(targetSubFolders);
                    Console.WriteLine($"Pasta não existe, criando agora...{targetSubFolders}");
                }
            }

            /*
            try
            {
                if (Directory.Exists(originFolder))
                {
                    //string newTarget = targetFolder + @"\033";
                    string[] folders = Directory.GetDirectories(originFolder);
                    foreach (string subfolder in folders)
                    {
                        string[] archives = Directory.GetFiles(subfolder);
                        string subfolderName = Path.GetFileName(subfolder);
                        foreach (string pathArchive in archives)
                        {
                            string archive = Path.GetFileName(pathArchive);

                            if (subfolderName == "033" && archive.StartsWith("EXT"))
                            {
                                if (!Directory.Exists(newTarget))
                                {
                                    Directory.CreateDirectory(newTarget);
                                    //string newArchive = $@"033\{archive}";
                                }
                                string targetPath = Path.Combine(newTarget, archive);
                                File.Copy(pathArchive, targetPath, true);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro: {ex.Message}");
            }*/
        }
    }
}
