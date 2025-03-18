using api_filmes_senai.Context;
using Event_.Domains;
using EventPLUS.Interface;
using Microsoft.EntityFrameworkCore;

namespace EventPLUS.Repositorys
{
    public class TipoEventoRepository : ITipoEventoRepository
    {

        private readonly EventoContext _context;
        public TipoEventoRepository(EventoContext context)
        {
            _context = context;
        }

        public void Atualizar(Guid id, TipoEvento tipoEvento)
        {

            try
            {
                TipoEvento tipoBuscados = _context.TipoEventos.Find(id)!;

                if (tipoBuscados != null)
                {
                    tipoBuscados.TituloTipoEvento = tipoEvento.TituloTipoEvento;
                    
                }

                _context.SaveChanges();

            }

            catch (Exception)
            {

                throw;
            }
        }
        

        public TipoEvento BuscarPorId(Guid id)
        {
            try
            {
                TipoEvento tipoEvento = _context.TipoEventos.Find(id)!;
                
                return tipoEvento;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Cadastrar(TipoEvento novoTipoEvento)
        {
            try
            {
                _context.TipoEventos.Add(novoTipoEvento);

                _context.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Deletar(Guid id)
        {
            try
            {
                TipoEvento eventoBuscado = _context.TipoEventos.Find(id)!;

                if (eventoBuscado != null)
                {
                    _context.Remove(eventoBuscado);
                }

                _context.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<TipoEvento> Listar()
        {
            try
            {
                List<TipoEvento> listaDeTipos = _context.TipoEventos.Include(g => g.TituloTipoEvento).ToList();

                return listaDeTipos;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
