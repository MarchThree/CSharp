namespace 水表
{
    partial class main
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(main));
            this.groubox = new System.Windows.Forms.GroupBox();
            this.btnkg = new System.Windows.Forms.Button();
            this.groubshibiao = new System.Windows.Forms.GroupBox();
            this.labhao = new System.Windows.Forms.Label();
            this.labge = new System.Windows.Forms.Label();
            this.labshi = new System.Windows.Forms.Label();
            this.labbai = new System.Windows.Forms.Label();
            this.labqian = new System.Windows.Forms.Label();
            this.labwan = new System.Windows.Forms.Label();
            this.groubshuichi = new System.Windows.Forms.GroupBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.traBliu = new System.Windows.Forms.TrackBar();
            this.groubox.SuspendLayout();
            this.groubshibiao.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.traBliu)).BeginInit();
            this.SuspendLayout();
            // 
            // groubox
            // 
            this.groubox.Controls.Add(this.traBliu);
            this.groubox.Controls.Add(this.btnkg);
            this.groubox.Location = new System.Drawing.Point(12, 25);
            this.groubox.Name = "groubox";
            this.groubox.Size = new System.Drawing.Size(175, 350);
            this.groubox.TabIndex = 0;
            this.groubox.TabStop = false;
            this.groubox.Text = "开关";
            // 
            // btnkg
            // 
            this.btnkg.Location = new System.Drawing.Point(75, 310);
            this.btnkg.Name = "btnkg";
            this.btnkg.Size = new System.Drawing.Size(75, 23);
            this.btnkg.TabIndex = 0;
            this.btnkg.Text = "开";
            this.btnkg.UseVisualStyleBackColor = true;
            this.btnkg.Click += new System.EventHandler(this.btnkg_Click);
            // 
            // groubshibiao
            // 
            this.groubshibiao.Controls.Add(this.labhao);
            this.groubshibiao.Controls.Add(this.labge);
            this.groubshibiao.Controls.Add(this.labshi);
            this.groubshibiao.Controls.Add(this.labbai);
            this.groubshibiao.Controls.Add(this.labqian);
            this.groubshibiao.Controls.Add(this.labwan);
            this.groubshibiao.Location = new System.Drawing.Point(212, 25);
            this.groubshibiao.Name = "groubshibiao";
            this.groubshibiao.Size = new System.Drawing.Size(574, 107);
            this.groubshibiao.TabIndex = 0;
            this.groubshibiao.TabStop = false;
            this.groubshibiao.Text = "水表";
            // 
            // labhao
            // 
            this.labhao.AutoSize = true;
            this.labhao.Font = new System.Drawing.Font("宋体", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labhao.ForeColor = System.Drawing.Color.Red;
            this.labhao.Location = new System.Drawing.Point(423, 35);
            this.labhao.Name = "labhao";
            this.labhao.Size = new System.Drawing.Size(37, 40);
            this.labhao.TabIndex = 0;
            this.labhao.Text = "0";
            // 
            // labge
            // 
            this.labge.AutoSize = true;
            this.labge.Font = new System.Drawing.Font("宋体", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labge.Location = new System.Drawing.Point(380, 35);
            this.labge.Name = "labge";
            this.labge.Size = new System.Drawing.Size(37, 40);
            this.labge.TabIndex = 0;
            this.labge.Text = "0";
            // 
            // labshi
            // 
            this.labshi.AutoSize = true;
            this.labshi.Font = new System.Drawing.Font("宋体", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labshi.Location = new System.Drawing.Point(337, 35);
            this.labshi.Name = "labshi";
            this.labshi.Size = new System.Drawing.Size(37, 40);
            this.labshi.TabIndex = 0;
            this.labshi.Text = "0";
            // 
            // labbai
            // 
            this.labbai.AutoSize = true;
            this.labbai.Font = new System.Drawing.Font("宋体", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labbai.Location = new System.Drawing.Point(294, 35);
            this.labbai.Name = "labbai";
            this.labbai.Size = new System.Drawing.Size(37, 40);
            this.labbai.TabIndex = 0;
            this.labbai.Text = "0";
            // 
            // labqian
            // 
            this.labqian.AutoSize = true;
            this.labqian.Font = new System.Drawing.Font("宋体", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labqian.Location = new System.Drawing.Point(251, 35);
            this.labqian.Name = "labqian";
            this.labqian.Size = new System.Drawing.Size(37, 40);
            this.labqian.TabIndex = 0;
            this.labqian.Text = "0";
            // 
            // labwan
            // 
            this.labwan.AutoSize = true;
            this.labwan.Font = new System.Drawing.Font("宋体", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labwan.Location = new System.Drawing.Point(208, 35);
            this.labwan.Name = "labwan";
            this.labwan.Size = new System.Drawing.Size(37, 40);
            this.labwan.TabIndex = 0;
            this.labwan.Text = "0";
            // 
            // groubshuichi
            // 
            this.groubshuichi.Location = new System.Drawing.Point(212, 138);
            this.groubshuichi.Name = "groubshuichi";
            this.groubshuichi.Size = new System.Drawing.Size(574, 237);
            this.groubshuichi.TabIndex = 0;
            this.groubshuichi.TabStop = false;
            this.groubshuichi.Text = "水池";
            this.groubshuichi.Paint += new System.Windows.Forms.PaintEventHandler(this.groubshuichi_Paint);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // traBliu
            // 
            this.traBliu.Location = new System.Drawing.Point(6, 20);
            this.traBliu.Minimum = 1;
            this.traBliu.Name = "traBliu";
            this.traBliu.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.traBliu.Size = new System.Drawing.Size(45, 324);
            this.traBliu.TabIndex = 1;
            this.traBliu.Value = 1;
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 413);
            this.Controls.Add(this.groubshuichi);
            this.Controls.Add(this.groubshibiao);
            this.Controls.Add(this.groubox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "main";
            this.Text = "模拟水表";
            this.Load += new System.EventHandler(this.main_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.main_Paint);
            this.groubox.ResumeLayout(false);
            this.groubox.PerformLayout();
            this.groubshibiao.ResumeLayout(false);
            this.groubshibiao.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.traBliu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groubox;
        private System.Windows.Forms.Button btnkg;
        private System.Windows.Forms.GroupBox groubshibiao;
        private System.Windows.Forms.GroupBox groubshuichi;
        private System.Windows.Forms.Label labhao;
        private System.Windows.Forms.Label labge;
        private System.Windows.Forms.Label labshi;
        private System.Windows.Forms.Label labbai;
        private System.Windows.Forms.Label labqian;
        private System.Windows.Forms.Label labwan;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TrackBar traBliu;
    }
}

