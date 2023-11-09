namespace wishApp
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.újKívánságToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listázásToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wishesDataGridView = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wishesDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.újKívánságToolStripMenuItem,
            this.listázásToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // újKívánságToolStripMenuItem
            // 
            this.újKívánságToolStripMenuItem.Name = "újKívánságToolStripMenuItem";
            this.újKívánságToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.újKívánságToolStripMenuItem.Text = "Add Wish";
            this.újKívánságToolStripMenuItem.Click += new System.EventHandler(this.újKívánságToolStripMenuItem_Click);
            // 
            // listázásToolStripMenuItem
            // 
            this.listázásToolStripMenuItem.Name = "listázásToolStripMenuItem";
            this.listázásToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.listázásToolStripMenuItem.Text = "List wishes";
            this.listázásToolStripMenuItem.Click += new System.EventHandler(this.listázásToolStripMenuItem_Click);
            // 
            // wishesDataGridView
            // 
            this.wishesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.wishesDataGridView.Location = new System.Drawing.Point(12, 27);
            this.wishesDataGridView.Name = "wishesDataGridView";
            this.wishesDataGridView.RowTemplate.Height = 25;
            this.wishesDataGridView.Size = new System.Drawing.Size(623, 359);
            this.wishesDataGridView.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.wishesDataGridView);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Wish Handler 2000";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wishesDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem újKívánságToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listázásToolStripMenuItem;
        private System.Windows.Forms.DataGridView wishesDataGridView;
    }
}
