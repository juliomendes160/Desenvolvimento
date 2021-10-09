﻿using _Serie.Interfaces;
using _Serie.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace _Serie.Repositorio
{
    public class SerieRepositorio : Interface<Serie>
    {
        private List<Serie> lista = new List<Serie>();

        public void Atualizar(int id, Serie entidade)
        {
            throw new NotImplementedException();
        }

        public void Excluir(int id)
        {
            throw new NotImplementedException();
        }

        public int GerarId()
        {
            return lista.Count();
        }

        public List<Serie> Listar()
        {
            return lista;
        }

        public Task PegarId(int id)
        {
            throw new NotImplementedException();
        }

        public void Salvar(Serie entidade)
        {
            entidade.Id = GerarId();

            lista.Add(entidade);
        }

        public void Escrever(Serie entidade)
        {
            Directory.CreateDirectory(Path.Combine(Directory.GetCurrentDirectory(), "Dados"));

            File.AppendAllText(
                Path.Combine(Directory.GetCurrentDirectory(), "Dados", "Serie.txt"), 
                $"{DateTime.Now}#{entidade.Id}#{entidade.Genero}#{entidade.Titulo}{Environment.NewLine}"
            );
        }
    }
}
