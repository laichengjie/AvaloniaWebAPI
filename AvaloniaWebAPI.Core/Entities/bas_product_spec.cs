using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AvaloniaWebAPI.Core.Entities
{
    /// <summary>
    /// 商品规格表
    /// </summary>
    [Table("bas_product_spec")]
    public class bas_product_spec
    {
        /// <summary>
        /// 商品规格ID（自增主键）
        /// </summary>
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }

        /// <summary>
        /// 集团ID
        /// </summary>
        [Column("group_id")]
        public int group_id { get; set; }

        /// <summary>
        /// 商品ID
        /// </summary>
        [Column("product_id")]
        public int product_id { get; set; }

        /// <summary>
        /// 规格组ID
        /// </summary>
        [Column("bas_specgroup_id")]
        public int bas_specgroup_id { get; set; }

        /// <summary>
        /// 规格ID
        /// </summary>
        [Column("spec_id")]
        public int spec_id { get; set; }

        /// <summary>
        /// 删除标记（0未删除，1已删除）
        /// </summary>
        [Column("is_deleted")]
        public int is_deleted { get; set; }
    }
}