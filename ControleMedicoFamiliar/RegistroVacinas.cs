﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControleMedicoFamiliar
{
    public partial class RegistroVacinas : Form
    {
        RegistroVacina regVacina = new RegistroVacina();
        Vacinas vacina = new Vacinas();
        Familiares familiar = new Familiares();
        HomePage home = new HomePage();
        public RegistroVacinas()
        {
            InitializeComponent();
            List<Vacinas> vacinas = new List<Vacinas>();
            vacinas = vacina.Listar();
            foreach (var item in vacinas)
            {
                cbVacina.Items.Add(item.nome +" - "+ item.tipo);
            }

            List<Familiares> familiares = new List<Familiares>();
            familiares = familiar.Listar();
            foreach (var item in familiares)
            {
                cbPessoas.Items.Add(item.Nome);
            }

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string pessoa = cbPessoas.SelectedText;
            string vacina = cbVacina.SelectedText;

            try
            {
                regVacina.Adicionar(pessoa, vacina);
                MessageBox.Show("Vacina registrada com sucesso!");
            }
            catch (Exception)
            {
                MessageBox.Show("Erro ao registrar vacina!");
                throw;
            }
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            home.Refresh();
        }
    }
}
