using senai_SPMGwebAPI.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai_SPMGwebAPI.Repositories
{
    /// <summary>
    /// Classe responsável pelo repositório dos tipos de usuario
    /// </summary>
    public class TipoUsuarioRepositary : TiposUsuario
    {

        /// <summary>
        /// Autaliza um tipo de usuario existente 
        /// </summary>
        /// <param name="id">ID do tipo de usuario que será atualizada</param>
        /// <param name="tiposUsuarioAtualizado">Objeto TipoUsuarioAtualizado com as novas informações</param>
        public void Atualizar(int id, TiposUsuario TipoUsuarioAtualizado)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Busca um tipo de usuario através do seu ID
        /// </summary>
        /// <param name="id">ID tipo de Usuario que será buscado</param>
        /// <returns>Um tipo de usuario encontrado</returns>
        public TiposUsuario BuscarPorId(int id )
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Cadastra um tipo usuario
        /// </summary>
        /// <param name="tiposUsuario">Objeto novo TipoUsuario que será cadastrado</param>
        public void Cadastrar(TiposUsuario novoTiposUsuario)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Deletar um tipo de usuario existente 
        /// </summary>
        /// <param name="id">ID de tipo usuario que será deletado </param>
        public void Deletar(int id)
        {
            throw new NotImplementedException();
        }
    }
}
