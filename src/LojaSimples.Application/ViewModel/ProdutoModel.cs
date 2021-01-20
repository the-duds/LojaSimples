using Flunt.Notifications;
using Flunt.Validations;

namespace LojaSimples.Application.ViewModel
{
    /// <summary>
    /// Produto
    /// </summary>
    public class ProdutoModel : Notifiable, IValidatable
    {
        /// <summary>
        /// Nome
        /// </summary>
        public string Nome { get; set; }

        /// <summary>
        /// Categoria
        /// </summary>
        public string Categoria { get; set; }

        /// <summary>
        /// Valor
        /// </summary>
        public decimal Valor { get; set; }


        public void Validate()
        {
            AddNotifications(new Contract()
                .Requires().IsNotNullOrEmpty(Nome, nameof(Nome), "Nome não pode ser vazio")
                .Requires().IsNotNullOrEmpty(Categoria, nameof(Categoria), "Categoria não pode ser vazio")
                .Requires().IsNotNull(Valor, nameof(Valor), "Valor não pode ser vazio")

            );
        }
    }
}
