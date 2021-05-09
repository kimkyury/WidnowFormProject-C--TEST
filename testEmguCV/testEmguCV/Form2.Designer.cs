
namespace testEmguCV
{
    partial class Form2
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
            this.Canny = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.numericThresholdLink = new System.Windows.Forms.NumericUpDown();
            this.numericThreshold = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Canny.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericThresholdLink)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericThreshold)).BeginInit();
            this.SuspendLayout();
            // 
            // Canny
            // 
            this.Canny.Controls.Add(this.button2);
            this.Canny.Controls.Add(this.button1);
            this.Canny.Controls.Add(this.numericThresholdLink);
            this.Canny.Controls.Add(this.numericThreshold);
            this.Canny.Controls.Add(this.label2);
            this.Canny.Controls.Add(this.label1);
            this.Canny.Location = new System.Drawing.Point(36, 13);
            this.Canny.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Canny.Name = "Canny";
            this.Canny.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Canny.Size = new System.Drawing.Size(433, 182);
            this.Canny.TabIndex = 1;
            this.Canny.TabStop = false;
            this.Canny.Text = "groupBox1";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(242, 124);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(86, 29);
            this.button2.TabIndex = 4;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(134, 124);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 29);
            this.button1.TabIndex = 3;
            this.button1.Text = "Apply";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // numericThresholdLink
            // 
            this.numericThresholdLink.Location = new System.Drawing.Point(168, 90);
            this.numericThresholdLink.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.numericThresholdLink.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericThresholdLink.Name = "numericThresholdLink";
            this.numericThresholdLink.Size = new System.Drawing.Size(137, 25);
            this.numericThresholdLink.TabIndex = 2;
            this.numericThresholdLink.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // numericThreshold
            // 
            this.numericThreshold.Location = new System.Drawing.Point(168, 48);
            this.numericThreshold.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.numericThreshold.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericThreshold.Name = "numericThreshold";
            this.numericThreshold.Size = new System.Drawing.Size(137, 25);
            this.numericThreshold.TabIndex = 2;
            this.numericThreshold.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Threshold Link : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(73, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Threshold : ";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 221);
            this.Controls.Add(this.Canny);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Canny.ResumeLayout(false);
            this.Canny.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericThresholdLink)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericThreshold)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Canny;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NumericUpDown numericThresholdLink;
        private System.Windows.Forms.NumericUpDown numericThreshold;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}