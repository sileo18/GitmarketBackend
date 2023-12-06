using MusicsAPI.Domains;

namespace MusicsAPI.Interfaces
{
    interface IListaRepositorio
    {
        /// <summary>
        /// Lista todas as listas
        /// </summary>
        /// <returns>Lista de listas</returns>
        List<Listum> Listar();

        /// <summary>
        /// Busca uma lista  através do id
        /// </summary>
        /// <param name="id">Id da lista buscada</param>
        /// <returns>Retorna um objeto listum</returns>
        Listum BuscarPorId(int id); 

        /// <summary>
        /// Cadastra uma lista nova
        /// </summary>
        /// <param name="id">Id do usuário que a lista será  associada</param>
        /// <param name="Lista">Objeto Lista que será  cadastrado/criado</param>
        void Cadastrar(int id, Listum Lista);


        /// <summary>
        /// Atualiza  uma lista
        /// </summary>
        /// <param name="id">Id da lista a  ser atualizada</param>
        /// <param name="Lista">Objeto com informações atualizadas</param>
        void Atualizar(int id, Listum Lista);


        /// <summary>
        /// Deleta uma lista
        /// </summary>
        /// <param name="id">Id da lista que será deletada</param>
        void Deletar(int id);

    }
}
