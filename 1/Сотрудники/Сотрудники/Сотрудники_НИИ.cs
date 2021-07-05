namespace Сотрудники
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Сотрудники НИИ")]
    public partial class Сотрудники_НИИ
    {
        internal static readonly object Columns;

        public static object Rows { get; internal set; }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Код { get; set; }

        [Required]
        [StringLength(20)]
        public string Фамилия { get; set; }

        [Required]
        [StringLength(20)]
        public string Имя { get; set; }

        [Required]
        [StringLength(20)]
        public string Отчество { get; set; }
       
        public int КодКатегории { get; set; }
        
        public int КодДолжности { get; set; }

        [Required]
        [StringLength(3)]
        public string Пол { get; set; }

        [Column(TypeName = "date")]
        public DateTime Дата_рождения { get; set; }

        [StringLength(50)]
        public string Образование { get; set; }

        [StringLength(15)]
        public string Ученная_степень { get; set; }

        public int Зарплата_в_мес_руб { get; set; }

        [StringLength(50)]
        public string Адрес { get; set; }

        [StringLength(12)]
        public string Телефон { get; set; }
    }
}
