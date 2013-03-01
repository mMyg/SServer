using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using SServer;
using NDde.Client;
using System.Net.NetworkInformation;

namespace SClient
{
    public partial class SClient : Form
    {
        private IniFile _inifile;
        private String _name;
        private String _side;
        private String _class;
        private String _type;
        private String _host;
        private UInt32 _port;
        private IniFile.Section _section;
        private Int32 _macadress;

        public SClient()
        {
            InitializeComponent();
            foreach (NetworkInterface nic in NetworkInterface.GetAllNetworkInterfaces())
            {
                _macadress =+ nic.GetPhysicalAddress().GetHashCode();
            }
            _inifile = new IniFile("Client.ini");
            _section = _inifile.GetSection("[Multiplayer]");
            _section.GetPropertyByName("Name").SetValue(new String[] { _macadress.ToString() });
            _name = _section.GetPropertyByName("Name").GetValue()[0];
            _side = _section.GetPropertyByName("Side").GetValue()[0];
            _class =_section.GetPropertyByName("Class").GetValue()[0];
            _type = _section.GetPropertyByName("Type").GetValue()[0];
            _host = _section.GetPropertyByName("Host").GetValue()[0];
            _port = UInt32.Parse(_section.GetPropertyByName("Port").GetValue()[0]);

            namebox.Text = _name;
            selectside.Text = _side;
            selectclass.Text = _class;
            selecttype.Text = _type;
            selecthost.Text = _host;
            portinfo.Text = _port.ToString();
        }


        private void hostinfo_TextChanged(object sender, EventArgs e)
        {
            _section.GetPropertyByName("Host").SetValue(new String[] { selecthost.Text });
        }

        private void portinfo_TextChanged(object sender, EventArgs e)
        {
            _section.GetPropertyByName("Port").SetValue(new String[] { portinfo.Text });
        }

        private void SClient_FormClosed(object sender, FormClosedEventArgs e)
        {
            _inifile.Write();
        }

        private void launchbutton_Click(object sender, EventArgs e)
        {
            try
            {
                DdeClient ddeClient = new DdeClient("SOLE", "POKE TOPIC");
                String tempHeader = System.Text.ASCIIEncoding.ASCII.GetString(new Byte[] { 0, 0, 1, 48, 0, 0, 0, 0 });
                String tempStringData = tempHeader + _section.ToString().Trim();
                ddeClient.Connect();
                ddeClient.Poke("TOPIC", tempStringData, 10000);
            }
            catch (Exception)
            {
                MessageBox.Show("Failed to contact application, please load/restart sole.exe");
            }
        }

        private void selectside_TextChanged(object sender, EventArgs e)
        {
            _section.GetPropertyByName("Side").SetValue(new String[] { selectside.Text });
        }

        private void selectclass_TextChanged(object sender, EventArgs e)
        {
            _section.GetPropertyByName("Class").SetValue(new String[] { selectclass.Text });
        }

        private void selecttype_TextChanged(object sender, EventArgs e)
        {
            _section.GetPropertyByName("Type").SetValue(new String[] { selecttype.Text });
        }
    }
}
