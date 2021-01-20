using Flunt.Notifications;
using System.Collections.Generic;

namespace LojaSimples.Application.Interfaces.Boundaries
{
    /// <summary>
    /// Interface output de erro.
    /// </summary>
    public interface IOutputPortError
    {
        /// <summary>
        /// Informa que um erro ocorreu.
        /// </summary>
        /// <param name="message">Descrição do erro.</param>
        void WriteError(string message);

        /// <summary>
        /// Informa notificação de validação de erros.
        /// </summary>
        /// <param name="errors">Erros na validação de dados.</param>
        void WriteError(IReadOnlyCollection<Notification> errors);
    }
}
