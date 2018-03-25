using System;
using System.Collections.Generic;
using System.Text;
using Domain.Entities.Base;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities
{
    [Table("Categories", Schema = "Store")]
    public class Category : EntityBase
    {
        [DataType(DataType.Text), MaxLength(50)]
        public string CategoryName { get; set; }

    }
}