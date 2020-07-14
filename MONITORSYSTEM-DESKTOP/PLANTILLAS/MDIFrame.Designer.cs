namespace MONITORSYSTEM_DESKTOP.PLANTILLAS
{
    partial class MDIFrame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MDIFrame));
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.pTop = new System.Windows.Forms.Panel();
            this.pMenu = new System.Windows.Forms.Panel();
            this.menu = new System.Windows.Forms.MenuStrip();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pBot = new System.Windows.Forms.Panel();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.tsNombre = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.tsFecha = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel5 = new System.Windows.Forms.ToolStripLabel();
            this.tsHora = new System.Windows.Forms.ToolStripLabel();
            this.pContenedor = new System.Windows.Forms.Panel();
            this.pTop.SuspendLayout();
            this.pMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pBot.SuspendLayout();
            this.toolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // pTop
            // 
            this.pTop.Controls.Add(this.pMenu);
            this.pTop.Controls.Add(this.pictureBox1);
            this.pTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pTop.Location = new System.Drawing.Point(0, 0);
            this.pTop.Name = "pTop";
            this.pTop.Size = new System.Drawing.Size(834, 35);
            this.pTop.TabIndex = 4;
            // 
            // pMenu
            // 
            this.pMenu.Controls.Add(this.menu);
            this.pMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pMenu.Location = new System.Drawing.Point(36, 0);
            this.pMenu.Name = "pMenu";
            this.pMenu.Size = new System.Drawing.Size(798, 35);
            this.pMenu.TabIndex = 2;
            // 
            // menu
            // 
            this.menu.AutoSize = false;
            this.menu.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(798, 35);
            this.menu.TabIndex = 0;
            this.menu.Text = "menuStrip1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(36, 35);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // pBot
            // 
            this.pBot.Controls.Add(this.toolStrip);
            this.pBot.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pBot.Location = new System.Drawing.Point(0, 531);
            this.pBot.Name = "pBot";
            this.pBot.Size = new System.Drawing.Size(834, 30);
            this.pBot.TabIndex = 5;
            // 
            // toolStrip
            // 
            this.toolStrip.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.toolStrip.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.tsNombre,
            this.toolStripSeparator1,
            this.toolStripLabel3,
            this.tsFecha,
            this.toolStripSeparator2,
            this.toolStripLabel5,
            this.tsHora});
            this.toolStrip.Location = new System.Drawing.Point(0, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip.Size = new System.Drawing.Size(834, 30);
            this.toolStrip.TabIndex = 0;
            this.toolStrip.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(56, 27);
            this.toolStripLabel1.Text = "Operario:";
            // 
            // tsNombre
            // 
            this.tsNombre.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.tsNombre.Name = "tsNombre";
            this.tsNombre.Size = new System.Drawing.Size(120, 27);
            this.tsNombre.Text = "NOMBRE COMPLETO";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 30);
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(41, 27);
            this.toolStripLabel3.Text = "Fecha:";
            // 
            // tsFecha
            // 
            this.tsFecha.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.tsFecha.Name = "tsFecha";
            this.tsFecha.Size = new System.Drawing.Size(77, 27);
            this.tsFecha.Text = "dd/mm/yyyy";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 30);
            // 
            // toolStripLabel5
            // 
            this.toolStripLabel5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.toolStripLabel5.Name = "toolStripLabel5";
            this.toolStripLabel5.Size = new System.Drawing.Size(36, 27);
            this.toolStripLabel5.Text = "Hora:";
            // 
            // tsHora
            // 
            this.tsHora.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.tsHora.Name = "tsHora";
            this.tsHora.Size = new System.Drawing.Size(59, 27);
            this.tsHora.Text = "hh:mm:ss";
            // 
            // pContenedor
            // 
            this.pContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pContenedor.Location = new System.Drawing.Point(0, 35);
            this.pContenedor.Name = "pContenedor";
            this.pContenedor.Size = new System.Drawing.Size(834, 496);
            this.pContenedor.TabIndex = 6;
            // 
            // MDIFrame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(834, 561);
            this.Controls.Add(this.pContenedor);
            this.Controls.Add(this.pBot);
            this.Controls.Add(this.pTop);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "MDIFrame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MDIFrame";
            this.Load += new System.EventHandler(this.MDIFrame_Load);
            this.pTop.ResumeLayout(false);
            this.pMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pBot.ResumeLayout(false);
            this.pBot.PerformLayout();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.ResumeLayout(false);

        }
        #endregion
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.Panel pTop;
        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.Panel pBot;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripLabel tsNombre;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.ToolStripLabel tsFecha;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel5;
        private System.Windows.Forms.Panel pContenedor;
        private System.Windows.Forms.ToolStripLabel tsHora;
        private System.Windows.Forms.Panel pMenu;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}



