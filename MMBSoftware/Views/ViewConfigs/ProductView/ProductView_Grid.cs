using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MMBSoftware.Views
{
    public partial class ProductView
    {
        private record ColumnLayout(string Name, DataGridViewAutoSizeColumnMode AutoSizeMode, int Width, float FillWeight, int MinimumWidth);
        private List<ColumnLayout>? _initialColumnLayouts;
        public void ConfigureDataGridProduct()
        {
            dataGridViewProducts.AutoGenerateColumns = false;

            var colId = new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Id",
                HeaderText = "ID",
                Name = "Id",
                ReadOnly = true,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.None,
                Width = 60,
            };

            var colName = new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Name",
                HeaderText = "Name",
                Name = "Name",
                ReadOnly = true,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill,
                FillWeight = 40,
            };

            var colBarcode = new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Barcode",
                HeaderText = "Código de barras",
                Name = "Barcode",
                ReadOnly = true,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill,
                FillWeight = 20,
            };

            var colDescription = new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Description",
                HeaderText = "Descrição",
                Name = "Description",
                ReadOnly = true,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill,
                FillWeight = 25,
            };

            var colPrice = new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Price",
                HeaderText = "Preço",
                Name = "Price",
                ReadOnly = true,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill,
                FillWeight = 15,
            };

            var colCategory = new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Category",
                HeaderText = "Categoria",
                Name = "Category",
                ReadOnly = true,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill,
                FillWeight = 20,
            };

            var colBtnEdit = new DataGridViewButtonColumn
            {
                HeaderText = "",
                Name = "EditBtn",
                Text = "Editar",
                UseColumnTextForButtonValue = true,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.None,
                Width = 80,
            };

            var colBtnDelete = new DataGridViewButtonColumn
            {
                HeaderText = "",
                Name = "DelBtn" +
                "",
                Text = "Excluir",
                UseColumnTextForButtonValue = true,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.None,
                Width = 80,
            };

            dataGridViewProducts.Columns.Clear();
            dataGridViewProducts.Columns.AddRange(new DataGridViewColumn[] {
                colId, colName, colBarcode, colDescription ,colPrice, colCategory, colBtnEdit, colBtnDelete
            });

            SaveInitialColumnLayouts();

            var form = this.FindForm();
            if (form is not null)
            {
                form.ResizeEnd -= ParentForm_ResizeEnd;
                form.ResizeEnd += ParentForm_ResizeEnd;
            }
            else
            {
                this.HandleCreated -= ProductView_HandleCreated;
                this.HandleCreated += ProductView_HandleCreated;
            }

            ConfigureDataGridEvents();
        }

        private void ConfigureDataGridEvents()
        {
            dataGridViewProducts.CellContentClick -= DataGridProducts_CellContentClick;
            dataGridViewProducts.CellContentClick += DataGridProducts_CellContentClick;
        }

        private void ProductView_HandleCreated(object? sender, EventArgs e)
        {
            var form = this.FindForm();
            if (form is not null)
            {
                form.ResizeEnd -= ParentForm_ResizeEnd;
                form.ResizeEnd += ParentForm_ResizeEnd;
            }
        }

        private void ParentForm_ResizeEnd(object? sender, EventArgs e)
        {
            RestoreInitialColumnLayouts();
        }

        private void SaveInitialColumnLayouts()
        {
            _initialColumnLayouts = new List<ColumnLayout>(dataGridViewProducts.Columns.Count);
            foreach (DataGridViewColumn column in dataGridViewProducts.Columns)
            {
                _initialColumnLayouts.Add(new ColumnLayout(
                    column.Name,
                    column.AutoSizeMode,
                    column.Width,
                    column.FillWeight,
                    column.MinimumWidth
                ));
            }
        }

        private void RestoreInitialColumnLayouts()
        {
            if (_initialColumnLayouts == null) return;
            foreach (var layout in _initialColumnLayouts)
            {
                var col = dataGridViewProducts.Columns.Cast<DataGridViewColumn>().FirstOrDefault(c => c.Name == layout.Name);
                if (col != null) continue;

                col.AutoSizeMode = layout.AutoSizeMode;
                if (layout.AutoSizeMode == DataGridViewAutoSizeColumnMode.None)
                {
                    col.Width = layout.Width;
                }
                else if (layout.AutoSizeMode == DataGridViewAutoSizeColumnMode.Fill)
                {
                    col.FillWeight = layout.FillWeight;
                }

                col.MinimumWidth = layout.MinimumWidth;
            }

            dataGridViewProducts.AutoResizeColumns();
            dataGridViewProducts.Refresh();
        }

        private void DataGridProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var grid = (DataGridView)sender;
            var colName = grid.Columns[e.ColumnIndex].Name;

            grid.CurrentCell = grid.Rows[e.RowIndex].Cells[0];

            if (colName == "EditBtn")
            {
                tabControl1.TabPages.Remove(tabListPd);
                tabControl1.TabPages.Add(tabDetailPd);

                EditEvent?.Invoke(this, EventArgs.Empty);
                tabPdDetailTitle.Text = "Editar Produto";

            }
            else if (colName == "DelBtn")
            {
                var result = MessageBox.Show("Tem certeza que deseja excluir este produto?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    DeleteEvent?.Invoke(this, EventArgs.Empty);
                }
            }
        }
    }
}
