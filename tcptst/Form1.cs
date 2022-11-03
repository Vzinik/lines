using System.Globalization;
using System.Net.Sockets;
using System.Text;

namespace tcptst
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        TcpClient tcpclnt;
        private void startbttn_Click(object sender, EventArgs e)
        {

            try
            {
                tcpclnt = new TcpClient();
                tcpclnt.Connect(iptxt.Text, 33000);
            }
            catch (Exception ex) { loglstbx.Items.Add(ex.Message); }

            //checking if connected
            Socket s = tcpclnt.Client;
            if (s.Connected)
                loglstbx.Items.Add("connected....");
            else
            {
                tcpclnt.Close();
                loglstbx.Items.Add("not connected");
            }

            Int32 avl = tcpclnt.Available;
            loglstbx.Items.Add("amount of data avl: " + avl);



            //if(!tcpclnt.Active)

            NetworkStream stm = tcpclnt.GetStream();
            
            ASCIIEncoding asen = new ASCIIEncoding();
            byte[] ba = new byte[1024];
            int num = 0;
            if(stm.DataAvailable)
            num = stm.Read(ba);
            else
            {
                stm.Close();
                loglstbx.Items.Add("no data");
                return;
            }
            loglstbx.Items.Add("bytes read: " + num);
            string datastring=Convert.ToHexString(ba);
            loglstbx.Items.Add("datastring: "+datastring);
            string maindata="";
            for (int i = 0; i <26 ; i++)
            {
                maindata += datastring[i];
                
            }
            string hexnumber = "";

            loglstbx.Items.Add("whole chunk: "+maindata);
            maindata = "";
            for (int i = 0; i < 16; i++)
            {
                maindata += datastring[10+i];

            }

            byte[] decnum;
            for(int j = 0; j < 16; j++)
            {
                if ((j + 1) / 4 == 0)
                {
                    decnum=Convert.FromHexString(hexnumber);
                    //int x=decnum[1];
                    loglstbx.Items.Add(hexnumber);
                    hexnumber = "";
                }
                hexnumber += maindata; 
            }
            stm.Close();
        }

        private void stopbttn_Click(object sender, EventArgs e)
        {
            tcpclnt.Close();
            loglstbx.Items.Add("comms closed");
        }

        private void mssgtxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void sendbttn_Click(object sender, EventArgs e)
        {
            string hex=mssgtxt.Text;
            byte[] a = Convert.FromHexString(hex);
            //Int32 b=Convert.ToInt32(a);
            NetworkStream stm = tcpclnt.GetStream();
            stm.Write(a);
            loglstbx.Items.Add(a[0] * 256 + a[1]);
            mssgtxt.Text = "";
            
        }

        private void clrbttn_Click(object sender, EventArgs e)
        {
            loglstbx.Items.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //loglstbx.Items.Add("connecting.....");
            
            try
            {
                tcpclnt = new TcpClient();
                tcpclnt.Connect(iptxt.Text, 33000);
            }
            catch (Exception ex) { loglstbx.Items.Add(ex.Message); }

            //checking if connected
            Socket s = tcpclnt.Client;
            if (s.Connected)
                loglstbx.Items.Add("connected....");
            else
            {
                tcpclnt.Close();
                loglstbx.Items.Add("not connected");
                return;
            }

            Int32 avl = tcpclnt.Available;
            loglstbx.Items.Add("amount of data avl: " + avl);
        }

    
    }
}