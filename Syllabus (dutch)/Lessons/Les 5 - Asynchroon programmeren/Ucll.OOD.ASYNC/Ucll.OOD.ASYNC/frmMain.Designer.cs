namespace Ucll.OOD.ASYNC
{
    partial class FrmMain
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
            this.tbOutput = new System.Windows.Forms.TextBox();
            this.btnSync = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnSync2 = new System.Windows.Forms.Button();
            this.btnAsync = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAsyncWithCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbOutput
            // 
            this.tbOutput.Location = new System.Drawing.Point(11, 269);
            this.tbOutput.Multiline = true;
            this.tbOutput.Name = "tbOutput";
            this.tbOutput.Size = new System.Drawing.Size(777, 169);
            this.tbOutput.TabIndex = 0;
            // 
            // btnSync
            // 
            this.btnSync.Location = new System.Drawing.Point(11, 12);
            this.btnSync.Name = "btnSync";
            this.btnSync.Size = new System.Drawing.Size(299, 29);
            this.btnSync.TabIndex = 1;
            this.btnSync.Text = "Download SYNC";
            this.btnSync.UseVisualStyleBackColor = true;
            this.btnSync.Click += new System.EventHandler(this.BtnSync_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(586, 12);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(202, 251);
            this.textBox1.TabIndex = 2;
            // 
            // btnSync2
            // 
            this.btnSync2.Location = new System.Drawing.Point(11, 47);
            this.btnSync2.Name = "btnSync2";
            this.btnSync2.Size = new System.Drawing.Size(299, 29);
            this.btnSync2.TabIndex = 3;
            this.btnSync2.Text = "Download SYNC - not blocking GUI";
            this.btnSync2.UseVisualStyleBackColor = true;
            this.btnSync2.Click += new System.EventHandler(this.BtnSync2_Click);
            // 
            // btnAsync
            // 
            this.btnAsync.Location = new System.Drawing.Point(11, 83);
            this.btnAsync.Name = "btnAsync";
            this.btnAsync.Size = new System.Drawing.Size(299, 29);
            this.btnAsync.TabIndex = 4;
            this.btnAsync.Text = "Download ASYNC";
            this.btnAsync.UseVisualStyleBackColor = true;
            this.btnAsync.Click += new System.EventHandler(this.BtnAsync_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(11, 152);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(299, 29);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel download";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAsyncWithCancel
            // 
            this.btnAsyncWithCancel.Location = new System.Drawing.Point(14, 117);
            this.btnAsyncWithCancel.Name = "btnAsyncWithCancel";
            this.btnAsyncWithCancel.Size = new System.Drawing.Size(299, 29);
            this.btnAsyncWithCancel.TabIndex = 6;
            this.btnAsyncWithCancel.Text = "Download ASYNC with CANCEL";
            this.btnAsyncWithCancel.UseVisualStyleBackColor = true;
            this.btnAsyncWithCancel.Click += new System.EventHandler(this.btnAsyncWithCancel_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 451);
            this.Controls.Add(this.btnAsyncWithCancel);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAsync);
            this.Controls.Add(this.btnSync2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnSync);
            this.Controls.Add(this.tbOutput);
            this.Name = "FrmMain";
            this.Text = "Demo Async";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox tbOutput;
        private Button btnSync;
        private TextBox textBox1;
        private Button btnSync2;
        private Button btnAsync;
        private Button btnCancel;
        private Button btnAsyncWithCancel;
    }
}