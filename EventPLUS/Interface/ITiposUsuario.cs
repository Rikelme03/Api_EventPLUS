using Event_.Domains;

namespace EventPLUS.Interface
{
    public interface ITiposUsuario 
    {
        void Cadastrar(TiposUsuarios novoTipoUsuario);
        void Deletar(Guid id);
        TiposUsuarios BuscarPorId(Guid id);
        List<TiposUsuarios> Listar();

        void Atualizar(Guid id, TiposUsuarios tiposUsuarios);

    }
}
