using EscolaDeRock.Interfaces;

namespace EscolaDeRock.Models
{
    public class Violao : InstrumentoMusical, IPercussao, IMelodia, IHarmonia
    {
        public bool ManterRitmo()
        {
            System.Console.WriteLine($"Mantendo ritmo como um(a) {this.GetType().Name}");
            return true;;
        }

        public bool TocarAcordes()
        {
            System.Console.WriteLine($"Mantendo acordes como um(a) {this.GetType().Name}");
            return true;
        }

        public bool TocarSolo()
        {
            System.Console.WriteLine($"Tocando solo como um(a) {this.GetType().Name}");
            return true;
        }
    }
}