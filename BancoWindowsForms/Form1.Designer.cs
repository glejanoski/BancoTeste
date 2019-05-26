namespace BancoWindowsForms
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnMsg = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.nomeCompleto = new System.Windows.Forms.Label();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnMsg
            // 
            this.btnMsg.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnMsg.Location = new System.Drawing.Point(209, 37);
            this.btnMsg.Name = "btnMsg";
            this.btnMsg.Size = new System.Drawing.Size(130, 64);
            this.btnMsg.TabIndex = 0;
            this.btnMsg.Text = "Exibir Menagem";
            this.btnMsg.UseVisualStyleBackColor = false;
            this.btnMsg.Click += new System.EventHandler(this.btnMsg_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(209, 124);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 1;
            // 
            // nomeCompleto
            // 
            this.nomeCompleto.AutoSize = true;
            this.nomeCompleto.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.nomeCompleto.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.nomeCompleto.Location = new System.Drawing.Point(103, 131);
            this.nomeCompleto.Name = "nomeCompleto";
            this.nomeCompleto.Size = new System.Drawing.Size(82, 13);
            this.nomeCompleto.TabIndex = 2;
            this.nomeCompleto.Text = "Nome Completo";
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.nomeCompleto);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.btnMsg);
            this.ForeColor = System.Drawing.SystemColors.InfoText;
            this.Name = "Form1";
            this.Text = "formularioConta";
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMsg;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label nomeCompleto;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
    }
}

