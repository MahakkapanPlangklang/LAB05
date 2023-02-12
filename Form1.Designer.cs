namespace LAB05
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.mpName = new System.Windows.Forms.TextBox();
            this.mpHP = new System.Windows.Forms.TextBox();
            this.eHP = new System.Windows.Forms.TextBox();
            this.eName = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.N = new System.Windows.Forms.Button();
            this.W = new System.Windows.Forms.Button();
            this.C = new System.Windows.Forms.Button();
            this.P = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.defense = new System.Windows.Forms.Button();
            this.heal = new System.Windows.Forms.Button();
            this.Attack = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(94, 47);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(180, 140);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(536, 47);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(180, 140);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(94, 209);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(94, 243);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "HP";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(536, 243);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "HP";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(536, 209);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Name";
            // 
            // mpName
            // 
            this.mpName.Location = new System.Drawing.Point(149, 206);
            this.mpName.Name = "mpName";
            this.mpName.Size = new System.Drawing.Size(125, 27);
            this.mpName.TabIndex = 6;
            // 
            // mpHP
            // 
            this.mpHP.Location = new System.Drawing.Point(149, 243);
            this.mpHP.Name = "mpHP";
            this.mpHP.Size = new System.Drawing.Size(125, 27);
            this.mpHP.TabIndex = 7;
            // 
            // eHP
            // 
            this.eHP.Location = new System.Drawing.Point(591, 246);
            this.eHP.Name = "eHP";
            this.eHP.Size = new System.Drawing.Size(125, 27);
            this.eHP.TabIndex = 9;
            // 
            // eName
            // 
            this.eName.Location = new System.Drawing.Point(591, 209);
            this.eName.Name = "eName";
            this.eName.Size = new System.Drawing.Size(125, 27);
            this.eName.TabIndex = 8;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.N);
            this.groupBox1.Controls.Add(this.W);
            this.groupBox1.Controls.Add(this.C);
            this.groupBox1.Controls.Add(this.P);
            this.groupBox1.Location = new System.Drawing.Point(68, 319);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(206, 190);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "My Pokemon";
            // 
            // N
            // 
            this.N.Location = new System.Drawing.Point(26, 147);
            this.N.Name = "N";
            this.N.Size = new System.Drawing.Size(162, 29);
            this.N.TabIndex = 3;
            this.N.Text = "Nidoran";
            this.N.UseVisualStyleBackColor = true;
            this.N.Click += new System.EventHandler(this.N_Click);
            // 
            // W
            // 
            this.W.Location = new System.Drawing.Point(26, 112);
            this.W.Name = "W";
            this.W.Size = new System.Drawing.Size(162, 29);
            this.W.TabIndex = 2;
            this.W.Text = "Wartortle";
            this.W.UseVisualStyleBackColor = true;
            this.W.Click += new System.EventHandler(this.W_Click);
            // 
            // C
            // 
            this.C.Location = new System.Drawing.Point(26, 77);
            this.C.Name = "C";
            this.C.Size = new System.Drawing.Size(162, 29);
            this.C.TabIndex = 1;
            this.C.Text = "Charmander";
            this.C.UseVisualStyleBackColor = true;
            this.C.Click += new System.EventHandler(this.C_Click);
            // 
            // P
            // 
            this.P.Location = new System.Drawing.Point(26, 42);
            this.P.Name = "P";
            this.P.Size = new System.Drawing.Size(162, 29);
            this.P.TabIndex = 0;
            this.P.Text = "Pikachu";
            this.P.UseVisualStyleBackColor = true;
            this.P.Click += new System.EventHandler(this.P_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.defense);
            this.groupBox2.Controls.Add(this.heal);
            this.groupBox2.Controls.Add(this.Attack);
            this.groupBox2.Location = new System.Drawing.Point(324, 319);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(180, 190);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Command";
            // 
            // defense
            // 
            this.defense.Location = new System.Drawing.Point(22, 112);
            this.defense.Name = "defense";
            this.defense.Size = new System.Drawing.Size(141, 29);
            this.defense.TabIndex = 2;
            this.defense.Text = "Defense + 50";
            this.defense.UseVisualStyleBackColor = true;
            this.defense.Click += new System.EventHandler(this.defense_Click);
            // 
            // heal
            // 
            this.heal.Location = new System.Drawing.Point(22, 77);
            this.heal.Name = "heal";
            this.heal.Size = new System.Drawing.Size(141, 29);
            this.heal.TabIndex = 1;
            this.heal.Text = "HP + 50";
            this.heal.UseVisualStyleBackColor = true;
            this.heal.Click += new System.EventHandler(this.heal_Click);
            // 
            // Attack
            // 
            this.Attack.Location = new System.Drawing.Point(22, 42);
            this.Attack.Name = "Attack";
            this.Attack.Size = new System.Drawing.Size(141, 29);
            this.Attack.TabIndex = 0;
            this.Attack.Text = "Attack";
            this.Attack.UseVisualStyleBackColor = true;
            this.Attack.Click += new System.EventHandler(this.Attack_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(536, 328);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(166, 29);
            this.button2.TabIndex = 12;
            this.button2.Text = "Enemy Attack";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(536, 363);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(166, 29);
            this.button3.TabIndex = 13;
            this.button3.Text = "Enemy HP+50";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(536, 398);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(166, 29);
            this.button7.TabIndex = 14;
            this.button7.Text = "Enemy Defense+50";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 591);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.eHP);
            this.Controls.Add(this.eName);
            this.Controls.Add(this.mpHP);
            this.Controls.Add(this.mpName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox mpName;
        private TextBox mpHP;
        private TextBox eHP;
        private TextBox eName;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Button defense;
        private Button heal;
        private Button Attack;
        private Button W;
        private Button C;
        private Button P;
        private Button N;
        private Button button2;
        private Button button3;
        private Button button7;
    }
}