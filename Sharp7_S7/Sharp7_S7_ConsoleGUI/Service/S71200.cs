using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using Sharp7;
using System.Windows.Forms;
using Sharp7_S7_GUI;


namespace Sharp7_S7_GUI.Service
{
    class S71200
    {
        public void ReadAllDBfromPLC()
        {
            var client = new S7Client();
            while (true)
            {
                if (client.ConnectTo("127.0.0.1", 0, 1) != 0)
                {
                    MessageBox.Show(client.ErrorText(client.ConnectTo("127.0.0.1", 0, 1)));
                    break;
                }
                byte[] db1Buffer = new byte[66];
                client.DBRead(52, 0, 66, db1Buffer);
                int PV_NoPress_1 = S7.GetIntAt(db1Buffer, 12);
                int PV_NoPress_2 = S7.GetIntAt(db1Buffer, 14);
                int PV_NoPress_3 = S7.GetIntAt(db1Buffer, 16);
                double PV_Force1 = S7.GetRealAt(db1Buffer, 38);
                double PV_Force2 = S7.GetRealAt(db1Buffer, 42);
                double PV_Force3 = S7.GetRealAt(db1Buffer, 46);
                MessageBox.Show("PV No Press 1: " + PV_NoPress_1 + "PV No Press 2: " + PV_NoPress_2 + "PV No Press 3: " + PV_NoPress_3);
                Thread.Sleep(100);
            }
            
        }
    }

}
