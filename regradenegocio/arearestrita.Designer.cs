
namespace regradenegocio
{
    partial class arearestrita
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
            this.lstHoras = new System.Windows.Forms.ListView();
            this.lstDia = new System.Windows.Forms.ListView();
            this.lstDolar = new System.Windows.Forms.ListView();
            this.lstReal = new System.Windows.Forms.ListView();
            this.btnHoras = new System.Windows.Forms.Button();
            this.btnDia = new System.Windows.Forms.Button();
            this.btnDolar = new System.Windows.Forms.Button();
            this.btnReal = new System.Windows.Forms.Button();
            this.btnCep = new System.Windows.Forms.Button();
            this.lblCep = new System.Windows.Forms.Label();
            this.txtCep = new System.Windows.Forms.TextBox();
            this.lstCep = new System.Windows.Forms.ListView();
            this.btnTemperatura = new System.Windows.Forms.Button();
            this.lblTemperatura = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstHoras
            // 
            this.lstHoras.HideSelection = false;
            this.lstHoras.Location = new System.Drawing.Point(262, 81);
            this.lstHoras.Name = "lstHoras";
            this.lstHoras.Size = new System.Drawing.Size(121, 97);
            this.lstHoras.TabIndex = 0;
            this.lstHoras.UseCompatibleStateImageBehavior = false;
            // 
            // lstDia
            // 
            this.lstDia.HideSelection = false;
            this.lstDia.Location = new System.Drawing.Point(549, 81);
            this.lstDia.Name = "lstDia";
            this.lstDia.Size = new System.Drawing.Size(121, 97);
            this.lstDia.TabIndex = 1;
            this.lstDia.UseCompatibleStateImageBehavior = false;
            // 
            // lstDolar
            // 
            this.lstDolar.HideSelection = false;
            this.lstDolar.Location = new System.Drawing.Point(262, 220);
            this.lstDolar.Name = "lstDolar";
            this.lstDolar.Size = new System.Drawing.Size(121, 97);
            this.lstDolar.TabIndex = 2;
            this.lstDolar.UseCompatibleStateImageBehavior = false;
            // 
            // lstReal
            // 
            this.lstReal.HideSelection = false;
            this.lstReal.Location = new System.Drawing.Point(549, 220);
            this.lstReal.Name = "lstReal";
            this.lstReal.Size = new System.Drawing.Size(121, 97);
            this.lstReal.TabIndex = 3;
            this.lstReal.UseCompatibleStateImageBehavior = false;
            // 
            // btnHoras
            // 
            this.btnHoras.Location = new System.Drawing.Point(150, 81);
            this.btnHoras.Name = "btnHoras";
            this.btnHoras.Size = new System.Drawing.Size(89, 44);
            this.btnHoras.TabIndex = 4;
            this.btnHoras.Text = "Que horas são?";
            this.btnHoras.UseVisualStyleBackColor = true;
            this.btnHoras.Click += new System.EventHandler(this.btnHoras_Click);
            // 
            // btnDia
            // 
            this.btnDia.Location = new System.Drawing.Point(432, 81);
            this.btnDia.Name = "btnDia";
            this.btnDia.Size = new System.Drawing.Size(75, 44);
            this.btnDia.TabIndex = 5;
            this.btnDia.Text = "Que dia é hoje?";
            this.btnDia.UseVisualStyleBackColor = true;
            this.btnDia.Click += new System.EventHandler(this.btnDia_Click);
            // 
            // btnDolar
            // 
            this.btnDolar.Location = new System.Drawing.Point(150, 220);
            this.btnDolar.Name = "btnDolar";
            this.btnDolar.Size = new System.Drawing.Size(75, 23);
            this.btnDolar.TabIndex = 6;
            this.btnDolar.Text = "USD-BRL";
            this.btnDolar.UseVisualStyleBackColor = true;
            this.btnDolar.Click += new System.EventHandler(this.btnDolar_Click);
            // 
            // btnReal
            // 
            this.btnReal.Location = new System.Drawing.Point(432, 220);
            this.btnReal.Name = "btnReal";
            this.btnReal.Size = new System.Drawing.Size(75, 23);
            this.btnReal.TabIndex = 7;
            this.btnReal.Text = "BRL-USD";
            this.btnReal.UseVisualStyleBackColor = true;
            this.btnReal.Click += new System.EventHandler(this.btnReal_Click);
            // 
            // btnCep
            // 
            this.btnCep.Location = new System.Drawing.Point(266, 464);
            this.btnCep.Name = "btnCep";
            this.btnCep.Size = new System.Drawing.Size(75, 23);
            this.btnCep.TabIndex = 8;
            this.btnCep.Text = "Buscar";
            this.btnCep.UseVisualStyleBackColor = true;
            this.btnCep.Click += new System.EventHandler(this.btnCep_Click);
            // 
            // lblCep
            // 
            this.lblCep.AutoSize = true;
            this.lblCep.Location = new System.Drawing.Point(211, 438);
            this.lblCep.Name = "lblCep";
            this.lblCep.Size = new System.Drawing.Size(28, 13);
            this.lblCep.TabIndex = 9;
            this.lblCep.Text = "CEP";
            // 
            // txtCep
            // 
            this.txtCep.Location = new System.Drawing.Point(253, 438);
            this.txtCep.Name = "txtCep";
            this.txtCep.Size = new System.Drawing.Size(100, 20);
            this.txtCep.TabIndex = 10;
            this.txtCep.TextChanged += new System.EventHandler(this.BuscaCep);
            // 
            // lstCep
            // 
            this.lstCep.HideSelection = false;
            this.lstCep.Location = new System.Drawing.Point(413, 438);
            this.lstCep.Name = "lstCep";
            this.lstCep.Size = new System.Drawing.Size(199, 156);
            this.lstCep.TabIndex = 11;
            this.lstCep.UseCompatibleStateImageBehavior = false;
            // 
            // btnTemperatura
            // 
            this.btnTemperatura.Location = new System.Drawing.Point(764, 81);
            this.btnTemperatura.Name = "btnTemperatura";
            this.btnTemperatura.Size = new System.Drawing.Size(75, 57);
            this.btnTemperatura.TabIndex = 12;
            this.btnTemperatura.Text = "Qual a temperatura de hoje?";
            this.btnTemperatura.UseVisualStyleBackColor = true;
            this.btnTemperatura.Click += new System.EventHandler(this.btnTemperatura_Click);
            // 
            // lblTemperatura
            // 
            this.lblTemperatura.AutoSize = true;
            this.lblTemperatura.Location = new System.Drawing.Point(892, 103);
            this.lblTemperatura.Name = "lblTemperatura";
            this.lblTemperatura.Size = new System.Drawing.Size(35, 13);
            this.lblTemperatura.TabIndex = 13;
            this.lblTemperatura.Text = "label1";
            // 
            // arearestrita
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1092, 683);
            this.Controls.Add(this.lblTemperatura);
            this.Controls.Add(this.btnTemperatura);
            this.Controls.Add(this.lstCep);
            this.Controls.Add(this.txtCep);
            this.Controls.Add(this.lblCep);
            this.Controls.Add(this.btnCep);
            this.Controls.Add(this.btnReal);
            this.Controls.Add(this.btnDolar);
            this.Controls.Add(this.btnDia);
            this.Controls.Add(this.btnHoras);
            this.Controls.Add(this.lstReal);
            this.Controls.Add(this.lstDolar);
            this.Controls.Add(this.lstDia);
            this.Controls.Add(this.lstHoras);
            this.Name = "arearestrita";
            this.Text = "arearestrita";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lstHoras;
        private System.Windows.Forms.ListView lstDia;
        private System.Windows.Forms.ListView lstDolar;
        private System.Windows.Forms.ListView lstReal;
        private System.Windows.Forms.Button btnHoras;
        private System.Windows.Forms.Button btnDia;
        private System.Windows.Forms.Button btnDolar;
        private System.Windows.Forms.Button btnReal;
        private System.Windows.Forms.Button btnCep;
        private System.Windows.Forms.Label lblCep;
        private System.Windows.Forms.TextBox txtCep;
        private System.Windows.Forms.ListView lstCep;
        private System.Windows.Forms.Button btnTemperatura;
        private System.Windows.Forms.Label lblTemperatura;
    }
}