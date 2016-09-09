namespace shotgun
{
    partial class frmShotgun
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
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnBlock = new System.Windows.Forms.Button();
            this.btnFire = new System.Windows.Forms.Button();
            this.lblPlayerAmmoCount = new System.Windows.Forms.Label();
            this.lblComputerAmmoCount = new System.Windows.Forms.Label();
            this.lblComputerAmmo = new System.Windows.Forms.Label();
            this.lblPlayerAmmo = new System.Windows.Forms.Label();
            this.lblEventLog = new System.Windows.Forms.Label();
            this.btnShotgun = new System.Windows.Forms.Button();
            this.lblHeader = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(28, 96);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(75, 23);
            this.btnLoad.TabIndex = 0;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnBlock
            // 
            this.btnBlock.Location = new System.Drawing.Point(109, 96);
            this.btnBlock.Name = "btnBlock";
            this.btnBlock.Size = new System.Drawing.Size(75, 23);
            this.btnBlock.TabIndex = 1;
            this.btnBlock.Text = "Block";
            this.btnBlock.UseVisualStyleBackColor = true;
            this.btnBlock.Click += new System.EventHandler(this.btnBlock_Click);
            // 
            // btnFire
            // 
            this.btnFire.Enabled = false;
            this.btnFire.Location = new System.Drawing.Point(190, 96);
            this.btnFire.Name = "btnFire";
            this.btnFire.Size = new System.Drawing.Size(75, 23);
            this.btnFire.TabIndex = 2;
            this.btnFire.Text = "Fire";
            this.btnFire.UseVisualStyleBackColor = true;
            this.btnFire.Click += new System.EventHandler(this.btnFire_Click);
            // 
            // lblPlayerAmmoCount
            // 
            this.lblPlayerAmmoCount.AutoSize = true;
            this.lblPlayerAmmoCount.Location = new System.Drawing.Point(241, 164);
            this.lblPlayerAmmoCount.Name = "lblPlayerAmmoCount";
            this.lblPlayerAmmoCount.Size = new System.Drawing.Size(24, 13);
            this.lblPlayerAmmoCount.TabIndex = 3;
            this.lblPlayerAmmoCount.Text = "0/3";
            // 
            // lblComputerAmmoCount
            // 
            this.lblComputerAmmoCount.AutoSize = true;
            this.lblComputerAmmoCount.Location = new System.Drawing.Point(241, 177);
            this.lblComputerAmmoCount.Name = "lblComputerAmmoCount";
            this.lblComputerAmmoCount.Size = new System.Drawing.Size(24, 13);
            this.lblComputerAmmoCount.TabIndex = 4;
            this.lblComputerAmmoCount.Text = "0/3";
            // 
            // lblComputerAmmo
            // 
            this.lblComputerAmmo.AutoSize = true;
            this.lblComputerAmmo.Location = new System.Drawing.Point(124, 177);
            this.lblComputerAmmo.Name = "lblComputerAmmo";
            this.lblComputerAmmo.Size = new System.Drawing.Size(111, 13);
            this.lblComputerAmmo.TabIndex = 5;
            this.lblComputerAmmo.Text = "Computer ammunition:";
            // 
            // lblPlayerAmmo
            // 
            this.lblPlayerAmmo.AutoSize = true;
            this.lblPlayerAmmo.Location = new System.Drawing.Point(140, 164);
            this.lblPlayerAmmo.Name = "lblPlayerAmmo";
            this.lblPlayerAmmo.Size = new System.Drawing.Size(95, 13);
            this.lblPlayerAmmo.TabIndex = 6;
            this.lblPlayerAmmo.Text = "Player ammunition:";
            // 
            // lblEventLog
            // 
            this.lblEventLog.AutoSize = true;
            this.lblEventLog.Location = new System.Drawing.Point(25, 125);
            this.lblEventLog.Name = "lblEventLog";
            this.lblEventLog.Size = new System.Drawing.Size(52, 13);
            this.lblEventLog.TabIndex = 7;
            this.lblEventLog.Text = "Event log";
            // 
            // btnShotgun
            // 
            this.btnShotgun.Enabled = false;
            this.btnShotgun.Location = new System.Drawing.Point(190, 125);
            this.btnShotgun.Name = "btnShotgun";
            this.btnShotgun.Size = new System.Drawing.Size(75, 23);
            this.btnShotgun.TabIndex = 8;
            this.btnShotgun.Text = "Shotgun!";
            this.btnShotgun.UseVisualStyleBackColor = true;
            this.btnShotgun.Click += new System.EventHandler(this.btnShotgun_Click);
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Gigi", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.Location = new System.Drawing.Point(79, 22);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(133, 44);
            this.lblHeader.TabIndex = 9;
            this.lblHeader.Text = "Shotgun!";
            // 
            // frmShotgun
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(284, 204);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.btnShotgun);
            this.Controls.Add(this.lblEventLog);
            this.Controls.Add(this.lblPlayerAmmo);
            this.Controls.Add(this.lblComputerAmmo);
            this.Controls.Add(this.lblComputerAmmoCount);
            this.Controls.Add(this.lblPlayerAmmoCount);
            this.Controls.Add(this.btnFire);
            this.Controls.Add(this.btnBlock);
            this.Controls.Add(this.btnLoad);
            this.Name = "frmShotgun";
            this.Text = "Shotgun";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnBlock;
        private System.Windows.Forms.Button btnFire;
        private System.Windows.Forms.Label lblPlayerAmmoCount;
        private System.Windows.Forms.Label lblComputerAmmoCount;
        private System.Windows.Forms.Label lblComputerAmmo;
        private System.Windows.Forms.Label lblPlayerAmmo;
        private System.Windows.Forms.Label lblEventLog;
        private System.Windows.Forms.Button btnShotgun;
        private System.Windows.Forms.Label lblHeader;
    }
}

