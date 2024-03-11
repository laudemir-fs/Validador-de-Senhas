namespace Validador.Interface
{
    public interface ISenhaRepository
    {
        public List<string> VerificarTamanhoDaSenha(string senha);
        public List<string> VerificarMaiusculasEminusculas(string senha);
        public List<string> VerificarCaracteresEspeciais(string senha);
        public List<string> VerificarRepetidosEespacoEmBranco(string senha);

    }
}