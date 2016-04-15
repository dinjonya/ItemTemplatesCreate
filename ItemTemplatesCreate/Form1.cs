using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ItemTemplatesCreate
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string itemtemplatesPath = "";
        private string auther = "";
        private string company = "";
        private string desc = "";
        private string tip = "";
        private string outPath = "";
        private string winrarName = "";

        public string CreateTip(string author,string company,string desc)
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine("/// <summary> ");
            builder.AppendLine("///     作者：" + author);
            builder.AppendLine("///     时间：$time$  ");
            builder.AppendLine("///     公司:" + company);
            builder.AppendLine("///     版权：$year$-2012  ");
            builder.AppendLine("///  CLR版本：$clrversion$ ");
            builder.AppendLine("///     说明：" + desc);
            builder.AppendLine("/// 唯一标识：$guid1$ ");
            builder.AppendLine("/// 更改说明：");
            builder.AppendLine("/// </summary>");
            builder.AppendLine("");
            return builder.ToString();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            //C:\Users\3c-dinjonya\Documents\Visual Studio 2013\Templates\ItemTemplates
            txtOutpath.Text = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            itemtemplatesPath = txtItemtemplatesPath.Text;
            auther = txtAuther.Text;
            company = txtCompany.Text;
            desc = txtDesc.Text;
            outPath = txtOutpath.Text;
            winrarName = txtItemtemplatesPath.Text.Split('\\')[txtItemtemplatesPath.Text.Split('\\').Length - 1] +
                         "(" + txtItemtemplatesPath.Text.Split('\\')[txtItemtemplatesPath.Text.Split('\\').Length - 4] + ").rar";
            CSharpWinrar rar = new CSharpWinrar();
            CSharpWinrar.CompressRar(itemtemplatesPath, outPath, winrarName);
           
            tip = CreateTip(auther, company, desc);
            txtContent.Text = tip;

            GetDirs(itemtemplatesPath,tip);
            

            MessageBox.Show("Test");

        }

        private void GetDirs(string path, string addTip)
        {
            List<string> files =
                Directory.GetFiles(path, "*.cs")
                    .Where(x => System.Text.RegularExpressions.Regex.IsMatch(x, @"\w+\.cs(?=$)"))
                    .ToList();
            AddSummary(files, addTip);

            string[] dirs = Directory.GetDirectories(path);
            if (dirs == null || dirs.Length == 0)
                return;
            else
            {
                foreach (string dirpath in dirs)
                {
                    GetDirs(dirpath, addTip);
                }
            }
        }

        private void AddSummary(List<string> filePath,string addTip)
        {
            if (filePath == null || filePath.Count == 0)
                return;
            foreach (string s in filePath)
            {
                FileStream fsr = new FileStream(s, FileMode.Open, FileAccess.Read);
                StreamReader str = new StreamReader(fsr, Encoding.UTF8);
                string content = str.ReadToEnd();
                str.Close();
                fsr.Close();
                StreamWriter stw = new StreamWriter(s, false, Encoding.UTF8);
                string newContent = addTip + content;
                stw.Write(newContent);
                stw.Close();
            }
            
        }


        /// <summary>
        /// 拷贝文件夹
        /// </summary>
        /// <param name="srcdir"></param>
        /// <param name="desdir"></param>
        private void CopyDirectory(string srcdir, string desdir)
        {
            string folderName = srcdir.Substring(srcdir.LastIndexOf("\\") + 1);

            string desfolderdir = desdir + "\\" + folderName;

            if (desdir.LastIndexOf("\\") == (desdir.Length - 1))
            {
                desfolderdir = desdir + folderName;
            }
            string[] filenames = Directory.GetFileSystemEntries(srcdir);

            foreach (string file in filenames)// 遍历所有的文件和目录
            {
                if (Directory.Exists(file))// 先当作目录处理如果存在这个目录就递归Copy该目录下面的文件
                {

                    string currentdir = desfolderdir + "\\" + file.Substring(file.LastIndexOf("\\") + 1);
                    if (!Directory.Exists(currentdir))
                    {
                        Directory.CreateDirectory(currentdir);
                    }

                    CopyDirectory(file, desfolderdir);
                }

                else // 否则直接copy文件
                {
                    string srcfileName = file.Substring(file.LastIndexOf("\\") + 1);

                    srcfileName = desfolderdir + "\\" + srcfileName;


                    if (!Directory.Exists(desfolderdir))
                    {
                        Directory.CreateDirectory(desfolderdir);
                    }


                    File.Copy(file, srcfileName);
                }
            }//foreach 
        }//function end 
    }
}
