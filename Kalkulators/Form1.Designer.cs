namespace Kalkulators
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
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.themeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.darkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lightToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.minimizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.septiniPoga = new System.Windows.Forms.Button();
            this.astoniPoga = new System.Windows.Forms.Button();
            this.deviniPoga = new System.Windows.Forms.Button();
            this.cetriPoga = new System.Windows.Forms.Button();
            this.pieciPoga = new System.Windows.Forms.Button();
            this.sesiPoga = new System.Windows.Forms.Button();
            this.viensPoga = new System.Windows.Forms.Button();
            this.diviPoga = new System.Windows.Forms.Button();
            this.trisPoga = new System.Windows.Forms.Button();
            this.vienadsPoga = new System.Windows.Forms.Button();
            this.dalitPoga = new System.Windows.Forms.Button();
            this.reizinatPoga = new System.Windows.Forms.Button();
            this.plusPoga = new System.Windows.Forms.Button();
            this.tekstaLaukums = new System.Windows.Forms.TextBox();
            this.minusPoga = new System.Windows.Forms.Button();
            this.CPoga = new System.Windows.Forms.Button();
            this.punktaPoga = new System.Windows.Forms.Button();
            this.nullesPoga = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.saknesPoga = new System.Windows.Forms.Button();
            this.pakapesPoga = new System.Windows.Forms.Button();
            this.USD = new System.Windows.Forms.Button();
            this.EUR = new System.Windows.Forms.Button();
            this.LV = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.checkBoxLog = new System.Windows.Forms.CheckBox();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.themeToolStripMenuItem,
            this.sizeToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(707, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "File";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewToolStripMenuItem,
            this.clearToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(101, 22);
            this.viewToolStripMenuItem.Text = "View";
            this.viewToolStripMenuItem.Click += new System.EventHandler(this.viewLogFile_Click);
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(101, 22);
            this.clearToolStripMenuItem.Text = "Clear";
            this.clearToolStripMenuItem.Click += new System.EventHandler(this.logFileClear_Click);
            // 
            // themeToolStripMenuItem
            // 
            this.themeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.darkToolStripMenuItem,
            this.lightToolStripMenuItem});
            this.themeToolStripMenuItem.Name = "themeToolStripMenuItem";
            this.themeToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.themeToolStripMenuItem.Text = "Theme";
            // 
            // darkToolStripMenuItem
            // 
            this.darkToolStripMenuItem.Name = "darkToolStripMenuItem";
            this.darkToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.darkToolStripMenuItem.Text = "Dark";
            this.darkToolStripMenuItem.Click += new System.EventHandler(this.setDarkTheme_Click);
            // 
            // lightToolStripMenuItem
            // 
            this.lightToolStripMenuItem.Name = "lightToolStripMenuItem";
            this.lightToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.lightToolStripMenuItem.Text = "Light";
            this.lightToolStripMenuItem.Click += new System.EventHandler(this.setLightTheme_Click);
            // 
            // sizeToolStripMenuItem
            // 
            this.sizeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.minimizeToolStripMenuItem});
            this.sizeToolStripMenuItem.Name = "sizeToolStripMenuItem";
            this.sizeToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.sizeToolStripMenuItem.Text = "Size";
            // 
            // minimizeToolStripMenuItem
            // 
            this.minimizeToolStripMenuItem.Name = "minimizeToolStripMenuItem";
            this.minimizeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.minimizeToolStripMenuItem.Text = "Resize";
            this.minimizeToolStripMenuItem.Click += new System.EventHandler(this.windowResize_Click);
            // 
            // septiniPoga
            // 
            this.septiniPoga.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.septiniPoga.Location = new System.Drawing.Point(33, 109);
            this.septiniPoga.Name = "septiniPoga";
            this.septiniPoga.Size = new System.Drawing.Size(57, 54);
            this.septiniPoga.TabIndex = 0;
            this.septiniPoga.Text = "7";
            this.septiniPoga.Click += new System.EventHandler(this.septiniPoga_Click);
            // 
            // astoniPoga
            // 
            this.astoniPoga.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.astoniPoga.Location = new System.Drawing.Point(117, 109);
            this.astoniPoga.Name = "astoniPoga";
            this.astoniPoga.Size = new System.Drawing.Size(57, 54);
            this.astoniPoga.TabIndex = 1;
            this.astoniPoga.Text = "8";
            this.astoniPoga.Click += new System.EventHandler(this.astoniPoga_Click);
            // 
            // deviniPoga
            // 
            this.deviniPoga.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deviniPoga.Location = new System.Drawing.Point(202, 109);
            this.deviniPoga.Name = "deviniPoga";
            this.deviniPoga.Size = new System.Drawing.Size(57, 54);
            this.deviniPoga.TabIndex = 2;
            this.deviniPoga.Text = "9";
            this.deviniPoga.Click += new System.EventHandler(this.deviniPoga_Click);
            // 
            // cetriPoga
            // 
            this.cetriPoga.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cetriPoga.Location = new System.Drawing.Point(33, 186);
            this.cetriPoga.Name = "cetriPoga";
            this.cetriPoga.Size = new System.Drawing.Size(57, 54);
            this.cetriPoga.TabIndex = 3;
            this.cetriPoga.Text = "4";
            this.cetriPoga.Click += new System.EventHandler(this.cetriPoga_Click);
            // 
            // pieciPoga
            // 
            this.pieciPoga.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pieciPoga.Location = new System.Drawing.Point(117, 186);
            this.pieciPoga.Name = "pieciPoga";
            this.pieciPoga.Size = new System.Drawing.Size(57, 54);
            this.pieciPoga.TabIndex = 4;
            this.pieciPoga.Text = "5";
            this.pieciPoga.Click += new System.EventHandler(this.pieciPoga_Click);
            // 
            // sesiPoga
            // 
            this.sesiPoga.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sesiPoga.Location = new System.Drawing.Point(202, 186);
            this.sesiPoga.Name = "sesiPoga";
            this.sesiPoga.Size = new System.Drawing.Size(57, 54);
            this.sesiPoga.TabIndex = 5;
            this.sesiPoga.Text = "6";
            this.sesiPoga.Click += new System.EventHandler(this.sesiPoga_Click);
            // 
            // viensPoga
            // 
            this.viensPoga.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viensPoga.Location = new System.Drawing.Point(33, 263);
            this.viensPoga.Name = "viensPoga";
            this.viensPoga.Size = new System.Drawing.Size(57, 54);
            this.viensPoga.TabIndex = 6;
            this.viensPoga.Text = "1";
            this.viensPoga.Click += new System.EventHandler(this.viensPoga_Click);
            // 
            // diviPoga
            // 
            this.diviPoga.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.diviPoga.Location = new System.Drawing.Point(117, 263);
            this.diviPoga.Name = "diviPoga";
            this.diviPoga.Size = new System.Drawing.Size(57, 54);
            this.diviPoga.TabIndex = 7;
            this.diviPoga.Text = "2";
            this.diviPoga.Click += new System.EventHandler(this.diviPoga_Click);
            // 
            // trisPoga
            // 
            this.trisPoga.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trisPoga.Location = new System.Drawing.Point(202, 263);
            this.trisPoga.Name = "trisPoga";
            this.trisPoga.Size = new System.Drawing.Size(57, 54);
            this.trisPoga.TabIndex = 8;
            this.trisPoga.Text = "3";
            this.trisPoga.Click += new System.EventHandler(this.trisPoga_Click);
            // 
            // vienadsPoga
            // 
            this.vienadsPoga.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vienadsPoga.Location = new System.Drawing.Point(33, 429);
            this.vienadsPoga.Name = "vienadsPoga";
            this.vienadsPoga.Size = new System.Drawing.Size(333, 54);
            this.vienadsPoga.TabIndex = 9;
            this.vienadsPoga.Text = "=";
            this.vienadsPoga.Click += new System.EventHandler(this.vienadsPoga_Click);
            // 
            // dalitPoga
            // 
            this.dalitPoga.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dalitPoga.Location = new System.Drawing.Point(309, 109);
            this.dalitPoga.Name = "dalitPoga";
            this.dalitPoga.Size = new System.Drawing.Size(57, 54);
            this.dalitPoga.TabIndex = 10;
            this.dalitPoga.Text = "/";
            this.dalitPoga.Click += new System.EventHandler(this.dalitPoga_Click);
            // 
            // reizinatPoga
            // 
            this.reizinatPoga.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reizinatPoga.Location = new System.Drawing.Point(309, 186);
            this.reizinatPoga.Name = "reizinatPoga";
            this.reizinatPoga.Size = new System.Drawing.Size(57, 54);
            this.reizinatPoga.TabIndex = 11;
            this.reizinatPoga.Text = "*";
            this.reizinatPoga.Click += new System.EventHandler(this.reizinatPoga_Click);
            // 
            // plusPoga
            // 
            this.plusPoga.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plusPoga.Location = new System.Drawing.Point(309, 263);
            this.plusPoga.Name = "plusPoga";
            this.plusPoga.Size = new System.Drawing.Size(57, 54);
            this.plusPoga.TabIndex = 12;
            this.plusPoga.Text = "+";
            this.plusPoga.Click += new System.EventHandler(this.plusPoga_Click);
            // 
            // tekstaLaukums
            // 
            this.tekstaLaukums.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tekstaLaukums.Location = new System.Drawing.Point(33, 36);
            this.tekstaLaukums.Multiline = true;
            this.tekstaLaukums.Name = "tekstaLaukums";
            this.tekstaLaukums.Size = new System.Drawing.Size(333, 50);
            this.tekstaLaukums.TabIndex = 13;
            // 
            // minusPoga
            // 
            this.minusPoga.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minusPoga.Location = new System.Drawing.Point(309, 341);
            this.minusPoga.Name = "minusPoga";
            this.minusPoga.Size = new System.Drawing.Size(57, 54);
            this.minusPoga.TabIndex = 17;
            this.minusPoga.Text = "-";
            this.minusPoga.Click += new System.EventHandler(this.minusPoga_Click);
            // 
            // CPoga
            // 
            this.CPoga.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CPoga.Location = new System.Drawing.Point(202, 341);
            this.CPoga.Name = "CPoga";
            this.CPoga.Size = new System.Drawing.Size(57, 54);
            this.CPoga.TabIndex = 16;
            this.CPoga.Text = "C";
            this.CPoga.Click += new System.EventHandler(this.CPoga_Click);
            // 
            // punktaPoga
            // 
            this.punktaPoga.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.punktaPoga.Location = new System.Drawing.Point(117, 341);
            this.punktaPoga.Name = "punktaPoga";
            this.punktaPoga.Size = new System.Drawing.Size(57, 54);
            this.punktaPoga.TabIndex = 15;
            this.punktaPoga.Text = ".";
            this.punktaPoga.Click += new System.EventHandler(this.punktaPoga_Click);
            // 
            // nullesPoga
            // 
            this.nullesPoga.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nullesPoga.Location = new System.Drawing.Point(33, 341);
            this.nullesPoga.Name = "nullesPoga";
            this.nullesPoga.Size = new System.Drawing.Size(57, 54);
            this.nullesPoga.TabIndex = 14;
            this.nullesPoga.Text = "0";
            this.nullesPoga.Click += new System.EventHandler(this.nullesPoga_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(534, 186);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(131, 50);
            this.textBox1.TabIndex = 18;
            // 
            // saknesPoga
            // 
            this.saknesPoga.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saknesPoga.Location = new System.Drawing.Point(554, 109);
            this.saknesPoga.Name = "saknesPoga";
            this.saknesPoga.Size = new System.Drawing.Size(111, 50);
            this.saknesPoga.TabIndex = 0;
            this.saknesPoga.Text = "_/`";
            this.saknesPoga.Click += new System.EventHandler(this.saknePoga_Click);
            // 
            // pakapesPoga
            // 
            this.pakapesPoga.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pakapesPoga.Location = new System.Drawing.Point(435, 109);
            this.pakapesPoga.Name = "pakapesPoga";
            this.pakapesPoga.Size = new System.Drawing.Size(111, 50);
            this.pakapesPoga.TabIndex = 0;
            this.pakapesPoga.Text = "^2";
            this.pakapesPoga.Click += new System.EventHandler(this.pakapePoga_Click);
            // 
            // USD
            // 
            this.USD.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.USD.Location = new System.Drawing.Point(435, 259);
            this.USD.Name = "USD";
            this.USD.Size = new System.Drawing.Size(57, 54);
            this.USD.TabIndex = 19;
            this.USD.Text = "$";
            this.USD.Click += new System.EventHandler(this.USD_Click);
            // 
            // EUR
            // 
            this.EUR.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EUR.Location = new System.Drawing.Point(435, 182);
            this.EUR.Name = "EUR";
            this.EUR.Size = new System.Drawing.Size(57, 54);
            this.EUR.TabIndex = 20;
            this.EUR.Text = "€";
            this.EUR.Click += new System.EventHandler(this.EUR_Click);
            // 
            // LV
            // 
            this.LV.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LV.Location = new System.Drawing.Point(435, 337);
            this.LV.Name = "LV";
            this.LV.Size = new System.Drawing.Size(57, 54);
            this.LV.TabIndex = 21;
            this.LV.Text = "Lati";
            this.LV.Click += new System.EventHandler(this.LV_Click);
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(534, 263);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(131, 50);
            this.textBox2.TabIndex = 22;
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(534, 341);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(131, 50);
            this.textBox3.TabIndex = 23;
            // 
            // checkBoxLog
            // 
            this.checkBoxLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxLog.Location = new System.Drawing.Point(435, 36);
            this.checkBoxLog.Name = "checkBoxLog";
            this.checkBoxLog.Size = new System.Drawing.Size(104, 24);
            this.checkBoxLog.TabIndex = 24;
            this.checkBoxLog.Text = "Write to Log";
            this.checkBoxLog.CheckedChanged += new System.EventHandler(this.logCheckBox_Checked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 512);
            this.Controls.Add(this.menuStrip);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.LV);
            this.Controls.Add(this.EUR);
            this.Controls.Add(this.USD);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.minusPoga);
            this.Controls.Add(this.CPoga);
            this.Controls.Add(this.punktaPoga);
            this.Controls.Add(this.nullesPoga);
            this.Controls.Add(this.tekstaLaukums);
            this.Controls.Add(this.plusPoga);
            this.Controls.Add(this.reizinatPoga);
            this.Controls.Add(this.dalitPoga);
            this.Controls.Add(this.vienadsPoga);
            this.Controls.Add(this.trisPoga);
            this.Controls.Add(this.diviPoga);
            this.Controls.Add(this.viensPoga);
            this.Controls.Add(this.sesiPoga);
            this.Controls.Add(this.pieciPoga);
            this.Controls.Add(this.cetriPoga);
            this.Controls.Add(this.deviniPoga);
            this.Controls.Add(this.astoniPoga);
            this.Controls.Add(this.septiniPoga);
            this.Controls.Add(this.pakapesPoga);
            this.Controls.Add(this.saknesPoga);
            this.Controls.Add(this.checkBoxLog);
            this.Name = "Form1";
            this.Text = "Kalkulātors";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;

        private System.Windows.Forms.Button septiniPoga;
        private System.Windows.Forms.Button astoniPoga;
        private System.Windows.Forms.Button deviniPoga;
        private System.Windows.Forms.Button cetriPoga;
        private System.Windows.Forms.Button pieciPoga;
        private System.Windows.Forms.Button sesiPoga;
        private System.Windows.Forms.Button viensPoga;
        private System.Windows.Forms.Button diviPoga;
        private System.Windows.Forms.Button trisPoga;
        private System.Windows.Forms.Button vienadsPoga;
        private System.Windows.Forms.Button dalitPoga;
        private System.Windows.Forms.Button reizinatPoga;
        private System.Windows.Forms.Button plusPoga;
        private System.Windows.Forms.TextBox tekstaLaukums;
        private System.Windows.Forms.Button minusPoga;
        private System.Windows.Forms.Button CPoga;
        private System.Windows.Forms.Button punktaPoga;
        private System.Windows.Forms.Button nullesPoga;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button pakapesPoga;
        private System.Windows.Forms.Button saknesPoga;
        private System.Windows.Forms.Button USD;
        private System.Windows.Forms.Button EUR;
        private System.Windows.Forms.Button LV;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.CheckBox checkBoxLog;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem themeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem darkToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lightToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sizeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem minimizeToolStripMenuItem;
    }
}

