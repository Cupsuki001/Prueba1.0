namespace prueba
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
            menuStrip1 = new MenuStrip();
            prueba1ToolStripMenuItem = new ToolStripMenuItem();
            prueba2ToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { prueba1ToolStripMenuItem, prueba2ToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // prueba1ToolStripMenuItem
            // 
            prueba1ToolStripMenuItem.Name = "prueba1ToolStripMenuItem";
            prueba1ToolStripMenuItem.Size = new Size(81, 24);
            prueba1ToolStripMenuItem.Text = "Prueba 1";
            prueba1ToolStripMenuItem.Click += prueba1ToolStripMenuItem_Click;
            // 
            // prueba2ToolStripMenuItem
            // 
            prueba2ToolStripMenuItem.Name = "prueba2ToolStripMenuItem";
            prueba2ToolStripMenuItem.Size = new Size(81, 24);
            prueba2ToolStripMenuItem.Text = "Prueba 2";
            prueba2ToolStripMenuItem.Click += prueba2ToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Evaluacion 1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem prueba1ToolStripMenuItem;
        private ToolStripMenuItem prueba2ToolStripMenuItem;
    }
}
