
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using GM.Controller;
using GM.Model;

namespace GM.View.produto {
	public partial class CSFamilia : Form {
		
		private LinkedList<Familia> familias = new LinkedList<Familia>();
		private ObjectDao<Familia> fDao = new ObjectDao<Familia>();
		
		public CSFamilia() {
			InitializeComponent();
		}
		
		public void pesquisar() {
			Resultado res = fDao.listar("SELECT * FROM familia WHERE CONCAT(codigo, nome) LIKE '%" + txtPesquisa.Text.Replace("'", "") + "%'");
			listFamilias.Items.Clear();
			if(res.condicao) {
				familias = res.converter<LinkedList<Familia>>();
				foreach (Familia fam in familias) {
					ListViewItem itm = new ListViewItem();
					itm.Text = fam.codigo.ToString();
					itm.SubItems.Add(fam.nome);
					itm.SubItems.Add(fam.descricao);
					listFamilias.Items.Add(itm);
				}
			} else {  }
		}
		
		void Arranque(object sender, EventArgs e) {
			if(!Ferramentas.infoTela(this.Name).condicao) {
				this.Close();
			} else {
				pesquisar();
			}
		}
		
		void pesquisaClique(object sender, EventArgs e) {
			pesquisar();
		}
		
		void adicionarClique(object sender, EventArgs e) {
			CDFamilia cd = new CDFamilia();
			if(cd.ShowDialog() == DialogResult.OK) { }
			pesquisar();
		}
		
		void editarClique(object sender, EventArgs e) {
			try {
				CDFamilia cd = new CDFamilia(familias.ElementAt(listFamilias.FocusedItem.Index));
				cd.Show();
			} catch (Exception) { }
		}
		
		void deletarSelecionado(object sender, EventArgs e) {
			try {
				Comando com = new Comando("SELECT COUNT(codigo) FROM produto WHERE familia = @fam");
				com.addParametro("@fam", familias.ElementAt(listFamilias.FocusedItem.Index).codigo);
				Resultado res = com.consultarValor();
				if(res.condicao) {
					int quant = int.Parse(res.resultado.ToString());
					if(quant > 0) {
						MessageBox.Show("Há produtos cadastrados para essa família não é possível excluir o mesmo !", "Vinculo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					} else if(MessageBox.Show("Tem certeza ?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes){
						fDao.delete(familias.ElementAt(listFamilias.FocusedItem.Index));
					}
				} else {
					MessageBox.Show("Erro ao validar exclusão : " + res.mensagem, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			} catch (Exception) {
				
			}
		}
	}
}
