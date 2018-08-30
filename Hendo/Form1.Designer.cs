namespace Hendo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.HendoTextForm = new System.Windows.Forms.RichTextBox();
            this.menupanel = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.volumeMeter1 = new NAudio.Gui.VolumeMeter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.StatusText = new System.Windows.Forms.TextBox();
            this.menupanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // HendoTextForm
            // 
            this.HendoTextForm.AutoWordSelection = true;
            this.HendoTextForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.HendoTextForm.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.HendoTextForm.DetectUrls = false;
            this.HendoTextForm.Font = new System.Drawing.Font("Gadugi", 7.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HendoTextForm.ForeColor = System.Drawing.SystemColors.Window;
            this.HendoTextForm.Location = new System.Drawing.Point(0, 43);
            this.HendoTextForm.Name = "HendoTextForm";
            this.HendoTextForm.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.HendoTextForm.Size = new System.Drawing.Size(375, 506);
            this.HendoTextForm.TabIndex = 1;
            this.HendoTextForm.Text = "";
            this.HendoTextForm.TextChanged += new System.EventHandler(this.HendoTextForm_TextChanged);
            // 
            // menupanel
            // 
            this.menupanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.menupanel.Controls.Add(this.button2);
            this.menupanel.Controls.Add(this.button3);
            this.menupanel.Controls.Add(this.button4);
            this.menupanel.Controls.Add(this.button1);
            this.menupanel.Location = new System.Drawing.Point(0, 0);
            this.menupanel.Name = "menupanel";
            this.menupanel.Size = new System.Drawing.Size(376, 42);
            this.menupanel.TabIndex = 2;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(95, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 43);
            this.button2.TabIndex = 1;
            this.button2.Text = "Read";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Khaki;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(189, 0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(94, 43);
            this.button3.TabIndex = 2;
            this.button3.Text = "Stop";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Chocolate;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Location = new System.Drawing.Point(283, 0);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(94, 43);
            this.button4.TabIndex = 3;
            this.button4.Text = "Clear";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DodgerBlue;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 43);
            this.button1.TabIndex = 0;
            this.button1.Text = "Listen";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // volumeMeter1
            // 
            this.volumeMeter1.Amplitude = 0F;
            this.volumeMeter1.Location = new System.Drawing.Point(4, 4);
            this.volumeMeter1.MaxDb = 18F;
            this.volumeMeter1.MinDb = -60F;
            this.volumeMeter1.Name = "volumeMeter1";
            this.volumeMeter1.Size = new System.Drawing.Size(145, 13);
            this.volumeMeter1.TabIndex = 3;
            this.volumeMeter1.Text = "volumeMeter1";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.StatusText);
            this.panel1.Controls.Add(this.volumeMeter1);
            this.panel1.Location = new System.Drawing.Point(0, 549);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(375, 21);
            this.panel1.TabIndex = 4;
            // 
            // StatusText
            // 
            this.StatusText.BackColor = System.Drawing.SystemColors.Control;
            this.StatusText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.StatusText.Font = new System.Drawing.Font("Gadugi", 6.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StatusText.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.StatusText.Location = new System.Drawing.Point(183, 4);
            this.StatusText.Name = "StatusText";
            this.StatusText.Size = new System.Drawing.Size(186, 12);
            this.StatusText.TabIndex = 4;
            this.StatusText.Text = "Loading...";
            this.StatusText.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.ClientSize = new System.Drawing.Size(376, 571);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menupanel);
            this.Controls.Add(this.HendoTextForm);
            this.Font = new System.Drawing.Font("Gadugi", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(392, 606);
            this.MinimumSize = new System.Drawing.Size(392, 606);
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Hendo";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menupanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.RichTextBox HendoTextForm;
        private System.Windows.Forms.Panel menupanel;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button1;
        private NAudio.Gui.VolumeMeter volumeMeter1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox StatusText;
    }
}

