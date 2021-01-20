namespace LojaSimples.Application.Interfaces.Boundaries
{
    public interface IOutputPortNotFound
    {
        /// <summary>
        /// Informa que o recurso procurado não foi encontrado.
        /// </summary>
        /// <param name="message">Descrição do erro.</param>
        void NotFound(string message);
    }
}
