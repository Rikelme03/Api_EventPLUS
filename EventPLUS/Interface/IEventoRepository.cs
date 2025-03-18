using Event_.Domains;

namespace EventPLUS.Interface
{
    public interface IEventoRepository 
    {

        void Cadastrar(Evento novoEvento);
        List<Evento> Listar();
        Evento BuscarPorId(Guid id);
        void Deletar(Guid id);

        void Atualizar(Guid id, Evento evento);

        List<Evento> ListarPorId(Guid id);

        List<Evento> BuscarProximosEventos(Guid id, Evento evento);

    }
}
