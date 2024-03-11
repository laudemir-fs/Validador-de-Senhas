namespace Validador.Models
{
    public class SenhaRetorno
    {
         public bool SenhaValida { get; set; }
         public string[]? Erros { get; set; }
    }
}