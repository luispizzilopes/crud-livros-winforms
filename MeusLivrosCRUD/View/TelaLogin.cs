﻿using MeusLivrosCRUD.Controller.Login;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MeusLivrosCRUD.View
{
    public partial class TelaLogin : Form
    {
        public TelaLogin()
        {
            InitializeComponent();
        }

        ControllerLogin controllerLogin = new ControllerLogin();

        private void btnAcessar_Click(object sender, EventArgs e)
        {
            if (txtBoxUsuario.Text != string.Empty && txtBoxSenha.Text != string.Empty)
            {
                if(controllerLogin.Acessar(txtBoxUsuario.Text, txtBoxSenha.Text) == true)
                {
                    TelaPrincipal tela = new TelaPrincipal();
                    tela.Show();
                    this.Visible = false; 
                }
                else
                {
                    MessageBox.Show("Não foi possível localizar as informações na base de dados", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error); 
                }
            }
            else
            {
                MessageBox.Show("Informe todos os campos!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning); 
            }
        }
    }
}
