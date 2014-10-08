namespace LogParser
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
            this.textBoxCesta = new System.Windows.Forms.TextBox();
            this.labelCesta = new System.Windows.Forms.Label();
            this.buttonCesta = new System.Windows.Forms.Button();
            this.groupBoxParametrers = new System.Windows.Forms.GroupBox();
            this.buttonPodm_1 = new System.Windows.Forms.Button();
            this.textBoxPodm_1 = new System.Windows.Forms.TextBox();
            this.buttonStart = new System.Windows.Forms.Button();
            this.openFileDialogCesta = new System.Windows.Forms.OpenFileDialog();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeaderID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderString = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonExport = new System.Windows.Forms.Button();
            this.saveFileDialogExport = new System.Windows.Forms.SaveFileDialog();
            this.groupBoxParametrers.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxCesta
            // 
            this.textBoxCesta.Location = new System.Drawing.Point(12, 25);
            this.textBoxCesta.Name = "textBoxCesta";
            this.textBoxCesta.Size = new System.Drawing.Size(317, 20);
            this.textBoxCesta.TabIndex = 0;
            // 
            // labelCesta
            // 
            this.labelCesta.AutoSize = true;
            this.labelCesta.Location = new System.Drawing.Point(12, 9);
            this.labelCesta.Name = "labelCesta";
            this.labelCesta.Size = new System.Drawing.Size(32, 13);
            this.labelCesta.TabIndex = 1;
            this.labelCesta.Text = "Path:";
            // 
            // buttonCesta
            // 
            this.buttonCesta.Location = new System.Drawing.Point(335, 23);
            this.buttonCesta.Name = "buttonCesta";
            this.buttonCesta.Size = new System.Drawing.Size(34, 23);
            this.buttonCesta.TabIndex = 2;
            this.buttonCesta.Text = "...";
            this.buttonCesta.UseVisualStyleBackColor = true;
            this.buttonCesta.Click += new System.EventHandler(this.buttonCesta_Click);
            // 
            // groupBoxParametrers
            // 
            this.groupBoxParametrers.Controls.Add(this.buttonPodm_1);
            this.groupBoxParametrers.Controls.Add(this.textBoxPodm_1);
            this.groupBoxParametrers.Location = new System.Drawing.Point(12, 61);
            this.groupBoxParametrers.Name = "groupBoxParametrers";
            this.groupBoxParametrers.Size = new System.Drawing.Size(362, 58);
            this.groupBoxParametrers.TabIndex = 3;
            this.groupBoxParametrers.TabStop = false;
            this.groupBoxParametrers.Text = "Parameters:";
            // 
            // buttonPodm_1
            // 
            this.buttonPodm_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonPodm_1.Location = new System.Drawing.Point(323, 16);
            this.buttonPodm_1.Name = "buttonPodm_1";
            this.buttonPodm_1.Size = new System.Drawing.Size(34, 23);
            this.buttonPodm_1.TabIndex = 4;
            this.buttonPodm_1.Text = "+";
            this.buttonPodm_1.UseVisualStyleBackColor = true;
            this.buttonPodm_1.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBoxPodm_1
            // 
            this.textBoxPodm_1.Location = new System.Drawing.Point(6, 19);
            this.textBoxPodm_1.Name = "textBoxPodm_1";
            this.textBoxPodm_1.Size = new System.Drawing.Size(311, 20);
            this.textBoxPodm_1.TabIndex = 0;
            // 
            // buttonStart
            // 
            this.buttonStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonStart.Location = new System.Drawing.Point(616, 513);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(75, 23);
            this.buttonStart.TabIndex = 4;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // listView1
            // 
            this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderID,
            this.columnHeaderString});
            this.listView1.Location = new System.Drawing.Point(12, 125);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(689, 382);
            this.listView1.TabIndex = 5;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SizeChanged += new System.EventHandler(this.listView1_SizeChanged);
            // 
            // columnHeaderID
            // 
            this.columnHeaderID.Text = "FieldID";
            this.columnHeaderID.Width = 80;
            // 
            // columnHeaderString
            // 
            this.columnHeaderString.Text = "String";
            this.columnHeaderString.Width = 270;
            // 
            // buttonExport
            // 
            this.buttonExport.Location = new System.Drawing.Point(12, 513);
            this.buttonExport.Name = "buttonExport";
            this.buttonExport.Size = new System.Drawing.Size(108, 23);
            this.buttonExport.TabIndex = 6;
            this.buttonExport.Text = "Export";
            this.buttonExport.UseVisualStyleBackColor = true;
            this.buttonExport.Visible = false;
            this.buttonExport.Click += new System.EventHandler(this.buttonExport_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 548);
            this.Controls.Add(this.buttonExport);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.groupBoxParametrers);
            this.Controls.Add(this.buttonCesta);
            this.Controls.Add(this.labelCesta);
            this.Controls.Add(this.textBoxCesta);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Log Parser";
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.groupBoxParametrers.ResumeLayout(false);
            this.groupBoxParametrers.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxCesta;
        private System.Windows.Forms.Label labelCesta;
        private System.Windows.Forms.Button buttonCesta;
        private System.Windows.Forms.GroupBox groupBoxParametrers;
        private System.Windows.Forms.Button buttonPodm_1;
        private System.Windows.Forms.TextBox textBoxPodm_1;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.OpenFileDialog openFileDialogCesta;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeaderID;
        private System.Windows.Forms.ColumnHeader columnHeaderString;
        private System.Windows.Forms.Button buttonExport;
        private System.Windows.Forms.SaveFileDialog saveFileDialogExport;
    }
}

