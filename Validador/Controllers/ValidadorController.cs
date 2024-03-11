using Microsoft.AspNetCore.Mvc;
using System.ComponentModel;
using Validador.Models;
using Validador.Service;

namespace Validador.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValidadorController : ControllerBase
    {
        [HttpPost]
        public ActionResult<SenhaModel> ValidarSenha([FromBody] [Description("Digite a senha a ser validada:")] SenhaModel senhaModel)
        {
            if (senhaModel == null || string.IsNullOrWhiteSpace(senhaModel.Senha))
            {
                return BadRequest("É necessário preencher uma senha ao fazer uma requisição.");
            }

            ValidadorSenha sevice = new ValidadorSenha();

             SenhaRetorno senhaRetorno = sevice.VerificarParametrosSenhaValida(senhaModel.Senha);

            return Ok(senhaRetorno);
        }

    }

}