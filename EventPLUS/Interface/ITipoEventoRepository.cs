using Event_.Domains;

namespace EventPLUS.Interface
{
    public interface ITipoEventoRepository 
    {

        void Cadastrar(TipoEvento novoTipoEvento);

        void Deletar(Guid id);

        List<TipoEvento> Listar();  

        TipoEvento BuscarPorId(Guid id);

        void Atualizar(Guid id, TipoEvento tipoEvento);

    }
}
