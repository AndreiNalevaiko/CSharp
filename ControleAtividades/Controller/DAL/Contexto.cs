﻿using Modelos;
using System;
using System.Data.Entity;

namespace Controller.DAL
{
    class Contexto : DbContext
    {
        public Contexto() : base("strConn")
        {

        }

        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Atividade> Atividades { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
    }
}
