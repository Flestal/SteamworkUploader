using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Steamworks;

namespace SteamworkUploader
{
    public partial class Form1 : Form
    {
        SteamId steamId;
        public Form1()
        {
            InitializeComponent();
            GameInit();
            groupBox1.AllowDrop = true;
            groupBox2.AllowDrop = true;
        }


        private void panel1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            }
        }
        private DirectoryInfo d;
        private string path, prev;

        private void panel1_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                d = new DirectoryInfo(((string[])e.Data.GetData(DataFormats.FileDrop))[0]);
                //label2.Text = "폴더 경로 : " + d.FullName;
                tb_path.Text = d.FullName;
                path = d.FullName;
                
                foreach(FileInfo file in d.GetFiles())
                {
                    if ((file.Name.ToLower().Contains("preview.jpg")))
                    {
                        //label3.Text = "미리보기 이미지 : " + file.Name;
                        Image tempImg = Image.FromFile(file.FullName);
                        //tempImg.Size = new Size(pictureBox1.Width, pictureBox1.Height);
                        prev = file.FullName;
                        Image resize = new Bitmap(tempImg, pictureBox1.Width, pictureBox1.Height);
                        pictureBox1.Image = resize;
                        break;
                    }
                    if (file.Name.ToLower().Contains("desc.txt"))
                    {
                        StreamReader sr = file.OpenText();
                        string[] line = sr.ReadToEnd().Split('\n');
                        bool flag = false;
                        string desc = "";
                        foreach(string s in line)
                        {
                            if (s.Contains("Title:"))
                            {
                                tb_title.Text = s.Split(':')[1];
                            }
                            /*if (s.Contains("Desc:"))
                            {
                                tb_desc.Text = s.Split(':')[1];
                            }*/
                            if (s.Contains("```"))
                            {
                                flag = !flag;
                                continue;
                            }
                            if (s.Contains("Tag:"))
                            {
                                tb_tag.Text = s.Split(':')[1];
                            }
                            if (flag)
                            {
                                if (desc == "")
                                {
                                    desc = s;
                                }
                                else
                                {
                                    desc += "\n" + s;
                                }
                                
                            }
                        }
                        tb_desc.Text = desc;
                        sr.Close();
                    }
                }
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            SteamClient.Shutdown();
        }

        private void groupBox2_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            }
        }
        int workID;

        private void groupBox2_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                d = new DirectoryInfo(((string[])e.Data.GetData(DataFormats.FileDrop))[0]);
                //label2.Text = "폴더 경로 : " + d.FullName;
                tb_updatePath.Text = d.FullName;
                path = d.FullName;

                foreach (FileInfo file in d.GetFiles())
                {
                    if ((file.Name.ToLower().Contains("preview.jpg")))
                    {
                        //label3.Text = "미리보기 이미지 : " + file.Name;
                        Image tempImg = Image.FromFile(file.FullName);
                        //tempImg.Size = new Size(pictureBox1.Width, pictureBox1.Height);
                        prev = file.FullName;
                        Image resize = new Bitmap(tempImg, pictureBox1.Width, pictureBox1.Height);
                        pictureBox2.Image = resize;
                        break;
                    }
                    if (file.Name.ToLower().Contains("desc.txt"))
                    {
                        StreamReader sr = file.OpenText();
                        string[] line = sr.ReadToEnd().Split('\n');
                        bool flag = false;
                        string desc = "";
                        foreach (string s in line)
                        {
                            if (s.Contains("Title:"))
                            {
                                tb_updateTitle.Text = s.Split(':')[1];
                            }
                            /*if (s.Contains("Desc:"))
                            {
                                tb_desc.Text = s.Split(':')[1];
                            }*/
                            if (s.Contains("```"))
                            {
                                flag = !flag;
                                continue;
                            }
                            if (s.Contains("Tag:"))
                            {
                                tb_updateTag.Text = s.Split(':')[1];
                            }
                            if (flag)
                            {
                                if (desc == "")
                                {
                                    desc = s;
                                }
                                else
                                {
                                    desc += "\n" + s;
                                }

                            }
                        }
                        tb_updateDesc.Text = desc;
                        sr.Close();
                    }
                }
            }
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            //var result=await Steamworks.Ugc.
            string[] tags = tb_updateTag.Text.Split('|');
            ulong id = Convert.ToUInt64(tb_workshopItemAddress.Text.Split(new string[]{"?id="},StringSplitOptions.None)[1]);
            tb_log_update.Text = id.ToString();
            //tb_log_update.Text = tb_workshopItemAddress.Text.Split(new string[] { "?id=" }, StringSplitOptions.None)[1];
            Steamworks.Ugc.Editor item = new Steamworks.Ugc.Editor(id)
                .WithTitle(tb_updateTitle.Text)
                .WithDescription(tb_updateDesc.Text)
                .WithContent(path)
                .WithPreviewFile(prev)
                .WithChangeLog(tb_whatNew.Text);

            foreach (string s in tags)
            {
                item.WithTag(s);
            }

            var result = await item.SubmitAsync();

            tb_log_update.Text = "업로드 완료";
        }

        private void GameInit()
        {
            SteamClient.Shutdown();
            string[] str = tb_shopPage.Text.Split('/');
            tb_log_newitem.Text = "";
            uint appId = 1256670;
            foreach (string s in str)
            {
                //tb_log_newitem.Text += "\n" + s;
                try
                {
                    appId = Convert.ToUInt32(s);
                }
                catch (Exception)
                {
                    continue;
                }
            }
            tb_log_newitem.Text = appId.ToString();
            try
            {
                SteamClient.Init(appId, true);
                steamId = SteamClient.SteamId;
                tb_log_newitem.Text = "Init OK, app Id : "+appId;
            }
            catch (Exception ex)
            {
                tb_log_newitem.Text = ex.Message;
                tb_log_newitem.Text += Environment.NewLine + ex.StackTrace;
            }
        }

        private void btn_GameInit_Click(object sender, EventArgs e)
        {
            GameInit();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            /*ItemData data = new ItemData();
            data.title = tb_title.Text;
            data.tag = tb_tag.Text;
            data.description = tb_desc.Text;
            data.contentpath = path;
            data.preview = prev;*/
            string[] tags = tb_tag.Text.Split('|');
            Steamworks.Ugc.Editor item = Steamworks.Ugc.Editor.NewCommunityFile
                .WithTitle(tb_title.Text)
                .WithDescription(tb_desc.Text)
                .WithContent(path)
                .WithPreviewFile(prev);

            foreach(string s in tags)
            {
                item.WithTag(s);
            }
            var result = await item.SubmitAsync();
                
            tb_log_newitem.Text = "업로드 완료";
        }
    }
}
