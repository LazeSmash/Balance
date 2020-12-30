namespace Balance
{
    partial class main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(main));
            this.header = new System.Windows.Forms.Panel();
            this.logo = new System.Windows.Forms.PictureBox();
            this.title = new System.Windows.Forms.Label();
            this.start = new System.Windows.Forms.Button();
            this.copyright = new System.Windows.Forms.Label();
            this.language = new System.Windows.Forms.Label();
            this.version = new System.Windows.Forms.Label();
            this.version_text = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.current = new System.Windows.Forms.Label();
            this.current_amount = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.SuspendLayout();
            // 
            // header
            // 
            this.header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            this.header.Controls.Add(this.language);
            this.header.Controls.Add(this.title);
            this.header.Controls.Add(this.logo);
            this.header.Dock = System.Windows.Forms.DockStyle.Top;
            this.header.ForeColor = System.Drawing.Color.Transparent;
            this.header.Location = new System.Drawing.Point(0, 0);
            this.header.Margin = new System.Windows.Forms.Padding(3, 50, 3, 3);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(919, 62);
            this.header.TabIndex = 0;
            this.header.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // logo
            // 
            this.logo.Image = ((System.Drawing.Image)(resources.GetObject("logo.Image")));
            this.logo.Location = new System.Drawing.Point(3, 0);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(142, 62);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logo.TabIndex = 0;
            this.logo.TabStop = false;
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.Location = new System.Drawing.Point(98, 9);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(114, 38);
            this.title.TabIndex = 1;
            this.title.Text = "Balance";
            this.title.Click += new System.EventHandler(this.label1_Click);
            // 
            // start
            // 
            this.start.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            this.start.Cursor = System.Windows.Forms.Cursors.Hand;
            this.start.FlatAppearance.BorderSize = 0;
            this.start.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.start.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.start.ForeColor = System.Drawing.Color.White;
            this.start.Location = new System.Drawing.Point(12, 68);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(212, 48);
            this.start.TabIndex = 1;
            this.start.Text = "Undefined";
            this.start.UseVisualStyleBackColor = false;
            // 
            // copyright
            // 
            this.copyright.AutoSize = true;
            this.copyright.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.copyright.Location = new System.Drawing.Point(780, 458);
            this.copyright.Name = "copyright";
            this.copyright.Size = new System.Drawing.Size(127, 19);
            this.copyright.TabIndex = 3;
            this.copyright.Text = "© 2020 LazeSmash";
            // 
            // language
            // 
            this.language.AutoSize = true;
            this.language.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.language.Location = new System.Drawing.Point(208, 26);
            this.language.Name = "language";
            this.language.Size = new System.Drawing.Size(73, 17);
            this.language.TabIndex = 2;
            this.language.Text = "Undefined";
            // 
            // version
            // 
            this.version.AutoSize = true;
            this.version.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.version.Location = new System.Drawing.Point(12, 443);
            this.version.Name = "version";
            this.version.Size = new System.Drawing.Size(90, 17);
            this.version.TabIndex = 4;
            this.version.Text = "V. Undefined";
            // 
            // version_text
            // 
            this.version_text.AutoSize = true;
            this.version_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.version_text.Location = new System.Drawing.Point(12, 460);
            this.version_text.Name = "version_text";
            this.version_text.Size = new System.Drawing.Size(73, 17);
            this.version_text.TabIndex = 6;
            this.version_text.Text = "Undefined";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(12, 122);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(212, 48);
            this.button1.TabIndex = 7;
            this.button1.Text = "Undefined";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // current
            // 
            this.current.AutoSize = true;
            this.current.Font = new System.Drawing.Font("Comic Sans MS", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.current.Location = new System.Drawing.Point(394, 216);
            this.current.Name = "current";
            this.current.Size = new System.Drawing.Size(128, 32);
            this.current.TabIndex = 8;
            this.current.Text = "Undefined";
            this.current.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.current.UseMnemonic = false;
            // 
            // current_amount
            // 
            this.current_amount.AutoSize = true;
            this.current_amount.Font = new System.Drawing.Font("Comic Sans MS", 12.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.current_amount.Location = new System.Drawing.Point(372, 248);
            this.current_amount.Name = "current_amount";
            this.current_amount.Size = new System.Drawing.Size(181, 24);
            this.current_amount.TabIndex = 9;
            this.current_amount.Text = "Undefined Undefined";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(798, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 28);
            this.label3.TabIndex = 10;
            this.label3.Text = "Undefined";
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(209)))), ((int)(((byte)(209)))));
            this.ClientSize = new System.Drawing.Size(919, 486);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.current_amount);
            this.Controls.Add(this.current);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.version_text);
            this.Controls.Add(this.version);
            this.Controls.Add(this.copyright);
            this.Controls.Add(this.start);
            this.Controls.Add(this.header);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "main";
            this.Text = "Balance";
            this.header.ResumeLayout(false);
            this.header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel header;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.Button start;
        private System.Windows.Forms.Label copyright;
        private System.Windows.Forms.Label language;
        private System.Windows.Forms.Label version;
        private System.Windows.Forms.Label version_text;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label current;
        private System.Windows.Forms.Label current_amount;
        private System.Windows.Forms.Label label3;
    }
}

