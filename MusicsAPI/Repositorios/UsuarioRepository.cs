using MusicsAPI.Context;
using MusicsAPI.Domains;
using MusicsAPI.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicsAPI.Repositorios

{
    public class UsuarioRepository : IUsuarioRepositorio
    {
        InLockContext ctx = new InLockContext();

        public void Atualizar(int id, Usuario novoUsuario)
        {
            throw new NotImplementedException();
        }

        public Usuario BuscarPorId(int id)
        {
            throw new NotImplementedException();
        }

        public void Cadastrar(Usuario usuario)
        {
            throw new NotImplementedException();
        }

        public void Deletar(int id)
        {
            throw new NotImplementedException();
        }

        public List<Usuario> Listar()
        {
            throw new NotImplementedException();
        }
    }
}
