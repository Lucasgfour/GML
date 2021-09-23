
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace GM.Controller {

	public class LMSListView : ListView {
		
		private LinkedList<Object> dados;
	
		public void SetDados<T>(LinkedList<T> dados) {
			this.dados = new LinkedList<Object>();
			try {
				foreach (T dado in dados) {
					this.dados.AddLast(dado);
					ListViewItem itm = new ListViewItem();
					foreach (ColumnHeader col in Columns) {
						try {
							String vlr = dado.GetType().GetProperty(col.Text.ToString().ToLower()).GetValue(dado).ToString();
							if(itm.Text.Equals("")) {
								itm.Text = vlr;	
							} else {
								itm.SubItems.Add(vlr);
							}
						} catch (Exception) { }
					}
					this.Items.Add(itm);
				}
			} catch(Exception e) {
				MessageBox.Show("Erro ao setar dados, detalhes : " + e.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			
		}
		
	}
	
}
