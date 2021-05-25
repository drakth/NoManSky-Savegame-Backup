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

/* No Man Sky Savegame Backup, was born because i was annoyed with the bug
 * about the expeditions ending prematurly, so I decided to make a small 
 * utility to make backups of the savegames as changes are detected.
 * 
    Copyright(C) 2021  Matias A. Villagarcia

    This program is free software: you can redistribute it and/or modify
    it under the terms of the GNU General Public License as published by
    the Free Software Foundation, version 3 of the License.

    This program is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.See the
    GNU General Public License for more details.

    You should have received a copy of the GNU General Public License
    along with this program.If not, see<https://www.gnu.org/licenses/>.
*/

namespace No_Man_Sky_Save_Management
{
    public partial class frmMain : Form
    {
        string destination = "";
        public frmMain()
        {
            InitializeComponent();

            //Create the callbacks for the File System Watcher object.
            FSW.Created += fsw_created;
            FSW.Changed += fsw_changed;
            FSW.Deleted += fsw_deleted;
        }

        private void enableFSWEvents()
        {
            FSW.EnableRaisingEvents = true;
        }

        private void disableFSWEvents()
        {
            FSW.EnableRaisingEvents = false;
        }

        private void cmdBrowse_Click(object sender, EventArgs e)
        {
            dlgFolder.ShowDialog();
            txtPath.Text = dlgFolder.SelectedPath;
            txtLog.AppendText(DateTime.Now + " NMS save folder set." + Environment.NewLine);
        }

        private void cmdBrowseDest_Click(object sender, EventArgs e)
        {
            dlgFolder.ShowDialog();
            txtDestination.Text = dlgFolder.SelectedPath;
            txtLog.AppendText(DateTime.Now + " Destination folder set." + Environment.NewLine);
        }

        private void cmdEnable_Click(object sender, EventArgs e)
        {
            //Set up the callbacks and start monitoring for changes.
            try
            {
                string rutaNMS = txtPath.Text;

                if (rutaNMS != "")
                {
                    if(txtDestination.Text != "" )
                    {
                        FSW.Path = rutaNMS;

                        enableFSWEvents();
                        cmdEnable.Enabled = false;
                        cmdDisable.Enabled = true;
                        txtLog.AppendText(DateTime.Now + " Monitoring enabled!" + Environment.NewLine);
                    }else
                    {
                        txtLog.AppendText(DateTime.Now + " Invalid destination folder." + Environment.NewLine);
                    }
                }else
                {
                    txtLog.AppendText(DateTime.Now + " Invalid NMS path." + Environment.NewLine);
                }
            }
            catch (Exception ex)
            {
                txtLog.AppendText(DateTime.Now + " ERROR: " + ex.Message + Environment.NewLine);
            }
        }

        //TODO: Instead of duplicating code in create and modify, we should probably modularize it.

        private void fsw_created (object sender, FileSystemEventArgs e)
        {
            try
            {
                int delay = Convert.ToInt32(txtDelay.Text);
                if (e.Name != "steam_autocloud.vdf") //We dont want to process changes to steam cloud files.
                {
                    Task.Delay(Convert.ToInt32(txtDelay.Text) * 1000).Wait(); //If we do not wait the file will still be used by NMS and give an error.

                    //We disable monitoring so we dont process further changes until
                    //we are done copying files.
                    disableFSWEvents();
                    txtLog.AppendText(DateTime.Now + " " + e.FullPath + " Changed." + Environment.NewLine);

                    //Check if destination folder exists, if it does not create it and copy the files.
                    destination = Convert.ToString(DateTime.Now.Day + "-" + DateTime.Now.Month + "-" + DateTime.Now.Year + "-" + DateTime.Now.Hour + "." + DateTime.Now.Minute);
                    destination = destination.Replace("/", "-");
                    destination = destination.Replace(":", ".");
                    if (Directory.Exists(txtDestination.Text + "\\" + destination) == false)
                    {
                        Directory.CreateDirectory(txtDestination.Text + "\\" + destination);
                        File.Copy(e.FullPath, txtDestination.Text + "\\" + destination + "\\" + e.Name, true);
                    }
                    else
                    {
                        File.Copy(e.FullPath, txtDestination.Text + "\\" + destination + "\\" + e.Name, true);
                    }
                    txtLog.AppendText(DateTime.Now + " " + e.Name + " File copied." + Environment.NewLine);

                    enableFSWEvents();
                }
            }
            catch (Exception ex)
            {
                txtLog.AppendText(DateTime.Now + " ERROR: " + ex.Message + Environment.NewLine);
            }
        }

        private void fsw_changed(object sender, FileSystemEventArgs e)
        {
            try
            {
                int delay = Convert.ToInt32(txtDelay.Text);
                if (e.Name != "steam_autocloud.vdf") //We dont want to process changes to steam cloud files.
                {
                    Task.Delay(Convert.ToInt32(txtDelay.Text) * 1000).Wait(); //If we do not wait the file will still be used by NMS and give an error.

                    //We disable monitoring so we dont process further changes until
                    //we are done copying files.
                    disableFSWEvents();
                    txtLog.AppendText(DateTime.Now + " " + e.FullPath + " Changed." + Environment.NewLine);

                    //Check if destination folder exists, if it does not create it and copy the files.
                    destination = Convert.ToString(DateTime.Now.Day + "-" + DateTime.Now.Month + "-" + DateTime.Now.Year + "-" + DateTime.Now.Hour + "." + DateTime.Now.Minute);
                    destination = destination.Replace("/", "-");
                    destination = destination.Replace(":", ".");
                    if (Directory.Exists(txtDestination.Text + "\\" + destination) == false)
                    {
                        Directory.CreateDirectory(txtDestination.Text + "\\" + destination);
                        File.Copy(e.FullPath, txtDestination.Text + "\\" + destination + "\\" + e.Name, true);
                    }
                    else
                    {
                        File.Copy(e.FullPath, txtDestination.Text + "\\" + destination + "\\" + e.Name, true);
                    }
                    txtLog.AppendText(DateTime.Now + " " + e.Name + " File copied." + Environment.NewLine);

                    enableFSWEvents();
                }
            }
            catch (Exception ex)
            {
                txtLog.AppendText(DateTime.Now + " ERROR: " + ex.Message + Environment.NewLine);
            }
        }

        private void fsw_deleted (object sender, FileSystemEventArgs e)
        {
            //Not sure if this will be used?
        }

        private void cmdDisable_Click(object sender, EventArgs e)
        {
            try
            {
                disableFSWEvents();
                cmdEnable.Enabled = true;
                cmdDisable.Enabled = false;
                txtLog.AppendText(DateTime.Now + " Monitoring Disabled!" + Environment.NewLine);
            }
            catch(Exception ex)
            {
                txtLog.AppendText(DateTime.Now + " ERROR: " + ex.Message + Environment.NewLine);
            }
        }

        private void chkRemember_Click(object sender, EventArgs e)
        {
            try
            {
                if (chkRemember.Checked == true)
                {
                    if (txtPath.Text != "" && txtDestination.Text != "")
                    {
                        StreamWriter sw = new StreamWriter(Application.StartupPath + "\\paths.txt", false);
                        sw.WriteLine(txtPath.Text);
                        sw.WriteLine(txtDestination.Text);
                        sw.Close();
                    }
                    else
                    {
                        txtLog.AppendText(DateTime.Now + " Both paths must be completed." + Environment.NewLine);
                        chkRemember.Checked = false;
                    }
                }
                else
                {
                    if(File.Exists(Application.StartupPath + "\\paths.txt"))
                    {
                        File.Delete(Application.StartupPath + "\\paths.txt");
                    }
                }
            }
            catch (Exception ex)
            {
                txtLog.AppendText(DateTime.Now + " ERROR: " + ex.Message + Environment.NewLine);
            }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            try
            {
                if(File.Exists(Application.StartupPath + "\\paths.txt"))
                {
                    StreamReader sr = new StreamReader(Application.StartupPath + "\\paths.txt");
                    txtPath.Text = sr.ReadLine();
                    txtDestination.Text = sr.ReadLine();
                    sr.Close();
                    chkRemember.Checked = true;
                }else
                {
                    chkRemember.Checked = false;
                }
            }catch(Exception ex)
            {
                txtLog.AppendText(DateTime.Now + " ERROR: " + ex.Message + Environment.NewLine);
            }
        }
    }
}