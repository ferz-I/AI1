namespace App
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
            this.label2 = new System.Windows.Forms.Label();
            this.xlabel = new System.Windows.Forms.Label();
            this.ylabel = new System.Windows.Forms.Label();
            this.x = new System.Windows.Forms.TextBox();
            this.y = new System.Windows.Forms.TextBox();
            this.grid = new System.Windows.Forms.DataGridView();
            this.start = new System.Windows.Forms.Button();
            this.Create = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.mazeSize = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.xfin = new System.Windows.Forms.TextBox();
            this.yfin = new System.Windows.Forms.TextBox();
            this.mark = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 852);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Start position:";
            // 
            // xlabel
            // 
            this.xlabel.AutoSize = true;
            this.xlabel.Location = new System.Drawing.Point(157, 852);
            this.xlabel.Name = "xlabel";
            this.xlabel.Size = new System.Drawing.Size(16, 20);
            this.xlabel.TabIndex = 3;
            this.xlabel.Text = "x";
            // 
            // ylabel
            // 
            this.ylabel.AutoSize = true;
            this.ylabel.Location = new System.Drawing.Point(157, 899);
            this.ylabel.Name = "ylabel";
            this.ylabel.Size = new System.Drawing.Size(16, 20);
            this.ylabel.TabIndex = 4;
            this.ylabel.Text = "y";
            // 
            // x
            // 
            this.x.Location = new System.Drawing.Point(190, 852);
            this.x.Name = "x";
            this.x.Size = new System.Drawing.Size(46, 27);
            this.x.TabIndex = 5;
            // 
            // y
            // 
            this.y.Location = new System.Drawing.Point(190, 896);
            this.y.Name = "y";
            this.y.Size = new System.Drawing.Size(46, 27);
            this.y.TabIndex = 6;
            // 
            // grid
            // 
            this.grid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid.Location = new System.Drawing.Point(12, 12);
            this.grid.Name = "grid";
            this.grid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.grid.RowHeadersWidth = 10;
            this.grid.RowTemplate.Height = 29;
            this.grid.RowTemplate.ReadOnly = true;
            this.grid.Size = new System.Drawing.Size(1255, 822);
            this.grid.TabIndex = 7;
            this.grid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.maze_CellContentClick);
            // 
            // start
            // 
            this.start.Location = new System.Drawing.Point(858, 848);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(94, 29);
            this.start.TabIndex = 11;
            this.start.Text = "Start";
            this.start.UseVisualStyleBackColor = true;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // Create
            // 
            this.Create.Location = new System.Drawing.Point(676, 890);
            this.Create.Name = "Create";
            this.Create.Size = new System.Drawing.Size(94, 29);
            this.Create.TabIndex = 12;
            this.Create.Text = "Create";
            this.Create.UseVisualStyleBackColor = true;
            this.Create.Click += new System.EventHandler(this.Create_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(676, 852);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 20);
            this.label1.TabIndex = 13;
            this.label1.Text = "Size:";
            // 
            // mazeSize
            // 
            this.mazeSize.Location = new System.Drawing.Point(735, 849);
            this.mazeSize.Name = "mazeSize";
            this.mazeSize.Size = new System.Drawing.Size(49, 27);
            this.mazeSize.TabIndex = 14;
            this.mazeSize.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(290, 852);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 20);
            this.label3.TabIndex = 15;
            this.label3.Text = "Finish position:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(412, 852);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(16, 20);
            this.label4.TabIndex = 16;
            this.label4.Text = "x";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(412, 899);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(16, 20);
            this.label5.TabIndex = 17;
            this.label5.Text = "y";
            // 
            // xfin
            // 
            this.xfin.Location = new System.Drawing.Point(445, 845);
            this.xfin.Name = "xfin";
            this.xfin.Size = new System.Drawing.Size(47, 27);
            this.xfin.TabIndex = 18;
            this.xfin.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // yfin
            // 
            this.yfin.Location = new System.Drawing.Point(445, 896);
            this.yfin.Name = "yfin";
            this.yfin.Size = new System.Drawing.Size(47, 27);
            this.yfin.TabIndex = 19;
            // 
            // mark
            // 
            this.mark.Location = new System.Drawing.Point(247, 937);
            this.mark.Name = "mark";
            this.mark.Size = new System.Drawing.Size(94, 29);
            this.mark.TabIndex = 20;
            this.mark.Text = "Mark";
            this.mark.UseVisualStyleBackColor = true;
            this.mark.Click += new System.EventHandler(this.mark_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1317, 978);
            this.Controls.Add(this.mark);
            this.Controls.Add(this.yfin);
            this.Controls.Add(this.xfin);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.mazeSize);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Create);
            this.Controls.Add(this.start);
            this.Controls.Add(this.grid);
            this.Controls.Add(this.y);
            this.Controls.Add(this.x);
            this.Controls.Add(this.ylabel);
            this.Controls.Add(this.xlabel);
            this.Controls.Add(this.label2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label label2;
        private Label xlabel;
        private Label ylabel;
        private TextBox x;
        private TextBox y;
        private DataGridView grid;
        private Button start;
        private Button Create;
        private Label label1;
        private TextBox mazeSize;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox xfin;
        private TextBox yfin;
        private Button mark;
    }
}