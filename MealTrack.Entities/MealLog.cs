namespace MealTrack.Entities
{
    public class MealLog
    {
        public int Id { get; set; }

        /// <summary>Yemek alan öğrencinin ID’si</summary>
        public int StudentId { get; set; }

        /// <summary>Yemek tüketim tarihi</summary>
        public DateTime MealDate { get; set; }

        /// <summary>Öğün türü: Kahvaltı / Öğle / Akşam gibi</summary>
        public string? MealType { get; set; }

        /// <summary>Yemek kaydı oluşturulma zamanı (sistem saati)</summary>
        public DateTime CreatedAt { get; set; } = DateTime.Now;
    }
}
