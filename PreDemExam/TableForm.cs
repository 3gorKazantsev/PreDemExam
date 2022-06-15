using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.Data;

namespace PreDemExam
{
    public partial class TableForm : Form
    {
        // ����
        private MySqlConnection connection = new MySqlConnection();
        private List<string> tables = new List<string>();
        private int currentTableIndex = -1;
        private int rowCount = 0;

        // �����������
        public TableForm(MySqlConnection connection)
        {
            InitializeComponent();

            // ������������� �����
            this.connection = connection;
            initTables();

            // ���������� ����������� ��-���
            fillTablesCB();
        }



        //---------------------------------- ������ ������ -------------------------------------------------------
        // ��������� ������ ������
        private void initTables()
        {
            var cmd = new MySqlCommand("SHOW TABLES", connection);
            var reader = cmd.ExecuteReader();
            while (reader.Read())
                tables.Add(reader.GetString(0));
            reader.Close();
        }

        // ���������� ����������� ������ ���������
        private void fillTablesCB()
        {
            tablesCB.Items.Clear();
            tablesCB.Items.AddRange(tables.ToArray());
        }

        // ����� ��-�� �� ����������� ������
        private void tablesCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            currentTableIndex = tablesCB.SelectedIndex;
            if (currentTableIndex != -1)
                fillDGW(tablesCB.SelectedIndex);
        }
        //------------------------------------------------------------------------------------------------------



        //---------------------------------- �������� ������� �������� -------------------------------------------
        // ������ ��������
        private void addBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string values = cellValuesToSqlStr(tableDGW.CurrentRow.Index);
                string query = $"INSERT INTO {getTableName(currentTableIndex)} ({getColumnNames()}) VALUES ({values})";
                exec(query);
                refreshDGW();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        // ������ �������
        private void deleteBtn_Click(object sender, EventArgs e)
        {
            var currentId = tableDGW.CurrentRow.Cells[0].Value;
            var query = $"DELETE FROM {getTableName(currentTableIndex)} WHERE id={currentId}";
            exec(query);
            refreshDGW();
        }

        // ��������� �������� � ������
        private void tableDGW_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (tableDGW.RowCount == rowCount)
                {
                    var columnName = tableDGW.CurrentCell.OwningColumn.Name;
                    var cellValue = formatCellValue(tableDGW.CurrentCell.Value);
                    var id = tableDGW.CurrentRow.Cells[0].Value.ToString();

                    var query = $"UPDATE {getTableName(currentTableIndex)} SET {columnName}='{cellValue}' WHERE id={id}";
                    exec(query);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }
        //--------------------------------------------------------------------------------------------------------



        //-------------------------------------------------- ���� -------------------------------------------------
        private string getTableName(int index)
        {
            return tables[index];
        }

        private string getColumnNames()
        {
            var columns = new List<string>();
            foreach (DataGridViewColumn column in tableDGW.Columns)
                columns.Add(column.Name);
            return string.Join(", ", columns);
        }

        private string cellValuesToSqlStr(int row)
        {
            List<string> cellValues = new List<string>();

            foreach (DataGridViewCell cell in tableDGW.Rows[row].Cells)
            {
                var cellValue = formatCellValue(cell.Value);
                cellValues.Add(cellValue);
            }

            return $"\'{string.Join("\', \'", cellValues)}\'";
        }

        // �������������� �������� ������ ��� SQL
        private string formatCellValue(object cellValue)
        {
            if (cellValue is DateTime)
                return ((DateTime)cellValue).ToString("yyyy-MM-dd");
            else if (cellValue is Boolean)
                return Convert.ToInt32((Boolean)cellValue).ToString();
            else
                return cellValue.ToString();
        }
        //---------------------------------------------------------------------------------------------------------

        // ���������� DGW
        private void fillDGW(int index)
        {
            try
            {
                var query = $"SELECT * FROM {getTableName(index)}";
                var adapter = new MySqlDataAdapter();
                adapter.SelectCommand = new MySqlCommand(query, connection);

                var dataTable = new DataTable();
                adapter.Fill(dataTable);

                var bindingSource = new BindingSource();
                bindingSource.DataSource = dataTable;

                tableDGW.DataSource = bindingSource;
                tableDGW.Columns[0].ReadOnly = true;
                rowCount = tableDGW.RowCount;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        // �������� DGW
        private void refreshDGW()
        {
            fillDGW(currentTableIndex);
        }

        // ��������� ������
        private void exec(string query)
        {
            try
            {
                var cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void tableDGW_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show("Data format error", "Error");
        }

        // �������� ����� ����������
        private void TableForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}