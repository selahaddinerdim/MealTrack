using MealTrack.DAL;
using MealTrack.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MealTrack.UI
{
    public partial class StudentForm : Form
    {
        public StudentForm()
        {
            InitializeComponent();
        }
       
        private void OgrencileriListele()
        {
            using (var db = new MealTrackDbContext())
            {
                dgvStudents.DataSource = db.Students
                    .Select(s => new
                    {
                        s.Id,
                        s.StudentNo,
                        s.FullName,
                        s.RFIDCode,
                        s.RegisterDate
                    })
                    .OrderBy(s => s.StudentNo)
                    .ToList();
            }

            // ID sütununu gizlemek istersen:
            if (dgvStudents.Columns["Id"] != null)
                dgvStudents.Columns["Id"].Visible = false;
        }
        private void YeniOgrenciNoAta()
        {
            using (var db = new MealTrackDbContext())
            {
                int sonId = db.Students.Any() ? db.Students.Max(s => s.Id) : 0;
                int yeniNo = 1000 + sonId + 1;

                txtStudentNo.Text = yeniNo.ToString();
            }
        }
        private void StudentForm_Load(object sender, EventArgs e)
        {
            YeniOgrenciNoAta();
            OgrencileriListele();
        }
        private void dgvStudents_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvStudents.Rows[e.RowIndex];

                txtStudentNo.Text = row.Cells["StudentNo"].Value?.ToString();
                txtFullName.Text = row.Cells["FullName"].Value?.ToString();
                txtRFIDCode.Text = row.Cells["RFIDCode"].Value?.ToString();
            }
        }


        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtStudentNo.Text) ||
                string.IsNullOrWhiteSpace(txtFullName.Text) ||
                string.IsNullOrWhiteSpace(txtRFIDCode.Text))
            {
                MessageBox.Show("Lütfen tüm alanları doldurun.", "Uyarı");
                return;
            }

            using (var db = new MealTrackDbContext())
            {
                bool studentExists = db.Students.Any(s =>
                    s.StudentNo == txtStudentNo.Text || s.RFIDCode == txtRFIDCode.Text);

                if (studentExists)
                {
                    MessageBox.Show("Bu öğrenci numarası veya RFID zaten kayıtlı!", "Uyarı");
                    return;
                }

                var student = new Student
                {
                    StudentNo = txtStudentNo.Text.Trim(),
                    FullName = txtFullName.Text.Trim(),
                    RFIDCode = txtRFIDCode.Text.Trim(),
                    RegisterDate = DateTime.Now
                };

                db.Students.Add(student);
                db.SaveChanges();
            }

            MessageBox.Show("Öğrenci başarıyla eklendi!");
            OgrencileriListele();
            YeniOgrenciNoAta();
            txtFullName.Clear();
            txtRFIDCode.Clear();
            txtFullName.Focus();
        }


        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (dgvStudents.CurrentRow != null)
            {
                int id = Convert.ToInt32(dgvStudents.CurrentRow.Cells["Id"].Value);

                using (var db = new MealTrackDbContext())
                {
                    var student = db.Students.Find(id);
                    if (student != null)
                    {
                        student.StudentNo = txtStudentNo.Text.Trim();
                        student.FullName = txtFullName.Text.Trim();
                        student.RFIDCode = txtRFIDCode.Text.Trim();

                        db.SaveChanges();
                        MessageBox.Show("Öğrenci güncellendi.");
                        OgrencileriListele();
                    }
                }
            }
        }


      

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (dgvStudents.CurrentRow != null)
            {
                int id = Convert.ToInt32(dgvStudents.CurrentRow.Cells["Id"].Value);

                var result = MessageBox.Show("Bu öğrenciyi silmek istediğinize emin misiniz?", "Onay", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    using (var db = new MealTrackDbContext())
                    {
                        var student = db.Students.Find(id);
                        if (student != null)
                        {
                            db.Students.Remove(student);
                            db.SaveChanges();
                            MessageBox.Show("Öğrenci silindi.");
                            OgrencileriListele();
                        }
                    }
                }
            }
        }

    }
}
