using System;
using System.Drawing;
using System.Windows.Forms;

namespace QuanLyCongTyDuLich.Forms
{
    // Tạo bố cục WinForms dùng chung; không chứa lệnh SQL.
    internal static class UiFactory
    {
        internal static Label Title(string text)
        {
            return new Label { Text = text, Dock = DockStyle.Fill, TextAlign = ContentAlignment.MiddleCenter,
                Font = new Font("Segoe UI", 16f, FontStyle.Bold), ForeColor = Color.FromArgb(33, 65, 94) };
        }

        internal static void Setup(Form form, string title, int width = 1120, int height = 760)
        {
            form.Text = title;
            form.Font = new Font("Segoe UI", 9.5f);
            form.StartPosition = FormStartPosition.CenterScreen;
            form.MinimumSize = new Size(800, 600);
            form.ClientSize = new Size(width, height);
            form.AutoScaleMode = AutoScaleMode.Font;
        }

        internal static TableLayoutPanel Root(Form form, params int[] rows)
        {
            var panel = new TableLayoutPanel { Dock = DockStyle.Fill, Padding = new Padding(12), ColumnCount = 1, RowCount = rows.Length };
            panel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f));
            foreach (int height in rows)
            {
                if (height == -1) panel.RowStyles.Add(new RowStyle(SizeType.Percent, 100f));
                else panel.RowStyles.Add(new RowStyle(SizeType.Absolute, height));
            }
            form.Controls.Add(panel);
            return panel;
        }

        internal static FlowLayoutPanel Inputs()
        {
            return new FlowLayoutPanel { Dock = DockStyle.Fill, AutoScroll = true,
                WrapContents = true, Padding = new Padding(6), FlowDirection = FlowDirection.LeftToRight };
        }

        internal static void Field(FlowLayoutPanel fields, string caption, Control control)
        {
            if (control is CheckBox)
            {
                var ck = (CheckBox)control;
                ck.Text = caption; ck.AutoSize = true; ck.Margin = new Padding(12, 22, 12, 4);
                fields.Controls.Add(ck); return;
            }
            Panel holder = new Panel { Width = 222, Height = 57, Margin = new Padding(7, 3, 7, 2) };
            Label label = new Label { Text = caption, Location = new Point(2, 2), AutoSize = true };
            control.Location = new Point(2, 23); control.Width = 210;
            if (control is ComboBox) ((ComboBox)control).DropDownStyle = ComboBoxStyle.DropDownList;
            holder.Controls.Add(label); holder.Controls.Add(control); fields.Controls.Add(holder);
        }

        internal static DataGridView Grid(DataGridView dgv, bool editable = false)
        {
            dgv.Dock = DockStyle.Fill;
            dgv.BackgroundColor = Color.White;
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.MultiSelect = false;
            dgv.RowHeadersVisible = false;
            dgv.AllowUserToAddRows = editable;
            dgv.AllowUserToDeleteRows = editable;
            dgv.ReadOnly = !editable;
            return dgv;
        }

        internal static void GridTab(TabControl tab, string name, DataGridView grid, FlowLayoutPanel fields)
        {
            var page = new TabPage(name) { Padding = new Padding(8) };
            var layout = new TableLayoutPanel { Dock = DockStyle.Fill, ColumnCount = 1, RowCount = 2 };
            layout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100));
            layout.RowStyles.Add(new RowStyle(SizeType.Percent, 66));
            layout.RowStyles.Add(new RowStyle(SizeType.Percent, 34));
            layout.Controls.Add(Grid(grid), 0, 0);
            layout.Controls.Add(fields, 0, 1);
            page.Controls.Add(layout); tab.TabPages.Add(page);
        }

        internal static FlowLayoutPanel Footer(Button close)
        {
            var footer = new FlowLayoutPanel { Dock = DockStyle.Fill, FlowDirection = FlowDirection.RightToLeft, Padding = new Padding(6) };
            close.Text = "Đóng"; close.Width = 110; close.Height = 34;
            footer.Controls.Add(close); return footer;
        }

        internal static void SetupStandard(Form form, string title, FlowLayoutPanel fields, DataGridView grid, Button close)
        {
            var root = Root(form, 48, 170, -1, 55);
            root.Controls.Add(Title(title), 0, 0);
            root.Controls.Add(fields, 0, 1);
            root.Controls.Add(Grid(grid), 0, 2);
            root.Controls.Add(Footer(close), 0, 3);
        }

        internal static void SetupTabbed(Form form, string title, Control head, TabControl tab, Button close)
        {
            var root = Root(form, 70, -1, 55);
            if (head == null) root.Controls.Add(Title(title), 0, 0);
            else
            {
                var header = new TableLayoutPanel { Dock = DockStyle.Fill, ColumnCount = 2, RowCount = 1 };
                header.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 48));
                header.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 52));
                header.Controls.Add(Title(title), 0, 0);
                var picker = new FlowLayoutPanel { Dock = DockStyle.Fill };
                Field(picker, "Tour đang chọn", head);
                header.Controls.Add(picker, 1, 0);
                root.Controls.Add(header, 0, 0);
            }
            tab.Dock = DockStyle.Fill;
            root.Controls.Add(tab, 0, 1);
            root.Controls.Add(Footer(close), 0, 2);
        }
    }
}
