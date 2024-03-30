﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Usuario
    {
        private int codigo;

        [DisplayName("Código")]
        public int Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }

        private string usuarioLogin;

        [DisplayName("Usuario")]
        public string UsuarioLogin
        {
            get { return usuarioLogin; }
            set { usuarioLogin = value; }
        }

        private string correo;

        [DisplayName("Correo")]
        public string Correo
        {
            get { return correo; }
            set { correo = value; }
        }

        private string contraseña;

        [DisplayName("Contraseña")]
        public string Contraseña
        {
            get { return contraseña; }
            set { contraseña = value; }
        }
    }
}
