using Microsoft.AspNetCore.Mvc;

namespace helloworld.Controllers
{
    [Route("~/")] //o ~indica que é a raiz(a índex) da minha aplicação 
    [ApiController]
    public class HelloController
    {
        [HttpGet] //primeiro endPoint
        public string Hello()
        {
            return "Hello Turma .NET 03!";
        }

        [HttpGet("/meunome")]//segundo endPoint
        public string MeuNome()
        {
            return "Ingrid Manfrin";
        }

        [HttpGet("/bsms")]//segundo endPoint
        public string Bsms()
        {
            return "- Mentalidades -" +
            "\nPersistência" +
            "\nMentalidade de Crescimento" +
            "\nResponsabilidade Pessoal" +
            "\nOrientação ao Futuro\n" +
            "\n- Habilidades Comportamentais -" +
            "\nOrientação ao Detalhe" +
            "\nTrabalho em Equipe" +
            "\nComunicação" +
            "\nProatividade";
        }

        [HttpGet("/objetivos")]//segundo endPoint
        public string Objetivos()
        {
            return "- Objetivos de Aprendizagem -" +
            "\nAprender sobre Linq" +
            "\nRevisar sobre MVC" +
            "\nConseguir aplicar os conhecimentos estudados no Blog Pessoal";
        }
    }
}
