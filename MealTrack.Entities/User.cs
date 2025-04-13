using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MealTrack.Entities
{
    /// <summary>
    /// Sisteme giriş yapan kullanıcı bilgileri (admin panel için)
    /// </summary>
    public class User
    {
        public int Id { get; set; }

        /// <summary>Kullanıcı adı (örnek: admin)</summary>
        public string? Username { get; set; }

        /// <summary>Güvenli şifre alanı (hash olarak tutulabilir)</summary>
        public string? Password { get; set; }

        /// <summary>Kullanıcının rolü (Admin, Personel, vb.)</summary>
        public string? Role { get; set; }
    }
}
