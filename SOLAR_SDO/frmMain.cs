using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Net;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using SOLAR_SDO.Properties;
using System.Drawing.Text;
using System.Windows.Input;

namespace SOLAR_SDO
{
    public partial class frmMain : Form
    {
        
        [DllImport("User32", CharSet = CharSet.Auto)]
        public static extern int SystemParametersInfo(int uiAction, int uiParam,string pvParam, uint fWinIni);

        public static DateTime last { get; set; }
        public static DateTime least { get; set; }

        public static bool flag { get; set; } = false;

        public static Point Last;

        public frmMain()
        {
            InitializeComponent();
            InitFont();
            comboLoad();
            picExample.ImageLocation = @"C:\SUN\LAST.jpg";
            
            cmbTemp.SelectedIndex = 5;
            download.Enabled = true;
            download.Start();
            download_Tick(null, null);
            download.Tick += new EventHandler(download_Tick);


            label1.Text = "Ultima descarga: "+ File.GetLastWriteTime(@"C:\SUN\latest_512_0304.jpg").ToString();
        }

        private void download_Tick(object sender, EventArgs e)
        {
            bool local = false, server = false;
            string path;
            //string pathNew = @"C:\SUN\TRY.jpg";
            //string pathOld = @"C:\SUN\LAST.jpg";
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
            using (WebClient wc = new WebClient())
            {
                try
                {
                    if (chkRandom.Checked == true)
                    {
                        int W = cmbTemp.Items.Count - 1;
                        Random rnd = new Random();
                        int select = rnd.Next(0, W);
                        cmbTemp.SelectedIndex = select;
                        path = "https://sdo.gsfc.nasa.gov/assets/img/latest/latest_4096_" + cmbTemp.SelectedItem + ".jpg";
                    }
                    else
                    {
                        path = "https://sdo.gsfc.nasa.gov/assets/img/latest/latest_4096_" + cmbTemp.SelectedItem + ".jpg";
                    }
                    try
                    {
                        HttpWebRequest FileDate = (HttpWebRequest)WebRequest.Create(path);
                        HttpWebResponse FileResponse = (HttpWebResponse)FileDate.GetResponse();
                        last = FileResponse.LastModified;
                        FileResponse.Close();
                        server = true;
                    }
                    catch (Exception ex)
                    {
                        server = false;
                        //MessageBox.Show(ex.ToString());
                    }


                    if (last > least || flag)
                    {
                        if (flag)
                        {
                            flag = false;
                        }
                        try
                        {
                            HttpWebRequest FileDate2 = (HttpWebRequest)WebRequest.Create(path);
                            HttpWebResponse FileResponse2 = (HttpWebResponse)FileDate2.GetResponse();
                            least = FileResponse2.LastModified;
                            FileResponse2.Close();
                            local = true;
                        }
                        catch (Exception ex)
                        {
                            local = false;
                            //MessageBox.Show(ex.ToString());
                        }

                        string DateFolder = DateTime.Now.ToString("yyyy-MM-dd");
                        if (!Directory.Exists(@"C:\SUN\box\" + DateFolder + @"\"))
                        {
                            Directory.CreateDirectory(@"C:\SUN\box\" + DateFolder + @"\");
                        }

                        string NewDownload = @"C:\SUN\box\" + DateFolder + @"\sun_" + cmbTemp.SelectedItem.ToString() + "_" + last.ToString("yyyy-MM-dd_HH-mm-ss").Replace('/', '-').Replace(':', '_') + ".jpg";
                        wc.DownloadFile(path, NewDownload);
                        timer.Enabled = true;
                        timer.Start();
                        int I = 0;
                        lblTime.Text = I.ToString();
                        lblTimer.Visible = true;
                        SystemParametersInfo(0x0014, 0, NewDownload, 0x0001);
                        label1.Text = "Fecha: " + File.GetLastWriteTime(NewDownload).ToString() + " - Filtro: " + cmbTemp.SelectedItem;
                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.ToString());
                }

            }
        }
       
        private void timer_Tick(object sender, EventArgs e)
        {
            int I = Convert.ToInt32(lblTime.Text); I++;
            lblTime.Text = (I).ToString() ;
        }

        private void CloseWindowClick(object sender, EventArgs e)
        {
            ((Form)this.TopLevelControl).Close();
        }

        private void MinimizeClick(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void InitFont()
        {
            PrivateFontCollection pfc = new PrivateFontCollection();

            //Select your font from the resources.
            int fontLength = Resources.nasalization_rg.Length;

            // create a buffer to read in to
            byte[] fontdata = Resources.nasalization_rg;

            // create an unsafe memory block for the font data
            IntPtr data = Marshal.AllocCoTaskMem(fontLength);

            // copy the bytes to the unsafe memory block
            Marshal.Copy(fontdata, 0, data, fontLength);

            // pass the font to the font collection
            pfc.AddMemoryFont(data, fontLength);
            label1.Font = new Font(pfc.Families[0], label1.Font.Size, label1.Font.Style);
            label2.Font = new Font(pfc.Families[0], label2.Font.Size, label2.Font.Style);
            label3.Font = new Font(pfc.Families[0], label3.Font.Size,label3.Font.Style);
            lblTimer.Font = new Font(pfc.Families[0], lblTimer.Font.Size, lblTimer.Font.Style);
            lblTime.Font = new Font(pfc.Families[0], lblTime.Font.Size, lblTime.Font.Style);
            cmbTemp.Font = new Font(pfc.Families[0], cmbTemp.Font.Size, cmbTemp.Font.Style);
            chkRandom.Font = new Font(pfc.Families[0], chkRandom.Font.Size, chkRandom.Font.Style);
            label3.Text = "SOLAR VIEWER";
        }

        private void comboLoad()
        {
            if (Directory.Exists(@"C:\SUN"))
            {
                foreach (var item in Directory.GetFiles(@"C:\SUN"))
                {
                    if (item.Contains("latest"))
                    {
                        cmbTemp.Items.Add(item.Split('_')[2].Split('.')[0]);
                    }
                } 
            }
        }

        private void cmbTemp_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.download.Enabled = false;
            picExample.ImageLocation = @"C:\SUN\latest_512_" + cmbTemp.SelectedItem + ".jpg" ;
            flag = true;
            this.download.Enabled = true;
        }

        private void frmMain_MouseDown(object sender, MouseEventArgs e)
        {
            Last = new Point(e.X,e.Y);
        }

        private void frmMain_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button==MouseButtons.Left)
            {
                this.Left += e.X - Last.X;
                this.Top += e.Y - Last.Y;
            }
        }

        private void chkRandom_CheckedChanged(object sender, EventArgs e)
        {
            if (chkRandom.Checked)
            {
                download.Interval = 30000;
            }
            else
            {
                download.Interval = 10000;
            }
        }

        private void NASA_Click(object sender, EventArgs e)
        {

        }
    }
}
