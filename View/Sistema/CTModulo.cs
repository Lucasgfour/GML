
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using GM.Controller;
using GM.Model;

namespace GM.View.Sistema {
	public partial class CTModulo : Form {
		
		private LinkedList<Tela> telas;
		private ObjectDao<Tela> tDao = new ObjectDao<Tela>();
		
		public CTModulo() {
			InitializeComponent();
		}
		
		void arranqueFormulario(object sender, EventArgs e) {
			if(!Ferramentas.infoTela(this.Name).condicao) {
				this.Close();
			} else {
				pesquisar();
			}
		}
		
		private void pesquisar() {
			listaTela.Items.Clear();
			Resultado resTela = tDao.listar("SELECT * FROM tela ORDER BY nome ASC");
			if(!resTela.condicao) {
				MessageBox.Show("Nenhuma tela localizado, detalhes : " + resTela.mensagem, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} else {
				telas = resTela.converter<LinkedList<Tela>>();
				foreach (Tela tl in telas) {
					ListViewItem itm = new ListViewItem();
					itm.Text = tl.nome;
					itm.SubItems.Add(tl.nivel.ToString());
					if(tl.disponivel == 0) {
						itm.BackColor = Color.LightSalmon;
					}
					listaTela.Items.Add(itm);
				}
			}
		}
		
		
		void cliqueNovo(object sender, EventArgs e) {
			CDTela cd = new CDTela();
			if(cd.ShowDialog() == DialogResult.OK) {
				pesquisar();
			}
		}
		
		void cliqueEditar(object sender, EventArgs e) {
			try {
				Tela tela = telas.ElementAt(listaTela.FocusedItem.Index);
				CDTela cd = new CDTela(tela);
				if(cd.ShowDialog() == DialogResult.OK) {
					pesquisar();
				}
			} catch (Exception) { }
		}
		
		void cliqueRemover(object sender, EventArgs e) {
			try {
				Tela tela = telas.ElementAt(listaTela.FocusedItem.Index);
				if(MessageBox.Show("Tem certeza que deseja deletar esta tela ?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) {
					Resultado resDele = tDao.delete(tela);
					MessageBox.Show(resDele.mensagem, "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
					pesquisar();
				}
			} catch (Exception) { }
		}
	}
}
