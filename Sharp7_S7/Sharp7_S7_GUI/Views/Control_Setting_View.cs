using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sharp7;
using Sharp7_S7_GUI.Service;



namespace Sharp7_S7_GUI
{
    public partial class Control_Setting_View : Form
    {
        public Control_Setting_View()
        {
            InitializeComponent();
        }
       
        private void btn_ClickConnect(object sender, EventArgs e)
        {
            var client = new S7Client();
            int result = client.ConnectTo("127.0.0.1", 0, 1);
            if (result == 0)
            {
                MessageBox.Show(" Connect to PLCSIM");
            }
            else
            {
                MessageBox.Show(client.ErrorText(result));
            }
        }

        private void btn_ClickDisconnect(object sender, EventArgs e)
        {
            var client = new S7Client();
            int result = client.Disconnect();
            MessageBox.Show(" Disconnect to PLCSIM");
        }
        public void DisplayData()
        {
        }
    }
}
