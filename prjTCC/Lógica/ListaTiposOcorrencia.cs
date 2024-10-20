using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using prjTCC.Classe;
using MySql.Data.MySqlClient;

namespace prjTCC.Lógica
{
    public class ListaTipoOcorrencia : Banco
    {
        public MySqlDataReader ListarTipoOcorrencia()
        {
            try
            {
                Conectar();

                string procedure = "ListarTipoOcorrencia";

                return Consultar(procedure);
            }

            catch (Exception)
            {
                throw new Exception("Erro na listagem dos tipos de ocorrência.");
            }
        }
        public void FecharConexao()
        {
            Desconectar();
        }
    }
}