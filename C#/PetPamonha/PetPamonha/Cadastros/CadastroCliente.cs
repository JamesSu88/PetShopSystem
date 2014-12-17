﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PetPamonha
{
    public partial class CadastroCliente : Form
    {
        public CadastroCliente()
        {
            InitializeComponent();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {

            String nome;
            String cpf;
            String email;
            String telefone;


            nome = txtNome.Text;
            cpf = mktCPF.Text;
            email = txtEmail.Text;
            telefone = mktTelefone.Text;

            Cliente cliente = new Cliente();

            cliente.Nome = nome;
            cliente.CPF = cpf;
            cliente.Email = email;
            cliente.Telefone = telefone;
           
            
            DAOCliente Daocliente = new DAOCliente();

            Daocliente.clientes.Add(cliente); // pode-se criar um método na DAOCliente para armazenar o cliente na arrayList. Serve para o projeto final de "Padrões de Projeto";

            Daocliente.insereCliente(nome, cpf, email, telefone);

            




        }
    }
}
