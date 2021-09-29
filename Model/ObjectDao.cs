using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Reflection;
using System.Windows.Forms;

namespace GM.Model
{
    public class ObjectDao<T> {

        private String primary; // Chave Primário do Objeto - Padrão Código
        public Boolean AutoIncrement { get; set; } // Possui chave primária ? Padrão Sim 
        public String banco { get; private set; } // Nome do banco a ser acessado

        public ObjectDao(String primary, bool AutoIncrement, String banco) {
            this.primary = primary;
            this.AutoIncrement = AutoIncrement;
            this.banco = banco;
        }

        public ObjectDao(String primary, bool AutoIncrement) {
            this.primary = primary;
            this.AutoIncrement = AutoIncrement;
            this.banco = "gm";
        }

        public ObjectDao() {
            this.primary = "codigo";
            this.AutoIncrement = true;
            this.banco = "gm";
        }

        public ObjectDao(String banco) {
            this.primary = "codigo";
            this.AutoIncrement = true;
            this.banco = banco;
        }

        public void setNullPrimary() {
            this.primary = "";
            this.AutoIncrement = false;
        }

        // === Consulta de objeto com base na chave primário =====
        public Resultado consultar(Object pk) {
            Comando comando = new Comando("SELECT * FROM " + novaInstancia().GetType().Name.ToLower() + " WHERE " + this.primary + " = @" + this.primary, this.banco);
            comando.addParametro("@" + this.primary, pk);
            return comando.consultar<T>();
        }

        // === Consulta de objeto com comando personalizado =====
        public Resultado consultar(String Strcomando) {
            Comando comando = new Comando(Strcomando, this.banco);
            return comando.consultar<T>();
        }

        // === Lista os objetos sem parametros =====
        public Resultado listar() {
            return listar("SELECT * FROM " + novaInstancia().GetType().Name.ToLower());
        }

        // === lista os objetos com comando personalizado =====
        public Resultado listar(String Strcomando) {
            Comando comando = new Comando(Strcomando, this.banco);
            return comando.listar<T>();
        }

        // === Cria novo registro utilizando o Objeto ==========
        public Resultado inserir(T Obj) {
        	// Construção automatica do Objeto INSERT
            String StrComando = "INSERT INTO " + Obj.GetType().Name.ToLower();
            Comando comando = new Comando(StrComando, this.banco);

            // Obtendo campos
            String Campos = "(";
            String Parametros = "(";
            foreach(PropertyInfo campo in getCampos()) {
               if(!(campo.Name.ToLower().Equals(this.primary) && this.AutoIncrement)) {
                    Campos = Campos + campo.Name.ToLower() + ", ";
                    Parametros = Parametros + "@" + campo.Name.ToLower() + ", ";
                    if(campo.PropertyType.ToString().Equals("System.float")) {
                    	comando.addParametro("@" + campo.Name.ToLower(), float.Parse(campo.GetValue(Obj).ToString()));
                    } else {
                    	comando.addParametro("@" + campo.Name.ToLower(), campo.GetValue(Obj));
                    }
                }
            }
            
            // Execução do comando
            StrComando = StrComando + (Campos + ")").Replace(", )", ")") + " VALUES" + (Parametros + ")").Replace(", )", ")");
            comando.setComando(StrComando);
            return comando.executar();
        }

        // ==== Altera utilizando o objeto registro já existente no banco ===
        public Resultado alterar(T obj) {
            String StrComando = "UPDATE " + obj.GetType().Name.ToLower() + " SET";
            Comando comando = new Comando(StrComando, this.banco);

            String Campos = " ";
            foreach (PropertyInfo campo in getCampos()) {
                if (!(campo.Name.ToLower().Equals(this.primary) && this.AutoIncrement)) {
                    Campos = Campos + campo.Name.ToLower() + " = @" + campo.Name.ToLower() + ", ";
                    if(campo.PropertyType.ToString().Equals("System.float")) {
                    	comando.addParametro("@" + campo.Name.ToLower(), float.Parse(campo.GetValue(obj).ToString()));
                    } else {
                    	comando.addParametro("@" + campo.Name.ToLower(), campo.GetValue(obj));
                    }
                }
            }

            StrComando = StrComando + (Campos + "WHERE").Replace(", WHERE", " WHERE ") + this.primary + " = @" + this.primary;
            comando.setComando(StrComando);
            comando.addParametro("@" + this.primary, obj.GetType().GetProperty(this.primary).GetValue(obj));
            return comando.executar();
        }

        // ==== Deletar registro com Objeto
        public Resultado delete(T obj){
            return delete(obj.GetType().GetProperty(this.primary).GetValue(obj));
        }

        // ==== Deletar registro com chave primaria
        public Resultado delete(Object pk) {
            Comando comando = new Comando("DELETE FROM " + novaInstancia().GetType().Name.ToLower() + " WHERE " + this.primary + " = @" + this.primary, this.banco);
            comando.addParametro("@" + this.primary, pk);
            return comando.executar();
        }

        // ==== Instancia novo Objeto
        private T novaInstancia() {
            return (T)Activator.CreateInstance(typeof(T), new object[] { });
        }

        // === Obter Atributos do objeto
        private PropertyInfo[] getCampos() {
            return novaInstancia().GetType().GetProperties();
        }
      
    }
}
