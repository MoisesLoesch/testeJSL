using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;
using testeJSL.BLL.Models;

namespace testeJSL.DAL.Interfaces
{
    public interface IEnderecoRepositorio : IRepositorioGenerico<Endereco>
    {
        Task<IdentityResult> CriarEndereco(Endereco endereco);
    }
}
