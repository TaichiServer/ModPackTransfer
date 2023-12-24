namespace FolderCopy
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.button3 = new System.Windows.Forms.Button();
            this.config = new System.Windows.Forms.CheckBox();
            this.options = new System.Windows.Forms.CheckBox();
            this.resourcepacks = new System.Windows.Forms.CheckBox();
            this.schematics = new System.Windows.Forms.CheckBox();
            this.saves = new System.Windows.Forms.CheckBox();
            this.screenshots = new System.Windows.Forms.CheckBox();
            this.XaeroWaypoints = new System.Windows.Forms.CheckBox();
            this.XaeroWorldMap = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bindall = new System.Windows.Forms.Button();
            this.unbindall = new System.Windows.Forms.Button();
            this.shaderpacks = new System.Windows.Forms.CheckBox();
            this.itemscroller = new System.Windows.Forms.CheckBox();
            this.g4mespeed = new System.Windows.Forms.CheckBox();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(382, 318);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(207, 30);
            this.button1.TabIndex = 0;
            this.button1.Text = "移動";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(235, 236);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(246, 23);
            this.textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(235, 270);
            this.textBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(246, 23);
            this.textBox2.TabIndex = 2;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(490, 234);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(99, 30);
            this.button2.TabIndex = 3;
            this.button2.Text = "参照";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(491, 270);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(99, 30);
            this.button3.TabIndex = 4;
            this.button3.Text = "参照";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // config
            // 
            this.config.AutoSize = true;
            this.config.Location = new System.Drawing.Point(682, 357);
            this.config.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.config.Name = "config";
            this.config.Size = new System.Drawing.Size(74, 20);
            this.config.TabIndex = 5;
            this.config.Text = "config";
            this.config.UseVisualStyleBackColor = true;
            // 
            // options
            // 
            this.options.AutoSize = true;
            this.options.Location = new System.Drawing.Point(682, 384);
            this.options.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.options.Name = "options";
            this.options.Size = new System.Drawing.Size(82, 20);
            this.options.TabIndex = 6;
            this.options.Text = "options";
            this.options.UseVisualStyleBackColor = true;
            // 
            // resourcepacks
            // 
            this.resourcepacks.AutoSize = true;
            this.resourcepacks.Location = new System.Drawing.Point(682, 329);
            this.resourcepacks.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.resourcepacks.Name = "resourcepacks";
            this.resourcepacks.Size = new System.Drawing.Size(130, 20);
            this.resourcepacks.TabIndex = 7;
            this.resourcepacks.Text = "resourcepacks";
            this.resourcepacks.UseVisualStyleBackColor = true;
            // 
            // schematics
            // 
            this.schematics.AutoSize = true;
            this.schematics.Location = new System.Drawing.Point(682, 301);
            this.schematics.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.schematics.Name = "schematics";
            this.schematics.Size = new System.Drawing.Size(106, 20);
            this.schematics.TabIndex = 8;
            this.schematics.Text = "schematics";
            this.schematics.UseVisualStyleBackColor = true;
            // 
            // saves
            // 
            this.saves.AutoSize = true;
            this.saves.Location = new System.Drawing.Point(682, 273);
            this.saves.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.saves.Name = "saves";
            this.saves.Size = new System.Drawing.Size(66, 20);
            this.saves.TabIndex = 9;
            this.saves.Text = "saves";
            this.saves.UseVisualStyleBackColor = true;
            // 
            // screenshots
            // 
            this.screenshots.AutoSize = true;
            this.screenshots.Location = new System.Drawing.Point(682, 245);
            this.screenshots.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.screenshots.Name = "screenshots";
            this.screenshots.Size = new System.Drawing.Size(114, 20);
            this.screenshots.TabIndex = 10;
            this.screenshots.Text = "screenshots";
            this.screenshots.UseVisualStyleBackColor = true;
            // 
            // XaeroWaypoints
            // 
            this.XaeroWaypoints.AutoSize = true;
            this.XaeroWaypoints.Location = new System.Drawing.Point(682, 217);
            this.XaeroWaypoints.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.XaeroWaypoints.Name = "XaeroWaypoints";
            this.XaeroWaypoints.Size = new System.Drawing.Size(138, 20);
            this.XaeroWaypoints.TabIndex = 11;
            this.XaeroWaypoints.Text = "XaeroWaypoints";
            this.XaeroWaypoints.UseVisualStyleBackColor = true;
            // 
            // XaeroWorldMap
            // 
            this.XaeroWorldMap.AutoSize = true;
            this.XaeroWorldMap.Location = new System.Drawing.Point(682, 189);
            this.XaeroWorldMap.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.XaeroWorldMap.Name = "XaeroWorldMap";
            this.XaeroWorldMap.Size = new System.Drawing.Size(130, 20);
            this.XaeroWorldMap.TabIndex = 12;
            this.XaeroWorldMap.Text = "XaeroWorldMap";
            this.XaeroWorldMap.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(142, 277);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 16);
            this.label1.TabIndex = 13;
            this.label1.Text = "新起動構成";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(142, 241);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 16);
            this.label2.TabIndex = 13;
            this.label2.Text = "旧起動構成";
            // 
            // bindall
            // 
            this.bindall.Font = new System.Drawing.Font("ＭＳ ゴシック", 9F);
            this.bindall.Location = new System.Drawing.Point(682, 412);
            this.bindall.Name = "bindall";
            this.bindall.Size = new System.Drawing.Size(75, 23);
            this.bindall.TabIndex = 14;
            this.bindall.Text = "bind all";
            this.bindall.UseVisualStyleBackColor = true;
            this.bindall.Click += new System.EventHandler(this.bindall_Click);
            // 
            // unbindall
            // 
            this.unbindall.Font = new System.Drawing.Font("ＭＳ ゴシック", 9F);
            this.unbindall.Location = new System.Drawing.Point(764, 411);
            this.unbindall.Name = "unbindall";
            this.unbindall.Size = new System.Drawing.Size(75, 23);
            this.unbindall.TabIndex = 15;
            this.unbindall.Text = "unbind all";
            this.unbindall.UseVisualStyleBackColor = true;
            this.unbindall.Click += new System.EventHandler(this.unbindall_Click);
            // 
            // shaderpacks
            // 
            this.shaderpacks.AutoSize = true;
            this.shaderpacks.Location = new System.Drawing.Point(682, 162);
            this.shaderpacks.Name = "shaderpacks";
            this.shaderpacks.Size = new System.Drawing.Size(114, 20);
            this.shaderpacks.TabIndex = 18;
            this.shaderpacks.Text = "shaderpacks";
            this.shaderpacks.UseVisualStyleBackColor = true;
            // 
            // itemscroller
            // 
            this.itemscroller.AutoSize = true;
            this.itemscroller.Location = new System.Drawing.Point(682, 136);
            this.itemscroller.Name = "itemscroller";
            this.itemscroller.Size = new System.Drawing.Size(122, 20);
            this.itemscroller.TabIndex = 19;
            this.itemscroller.Text = "itemscroller";
            this.itemscroller.UseVisualStyleBackColor = true;
            // 
            // g4mespeed
            // 
            this.g4mespeed.AutoSize = true;
            this.g4mespeed.Location = new System.Drawing.Point(682, 110);
            this.g4mespeed.Name = "g4mespeed";
            this.g4mespeed.Size = new System.Drawing.Size(98, 20);
            this.g4mespeed.TabIndex = 20;
            this.g4mespeed.Text = "g4mespeed";
            this.g4mespeed.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("ＭＳ ゴシック", 9F);
            this.button4.Location = new System.Drawing.Point(845, 412);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 21;
            this.button4.Text = "おすすめ";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 600);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.g4mespeed);
            this.Controls.Add(this.itemscroller);
            this.Controls.Add(this.shaderpacks);
            this.Controls.Add(this.unbindall);
            this.Controls.Add(this.bindall);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.XaeroWorldMap);
            this.Controls.Add(this.XaeroWaypoints);
            this.Controls.Add(this.screenshots);
            this.Controls.Add(this.saves);
            this.Controls.Add(this.schematics);
            this.Controls.Add(this.resourcepacks);
            this.Controls.Add(this.options);
            this.Controls.Add(this.config);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("ＭＳ ゴシック", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "ModPack Transition";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.CheckBox config;
        private System.Windows.Forms.CheckBox options;
        private System.Windows.Forms.CheckBox resourcepacks;
        private System.Windows.Forms.CheckBox schematics;
        private System.Windows.Forms.CheckBox saves;
        private System.Windows.Forms.CheckBox screenshots;
        private System.Windows.Forms.CheckBox XaeroWaypoints;
        private System.Windows.Forms.CheckBox XaeroWorldMap;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bindall;
        private System.Windows.Forms.Button unbindall;
        private System.Windows.Forms.CheckBox shaderpacks;
        private System.Windows.Forms.CheckBox itemscroller;
        private System.Windows.Forms.CheckBox g4mespeed;
        private System.Windows.Forms.Button button4;
    }
}

