
namespace Tech.PracticalAplications.FactoryMethod.MyApp.Presentation
{
    partial class LinkViewAddNew
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlLink = new System.Windows.Forms.Panel();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.txtLine = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.pnlLink.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlLink
            // 
            this.pnlLink.Controls.Add(this.btnAddNew);
            this.pnlLink.Controls.Add(this.txtLine);
            this.pnlLink.Controls.Add(this.txtName);
            this.pnlLink.Location = new System.Drawing.Point(14, 15);
            this.pnlLink.Name = "pnlLink";
            this.pnlLink.Size = new System.Drawing.Size(775, 130);
            this.pnlLink.TabIndex = 0;
            // 
            // btnAddNew
            // 
            this.btnAddNew.Location = new System.Drawing.Point(600, 24);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(141, 29);
            this.btnAddNew.TabIndex = 2;
            this.btnAddNew.Text = "Add New";
            this.btnAddNew.UseVisualStyleBackColor = true;
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // txtLine
            // 
            this.txtLine.Location = new System.Drawing.Point(29, 78);
            this.txtLine.Name = "txtLine";
            this.txtLine.Size = new System.Drawing.Size(712, 27);
            this.txtLine.TabIndex = 1;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(29, 24);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(401, 27);
            this.txtName.TabIndex = 0;
            // 
            // LinkViewAddNew
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlLink);
            this.Name = "LinkViewAddNew";
            this.Size = new System.Drawing.Size(807, 161);
            this.pnlLink.ResumeLayout(false);
            this.pnlLink.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlLink;
        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.TextBox txtLine;
        private System.Windows.Forms.TextBox txtName;
    }
}
