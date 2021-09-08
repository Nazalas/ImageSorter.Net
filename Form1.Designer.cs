
namespace Image_Sorter
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
            this.txtSourceDirectory = new System.Windows.Forms.TextBox();
            this.lblSourceDirectory = new System.Windows.Forms.Label();
            this.lblTargetDirectory = new System.Windows.Forms.Label();
            this.txtTargetDirectory = new System.Windows.Forms.TextBox();
            this.btnRun = new System.Windows.Forms.Button();
            this.txtResults = new System.Windows.Forms.TextBox();
            this.chkRecursive = new System.Windows.Forms.CheckBox();
            this.chkOverwrite = new System.Windows.Forms.CheckBox();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // txtSourceDirectory
            // 
            this.txtSourceDirectory.Location = new System.Drawing.Point(12, 32);
            this.txtSourceDirectory.Name = "txtSourceDirectory";
            this.txtSourceDirectory.Size = new System.Drawing.Size(244, 20);
            this.txtSourceDirectory.TabIndex = 1;
            // 
            // lblSourceDirectory
            // 
            this.lblSourceDirectory.AutoSize = true;
            this.lblSourceDirectory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSourceDirectory.Location = new System.Drawing.Point(12, 9);
            this.lblSourceDirectory.Name = "lblSourceDirectory";
            this.lblSourceDirectory.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblSourceDirectory.Size = new System.Drawing.Size(127, 20);
            this.lblSourceDirectory.TabIndex = 2;
            this.lblSourceDirectory.Text = "Source Directory";
            // 
            // lblTargetDirectory
            // 
            this.lblTargetDirectory.AutoSize = true;
            this.lblTargetDirectory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTargetDirectory.Location = new System.Drawing.Point(286, 9);
            this.lblTargetDirectory.Name = "lblTargetDirectory";
            this.lblTargetDirectory.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblTargetDirectory.Size = new System.Drawing.Size(122, 20);
            this.lblTargetDirectory.TabIndex = 5;
            this.lblTargetDirectory.Text = "Target Directory";
            // 
            // txtTargetDirectory
            // 
            this.txtTargetDirectory.Location = new System.Drawing.Point(286, 32);
            this.txtTargetDirectory.Name = "txtTargetDirectory";
            this.txtTargetDirectory.Size = new System.Drawing.Size(244, 20);
            this.txtTargetDirectory.TabIndex = 4;
            // 
            // btnRun
            // 
            this.btnRun.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRun.Location = new System.Drawing.Point(554, 16);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(90, 36);
            this.btnRun.TabIndex = 6;
            this.btnRun.Text = "Run Sort";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // txtResults
            // 
            this.txtResults.Location = new System.Drawing.Point(12, 87);
            this.txtResults.Multiline = true;
            this.txtResults.Name = "txtResults";
            this.txtResults.Size = new System.Drawing.Size(632, 345);
            this.txtResults.TabIndex = 7;
            // 
            // chkRecursive
            // 
            this.chkRecursive.AutoSize = true;
            this.chkRecursive.Location = new System.Drawing.Point(145, 12);
            this.chkRecursive.Name = "chkRecursive";
            this.chkRecursive.Size = new System.Drawing.Size(74, 17);
            this.chkRecursive.TabIndex = 8;
            this.chkRecursive.Text = "Recursive";
            this.chkRecursive.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.chkRecursive.UseVisualStyleBackColor = true;
            // 
            // chkOverwrite
            // 
            this.chkOverwrite.AutoSize = true;
            this.chkOverwrite.Location = new System.Drawing.Point(414, 13);
            this.chkOverwrite.Name = "chkOverwrite";
            this.chkOverwrite.Size = new System.Drawing.Size(109, 17);
            this.chkOverwrite.TabIndex = 9;
            this.chkOverwrite.Text = "Overwrite if Exists";
            this.chkOverwrite.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.chkOverwrite.UseVisualStyleBackColor = true;
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(12, 58);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(631, 23);
            this.progressBar.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 444);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.chkOverwrite);
            this.Controls.Add(this.chkRecursive);
            this.Controls.Add(this.txtResults);
            this.Controls.Add(this.btnRun);
            this.Controls.Add(this.lblTargetDirectory);
            this.Controls.Add(this.txtTargetDirectory);
            this.Controls.Add(this.lblSourceDirectory);
            this.Controls.Add(this.txtSourceDirectory);
            this.Name = "Form1";
            this.Text = "Image Sorter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSourceDirectory;
        private System.Windows.Forms.Label lblSourceDirectory;
        private System.Windows.Forms.Label lblTargetDirectory;
        private System.Windows.Forms.TextBox txtTargetDirectory;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.TextBox txtResults;
        private System.Windows.Forms.CheckBox chkRecursive;
        private System.Windows.Forms.CheckBox chkOverwrite;
        private System.Windows.Forms.ProgressBar progressBar;
    }
}

