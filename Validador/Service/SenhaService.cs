using Validador.Models;
using Validador.Repository;

namespace Validador.Service
{
    public class ValidadorSenha
    {
        public SenhaRetorno VerificarParametrosSenhaValida(string senha)
        {
            var retornoVerificacaoSenha = new SenhaRetorno();

            var repo = new SenhaRepository();

            List<string> errosVerificacaoSenha = new List<string>();

            bool senhaValida = false;

            errosVerificacaoSenha.AddRange(repo.VerificarTamanhoDaSenha(senha));
            errosVerificacaoSenha.AddRange(repo.VerificarMaiusculasEminusculas(senha));
            errosVerificacaoSenha.AddRange(repo.VerificarCaracteresEspeciais(senha));
            errosVerificacaoSenha.AddRange(repo.VerificarRepetidosEespacoEmBranco(senha));

            if (!errosVerificacaoSenha.Any())
            {
                senhaValida = true;

            }

            retornoVerificacaoSenha.SenhaValida = senhaValida;

            retornoVerificacaoSenha.Erros = errosVerificacaoSenha.ToArray();

            return retornoVerificacaoSenha;
        }
    }
}