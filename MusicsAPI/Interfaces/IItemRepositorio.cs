using MusicsAPI.Domains;

namespace MusicsAPI.Interfaces
{
    interface IItemRepositorio
    {
        /// <summary>
        /// Lista todos os items de uma lista
        /// </summary>
        /// <returns>Lista de items</returns>
        /// <param name="ListaId">Id da lista na qual será buscado os itens</param>
        List<Item> Listar(int ListaId);


        // <summary>
        /// Cadastra um novo item
        /// </summary>
        /// <param name="id">ID da lista aonde o item será  cadastrado</param>
        /// <param name="item">Objeto novoItem que será cadastrado </param>
        void Cadastrar(int id, Item novoItem);

        /// <summary>
        /// Deletar um item
        /// </summary>
        /// <param name="id">Id do item que será deletado</param>
        void Deletar(int id);

    }
}
