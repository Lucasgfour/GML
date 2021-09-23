using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Reflection;
using MySql.Data.MySqlClient;

namespace GM.Model
{
    public class Comando {
        private Conexao con;
        private MySqlCommand comando;
        private String banco = "";

        public Comando(String query) {
            comando = new MySqlCommand(query);
            this.banco = "gm";
        }

        public Comando(String query, String banco) {
            comando = new MySqlCommand(query);
            this.banco = banco;
        }

        public void setComando(String comando) {
            this.comando.CommandText = comando;
        }

        public void addParametro(String parametro, Object valor) {
            try {
                comando.Parameters.AddWithValue(parametro, valor);
            } catch(Exception eAdd) {
                Console.WriteLine(eAdd.ToString());
            }
        }

        // ========== Realizar comando sem consulta no banco =====================
        public Resultado executar() {
            openConexao();
            Resultado saida = new Resultado(false, "Comando não executado.");
            try {
                comando.Connection = con.getConexao();
                saida = new Resultado(true, "Comando executado com sucesso.", comando.ExecuteNonQuery());
            } catch(Exception eExecutar) {
                saida = new Resultado(false, "Comando não executado : " + eExecutar.Message);
            }
            con.fecharConexao();
            return saida;
        }

        // ======= Consulta de Registro Único =========================
        public Resultado consultar<T>() {
            Resultado saida = new Resultado(false, "Comando não executado.");
            openConexao();
            try {
                comando.Connection = con.getConexao();
                MySqlDataReader dados = comando.ExecuteReader();
                if(dados.HasRows) {
                    T obj = novaInstancia<T>();
                    dados.Read();
                    saida = new Resultado(true, "Consulta realizada com sucesso.", FillObject(obj, dados));
                } else {
                    saida = new Resultado(false, "Nenhum registro encontrado.");
                }
            } catch (Exception eConsultar) {
                Console.WriteLine(eConsultar.ToString());
                saida = new Resultado(false, "Comando não executado : " + eConsultar.Message);
            }
            con.fecharConexao();
            return saida;
        }

        // ========= Consulta de registro multiplos ===============================
        public Resultado listar<T>() {
            Resultado saida = new Resultado(false, "Comando não executado.");
            openConexao();
            try {
                comando.Connection = con.getConexao();
                MySqlDataReader dados = comando.ExecuteReader();
                if (dados.HasRows) {
                    LinkedList<T> lista = new LinkedList<T>();
                    while (dados.Read()) {
                        lista.AddLast((T) FillObject(novaInstancia<T>(), dados));
                    }
                    saida = new Resultado(true, "Comando executado com sucesso.", lista);
                } else {
                    saida = new Resultado(false, "Nenhum registro encontrado.");
                }
            } catch (Exception eConsultar) {
                Console.WriteLine(eConsultar.ToString());
                saida = new Resultado(false, "Comando não executado : " + eConsultar.Message);
            }
            con.fecharConexao();
            return saida;
        }

        // ========= Consulta e faz a conversão para JSON ===============================
        public Resultado ConsultarToJson() {
            Resultado saida = new Resultado();
            openConexao();
            try {
                comando.Connection = con.getConexao();
                MySqlDataReader dados = comando.ExecuteReader();
                if (dados.HasRows) {
                    saida = new Resultado(true, "Comando realizado com sucesso.", Serialize(dados));
                } else {
                    saida = new Resultado(false, "Nenhum registro encontrado.");
                }
            } catch (Exception eConsultar) {
                Console.WriteLine(eConsultar.ToString());
                saida = new Resultado(false, "Comando não executado : " + eConsultar.Message);
            }
            con.fecharConexao();
            return saida;
        }
        
        // ========== Consulta para apenar um Campo Ex. (Consultar Saldo, COUNT, SUM) ===============
        public Resultado consultarValor() {
        	Resultado saida = new Resultado(false, "Comando não executado.");
            openConexao();
            try {
                comando.Connection = con.getConexao();
                MySqlDataReader dados = comando.ExecuteReader();
                if(dados.Read()) {
                	saida = new Resultado(true, "Consulta realizada com sucesso.", dados.GetValue(0));
                } else {
                    saida = new Resultado(false, "Nenhum registro encontrado.");
                }
            } catch (Exception eConsultar) {
                Console.WriteLine(eConsultar.ToString());
                saida = new Resultado(false, "Comando não executado : " + eConsultar.ToString());
            }
            con.fecharConexao();
            return saida;
        }
        
        // ================ Consultar e transformar em DataTable ======================================
        public Resultado consultarToDataTable() {
            Resultado saida = new Resultado();
            openConexao();
            try {
                comando.Connection = con.getConexao();
                MySqlDataReader dados = comando.ExecuteReader();
                if (dados.HasRows) {
                	DataTable dt = new DataTable();
                	dt.Load(dados);
                    saida = new Resultado(true, "Comando realizado com sucesso.", dt);
                } else {
                    saida = new Resultado(false, "Nenhum registro encontrado.");
                }
            } catch (Exception eConsultar) {
                Console.WriteLine(eConsultar.ToString());
                saida = new Resultado(false, "Comando não executado : " + eConsultar.Message);
            }
            con.fecharConexao();
            return saida;
        }

        // === Abrir Conexão com banco ===============================
        private void openConexao() {
            con = new Conexao("localhost", "root", "", this.banco);
        }

        // ==== Criar nova instancia do objeto a ser preenchido ========
        private T novaInstancia<T>() {
            return (T)Activator.CreateInstance(typeof(T), new object[] { });
        }

        // ====== Função responsável por preencher o Objeto da consulta com os dados =======
        private Object FillObject(Object obj, MySqlDataReader dados) {
            PropertyInfo[] campos = obj.GetType().GetProperties();
            foreach(PropertyInfo campo in campos) {
                campo.SetValue(obj, dados.GetValue(dados.GetOrdinal(campo.Name.ToLower())));
            }
            return obj;
        }

        private IEnumerable<Dictionary<string, object>> Serialize(MySqlDataReader reader) {
            var results = new List<Dictionary<string, object>>();
            var cols = new List<string>();
            for (var i = 0; i < reader.FieldCount; i++)
                cols.Add(reader.GetName(i));

            while (reader.Read())
                results.Add(SerializeRow(cols, reader));

            return results;
        }
        private Dictionary<string, object> SerializeRow(IEnumerable<string> cols, MySqlDataReader reader) {
            var result = new Dictionary<string, object>();
            foreach (var col in cols)
                result.Add(col, reader[col]);
            return result;
        }
    }
}
