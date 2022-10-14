using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProEventos.api.Models;

namespace ProVentos.api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventoController : ControllerBase
    {
        
        public IEnumerable <Evento> _evento =  new Evento[]{
                new Evento(){
                    EventoId = 1,
                    Tema = "Angular e .NET 5",
                    Local = "Belo Horizonte",
                    QtdPessoa = 250,
                    Lote = "1º Lote",
                    DataEvento = DateTime.Now.AddDays(2).ToString("dd/MM/yyyy"),
                    ImagemURL = "foto.png"
                    },
                new Evento(){
                    EventoId = 2,
                    Tema = "Angular e .NET 5",
                    Local = "São Paulo",
                    QtdPessoa = 350,
                    Lote = "2º Lote",
                    DataEvento = DateTime.Now.AddDays(2).ToString("dd/MM/yyyy"),
                    ImagemURL = "foto2.png"
                    }
        };

        private readonly ILogger<EventoController> _logger;


        public EventoController()
        {
            
        }

        [HttpGet]
        public IEnumerable <Evento> Get()
        {
            return  _evento;        
        }

        
        [HttpGet("{id}")]
        public IEnumerable <Evento> GetById(int id)
        {
            return  _evento.Where(evento => evento.EventoId == id);        
        }
    }
}
