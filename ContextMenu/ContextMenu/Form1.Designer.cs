namespace ContextMenu
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
            components = new System.ComponentModel.Container();
            contextMenuStrip1 = new ContextMenuStrip(components);
            maviToolStripMenuItem = new ToolStripMenuItem();
            yeşilToolStripMenuItem = new ToolStripMenuItem();
            ayarlarToolStripMenuItem = new ToolStripMenuItem();
            hakkımızdaToolStripMenuItem = new ToolStripMenuItem();
            çıkışToolStripMenuItem = new ToolStripMenuItem();
            kolayErişimToolStripMenuItem = new ToolStripMenuItem();
            hesapMakinesiToolStripMenuItem1 = new ToolStripMenuItem();
            paintToolStripMenuItem = new ToolStripMenuItem();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { maviToolStripMenuItem, yeşilToolStripMenuItem, ayarlarToolStripMenuItem, kolayErişimToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(160, 100);
            // 
            // maviToolStripMenuItem
            // 
            maviToolStripMenuItem.Name = "maviToolStripMenuItem";
            maviToolStripMenuItem.Size = new Size(159, 24);
            maviToolStripMenuItem.Text = "Mavi";
            maviToolStripMenuItem.Click += maviToolStripMenuItem_Click;
            // 
            // yeşilToolStripMenuItem
            // 
            yeşilToolStripMenuItem.Name = "yeşilToolStripMenuItem";
            yeşilToolStripMenuItem.Size = new Size(159, 24);
            yeşilToolStripMenuItem.Text = "Yeşil";
            yeşilToolStripMenuItem.Click += yeşilToolStripMenuItem_Click;
            // 
            // ayarlarToolStripMenuItem
            // 
            ayarlarToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { hakkımızdaToolStripMenuItem, çıkışToolStripMenuItem });
            ayarlarToolStripMenuItem.Name = "ayarlarToolStripMenuItem";
            ayarlarToolStripMenuItem.Size = new Size(159, 24);
            ayarlarToolStripMenuItem.Text = "Ayarlar";
            // 
            // hakkımızdaToolStripMenuItem
            // 
            hakkımızdaToolStripMenuItem.Name = "hakkımızdaToolStripMenuItem";
            hakkımızdaToolStripMenuItem.Size = new Size(170, 26);
            hakkımızdaToolStripMenuItem.Text = "Hakkımızda";
            // 
            // çıkışToolStripMenuItem
            // 
            çıkışToolStripMenuItem.Name = "çıkışToolStripMenuItem";
            çıkışToolStripMenuItem.Size = new Size(170, 26);
            çıkışToolStripMenuItem.Text = "Çıkış";
            çıkışToolStripMenuItem.Click += çıkışToolStripMenuItem_Click;
            // 
            // kolayErişimToolStripMenuItem
            // 
            kolayErişimToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { hesapMakinesiToolStripMenuItem1, paintToolStripMenuItem });
            kolayErişimToolStripMenuItem.Name = "kolayErişimToolStripMenuItem";
            kolayErişimToolStripMenuItem.Size = new Size(159, 24);
            kolayErişimToolStripMenuItem.Text = "Kolay Erişim";
            // 
            // hesapMakinesiToolStripMenuItem1
            // 
            hesapMakinesiToolStripMenuItem1.Name = "hesapMakinesiToolStripMenuItem1";
            hesapMakinesiToolStripMenuItem1.Size = new Size(224, 26);
            hesapMakinesiToolStripMenuItem1.Text = "Hesap Makinesi";
            hesapMakinesiToolStripMenuItem1.Click += hesapMakinesiToolStripMenuItem1_Click;
            // 
            // paintToolStripMenuItem
            // 
            paintToolStripMenuItem.Name = "paintToolStripMenuItem";
            paintToolStripMenuItem.Size = new Size(224, 26);
            paintToolStripMenuItem.Text = "Paint";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            ContextMenuStrip = contextMenuStrip1;
            Name = "Form1";
            Text = "Form1";
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem maviToolStripMenuItem;
        private ToolStripMenuItem yeşilToolStripMenuItem;
        private ToolStripMenuItem ayarlarToolStripMenuItem;
        private ToolStripMenuItem hakkımızdaToolStripMenuItem;
        private ToolStripMenuItem çıkışToolStripMenuItem;
        private ToolStripMenuItem kolayErişimToolStripMenuItem;
        private ToolStripMenuItem hesapMakinesiToolStripMenuItem1;
        private ToolStripMenuItem paintToolStripMenuItem;
    }
}
