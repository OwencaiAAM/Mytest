using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PluginCommon;

fuck

namespace TestForm
{
    public partial class Form1 : Form
    {
        private ArrayList pluginsList = new ArrayList();
        private IPlugin _plugins = null;


        public Form1()
        {
            InitializeComponent();
        }

        private void btnInitial_Click(object sender, EventArgs e)
        {
            _plugins.RunFuction("InitCardReader");

            //MF102UMain.InitCardReader();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
           
            string type = "USB";
            string port = "COM1";
            string baud = "9600";
            bool re = Convert.ToBoolean(_plugins.RunFuctionRes("OpenCardReader", new string[] { type, port, baud }));
            if (re)
            {
                MessageBox.Show("读卡器打开成功");
            }
            else
            {
                MessageBox.Show("读卡器打开失败");
            }

            //MF102UMain.OpenCardReader("USB");
        }

        private void btnInventory_Click(object sender, EventArgs e)
        {
            string uid = _plugins.RunFuctionRes("Inventory").ToString();
            MessageBox.Show(uid);
        }

        private void btnAuthenticate_Click(object sender, EventArgs e)
        {
            string block = "11";
            string type = "0";
            string keyA = "FFFFFFFFFFFF";
            string keyB = "FFFFFFFFFFFF";

            bool ire = Convert.ToBoolean(_plugins.RunFuctionRes("Authenticate", new string[] { block, type, keyA, keyB }));

            if (ire)
            {
                MessageBox.Show("认证成功！");
            }
            else
            {
                MessageBox.Show("认证失败！");
            }
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            bool ire = Convert.ToBoolean(_plugins.RunFuctionRes("ConnectCard"));
            if (ire)
            {
                MessageBox.Show("连接成功！");
            }
            else
            {
                MessageBox.Show("连接失败！");
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            _plugins.RunFuction("Close");
            //MF102UMain.Close();
        }

        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            _plugins.RunFuction("DisConnect");
            //MF102UMain.DisConnect();
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            string block = "11";
            string type = "0";
            string keyA = "FFFFFFFFFFFF";
            string keyB = "FFFFFFFFFFFF";
            string cardno = _plugins.RunFuctionRes("ReadCard", new string[] { block, type, keyA, keyB }).ToString();
            MessageBox.Show(cardno);
            //MessageBox.Show(MF102UMain.ReadCard(0,0));
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadAllPlugs();
            _plugins = this.pluginsList[0] as IPlugin;

        }

        ///<summary>
        /// 载入所有插件
        ///</summary>
        private void LoadAllPlugs()
        {
            //获取插件目录(plugins)下所有文件
            string path = System.IO.Path.GetDirectoryName(Process.GetCurrentProcess().MainModule.FileName) + @"\Plugins";
            string[] files = Directory.GetFiles(path);
            foreach (string file in files)
            {
                if (file.ToUpper().EndsWith(".DLL"))
                {
                    try
                    {
                        //载入dll
                        Assembly ab = Assembly.LoadFrom(file);
                        Type[] types = ab.GetTypes();
                        foreach (Type t in types)
                        {
                            //如果某些类实现了预定义的IMsg.IMsgPlug接口，则认为该类适配与主程序(是主程序的插件)
                            if (t.GetInterface("IPlugin") != null)
                            {
                                pluginsList.Add(ab.CreateInstance(t.FullName));
                                //listBox1.Items.Add(t.FullName);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        //MessageBox.Show(ex.Message);
                    }
                }
            }
        }

    }
}
