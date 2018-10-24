using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using System.Net;
using System.IO;

namespace STORE
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private static Random rnd = new Random((int)DateTime.Now.Ticks); //Agar Char_Generator tidak memasukkan nilai yg sama

        public string Char_Generator(int length)
        {
            
            var random_str = "";
            for (var i = 0; i < length; i++)
            {
                random_str += ((char)(rnd.Next(1, 26) + 64)).ToString();
            }

            string result = random_str.ToLower();
            return result;
            
        }

        private void button_buat_user_Click(object sender, EventArgs e)
        {
            //TANGGAL PLUS 3 BULAN
            DateTime dt = DateTime.Now;
            dt = dt.AddMonths(3);

            string pass1 = Char_Generator(5);
            string user1 = "pda1";
            string user2 = "pda2";
            string user3 = "pda3";
            string user4 = "pda4";
            string user5 = "pda5";
            string date_active = String.Format("{0:MM/dd/yyyy }", dt);
            string date_human = String.Format("{0:dd MMMM yyyy }", dt);
            string command_delete = "net user " 
                + user1 + " /delete & net user "
                + user2 + " /delete & net user "
                + user3 + " /delete & net user "
                + user4 + " /delete & net user "
                + user5 + " /delete";
            string command_add1 = "net user " + user1 + " " + pass1 + " /active:yes /expires:" + date_active + " /add";
            string command_add2 = "WMIC USERACCOUNT WHERE Name='" + user1 +"' SET PasswordExpires=FALSE";
            string command_add3 = "net localgroup administrators " + user1 + " /add";

            string cmd = "cmd /c "
                + command_delete + " & "
                + command_add1 + " & "
                + command_add2 + " & "
                + command_add3 + "";
            

            field_date_active.Text = date_human;
            field_pass_pda1.Text = pass1;
            field_pass_pda2.Text = "";
            field_pass_pda3.Text = "";
            field_pass_pda4.Text = "";
            field_pass_pda5.Text = "";


            ProcessStartInfo procStartInfo = new ProcessStartInfo("cmd.exe");
            procStartInfo.UseShellExecute = true;
            procStartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            procStartInfo.CreateNoWindow = true;
            procStartInfo.Verb = "runas";
            procStartInfo.Arguments = "/env /user:" + "Administrator" + cmd;

            ///command contains the command to be executed in cmd
            System.Diagnostics.Process proc = new System.Diagnostics.Process();
            proc.StartInfo = procStartInfo;
            proc.Start();
        }

        private void button_buat_user_5_Click(object sender, EventArgs e)
        {
            //TANGGAL PLUS 3 BULAN
            DateTime dt = DateTime.Now;
            dt = dt.AddMonths(3);

            string pass1 = Char_Generator(5);
            string pass2 = Char_Generator(5);
            string pass3 = Char_Generator(5);
            string pass4 = Char_Generator(5);
            string pass5 = Char_Generator(5);
            string user1 = "pda1";
            string user2 = "pda2";
            string user3 = "pda3";
            string user4 = "pda4";
            string user5 = "pda5";
            string date_active = String.Format("{0:MM/dd/yyyy }", dt);
            string date_human = String.Format("{0:dd MMMM yyyy }", dt);
            string command_delete = "net user "
                + user1 + " /delete & net user "
                + user2 + " /delete & net user "
                + user3 + " /delete & net user "
                + user4 + " /delete & net user "
                + user5 + " /delete";

            string command_add1_1 = "net user " + user1 + " " + pass1 + " /active:yes /expires:" + date_active + " /add";
            string command_add1_2 = "WMIC USERACCOUNT WHERE Name='" + user1 + "' SET PasswordExpires=FALSE";
            string command_add1_3 = "net localgroup administrators " + user1 + " /add";

            string command_add2_1 = "net user " + user2 + " " + pass2 + " /active:yes /expires:" + date_active + " /add";
            string command_add2_2 = "WMIC USERACCOUNT WHERE Name='" + user2 + "' SET PasswordExpires=FALSE";
            string command_add2_3 = "net localgroup administrators " + user2 + " /add";

            string command_add3_1 = "net user " + user3 + " " + pass3 + " /active:yes /expires:" + date_active + " /add";
            string command_add3_2 = "WMIC USERACCOUNT WHERE Name='" + user3 + "' SET PasswordExpires=FALSE";
            string command_add3_3 = "net localgroup administrators " + user3 + " /add";

            string command_add4_1 = "net user " + user4 + " " + pass4 + " /active:yes /expires:" + date_active + " /add";
            string command_add4_2 = "WMIC USERACCOUNT WHERE Name='" + user4 + "' SET PasswordExpires=FALSE";
            string command_add4_3 = "net localgroup administrators " + user4 + " /add";

            string command_add5_1 = "net user " + user5 + " " + pass5 + " /active:yes /expires:" + date_active + " /add";
            string command_add5_2 = "WMIC USERACCOUNT WHERE Name='" + user5 + "' SET PasswordExpires=FALSE";
            string command_add5_3 = "net localgroup administrators " + user5 + " /add";

            string cmd = "cmd /c "
                + command_delete + " & "
                + command_add1_1 + " & "
                + command_add1_2 + " & "
                + command_add1_3 + " & "
                + command_add2_1 + " & "
                + command_add2_2 + " & "
                + command_add2_3 + " & "
                + command_add3_1 + " & "
                + command_add3_2 + " & "
                + command_add3_3 + " & "
                + command_add4_1 + " & "
                + command_add4_2 + " & "
                + command_add4_3 + " & "
                + command_add5_1 + " & "
                + command_add5_2 + " & "
                + command_add5_3 + "";


            field_date_active.Text = date_human;
            field_pass_pda1.Text = pass1;
            field_pass_pda2.Text = pass2;
            field_pass_pda3.Text = pass3;
            field_pass_pda4.Text = pass4;
            field_pass_pda5.Text = pass5;


            ProcessStartInfo procStartInfo = new ProcessStartInfo("cmd.exe");
            procStartInfo.UseShellExecute = true;
            procStartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            procStartInfo.CreateNoWindow = true;
            procStartInfo.Verb = "runas";
            procStartInfo.Arguments = "/env /user:" + "Administrator" + cmd;

            ///command contains the command to be executed in cmd
            System.Diagnostics.Process proc = new System.Diagnostics.Process();
            proc.StartInfo = procStartInfo;
            proc.Start();

            //GET CLIENT METHOD
            //WebClient client = new WebClient();
            // Use google as test page
            //string downloadString = client.DownloadString("https://restcountries.eu");

            //string URI = "http://www.myurl.com/post.php";
            //string myParameters = "param1=value1&param2=value2&param3=value3";

            //using (WebClient wc = new WebClient())
            //{
            //    wc.Headers[HttpRequestHeader.ContentType] = "application/x-www-form-urlencoded";
            //    string HtmlResult = wc.UploadString(URI, myParameters);
            //}
        }
    }
}
