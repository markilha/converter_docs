namespace ConverterDocumento
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cboPadraoArquivos = new System.Windows.Forms.ComboBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbArquivos = new System.Windows.Forms.ListBox();
            this.fbd1 = new System.Windows.Forms.FolderBrowserDialog();
            this.btnConverter = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.btnJuntar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.progressBar1);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.btnBuscar);
            this.groupBox1.Controls.Add(this.cboPadraoArquivos);
            this.groupBox1.Location = new System.Drawing.Point(42, 35);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(713, 381);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // cboPadraoArquivos
            // 
            this.cboPadraoArquivos.FormattingEnabled = true;
            this.cboPadraoArquivos.Location = new System.Drawing.Point(28, 32);
            this.cboPadraoArquivos.Name = "cboPadraoArquivos";
            this.cboPadraoArquivos.Size = new System.Drawing.Size(136, 21);
            this.cboPadraoArquivos.TabIndex = 0;
            this.cboPadraoArquivos.Text = "DOCX Files (*.docx)";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(170, 32);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(103, 22);
            this.btnBuscar.TabIndex = 1;
            this.btnBuscar.Text = "buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbArquivos);
            this.groupBox2.Location = new System.Drawing.Point(28, 70);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(655, 271);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Arquivos";
            // 
            // lbArquivos
            // 
            this.lbArquivos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbArquivos.FormattingEnabled = true;
            this.lbArquivos.Location = new System.Drawing.Point(3, 16);
            this.lbArquivos.Name = "lbArquivos";
            this.lbArquivos.Size = new System.Drawing.Size(649, 252);
            this.lbArquivos.TabIndex = 0;
            // 
            // btnConverter
            // 
            this.btnConverter.Location = new System.Drawing.Point(585, 422);
            this.btnConverter.Name = "btnConverter";
            this.btnConverter.Size = new System.Drawing.Size(170, 35);
            this.btnConverter.TabIndex = 2;
            this.btnConverter.Text = "Converter ";
            this.btnConverter.UseVisualStyleBackColor = true;
            this.btnConverter.Click += new System.EventHandler(this.btnConverter_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(31, 347);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(649, 21);
            this.progressBar1.TabIndex = 3;
            // 
            // btnJuntar
            // 
            this.btnJuntar.Location = new System.Drawing.Point(409, 422);
            this.btnJuntar.Name = "btnJuntar";
            this.btnJuntar.Size = new System.Drawing.Size(170, 35);
            this.btnJuntar.TabIndex = 3;
            this.btnJuntar.Text = "Mesclar";
            this.btnJuntar.UseVisualStyleBackColor = true;
            this.btnJuntar.Click += new System.EventHandler(this.btnJuntar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 469);
            this.Controls.Add(this.btnJuntar);
            this.Controls.Add(this.btnConverter);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Converter Arquivos";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox lbArquivos;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.ComboBox cboPadraoArquivos;
        private System.Windows.Forms.FolderBrowserDialog fbd1;
        private System.Windows.Forms.Button btnConverter;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button btnJuntar;
    }
}

