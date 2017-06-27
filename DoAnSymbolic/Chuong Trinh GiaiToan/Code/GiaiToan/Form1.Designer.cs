namespace GiaiToan
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
            this.input_box = new System.Windows.Forms.TextBox();
            this.output_box = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pic_giai = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.hd = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.info_sl = new System.Windows.Forms.Label();
            this.info_check = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_giai)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hd)).BeginInit();
            this.SuspendLayout();
            // 
            // input_box
            // 
            this.input_box.Location = new System.Drawing.Point(12, 42);
            this.input_box.Name = "input_box";
            this.input_box.Size = new System.Drawing.Size(302, 22);
            this.input_box.TabIndex = 1;
            this.input_box.TextChanged += new System.EventHandler(this.input_box_TextChanged);
            this.input_box.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.input_box_KeyPress);
            // 
            // output_box
            // 
            this.output_box.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.output_box.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.output_box.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.output_box.Location = new System.Drawing.Point(12, 79);
            this.output_box.Multiline = true;
            this.output_box.Name = "output_box";
            this.output_box.ReadOnly = true;
            this.output_box.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.output_box.Size = new System.Drawing.Size(494, 179);
            this.output_box.TabIndex = 2;
            this.output_box.UseWaitCursor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureBox1.Location = new System.Drawing.Point(12, 292);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(494, 47);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // pic_giai
            // 
            this.pic_giai.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pic_giai.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pic_giai.Image = ((System.Drawing.Image)(resources.GetObject("pic_giai.Image")));
            this.pic_giai.Location = new System.Drawing.Point(535, 199);
            this.pic_giai.Name = "pic_giai";
            this.pic_giai.Size = new System.Drawing.Size(191, 243);
            this.pic_giai.TabIndex = 5;
            this.pic_giai.TabStop = false;
            this.pic_giai.Click += new System.EventHandler(this.pic_giai_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureBox2.Location = new System.Drawing.Point(12, 343);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(494, 47);
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureBox3.Location = new System.Drawing.Point(12, 395);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(494, 47);
            this.pictureBox3.TabIndex = 8;
            this.pictureBox3.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(12, 273);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Nghiệm:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(12, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Nhập phương trình:";
            // 
            // hd
            // 
            this.hd.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.hd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.hd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.hd.Location = new System.Drawing.Point(507, 18);
            this.hd.Name = "hd";
            this.hd.Size = new System.Drawing.Size(255, 181);
            this.hd.TabIndex = 11;
            this.hd.TabStop = false;
            this.hd.Click += new System.EventHandler(this.hd_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.Font = new System.Drawing.Font("Candara", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(453, 42);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(60, 25);
            this.button1.TabIndex = 12;
            this.button1.Text = "Check space";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button1.MouseLeave += new System.EventHandler(this.button1_MouseLeave);
            this.button1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.button1_MouseMove);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Location = new System.Drawing.Point(320, 42);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(131, 24);
            this.comboBox1.TabIndex = 13;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            this.comboBox1.MouseLeave += new System.EventHandler(this.comboBox1_MouseLeave);
            this.comboBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.comboBox1_MouseMove);
            // 
            // info_sl
            // 
            this.info_sl.AutoSize = true;
            this.info_sl.Location = new System.Drawing.Point(317, 22);
            this.info_sl.Name = "info_sl";
            this.info_sl.Size = new System.Drawing.Size(0, 17);
            this.info_sl.TabIndex = 14;
            // 
            // info_check
            // 
            this.info_check.AutoSize = true;
            this.info_check.Location = new System.Drawing.Point(449, 23);
            this.info_check.Name = "info_check";
            this.info_check.Size = new System.Drawing.Size(0, 17);
            this.info_check.TabIndex = 15;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(381, 14);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 16;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(761, 456);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.info_check);
            this.Controls.Add(this.info_sl);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.hd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pic_giai);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.output_box);
            this.Controls.Add(this.input_box);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(779, 503);
            this.MinimumSize = new System.Drawing.Size(779, 503);
            this.Name = "Form1";
            this.Opacity = 0.96D;
            this.ShowIcon = false;
            this.Text = "Math class 8";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_giai)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox input_box;
        private System.Windows.Forms.TextBox output_box;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pic_giai;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox hd;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label info_sl;
        private System.Windows.Forms.Label info_check;
        private System.Windows.Forms.Button button2;
    }
}

