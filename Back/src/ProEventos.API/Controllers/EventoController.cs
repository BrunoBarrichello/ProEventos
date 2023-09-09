using Microsoft.AspNetCore.Mvc;
using ProEventos.API.Models;

namespace ProEventos.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class EventoController : ControllerBase
{
    private readonly ILogger<EventoController> _logger;
    public IEnumerable<Evento> _evento = new Evento[] {
            
            new Evento() {
                EventoId = 1,
                Tema = "Angular e .NET Core",
                Local = "Piracicaba",
                Lote = "1º Lote",
                QtdPessoas = 250,
                DataEvento = DateTime.Now.AddDays(2).ToString(),
                ImagemURL = "testeimage.com",
            },
            new Evento() {
                EventoId = 2,
                Tema = "Angular e .NET Core 2",
                Local = "Piracicaba 2",
                Lote = "2º Lote",
                QtdPessoas = 450,
                DataEvento = DateTime.Now.AddDays(4).ToString(),
                ImagemURL = "testeimage_2.com",
            }

        };
    private static readonly string[] Summaries = new[]
    {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
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
        return _evento.Where(evento => evento.EventoId == id);
    }
}
