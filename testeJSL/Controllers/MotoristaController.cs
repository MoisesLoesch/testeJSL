using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using testeJSL.BLL.Models;
using testeJSL.DAL.Interfaces;
using testeJSL.ViewModels;

namespace testeJSL.Controllers
{
    public class MotoristaController : Controller
    {
        private readonly IMotoristaRepositorio _motoristaRepositorio;
        private readonly IVeiculoRepositorio _veiculoRepositorio;
        private readonly IEnderecoRepositorio _enderecoRepositorio;


        public MotoristaController(IMotoristaRepositorio motoristaRepositorio, IVeiculoRepositorio veiculoRepositorio, IEnderecoRepositorio enderecoRepositorio)
        {
            _motoristaRepositorio = motoristaRepositorio;
            _veiculoRepositorio = veiculoRepositorio;
            _enderecoRepositorio = enderecoRepositorio;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Registro()
        {
            return View();
        }


        [ValidateAntiForgeryToken]
        [HttpPost]
        public async Task<IActionResult> Registro(RegistroViewModel model)
        {
            if (ModelState.IsValid)
            {
                Motorista motorista = new Motorista();
                Veiculo veiculo = new Veiculo();
                Endereco endereco = new Endereco();

                IdentityResult motoristaCriado;
                IdentityResult veiculoCriado;
                IdentityResult enderecoCriado;

                motorista.primeiroNome = model.primeiroNome;
                motorista.segundoNome = model.segundoNome;
                veiculo.marca = model.marca;
                veiculo.modelo = model.modelo;
                veiculo.placa = model.placa;
                veiculo.eixos = model.eixos;
                endereco.nomeEndereco = model.nomeEndereco;
                endereco.bairro = model.bairro;
                endereco.cidade = model.cidade;
                endereco.cep = model.cep;
                endereco.numero = model.numero;
                endereco.complemento = model.complemento;


                try
                {
                    motoristaCriado = await _motoristaRepositorio.CriarMotorista(motorista);
                    veiculoCriado = await _veiculoRepositorio.CriarVeiculo(veiculo);
                    enderecoCriado = await _enderecoRepositorio.CriarEndereco(endereco);

                    if (motoristaCriado.Succeeded)
                    {
                        return RedirectToAction("Index", "Motorista");
                    }

                }
                catch (Exception ex)
                {

                    throw ex;
                }                

            }


            return View(model);
        } 
    }
}
