
namespace YurtKayitOtomasyonu
{
    partial class FrmBolumler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBolumler));
            this.pcbbolumekle = new System.Windows.Forms.PictureBox();
            this.pcbbolumsil = new System.Windows.Forms.PictureBox();
            this.pcbbolumguncelle = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtbolumid = new System.Windows.Forms.TextBox();
            this.txtbolumad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.yurtKayitDataSet = new YurtKayitOtomasyonu.YurtKayitDataSet();
            this.bolumlerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bolumlerTableAdapter = new YurtKayitOtomasyonu.YurtKayitDataSetTableAdapters.BolumlerTableAdapter();
            this.bolumIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bolumAdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pcbbolumekle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbbolumsil)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbbolumguncelle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yurtKayitDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bolumlerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pcbbolumekle
            // 
            this.pcbbolumekle.Image = ((System.Drawing.Image)(resources.GetObject("pcbbolumekle.Image")));
            this.pcbbolumekle.Location = new System.Drawing.Point(455, 40);
            this.pcbbolumekle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pcbbolumekle.Name = "pcbbolumekle";
            this.pcbbolumekle.Size = new System.Drawing.Size(67, 53);
            this.pcbbolumekle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbbolumekle.TabIndex = 0;
            this.pcbbolumekle.TabStop = false;
            this.toolTip1.SetToolTip(this.pcbbolumekle, "Bölüm Ekle");
            this.pcbbolumekle.Click += new System.EventHandler(this.pcbbolumekle_Click);
            // 
            // pcbbolumsil
            // 
            this.pcbbolumsil.Image = ((System.Drawing.Image)(resources.GetObject("pcbbolumsil.Image")));
            this.pcbbolumsil.Location = new System.Drawing.Point(530, 40);
            this.pcbbolumsil.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pcbbolumsil.Name = "pcbbolumsil";
            this.pcbbolumsil.Size = new System.Drawing.Size(65, 53);
            this.pcbbolumsil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbbolumsil.TabIndex = 1;
            this.pcbbolumsil.TabStop = false;
            this.toolTip1.SetToolTip(this.pcbbolumsil, "Bölüm Sil");
            this.pcbbolumsil.Click += new System.EventHandler(this.pcbbolumsil_Click);
            // 
            // pcbbolumguncelle
            // 
            this.pcbbolumguncelle.Image = ((System.Drawing.Image)(resources.GetObject("pcbbolumguncelle.Image")));
            this.pcbbolumguncelle.Location = new System.Drawing.Point(603, 40);
            this.pcbbolumguncelle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pcbbolumguncelle.Name = "pcbbolumguncelle";
            this.pcbbolumguncelle.Size = new System.Drawing.Size(67, 52);
            this.pcbbolumguncelle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbbolumguncelle.TabIndex = 2;
            this.pcbbolumguncelle.TabStop = false;
            this.toolTip1.SetToolTip(this.pcbbolumguncelle, "Bölüm Güncelle");
            this.pcbbolumguncelle.Click += new System.EventHandler(this.pcbbolumguncelle_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(17, 43);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "Bölüm ID:";
            // 
            // txtbolumid
            // 
            this.txtbolumid.Enabled = false;
            this.txtbolumid.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtbolumid.Location = new System.Drawing.Point(105, 40);
            this.txtbolumid.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtbolumid.Name = "txtbolumid";
            this.txtbolumid.Size = new System.Drawing.Size(300, 25);
            this.txtbolumid.TabIndex = 4;
            // 
            // txtbolumad
            // 
            this.txtbolumad.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtbolumad.Location = new System.Drawing.Point(105, 73);
            this.txtbolumad.Margin = new System.Windows.Forms.Padding(4);
            this.txtbolumad.Name = "txtbolumad";
            this.txtbolumad.Size = new System.Drawing.Size(300, 25);
            this.txtbolumad.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(17, 76);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "Bölüm AD:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bolumIDDataGridViewTextBoxColumn,
            this.bolumAdDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.bolumlerBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(1, 165);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(694, 272);
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // yurtKayitDataSet
            // 
            this.yurtKayitDataSet.DataSetName = "YurtKayitDataSet";
            this.yurtKayitDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bolumlerBindingSource
            // 
            this.bolumlerBindingSource.DataMember = "Bolumler";
            this.bolumlerBindingSource.DataSource = this.yurtKayitDataSet;
            // 
            // bolumlerTableAdapter
            // 
            this.bolumlerTableAdapter.ClearBeforeFill = true;
            // 
            // bolumIDDataGridViewTextBoxColumn
            // 
            this.bolumIDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.bolumIDDataGridViewTextBoxColumn.DataPropertyName = "BolumID";
            this.bolumIDDataGridViewTextBoxColumn.HeaderText = "BolumID";
            this.bolumIDDataGridViewTextBoxColumn.Name = "bolumIDDataGridViewTextBoxColumn";
            this.bolumIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.bolumIDDataGridViewTextBoxColumn.Width = 90;
            // 
            // bolumAdDataGridViewTextBoxColumn
            // 
            this.bolumAdDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.bolumAdDataGridViewTextBoxColumn.DataPropertyName = "BolumAd";
            this.bolumAdDataGridViewTextBoxColumn.HeaderText = "BolumAd";
            this.bolumAdDataGridViewTextBoxColumn.Name = "bolumAdDataGridViewTextBoxColumn";
            this.bolumAdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // FrmBolumler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(696, 440);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtbolumad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtbolumid);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pcbbolumguncelle);
            this.Controls.Add(this.pcbbolumsil);
            this.Controls.Add(this.pcbbolumekle);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmBolumler";
            this.Text = "Bölümler";
            this.Load += new System.EventHandler(this.FrmBolumler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcbbolumekle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbbolumsil)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbbolumguncelle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yurtKayitDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bolumlerBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pcbbolumekle;
        private System.Windows.Forms.PictureBox pcbbolumsil;
        private System.Windows.Forms.PictureBox pcbbolumguncelle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtbolumid;
        private System.Windows.Forms.TextBox txtbolumad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private YurtKayitDataSet yurtKayitDataSet;
        private System.Windows.Forms.BindingSource bolumlerBindingSource;
        private YurtKayitDataSetTableAdapters.BolumlerTableAdapter bolumlerTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn bolumIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bolumAdDataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}