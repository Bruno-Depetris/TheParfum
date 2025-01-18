namespace TheParfum.Formularios {
    partial class Stock {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.panel_ContenedorForm = new System.Windows.Forms.Panel();
            this.parrotGradientPanel1 = new ReaLTaiizor.Controls.ParrotGradientPanel();
            this.materialCard_Stock = new ReaLTaiizor.Controls.MaterialCard();
            this.SuspendLayout();
            // 
            // panel_ContenedorForm
            // 
            this.panel_ContenedorForm.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_ContenedorForm.Location = new System.Drawing.Point(0, 0);
            this.panel_ContenedorForm.Name = "panel_ContenedorForm";
            this.panel_ContenedorForm.Size = new System.Drawing.Size(221, 599);
            this.panel_ContenedorForm.TabIndex = 0;
            // 
            // parrotGradientPanel1
            // 
            this.parrotGradientPanel1.BottomLeft = System.Drawing.Color.Black;
            this.parrotGradientPanel1.BottomRight = System.Drawing.Color.Fuchsia;
            this.parrotGradientPanel1.CompositingQualityType = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
            this.parrotGradientPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.parrotGradientPanel1.InterpolationType = System.Drawing.Drawing2D.InterpolationMode.HighQualityBilinear;
            this.parrotGradientPanel1.Location = new System.Drawing.Point(221, 0);
            this.parrotGradientPanel1.Name = "parrotGradientPanel1";
            this.parrotGradientPanel1.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            this.parrotGradientPanel1.PrimerColor = System.Drawing.Color.White;
            this.parrotGradientPanel1.Size = new System.Drawing.Size(5, 599);
            this.parrotGradientPanel1.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            this.parrotGradientPanel1.Style = ReaLTaiizor.Controls.ParrotGradientPanel.GradientStyle.Vertical;
            this.parrotGradientPanel1.TabIndex = 1;
            this.parrotGradientPanel1.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.parrotGradientPanel1.TopLeft = System.Drawing.Color.Silver;
            this.parrotGradientPanel1.TopRight = System.Drawing.Color.White;
            // 
            // materialCard_Stock
            // 
            this.materialCard_Stock.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialCard_Stock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard_Stock.Depth = 0;
            this.materialCard_Stock.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard_Stock.Location = new System.Drawing.Point(243, 23);
            this.materialCard_Stock.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard_Stock.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.materialCard_Stock.Name = "materialCard_Stock";
            this.materialCard_Stock.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard_Stock.Size = new System.Drawing.Size(511, 553);
            this.materialCard_Stock.TabIndex = 3;
            // 
            // Stock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(777, 599);
            this.Controls.Add(this.materialCard_Stock);
            this.Controls.Add(this.parrotGradientPanel1);
            this.Controls.Add(this.panel_ContenedorForm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Stock";
            this.Text = "Stock";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_ContenedorForm;
        private ReaLTaiizor.Controls.ParrotGradientPanel parrotGradientPanel1;
        private ReaLTaiizor.Controls.MaterialCard materialCard_Stock;
    }
}