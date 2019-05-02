namespace CadastroTarefas.Utils
{
    public class ValidacaoUtil
    {
        public static bool ValidarEmail(string email)
        {
            if (email.Contains("@") && email.Contains("."))
            {
                return true;
            }
            return false; 
        }

        public static bool ValidarSenha (string senha, string confirmaSenha)
        {
            if (senha.Length >= 6 && confirmaSenha.Equals(senha))
            {
                return true;
            }
            return false;
        }//end ValidarSenha()
    }
}