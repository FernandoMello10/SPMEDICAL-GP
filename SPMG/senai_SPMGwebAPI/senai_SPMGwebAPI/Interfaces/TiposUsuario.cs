using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai_SPMGwebAPI.Interfaces
{
    /// <summary>
    /// Interface responsavel pelo repositorio TiposUsuario
    /// </summary>
    interface TiposUsuario
    {
        //Definição de métodos, seguem a estrutura:
        // tipoRetorno nomeMetodo(tipoParametro nomeparametros);

        /// <summary>
        /// Lista todos os tipos de usuario
        /// </summary>
        /// <returns>Uma lista de tipos usuario</returns>
        List<TiposUsuario> ListarTodos();

        /// <summary>
        /// Busca um tipo de usuario através do seu ID
        /// </summary>
        /// <param name="id">ID tipo de Usuario que será buscado</param>
        /// <returns>Um tipo de usuario encontrado</returns>
        TiposUsuario BuscarPorId(int id);

        /// <summary>
        /// Cadastra um tipo usuario
        /// </summary>
        /// <param name="tiposUsuario">Objeto novo TipoUsuario que será cadastrado</param>
        void Cadastrar(TiposUsuario tiposUsuario);

        /// <summary>
        /// Autaliza um tipo de usuario existente 
        /// </summary>
        /// <param name="id">ID do tipo de usuario que será atualizada</param>
        /// <param name="tiposUsuarioAtualizado">Objeto TipoUsuarioAtualizado com as novas informações</param>
        void Atualizar(int id, TiposUsuario tiposUsuarioAtualizado);

        /// <summary>
        /// Deletar um tipo de usuario existente 
        /// </summary>
        /// <param name="id">ID de tipo usuario que será deletado </param>
        void Deletar(int id);
    }
}
