using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AvaloniaWebAPI.Core.Entities
{
    /// <summary>
    /// 支付方式基础资料表
    /// </summary>
    [Table("bas_payment")]
    public class bas_payment
    {
        /// <summary>
        /// ID（主键）
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
        /// 业务组织ID
        /// </summary>
        [Column("ou_id")]
        public int ou_id { get; set; }

        /// <summary>
        /// 支付方式编码
        /// </summary>
        [Column("payment_code")]
        public string payment_code { get; set; } = string.Empty;

        /// <summary>
        /// 支付方式名称
        /// </summary>
        [Column("payment_name")]
        public string payment_name { get; set; } = string.Empty;

        /// <summary>
        /// 支付类型
        /// </summary>
        [Column("pay_typeid")]
        public int pay_typeid { get; set; }

        /// <summary>
        /// 币种
        /// </summary>
        [Column("currency_id")]
        public int currency_id { get; set; }

        /// <summary>
        /// 快捷键
        /// </summary>
        [Column("shortcut")]
        public string shortcut { get; set; } = string.Empty;

        /// <summary>
        /// 费率
        /// </summary>
        [Column("pay_rate")]
        public decimal pay_rate { get; set; }

        /// <summary>
        /// 使用范围(是否有渠道)
        /// </summary>
        [Column("apply_all_channel")]
        public int apply_all_channel { get; set; }

        /// <summary>
        /// 排序
        /// </summary>
        [Column("seq")]
        public int seq { get; set; }

        /// <summary>
        /// 计算会员积分
        /// </summary>
        [Column("integral_calculate_enabled")]
        public int integral_calculate_enabled { get; set; }

        /// <summary>
        /// 是否纳入实际结算金额计算
        /// </summary>
        [Column("is_join_payamount_calc")]
        public int is_join_payamount_calc { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        [Column("remark")]
        public string remark { get; set; } = string.Empty;

        /// <summary>
        /// 启用状态
        /// </summary>
        [Column("status")]
        public int status { get; set; }

        /// <summary>
        /// POS结算默认收款方式
        /// </summary>
        [Column("is_pos_default_payment")]
        public int is_pos_default_payment { get; set; }

        /// <summary>
        /// 创建人
        /// </summary>
        [Column("created_by")]
        public string created_by { get; set; } = "system";

        /// <summary>
        /// 创建时间
        /// </summary>
        [Column("created_time")]
        public DateTime created_time { get; set; } = DateTime.Now;

        /// <summary>
        /// 修改人
        /// </summary>
        [Column("modified_by")]
        public string modified_by { get; set; } = "system";

        /// <summary>
        /// 修改时间
        /// </summary>
        [Column("modified_time")]
        public DateTime modified_time { get; set; } = DateTime.Now;

        /// <summary>
        /// 删除标记
        /// </summary>
        [Column("is_deleted")]
        public int is_deleted { get; set; }

        /// <summary>
        /// 删除人
        /// </summary>
        [Column("deleted_by")]
        public string deleted_by { get; set; } = string.Empty;

        /// <summary>
        /// 删除时间（可为空）
        /// </summary>
        [Column("deleted_time")]
        public DateTime? deleted_time { get; set; }

        /// <summary>
        /// 外部收款方式编码
        /// </summary>
        [Column("ext_payment_code")]
        public string ext_payment_code { get; set; } = string.Empty;

        /// <summary>
        /// 购物金允许部分使用
        /// </summary>
        [Column("is_shopping_part_use")]
        public int is_shopping_part_use { get; set; }

        /// <summary>
        /// 是否纳入业绩金额
        /// </summary>
        [Column("performance_amount_enabled")]
        public int performance_amount_enabled { get; set; }

        /// <summary>
        /// 外部收款方式编码（子）
        /// </summary>
        [Column("child_ext_payment_code")]
        public string child_ext_payment_code { get; set; } = string.Empty;

        /// <summary>
        /// 推送至第三方标记（0未推送，1已推送，2不推送）
        /// </summary>
        [Column("push_third_flag")]
        public int push_third_flag { get; set; }

        /// <summary>
        /// 推送至第三方时间（可为空）
        /// </summary>
        [Column("push_third_time")]
        public DateTime? push_third_time { get; set; }

        /// <summary>
        /// 推送次数
        /// </summary>
        [Column("push_times")]
        public int push_times { get; set; }

        /// <summary>
        /// 是否纳入兑换券收款方式
        /// </summary>
        [Column("is_exchange_coupon")]
        public int is_exchange_coupon { get; set; }

        /// <summary>
        /// 是否纳入发票金额计算
        /// </summary>
        [Column("is_groupon_card")]
        public int is_groupon_card { get; set; }

        /// <summary>
        /// 是否纳入发票金额计算
        /// </summary>
        [Column("invoice_amount_enabled")]
        public int invoice_amount_enabled { get; set; }
    }
}