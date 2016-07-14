using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;


namespace WindowsFormsApplication3
{
    public partial class Form1 : Form
    {
        string[] pony1 = { "YAY", "YAY!!!!", "Hello!", "20 percent cooler" }; //Pony
        static int text1 = 0;
        int RAMCHANGE;                                                        //RAMCHANGE int for RAMBAR
        string client = "client name";                                        //client string for client selection
        string name = "name";                                                          //name string for name selection
        string appdata = Environment.GetEnvironmentVariable("APPDATA");       //appdata string for get appdata enviroment
        string client1patch = "ShyCraft";                                     //client1patch string for get client1 patch
        string client2patch = "minecraft";                                    //client2patch string for get client2 patch




        public Form1()
        {
            InitializeComponent();  
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public void textBox1_TextChanged(object sender, EventArgs e)
        {
            string name = textBox1.Text;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        public void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox1.DisplayMember.ToString();
            string client = comboBox1.Text;
            DebugLabel.Text = client;

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        public void RAM_Scroll(object sender, EventArgs e)
        {

            int RAMCHANGE = RAM.Value *512;

            label2.Text = "RAM " + RAMCHANGE.ToString();

            if (RAMCHANGE >= 1536)
            {
                label4.Visible = true;
            }
            else
            {
                label4.Visible = false;
            }

        }

        ////////relise if function and client launch////////
        public void button1_Click_1(object sender, EventArgs e)
        {
            //Client1
            if (comboBox1.Text.Equals("ShyCraft 1.5.2"))
            {
                string name = textBox1.Text;                //get values again
                int RAMCHANGE = RAM.Value * 512;
                string launch = "java -Xms" + "1024" + "m -Xmx" + RAMCHANGE + "m -cp " + appdata + "\\." + client1patch + "\\bin"+"\\*" + " -Djava.library.path=" + appdata + "\\." + client1patch + "\\" + "bin" + "\\" + "natives" + " net.minecraft.client.Minecraft " +name;
                //DebugLabel.Text = "java -Xms" + "1024" + "m -Xmx" + RAMCHANGE + "m -cp " + appdata + "\\." + client1patch + "\\bin"+"\\*" + " -Djava.library.path=" + appdata + "\\." + client1patch + "\\" + "bin" + "\\" + "natives" + " net.minecraft.client.Minecraft " +name;
                //.Start("java -Xms" + RAMCHANGE + "m -Xmx" + RAMCHANGE + "m -cp " + appdata + "\\." + client1patch + "\\bin" + "\\*" + " -Djava.library.path=" + appdata + "\\." + client1patch + "\\" + "bin" + "\\" + "natives" + " net.minecraft.client.Minecraft " + name);
                //System.IO.File.WriteAllText(appdata + "writelines.bat", DebugLabel.Text);
                //System.IO.File.WriteAllText(appdata + "writelines.txt", DebugLabel.Text);
                Process.Start("cmd.exe", "/C" + launch);
            }
            //Client2
            if (comboBox1.Text.Equals("notepad"))
            {
                string name = textBox1.Text;                //get values again
                int RAMCHANGE = RAM.Value * 512;
                DebugLabel.Text = "java pause";
                Process.Start(@"java");
                System.IO.File.WriteAllText(appdata + "writelines.bat", DebugLabel.Text);
                System.IO.File.WriteAllText(appdata + "writelines.txt", DebugLabel.Text);
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.java.com/ru/download/manual.jsp");
        }
    }

}
