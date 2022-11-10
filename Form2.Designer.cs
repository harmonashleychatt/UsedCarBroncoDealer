
namespace Ch12_Prog_EX_CarDealer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_1985 = new System.Windows.Forms.Button();
            this.btn1990 = new System.Windows.Forms.Button();
            this.btn_rtnHome = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(6, 106);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(314, 195);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Firebrick;
            this.panel1.Controls.Add(this.richTextBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(65, 41);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(320, 168);
            this.panel1.TabIndex = 1;
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.Black;
            this.richTextBox1.Font = new System.Drawing.Font("Perpetua Titling MT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.ForeColor = System.Drawing.SystemColors.Window;
            this.richTextBox1.Location = new System.Drawing.Point(58, 93);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.richTextBox1.Size = new System.Drawing.Size(212, 123);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.TabStop = false;
            this.richTextBox1.Text = "Price: $10,050.00\nMiles 350,000\nCondition: Good";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel2.BackColor = System.Drawing.Color.Firebrick;
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Location = new System.Drawing.Point(65, 208);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(320, 322);
            this.panel2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Perpetua Titling MT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LightGray;
            this.label1.Location = new System.Drawing.Point(53, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "1995 Ford Bronco";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btn_1985
            // 
            this.btn_1985.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_1985.BackgroundImage")));
            this.btn_1985.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_1985.Location = new System.Drawing.Point(575, 294);
            this.btn_1985.Name = "btn_1985";
            this.btn_1985.Size = new System.Drawing.Size(256, 144);
            this.btn_1985.TabIndex = 3;
            this.btn_1985.UseVisualStyleBackColor = true;
            this.btn_1985.Click += new System.EventHandler(this.btn_1985_Click);
            // 
            // btn1990
            // 
            this.btn1990.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn1990.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn1990.Image = ((System.Drawing.Image)(resources.GetObject("btn1990.Image")));
            this.btn1990.Location = new System.Drawing.Point(575, 134);
            this.btn1990.Name = "btn1990";
            this.btn1990.Size = new System.Drawing.Size(256, 141);
            this.btn1990.TabIndex = 4;
            this.btn1990.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn1990.UseVisualStyleBackColor = true;
            this.btn1990.Click += new System.EventHandler(this.btn1990_Click);
            // 
            // btn_rtnHome
            // 
            this.btn_rtnHome.Font = new System.Drawing.Font("Perpetua Titling MT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_rtnHome.Location = new System.Drawing.Point(591, 495);
            this.btn_rtnHome.Name = "btn_rtnHome";
            this.btn_rtnHome.Size = new System.Drawing.Size(199, 23);
            this.btn_rtnHome.TabIndex = 5;
            this.btn_rtnHome.Text = "Return to Homepage";
            this.btn_rtnHome.UseVisualStyleBackColor = true;
            this.btn_rtnHome.Click += new System.EventHandler(this.btn_rtnHome_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Perpetua Titling MT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.LightGray;
            this.label3.Location = new System.Drawing.Point(525, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(361, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Click On A Vehicle To Get More Information";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(911, 565);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_rtnHome);
            this.Controls.Add(this.btn_1985);
            this.Controls.Add(this.btn1990);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_1985;
        private System.Windows.Forms.Button btn1990;
        private System.Windows.Forms.Button btn_rtnHome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}