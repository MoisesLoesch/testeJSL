using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using testeJSL.BLL.Models;
using testeJSL.DAL.Interfaces;

namespace testeJSL.DAL.Repositorio
{
    public class EnderecpRepositorio : RepositorioGenerico<Endereco>, IEnderecoRepositorio
    {
        private readonly Contexto _contexto;
        private readonly UserManager<Endereco> _endereco;

        public EnderecpRepositorio(Contexto contexto, UserManager<Endereco> endereco) : base(contexto)
        {
            _contexto = contexto;
            _endereco = endereco;
        }

        public async Task<IdentityResult> CriarEndereco(Endereco endereco)
        {
            try
            {
                return await _endereco.CreateAsync(endereco);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

    }
}
