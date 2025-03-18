using api_filmes_senai.Context;
using Event_.Domains;
using EventPLUS.Repositorys;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing.Constraints;

namespace EventPLUS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Produces("application/json")]
    public class TipoEventoController : ControllerBase
    {

        private readonly EventoContext _tipoEventoRepository;
        public TipoEventoController(EventoContext tipoEventoRepository)
        {
            _tipoEventoRepository = tipoEventoRepository;
        }

        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                return Ok(_tipoEventoRepository.Eventos.ToList());
            }
            catch (Exception e)
            {

                return BadRequest(e.Message);
            }
        }


        [HttpPost("Cadastrar")]

        public IActionResult Post(TipoEvento tipoEvento)
        {

            try
            {
                _tipoEventoRepository.TipoEventos.Add(tipoEvento);
                _tipoEventoRepository.SaveChanges();
                return Ok(tipoEvento);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }

        }

        [HttpGet("BuscarPorId/{id}")]

        public IActionResult GetById(Guid id)
        {
            try
            {
                TipoEvento tipoEvento = _tipoEventoRepository.TipoEventos.Find(id)!;
                if (tipoEvento == null)
                {
                    return NotFound();
                }
                return Ok(tipoEvento);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpDelete("Deletar/{id}")]
        public IActionResult Delete(Guid id)
        {
            try
            {
                TipoEvento tipoEvento = _tipoEventoRepository.TipoEventos.Find(id)!;
                if (tipoEvento == null)
                {
                    return NotFound();
                }
                _tipoEventoRepository.TipoEventos.Remove(tipoEvento);
                _tipoEventoRepository.SaveChanges();
                return Ok(tipoEvento);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        //[HttpPut("{id}")]
        //public IActionResult Put(Guid id, TipoEvento tipoEvento)
        //{
        //    try
        //    {
        //        if (tipoEvento == null || id != tipoEvento.IdEvento)
        //            return BadRequest("Os dados fornecidos são inválidos.");

        //        var eventoExistente = _tipoEventoRepository.Buscar(id);
        //        if (eventoExistente == null)
        //            return NotFound("Evento não encontrado.");

        //        _tipoEventoRepository.Atualizar(id, tipoEvento);

        //        return NoContent();
        //    }
        //    catch (Exception ex)
        //    {
        //        return StatusCode(500, $"Erro interno: {ex.Message}");
        //    }
        //}

    }
}