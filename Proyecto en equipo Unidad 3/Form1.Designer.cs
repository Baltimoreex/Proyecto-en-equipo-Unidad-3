namespace Proyecto_en_equipo_Unidad_3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            cmbPlayers = new MaterialSkin.Controls.MaterialComboBox();
            lblPlayers = new MaterialSkin.Controls.MaterialLabel();
            lblRange = new MaterialSkin.Controls.MaterialLabel();
            lblLevel = new MaterialSkin.Controls.MaterialLabel();
            picAvatar = new PictureBox();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            cmbWeapons = new MaterialSkin.Controls.MaterialComboBox();
            lblWeapons = new MaterialSkin.Controls.MaterialLabel();
            picWeapons = new PictureBox();
            picScope = new PictureBox();
            picHandle = new PictureBox();
            picExtendedMag = new PictureBox();
            picSilencer = new PictureBox();
            btnOrdenar = new MaterialSkin.Controls.MaterialButton();
            textWeapons = new MaterialSkin.Controls.MaterialMultiLineTextBox();
            lblActions = new MaterialSkin.Controls.MaterialLabel();
            btnShoot = new MaterialSkin.Controls.MaterialButton();
            btnReload = new MaterialSkin.Controls.MaterialButton();
            btnInspect = new MaterialSkin.Controls.MaterialButton();
            textShoot = new MaterialSkin.Controls.MaterialMultiLineTextBox();
            textReload = new MaterialSkin.Controls.MaterialMultiLineTextBox();
            textInspect = new MaterialSkin.Controls.MaterialMultiLineTextBox();
            lblName = new MaterialSkin.Controls.MaterialLabel();
            lblName2 = new MaterialSkin.Controls.MaterialLabel();
            lblRange2 = new MaterialSkin.Controls.MaterialLabel();
            lblLevel2 = new MaterialSkin.Controls.MaterialLabel();
            chkScope = new CheckBox();
            chkExtendedMag = new CheckBox();
            chkHandle = new CheckBox();
            chkSilencer = new CheckBox();
            textScopeDescription = new MaterialSkin.Controls.MaterialMultiLineTextBox();
            textExtendedMagDescription = new MaterialSkin.Controls.MaterialMultiLineTextBox();
            textHandleDescription = new MaterialSkin.Controls.MaterialMultiLineTextBox();
            materialMultiLineTextBox1 = new MaterialSkin.Controls.MaterialMultiLineTextBox();
            lblTipo = new Label();
            ((System.ComponentModel.ISupportInitialize)picAvatar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picWeapons).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picScope).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picHandle).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picExtendedMag).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picSilencer).BeginInit();
            SuspendLayout();
            // 
            // cmbPlayers
            // 
            cmbPlayers.AutoResize = false;
            cmbPlayers.BackColor = Color.FromArgb(255, 255, 255);
            cmbPlayers.Depth = 0;
            cmbPlayers.DrawMode = DrawMode.OwnerDrawVariable;
            cmbPlayers.DropDownHeight = 174;
            cmbPlayers.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPlayers.DropDownWidth = 121;
            cmbPlayers.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cmbPlayers.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cmbPlayers.FormattingEnabled = true;
            cmbPlayers.IntegralHeight = false;
            cmbPlayers.ItemHeight = 43;
            cmbPlayers.Location = new Point(101, 69);
            cmbPlayers.Margin = new Padding(3, 4, 3, 4);
            cmbPlayers.MaxDropDownItems = 4;
            cmbPlayers.MouseState = MaterialSkin.MouseState.OUT;
            cmbPlayers.Name = "cmbPlayers";
            cmbPlayers.Size = new Size(254, 49);
            cmbPlayers.StartIndex = 0;
            cmbPlayers.TabIndex = 0;
            cmbPlayers.SelectedIndexChanged += cmbPlayers_SelectedIndexChanged;
            // 
            // lblPlayers
            // 
            lblPlayers.AutoSize = true;
            lblPlayers.BackColor = Color.Transparent;
            lblPlayers.Depth = 0;
            lblPlayers.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblPlayers.Location = new Point(254, 24);
            lblPlayers.MouseState = MaterialSkin.MouseState.HOVER;
            lblPlayers.Name = "lblPlayers";
            lblPlayers.Size = new Size(38, 19);
            lblPlayers.TabIndex = 1;
            lblPlayers.Text = "Perfil";
            // 
            // lblRange
            // 
            lblRange.AutoSize = true;
            lblRange.Depth = 0;
            lblRange.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblRange.Location = new Point(101, 249);
            lblRange.MouseState = MaterialSkin.MouseState.HOVER;
            lblRange.Name = "lblRange";
            lblRange.Size = new Size(51, 19);
            lblRange.TabIndex = 2;
            lblRange.Text = "Rango:";
            // 
            // lblLevel
            // 
            lblLevel.AutoSize = true;
            lblLevel.Depth = 0;
            lblLevel.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblLevel.Location = new Point(101, 315);
            lblLevel.MouseState = MaterialSkin.MouseState.HOVER;
            lblLevel.Name = "lblLevel";
            lblLevel.Size = new Size(40, 19);
            lblLevel.TabIndex = 3;
            lblLevel.Text = "Nivel:";
            // 
            // picAvatar
            // 
            picAvatar.BackColor = Color.Transparent;
            picAvatar.Location = new Point(412, 69);
            picAvatar.Margin = new Padding(3, 4, 3, 4);
            picAvatar.Name = "picAvatar";
            picAvatar.Size = new Size(108, 104);
            picAvatar.TabIndex = 5;
            picAvatar.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-3, 0);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(569, 609);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(563, 0);
            pictureBox2.Margin = new Padding(3, 4, 3, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(569, 609);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 7;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(1120, 0);
            pictureBox3.Margin = new Padding(3, 4, 3, 4);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(564, 609);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 8;
            pictureBox3.TabStop = false;
            // 
            // cmbWeapons
            // 
            cmbWeapons.AutoResize = false;
            cmbWeapons.BackColor = Color.FromArgb(255, 255, 255);
            cmbWeapons.Depth = 0;
            cmbWeapons.DrawMode = DrawMode.OwnerDrawVariable;
            cmbWeapons.DropDownHeight = 174;
            cmbWeapons.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbWeapons.DropDownWidth = 121;
            cmbWeapons.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cmbWeapons.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cmbWeapons.FormattingEnabled = true;
            cmbWeapons.IntegralHeight = false;
            cmbWeapons.ItemHeight = 43;
            cmbWeapons.Location = new Point(609, 41);
            cmbWeapons.Margin = new Padding(3, 4, 3, 4);
            cmbWeapons.MaxDropDownItems = 4;
            cmbWeapons.MouseState = MaterialSkin.MouseState.OUT;
            cmbWeapons.Name = "cmbWeapons";
            cmbWeapons.Size = new Size(222, 49);
            cmbWeapons.StartIndex = 0;
            cmbWeapons.TabIndex = 9;
            cmbWeapons.SelectedIndexChanged += cmbWeapons_SelectedIndexChanged;
            // 
            // lblWeapons
            // 
            lblWeapons.AutoSize = true;
            lblWeapons.BackColor = Color.Transparent;
            lblWeapons.Depth = 0;
            lblWeapons.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblWeapons.Location = new Point(853, 24);
            lblWeapons.MouseState = MaterialSkin.MouseState.HOVER;
            lblWeapons.Name = "lblWeapons";
            lblWeapons.Size = new Size(47, 19);
            lblWeapons.TabIndex = 10;
            lblWeapons.Text = "Armas";
            // 
            // picWeapons
            // 
            picWeapons.BackColor = Color.Transparent;
            picWeapons.Location = new Point(950, 24);
            picWeapons.Margin = new Padding(3, 4, 3, 4);
            picWeapons.Name = "picWeapons";
            picWeapons.Size = new Size(115, 115);
            picWeapons.TabIndex = 11;
            picWeapons.TabStop = false;
            // 
            // picScope
            // 
            picScope.BackColor = Color.Transparent;
            picScope.BackgroundImage = (Image)resources.GetObject("picScope.BackgroundImage");
            picScope.BackgroundImageLayout = ImageLayout.Stretch;
            picScope.Location = new Point(699, 273);
            picScope.Margin = new Padding(3, 4, 3, 4);
            picScope.Name = "picScope";
            picScope.Size = new Size(94, 88);
            picScope.TabIndex = 12;
            picScope.TabStop = false;
            // 
            // picHandle
            // 
            picHandle.BackColor = Color.Transparent;
            picHandle.BackgroundImage = (Image)resources.GetObject("picHandle.BackgroundImage");
            picHandle.BackgroundImageLayout = ImageLayout.Stretch;
            picHandle.Location = new Point(1000, 273);
            picHandle.Margin = new Padding(3, 4, 3, 4);
            picHandle.Name = "picHandle";
            picHandle.Size = new Size(94, 88);
            picHandle.TabIndex = 13;
            picHandle.TabStop = false;
            // 
            // picExtendedMag
            // 
            picExtendedMag.BackColor = Color.Transparent;
            picExtendedMag.BackgroundImage = (Image)resources.GetObject("picExtendedMag.BackgroundImage");
            picExtendedMag.BackgroundImageLayout = ImageLayout.Stretch;
            picExtendedMag.Location = new Point(699, 445);
            picExtendedMag.Margin = new Padding(3, 4, 3, 4);
            picExtendedMag.Name = "picExtendedMag";
            picExtendedMag.Size = new Size(94, 91);
            picExtendedMag.TabIndex = 14;
            picExtendedMag.TabStop = false;
            // 
            // picSilencer
            // 
            picSilencer.BackColor = Color.Transparent;
            picSilencer.BackgroundImage = (Image)resources.GetObject("picSilencer.BackgroundImage");
            picSilencer.BackgroundImageLayout = ImageLayout.Stretch;
            picSilencer.Location = new Point(1000, 445);
            picSilencer.Margin = new Padding(3, 4, 3, 4);
            picSilencer.Name = "picSilencer";
            picSilencer.Size = new Size(94, 91);
            picSilencer.TabIndex = 15;
            picSilencer.TabStop = false;
            // 
            // btnOrdenar
            // 
            btnOrdenar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnOrdenar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnOrdenar.Depth = 0;
            btnOrdenar.HighEmphasis = true;
            btnOrdenar.Icon = null;
            btnOrdenar.Location = new Point(821, 534);
            btnOrdenar.Margin = new Padding(5, 8, 5, 8);
            btnOrdenar.MouseState = MaterialSkin.MouseState.HOVER;
            btnOrdenar.Name = "btnOrdenar";
            btnOrdenar.NoAccentTextColor = Color.Empty;
            btnOrdenar.Size = new Size(88, 36);
            btnOrdenar.TabIndex = 16;
            btnOrdenar.Text = "Ordenar";
            btnOrdenar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnOrdenar.UseAccentColor = false;
            btnOrdenar.UseVisualStyleBackColor = true;
            btnOrdenar.Click += btnOrdenar_Click;
            // 
            // textWeapons
            // 
            textWeapons.BackColor = Color.FromArgb(255, 255, 255);
            textWeapons.BorderStyle = BorderStyle.None;
            textWeapons.Depth = 0;
            textWeapons.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            textWeapons.ForeColor = Color.FromArgb(222, 0, 0, 0);
            textWeapons.Location = new Point(609, 98);
            textWeapons.Margin = new Padding(3, 4, 3, 4);
            textWeapons.MouseState = MaterialSkin.MouseState.HOVER;
            textWeapons.Name = "textWeapons";
            textWeapons.Size = new Size(222, 104);
            textWeapons.TabIndex = 21;
            textWeapons.Text = "";
            // 
            // lblActions
            // 
            lblActions.AutoSize = true;
            lblActions.Depth = 0;
            lblActions.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblActions.Location = new Point(1395, 24);
            lblActions.MouseState = MaterialSkin.MouseState.HOVER;
            lblActions.Name = "lblActions";
            lblActions.Size = new Size(65, 19);
            lblActions.TabIndex = 22;
            lblActions.Text = "Acciones";
            // 
            // btnShoot
            // 
            btnShoot.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnShoot.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnShoot.Depth = 0;
            btnShoot.HighEmphasis = true;
            btnShoot.Icon = null;
            btnShoot.Location = new Point(1164, 172);
            btnShoot.Margin = new Padding(5, 8, 5, 8);
            btnShoot.MouseState = MaterialSkin.MouseState.HOVER;
            btnShoot.Name = "btnShoot";
            btnShoot.NoAccentTextColor = Color.Empty;
            btnShoot.Size = new Size(91, 36);
            btnShoot.TabIndex = 23;
            btnShoot.Text = "DIsparar";
            btnShoot.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnShoot.UseAccentColor = false;
            btnShoot.UseVisualStyleBackColor = true;
            btnShoot.Click += btnShoot_Click;
            // 
            // btnReload
            // 
            btnReload.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnReload.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnReload.Depth = 0;
            btnReload.HighEmphasis = true;
            btnReload.Icon = null;
            btnReload.Location = new Point(1164, 273);
            btnReload.Margin = new Padding(5, 8, 5, 8);
            btnReload.MouseState = MaterialSkin.MouseState.HOVER;
            btnReload.Name = "btnReload";
            btnReload.NoAccentTextColor = Color.Empty;
            btnReload.Size = new Size(96, 36);
            btnReload.TabIndex = 24;
            btnReload.Text = "Recargar";
            btnReload.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnReload.UseAccentColor = false;
            btnReload.UseVisualStyleBackColor = true;
            btnReload.Click += btnReload_Click;
            // 
            // btnInspect
            // 
            btnInspect.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnInspect.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnInspect.Depth = 0;
            btnInspect.HighEmphasis = true;
            btnInspect.Icon = null;
            btnInspect.Location = new Point(1164, 389);
            btnInspect.Margin = new Padding(5, 8, 5, 8);
            btnInspect.MouseState = MaterialSkin.MouseState.HOVER;
            btnInspect.Name = "btnInspect";
            btnInspect.NoAccentTextColor = Color.Empty;
            btnInspect.Size = new Size(126, 36);
            btnInspect.TabIndex = 25;
            btnInspect.Text = "Inspeccionar";
            btnInspect.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnInspect.UseAccentColor = false;
            btnInspect.UseVisualStyleBackColor = true;
            btnInspect.Click += btnInspect_Click;
            // 
            // textShoot
            // 
            textShoot.BackColor = Color.FromArgb(255, 255, 255);
            textShoot.BorderStyle = BorderStyle.None;
            textShoot.Depth = 0;
            textShoot.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            textShoot.ForeColor = Color.FromArgb(222, 0, 0, 0);
            textShoot.Location = new Point(1413, 152);
            textShoot.Margin = new Padding(3, 4, 3, 4);
            textShoot.MouseState = MaterialSkin.MouseState.HOVER;
            textShoot.Name = "textShoot";
            textShoot.Size = new Size(116, 77);
            textShoot.TabIndex = 26;
            textShoot.Text = "";
            // 
            // textReload
            // 
            textReload.BackColor = Color.FromArgb(255, 255, 255);
            textReload.BorderStyle = BorderStyle.None;
            textReload.Depth = 0;
            textReload.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            textReload.ForeColor = Color.FromArgb(222, 0, 0, 0);
            textReload.Location = new Point(1413, 249);
            textReload.Margin = new Padding(3, 4, 3, 4);
            textReload.MouseState = MaterialSkin.MouseState.HOVER;
            textReload.Name = "textReload";
            textReload.Size = new Size(116, 77);
            textReload.TabIndex = 27;
            textReload.Text = "";
            // 
            // textInspect
            // 
            textInspect.BackColor = Color.FromArgb(255, 255, 255);
            textInspect.BorderStyle = BorderStyle.None;
            textInspect.Depth = 0;
            textInspect.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            textInspect.ForeColor = Color.FromArgb(222, 0, 0, 0);
            textInspect.Location = new Point(1413, 360);
            textInspect.Margin = new Padding(3, 4, 3, 4);
            textInspect.MouseState = MaterialSkin.MouseState.HOVER;
            textInspect.Name = "textInspect";
            textInspect.Size = new Size(116, 77);
            textInspect.TabIndex = 28;
            textInspect.Text = "";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Depth = 0;
            lblName.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblName.Location = new Point(101, 183);
            lblName.MouseState = MaterialSkin.MouseState.HOVER;
            lblName.Name = "lblName";
            lblName.Size = new Size(61, 19);
            lblName.TabIndex = 29;
            lblName.Text = "Nombre:";
            // 
            // lblName2
            // 
            lblName2.AutoSize = true;
            lblName2.Depth = 0;
            lblName2.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblName2.Location = new Point(231, 183);
            lblName2.MouseState = MaterialSkin.MouseState.HOVER;
            lblName2.Name = "lblName2";
            lblName2.Size = new Size(61, 19);
            lblName2.TabIndex = 30;
            lblName2.Text = "Nombre:";
            // 
            // lblRange2
            // 
            lblRange2.AutoSize = true;
            lblRange2.Depth = 0;
            lblRange2.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblRange2.Location = new Point(231, 249);
            lblRange2.MouseState = MaterialSkin.MouseState.HOVER;
            lblRange2.Name = "lblRange2";
            lblRange2.Size = new Size(51, 19);
            lblRange2.TabIndex = 31;
            lblRange2.Text = "Rango:";
            // 
            // lblLevel2
            // 
            lblLevel2.AutoSize = true;
            lblLevel2.Depth = 0;
            lblLevel2.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblLevel2.Location = new Point(231, 315);
            lblLevel2.MouseState = MaterialSkin.MouseState.HOVER;
            lblLevel2.Name = "lblLevel2";
            lblLevel2.Size = new Size(40, 19);
            lblLevel2.TabIndex = 32;
            lblLevel2.Text = "Nivel:";
            // 
            // chkScope
            // 
            chkScope.AutoSize = true;
            chkScope.Location = new Point(699, 241);
            chkScope.Margin = new Padding(3, 4, 3, 4);
            chkScope.Name = "chkScope";
            chkScope.Size = new Size(61, 24);
            chkScope.TabIndex = 33;
            chkScope.Text = "Mira";
            chkScope.UseVisualStyleBackColor = true;
            // 
            // chkExtendedMag
            // 
            chkExtendedMag.AutoSize = true;
            chkExtendedMag.Location = new Point(699, 413);
            chkExtendedMag.Margin = new Padding(3, 4, 3, 4);
            chkExtendedMag.Name = "chkExtendedMag";
            chkExtendedMag.Size = new Size(164, 24);
            chkExtendedMag.TabIndex = 34;
            chkExtendedMag.Text = "Cargador Extendido";
            chkExtendedMag.UseVisualStyleBackColor = true;
            // 
            // chkHandle
            // 
            chkHandle.AutoSize = true;
            chkHandle.Location = new Point(1000, 231);
            chkHandle.Margin = new Padding(3, 4, 3, 4);
            chkHandle.Name = "chkHandle";
            chkHandle.Size = new Size(115, 24);
            chkHandle.TabIndex = 35;
            chkHandle.Text = "Empuñadura";
            chkHandle.UseVisualStyleBackColor = true;
            // 
            // chkSilencer
            // 
            chkSilencer.AutoSize = true;
            chkSilencer.Location = new Point(1000, 413);
            chkSilencer.Margin = new Padding(3, 4, 3, 4);
            chkSilencer.Name = "chkSilencer";
            chkSilencer.Size = new Size(105, 24);
            chkSilencer.TabIndex = 36;
            chkSilencer.Text = "Silenciador";
            chkSilencer.UseVisualStyleBackColor = true;
            // 
            // textScopeDescription
            // 
            textScopeDescription.BackColor = Color.FromArgb(255, 255, 255);
            textScopeDescription.BorderStyle = BorderStyle.None;
            textScopeDescription.Depth = 0;
            textScopeDescription.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            textScopeDescription.ForeColor = Color.FromArgb(222, 0, 0, 0);
            textScopeDescription.Location = new Point(580, 298);
            textScopeDescription.MouseState = MaterialSkin.MouseState.HOVER;
            textScopeDescription.Name = "textScopeDescription";
            textScopeDescription.Size = new Size(113, 36);
            textScopeDescription.TabIndex = 37;
            textScopeDescription.Text = "+30 de Precision +600 de costo";
            // 
            // textExtendedMagDescription
            // 
            textExtendedMagDescription.BackColor = Color.FromArgb(255, 255, 255);
            textExtendedMagDescription.BorderStyle = BorderStyle.None;
            textExtendedMagDescription.Depth = 0;
            textExtendedMagDescription.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            textExtendedMagDescription.ForeColor = Color.FromArgb(222, 0, 0, 0);
            textExtendedMagDescription.Location = new Point(580, 445);
            textExtendedMagDescription.MouseState = MaterialSkin.MouseState.HOVER;
            textExtendedMagDescription.Name = "textExtendedMagDescription";
            textExtendedMagDescription.Size = new Size(113, 22);
            textExtendedMagDescription.TabIndex = 38;
            textExtendedMagDescription.Text = "+300 de costo";
            // 
            // textHandleDescription
            // 
            textHandleDescription.BackColor = Color.FromArgb(255, 255, 255);
            textHandleDescription.BorderStyle = BorderStyle.None;
            textHandleDescription.Depth = 0;
            textHandleDescription.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            textHandleDescription.ForeColor = Color.FromArgb(222, 0, 0, 0);
            textHandleDescription.Location = new Point(881, 297);
            textHandleDescription.MouseState = MaterialSkin.MouseState.HOVER;
            textHandleDescription.Name = "textHandleDescription";
            textHandleDescription.Size = new Size(113, 36);
            textHandleDescription.TabIndex = 39;
            textHandleDescription.Text = "+20 de Precision +400 de costo";
            // 
            // materialMultiLineTextBox1
            // 
            materialMultiLineTextBox1.BackColor = Color.FromArgb(255, 255, 255);
            materialMultiLineTextBox1.BorderStyle = BorderStyle.None;
            materialMultiLineTextBox1.Depth = 0;
            materialMultiLineTextBox1.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialMultiLineTextBox1.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialMultiLineTextBox1.Location = new Point(884, 445);
            materialMultiLineTextBox1.MouseState = MaterialSkin.MouseState.HOVER;
            materialMultiLineTextBox1.Name = "materialMultiLineTextBox1";
            materialMultiLineTextBox1.Size = new Size(110, 51);
            materialMultiLineTextBox1.TabIndex = 40;
            materialMultiLineTextBox1.Text = "-20 de daño,     +20 de Precision +500 de costo";
            // 
            // lblTipo
            // 
            lblTipo.AutoSize = true;
            lblTipo.Location = new Point(1308, 196);
            lblTipo.Name = "lblTipo";
            lblTipo.Size = new Size(50, 20);
            lblTipo.TabIndex = 41;
            lblTipo.Text = "label1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1678, 605);
            Controls.Add(lblTipo);
            Controls.Add(materialMultiLineTextBox1);
            Controls.Add(textHandleDescription);
            Controls.Add(textExtendedMagDescription);
            Controls.Add(textScopeDescription);
            Controls.Add(chkSilencer);
            Controls.Add(chkHandle);
            Controls.Add(chkExtendedMag);
            Controls.Add(chkScope);
            Controls.Add(lblLevel2);
            Controls.Add(lblRange2);
            Controls.Add(lblName2);
            Controls.Add(lblName);
            Controls.Add(textInspect);
            Controls.Add(textReload);
            Controls.Add(textShoot);
            Controls.Add(btnInspect);
            Controls.Add(btnReload);
            Controls.Add(btnShoot);
            Controls.Add(lblActions);
            Controls.Add(textWeapons);
            Controls.Add(btnOrdenar);
            Controls.Add(picSilencer);
            Controls.Add(picExtendedMag);
            Controls.Add(picHandle);
            Controls.Add(picScope);
            Controls.Add(picWeapons);
            Controls.Add(lblWeapons);
            Controls.Add(cmbWeapons);
            Controls.Add(picAvatar);
            Controls.Add(lblLevel);
            Controls.Add(lblRange);
            Controls.Add(lblPlayers);
            Controls.Add(cmbPlayers);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox3);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Pantalla todo en uno";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)picAvatar).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)picWeapons).EndInit();
            ((System.ComponentModel.ISupportInitialize)picScope).EndInit();
            ((System.ComponentModel.ISupportInitialize)picHandle).EndInit();
            ((System.ComponentModel.ISupportInitialize)picExtendedMag).EndInit();
            ((System.ComponentModel.ISupportInitialize)picSilencer).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaterialSkin.Controls.MaterialComboBox cmbPlayers;
        private MaterialSkin.Controls.MaterialLabel lblPlayers;
        private MaterialSkin.Controls.MaterialLabel lblRange;
        private MaterialSkin.Controls.MaterialLabel lblLevel;
        private PictureBox picAvatar;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private MaterialSkin.Controls.MaterialComboBox cmbWeapons;
        private MaterialSkin.Controls.MaterialLabel lblWeapons;
        private PictureBox picWeapons;
        private PictureBox picScope;
        private PictureBox picHandle;
        private PictureBox picExtendedMag;
        private PictureBox picSilencer;
        private MaterialSkin.Controls.MaterialButton btnOrdenar;
        private MaterialSkin.Controls.MaterialMultiLineTextBox textWeapons;
        private MaterialSkin.Controls.MaterialLabel lblActions;
        private MaterialSkin.Controls.MaterialButton btnShoot;
        private MaterialSkin.Controls.MaterialButton btnReload;
        private MaterialSkin.Controls.MaterialButton btnInspect;
        private MaterialSkin.Controls.MaterialMultiLineTextBox textShoot;
        private MaterialSkin.Controls.MaterialMultiLineTextBox textReload;
        private MaterialSkin.Controls.MaterialMultiLineTextBox textInspect;
        private MaterialSkin.Controls.MaterialLabel lblName;
        private MaterialSkin.Controls.MaterialLabel lblName2;
        private MaterialSkin.Controls.MaterialLabel lblRange2;
        private MaterialSkin.Controls.MaterialLabel lblLevel2;
        private CheckBox chkScope;
        private CheckBox chkExtendedMag;
        private CheckBox chkHandle;
        private CheckBox chkSilencer;
        private MaterialSkin.Controls.MaterialMultiLineTextBox textScopeDescription;
        private MaterialSkin.Controls.MaterialMultiLineTextBox textExtendedMagDescription;
        private MaterialSkin.Controls.MaterialMultiLineTextBox textHandleDescription;
        private MaterialSkin.Controls.MaterialMultiLineTextBox materialMultiLineTextBox1;
        private Label lblTipo;
    }
}
