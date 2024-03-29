﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio03
{
    class Livro : Produto
    {
        public Livro(string titulo, double preco, string autor) : base(titulo, preco)
        {
            Autor = autor;
        }

        public string Autor { get; private set; }

        public override void InformarDescrição()
        {
            Console.WriteLine($"{Titulo} escrito por {Autor}");
        }
    }
}
