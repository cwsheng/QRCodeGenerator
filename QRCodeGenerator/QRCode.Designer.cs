namespace QRCodeGenerator
{
    partial class fmQRCode
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmQRCode));
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.spEversion = new DevExpress.XtraEditors.SpinEdit();
            this.cmbEError = new DevExpress.XtraEditors.ComboBoxEdit();
            this.cmbEEncodeMode = new DevExpress.XtraEditors.ComboBoxEdit();
            this.spBtSave = new DevExpress.XtraEditors.SimpleButton();
            this.spBtGenerator = new DevExpress.XtraEditors.SimpleButton();
            this.picQRCode = new DevExpress.XtraEditors.PictureEdit();
            this.btnELogo = new DevExpress.XtraEditors.ButtonEdit();
            this.txtQRCodeContent = new DevExpress.XtraEditors.TextEdit();
            this.spEscale = new DevExpress.XtraEditors.SpinEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem8 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem9 = new DevExpress.XtraLayout.LayoutControlItem();
            this.openFdImg = new System.Windows.Forms.OpenFileDialog();
            this.dxErrorProvider1 = new DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spEversion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbEError.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbEEncodeMode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picQRCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnELogo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQRCodeContent.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spEscale.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.spEversion);
            this.layoutControl1.Controls.Add(this.cmbEError);
            this.layoutControl1.Controls.Add(this.cmbEEncodeMode);
            this.layoutControl1.Controls.Add(this.spBtSave);
            this.layoutControl1.Controls.Add(this.spBtGenerator);
            this.layoutControl1.Controls.Add(this.picQRCode);
            this.layoutControl1.Controls.Add(this.btnELogo);
            this.layoutControl1.Controls.Add(this.txtQRCodeContent);
            this.layoutControl1.Controls.Add(this.spEscale);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(476, 156, 250, 350);
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(420, 350);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // spEversion
            // 
            this.spEversion.EditValue = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.spEversion.Location = new System.Drawing.Point(287, 84);
            this.spEversion.Name = "spEversion";
            this.spEversion.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spEversion.Properties.MaxValue = new decimal(new int[] {
            40,
            0,
            0,
            0});
            this.spEversion.Size = new System.Drawing.Size(121, 20);
            this.spEversion.StyleController = this.layoutControl1;
            this.spEversion.TabIndex = 5;
            // 
            // cmbEError
            // 
            this.cmbEError.EditValue = "L";
            this.cmbEError.Location = new System.Drawing.Point(287, 60);
            this.cmbEError.Name = "cmbEError";
            this.cmbEError.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbEError.Properties.Items.AddRange(new object[] {
            "L",
            "M",
            "Q",
            "H"});
            this.cmbEError.Size = new System.Drawing.Size(121, 20);
            this.cmbEError.StyleController = this.layoutControl1;
            this.cmbEError.TabIndex = 3;
            // 
            // cmbEEncodeMode
            // 
            this.cmbEEncodeMode.EditValue = "Byte";
            this.cmbEEncodeMode.Location = new System.Drawing.Point(87, 60);
            this.cmbEEncodeMode.Name = "cmbEEncodeMode";
            this.cmbEEncodeMode.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbEEncodeMode.Properties.Items.AddRange(new object[] {
            "Byte",
            "AlphaNumeric",
            "Numeric"});
            this.cmbEEncodeMode.Size = new System.Drawing.Size(121, 20);
            this.cmbEEncodeMode.StyleController = this.layoutControl1;
            this.cmbEEncodeMode.TabIndex = 2;
            // 
            // spBtSave
            // 
            this.spBtSave.Location = new System.Drawing.Point(212, 316);
            this.spBtSave.Name = "spBtSave";
            this.spBtSave.Size = new System.Drawing.Size(196, 22);
            this.spBtSave.StyleController = this.layoutControl1;
            this.spBtSave.TabIndex = 8;
            this.spBtSave.Text = "解析";
            this.spBtSave.Click += new System.EventHandler(this.spBtSave_Click);
            // 
            // spBtGenerator
            // 
            this.spBtGenerator.Location = new System.Drawing.Point(12, 316);
            this.spBtGenerator.Name = "spBtGenerator";
            this.spBtGenerator.Size = new System.Drawing.Size(196, 22);
            this.spBtGenerator.StyleController = this.layoutControl1;
            this.spBtGenerator.TabIndex = 7;
            this.spBtGenerator.Text = "生成";
            this.spBtGenerator.Click += new System.EventHandler(this.spBtGenerator_Click);
            // 
            // picQRCode
            // 
            this.picQRCode.Location = new System.Drawing.Point(12, 108);
            this.picQRCode.Name = "picQRCode";
            this.picQRCode.Properties.NullText = " ";
            this.picQRCode.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.picQRCode.Properties.ShowScrollBars = true;
            this.picQRCode.Size = new System.Drawing.Size(396, 204);
            this.picQRCode.StyleController = this.layoutControl1;
            this.picQRCode.TabIndex = 6;
            this.picQRCode.TabStop = true;
            // 
            // btnELogo
            // 
            this.btnELogo.Location = new System.Drawing.Point(87, 36);
            this.btnELogo.Name = "btnELogo";
            this.btnELogo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.btnELogo.Size = new System.Drawing.Size(321, 20);
            this.btnELogo.StyleController = this.layoutControl1;
            this.btnELogo.TabIndex = 1;
            this.btnELogo.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.btnELogo_ButtonClick);
            // 
            // txtQRCodeContent
            // 
            this.txtQRCodeContent.Location = new System.Drawing.Point(87, 12);
            this.txtQRCodeContent.Name = "txtQRCodeContent";
            this.txtQRCodeContent.Size = new System.Drawing.Size(321, 20);
            this.txtQRCodeContent.StyleController = this.layoutControl1;
            this.txtQRCodeContent.TabIndex = 0;
            this.txtQRCodeContent.EditValueChanged += new System.EventHandler(this.txtQRCodeContent_EditValueChanged);
            // 
            // spEscale
            // 
            this.spEscale.EditValue = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.spEscale.Location = new System.Drawing.Point(87, 84);
            this.spEscale.Name = "spEscale";
            this.spEscale.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spEscale.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Default;
            this.spEscale.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this.spEscale.Properties.MaxValue = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.spEscale.Properties.MinValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.spEscale.Size = new System.Drawing.Size(121, 20);
            this.spEscale.StyleController = this.layoutControl1;
            this.spEscale.TabIndex = 4;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem4,
            this.layoutControlItem5,
            this.layoutControlItem6,
            this.layoutControlItem7,
            this.layoutControlItem8,
            this.layoutControlItem9});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Size = new System.Drawing.Size(420, 350);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.txtQRCodeContent;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(400, 24);
            this.layoutControlItem1.Text = "二维码内容：";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(72, 14);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.btnELogo;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(400, 24);
            this.layoutControlItem2.Text = "解析图片：";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(72, 14);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.picQRCode;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 96);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(400, 208);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.spBtGenerator;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 304);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(200, 26);
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.spBtSave;
            this.layoutControlItem5.Location = new System.Drawing.Point(200, 304);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(200, 26);
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextVisible = false;
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.cmbEEncodeMode;
            this.layoutControlItem6.Location = new System.Drawing.Point(0, 48);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(200, 24);
            this.layoutControlItem6.Text = "编码格式：";
            this.layoutControlItem6.TextSize = new System.Drawing.Size(72, 14);
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Control = this.cmbEError;
            this.layoutControlItem7.Location = new System.Drawing.Point(200, 48);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Size = new System.Drawing.Size(200, 24);
            this.layoutControlItem7.Text = "误差校正:";
            this.layoutControlItem7.TextSize = new System.Drawing.Size(72, 14);
            // 
            // layoutControlItem8
            // 
            this.layoutControlItem8.Control = this.spEscale;
            this.layoutControlItem8.Location = new System.Drawing.Point(0, 72);
            this.layoutControlItem8.Name = "layoutControlItem8";
            this.layoutControlItem8.Size = new System.Drawing.Size(200, 24);
            this.layoutControlItem8.Text = "尺寸：";
            this.layoutControlItem8.TextSize = new System.Drawing.Size(72, 14);
            // 
            // layoutControlItem9
            // 
            this.layoutControlItem9.Control = this.spEversion;
            this.layoutControlItem9.Location = new System.Drawing.Point(200, 72);
            this.layoutControlItem9.Name = "layoutControlItem9";
            this.layoutControlItem9.Size = new System.Drawing.Size(200, 24);
            this.layoutControlItem9.Text = "版本：";
            this.layoutControlItem9.TextSize = new System.Drawing.Size(72, 14);
            // 
            // openFdImg
            // 
            this.openFdImg.Filter = "图片文件|*.jpg";
            // 
            // dxErrorProvider1
            // 
            this.dxErrorProvider1.ContainerControl = this;
            // 
            // fmQRCode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 350);
            this.Controls.Add(this.layoutControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(436, 388);
            this.Name = "fmQRCode";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "二维码生成器";
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spEversion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbEError.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbEEncodeMode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picQRCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnELogo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQRCodeContent.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spEscale.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraEditors.TextEdit txtQRCodeContent;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraEditors.ButtonEdit btnELogo;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private System.Windows.Forms.OpenFileDialog openFdImg;
        private DevExpress.XtraEditors.SimpleButton spBtSave;
        private DevExpress.XtraEditors.SimpleButton spBtGenerator;
        private DevExpress.XtraEditors.PictureEdit picQRCode;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraEditors.ComboBoxEdit cmbEError;
        private DevExpress.XtraEditors.ComboBoxEdit cmbEEncodeMode;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
        private DevExpress.XtraEditors.SpinEdit spEscale;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem8;
        private DevExpress.XtraEditors.SpinEdit spEversion;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem9;
        private DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider dxErrorProvider1;
    }
}

