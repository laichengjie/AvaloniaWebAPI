using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AvaloniaWebAPI.Core.Entities
{
    /// <summary>
    /// 商品套餐-商品分组
    /// </summary>
    [Table("bas_packagt_pgroup")]
    public class bas_packagt_pgroup
    {
        /// <summary>
        /// 主键，自增
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
        /// 商品套餐ID
        /// </summary>
        [Column("package_id")]
        public int package_id { get; set; }

        /// <summary>
        /// 商品组名称
        /// </summary>
        [Column("pgroup_name")]
        public string pgroup_name { get; set; } = string.Empty;

        /// <summary>
        /// 购买数量
        /// </summary>
        [Column("qty")]
        public decimal qty { get; set; }

        /// <summary>
        /// 删除标记（0未删除，1已删除）
        /// </summary>
        [Column("is_deleted")]
        public int is_deleted { get; set; }
    }
}