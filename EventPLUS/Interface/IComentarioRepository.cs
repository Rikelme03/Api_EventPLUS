using Event_.Domains;
using EventPLUS.Domains;

namespace EventPLUS.Interface
{
    public interface IComentario
    {

        void Cadastrar(Comentario novoComentario);

        void Deletar(Guid id);

        List<Comentario> Listar();

        Comentario BuscarPorId(Guid id);

        Comentario BuscarPorIdUsuario(Guid idUsuario, Guid IdEvento);

    }
}
