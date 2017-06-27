using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.IO;
using System.Text.RegularExpressions;

namespace GiaiToan
{
    public partial class Form1 : Form
    {
        public static string result = "";
        public static string status = "";
        public static string error = "";
        public static string inputs="";
        public static string outputs = "";
        public static int flg=0;
        List<string> Item = new List<string>();
        public Form1()
        {
            InitializeComponent();
            _select();
            button2.Visible = false;
            pic_giai.Image = Image.FromFile("1.png");
            output_box.Font = new Font("Arial", 9);
            output_box.Enabled= true;
            hd.Image = Image.FromFile("hd2.jpg");
            MapleEngine.MapleCallbacks cb;
            IntPtr kv;
            byte[] err = new byte[2048];
            String[] argv = new String[2];
            argv[0] = "maple";
            argv[1] = "-A2";
            cb.textCallBack = cbText;
            cb.errorCallBack = cbError;
            cb.statusCallBack = cbStatus;
            cb.readlineCallBack = null;
            cb.redirectCallBack = null;
            cb.streamCallBack = null;
            cb.queryInterrupt = null;
            cb.callbackCallBack = null;

            try
            {
                kv = MapleEngine.StartMaple(2, argv, ref cb, IntPtr.Zero, IntPtr.Zero, err);
            }
            catch (DllNotFoundException e)
            {
                System.Windows.Forms.MessageBox.Show(e.ToString());
                return;
            }
            catch (EntryPointNotFoundException e)
            {
                System.Windows.Forms.MessageBox.Show(e.ToString());
                return;
            }
            try
            {
                MapleEngine.EvalMapleStatement(kv, Encoding.ASCII.GetBytes("with(abc):"));
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.ToString());
                return;
            }

        }
        public static void cbStatus(IntPtr data, IntPtr used, IntPtr alloc, double time)
        {

        }          
        public void cbText(IntPtr data, int tag, IntPtr output)
        {
            output_box.Text += Marshal.PtrToStringAnsi(output)+Environment.NewLine;

        }
        public void kqText(IntPtr data, int tag, IntPtr output)
        {
            output_box.Text += Marshal.PtrToStringAnsi(output) + Environment.NewLine;
        }
        public static void cbError(IntPtr data, IntPtr offset, IntPtr msg)
        {
            string s = Marshal.PtrToStringAnsi(msg);
        }

        private void input_box_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Convert.ToInt32(e.KeyChar) == 13)
            {
                inputs = input_box.Text;
                string sr = comboBox1.GetItemText(this.comboBox1.SelectedItem);
                if (sr == "GiaiPT bac 2,bac 3")
                {
                    giaiPT();
                    outputs = output_box.Text;
                    try
                    {
                        resurl();
                        input_box.Text = inputs;
                        string[] tmp_out = outputs.Split('!');
                        output_box.Text = tmp_out[0];
                        pic_giai.Image = Image.FromFile("1.png");
                        button1.BackColor = Color.White;
                    }
                    catch (Exception)
                    {
                        output_box.Text = "Khong the giai phuong trinh!";
                        input_box.Text = inputs;
                    }
                }
                else
                    if (sr == "BienLuanPT bac 1")
                    {
                        blPT1();
                        outputs = output_box.Text;
                        //MessageBox.Show(outputs);
                        try
                        {
                            resurl();
                            input_box.Text = inputs;
                            string[] tmp_out = outputs.Split('!');
                            output_box.Text = tmp_out[0];
                            pic_giai.Image = Image.FromFile("1.png");
                            button1.BackColor = Color.White;
                        }
                        catch (Exception ex)
                        {
                            output_box.Text = "Khong the giai phuong trinh!";
                            input_box.Text = inputs;
                        }
                    }
                    else
                        if (sr == "BienLuanPT bac 2")
                        {
                            blPT2();
                            outputs = output_box.Text;
                            //MessageBox.Show(outputs);
                            try
                            {
                                resurl();
                                input_box.Text = inputs;
                                string[] tmp_out = outputs.Split('!');
                                output_box.Text = tmp_out[0];
                                pic_giai.Image = Image.FromFile("1.png");
                                button1.BackColor = Color.White;
                            }
                            catch (Exception ex)
                            {
                                output_box.Text = "Khong the giai phuong trinh!";
                                // System.Windows.Forms.MessageBox.Show(ex.ToString());
                                input_box.Text = inputs;
                            }
                        }
                if (sr == "" || sr == null) { MessageBox.Show("Chon dang toan!"); }
            }
        }
        private string GetGifFilePath()
        {
            return Path.Combine(Path.GetTempPath(), "Eq2ImgWinForms.gif");
        }
        #region Xuat cong thuc
        private void WriteEquation(string equation, PictureBox x, string namepic)
        {
            if (x.Image != null)
                x.Image.Dispose();

            if (equation.Length > 0)
            {
                string tempGifFilePath = namepic+".gif";//GetGifFilePath();
                try
                {
                    NativeMethods.CreateGifFromEq(equation, tempGifFilePath);
                    x.Image = Image.FromFile(tempGifFilePath);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            else
            {
                x.Image = Image.FromFile(Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), "emptyeq.jpg"));
            };

        }
        #endregion
        public void giaiPT()
        {
            output_box.Text = "";
            MapleEngine.MapleCallbacks cb;
            byte[] err = new byte[2048];
            IntPtr kv;

            String[] argv = new String[2];
            argv[0] = "maple";
            argv[1] = "-A2";

            cb.textCallBack = cbText;
            cb.errorCallBack = cbError;
            cb.statusCallBack = cbStatus;
            cb.readlineCallBack = null;
            cb.redirectCallBack = null;
            cb.streamCallBack = null;
            cb.queryInterrupt = null;
            cb.callbackCallBack = null;
            try
            {
                kv = MapleEngine.StartMaple(2, argv, ref cb, IntPtr.Zero, IntPtr.Zero, err);
                try
                {
                    //sử dụng hàm Tong trong package TEST
                    String expr = "check(";
                    expr += input_box.Text;
                    expr += ");";
                    string t;
                    t = expr.ToLower();
                    //MessageBox.Show(t);
                    IntPtr val = MapleEngine.EvalMapleStatement(kv, Encoding.ASCII.GetBytes(expr));

                }
                catch (Exception)
                {
                    MessageBox.Show("Không thể load Maple", "Lỗi", MessageBoxButtons.OK);
                }
            }
            catch (Exception)
            {
            }  
        }
        public void blPT1()
        {
            output_box.Text = "";
            MapleEngine.MapleCallbacks cb;
            byte[] err = new byte[2048];
            IntPtr kv;

            String[] argv = new String[2];
            argv[0] = "maple";
            argv[1] = "-A2";

            cb.textCallBack = cbText;
            cb.errorCallBack = cbError;
            cb.statusCallBack = cbStatus;
            cb.readlineCallBack = null;
            cb.redirectCallBack = null;
            cb.streamCallBack = null;
            cb.queryInterrupt = null;
            cb.callbackCallBack = null;
            try
            {
                kv = MapleEngine.StartMaple(2, argv, ref cb, IntPtr.Zero, IntPtr.Zero, err);
                try
                {
                    //sử dụng hàm Tong trong package TEST
                    String expr = "blpt1(";
                    expr += input_box.Text;
                    expr += ",x);";
                    string t;
                    t = expr.ToLower();
                    //MessageBox.Show(t);
                    IntPtr val = MapleEngine.EvalMapleStatement(kv, Encoding.ASCII.GetBytes(expr));

                }
                catch (Exception)
                {
                    MessageBox.Show("Không thể load Maple", "Lỗi", MessageBoxButtons.OK);
                }
            }
            catch (Exception)
            {
            }
        }
        public void blPT2()
        {
            output_box.Text = "";
            MapleEngine.MapleCallbacks cb;
            byte[] err = new byte[2048];
            IntPtr kv;

            String[] argv = new String[2];
            argv[0] = "maple";
            argv[1] = "-A2";

            cb.textCallBack = cbText;
            cb.errorCallBack = cbError;
            cb.statusCallBack = cbStatus;
            cb.readlineCallBack = null;
            cb.redirectCallBack = null;
            cb.streamCallBack = null;
            cb.queryInterrupt = null;
            cb.callbackCallBack = null;
            try
            {
                kv = MapleEngine.StartMaple(2, argv, ref cb, IntPtr.Zero, IntPtr.Zero, err);
                try
                {
                    //sử dụng hàm Tong trong package TEST
                    String expr = "blpt2(";
                    expr += input_box.Text;
                    expr += ",x);";
                    string t;
                    t = expr.ToLower();
                    //MessageBox.Show(t);
                    IntPtr val = MapleEngine.EvalMapleStatement(kv, Encoding.ASCII.GetBytes(expr));

                }
                catch (Exception)
                {
                    MessageBox.Show("Không thể load Maple", "Lỗi", MessageBoxButtons.OK);
                }
            }
            catch (Exception)
            {
            }
        }
        public void _delete_(string input, ref string ou){
            //string input="";
            string strPattern = @"[\s]+";
            Regex rgx = new Regex(strPattern);
            ou = rgx.Replace(input,"");
            //MessageBox.Show(Ouput);
        }
        public void _changeLatex()
        {
            output_box.Text = "";
            MapleEngine.MapleCallbacks cb;
            byte[] err = new byte[2048];
            IntPtr kv;

            String[] argv = new String[2];
            argv[0] = "maple";
            argv[1] = "-A2";

            cb.textCallBack = cbText;
            cb.errorCallBack = cbError;
            cb.statusCallBack = cbStatus;
            cb.readlineCallBack = null;
            cb.redirectCallBack = null;
            cb.streamCallBack = null;
            cb.queryInterrupt = null;
            cb.callbackCallBack = null;

            try
            {
                kv = MapleEngine.StartMaple(2, argv, ref cb, IntPtr.Zero, IntPtr.Zero, err);
                try
                {
                    String expr = "change(";
                    expr += input_box.Text;
                    expr += ");";
                    string t;
                    t = expr.ToLower();
                    IntPtr val = MapleEngine.EvalMapleStatement(kv, Encoding.ASCII.GetBytes(t));
                }
                catch (Exception)
                {
                    MessageBox.Show("Không thể load Maple", "Lỗi", MessageBoxButtons.OK);
                }
            }
            catch (Exception)
            {
            }
        }
        private void pic_giai_Click(object sender, EventArgs e)
        {
            inputs = input_box.Text;
            string sr = comboBox1.GetItemText(this.comboBox1.SelectedItem);
            if (flg == 1)
            {
                giaiPT();
                outputs = output_box.Text;
                //MessageBox.Show(outputs);
                try
                {
                    resurl();
                    input_box.Text = inputs;
                    string[] tmp_out = outputs.Split('!');
                    output_box.Text = tmp_out[0];
                    pic_giai.Image = Image.FromFile("1.png");
                    button1.BackColor = Color.White;
                }
                catch (Exception)
                {
                    output_box.Text = "Khong the giai phuong trinh!";
                    input_box.Text = inputs;
                }
            }

            if (flg == 2)
            {
                blPT1();
                outputs = output_box.Text;
                //MessageBox.Show(outputs);
                try
                {
                    resurl();
                    input_box.Text = inputs;
                    string[] tmp_out = outputs.Split('!');
                    output_box.Text = tmp_out[0];
                    pic_giai.Image = Image.FromFile("1.png");
                    button1.BackColor = Color.White;
                }
                catch (Exception ex)
                {
                    //output_box.Text =
                    output_box.Text = "Khong the giai phuong trinh!";
                    System.Windows.Forms.MessageBox.Show(ex.ToString());
                    input_box.Text = inputs;
                }
            }

            if (flg == 3)
            {
                blPT2();
                outputs = output_box.Text;
                //MessageBox.Show(outputs);
                try
                {
                    resurl();
                    input_box.Text = inputs;
                    string[] tmp_out = outputs.Split('!');
                    output_box.Text = tmp_out[0];
                    pic_giai.Image = Image.FromFile("1.png");
                    button1.BackColor = Color.White;
                }
                catch (Exception ex)
                {
                    output_box.Text = "Khong the giai phuong trinh!";
                   // System.Windows.Forms.MessageBox.Show(ex.ToString());
                    input_box.Text = inputs;
                }
            }
            if (sr == "" || sr==null) { MessageBox.Show("Chon dang toan!"); }
            
        }
        public void _checkRe(string n, string nghiem)
        {

        }
        public void resurl()
        {
            string s = output_box.Text;
            string[] arr = s.Split('!');
            string[] _kq = arr[1].Split(',');
            int count = _kq.Length;
            string namepic = "kq";
            if (count==1)
            {
                string tmp = _kq[0];
                input_box.Text = tmp;
                _changeLatex();
                namepic = "kq1";
                tmp = output_box.Text;
                WriteEquation(tmp, pictureBox1, namepic);
                pictureBox3.Image = Image.FromFile("empty.jpg");
                pictureBox2.Image = Image.FromFile("empty.jpg");
            }
            if (count == 2)
            {
                string tmp = _kq[0];
                input_box.Text = tmp;
                _changeLatex();
                namepic = "kq1";
                tmp = output_box.Text;
                WriteEquation(tmp, pictureBox1, namepic);

                tmp = _kq[1];
                input_box.Text = tmp;
                _changeLatex();
                namepic = "kq2";
                tmp = output_box.Text;
                WriteEquation(tmp, pictureBox2, namepic);
                pictureBox3.Image = Image.FromFile("empty.jpg");

            }
            if (count == 3)
            {
                string tmp = _kq[0];
                input_box.Text = tmp;
                //checkRe
                _changeLatex();
                namepic = "kq1";
                tmp = output_box.Text;
                WriteEquation(tmp, pictureBox1, namepic);

                tmp = _kq[1];
                input_box.Text = tmp;
                _changeLatex();
                namepic = "kq2";
                tmp = output_box.Text;
                WriteEquation(tmp, pictureBox2, namepic);

                tmp = _kq[2];
                input_box.Text = tmp;
                _changeLatex();
                namepic = "kq3";
                tmp = output_box.Text;
                WriteEquation(tmp, pictureBox3, namepic);
            }
;
        }

        private void input_box_TextChanged(object sender, EventArgs e)
        {
            if (input_box.Text!="")
            pic_giai.Image = Image.FromFile("wait.png");
            else pic_giai.Image = Image.FromFile("1.png");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MapleEngine.MapleCallbacks cb;
            IntPtr kv;
            byte[] err = new byte[2048];
            String[] argv = new String[2];
            argv[0] = "maple";
            argv[1] = "-A2";
            cb.textCallBack = cbText;
            cb.errorCallBack = cbError;
            cb.statusCallBack = cbStatus;
            cb.readlineCallBack = null;
            cb.redirectCallBack = null;
            cb.streamCallBack = null;
            cb.queryInterrupt = null;
            cb.callbackCallBack = null;

            try
            {
                kv = MapleEngine.StartMaple(2, argv, ref cb, IntPtr.Zero, IntPtr.Zero, err);
            }
            catch (DllNotFoundException xe)
            {
                System.Windows.Forms.MessageBox.Show(xe.ToString());
                return;
            }
            catch (EntryPointNotFoundException xe)
            {
                System.Windows.Forms.MessageBox.Show(xe.ToString());
                return;
            }
            try
            {
                MapleEngine.EvalMapleStatement(kv, Encoding.ASCII.GetBytes("with(abc):"));
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.ToString());
                return;
            }
        }

        private void hd_Click(object sender, EventArgs e)
        {
            huongdan hd = new huongdan();
            hd.Show();
        }
        public void _select()
        {
            //comboBox1.GetItemText(this.comboBox1.SelectedItem);
            comboBox1.Items.Add("GiaiPT bac 2,bac 3");
            comboBox1.Items.Add("BienLuanPT bac 1");
            comboBox1.Items.Add("BienLuanPT bac 2");
            info_sl.Visible = false;
            
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string s="";
            _delete_(input_box.Text, ref s);
            input_box.Text = s;
            button1.BackColor = Color.Aqua;
            info_check.Visible = false;
            output_box.Text = "";
            pictureBox1.Image = Image.FromFile("empty.jpg");
            pictureBox2.Image = Image.FromFile("empty.jpg");
            pictureBox3.Image = Image.FromFile("empty.jpg");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string s = comboBox1.GetItemText(this.comboBox1.SelectedItem);
            if (s=="GiaiPT bac 2,bac 3")
                flg=1;
                if(s=="BienLuanPT bac 1")
                    flg=2;
                if (s == "BienLuanPT bac 2")
                    flg = 3;
            //MessageBox.Show(s);
        }

        private void comboBox1_MouseMove(object sender, MouseEventArgs e)
        {
            //info_sl.Visible = true;
            //info_sl.Text = comboBox1.GetItemText(this.comboBox1.SelectedItem);
        }

        private void comboBox1_MouseLeave(object sender, EventArgs e)
        {
           /// info_sl.Visible = false;
        }

        private void button1_MouseMove(object sender, MouseEventArgs e)
        {
           // info_check.Visible = true;
           // info_check.Text = "Xoa khoang trang (neu co) trong bieu thuc!";

        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            //info_check.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            blPT2();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            string s="(m^2-1)*x^2-x = 2*m-3";
            input_box.Text = s;
            blPT2();

        }
    }
}
