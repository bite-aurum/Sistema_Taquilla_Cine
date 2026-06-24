using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Taquilla_Cine
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}
		private void FormPrincipal_Load(object sender, EventArgs e)
		{
			cmbTipoBoleto.Items.Add("Estudiante");
			cmbTipoBoleto.Items.Add("Adulto Mayor");
			cmbTipoBoleto.Items.Add("General");

			cmbTipoBoleto.SelectedIndex = 0;
		}

		private void btnCalcular_Click(object sender, EventArgs e)
		{
			decimal precioBase = 80m;
			Boleto boleto = null;

			// ===== INTEGRANTE B =====
			if (cmbTipoBoleto.Text == "Estudiante")
			{
				boleto = new BoletoEstudiante(precioBase, "2026001");
			}

			// ===== INTEGRANTE C =====
			else if (cmbTipoBoleto.Text == "Adulto Mayor")
			{
				boleto = new BoletoAdultoMayor(precioBase, "INAPAM123");
			}

			// ===== INTEGRANTE D =====
			else if (cmbTipoBoleto.Text == "General")
			{
				boleto = new BoletoGeneral(precioBase);
			}

			if (boleto != null)
			{
				decimal total = boleto.CalcularPrecioFinal();

				lblResultado.Text =
					$"Precio Base: ${precioBase}\n" +
					$"Total a Pagar: ${total}";
			}
		}
	}
}
