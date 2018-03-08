namespace Vendors
{
    partial class Form1
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
            this.dgVendors = new System.Windows.Forms.DataGridView();
            this.getData = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgVendors)).BeginInit();
            this.SuspendLayout();
            // 
            // dgVendors
            // 
            this.dgVendors.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgVendors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgVendors.Location = new System.Drawing.Point(12, 12);
            this.dgVendors.Name = "dgVendors";
            this.dgVendors.Size = new System.Drawing.Size(717, 161);
            this.dgVendors.TabIndex = 0;
            this.dgVendors.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgVendors_CellContentClick);
            // 
            // getData
            // 
            this.getData.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.getData.Location = new System.Drawing.Point(344, 335);
            this.getData.Name = "getData";
            this.getData.Size = new System.Drawing.Size(75, 23);
            this.getData.TabIndex = 1;
            this.getData.Text = "Retrieve";
            this.getData.UseVisualStyleBackColor = true;
            this.getData.Click += new System.EventHandler(this.getData_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 370);
            this.Controls.Add(this.getData);
            this.Controls.Add(this.dgVendors);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgVendors)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgVendors;
        private System.Windows.Forms.Button getData;
    }
}

