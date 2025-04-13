using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MealTrack.Entities
{
   
        /// <summary>
        /// Öğrencilerin temel bilgilerini temsil eder.
        /// </summary>
        public class Student
        {
            /// <summary>Veritabanındaki benzersiz öğrenci ID’si (otomatik artan)</summary>
            public int Id { get; set; }

            /// <summary>Okulun verdiği benzersiz öğrenci numarası (RFID ile eşleştirilir)</summary>
            public string? StudentNo { get; set; }

            /// <summary>Öğrencinin adı ve soyadı</summary>
            public string? FullName { get; set; }

            /// <summary>Öğrencinin RFID kart kodu</summary>
            public string? RFIDCode { get; set; }

            /// <summary>Öğrenci kayıt tarihi</summary>
            public DateTime RegisterDate { get; set; }
        }
    }

