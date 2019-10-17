using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuicheAtendimento
{
    //Cintia Donabela
    public partial class Form1 : Form
    {
        Senhas senhas = new Senhas();
        Guiches guiches = new Guiches();
        Guiche guiche = new Guiche();
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_adcGuiche_Click(object sender, EventArgs e)
        {
            lbl_numGuiches.Text = (int.Parse(lbl_numGuiches.Text) + 1).ToString() ;
            guiches.adicionar(new Guiche(int.Parse(lbl_numGuiches.Text)));

            nmr_guiche.Maximum = int.Parse(lbl_numGuiches.Text);
        }

        private void btn_gerar_Click(object sender, EventArgs e)
        {
            senhas.gerar();
        }

        private void btn_listarSenha_Click(object sender, EventArgs e)
        {
            mostraFilaSenhas();
        }

        void mostraFilaSenhas()
        {
            lst_senhas.Items.Clear();
            foreach (Senha s in senhas.FilaSenhas)
            {
                lst_senhas.Items.Add(s.dadosParciais());
            }
        }

        private void btn_listarAtend_Click(object sender, EventArgs e)
        {
            mostraFilaAtendimento();
        }
        void mostraFilaAtendimento()
        {
            lst_atendimento.Items.Clear();
            foreach (Senha s in guiche.ListaAtendimentos)
            {
                lst_atendimento.Items.Add("Guichê: " + nmr_guiche.Value.ToString() + " Senha: " + s.dadosCompletos());
            }
        }

        private void btn_chamar_Click(object sender, EventArgs e)
        {
           guiche.chamar(senhas.FilaSenhas);
        }

        private void nmr_guiche_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
