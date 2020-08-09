﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteWsReceita
{
    public class Teste
    {
        // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse); 
        public class AtividadePrincipal
        {
            [JsonProperty("text")]
            public string Text { get; set; }

            [JsonProperty("code")]
            public string Code { get; set; }
        }

        public class AtividadesSecundaria
        {
            [JsonProperty("text")]
            public string Text { get; set; }

            [JsonProperty("code")]
            public string Code { get; set; }
        }

        public class Qsa
        {
            [JsonProperty("qual")]
            public string Qual { get; set; }

            [JsonProperty("nome")]
            public string Nome { get; set; }
        }

        public class Extra
        {
        }

        public class Billing
        {
            [JsonProperty("free")]
            public bool Free { get; set; }

            [JsonProperty("database")]
            public bool Database { get; set; }
        }

        public class Root
        {
            [JsonProperty("atividade_principal")]
            public List<AtividadePrincipal> AtividadePrincipal { get; set; }

            [JsonProperty("data_situacao")]
            public string DataSituacao { get; set; }

            [JsonProperty("complemento")]
            public string Complemento { get; set; }

            [JsonProperty("tipo")]
            public string Tipo { get; set; }

            [JsonProperty("nome")]
            public string Nome { get; set; }

            [JsonProperty("telefone")]
            public string Telefone { get; set; }

            [JsonProperty("email")]
            public string Email { get; set; }

            [JsonProperty("atividades_secundarias")]
            public List<AtividadesSecundaria> AtividadesSecundarias { get; set; }

            [JsonProperty("qsa")]
            public List<Qsa> Qsa { get; set; }

            [JsonProperty("situacao")]
            public string Situacao { get; set; }

            [JsonProperty("bairro")]
            public string Bairro { get; set; }

            [JsonProperty("logradouro")]
            public string Logradouro { get; set; }

            [JsonProperty("numero")]
            public string Numero { get; set; }

            [JsonProperty("cep")]
            public string Cep { get; set; }

            [JsonProperty("municipio")]
            public string Municipio { get; set; }

            [JsonProperty("porte")]
            public string Porte { get; set; }

            [JsonProperty("abertura")]
            public string Abertura { get; set; }

            [JsonProperty("natureza_juridica")]
            public string NaturezaJuridica { get; set; }

            [JsonProperty("uf")]
            public string Uf { get; set; }

            [JsonProperty("cnpj")]
            public string Cnpj { get; set; }

            [JsonProperty("ultima_atualizacao")]
            public DateTime UltimaAtualizacao { get; set; }

            [JsonProperty("status")]
            public string Status { get; set; }

            [JsonProperty("fantasia")]
            public string Fantasia { get; set; }

            [JsonProperty("efr")]
            public string Efr { get; set; }

            [JsonProperty("motivo_situacao")]
            public string MotivoSituacao { get; set; }

            [JsonProperty("situacao_especial")]
            public string SituacaoEspecial { get; set; }

            [JsonProperty("data_situacao_especial")]
            public string DataSituacaoEspecial { get; set; }

            [JsonProperty("capital_social")]
            public string CapitalSocial { get; set; }

            [JsonProperty("extra")]
            public Extra Extra { get; set; }

            [JsonProperty("billing")]
            public Billing Billing { get; set; }
        }


    }
}
