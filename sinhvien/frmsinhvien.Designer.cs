
namespace sinhvien
{
    partial class frmsinhvien
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tensvDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaysinhDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gioitinhDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dienthoaiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diachiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.malopDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sinhvienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLSDataSet = new sinhvien.QLSDataSet();
            this.masv = new System.Windows.Forms.Label();
            this.tensv = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txbmasv = new System.Windows.Forms.TextBox();
            this.txbtensv = new System.Windows.Forms.TextBox();
            this.cmblophoc = new System.Windows.Forms.ComboBox();
            this.lophocBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLSDataSet4 = new sinhvien.QLSDataSet4();
            this.dtngaysinh = new System.Windows.Forms.DateTimePicker();
            this.radnam = new System.Windows.Forms.RadioButton();
            this.radnu = new System.Windows.Forms.RadioButton();
            this.txbdienthoai = new System.Windows.Forms.TextBox();
            this.txbdiachi = new System.Windows.Forms.TextBox();
            this.bntluu = new System.Windows.Forms.Button();
            this.bntxoa = new System.Windows.Forms.Button();
            this.bntcapnhat = new System.Windows.Forms.Button();
            this.bntthoat = new System.Windows.Forms.Button();
            this.sinhvienTableAdapter = new sinhvien.QLSDataSetTableAdapters.sinhvienTableAdapter();
            this.lophocTableAdapter = new sinhvien.QLSDataSet4TableAdapters.lophocTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sinhvienBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLSDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lophocBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLSDataSet4)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.tensvDataGridViewTextBoxColumn,
            this.ngaysinhDataGridViewTextBoxColumn,
            this.gioitinhDataGridViewTextBoxColumn,
            this.dienthoaiDataGridViewTextBoxColumn,
            this.diachiDataGridViewTextBoxColumn,
            this.malopDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.sinhvienBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(-7, 294);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(936, 199);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.Width = 150;
            // 
            // tensvDataGridViewTextBoxColumn
            // 
            this.tensvDataGridViewTextBoxColumn.DataPropertyName = "tensv";
            this.tensvDataGridViewTextBoxColumn.HeaderText = "tensv";
            this.tensvDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.tensvDataGridViewTextBoxColumn.Name = "tensvDataGridViewTextBoxColumn";
            this.tensvDataGridViewTextBoxColumn.Width = 150;
            // 
            // ngaysinhDataGridViewTextBoxColumn
            // 
            this.ngaysinhDataGridViewTextBoxColumn.DataPropertyName = "ngaysinh";
            this.ngaysinhDataGridViewTextBoxColumn.HeaderText = "ngaysinh";
            this.ngaysinhDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.ngaysinhDataGridViewTextBoxColumn.Name = "ngaysinhDataGridViewTextBoxColumn";
            this.ngaysinhDataGridViewTextBoxColumn.Width = 150;
            // 
            // gioitinhDataGridViewTextBoxColumn
            // 
            this.gioitinhDataGridViewTextBoxColumn.DataPropertyName = "gioitinh";
            this.gioitinhDataGridViewTextBoxColumn.HeaderText = "gioitinh";
            this.gioitinhDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.gioitinhDataGridViewTextBoxColumn.Name = "gioitinhDataGridViewTextBoxColumn";
            this.gioitinhDataGridViewTextBoxColumn.Width = 150;
            // 
            // dienthoaiDataGridViewTextBoxColumn
            // 
            this.dienthoaiDataGridViewTextBoxColumn.DataPropertyName = "dienthoai";
            this.dienthoaiDataGridViewTextBoxColumn.HeaderText = "dienthoai";
            this.dienthoaiDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.dienthoaiDataGridViewTextBoxColumn.Name = "dienthoaiDataGridViewTextBoxColumn";
            this.dienthoaiDataGridViewTextBoxColumn.Width = 150;
            // 
            // diachiDataGridViewTextBoxColumn
            // 
            this.diachiDataGridViewTextBoxColumn.DataPropertyName = "diachi";
            this.diachiDataGridViewTextBoxColumn.HeaderText = "diachi";
            this.diachiDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.diachiDataGridViewTextBoxColumn.Name = "diachiDataGridViewTextBoxColumn";
            this.diachiDataGridViewTextBoxColumn.Width = 150;
            // 
            // malopDataGridViewTextBoxColumn
            // 
            this.malopDataGridViewTextBoxColumn.DataPropertyName = "malop";
            this.malopDataGridViewTextBoxColumn.HeaderText = "malop";
            this.malopDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.malopDataGridViewTextBoxColumn.Name = "malopDataGridViewTextBoxColumn";
            this.malopDataGridViewTextBoxColumn.Width = 150;
            // 
            // sinhvienBindingSource
            // 
            this.sinhvienBindingSource.DataMember = "sinhvien";
            this.sinhvienBindingSource.DataSource = this.qLSDataSet;
            // 
            // qLSDataSet
            // 
            this.qLSDataSet.DataSetName = "QLSDataSet";
            this.qLSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // masv
            // 
            this.masv.AutoSize = true;
            this.masv.Location = new System.Drawing.Point(22, 13);
            this.masv.Name = "masv";
            this.masv.Size = new System.Drawing.Size(96, 20);
            this.masv.TabIndex = 1;
            this.masv.Text = "Mã sinh viên";
            // 
            // tensv
            // 
            this.tensv.AutoSize = true;
            this.tensv.Location = new System.Drawing.Point(22, 48);
            this.tensv.Name = "tensv";
            this.tensv.Size = new System.Drawing.Size(101, 20);
            this.tensv.TabIndex = 2;
            this.tensv.Text = "Tên sinh viên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Lớp học";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Ngày sinh";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 175);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Giới tính";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 251);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "Điện thoại";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(387, 251);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 20);
            this.label7.TabIndex = 7;
            this.label7.Text = "Địa chỉ";
            // 
            // txbmasv
            // 
            this.txbmasv.Location = new System.Drawing.Point(137, 13);
            this.txbmasv.Name = "txbmasv";
            this.txbmasv.Size = new System.Drawing.Size(183, 26);
            this.txbmasv.TabIndex = 10;
            // 
            // txbtensv
            // 
            this.txbtensv.Location = new System.Drawing.Point(137, 48);
            this.txbtensv.Name = "txbtensv";
            this.txbtensv.Size = new System.Drawing.Size(268, 26);
            this.txbtensv.TabIndex = 11;
            // 
            // cmblophoc
            // 
            this.cmblophoc.DataSource = this.lophocBindingSource;
            this.cmblophoc.FormattingEnabled = true;
            this.cmblophoc.Location = new System.Drawing.Point(137, 83);
            this.cmblophoc.Name = "cmblophoc";
            this.cmblophoc.Size = new System.Drawing.Size(183, 28);
            this.cmblophoc.TabIndex = 12;
            this.cmblophoc.SelectedIndexChanged += new System.EventHandler(this.cmblophoc_SelectedIndexChanged);
            // 
            // lophocBindingSource
            // 
            this.lophocBindingSource.DataMember = "lophoc";
            this.lophocBindingSource.DataSource = this.qLSDataSet4;
            // 
            // qLSDataSet4
            // 
            this.qLSDataSet4.DataSetName = "QLSDataSet4";
            this.qLSDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dtngaysinh
            // 
            this.dtngaysinh.CustomFormat = "dd/MM/yyyy";
            this.dtngaysinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtngaysinh.Location = new System.Drawing.Point(137, 118);
            this.dtngaysinh.Name = "dtngaysinh";
            this.dtngaysinh.Size = new System.Drawing.Size(200, 26);
            this.dtngaysinh.TabIndex = 13;
            // 
            // radnam
            // 
            this.radnam.AutoSize = true;
            this.radnam.Location = new System.Drawing.Point(137, 170);
            this.radnam.Name = "radnam";
            this.radnam.Size = new System.Drawing.Size(65, 24);
            this.radnam.TabIndex = 14;
            this.radnam.TabStop = true;
            this.radnam.Text = "nam";
            this.radnam.UseVisualStyleBackColor = true;
            // 
            // radnu
            // 
            this.radnu.AutoSize = true;
            this.radnu.Location = new System.Drawing.Point(351, 175);
            this.radnu.Name = "radnu";
            this.radnu.Size = new System.Drawing.Size(52, 24);
            this.radnu.TabIndex = 15;
            this.radnu.TabStop = true;
            this.radnu.Text = "nữ";
            this.radnu.UseVisualStyleBackColor = true;
            // 
            // txbdienthoai
            // 
            this.txbdienthoai.Location = new System.Drawing.Point(137, 244);
            this.txbdienthoai.Name = "txbdienthoai";
            this.txbdienthoai.Size = new System.Drawing.Size(200, 26);
            this.txbdienthoai.TabIndex = 16;
            // 
            // txbdiachi
            // 
            this.txbdiachi.Location = new System.Drawing.Point(475, 251);
            this.txbdiachi.Name = "txbdiachi";
            this.txbdiachi.Size = new System.Drawing.Size(285, 26);
            this.txbdiachi.TabIndex = 17;
            // 
            // bntluu
            // 
            this.bntluu.Location = new System.Drawing.Point(26, 524);
            this.bntluu.Name = "bntluu";
            this.bntluu.Size = new System.Drawing.Size(114, 46);
            this.bntluu.TabIndex = 20;
            this.bntluu.Text = "Lưu";
            this.bntluu.UseVisualStyleBackColor = true;
            this.bntluu.Click += new System.EventHandler(this.bntluu_Click);
            // 
            // bntxoa
            // 
            this.bntxoa.Location = new System.Drawing.Point(183, 524);
            this.bntxoa.Name = "bntxoa";
            this.bntxoa.Size = new System.Drawing.Size(114, 46);
            this.bntxoa.TabIndex = 21;
            this.bntxoa.Text = "Xóa";
            this.bntxoa.UseVisualStyleBackColor = true;
            this.bntxoa.Click += new System.EventHandler(this.bntxoa_Click);
            // 
            // bntcapnhat
            // 
            this.bntcapnhat.Location = new System.Drawing.Point(330, 524);
            this.bntcapnhat.Name = "bntcapnhat";
            this.bntcapnhat.Size = new System.Drawing.Size(114, 46);
            this.bntcapnhat.TabIndex = 22;
            this.bntcapnhat.Text = "Cập nhật";
            this.bntcapnhat.UseVisualStyleBackColor = true;
            this.bntcapnhat.Click += new System.EventHandler(this.bntcapnhat_Click);
            // 
            // bntthoat
            // 
            this.bntthoat.Location = new System.Drawing.Point(815, 524);
            this.bntthoat.Name = "bntthoat";
            this.bntthoat.Size = new System.Drawing.Size(114, 46);
            this.bntthoat.TabIndex = 23;
            this.bntthoat.Text = "Thoát";
            this.bntthoat.UseVisualStyleBackColor = true;
            this.bntthoat.Click += new System.EventHandler(this.bntthoat_Click);
            // 
            // sinhvienTableAdapter
            // 
            this.sinhvienTableAdapter.ClearBeforeFill = true;
            // 
            // lophocTableAdapter
            // 
            this.lophocTableAdapter.ClearBeforeFill = true;
            // 
            // frmsinhvien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(981, 666);
            this.Controls.Add(this.bntthoat);
            this.Controls.Add(this.bntcapnhat);
            this.Controls.Add(this.bntxoa);
            this.Controls.Add(this.bntluu);
            this.Controls.Add(this.txbdiachi);
            this.Controls.Add(this.txbdienthoai);
            this.Controls.Add(this.radnu);
            this.Controls.Add(this.radnam);
            this.Controls.Add(this.dtngaysinh);
            this.Controls.Add(this.cmblophoc);
            this.Controls.Add(this.txbtensv);
            this.Controls.Add(this.txbmasv);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tensv);
            this.Controls.Add(this.masv);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmsinhvien";
            this.Text = "frmsinhvien";
            this.Load += new System.EventHandler(this.frmsinhvien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sinhvienBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLSDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lophocBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLSDataSet4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label masv;
        private System.Windows.Forms.Label tensv;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txbmasv;
        private System.Windows.Forms.TextBox txbtensv;
        private System.Windows.Forms.ComboBox cmblophoc;
        private System.Windows.Forms.DateTimePicker dtngaysinh;
        private System.Windows.Forms.RadioButton radnam;
        private System.Windows.Forms.RadioButton radnu;
        private System.Windows.Forms.TextBox txbdienthoai;
        private System.Windows.Forms.TextBox txbdiachi;
        private System.Windows.Forms.Button bntluu;
        private System.Windows.Forms.Button bntxoa;
        private System.Windows.Forms.Button bntcapnhat;
        private System.Windows.Forms.Button bntthoat;
        private QLSDataSet qLSDataSet;
        private System.Windows.Forms.BindingSource sinhvienBindingSource;
        private QLSDataSetTableAdapters.sinhvienTableAdapter sinhvienTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tensvDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaysinhDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gioitinhDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dienthoaiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn diachiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn malopDataGridViewTextBoxColumn;
        private QLSDataSet4 qLSDataSet4;
        private System.Windows.Forms.BindingSource lophocBindingSource;
        private QLSDataSet4TableAdapters.lophocTableAdapter lophocTableAdapter;
    }
}

