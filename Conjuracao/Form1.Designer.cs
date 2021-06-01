
namespace Conjuracao
{
    partial class Conjuracao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Conjuracao));
            this.dado1picbox = new System.Windows.Forms.PictureBox();
            this.rolarButton = new System.Windows.Forms.Button();
            this.dado2picbox = new System.Windows.Forms.PictureBox();
            this.dado3picbox = new System.Windows.Forms.PictureBox();
            this.dado4picbox = new System.Windows.Forms.PictureBox();
            this.dado5picbox = new System.Windows.Forms.PictureBox();
            this.dado6picbox = new System.Windows.Forms.PictureBox();
            this.comecarButton = new System.Windows.Forms.Button();
            this.reporButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dado1picbox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dado2picbox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dado3picbox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dado4picbox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dado5picbox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dado6picbox)).BeginInit();
            this.SuspendLayout();
            // 
            // dado1picbox
            // 
            this.dado1picbox.Image = ((System.Drawing.Image)(resources.GetObject("dado1picbox.Image")));
            this.dado1picbox.InitialImage = null;
            this.dado1picbox.Location = new System.Drawing.Point(153, 33);
            this.dado1picbox.Name = "dado1picbox";
            this.dado1picbox.Size = new System.Drawing.Size(100, 100);
            this.dado1picbox.TabIndex = 0;
            this.dado1picbox.TabStop = false;
            // 
            // rolarButton
            // 
            this.rolarButton.Enabled = false;
            this.rolarButton.Location = new System.Drawing.Point(234, 262);
            this.rolarButton.Name = "rolarButton";
            this.rolarButton.Size = new System.Drawing.Size(146, 31);
            this.rolarButton.TabIndex = 1;
            this.rolarButton.Text = "ROLAR";
            this.rolarButton.UseVisualStyleBackColor = true;
            this.rolarButton.Click += new System.EventHandler(this.rolarButton_Click);
            // 
            // dado2picbox
            // 
            this.dado2picbox.Image = ((System.Drawing.Image)(resources.GetObject("dado2picbox.Image")));
            this.dado2picbox.InitialImage = null;
            this.dado2picbox.Location = new System.Drawing.Point(259, 33);
            this.dado2picbox.Name = "dado2picbox";
            this.dado2picbox.Size = new System.Drawing.Size(100, 100);
            this.dado2picbox.TabIndex = 2;
            this.dado2picbox.TabStop = false;
            // 
            // dado3picbox
            // 
            this.dado3picbox.Image = ((System.Drawing.Image)(resources.GetObject("dado3picbox.Image")));
            this.dado3picbox.InitialImage = null;
            this.dado3picbox.Location = new System.Drawing.Point(365, 33);
            this.dado3picbox.Name = "dado3picbox";
            this.dado3picbox.Size = new System.Drawing.Size(100, 100);
            this.dado3picbox.TabIndex = 3;
            this.dado3picbox.TabStop = false;
            // 
            // dado4picbox
            // 
            this.dado4picbox.Image = ((System.Drawing.Image)(resources.GetObject("dado4picbox.Image")));
            this.dado4picbox.InitialImage = null;
            this.dado4picbox.Location = new System.Drawing.Point(153, 139);
            this.dado4picbox.Name = "dado4picbox";
            this.dado4picbox.Size = new System.Drawing.Size(100, 100);
            this.dado4picbox.TabIndex = 4;
            this.dado4picbox.TabStop = false;
            // 
            // dado5picbox
            // 
            this.dado5picbox.Image = ((System.Drawing.Image)(resources.GetObject("dado5picbox.Image")));
            this.dado5picbox.InitialImage = null;
            this.dado5picbox.Location = new System.Drawing.Point(259, 139);
            this.dado5picbox.Name = "dado5picbox";
            this.dado5picbox.Size = new System.Drawing.Size(100, 100);
            this.dado5picbox.TabIndex = 5;
            this.dado5picbox.TabStop = false;
            // 
            // dado6picbox
            // 
            this.dado6picbox.Image = ((System.Drawing.Image)(resources.GetObject("dado6picbox.Image")));
            this.dado6picbox.InitialImage = null;
            this.dado6picbox.Location = new System.Drawing.Point(365, 139);
            this.dado6picbox.Name = "dado6picbox";
            this.dado6picbox.Size = new System.Drawing.Size(100, 100);
            this.dado6picbox.TabIndex = 6;
            this.dado6picbox.TabStop = false;
            // 
            // comecarButton
            // 
            this.comecarButton.Location = new System.Drawing.Point(41, 33);
            this.comecarButton.Name = "comecarButton";
            this.comecarButton.Size = new System.Drawing.Size(75, 23);
            this.comecarButton.TabIndex = 7;
            this.comecarButton.Text = "COMEÇAR";
            this.comecarButton.UseVisualStyleBackColor = true;
            this.comecarButton.Click += new System.EventHandler(this.comecaButton_Click);
            // 
            // reporButton
            // 
            this.reporButton.Enabled = false;
            this.reporButton.Location = new System.Drawing.Point(41, 262);
            this.reporButton.Name = "reporButton";
            this.reporButton.Size = new System.Drawing.Size(106, 30);
            this.reporButton.TabIndex = 8;
            this.reporButton.Text = "REPOR";
            this.reporButton.UseVisualStyleBackColor = true;
            this.reporButton.Click += new System.EventHandler(this.reporButton_Click);
            // 
            // Conjuracao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(624, 321);
            this.Controls.Add(this.reporButton);
            this.Controls.Add(this.comecarButton);
            this.Controls.Add(this.dado6picbox);
            this.Controls.Add(this.dado5picbox);
            this.Controls.Add(this.dado4picbox);
            this.Controls.Add(this.dado3picbox);
            this.Controls.Add(this.dado2picbox);
            this.Controls.Add(this.rolarButton);
            this.Controls.Add(this.dado1picbox);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "Conjuracao";
            this.Text = "Conjuração";
            ((System.ComponentModel.ISupportInitialize)(this.dado1picbox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dado2picbox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dado3picbox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dado4picbox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dado5picbox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dado6picbox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button rolarButton;
        public System.Windows.Forms.PictureBox dado1picbox;
        public System.Windows.Forms.PictureBox dado2picbox;
        public System.Windows.Forms.PictureBox dado3picbox;
        public System.Windows.Forms.PictureBox dado4picbox;
        public System.Windows.Forms.PictureBox dado5picbox;
        public System.Windows.Forms.PictureBox dado6picbox;
        private System.Windows.Forms.Button comecarButton;
        private System.Windows.Forms.Button reporButton;
    }
}

