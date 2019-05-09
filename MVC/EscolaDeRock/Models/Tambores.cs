using EscolaDeRock.Interfaces;

namespace EscolaDeRock.Models
{
    public class Tambores : InstrumentoMusical, IPercussao
    {
        public bool ManterRitmo()
        {
            System.Console.WriteLine($"Mantendo ritmo como um(a) {this.GetType().Name}");
            return true;
        }
    }
}