namespace PreDemExam
{
    partial class TableForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tablesCB = new System.Windows.Forms.ComboBox();
            this.tableDGW = new System.Windows.Forms.DataGridView();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.addBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tableDGW)).BeginInit();
            this.SuspendLayout();
            // 
            // tablesCB
            // 
            this.tablesCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tablesCB.FormattingEnabled = true;
            this.tablesCB.Location = new System.Drawing.Point(1025, 12);
            this.tablesCB.Name = "tablesCB";
            this.tablesCB.Size = new System.Drawing.Size(200, 23);
            this.tablesCB.TabIndex = 0;
            this.tablesCB.SelectedIndexChanged += new System.EventHandler(this.tablesCB_SelectedIndexChanged);
            // 
            // tableDGW
            // 
            this.tableDGW.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableDGW.Location = new System.Drawing.Point(12, 12);
            this.tableDGW.Name = "tableDGW";
            this.tableDGW.RowTemplate.Height = 25;
            this.tableDGW.Size = new System.Drawing.Size(1007, 710);
            this.tableDGW.TabIndex = 1;
            this.tableDGW.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.tableDGW_CellValueChanged);
            this.tableDGW.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.tableDGW_DataError);
            // 
            // deleteBtn
            // 
            this.deleteBtn.Location = new System.Drawing.Point(1025, 677);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(200, 45);
            this.deleteBtn.TabIndex = 4;
            this.deleteBtn.Text = "Удалить";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(1025, 626);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(200, 45);
            this.addBtn.TabIndex = 5;
            this.addBtn.Text = "Добавить";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // TableForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1237, 734);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.tableDGW);
            this.Controls.Add(this.tablesCB);
            this.Name = "TableForm";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TableForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.tableDGW)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ComboBox tablesCB;
        private DataGridView tableDGW;
        private Button deleteBtn;
        private Button addBtn;
    }
}