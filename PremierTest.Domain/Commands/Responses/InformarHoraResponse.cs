using PremierTest.Domain.Entities;

namespace PremierTest.Domain.Commands.Responses
{
    public class InformarHoraResponse
    {
        public int Id { get; set; }
        public string Status { get; set; }
        public HoraTrabalhada HoraTrabalhada { get; set; }
    }
}
