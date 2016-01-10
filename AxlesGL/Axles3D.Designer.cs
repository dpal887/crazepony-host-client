namespace AxlesGL
{
    partial class Axles3D
    {
        /// <Summary>
        /// Required designer variable.
        /// </ Summary>
        private System.ComponentModel.IContainer components = null;

        /// <Summary>
        /// Clean up all the resources being used.
        /// </ Summary>
        /// <Param name = "disposing"> if managed resources should be released, it is true; otherwise, false. </ Param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <Summary>
        /// Required method for Designer support - do not
        /// Using the code editor to modify the contents of this method.
        /// </ Summary>
        private void InitializeComponent()
        {
            this.SuspendLayout();
            //
            // Axles3D
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "Axles3D";
            this.Load += new System.EventHandler(this.Axles3D_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Axles3D_Paint);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Axles3D_MouseMove);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Axles3D_MouseDown);
            this.Resize += new System.EventHandler(this.Axles3D_Resize);
            this.ResumeLayout(false);

        }

        #endregion





    }
}