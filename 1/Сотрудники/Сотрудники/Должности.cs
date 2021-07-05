namespace Сотрудники
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Должности
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int КодДолжности { get; set; }

        public int КодКатегории { get; set; }

        [StringLength(50)]
        public string НазваниеДолжности { get; set; }

        public virtual Категории Категории { get; set; }
    }
}
