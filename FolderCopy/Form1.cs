using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FolderCopy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                // コピーするのディレクトリパス
                string sourceDirName = textBox1.Text;
                // コピー後のディレクトリパス
                string destDirName = textBox2.Text;
 

                // ディレクトリをコピーする
                CopyDirectory(sourceDirName, destDirName);
                if (!options.Checked && !config.Checked && !resourcepacks.Checked && !schematics.Checked && !saves.Checked && !screenshots.Checked && !XaeroWaypoints.Checked && !XaeroWorldMap.Checked && !String.IsNullOrEmpty(textBox1.Text) && !String.IsNullOrEmpty(textBox2.Text))
                {
                    MessageBox.Show("何も選択されていません");
                }
                else
                {
                    // 完了メッセージを表示する
                    MessageBox.Show($"{sourceDirName}を{destDirName}にコピーしました。");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        public void CopyDirectory(string sourceDirName, string destDirName)
        {
            // コピー先のディレクトリがないかどうか判定する
            if (!Directory.Exists(destDirName))
            {
                // コピー先のディレクトリを作成する
                Directory.CreateDirectory(destDirName);
            }

            // コピー元のディレクトリの属性をコピー先のディレクトリに反映する
            File.SetAttributes(destDirName, File.GetAttributes(sourceDirName));

            // ディレクトリパスの末尾が「\」でないかどうかを判定する
            if (!destDirName.EndsWith(Path.DirectorySeparatorChar.ToString()))
            {
                // コピー先のディレクトリ名の末尾に「\」を付加する
                destDirName = destDirName + Path.DirectorySeparatorChar;
            }

            // コピー元のディレクトリ内のファイルを取得する
            string[] files = Directory.GetFiles(sourceDirName);
            foreach (string file in files)
            {
                if (options.Checked==true)
                {
                    File.Copy(sourceDirName+"\\options.txt", destDirName + Path.GetFileName("options.txt"), true);
                }
            }

            // コピー元のディレクトリのサブディレクトリを取得する
            string[] dirs = Directory.GetDirectories(sourceDirName);
                if (config.Checked == true)
                {
                    // コピー元のディレクトリのサブディレクトリで自メソッド（CopyDirectory）を再帰的に呼び出す
                    CopyDirectory2(sourceDirName+("\\config"), destDirName + Path.GetFileName("config"));
                }
                if(resourcepacks.Checked == true)
                {
                    CopyDirectory2(sourceDirName + ("\\resourcepacks"), destDirName+Path.GetFileName("resourcepacks"));
                }
                if(saves.Checked == true)
                {
                    CopyDirectory2(sourceDirName+("\\saves"), destDirName + Path.GetFileName("saves"));
                }
                if(schematics.Checked == true)
            {
                CopyDirectory2(sourceDirName + ("\\schematics"), destDirName + Path.GetFileName("schematics"));
            }
                if(screenshots.Checked == true)
            {
                CopyDirectory2(sourceDirName + ("\\screenshots"), destDirName + Path.GetFileName("screenshots"));
            }
                if(XaeroWaypoints.Checked == true)
            {
                CopyDirectory2(sourceDirName + ("\\XaeroWaypoints"), destDirName + Path.GetFileName("XaeroWaypoints"));
            }
                if(XaeroWorldMap.Checked == true)
            {
                CopyDirectory2(sourceDirName + ("\\XaeroWorldMap"), destDirName + Path.GetFileName("XaeroWorldMap"));
            }
            if (shaderpacks.Checked == true)
            {
                CopyDirectory2(sourceDirName + ("\\shaderpacks"), destDirName + Path.GetFileName("shaderpacks"));
            }
            if (itemscroller.Checked == true)
            {
                CopyDirectory2(sourceDirName + ("\\itemscroller"), destDirName + Path.GetFileName("itemscroller"));
            }
            if (g4mespeed.Checked == true)
            {
                CopyDirectory2(sourceDirName + ("\\g4mespeed"), destDirName + Path.GetFileName("g4mespeed"));
            }
        }
        public void CopyDirectory2(string sourceDirName, string destDirName)
        {
            // コピー先のディレクトリがないかどうか判定する
            if (!Directory.Exists(destDirName))
            {
                // コピー先のディレクトリを作成する
                Directory.CreateDirectory(destDirName);
            }

            // コピー元のディレクトリの属性をコピー先のディレクトリに反映する
            File.SetAttributes(destDirName, File.GetAttributes(sourceDirName));

            // ディレクトリパスの末尾が「\」でないかどうかを判定する
            if (!destDirName.EndsWith(Path.DirectorySeparatorChar.ToString()))
            {
                // コピー先のディレクトリ名の末尾に「\」を付加する
                destDirName = destDirName + Path.DirectorySeparatorChar;
            }

            // コピー元のディレクトリ内のファイルを取得する
            string[] files = Directory.GetFiles(sourceDirName);
            foreach (string file in files)
            {
                if (Path.GetFileName(file) == "hanemod-client.toml")
                {
                    Console.WriteLine("hanemodのconfigは移行できません");
                }
                else
                {
                    // コピー元のディレクトリにあるファイルをコピー先のディレクトリにコピーする
                    File.Copy(file, destDirName + Path.GetFileName(file), true);
                }
            }

            // コピー元のディレクトリのサブディレクトリを取得する
            string[] dirs = Directory.GetDirectories(sourceDirName);
            foreach (string dir in dirs)
            {
                    // コピー元のディレクトリのサブディレクトリで自メソッド（CopyDirectory）を再帰的に呼び出す
                    CopyDirectory2(dir, destDirName + Path.GetFileName(dir));
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult dr = folderBrowserDialog1.ShowDialog();
            if (dr == System.Windows.Forms.DialogResult.OK)
            {
                textBox1.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult dr = folderBrowserDialog1.ShowDialog();
            if (dr == System.Windows.Forms.DialogResult.OK)
            {
                textBox2.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void bindall_Click(object sender, EventArgs e)
        {
            options.Checked = true;
            resourcepacks.Checked = true;
            config.Checked = true;
            saves.Checked = true;
            schematics.Checked = true;
            screenshots.Checked = true;
            XaeroWaypoints.Checked = true;
            XaeroWorldMap.Checked = true;
            shaderpacks.Checked = true;
            itemscroller.Checked = true;
            g4mespeed.Checked = true;
        }

        private void unbindall_Click(object sender, EventArgs e)
        {
            options.Checked = false;
            resourcepacks.Checked = false;
            config.Checked = false;
            saves.Checked = false;
            schematics.Checked = false;
            screenshots.Checked = false;
            XaeroWaypoints.Checked = false;
            XaeroWorldMap.Checked = false;
            shaderpacks.Checked = false;
            itemscroller.Checked = false;
            g4mespeed.Checked = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            options.Checked = true;
            resourcepacks.Checked = true;
            config.Checked = true;
            schematics.Checked = true;
            XaeroWaypoints.Checked = true;
            XaeroWorldMap.Checked = true;
            shaderpacks.Checked = true;
            itemscroller.Checked = true;
            g4mespeed.Checked = true;
        }
    }
}
