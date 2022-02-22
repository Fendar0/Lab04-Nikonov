using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab04_Nikonov
{
    public partial class Form1 : Form
    {
        string connectingstring = @"Data Source=DESKTOP-NOJI3BG;Initial Catalog=DBLab3;Integrated Security=True";
        SqlCommand cmd = new SqlCommand();

        struct elementinfo
        {
            public int atomic;
            public string name;
        }

        struct lineinfo
        {
            public float wlen;
            public float intens;
        }

        List<elementinfo> elements = new List<elementinfo>();
        List<lineinfo> lines = new List<lineinfo>();

        Pen pen = new Pen(Color.White);
        public Form1()
        {
            InitializeComponent();
        }

        private void pb_box_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.Clear(Color.Black);

            int w = pb_box.Width - 1;
            int h = pb_box.Height - 1;

            float[] c = new float[3];
            for (int i = 0; i < lines.Count; i++)
            {
                float x = Interp.map(lines[i].wlen, 380.0f, 780.0f, 0, w);
                Wavelength.RGB(lines[i].wlen, c);
                pen.Color = Color.FromArgb((int)(c[0] * 255.0f), (int)(c[1] * 255.0f), (int)(c[2] * 255.0f));
                e.Graphics.DrawLine(pen, x, 0, x, h);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {            
            using (SqlConnection connect = new SqlConnection(connectingstring))
            {
                connect.Open();

                string sql = "SELECT Atomic_number, Full_name FROM elements;";
                cmd = new SqlCommand(sql, connect);

                SqlDataReader reader = cmd.ExecuteReader();

                int col_atom = reader.GetOrdinal("atomic_number");
                int col_name = reader.GetOrdinal("full_name");

                while (reader.Read() == true)
                {
                    elementinfo el;
                    el.atomic = reader.GetInt32(col_atom);
                    el.name = reader.GetString(col_name);

                    elements.Add(el);
;                   cb_Element.Items.Add(el.name);
                }
                reader.Close();

                connect.Close();
            }

        }

        private void tb_Show_Click(object sender, EventArgs e)
        {
            using (SqlConnection connect = new SqlConnection(connectingstring))
            {
                int idx = cb_Element.SelectedIndex;
                if (idx < 0) return;

                int atomic = elements[idx].atomic;

                connect.Open();
                string sql2 = "SELECT wave_length, rel_intensity FROM spectral_lines ";
                sql2 += $"WHERE atomic_number = {atomic.ToString()}";
                                
                cmd = new SqlCommand(sql2, connect);

                SqlDataReader reader = cmd.ExecuteReader();

                int col_wlen = reader.GetOrdinal("wave_length");
                int col_reli = reader.GetOrdinal("rel_intensity");

                lines.Clear();

                while (reader.Read() == true)
                {
                    lineinfo li;

                    li.wlen = (float)reader.GetDouble(col_wlen);
                    li.intens = (float)reader.GetDouble(col_reli);
                    
                    lines.Add(li);
                }

                reader.Close();
                pb_box.Invalidate();

            }
        }
    }
}
