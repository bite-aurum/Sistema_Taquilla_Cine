namespace Sistema_Taquilla_Cine
{
	partial class Form1
	{
		/// <summary>
		/// Variable del diseñador necesaria.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Limpiar los recursos que se estén usando.
		/// </summary>
		/// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Código generado por el Diseñador de Windows Forms

		/// <summary>
		/// Método necesario para admitir el Diseñador. No se puede modificar
		/// el contenido de este método con el editor de código.
		/// </summary>
		private void InitializeComponent()
		{
			this.lblTitulo = new System.Windows.Forms.Label();
			this.lblTipoBoleto = new System.Windows.Forms.Label();
			this.cmbTipoBoleto = new System.Windows.Forms.ComboBox();
			this.btnCalcular = new System.Windows.Forms.Button();
			this.lblResultado = new System.Windows.Forms.Label();
			this.SuspendLayout();

			// lblTitulo

			this.lblTitulo.AutoSize = true;
			this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 16F,
				System.Drawing.FontStyle.Bold);
			this.lblTitulo.Location = new System.Drawing.Point(70, 20);
			this.lblTitulo.Name = "lblTitulo";
			this.lblTitulo.Size = new System.Drawing.Size(290, 37);
			this.lblTitulo.TabIndex = 0;
			this.lblTitulo.Text = "TAQUILLA DE CINE";

			// lblTipoBoleto

			this.lblTipoBoleto.AutoSize = true;
			this.lblTipoBoleto.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.lblTipoBoleto.Location = new System.Drawing.Point(35, 90);
			this.lblTipoBoleto.Name = "lblTipoBoleto";
			this.lblTipoBoleto.Size = new System.Drawing.Size(122, 23);
			this.lblTipoBoleto.TabIndex = 1;
			this.lblTipoBoleto.Text = "Tipo de boleto:";

			// cmbTipoBoleto

			this.cmbTipoBoleto.DropDownStyle =
				System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbTipoBoleto.FormattingEnabled = true;
			this.cmbTipoBoleto.Location = new System.Drawing.Point(170, 88);
			this.cmbTipoBoleto.Name = "cmbTipoBoleto";
			this.cmbTipoBoleto.Size = new System.Drawing.Size(180, 28);
			this.cmbTipoBoleto.TabIndex = 2;

			// btnCalcular

			this.btnCalcular.Font = new System.Drawing.Font("Segoe UI", 10F,
				System.Drawing.FontStyle.Bold);
			this.btnCalcular.Location = new System.Drawing.Point(150, 140);
			this.btnCalcular.Name = "btnCalcular";
			this.btnCalcular.Size = new System.Drawing.Size(120, 40);
			this.btnCalcular.TabIndex = 3;
			this.btnCalcular.Text = "Calcular";
			this.btnCalcular.UseVisualStyleBackColor = true;
			this.btnCalcular.Click +=
				new System.EventHandler(this.btnCalcular_Click);

			// lblResultado

			this.lblResultado.BorderStyle =
				System.Windows.Forms.BorderStyle.FixedSingle;
			this.lblResultado.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.lblResultado.Location = new System.Drawing.Point(35, 200);
			this.lblResultado.Name = "lblResultado";
			this.lblResultado.Size = new System.Drawing.Size(330, 70);
			this.lblResultado.TabIndex = 4;
			this.lblResultado.Text = "Resultado...";
			this.lblResultado.TextAlign =
				System.Drawing.ContentAlignment.MiddleCenter;

			// FormPrincipal

			this.AutoScaleDimensions =
				new System.Drawing.SizeF(8F, 20F);
			this.AutoScaleMode =
				System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize =
				new System.Drawing.Size(420, 300);
			this.Controls.Add(this.lblResultado);
			this.Controls.Add(this.btnCalcular);
			this.Controls.Add(this.cmbTipoBoleto);
			this.Controls.Add(this.lblTipoBoleto);
			this.Controls.Add(this.lblTitulo);
			this.FormBorderStyle =
				System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "FormPrincipal";
			this.StartPosition =
				System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Sistema de Taquilla de Cine";
			this.Load +=
				new System.EventHandler(this.FormPrincipal_Load);
			this.ResumeLayout(false);
			this.PerformLayout();
		}


		#endregion
		private System.Windows.Forms.Label lblTitulo;
		private System.Windows.Forms.Label lblTipoBoleto;
		private System.Windows.Forms.ComboBox cmbTipoBoleto;
		private System.Windows.Forms.Button btnCalcular;
		private System.Windows.Forms.Label lblResultado;
	}
}

