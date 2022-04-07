namespace bioskop
{
    partial class Bioskop
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
            this.dgTabela = new System.Windows.Forms.DataGridView();
            this.bioskop2DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bioskop2DataSet = new bioskop.Bioskop2DataSet();
            this.tbFilm = new System.Windows.Forms.TextBox();
            this.tbVreme = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnOpis = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgTabela)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bioskop2DataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bioskop2DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dgTabela
            // 
            this.dgTabela.AllowUserToAddRows = false;
            this.dgTabela.AllowUserToDeleteRows = false;
            this.dgTabela.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgTabela.Location = new System.Drawing.Point(36, 134);
            this.dgTabela.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgTabela.Name = "dgTabela";
            this.dgTabela.ReadOnly = true;
            this.dgTabela.RowHeadersWidth = 102;
            this.dgTabela.RowTemplate.Height = 40;
            this.dgTabela.Size = new System.Drawing.Size(589, 312);
            this.dgTabela.TabIndex = 0;
            // 
            // bioskop2DataSetBindingSource
            // 
            this.bioskop2DataSetBindingSource.DataSource = this.bioskop2DataSet;
            this.bioskop2DataSetBindingSource.Position = 0;
            // 
            // bioskop2DataSet
            // 
            this.bioskop2DataSet.DataSetName = "Bioskop2DataSet";
            this.bioskop2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbFilm
            // 
            this.tbFilm.Location = new System.Drawing.Point(95, 83);
            this.tbFilm.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbFilm.Name = "tbFilm";
            this.tbFilm.Size = new System.Drawing.Size(124, 22);
            this.tbFilm.TabIndex = 1;
            // 
            // tbVreme
            // 
            this.tbVreme.Location = new System.Drawing.Point(313, 83);
            this.tbVreme.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbVreme.Name = "tbVreme";
            this.tbVreme.Size = new System.Drawing.Size(124, 22);
            this.tbVreme.TabIndex = 2;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(561, 77);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(98, 28);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "Traži";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnOpis
            // 
            this.btnOpis.Location = new System.Drawing.Point(664, 134);
            this.btnOpis.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnOpis.Name = "btnOpis";
            this.btnOpis.Size = new System.Drawing.Size(98, 28);
            this.btnOpis.TabIndex = 4;
            this.btnOpis.Text = "Saznaj više!";
            this.btnOpis.UseVisualStyleBackColor = true;
            this.btnOpis.Click += new System.EventHandler(this.btnOpis_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(92, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Ime filma:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(310, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Vreme projekcije:";
            // 
            // Bioskop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 500);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnOpis);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.tbVreme);
            this.Controls.Add(this.tbFilm);
            this.Controls.Add(this.dgTabela);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Bioskop";
            this.Text = "Bioskop";
            this.Load += new System.EventHandler(this.Bioskop_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgTabela)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bioskop2DataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bioskop2DataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgTabela;
        private System.Windows.Forms.BindingSource bioskop2DataSetBindingSource;
        private Bioskop2DataSet bioskop2DataSet;
        private System.Windows.Forms.TextBox tbFilm;
        private System.Windows.Forms.TextBox tbVreme;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnOpis;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

