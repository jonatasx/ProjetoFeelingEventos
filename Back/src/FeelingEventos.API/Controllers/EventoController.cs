using FeelingEventos.API.Models;
using Microsoft.AspNetCore.Mvc;

namespace FeelingEventos.API.Controllers
{
[ApiController]
[Route("api/[controller]")]
public class EventoController : ControllerBase
{
  public IEnumerable<Evento> _evento = new Evento[] {
         new Evento(){
         EventoId = 1,
         Tema = "Campeonato de CS 2",
         Local = "Brasília",
         Lote =  "1º Lote",
         QtdPessoas = 250,
         DataEvento = DateTime.Now.AddDays(2).ToString("dd/MM/yyyy"),
         ImagemURL = "foto.png"
         },

          
         new Evento(){
         EventoId = 2,
         Tema = "Campeonato de Street Fighter 6",
         Local = "Brasília",
         Lote =  "2º Lote",
         QtdPessoas = 150,
         DataEvento = DateTime.Now.AddDays(4).ToString("dd/MM/yyyy"),
         ImagemURL = "foto2.png"
         }

       };

    

    public EventoController()
    {
        
    }

    [HttpGet]
    public IEnumerable<Evento> Get()
    {
      return _evento;
    }
    
    [HttpGet("{id}")]
    public IEnumerable<Evento> GetById(int id)
    {
      return _evento.Where(evento => evento.EventoId ==id);
    }


    [HttpPost(Name = "PostEvento")]
    public string Post()
    {
       return "Exemplo de Post";
    }

     [HttpPut("{id}")]
    public string Put(int id)
    {
       return $"Exemplo de Put com id = {id}";
    }

     [HttpDelete( "{id}")]
    public string Delete(int id)
    {
       return $"Exemplo de Delete com id = {id}";
    }
}




}

