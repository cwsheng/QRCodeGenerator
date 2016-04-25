using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ThoughtWorks.QRCode.Codec;
using ThoughtWorks.QRCode.Codec.Data;

namespace QRCodeGenerator
{
    public partial class fmQRCode : Form
    {
        public fmQRCode()
        {
            InitializeComponent();
        }

        public Image CreateCode_Choose(string strData, string qrEncoding, string level, int version, int scale)
        {
            QRCodeEncoder qrCodeEncoder = new QRCodeEncoder();
            string encoding = qrEncoding;
            switch (encoding)
            {
                case "Byte":
                    qrCodeEncoder.QRCodeEncodeMode = QRCodeEncoder.ENCODE_MODE.BYTE;
                    break;
                case "AlphaNumeric":
                    qrCodeEncoder.QRCodeEncodeMode = QRCodeEncoder.ENCODE_MODE.ALPHA_NUMERIC;
                    break;
                case "Numeric":
                    qrCodeEncoder.QRCodeEncodeMode = QRCodeEncoder.ENCODE_MODE.NUMERIC;
                    break;
                default:
                    qrCodeEncoder.QRCodeEncodeMode = QRCodeEncoder.ENCODE_MODE.BYTE;
                    break;
            }

            qrCodeEncoder.QRCodeScale = scale;
            qrCodeEncoder.QRCodeVersion = version;
            switch (level)
            {
                case "L":
                    qrCodeEncoder.QRCodeErrorCorrect = QRCodeEncoder.ERROR_CORRECTION.L;
                    break;
                case "M":
                    qrCodeEncoder.QRCodeErrorCorrect = QRCodeEncoder.ERROR_CORRECTION.M;
                    break;
                case "Q":
                    qrCodeEncoder.QRCodeErrorCorrect = QRCodeEncoder.ERROR_CORRECTION.Q;
                    break;
                default:
                    qrCodeEncoder.QRCodeErrorCorrect = QRCodeEncoder.ERROR_CORRECTION.H;
                    break;
            }

            //文字生成图片
            return qrCodeEncoder.Encode(strData);
        }

        /// <summary>
        /// 二维码解码
        /// </summary>
        /// <param name="filePath">图片路径</param>
        /// <returns></returns>
        public string CodeDecoder(Image img)
        {
            string decodedString = string.Empty;
            try
            {
                QRCodeDecoder decoder = new QRCodeDecoder();
                decodedString = decoder.decode(new QRCodeBitmapImage((Bitmap)img));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "异常提示");
            }
            return decodedString;
        }

        private void spBtSave_Click(object sender, EventArgs e)
        {
            if (picQRCode.Image != null)
            {
                string content = CodeDecoder(picQRCode.Image);
                txtQRCodeContent.Text = content;
            }
        }

        private void txtQRCodeContent_EditValueChanged(object sender, EventArgs e)
        {
            dxErrorProvider1.ClearErrors();
            if (string.IsNullOrEmpty(txtQRCodeContent.Text))
            {
                dxErrorProvider1.SetError(txtQRCodeContent, "二维码内容必填");
            }
        }

        private void btnELogo_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            openFdImg.Title = "选择二维码图片";
            if (openFdImg.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                try
                {
                    Image img = Image.FromStream(openFdImg.OpenFile());
                    picQRCode.Image = img;
                    btnELogo.EditValue = openFdImg.SafeFileName;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "异常提示");
                }
            }
        }

        private void spBtGenerator_Click(object sender, EventArgs e)
        {
            dxErrorProvider1.ClearErrors();
            if (string.IsNullOrEmpty(txtQRCodeContent.Text))
            {
                dxErrorProvider1.SetError(txtQRCodeContent, "二维码内容必填");
                return;
            }
#if DEBUG
            System.Diagnostics.Stopwatch stopwatch = new System.Diagnostics.Stopwatch();
            stopwatch.Start();
#endif
            Image img = CreateCode_Choose(txtQRCodeContent.Text, cmbEEncodeMode.Text, cmbEError.Text, (int)spEversion.Value, (int)spEscale.Value);
#if DEBUG
            stopwatch.Stop();
            System.Diagnostics.Debug.WriteLine("生成二维码耗时:" + stopwatch.ElapsedMilliseconds);
#endif
            img = CombinImage(img, @"C:\Users\cba\Desktop\QRCodeGenerator\favicon.ico");
            this.picQRCode.Image = img;
        }

        /// <summary>  
        /// 生成二维码.  
        /// </summary>  
        /// <param name="data">需要添加进去的文本</param>  
        /// <returns></returns>  
        public System.Drawing.Image GCode(String data)
        {
            QRCodeEncoder qrCodeEncoder = new QRCodeEncoder();
            qrCodeEncoder.QRCodeEncodeMode = QRCodeEncoder.ENCODE_MODE.BYTE;
            qrCodeEncoder.QRCodeScale = 5;
            qrCodeEncoder.QRCodeVersion = 7;

            qrCodeEncoder.QRCodeErrorCorrect = QRCodeEncoder.ERROR_CORRECTION.L;
            var pbImg = qrCodeEncoder.Encode(data, System.Text.Encoding.UTF8);
            var width = pbImg.Width / 10;
            var dwidth = width * 2;
            Bitmap bmp = new Bitmap(pbImg.Width + dwidth, pbImg.Height + dwidth);
            Graphics g = Graphics.FromImage(bmp);
            var c = System.Drawing.Color.White;
            g.FillRectangle(new SolidBrush(c), 0, 0, pbImg.Width + dwidth, pbImg.Height + dwidth);
            g.DrawImage(pbImg, width, width);
            g.Dispose();
            return bmp;
        }

        /// <summary>  
        /// 调用此函数后使此两种图片合并，类似相册，有个  
        /// 背景图，中间贴自己的目标图片  
        /// </summary>  
        /// <param name="sourceImg">粘贴的源图片</param>  
        /// <param name="destImg">粘贴的目标图片</param>  
        public static System.Drawing.Image CombinImage(System.Drawing.Image imgBack, string destImg)
        {

            System.Drawing.Image img = System.Drawing.Image.FromFile(destImg);        //照片图片    
            if (img.Height != 32 || img.Width != 32)
            {
                img = KiResizeImage(img, 32, 32, 0);
            }
            Graphics g = Graphics.FromImage(imgBack);

            g.DrawImage(imgBack, 0, 0, imgBack.Width, imgBack.Height);      //g.DrawImage(imgBack, 0, 0, 相框宽, 相框高);   

            //g.FillRectangle(System.Drawing.Brushes.White, imgBack.Width / 2 - img.Width / 2 - 1, imgBack.Width / 2 - img.Width / 2 - 1,1,1);//相片四周刷一层黑色边框  
            //g.DrawImage(img, 照片与相框的左边距, 照片与相框的上边距, 照片宽, 照片高);  

            g.DrawImage(img, imgBack.Width / 2 - img.Width / 2, imgBack.Width / 2 - img.Width / 2, img.Width, img.Height);
            GC.Collect();
            return imgBack;
        }

        /// <summary>  
        /// Resize图片  
        /// </summary>  
        /// <param name="bmp">原始Bitmap</param>  
        /// <param name="newW">新的宽度</param>  
        /// <param name="newH">新的高度</param>  
        /// <param name="Mode">保留着，暂时未用</param>  
        /// <returns>处理以后的图片</returns>  
        public static System.Drawing.Image KiResizeImage(System.Drawing.Image bmp, int newW, int newH, int Mode)
        {
            try
            {
                System.Drawing.Image b = new Bitmap(newW, newH);
                Graphics g = Graphics.FromImage(b);

                // 插值算法的质量  
                g.InterpolationMode = InterpolationMode.HighQualityBicubic;

                g.DrawImage(bmp, new Rectangle(0, 0, newW, newH), new Rectangle(0, 0, bmp.Width, bmp.Height), GraphicsUnit.Pixel);
                g.Dispose();

                return b;
            }
            catch
            {
                return null;
            }
        }
    }
}
