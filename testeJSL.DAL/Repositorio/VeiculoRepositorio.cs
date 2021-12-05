using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using testeJSL.BLL.Models;
using testeJSL.DAL.Interfaces;

namespace testeJSL.DAL.Repositorio
{
    public class VeiculoRepositorio : RepositorioGenerico<Veiculo>, IVeiculoRepositorio
    {
        private readonly Contexto _contexto;
        private readonly UserManager<Veiculo> _veiculo;

        public VeiculoRepositorio(Contexto contexto, UserManager<Veiculo> veiculo) : base(contexto)
        {
            _contexto = contexto;
            _veiculo = veiculo;
        }

        public async Task<IdentityResult> CriarVeiculo(Veiculo veiculo)
        {
            try
            {
                return await _veiculo.CreateAsync(veiculo);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

    }
}
