namespace TemperatureMonitor
{
    partial class Window
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
            this.output = new System.Windows.Forms.Label();
            this.farenheight = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // output
            // 
            this.output.AutoSize = true;
            this.output.Location = new System.Drawing.Point(12, 9);
            this.output.Name = "output";
            this.output.Size = new System.Drawing.Size(78, 20);
            this.output.TabIndex = 0;
            this.output.Text = "Loading...";
            // 
            // farenheight
            // 
            this.farenheight.AutoSize = true;
            this.farenheight.Location = new System.Drawing.Point(12, 208);
            this.farenheight.Name = "farenheight";
            this.farenheight.Size = new System.Drawing.Size(154, 24);
            this.farenheight.TabIndex = 1;
            this.farenheight.Text = "Use Farenheight";
            this.farenheight.UseVisualStyleBackColor = true;
            // 
            // Window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(278, 244);
            this.Controls.Add(this.farenheight);
            this.Controls.Add(this.output);
            this.Name = "Window";
            this.Text = "Temperature Monitor";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Window_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label output;
        private System.Windows.Forms.CheckBox farenheight;
    }
}

