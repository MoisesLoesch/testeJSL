using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;
using testeJSL.BLL.Models;

namespace testeJSL.DAL.Interfaces
{
    public interface IMotoristaRepositorio : IRepositorioGenerico<Motorista>
    {
        Task<IdentityResult> CriarMotorista(Motorista motorista);
    }
}
