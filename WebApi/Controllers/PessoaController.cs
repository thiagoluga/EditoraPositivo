using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Arguments.Pessoa;
using Domain.Interfaces.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PessoaController : ControllerBase
    {
        private readonly IPessoaService _pessoaService;

        public PessoaController(IPessoaService pessoaService)
        {
            _pessoaService = pessoaService;
        }

        [HttpGet]
        public bool Get()
        {
            return true;
        }

        [HttpPost]
        public CriarPessoaResponse Post(CriarPessoaRequest criarPessoaRequest)
        {
            var response = _pessoaService.CriarPessoa(criarPessoaRequest);
            return response;
        }
    }
}