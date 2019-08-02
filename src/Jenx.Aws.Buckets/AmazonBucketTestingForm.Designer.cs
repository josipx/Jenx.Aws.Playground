namespace Jenx.Aws.Buckets
{
    partial class AmazonBucketTestingForm
    {        
        private System.ComponentModel.IContainer components = null;
    
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
      
        private void InitializeComponent()
        {
            this.GetBucketSubfolderTestButton = new System.Windows.Forms.Button();
            this.CreateEmptyBucketTestButton = new System.Windows.Forms.Button();
            this.PrivateBucketFlag = new System.Windows.Forms.CheckBox();
            this.CreateEmptyBucketAndUploadTestButton = new System.Windows.Forms.Button();
            this.OutputControl = new System.Windows.Forms.TextBox();
            this.ListBucketSubfoldersButton = new System.Windows.Forms.Button();
            this.CreateAndDeleteEmptyBucketTestButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // GetBucketSubfolderTestButton
            // 
            this.GetBucketSubfolderTestButton.Location = new System.Drawing.Point(20, 154);
            this.GetBucketSubfolderTestButton.Name = "GetBucketSubfolderTestButton";
            this.GetBucketSubfolderTestButton.Size = new System.Drawing.Size(242, 40);
            this.GetBucketSubfolderTestButton.TabIndex = 0;
            this.GetBucketSubfolderTestButton.Text = "Get Bucket Subfolder list";
            this.GetBucketSubfolderTestButton.UseVisualStyleBackColor = true;
            this.GetBucketSubfolderTestButton.Click += new System.EventHandler(this.GetBucketSubfolderTestButton_Click);
            // 
            // CreateEmptyBucketTestButton
            // 
            this.CreateEmptyBucketTestButton.Location = new System.Drawing.Point(20, 17);
            this.CreateEmptyBucketTestButton.Name = "CreateEmptyBucketTestButton";
            this.CreateEmptyBucketTestButton.Size = new System.Drawing.Size(242, 32);
            this.CreateEmptyBucketTestButton.TabIndex = 1;
            this.CreateEmptyBucketTestButton.Text = "Create Empty Aws Bucket";
            this.CreateEmptyBucketTestButton.UseVisualStyleBackColor = true;
            this.CreateEmptyBucketTestButton.Click += new System.EventHandler(this.CreateEmptyBucketTestButton_Click);
            // 
            // PrivateBucketFlag
            // 
            this.PrivateBucketFlag.AutoSize = true;
            this.PrivateBucketFlag.Location = new System.Drawing.Point(268, 24);
            this.PrivateBucketFlag.Name = "PrivateBucketFlag";
            this.PrivateBucketFlag.Size = new System.Drawing.Size(121, 21);
            this.PrivateBucketFlag.TabIndex = 3;
            this.PrivateBucketFlag.Text = "Private Bucket";
            this.PrivateBucketFlag.UseVisualStyleBackColor = true;
            // 
            // CreateEmptyBucketAndUploadTestButton
            // 
            this.CreateEmptyBucketAndUploadTestButton.Location = new System.Drawing.Point(20, 55);
            this.CreateEmptyBucketAndUploadTestButton.Name = "CreateEmptyBucketAndUploadTestButton";
            this.CreateEmptyBucketAndUploadTestButton.Size = new System.Drawing.Size(242, 51);
            this.CreateEmptyBucketAndUploadTestButton.TabIndex = 4;
            this.CreateEmptyBucketAndUploadTestButton.Text = "Create Empty Aws Bucket and Upload File";
            this.CreateEmptyBucketAndUploadTestButton.UseVisualStyleBackColor = true;
            this.CreateEmptyBucketAndUploadTestButton.Click += new System.EventHandler(this.CreateEmptyBucketAndUploadTestButton_Click);
            // 
            // OutputControl
            // 
            this.OutputControl.Location = new System.Drawing.Point(276, 59);
            this.OutputControl.Multiline = true;
            this.OutputControl.Name = "OutputControl";
            this.OutputControl.Size = new System.Drawing.Size(693, 192);
            this.OutputControl.TabIndex = 5;
            // 
            // ListBucketSubfoldersButton
            // 
            this.ListBucketSubfoldersButton.Location = new System.Drawing.Point(20, 200);
            this.ListBucketSubfoldersButton.Name = "ListBucketSubfoldersButton";
            this.ListBucketSubfoldersButton.Size = new System.Drawing.Size(242, 51);
            this.ListBucketSubfoldersButton.TabIndex = 6;
            this.ListBucketSubfoldersButton.Text = "List bucket subfolders";
            this.ListBucketSubfoldersButton.UseVisualStyleBackColor = true;
            this.ListBucketSubfoldersButton.Click += new System.EventHandler(this.GetBucketSubfolderTestButton_Click);
            // 
            // CreateAndDeleteEmptyBucketTestButton
            // 
            this.CreateAndDeleteEmptyBucketTestButton.Location = new System.Drawing.Point(20, 112);
            this.CreateAndDeleteEmptyBucketTestButton.Name = "CreateAndDeleteEmptyBucketTestButton";
            this.CreateAndDeleteEmptyBucketTestButton.Size = new System.Drawing.Size(242, 36);
            this.CreateAndDeleteEmptyBucketTestButton.TabIndex = 7;
            this.CreateAndDeleteEmptyBucketTestButton.Text = "Create and delete Aws Bucket";
            this.CreateAndDeleteEmptyBucketTestButton.UseVisualStyleBackColor = true;
            this.CreateAndDeleteEmptyBucketTestButton.Click += new System.EventHandler(this.CreateAndDeleteEmptyBucketTestButton_Click);
            // 
            // AwsBucketsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(981, 265);
            this.Controls.Add(this.CreateAndDeleteEmptyBucketTestButton);
            this.Controls.Add(this.ListBucketSubfoldersButton);
            this.Controls.Add(this.OutputControl);
            this.Controls.Add(this.CreateEmptyBucketAndUploadTestButton);
            this.Controls.Add(this.PrivateBucketFlag);
            this.Controls.Add(this.GetBucketSubfolderTestButton);
            this.Controls.Add(this.CreateEmptyBucketTestButton);
            this.Name = "AwsBucketsForm";
            this.Text = "Aws Buckets Playground";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button GetBucketSubfolderTestButton;
        private System.Windows.Forms.Button CreateEmptyBucketTestButton;
        private System.Windows.Forms.CheckBox PrivateBucketFlag;
        private System.Windows.Forms.Button CreateEmptyBucketAndUploadTestButton;
        private System.Windows.Forms.TextBox OutputControl;
        private System.Windows.Forms.Button ListBucketSubfoldersButton;
        private System.Windows.Forms.Button CreateAndDeleteEmptyBucketTestButton;
    }
}

