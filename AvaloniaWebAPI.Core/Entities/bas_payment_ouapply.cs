using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AvaloniaWebAPI.Core.Entities
{
    /// <summary>
    /// 支付(付款)方式使用范围（组织）
    /// </summary>
    [Table("bas_payment_ouapply")]
    public class bas_payment_ouapply
    {
        /// <summary>
        /// 主键ID（自增）
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
        /// 支付方式ID
        /// </summary>
        [Column("payment_id")]
        public int payment_id { get; set; }

        /// <summary>
        /// 业务组织ID
        /// </summary>
        [Column("ou_id")]
        public int ou_id { get; set; }

        /// <summary>
        /// 删除标记（0未删除，1已删除）
        /// </summary>
        [Column("is_deleted")]
        public int is_deleted { get; set; }
    }
}