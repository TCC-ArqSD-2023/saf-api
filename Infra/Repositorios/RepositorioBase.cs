﻿using GisaDominio.Entidades;
using GisaDominio.Interfaces.Repositorios;
using Infra.Contextos;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.Repositorios
{
    public class RepositorioBase<T> : IRepositorioBase<T> where T : EntidadeBase
    {
        private readonly SafDbContexto _contexto;
        private DbSet<T> _colecao;

        public RepositorioBase(SafDbContexto contexto)
        {
            _contexto = contexto;
            _colecao = _contexto.Set<T>();
        }

        public IEnumerable<T> ObterTodos()
        {
            return _colecao.AsEnumerable();
        }

        public T? ObterPorId(long id)
        {
            return _colecao.SingleOrDefault(e => e.Id == id);
        }

        public void Inserir(T entidade)
        {
            if (entidade == null)
            {
                throw new ArgumentNullException("entidade");
            }
            _colecao.Add(entidade);
            _contexto.SaveChanges();
        }

        public void Atualizar(T entidade)
        {
            if (entidade == null)
            {
                throw new ArgumentNullException("entidade");
            }
            _colecao.Attach(entidade);
            _contexto.Entry(entidade).State = EntityState.Modified;

            _contexto.SaveChanges();
        }

        public void Remover(long id)
        {
            var entidade = ObterPorId(id);
            if (entidade == null)
            {
                throw new ArgumentNullException("entidade");
            }

            _colecao.Remove(entidade);
            _contexto.SaveChanges();
        }
    }
}
