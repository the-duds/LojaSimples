using Flunt.Notifications;
using Flunt.Validations;
using System.Collections.Generic;

namespace LojaSimples.Application.ViewModel
{
    /// <summary>
    /// Pedido
    /// </summary>
    public class PedidoModel : Notifiable, IValidatable
    {
        /// <summary>
        /// Cpf
        /// </summary>
        public string Cpf { get; set; }

        /// <summary>
        /// Valot
        /// </summary>
        public decimal ValorTotal { get; set; }

        /// <summary>
        /// Lista de Itens
        /// </summary>
        public List<ItensPedidoModel> ListaItens { get; set; }


        public void Validate()
        {
            AddNotifications(new Contract()
                .Requires().IsNotNullOrEmpty(Cpf, nameof(Cpf), "Cpf não pode ser vazio")
                .Requires().IsNotNull(ValorTotal, nameof(ValorTotal), "Valor Total não pode ser vazio")
                .Requires().IsNotNull(ListaItens, nameof(ListaItens), "Lista de Itens não pode ser vazio")

            );
        }
    }
}
