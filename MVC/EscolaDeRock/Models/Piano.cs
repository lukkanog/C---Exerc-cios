using EscolaDeRock.Interfaces;

namespace EscolaDeRock.Models
{
    public class Piano : InstrumentoMusical, IMelodia, IHarmonia
    {
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