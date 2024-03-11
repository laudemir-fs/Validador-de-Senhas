Esta solução foi desenvolvida com o intuito de validar a força de uma senha digitada pelo usuário, de acordo com algumas premissas basicas para uma senha forte. A solução conta com um projeto de WEB API .NET, mais detalhes serão descritos nas instruções de execução da aplicação.

Requisitos para a execução da aplicação
Framework .NET Core 6 ou superior
Visual Studio Code
As versões de ambiente são de suma importancia para que não ocorram erros na execução!

(Não foram utilizados pacotes NuGet nesta solução e nem conexões de banco de dados)

Instruções para a execução da aplicação
Executa aplicação da API e a interface do Swagger para testar as requisições e respostas diretamente no formato JSON.

A ideia inicial era justamente criar uma API que fosse bem organizada, de facil manutenção e fácil de se implementar novas funcionalidades, por este motivo, decidi separar a aplicação em camadas e metodos, uma camada para logica de negocio (Service), uma para os repositorios e interfaces (as quais implementam metodos genéricos para suas funcionalidades).

Nota: A API só retornará status 400 (Bad Request) quando o input obrigatório não for preenchido.

Documentação da API
  POST /api/Validador/
Parâmetro	Tipo	Descrição
senha	string	Obrigatório. Senha a ser validada pela API.
Retorna um item
Chave	Tipo	Descrição
senhaValida	boolean	Indica se a senha é valida ou não após passar pela API.
erros	string[]	Lista um array de string com os critérios que reprovaram a senha.
