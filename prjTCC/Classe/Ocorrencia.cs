using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace prjTCC.Classe
{
    public class Ocorrencia
    {
        public Agendamento Agendamento { get; set; }
        public TipoOcorrencia TipoOcorrencia { get; set; }
        public bool FuncionarioOcorrencia { get; set; }
        public bool ClienteOcorrencia { get; set; }
        public string Descricao { get; set; }
        public Ocorrencia() { }

      

        public Ocorrencia(Agendamento agendamento, TipoOcorrencia tipoOcorrencia, bool funcionarioOcorrencia, bool clienteOcorrencia, string descricao)
        {
            this.Agendamento = agendamento;
            this.TipoOcorrencia = tipoOcorrencia;
            this.FuncionarioOcorrencia = funcionarioOcorrencia;
            this.ClienteOcorrencia = clienteOcorrencia;
            this.Descricao = descricao;
        }

    }
}