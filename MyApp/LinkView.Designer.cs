
namespace Tech.PracticalAplications.FactoryMethod.MyApp.Presentation
{
    partial class LinkView
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
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtLine = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.pnlLink.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlLink
            // 
            this.pnlLink.Controls.Add(this.btnDelete);
            this.pnlLink.Controls.Add(this.btnUpdate);
            this.pnlLink.Controls.Add(this.txtLine);
            this.pnlLink.Controls.Add(this.txtName);
            this.pnlLink.Location = new System.Drawing.Point(15, 15);
            this.pnlLink.Name = "pnlLink";
            this.pnlLink.Size = new System.Drawing.Size(777, 228);
            this.pnlLink.TabIndex = 0;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(637, 159);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(94, 29);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(513, 159);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(94, 29);
            this.btnUpdate.TabIndex = 2;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtLine
            // 
            this.txtLine.Location = new System.Drawing.Point(33, 91);
            this.txtLine.Name = "txtLine";
            this.txtLine.Size = new System.Drawing.Size(698, 27);
            this.txtLine.TabIndex = 1;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(33, 32);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(331, 27);
            this.txtName.TabIndex = 0;
            // 
            // LinkView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlLink);
            this.Name = "LinkView";
            this.Size = new System.Drawing.Size(807, 260);
            this.pnlLink.ResumeLayout(false);
            this.pnlLink.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlLink;
        private System.Windows.Forms.TextBox txtLine;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
    }
}
