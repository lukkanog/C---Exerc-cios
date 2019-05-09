using EscolaDeRock.Interfaces;

namespace EscolaDeRock.Models
{
    public class Baixo : InstrumentoMusical, IPercussao, IHarmonia
    {
        public bool ManterRitmo()
        {
            System.Console.WriteLine($"Mantendo um ritmo como um(a) {this.GetType().Name}");
            return true;
        }

        public bool TocarAcordes()
        {
            System.Console.WriteLine($"Mantendo acordes como um(a) {this.GetType().Name}");
            return true;
        }
    }
}