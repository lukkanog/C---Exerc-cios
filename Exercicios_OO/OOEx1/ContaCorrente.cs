namespace OOEx1
{
    public class ContaCorrente
    {
        public string titular;//atributo
        public int agencia;//atributo
        public int numeroConta;//atributo
        public double saldo{get;private set;}//atributo
        
        public void Depositar(double valor)
        {
            saldo+=valor;
        }
        public bool Sacar(double valor)
        {
            if(saldo <valor)
            {
                return false;
            }else
            {
                saldo -= valor;
                return true;
            }
        }
        public bool Transferir(double valor,ContaCorrente contaDestino)
        {
            if(valor > saldo)
            {
                return false;
            }else
            {
                saldo-=valor;
                contaDestino.saldo+=valor;
                return true;
            }

            
        }


    }
}