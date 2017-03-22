namespace LiveSplit.RealTimeMinusBonuses.UI.Components
{
    partial class ShitSplitter
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShitSplitter));
            this.txtGameTime = new System.Windows.Forms.TextBox();
            this.TimeBonusesTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // txtGameTime
            // 
            this.txtGameTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtGameTime.Location = new System.Drawing.Point(16, 15);
            this.txtGameTime.Margin = new System.Windows.Forms.Padding(4);
            this.txtGameTime.Name = "txtGameTime";
            this.txtGameTime.Size = new System.Drawing.Size(345, 22);
            this.txtGameTime.TabIndex = 0;
            this.txtGameTime.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGameTime_KeyPress);
            // 
            // TimeBonusesTimer
            // 
            this.TimeBonusesTimer.Interval = 1000;
            this.TimeBonusesTimer.Tick += new System.EventHandler(this.TimeBonusesTimer_Tick);
            // 
            // ShitSplitter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 54);
            this.Controls.Add(this.txtGameTime);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ShitSplitter";
            this.Text = "Enter Game Time";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtGameTime;
        private System.Windows.Forms.Timer TimeBonusesTimer;
    }
}