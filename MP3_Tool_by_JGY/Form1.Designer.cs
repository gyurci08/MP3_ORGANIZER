namespace MP3_Tool_by_JGY
{
    partial class MP3_Tool_by_JGY
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MP3_Tool_by_JGY));
            this.input_tb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.browse_input_bt = new System.Windows.Forms.Button();
            this.browse_output_bt = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.output_tb = new System.Windows.Forms.TextBox();
            this.generate_bt = new System.Windows.Forms.Button();
            this.log_tb = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // input_tb
            // 
            this.input_tb.Location = new System.Drawing.Point(12, 23);
            this.input_tb.Name = "input_tb";
            this.input_tb.Size = new System.Drawing.Size(450, 20);
            this.input_tb.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Input";
            // 
            // browse_input_bt
            // 
            this.browse_input_bt.Location = new System.Drawing.Point(464, 22);
            this.browse_input_bt.Name = "browse_input_bt";
            this.browse_input_bt.Size = new System.Drawing.Size(70, 21);
            this.browse_input_bt.TabIndex = 2;
            this.browse_input_bt.Text = "Browse";
            this.browse_input_bt.UseVisualStyleBackColor = true;
            this.browse_input_bt.Click += new System.EventHandler(this.browse_input_bt_Click);
            // 
            // browse_output_bt
            // 
            this.browse_output_bt.Location = new System.Drawing.Point(464, 63);
            this.browse_output_bt.Name = "browse_output_bt";
            this.browse_output_bt.Size = new System.Drawing.Size(70, 21);
            this.browse_output_bt.TabIndex = 5;
            this.browse_output_bt.Text = "Browse";
            this.browse_output_bt.UseVisualStyleBackColor = true;
            this.browse_output_bt.Click += new System.EventHandler(this.browse_output_bt_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Output";
            // 
            // output_tb
            // 
            this.output_tb.Location = new System.Drawing.Point(12, 64);
            this.output_tb.Name = "output_tb";
            this.output_tb.Size = new System.Drawing.Size(450, 20);
            this.output_tb.TabIndex = 3;
            // 
            // generate_bt
            // 
            this.generate_bt.Location = new System.Drawing.Point(610, 36);
            this.generate_bt.Name = "generate_bt";
            this.generate_bt.Size = new System.Drawing.Size(117, 37);
            this.generate_bt.TabIndex = 6;
            this.generate_bt.Text = "Generate";
            this.generate_bt.UseVisualStyleBackColor = true;
            this.generate_bt.Click += new System.EventHandler(this.generate_bt_Click);
            // 
            // log_tb
            // 
            this.log_tb.Location = new System.Drawing.Point(12, 134);
            this.log_tb.Multiline = true;
            this.log_tb.Name = "log_tb";
            this.log_tb.Size = new System.Drawing.Size(774, 256);
            this.log_tb.TabIndex = 7;
            // 
            // MP3_Tool_by_JGY
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(798, 402);
            this.Controls.Add(this.log_tb);
            this.Controls.Add(this.generate_bt);
            this.Controls.Add(this.browse_output_bt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.output_tb);
            this.Controls.Add(this.browse_input_bt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.input_tb);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MP3_Tool_by_JGY";
            this.Text = "MP3_Tool_by_JGY";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox input_tb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button browse_input_bt;
        private System.Windows.Forms.Button browse_output_bt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox output_tb;
        private System.Windows.Forms.Button generate_bt;
        private System.Windows.Forms.TextBox log_tb;
    }
}

