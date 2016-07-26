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
using System.Net;
using System.IO;

namespace WindowsFormsApplication3
{
    public partial class Form1 : Form
    {
        string[] pony1 = { "YAY", "YAY!!!!", "Hello!", "20 percent cooler" }; //Pony
        static int text1 = 0;
        int RAMCHANGE = 512;                                                  //RAMCHANGE int for RAMBAR
        string client = "client name";                                        //client string for client selection
        string name = "name";                                                 //name string for name selection
        string appdata = Environment.GetEnvironmentVariable("APPDATA");       //appdata string for get appdata enviroment
        string LauncherWorkFolder = Environment.GetEnvironmentVariable("APPDATA") + "\\" + "ShyLauncher";

        //client1 values
        string client1patch = "ShyCraft";                                     //client1patch string for get client1 patch
        string client1URL = "www.client1URL.com";                             //client1URL string for get client1 URL
        string client1update = "client1.zip";                                 //client1update string for get client1 zip
        string client1versiontxt = "version.txt";                             //client1versiontxt string for get client1 version

        //client2 values
        string client2patch = "minecraft";                                    //client2patch string for get client2 patch
        string client2URL = "www.client2URL.com";                             //client2URL string for get client2 zip
        string client2update = "client2.zip";                                 //client2update string for get client2 zip
        string client2versiontxt = "version.txt";                             //client2versiontxt string for get client2 version

        //client3 values
        string client3patch = "minecraft";                                    //client3patch string for get client3 patch
        string client3URL = "www.client2URL.com";                             //client3URL string for get client3 zip
        string client3update = "client2.zip";                                 //client3update string for get client3 zip
        string client3versiontxt = "version.txt";                             //client3versiontxt string for get client3 version
        string client3fullpatch = Environment.GetEnvironmentVariable("APPDATA") + "\\" + @".minecraft";       //appdata string for get appdata enviroment

        //client3 values
        string client4patch = "minecraft";                                    //client4patch string for get client4 patch
        string client4URL = "www.client2URL.com";                             //client4URL string for get client4 zip
        string client4update = "client2.zip";                                 //client4update string for get client4 zip
        string client4versiontxt = "version.txt";                             //client4versiontxt string for get client4 version
        string client4fullpatch = Environment.GetEnvironmentVariable("APPDATA") + "\\" + @".minecraft";       //appdata string for get appdata enviroment



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
            //Client1 launch
            if (comboBox1.Text.Equals("ShyCraft 1.5.2"))
            {
                string name = textBox1.Text;                //get values again
                int RAMCHANGE = RAM.Value * 512;
                string launch = "java -Xms" + "1024" + "m -Xmx" + RAMCHANGE + "m -cp " + appdata + "\\." + client1patch + "\\bin"+"\\*" + " -Djava.library.path=" + appdata + "\\." + client1patch + "\\" + "bin" + "\\" + "natives" + " net.minecraft.client.Minecraft " +name;
                Process.Start("cmd.exe", "/C" + launch);
            }
            //Client2 launch
            if (comboBox1.Text.Equals("Classic 1.5.2"))
            {
                string name = textBox1.Text;                //get values again
                int RAMCHANGE = RAM.Value * 512;
                string launch = "java -Xms" + "512" + "m -Xmx" + RAMCHANGE + "m -cp " + appdata + "\\." + client2patch + "\\bin" + "\\*" + " -Djava.library.path=" + appdata + "\\." + client2patch + "\\" + "bin" + "\\" + "natives" + " net.minecraft.client.Minecraft " + name;
                Process.Start("cmd.exe", "/C" + launch);
            }
            //Client3 launch
            if (comboBox1.Text.Equals("ShyCraft 1.6.4"))
            {
                string name = textBox1.Text;                //get values again
                int RAMCHANGE = RAM.Value * 512;

                string launch = "java.exe" + " -Xmx" + RAMCHANGE + "M" + @" -Djava.library.path=" + client3fullpatch + @"\versions\ShyCraft\natives" + @" -cp " +


                    client3fullpatch + @"\libraries\net\minecraftforge\minecraftforge\9.11.1.1345\minecraftforge-9.11.1.1345.jar;" +
                    client3fullpatch + @"\libraries\net\minecraft\launchwrapper\1.8\launchwrapper-1.8.jar;" +
                    client3fullpatch + @"\libraries\org\ow2\asm\asm-all\4.1\asm-all-4.1.jar;" +
                    client3fullpatch + @"\libraries\org\scala-lang\scala-library\2.10.2\scala-library-2.10.2.jar;" +
                    client3fullpatch + @"\libraries\org\scala-lang\scala-compiler\2.10.2\scala-compiler-2.10.2.jar;" +
                    client3fullpatch + @"\libraries\lzma\lzma\0.0.1\lzma-0.0.1.jar;" +
                    client3fullpatch + @"\libraries\net\sf\jopt-simple\jopt-simple\4.5\jopt-simple-4.5.jar;" +
                    client3fullpatch + @"\libraries\com\paulscode\codecjorbis\20101023\codecjorbis-20101023.jar;" +
                    client3fullpatch + @"\libraries\com\paulscode\codecwav\20101023\codecwav-20101023.jar;" +
                    client3fullpatch + @"\libraries\com\paulscode\libraryjavasound\20101123\libraryjavasound-20101123.jar;" +
                    client3fullpatch + @"\libraries\com\paulscode\librarylwjglopenal\20100824\librarylwjglopenal-20100824.jar;" +
                    client3fullpatch + @"\libraries\com\paulscode\soundsystem\20120107\soundsystem-20120107.jar;" +
                    client3fullpatch + @"\libraries\argo\argo\2.25_fixed\argo-2.25_fixed.jar;" +
                    client3fullpatch + @"\libraries\org\bouncycastle\bcprov-jdk15on\1.47\bcprov-jdk15on-1.47.jar;" +
                    client3fullpatch + @"\libraries\com\google\guava\guava\14.0\guava-14.0.jar;" +
                    client3fullpatch + @"\libraries\org\apache\commons\commons-lang3\3.1\commons-lang3-3.1.jar;" +
                    client3fullpatch + @"\libraries\commons-io\commons-io\2.4\commons-io-2.4.jar;" +
                    client3fullpatch + @"\libraries\net\java\jinput\jinput\2.0.5\jinput-2.0.5.jar;" +
                    client3fullpatch + @"\libraries\net\java\jutils\jutils\1.0.0\jutils-1.0.0.jar;" +
                    client3fullpatch + @"\libraries\com\google\code\gson\gson\2.2.2\gson-2.2.2.jar;" +
                    client3fullpatch + @"\libraries\org\lwjgl\lwjgl\lwjgl\2.9.0\lwjgl-2.9.0.jar;" +
                    client3fullpatch + @"\libraries\org\lwjgl\lwjgl\lwjgl_util\2.9.0\lwjgl_util-2.9.0.jar;" +
                    client3fullpatch + @"\versions\ShyCraft\ShyCraft.jar" + @" -Dfml.ignoreInvalidMinecraftCertificates=true -Dfml.ignorePatchDiscrepancies=true -XX:+UseConcMarkSweepGC -XX:+CMSIncrementalMode -XX:-UseAdaptiveSizePolicy -Xmn128M net.minecraft.launchwrapper.Launch --tweakClass cpw.mods.fml.common.launcher.FMLTweaker --username " + name + @" --gameDir C:\Users\pavel\AppData\Roaming\.minecraft --assetsDir C:\Users\pavel\AppData\Roaming\.minecraft\assets";


                Process.Start("cmd.exe", "/C" + launch);

                //System.IO.File.Create(LauncherWorkFolder + @"\" + "debug.txt");
                File.WriteAllText(appdata + @"\" + "debugFML.txt", launch);
                //System.IO.File.Create(LauncherWorkFolder);
                System.IO.File.WriteAllText(appdata + @"\" + "debugFML.bat", launch);
            }

            if (comboBox1.Text.Equals("ShyCraft 1.7.10"))
            {
                string name = textBox1.Text;                //get values again
                int RAMCHANGE = RAM.Value * 512;

                string launch = @"java.exe" + " -Xmx" + RAMCHANGE + "M" + " -Djava.library.path=" + client4fullpatch + @"\versions\ShyCraft\natives" + @" -cp " +
                    client4fullpatch + @"\libraries\net\minecraftforge\forge\1.7.10-10.13.4.1614-1.7.10\forge-1.7.10-10.13.4.1614-1.7.10.jar;" +
                    client4fullpatch + @"\libraries\net\minecraft\launchwrapper\1.12\launchwrapper-1.12.jar;" +
                    client4fullpatch + @"\libraries\org\ow2\asm\asm-all\5.0.3\asm-all-5.0.3.jar;" +
                    client4fullpatch + @"\libraries\com\typesafe\akka\akka-actor_2.11\2.3.3\akka-actor_2.11-2.3.3.jar;" +
                    client4fullpatch + @"\libraries\com\typesafe\config\1.2.1\config-1.2.1.jar;" +
                    client4fullpatch + @"\libraries\org\scala-lang\scala-actors-migration_2.11\1.1.0\scala-actors-migration_2.11-1.1.0.jar;" +
                    client4fullpatch + @"\libraries\org\scala-lang\scala-compiler\2.11.1\scala-compiler-2.11.1.jar;" +
                    client4fullpatch + @"\libraries\org\scala-lang\plugins\scala-continuations-library_2.11\1.0.2\scala-continuations-library_2.11-1.0.2.jar;" +
                    client4fullpatch + @"\libraries\org\scala-lang\plugins\scala-continuations-plugin_2.11.1\1.0.2\scala-continuations-plugin_2.11.1-1.0.2.jar;" +
                    client4fullpatch + @"\libraries\org\scala-lang\scala-library\2.11.1\scala-library-2.11.1.jar;" +
                    client4fullpatch + @"\libraries\org\scala-lang\scala-parser-combinators_2.11\1.0.1\scala-parser-combinators_2.11-1.0.1.jar;" +
                    client4fullpatch + @"\libraries\org\scala-lang\scala-reflect\2.11.1\scala-reflect-2.11.1.jar;" +
                    client4fullpatch + @"\libraries\org\scala-lang\scala-swing_2.11\1.0.1\scala-swing_2.11-1.0.1.jar;" +
                    client4fullpatch + @"\libraries\org\scala-lang\scala-xml_2.11\1.0.2\scala-xml_2.11-1.0.2.jar;" +
                    client4fullpatch + @"\libraries\lzma\lzma\0.0.1\lzma-0.0.1.jar;" +
                    client4fullpatch + @"\libraries\net\sf\jopt-simple\jopt-simple\4.5\jopt-simple-4.5.jar;" +
                    client4fullpatch + @"\libraries\com\google\guava\guava\17.0\guava-17.0.jar;" +
                    client4fullpatch + @"\libraries\org\apache\commons\commons-lang3\3.3.2\commons-lang3-3.3.2.jar;" +
                    client4fullpatch + @"\libraries\com\mojang\netty\1.6\netty-1.6.jar;" +
                    client4fullpatch + @"\libraries\com\mojang\realms\1.3.5\realms-1.3.5.jar;" +
                    client4fullpatch + @"\libraries\org\apache\commons\commons-compress\1.8.1\commons-compress-1.8.1.jar;" +
                    client4fullpatch + @"\libraries\org\apache\httpcomponents\httpclient\4.3.3\httpclient-4.3.3.jar;" +
                    client4fullpatch + @"\libraries\commons-logging\commons-logging\1.1.3\commons-logging-1.1.3.jar;" +
                    client4fullpatch + @"\libraries\org\apache\httpcomponents\httpcore\4.3.2\httpcore-4.3.2.jar;" +
                    client4fullpatch + @"\libraries\java3d\vecmath\1.3.1\vecmath-1.3.1.jar;" +
                    client4fullpatch + @"\libraries\net\sf\trove4j\trove4j\3.0.3\trove4j-3.0.3.jar;" +
                    client4fullpatch + @"\libraries\com\ibm\icu\icu4j-core-mojang\51.2\icu4j-core-mojang-51.2.jar;" +
                    client4fullpatch + @"\libraries\net\sf\jopt-simple\jopt-simple\4.5\jopt-simple-4.5.jar;" +
                    client4fullpatch + @"\libraries\com\paulscode\codecjorbis\20101023\codecjorbis-20101023.jar;" +
                    client4fullpatch + @"\libraries\com\paulscode\codecwav\20101023\codecwav-20101023.jar;" +
                    client4fullpatch + @"\libraries\com\paulscode\libraryjavasound\20101123\libraryjavasound-20101123.jar;" +
                    client4fullpatch + @"\libraries\com\paulscode\librarylwjglopenal\20100824\librarylwjglopenal-20100824.jar;" +
                    client4fullpatch + @"\libraries\com\paulscode\soundsystem\20120107\soundsystem-20120107.jar;" +
                    client4fullpatch + @"\libraries\io\netty\netty-all\4.0.10.Final\netty-all-4.0.10.Final.jar;" +
                    client4fullpatch + @"\libraries\com\google\guava\guava\15.0\guava-15.0.jar;" +
                    client4fullpatch + @"\libraries\org\apache\commons\commons-lang3\3.1\commons-lang3-3.1.jar;" +
                    client4fullpatch + @"\libraries\commons-io\commons-io\2.4\commons-io-2.4.jar;" +
                    client4fullpatch + @"\libraries\commons-codec\commons-codec\1.9\commons-codec-1.9.jar;" +
                    client4fullpatch + @"\libraries\net\java\jinput\jinput\2.0.5\jinput-2.0.5.jar;" +
                    client4fullpatch + @"\libraries\net\java\jutils\jutils\1.0.0\jutils-1.0.0.jar;" +
                    client4fullpatch + @"\libraries\com\google\code\gson\gson\2.2.4\gson-2.2.4.jar;" +
                    client4fullpatch + @"\libraries\com\mojang\authlib\1.5.21\authlib-1.5.21.jar;" +
                    client4fullpatch + @"\libraries\org\apache\logging\log4j\log4j-api\2.0-beta9\log4j-api-2.0-beta9.jar;" +
                    client4fullpatch + @"\libraries\org\apache\logging\log4j\log4j-core\2.0-beta9\log4j-core-2.0-beta9.jar;" +
                    client4fullpatch + @"\libraries\org\lwjgl\lwjgl\lwjgl\2.9.1\lwjgl-2.9.1.jar;" +
                    client4fullpatch + @"\libraries\org\lwjgl\lwjgl\lwjgl_util\2.9.1\lwjgl_util-2.9.1.jar;" +
                    client4fullpatch + @"\libraries\tv\twitch\twitch\5.16\twitch-5.16.jar;" +
                    client4fullpatch + @"\versions\ShyCraft\ShyCraft.jar -Dfml.ignoreInvalidMinecraftCertificates=true -Dfml.ignorePatchDiscrepancies=true -XX:+UseConcMarkSweepGC -XX:+CMSIncrementalMode -XX:-UseAdaptiveSizePolicy -Xmn128M net.minecraft.launchwrapper.Launch" +
                    @" --username " + name + @" --version ShyCraft" + @" --gameDir " + client4fullpatch + @" --assetsDir " + client4fullpatch + @"\assets\ --assetIndex 1.7.10 --uuid 00000000-0000-0000-0000-000000000000 --accessToken null --userProperties [] --userType legacy --tweakClass cpw.mods.fml.common.launcher.FMLTweaker --width 925 --height 530";

                pictureBox2.Visible = true;

                Process.Start("cmd.exe", "/C" + launch);

                //System.IO.File.Create(LauncherWorkFolder + @"\" + "debug.txt");
                //File.WriteAllText(appdata + @"\" + "debugFML.txt", launch);
                //System.IO.File.Create(LauncherWorkFolder);
                //System.IO.File.WriteAllText(appdata + @"\" + "debugFML.bat", launch);
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.java.com/ru/download/manual.jsp");
        }

        ////////download client functions////////

        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text.Equals("ShyCraft 1.5.2"))
            {
                DebugLabel.Text = LauncherWorkFolder;
                //using (WebClient DownloadClient1 = new WebClient())
                {
                    //DownloadClient1.DownloadProgressChanged += wc_DownloadProgressChanged;                             //for download bar progress change
                    //DownloadClient1.DownloadFileAsync(new System.Uri(""),
                    //"");
                }

            }
        }
    }

}
