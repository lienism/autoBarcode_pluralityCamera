using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZBar;

namespace AutoBarcodePicture
{
    class Program
    {
        static void Main(string[] args)
        {
            Mutex app_mutex = new Mutex(false, "AutoBarcodePicture");

            //ミューテックスの所有権を要求する
            if (app_mutex.WaitOne(0, false) == false)
            {
                MessageBox.Show("このアプリケーションは複数起動できません。");
                return;
            }
            DirectoryInfo Barcode_Folder = new DirectoryInfo("../../../plurality_Camera/bin/Debug/Barcode/");
            FileInfo[] pictures = Barcode_Folder.GetFiles();
            DirectoryInfo success_folder = new DirectoryInfo("../../../plurality_Camera/bin/Debug/Barcode/Success/");
            DirectoryInfo[] Barcode_name_folder = success_folder.GetDirectories();
            Bitmap bmp;
            ImageScanner Is = new ImageScanner();
            List<Symbol> Barcode_result;
            string sDirPath;
            for (int i = 0; i < pictures.Length; i++)
            {
                bmp = new Bitmap(pictures[i].FullName);
                Barcode_result = Is.Scan(bmp);
                if(Barcode_result.Count == 0)
                {
                        pictures[i].CopyTo(pictures[i].DirectoryName + "/Failed/" + pictures[i].Name);
                }
                else
                {
                    foreach (var item in Barcode_result)
                    {
                        sDirPath = "../../../plurality_Camera/bin/Debug/Barcode/Success/" + item.Data + "/";
                        DirectoryInfo di = new DirectoryInfo(sDirPath);
                        if (di.Exists == false)
                        {
                            di.Create();
                        }
                        pictures[i].CopyTo(sDirPath + pictures[i].Name.Replace(".jpg", "_" + item.Data + ".jpg"));
                    }
                }
            }
        }
    }
}
