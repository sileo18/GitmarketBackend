using MusicsAPI.Domains;

namespace MusicsAPI.Interfaces
{
    interface IUsuarioRepositorio
    {
        /// <summary>
        /// Lista os usuarios
        /// </summary>
        /// <returns>Uma lista de usuarios</returns>
        List<Usuario> Listar();


        /// <summary>
        /// Buscar um usuario através do id
        /// </summary>
        /// <param name="id">Id do usuario buscado</param>
        /// <returns>Um objeto com os dados do usuario</returns>
        Usuario BuscarPorId(int id);

        /// <summary>
        /// Cadastra um usuario
        /// </summary>
        /// <param name="usuario">Dados do usuario a ser cadastrado</param>
        void Cadastrar(Usuario usuario);

        /// <summary>
        /// Atualiza um usuario
        /// </summary>
        /// <param name="id">Id do usuario a ser atualizado</param>
        /// <param name="novoUsuario">Objeto com dados atualizados do usuario</param>
        void Atualizar(int id ,Usuario novoUsuario);

        /// <summary>
        /// Deleta um usuario
        /// </summary>
        /// <param name="id">Id do usuario a ser deletado</param>
        void Deletar(int id);
    }
}
