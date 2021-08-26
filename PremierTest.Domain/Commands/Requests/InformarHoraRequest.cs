
namespace PremierTest.Domain.Commands.Requests
{
    public class InformarHoraRequest
    {
        public int FuncionarioId { get; set; }
        public int ProjetoId { get; set; }
        public decimal HorasTrabalhadas { get; set; }
    }
}
