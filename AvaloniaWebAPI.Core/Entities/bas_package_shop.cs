using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AvaloniaWebAPI.Core.Entities
{
    /// <summary>
    /// 商品套餐-店铺范围
    /// </summary>
    [Table("bas_package_shop")]
    public class bas_package_shop
    {
        /// <summary>
        /// 主键
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
        /// 业务组织ID
        /// </summary>
        [Column("ou_id")]
        public int ou_id { get; set; }

        /// <summary>
        /// 业务地区ID
        /// </summary>
        [Column("op_area_id")]
        public int op_area_id { get; set; }

        /// <summary>
        /// 店铺ID
        /// </summary>
        [Column("shop_id")]
        public int shop_id { get; set; }

        /// <summary>
        /// 删除标记（0未删除，1已删除）
        /// </summary>
        [Column("is_deleted")]
        public int is_deleted { get; set; }
    }
}