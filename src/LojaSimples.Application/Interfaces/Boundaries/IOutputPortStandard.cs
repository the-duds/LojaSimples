namespace LojaSimples.Application.Interfaces.Boundaries
{
    public interface IOutputPortStandard<in TUseCaseOutput>
    {
        /// <summary>
        ///  Registra o retorno normal de uma application.
        /// </summary>
        /// <param name="output">O output da mensagem da application</param>
        void Success(TUseCaseOutput output);
    }
}
