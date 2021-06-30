using senai.SPMedGroup.webApi.Domains;
using senai_SPMGwebAPI.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai.SPMedGroup.webApi.Interfaces
{
    interface UsuarioRepository
    {
        /// <summary>
        /// Lista todas os Usuario
        /// </summary>
        /// <returns>Uma lista de Usuarios</returns>
        List<UsuarioRepository> Listar();

        /// <summary>
        /// Busca uma situação através do Id
        /// </summary>
        /// <param name="id">Id do usuario que será buscada</param>
        /// <returns>Uma situação encontrada</returns>
        Usuario BuscarPorId(int id);

        /// <summary>
        /// Cadastra um novo Usuario
        /// </summary>
        /// <param name="novaSituacao">Objeto novoUsuario com as informações</param>
        void Cadastrar(Usuario novaSituacao);

        /// <summary>
        /// Atualiza um Usuario existente
        /// </summary>
        /// <param name="id">Id do Usuario que será atualizada</param>
        /// <param name="usuarioAtualizada">Objeto UsuarioAtualizada com as novas informações</param>
        void Atualizar(int id, Usuario usuarioAtualizada);

        /// <summary>
        /// Deleta um usuario existente
        /// </summary>
        /// <param name="id">Id do usuario que será deletada</param>
        void Deletar(int id);
    }
}