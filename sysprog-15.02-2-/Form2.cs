using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace sysprog_15._02_2_
{
    public partial class Form2 : Form
    {
        private string captchaText;
        public Form2()
        {
            InitializeComponent();
            captchaText = GenerateCaptcha();
            captchalbl.Text = captchaText;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string userInput = captchatb.Text;

            if (userInput.ToLower() == captchaText.ToLower())
            {
                MessageBox.Show("Капча введена верно");
                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                MessageBox.Show("Капча введена неверно");
                captchatb.Text = "";
                captchaText = GenerateCaptcha();
                captchalbl.Text = captchaText;
            }
        }

        private void captcha_Click(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            Pen pen = new Pen(Color.White);
            pen.Width = 4;

            SizeF textSize = g.MeasureString(captchalbl.Text, captchalbl.Font);

            float x1 = 0;
            float y1 = captchalbl.Height / 2;
            float x2 = captchalbl.Width;
            float y2 = captchalbl.Height / 2;

            g.DrawLine(pen, x1, y1, x2, y2);
        }

        private string GenerateCaptcha()
        {
            Random random = new Random();
            const string chars = "QAZWSXEDCRFVTGBYHNUJMIK,OL.P/;[']qazwsxedcrfvtgbyhnujmik,ol.p1234567890";
            return new string(Enumerable.Repeat(chars, 6).Select(s => s[random.Next(s.Length)]).ToArray());
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            captchalbl.Text = GenerateCaptcha();
            captchalbl.Font = new Font(captchalbl.Font.FontFamily, captchalbl.Font.Size + 10, FontStyle.Bold);
            captchalbl.ForeColor = Color.Red;
            captchalbl.BackColor = Color.Black;
            captchalbl.TextAlign = ContentAlignment.MiddleCenter;
            captchalbl.AutoSize = false;
            captchalbl.Size = new Size(200, 50);
            captchalbl.Paint += new PaintEventHandler(captcha_Click);
        }

        private void captchalbl_Click(object sender, EventArgs e)
        {

        }
    }
}
