﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraWinForm2019_1_06092021
{
    public partial class frmCalculadoraWinForms_1_06092021 : Form
    {
        string strOperador;
        double a = 0;
        bool bolValidar = false;

        public frmCalculadoraWinForms_1_06092021()
        {
            InitializeComponent();
        }

        private void btnNumerador(object sender, EventArgs e)
        {
            Button bt = (Button)sender;
            txtValor.Text = txtValor.Text + bt.Text;
        }

        private void btnLimpa_Click(object sender, EventArgs e)
        {
            txtValor.Text = "";
            label1.Text = "";
            a = 0;
            bolValidar = false;
        }

        private void btnSoma_Click(object sender, EventArgs e)
        {
            if (bolValidar == true)
            {
                a = a + Convert.ToDouble(txtValor.Text);
                label1.Text = Convert.ToString(a) + "+";
                txtValor.Text = "";
                strOperador = "+";
            }
            else
            {
                label1.Text = txtValor.Text + btnSoma.Text;
                a = Convert.ToDouble(txtValor.Text);
                txtValor.Text = "";
                strOperador = "+";
                bolValidar = true;
            }
        }

        private void btnSubtrai_Click(object sender, EventArgs e)
        {
            if (bolValidar == true)
            {
                a = a - Convert.ToDouble(txtValor.Text);
                label1.Text = Convert.ToString(a) + "-";
                txtValor.Text = "";
                strOperador = "-";
            }
            else
            {
                label1.Text = txtValor.Text + btnSubtrai.Text;
                a = Convert.ToDouble(txtValor.Text);
                txtValor.Text = "";
                strOperador = "-";
                bolValidar = true;
            }
        }

        private void btnMultiplica_Click(object sender, EventArgs e)
        {
            if (bolValidar == true)
            {
                a = a * Convert.ToDouble(txtValor.Text);
                label1.Text = Convert.ToString(a) + "*";
                txtValor.Text = "";
                strOperador = "*";
            }
            else
            {
                label1.Text = txtValor.Text + btnMultiplica.Text;
                a = Convert.ToDouble(txtValor.Text);
                txtValor.Text = "";
                strOperador = "*";
                bolValidar = true;
            }
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            if (bolValidar == true)
            {
                a = a / Convert.ToDouble(txtValor.Text);
                label1.Text = Convert.ToString(a) + "/";
                txtValor.Text = "";
                strOperador = "/";
            }
            else
            {
                label1.Text = txtValor.Text + btnDivide.Text;
                a = Convert.ToDouble(txtValor.Text);
                txtValor.Text = "";
                strOperador = "/";
                bolValidar = true;
            }
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            try
            {
                if ((txtValor.Text == "") || (label1.Text == ""))
                {
                    MessageBox.Show("Insira os valores antes de clicar");
                }
                if (strOperador == "+")
                {
                    label1.Text = label1.Text + txtValor.Text + "=";
                    txtValor.Text = Convert.ToString(a + Convert.ToDouble(txtValor.Text));
                }
                else if (strOperador == "-")
                {
                    label1.Text = label1.Text + txtValor.Text + "=";
                    txtValor.Text = Convert.ToString(a - Convert.ToDouble(txtValor.Text));
                }
                else if (strOperador == "*")
                {
                    label1.Text = label1.Text + txtValor.Text + "=";
                    txtValor.Text = Convert.ToString(a * Convert.ToDouble(txtValor.Text));
                }
                else if (strOperador == "/")
                {
                    label1.Text = label1.Text + txtValor.Text + "=";
                    txtValor.Text = Convert.ToString(a / Convert.ToDouble(txtValor.Text));
                }
            }
            catch (Exception ex)
            {

                throw new Exception("Problemas na operação ==> " + ex.Message);
            }
            
        }
    }
}
