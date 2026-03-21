using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MMBSoftware.Views
{
    public partial class StockView
    {
        private record ColumnLayout(string Name, DataGridViewAutoSizeColumnMode AutoSizeMode, int Width, float FillWeight, int MinimumWidth);
        private List<ColumnLayout>? _initialColumnLayouts;
        public void ConfigureDataGridStock()
        {
            dataGridStockList.AutoGenerateColumns = false;

            var colId = new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Id",
                HeaderText = "ID",
                Name = "Id",
                ReadOnly = true,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.None,
                Width = 60,
            };

            var colProductId = new DataGridViewTextBoxColumn
            {
                DataPropertyName = "ProductId",
                HeaderText = "ID do Produto",
                Name = "ProductId",
                ReadOnly = true,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.None,
                Width = 60,
            };

            var colQuantity = new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Quantity",
                HeaderText = "Quantidade",
                Name = "Quantity",
                ReadOnly = true,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill,
                FillWeight = 10,
            };

            var colProductName = new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Product_Name",
                HeaderText = "Nome do Produto",
                Name = "Product_Name",
                ReadOnly = true,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill,
                FillWeight = 30,
            };

            var colEntryDate = new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Entry_Date",
                HeaderText = "Data de entrada",
                Name = "Entry_Date",
                ReadOnly = true,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill,
                FillWeight = 15,
            };

            var colExpiryDate = new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Expiry_Date",
                HeaderText = "Data de validade",
                Name = "Expiry_Date",
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
                Name = "DelBtn",
                Text = "Excluir",
                UseColumnTextForButtonValue = true,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.None,
                Width = 80,
            };

            dataGridStockList.Columns.Clear();
            dataGridStockList.Columns.AddRange(new DataGridViewColumn[] {
                colId, colProductId, colProductName, colQuantity ,colEntryDate, colExpiryDate, colBtnEdit, colBtnDelete
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
                this.HandleCreated -= StockView_HandleCreated;
                this.HandleCreated += StockView_HandleCreated;
            }

            ConfigureDataGridEvents();
        }

        private void ConfigureDataGridEvents()
        {
            dataGridStockList.CellContentClick -= DataGridStocks_CellContentClick;
            dataGridStockList.CellContentClick += DataGridStocks_CellContentClick;
        }

        private void StockView_HandleCreated(object? sender, EventArgs e)
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
            _initialColumnLayouts = new List<ColumnLayout>(dataGridStockList.Columns.Count);
            foreach (DataGridViewColumn column in dataGridStockList.Columns)
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
                var col = dataGridStockList.Columns.Cast<DataGridViewColumn>().FirstOrDefault(c => c.Name == layout.Name);
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

            dataGridStockList.AutoResizeColumns();
            dataGridStockList.Refresh();
        }

        private void DataGridStocks_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var grid = (DataGridView)sender;
            var colName = grid.Columns[e.ColumnIndex].Name;

            grid.CurrentCell = grid.Rows[e.RowIndex].Cells[0];

            if (colName == "EditBtn")
            {
                tabStockEdit.TabPages.Remove(tabStockList);
                tabStockEdit.TabPages.Add(tabStockRegEdit);

                EditEvent?.Invoke(this, EventArgs.Empty);
                tabPdDetailTitle.Text = "Editar Estoque";

            }
            else if (colName == "DelBtn")
            {
                var result = MessageBox.Show("Tem certeza que deseja excluir este registro?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    DeleteEvent?.Invoke(this, EventArgs.Empty);
                }
            }
        }
    }
}
