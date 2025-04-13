
namespace MealTrack.UI
{
    partial class StudentForm
    {
        private Guna.UI2.WinForms.Guna2TextBox txtStudentNo;
        private Guna.UI2.WinForms.Guna2TextBox txtFullName;
        private Guna.UI2.WinForms.Guna2TextBox txtRFIDCode;
        private Guna.UI2.WinForms.Guna2Button btnEkle;
        private Guna.UI2.WinForms.Guna2Button btnGuncelle;
        private Guna.UI2.WinForms.Guna2Button btnSil;
        private Guna.UI2.WinForms.Guna2DataGridView dgvStudents;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblTitle;


        private void InitializeComponent()
        {
            this.txtStudentNo = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtFullName = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtRFIDCode = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnEkle = new Guna.UI2.WinForms.Guna2Button();
            this.btnGuncelle = new Guna.UI2.WinForms.Guna2Button();
            this.btnSil = new Guna.UI2.WinForms.Guna2Button();
            this.dgvStudents = new Guna.UI2.WinForms.Guna2DataGridView();
            this.lblTitle = new Guna.UI2.WinForms.Guna2HtmlLabel();

            // 
            // lblTitle
            // 
            this.lblTitle.Text = "Öğrenci Kayıt Formu";
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(20, 10);

            // 
            // txtStudentNo
            // 
            this.txtStudentNo.PlaceholderText = "Öğrenci No";
            this.txtStudentNo.Location = new System.Drawing.Point(20, 60);
            this.txtStudentNo.Size = new System.Drawing.Size(250, 36);

            // 
            // txtFullName
            // 
            this.txtFullName.PlaceholderText = "Ad Soyad";
            this.txtFullName.Location = new System.Drawing.Point(20, 110);
            this.txtFullName.Size = new System.Drawing.Size(250, 36);

            // 
            // txtRFIDCode
            // 
            this.txtRFIDCode.PlaceholderText = "RFID Kodu";
            this.txtRFIDCode.Location = new System.Drawing.Point(20, 160);
            this.txtRFIDCode.Size = new System.Drawing.Size(250, 36);

            // 
            // btnEkle
            // 
            this.btnEkle = new Guna.UI2.WinForms.Guna2Button();
            this.btnEkle.Text = "Ekle";
            this.btnEkle.Location = new System.Drawing.Point(300, 60);
            this.btnEkle.Size = new System.Drawing.Size(100, 36);
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            this.Controls.Add(this.btnEkle);

            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.Location = new System.Drawing.Point(300, 110);
            this.btnGuncelle.Size = new System.Drawing.Size(100, 36);
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);

            // 
            // btnSil
            // 
            this.btnSil.Text = "Sil";
            this.btnSil.Location = new System.Drawing.Point(300, 160);
            this.btnSil.Size = new System.Drawing.Size(100, 36);
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);

            // 
            // dgvStudents
            // 
            this.dgvStudents.Location = new System.Drawing.Point(20, 220);
            this.dgvStudents.Size = new System.Drawing.Size(560, 200);
            this.dgvStudents.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStudents.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStudents_CellClick);

            // 
            // StudentForm
            // 
            this.ClientSize = new System.Drawing.Size(600, 450);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.txtStudentNo);
            this.Controls.Add(this.txtFullName);
            this.Controls.Add(this.txtRFIDCode);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.dgvStudents);
            this.Text = "Öğrenci Kayıt";
        }
    }
}
