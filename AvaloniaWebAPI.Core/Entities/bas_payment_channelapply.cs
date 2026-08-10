using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AvaloniaWebAPI.Core.Entities
{
    /// <summary>
    /// 支付(付款)方式使用范围（渠道）
    /// </summary>
    [Table("bas_payment_channelapply")]
    public class bas_payment_channelapply
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
        /// 业务地区ID
        /// </summary>
        [Column("op_area_id")]
        public int op_area_id { get; set; }

        /// <summary>
        /// 渠道类型ID
        /// </summary>
        [Column("channel_typeid")]
        public int channel_typeid { get; set; }

        /// <summary>
        /// 渠道ID
        /// </summary>
        [Column("channel_id")]
        public int channel_id { get; set; }

        /// <summary>
        /// 删除标记（0未删除，1已删除）
        /// </summary>
        [Column("is_deleted")]
        public int is_deleted { get; set; }
    }
}