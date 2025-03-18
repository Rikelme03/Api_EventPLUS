using Event_.Domains;

namespace EventPLUS.Interface
{
    public interface IPresencaEventos 
    {


        void PresencaEventos(PresencaEventos novoPresencaEvento);

        List<PresencaEventos> Listar();

        PresencaEventos BuscarPorId(Guid id);

        void Deletar(Guid id);

        void Atualizar(Guid id, PresencaEventos presencaEvento);

        List<PresencaEventos> ListarMinhasPresencas(Guid id);

        void Inscrever(Guid id, PresencaEventos presencaEvento);

    }
}
