using System;
using System.Collections.Generic;
using CadastroMVC.Models;

namespace CadastroMVC.Controllers
{
    public class UsuarioController
    {
        

        List<UsuarioModel> listaUsuarios = new List<UsuarioModel>();

        public void CadastrarUsuario(){

            System.Console.WriteLine("Informe o nome do usuario");
            string nome = Console.ReadLine();

            System.Console.WriteLine("Informe o email do usuario");
            string email = Console.ReadLine();

            System.Console.WriteLine("Informe a senha do usuario");
            string senha = Console.ReadLine();

            UsuarioModel usuario = new UsuarioModel();

            usuario.Id += 1;
            usuario.Nome = nome;
            usuario.Email = email;
            usuario.DataCriacao = DateTime.Now;

            listaUsuarios.Add(usuario);
        }

        public void ListarUsuarios(){

            foreach(var item in listaUsuarios){
                Console.WriteLine("_________________");
                Console.WriteLine($"Usuario: {item.Nome}");
                Console.WriteLine($"Id: {item.Id}");
                Console.WriteLine($"E-mail: {item.Email}");
                Console.WriteLine($"Data de Cadastro: {item.DataCriacao}");

            }
        }

        public bool Autenticando(){
            System.Console.WriteLine("Insira o e-mail:");
            string email = Console.ReadLine();

            System.Console.WriteLine("Insira sua senha:");
            string senha = Console.ReadLine();

            foreach(var item in listaUsuarios){

                if(item.Email == email && item.Senha == senha){
                    // Console.WriteLine("Usuário localizado");
                    // break;
                    return true;
                }
            }

            return false;
        }


    }
}