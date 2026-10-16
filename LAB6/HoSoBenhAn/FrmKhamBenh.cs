using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace HoSoBenhAnPrototype
{
    public partial class FrmKhamBenh : Form
    {
        private readonly KhamBenhService service = new KhamBenhService();
        private readonly List<ThuocKeData> thuoc = new List<ThuocKeData>();
        private readonly List<XetNghiemData> xetNghiem = new List<XetNghiemData>();

        public FrmKhamBenh()
        {
            InitializeComponent();
            cboLoaiKham.SelectedIndex = 0;
            cboLoaiKham.SelectedIndexChanged += DoiLoaiKham;
            btnThemXn.Click += ThemXetNghiem;
            btnXoaXn.Click += XoaXetNghiem;
            btnThemThuoc.Click += ThemThuoc;
            btnXoaThuoc.Click += XoaThuoc;
            btnLuu.Click += Luu;
            btnLichSu.Click += XemLichSu;
            Shown += (s, e) => LoadDanhMuc();
        }

        private void DoiLoaiKham(object sender, EventArgs e)
        {
            bool dinhKy = cboLoaiKham.Text == "DinhKy";
            if (dinhKy) numVienPhi.Value = 0;
            numVienPhi.Enabled = !dinhKy;
        }

        private void LoadDanhMuc()
        {
            try
            {
                cboBacSi.DisplayMember = "HienThi";
                cboBacSi.ValueMember = "MaBacSi";
                cboBacSi.DataSource = service.Repository.LayBacSi();

                cboThuoc.DisplayMember = "TenThuoc";
                cboThuoc.ValueMember = "MaThuoc";
                cboThuoc.DataSource = service.Repository.LayThuoc();

                cboXetNghiem.DisplayMember = "TenXetNghiem";
                cboXetNghiem.ValueMember = "MaXetNghiem";
                cboXetNghiem.DataSource = service.Repository.LayXetNghiem();
                TaiThuoc();
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Không tải được danh mục");
            }
        }

        private static int ParseMaHoSo(string input)
        {
            string s = (input ?? "").Trim().ToUpperInvariant();
            if (s.StartsWith("HS")) s = s.Substring(2);
            int id;
            return int.TryParse(s, out id) ? id : 0;
        }

        private void ThemThuoc(object sender, EventArgs e)
        {
            if (!(cboThuoc.SelectedValue is int)) return;
            int id = (int)cboThuoc.SelectedValue;
            if (thuoc.Any(x => x.MaThuoc == id))
            {
                MessageBox.Show("Thuốc đã được thêm.");
                return;
            }
            if (string.IsNullOrWhiteSpace(txtLieuDung.Text))
            {
                MessageBox.Show("Nhập liều dùng.");
                return;
            }
            thuoc.Add(new ThuocKeData
            {
                MaThuoc = id,
                TenThuoc = cboThuoc.Text,
                SoLuong = (int)numSoLuong.Value,
                LieuDung = txtLieuDung.Text.Trim()
            });
            TaiThuoc();
            txtLieuDung.Clear();
        }

        private void XoaThuoc(object sender, EventArgs e)
        {
            if (gridThuoc.CurrentRow == null || !gridThuoc.Columns.Contains("MaThuoc")) return;
            int ma = (int)gridThuoc.CurrentRow.Cells["MaThuoc"].Value;
            thuoc.RemoveAll(x => x.MaThuoc == ma);
            TaiThuoc();
        }

        private void TaiThuoc()
        {
            gridThuoc.DataSource = null;
            gridThuoc.DataSource = thuoc.Select(x => new { x.MaThuoc, x.TenThuoc, x.SoLuong, x.LieuDung }).ToList();
            if (gridThuoc.Columns.Contains("MaThuoc")) gridThuoc.Columns["MaThuoc"].Visible = false;
        }

        private void ThemXetNghiem(object sender, EventArgs e)
        {
            if (!(cboXetNghiem.SelectedValue is int)) return;
            int id = (int)cboXetNghiem.SelectedValue;
            if (xetNghiem.Any(x => x.MaXetNghiem == id))
            {
                MessageBox.Show("Xét nghiệm đã được thêm.");
                return;
            }
            xetNghiem.Add(new XetNghiemData { MaXetNghiem = id, KetQua = txtKetQuaXn.Text.Trim() });
            listXn.Items.Add(cboXetNghiem.Text + " | " + txtKetQuaXn.Text.Trim());
            txtKetQuaXn.Clear();
        }

        private void XoaXetNghiem(object sender, EventArgs e)
        {
            if (listXn.SelectedIndex < 0) return;
            int index = listXn.SelectedIndex;
            listXn.Items.RemoveAt(index);
            xetNghiem.RemoveAt(index);
        }

        private void Luu(object sender, EventArgs e)
        {
            try
            {
                var d = new KhamBenhData
                {
                    MaHoSo = ParseMaHoSo(txtMaHoSo.Text),
                    MaBacSi = cboBacSi.SelectedValue is int ? (int)cboBacSi.SelectedValue : 0,
                    NgayGioKham = dtKham.Value,
                    LoaiKham = cboLoaiKham.Text,
                    TrieuChung = txtTrieuChung.Text.Trim(),
                    ThanNhiet = numThanNhiet.Value,
                    HuyetAp = txtHuyetAp.Text.Trim(),
                    ChanDoan = txtChanDoan.Text.Trim(),
                    NgayXuatVien = dtXuatVien.Value,
                    NgayThanhToan = dtThanhToan.Value,
                    VienPhi = numVienPhi.Value
                };
                d.Thuoc.AddRange(thuoc);
                d.XetNghiem.AddRange(xetNghiem);
                int id = service.GhiNhan(d, ckXuatVien.Checked, ckThanhToan.Checked);
                MessageBox.Show(this, "Ghi nhận thành công phiếu khám số " + id, "Thành công");
                thuoc.Clear();
                xetNghiem.Clear();
                listXn.Items.Clear();
                TaiThuoc();
                XemLichSu(null, EventArgs.Empty);
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Không thể ghi nhận", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void XemLichSu(object sender, EventArgs e)
        {
            try
            {
                int id = ParseMaHoSo(txtMaHoSo.Text);
                if (id <= 0)
                {
                    MessageBox.Show("Nhập mã hồ sơ hợp lệ (ví dụ HS000001).");
                    return;
                }
                gridLichSu.DataSource = service.Repository.LayLichSu(id);
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Lỗi truy vấn");
            }
        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }
    }
}
