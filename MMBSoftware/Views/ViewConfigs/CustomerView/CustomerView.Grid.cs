
namespace MMBSoftware.Views
{
    public partial class CustomerView
    {
        private record ColumnLayout(string Name, DataGridViewAutoSizeColumnMode AutoSizeMode, int Width, float FillWeight, int MinimumWidth);
        private List<ColumnLayout>? _initialColumnLayouts;

        private void ConfigureDataGridCustomer()
        {
            dataGridClients.AutoGenerateColumns = false;

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
                HeaderText = "Nome",
                Name = "Name",
                ReadOnly = true,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill,
                FillWeight = 40,
            };

            var colEmail = new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Email",
                HeaderText = "Email",
                Name = "Email",
                ReadOnly = true,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill,
                FillWeight = 20,
            };

            var colPhone = new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Phone",
                HeaderText = "Telefone",
                Name = "Phone",
                ReadOnly = true,
                AutoSizeMode= DataGridViewAutoSizeColumnMode.Fill,
                FillWeight = 10,
            };

            var colCPF = new DataGridViewTextBoxColumn
            {
                DataPropertyName = "CPF",
                HeaderText = "CPF",
                Name = "CPF",
                ReadOnly = true,
                Width = 120,
            };

            var colCanPlaceOrder = new DataGridViewCheckBoxColumn
            {
                DataPropertyName = "CanPlaceOrder",
                HeaderText = "Situação",
                Name = "CanPlaceOrder",
                ReadOnly = true,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill,
                FillWeight = 7,
            };

            var colAccountLimit = new DataGridViewTextBoxColumn
            {
                DataPropertyName = "AccountLimit",
                HeaderText = "Limite de crédito",
                Name = "AccountLimit",
                ReadOnly = true,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill,
                FillWeight = 15,
            };
            
            var colNoteBtn = new DataGridViewButtonColumn
            {
                HeaderText = "",
                Name = "NotesBtn",
                Text = "Notas",
                UseColumnTextForButtonValue = true,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill,
                FillWeight = 10,
            };

            var colEditBtn = new DataGridViewButtonColumn
            {
                HeaderText = "",
                Name = "EditBtn",
                Text = "Editar",
                UseColumnTextForButtonValue = true,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill,
                FillWeight = 10,
            };

            var colDelBtn = new DataGridViewButtonColumn
            {
                HeaderText = "",
                Name = "DelBtn",
                Text = "Excluir",
                UseColumnTextForButtonValue = true,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill,
                FillWeight = 10,
            };

            dataGridClients.Columns.Clear();
            dataGridClients.Columns.AddRange(new DataGridViewColumn[] {
                colId, colName, colEmail, colPhone, colCanPlaceOrder, colAccountLimit, colEditBtn, colNoteBtn,colDelBtn
            });

            // Save initial layout so we can restore it after user resizes the window
            SaveInitialColumnLayouts();

            // Try to attach to the parent form ResizeEnd to restore layout when resizing finishes
            var form = this.FindForm();
            if (form is not null)
            {
                form.ResizeEnd -= ParentForm_ResizeEnd;
                form.ResizeEnd += ParentForm_ResizeEnd;
            }
            else
            {
                // If control not yet parented, attach when handle is created
                this.HandleCreated -= CustomerView_HandleCreated;
                this.HandleCreated += CustomerView_HandleCreated;
            }

            ConfigureDataGridEvents();
        }

        private void ConfigureDataGridEvents()
        {
            dataGridClients.CellContentClick -= DataGridClients_CellContentClick;
            dataGridClients.CellContentClick += DataGridClients_CellContentClick;
        }

        private void CustomerView_HandleCreated(object? sender, EventArgs e)
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
            // Restore the initial layout after resizing ends
            RestoreInitialColumnLayouts();
        }

        private void SaveInitialColumnLayouts()
        {
            _initialColumnLayouts = new List<ColumnLayout>(dataGridClients.Columns.Count);
            foreach (DataGridViewColumn col in dataGridClients.Columns)
            {
                var layout = new ColumnLayout(
                    col.Name,
                    col.AutoSizeMode,
                    col.Width,
                    col.FillWeight,
                    col.MinimumWidth
                );
                _initialColumnLayouts.Add(layout);
            }
        }

        private void RestoreInitialColumnLayouts()
        {
            if (_initialColumnLayouts == null) return;

            // Apply saved settings. For columns in Fill mode we set AutoSizeMode and FillWeight.
            foreach (var layout in _initialColumnLayouts)
            {
                var col = dataGridClients.Columns.Cast<DataGridViewColumn>().FirstOrDefault(c => c.Name == layout.Name);
                if (col == null) continue;

                col.AutoSizeMode = layout.AutoSizeMode;
                // For fixed mode, restore width. For fill mode, restore FillWeight.
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

            // Force a layout update
            dataGridClients.AutoResizeColumns();
            dataGridClients.Refresh();
        }

        private void DataGridClients_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var grid = (DataGridView)sender;
            var colName = grid.Columns[e.ColumnIndex].Name;

            grid.CurrentCell = grid.Rows[e.RowIndex].Cells[0];

            if (colName == "EditBtn")
            {
                tabControl1.TabPages.Remove(tabClientList);
                tabControl1.TabPages.Add(tabClientDetail);

                cbDefineStateAccount.Enabled = true;
                labelCbDefineStateAccount.Enabled = true;
                txtDefineLimitAccount.Enabled = true;
                labelTxtDefineLimitAccount.Enabled = true;

                EditEvent?.Invoke(this, EventArgs.Empty);
                tabClientsDetailTitle.Text = "Editar Cliente";

            }
            else if (colName == "DelBtn")
            {
                var result = MessageBox.Show("Tem certeza que deseja excluir este cliente?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    DeleteEvent?.Invoke(this, EventArgs.Empty);
                }
            }
        }
    }
}
