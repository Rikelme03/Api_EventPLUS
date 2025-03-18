using Event_.Domains;

namespace EventPLUS.Interface
{
    public interface IUsuarioRepository
    {

        void Cadastrar(Usuarios novoUsuario);

        Usuarios BuscarPorId(Guid id);

        Usuarios BuscarPorEmailSenha(string email, string senha);
    }
}
