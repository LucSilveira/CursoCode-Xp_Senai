using System;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using Gufus.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;

namespace Gufus.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Produces("application/json")]
    public class LoginController : ControllerBase
    {

        //Instanciamos o nosso contexto do banco de dados
        GufosContext _context = new GufosContext();

        // Definimos uma variavel que recorre as configuracao do sistema e valida os codigos
        private IConfiguration _config;

        // Metodo para que as informacoes sejam validadas atraves do appSettings.js
        public LoginController( IConfiguration config){

            _config = config;
        }

        [AllowAnonymous]
        [HttpPost]
        public IActionResult Login(Usuario logado){

            // Cria uma variavel do tipo IActionResult definindo que apriori nao é autorizado
            IActionResult resp = Unauthorized();

            // verifica se o usuario informado existe no banco de dados
            var usuario = autenticarUsuario(logado);

            // Verifica se o usuario nao é nullo
            if(usuario != null){

                // Criando uma variavel que armazenara o token
                var tokenString = gerarJsonWebToken(usuario);

                // Defini que a resposta é valida (200 Ok) e retorna o token
                resp = Ok(new { token = tokenString });
            }

            return resp;
        }

        /// <summary>
        /// Metodo privado que valida se um usuario exixte no banco
        /// </summary>
        /// <param name="logado">Obj do tipo UsuarioModel</param>
        /// <returns>Obj do tipo UsuarioModel</returns>
        private Usuario autenticarUsuario(Usuario logado){

            //Declara uma variavel que busca no nosso banco um usuario que tenha o email e senha cadastrados
            var usuario = _context.Usuario.Include(tp => tp.TipoUsuario).FirstOrDefault(usr => usr.Email == logado.Email && usr.Senha == logado.Senha);

         

            return usuario;
        }


        private string gerarJsonWebToken(Usuario infoUsuario){

            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config["Jwt:Key"]));

            var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);

            // Definindo nossa cliams que sao os dados da nossa seção
            var claims = new[]{

                new Claim(JwtRegisteredClaimNames.NameId, infoUsuario.Nome),
                new Claim(JwtRegisteredClaimNames.Email, infoUsuario.Email),
                new Claim(ClaimTypes.Role, infoUsuario.TipoUsuario.Titulo),
                new Claim("Role", infoUsuario.TipoUsuario.Titulo),
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString())

            };

            var token = new JwtSecurityToken(_config["Jwt:Issuer"],
                _config["Jwt:Issuer"],
                claims,
                expires: DateTime.Now.AddMinutes(120),
                signingCredentials: credentials
            );

            return new JwtSecurityTokenHandler().WriteToken(token);
        }

    }
}