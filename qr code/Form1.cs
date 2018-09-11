using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MessagingToolkit.QRCode.Codec;
using System.Drawing;

namespace qr_code
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private Image qrCreate(string Data, int qrCode)
        {
            QRCodeEncoder qr = new QRCodeEncoder();
            qr.QRCodeEncodeMode = QRCodeEncoder.ENCODE_MODE.BYTE;
            qr.QRCodeErrorCorrect = QRCodeEncoder.ERROR_CORRECTION.L;
            qr.QRCodeVersion = qrCode;

            Bitmap bm = qr.Encode(Data);
            return bm;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = qrCreate(textBox1.Text, 4);
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                button1.PerformClick();
        }
    }

}
