using System.Collections.Generic;

namespace Reciclagem.Models
{
    public class Lixos
    {
        //DICIONARIOS SERVEM PRA PROCURAR E TALZ
        //ELE ACHA A CHAVE E RETORNA O VALOR {CHAVE, VALOR}
        public static Dictionary<int, BaseViewModel> lixosDicionario = new Dictionary<int, BaseViewModel>()
        {
            {1, new LataDeRefri()},
            {2, new Garrafa()},
            {3, new CopoDescartavel()},
            {4, new CascaDeBanana()},
            {5, new PilhaUsada()},
            {6, new PapelSulfite()}
        };
    }
}