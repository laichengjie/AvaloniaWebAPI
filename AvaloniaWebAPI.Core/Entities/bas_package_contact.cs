using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AvaloniaWebAPI.Core.Entities
{
    /// <summary>
    /// 商品套餐-联系人范围
    /// </summary>
    [Table("bas_package_contact")]
    public class bas_package_contact
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
        /// 联系人（客户/供应商）ID
        /// </summary>
        [Column("contact_id")]
        public int contact_id { get; set; }

        /// <summary>
        /// 删除标记（0未删除，1已删除）
        /// </summary>
        [Column("is_deleted")]
        public int is_deleted { get; set; }
    }
}