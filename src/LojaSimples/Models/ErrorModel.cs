using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LojaSimples.Models
{
    public class ErrorModel
    {
        /// <summary>
        /// Erros das notificações.
        /// </summary>
        public List<string> Erros { get; } = new List<string>();

        /// <summary>
        /// Construtor
        /// </summary>
        /// <param name="erro">Nome do erro.</param>
        public ErrorModel(string erro)
        {
            Erros.Add(erro);
        }

        /// <summary>
        /// Define lista de erros.
        /// </summary>
        /// <param name="erros">Lista de todos erros.</param>
        public ErrorModel(IEnumerable<string> erros)
        {
            Erros.AddRange(erros);
        }

        /// <summary>
        /// Passa notificações dos erros.
        /// </summary>
        /// <param name="notifications">Notificações</param>
        public ErrorModel(IReadOnlyCollection<Flunt.Notifications.Notification> notifications)
        {
            foreach (var notification in notifications)
            {
                Erros.Add(notification.Message);
            }
        }
    }
}
