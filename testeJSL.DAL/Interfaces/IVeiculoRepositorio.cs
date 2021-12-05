using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;
using testeJSL.BLL.Models;

namespace testeJSL.DAL.Interfaces
{
    public interface IVeiculoRepositorio : IRepositorioGenerico<Veiculo>
    {
        Task<IdentityResult> CriarVeiculo(Veiculo veiculo);
    }
}
