
namespace TesterExCoreTxn
{
    partial class Tester
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.MyPalette = new ComponentFactory.Krypton.Toolkit.KryptonPalette(this.components);
            this.Log = new System.Windows.Forms.Label();
            this.Lb_Logs = new ComponentFactory.Krypton.Toolkit.KryptonListBox();
            this.Bt_Start = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.Tb_MfgOrder = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Bt_Reset = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.SuspendLayout();
            // 
            // MyPalette
            // 
            this.MyPalette.ButtonStyles.ButtonForm.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.MyPalette.ButtonStyles.ButtonForm.StateNormal.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.MyPalette.ButtonStyles.ButtonForm.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.MyPalette.ButtonStyles.ButtonForm.StateNormal.Border.Width = 0;
            this.MyPalette.ButtonStyles.ButtonForm.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.MyPalette.ButtonStyles.ButtonForm.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.MyPalette.ButtonStyles.ButtonForm.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.MyPalette.ButtonStyles.ButtonForm.StatePressed.Border.Width = 0;
            this.MyPalette.ButtonStyles.ButtonForm.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.MyPalette.ButtonStyles.ButtonForm.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.MyPalette.ButtonStyles.ButtonForm.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.MyPalette.ButtonStyles.ButtonForm.StateTracking.Border.Width = 0;
            this.MyPalette.FormStyles.FormMain.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.MyPalette.FormStyles.FormMain.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.MyPalette.FormStyles.FormMain.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.MyPalette.FormStyles.FormMain.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.None;
            this.MyPalette.FormStyles.FormMain.StateCommon.Border.Rounding = 12;
            this.MyPalette.HeaderStyles.HeaderForm.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.MyPalette.HeaderStyles.HeaderForm.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.MyPalette.HeaderStyles.HeaderForm.StateCommon.ButtonEdgeInset = 10;
            this.MyPalette.HeaderStyles.HeaderForm.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, -1, -1, -1);
            // 
            // Log
            // 
            this.Log.AutoSize = true;
            this.Log.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Log.ForeColor = System.Drawing.Color.Black;
            this.Log.Location = new System.Drawing.Point(269, 2);
            this.Log.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Log.Name = "Log";
            this.Log.Size = new System.Drawing.Size(37, 20);
            this.Log.TabIndex = 61;
            this.Log.Text = "Log";
            // 
            // Lb_Logs
            // 
            this.Lb_Logs.Location = new System.Drawing.Point(273, 25);
            this.Lb_Logs.Margin = new System.Windows.Forms.Padding(4);
            this.Lb_Logs.Name = "Lb_Logs";
            this.Lb_Logs.Size = new System.Drawing.Size(568, 384);
            this.Lb_Logs.StateCommon.Border.Color1 = System.Drawing.Color.Gray;
            this.Lb_Logs.StateCommon.Border.Color2 = System.Drawing.Color.Gray;
            this.Lb_Logs.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.Lb_Logs.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.Lb_Logs.StateCommon.Border.Rounding = 10;
            this.Lb_Logs.StateCommon.Border.Width = 1;
            this.Lb_Logs.StateDisabled.Back.Color1 = System.Drawing.Color.White;
            this.Lb_Logs.StateDisabled.Back.Color2 = System.Drawing.Color.White;
            this.Lb_Logs.StateDisabled.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.None;
            this.Lb_Logs.StateDisabled.Border.Color1 = System.Drawing.Color.Gray;
            this.Lb_Logs.StateDisabled.Border.Color2 = System.Drawing.Color.Gray;
            this.Lb_Logs.StateDisabled.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.Lb_Logs.StateDisabled.Border.Rounding = 10;
            this.Lb_Logs.StateDisabled.Border.Width = 1;
            this.Lb_Logs.StateNormal.Border.Color1 = System.Drawing.Color.Gray;
            this.Lb_Logs.StateNormal.Border.Color2 = System.Drawing.Color.Gray;
            this.Lb_Logs.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.Lb_Logs.StateNormal.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.Lb_Logs.StateNormal.Border.Rounding = 10;
            this.Lb_Logs.StateNormal.Border.Width = 1;
            this.Lb_Logs.TabIndex = 60;
            // 
            // Bt_Start
            // 
            this.Bt_Start.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Bt_Start.Location = new System.Drawing.Point(682, 431);
            this.Bt_Start.Margin = new System.Windows.Forms.Padding(4);
            this.Bt_Start.Name = "Bt_Start";
            this.Bt_Start.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(184)))), ((int)(((byte)(116)))));
            this.Bt_Start.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(143)))), ((int)(((byte)(81)))));
            this.Bt_Start.OverrideDefault.Back.ColorAngle = 45F;
            this.Bt_Start.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.Bt_Start.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.Bt_Start.OverrideDefault.Border.ColorAngle = 45F;
            this.Bt_Start.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.Bt_Start.OverrideDefault.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.Bt_Start.OverrideDefault.Border.Rounding = 20;
            this.Bt_Start.OverrideDefault.Border.Width = 1;
            this.Bt_Start.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.Bt_Start.Size = new System.Drawing.Size(159, 48);
            this.Bt_Start.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(184)))), ((int)(((byte)(116)))));
            this.Bt_Start.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(143)))), ((int)(((byte)(81)))));
            this.Bt_Start.StateCommon.Back.ColorAngle = 45F;
            this.Bt_Start.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.Bt_Start.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.Bt_Start.StateCommon.Border.ColorAngle = 45F;
            this.Bt_Start.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.Bt_Start.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.Bt_Start.StateCommon.Border.Rounding = 20;
            this.Bt_Start.StateCommon.Border.Width = 1;
            this.Bt_Start.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.Bt_Start.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.Bt_Start.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bt_Start.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(184)))), ((int)(((byte)(116)))));
            this.Bt_Start.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(143)))), ((int)(((byte)(81)))));
            this.Bt_Start.StatePressed.Back.ColorAngle = 135F;
            this.Bt_Start.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(145)))), ((int)(((byte)(198)))));
            this.Bt_Start.StatePressed.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(121)))), ((int)(((byte)(206)))));
            this.Bt_Start.StatePressed.Border.ColorAngle = 135F;
            this.Bt_Start.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.Bt_Start.StatePressed.Border.Rounding = 20;
            this.Bt_Start.StatePressed.Border.Width = 1;
            this.Bt_Start.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(143)))), ((int)(((byte)(81)))));
            this.Bt_Start.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(184)))), ((int)(((byte)(116)))));
            this.Bt_Start.StateTracking.Back.ColorAngle = 45F;
            this.Bt_Start.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.Bt_Start.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.Bt_Start.StateTracking.Border.ColorAngle = 45F;
            this.Bt_Start.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.Bt_Start.StateTracking.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.Bt_Start.StateTracking.Border.Rounding = 20;
            this.Bt_Start.StateTracking.Border.Width = 1;
            this.Bt_Start.TabIndex = 62;
            this.Bt_Start.Values.Text = "Start";
            this.Bt_Start.Click += new System.EventHandler(this.Bt_Start_Click);
            // 
            // Tb_MfgOrder
            // 
            this.Tb_MfgOrder.Location = new System.Drawing.Point(13, 54);
            this.Tb_MfgOrder.Margin = new System.Windows.Forms.Padding(4);
            this.Tb_MfgOrder.Name = "Tb_MfgOrder";
            this.Tb_MfgOrder.Size = new System.Drawing.Size(235, 39);
            this.Tb_MfgOrder.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.Tb_MfgOrder.StateCommon.Border.Color1 = System.Drawing.Color.Black;
            this.Tb_MfgOrder.StateCommon.Border.Color2 = System.Drawing.Color.Black;
            this.Tb_MfgOrder.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.Tb_MfgOrder.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.Tb_MfgOrder.StateCommon.Border.Rounding = 20;
            this.Tb_MfgOrder.StateCommon.Border.Width = 1;
            this.Tb_MfgOrder.StateCommon.Content.Color1 = System.Drawing.Color.Black;
            this.Tb_MfgOrder.TabIndex = 64;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(24, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 20);
            this.label1.TabIndex = 65;
            this.label1.Text = "Mfg Order";
            // 
            // Bt_Reset
            // 
            this.Bt_Reset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Bt_Reset.Location = new System.Drawing.Point(500, 431);
            this.Bt_Reset.Margin = new System.Windows.Forms.Padding(4);
            this.Bt_Reset.Name = "Bt_Reset";
            this.Bt_Reset.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(94)))), ((int)(((byte)(47)))));
            this.Bt_Reset.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(73)))), ((int)(((byte)(26)))));
            this.Bt_Reset.OverrideDefault.Back.ColorAngle = 45F;
            this.Bt_Reset.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(94)))), ((int)(((byte)(47)))));
            this.Bt_Reset.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(73)))), ((int)(((byte)(26)))));
            this.Bt_Reset.OverrideDefault.Border.ColorAngle = 45F;
            this.Bt_Reset.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.Bt_Reset.OverrideDefault.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.Bt_Reset.OverrideDefault.Border.Rounding = 20;
            this.Bt_Reset.OverrideDefault.Border.Width = 1;
            this.Bt_Reset.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.Bt_Reset.Size = new System.Drawing.Size(159, 48);
            this.Bt_Reset.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(94)))), ((int)(((byte)(47)))));
            this.Bt_Reset.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(73)))), ((int)(((byte)(26)))));
            this.Bt_Reset.StateCommon.Back.ColorAngle = 45F;
            this.Bt_Reset.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(73)))), ((int)(((byte)(26)))));
            this.Bt_Reset.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(94)))), ((int)(((byte)(47)))));
            this.Bt_Reset.StateCommon.Border.ColorAngle = 45F;
            this.Bt_Reset.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.Bt_Reset.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.Bt_Reset.StateCommon.Border.Rounding = 20;
            this.Bt_Reset.StateCommon.Border.Width = 1;
            this.Bt_Reset.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.Bt_Reset.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.Bt_Reset.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bt_Reset.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(94)))), ((int)(((byte)(47)))));
            this.Bt_Reset.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(73)))), ((int)(((byte)(26)))));
            this.Bt_Reset.StatePressed.Back.ColorAngle = 135F;
            this.Bt_Reset.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(94)))), ((int)(((byte)(47)))));
            this.Bt_Reset.StatePressed.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(73)))), ((int)(((byte)(26)))));
            this.Bt_Reset.StatePressed.Border.ColorAngle = 135F;
            this.Bt_Reset.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.Bt_Reset.StatePressed.Border.Rounding = 20;
            this.Bt_Reset.StatePressed.Border.Width = 1;
            this.Bt_Reset.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(73)))), ((int)(((byte)(26)))));
            this.Bt_Reset.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(94)))), ((int)(((byte)(47)))));
            this.Bt_Reset.StateTracking.Back.ColorAngle = 45F;
            this.Bt_Reset.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(73)))), ((int)(((byte)(26)))));
            this.Bt_Reset.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(94)))), ((int)(((byte)(47)))));
            this.Bt_Reset.StateTracking.Border.ColorAngle = 45F;
            this.Bt_Reset.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.Bt_Reset.StateTracking.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.Bt_Reset.StateTracking.Border.Rounding = 20;
            this.Bt_Reset.StateTracking.Border.Width = 1;
            this.Bt_Reset.TabIndex = 66;
            this.Bt_Reset.Values.Text = "Reset";
            this.Bt_Reset.Click += new System.EventHandler(this.Bt_Reset_Click);
            // 
            // Tester
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(854, 522);
            this.Controls.Add(this.Bt_Reset);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Tb_MfgOrder);
            this.Controls.Add(this.Bt_Start);
            this.Controls.Add(this.Log);
            this.Controls.Add(this.Lb_Logs);
            this.Name = "Tester";
            this.Palette = this.MyPalette;
            this.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.ShowIcon = false;
            this.Text = "Tester ExCore";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonPalette MyPalette;
        private System.Windows.Forms.Label Log;
        private ComponentFactory.Krypton.Toolkit.KryptonListBox Lb_Logs;
        private ComponentFactory.Krypton.Toolkit.KryptonButton Bt_Start;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox Tb_MfgOrder;
        private System.Windows.Forms.Label label1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton Bt_Reset;
    }
}

