using System;

namespace Cadastro_Tsushi_Mvc.Utils
{
    public static class ValidacaoUtil
    {
        /// <summary>retorna true se o email tiver @ e . e false se n</summary>
        public static bool ValidarEmail(string email)
        {
            if (email.Contains("@") && email.Contains("."))
            {
                return true;
            }
            return false;   
        }//end ValidarEmail()

        public static bool ConfirmacaoSenha (string senha, string confirmaSenha)
        {
            if (senha.Length >= 6 && confirmaSenha.Equals(senha))
            {
                return true;
            }
            return false;
        }//end ValidarSenha()
    }
}