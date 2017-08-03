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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShitSplitter));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.txtGameTime = new System.Windows.Forms.TextBox();
            this.labelInputExpected = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.txtGameTime, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelInputExpected, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(355, 30);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // txtGameTime
            // 
            this.txtGameTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtGameTime.BackColor = System.Drawing.SystemColors.Window;
            this.txtGameTime.Location = new System.Drawing.Point(45, 4);
            this.txtGameTime.Margin = new System.Windows.Forms.Padding(4);
            this.txtGameTime.Name = "txtGameTime";
            this.txtGameTime.Size = new System.Drawing.Size(306, 22);
            this.txtGameTime.TabIndex = 1;
            this.txtGameTime.TextChanged += new System.EventHandler(this.txtGameTime_TextChanged);
            this.txtGameTime.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGameTime_KeyPress);
            // 
            // labelInputExpected
            // 
            this.labelInputExpected.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelInputExpected.AutoSize = true;
            this.labelInputExpected.Location = new System.Drawing.Point(3, 6);
            this.labelInputExpected.Name = "labelInputExpected";
            this.labelInputExpected.Size = new System.Drawing.Size(35, 17);
            this.labelInputExpected.TabIndex = 2;
            this.labelInputExpected.Text = "IGT:";
            // 
            // ShitSplitter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 54);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ShitSplitter";
            this.Text = "Enter Game Time";
            this.Load += new System.EventHandler(this.ShitSplitter_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox txtGameTime;
        private System.Windows.Forms.Label labelInputExpected;
    }
}