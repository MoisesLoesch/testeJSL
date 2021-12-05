using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using testeJSL.BLL.Models;
using testeJSL.DAL.Interfaces;

namespace testeJSL.DAL.Repositorio
{
    public class MotoristaRepositorio : RepositorioGenerico<Motorista>, IMotoristaRepositorio
    {
        private readonly Contexto _contexto;
        private readonly UserManager<Motorista> _motorista;

        public MotoristaRepositorio(Contexto contexto, UserManager<Motorista> motorista) : base(contexto)
        {
            _contexto = contexto;
            _motorista = motorista;
        }

        public async Task<IdentityResult> CriarMotorista(Motorista motorista)
        {
            try
            {
                return await _motorista.CreateAsync(motorista);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

    }
}
