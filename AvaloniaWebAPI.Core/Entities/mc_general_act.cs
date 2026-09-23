using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AvaloniaWebAPI.Core.Entities
{
    /// <summary>
    /// 通用活动（补全字段版）
    /// </summary>
    [Table("mc_general_act")]
    public class mc_general_act
    {
        /// <summary>
        /// ID（主键，自增）
        /// </summary>
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }

        /// <summary>
        /// 删除标记（0未删除，1已删除）
        /// </summary>
        [Column("is_deleted")]
        public int is_deleted { get; set; }

        /// <summary>
        /// 集团ID
        /// </summary>
        [Column("group_id")]
        public int group_id { get; set; }

        /// <summary>
        /// 业务组织
        /// </summary>
        [Column("ou_id")]
        public int ou_id { get; set; }

        /// <summary>
        /// 活动类型
        /// </summary>
        [Column("activity_type_id")]
        public int activity_type_id { get; set; }

        /// <summary>
        /// 活动编码
        /// </summary>
        [Column("activity_code")]
        public string activity_code { get; set; } = string.Empty;

        /// <summary>
        /// 活动名称
        /// </summary>
        [Column("activity_name")]
        public string activity_name { get; set; } = string.Empty;

        /// <summary>
        /// 有效开始时间
        /// </summary>
        [Column("effective_start")]
        public DateTime effective_start { get; set; } = DateTime.Now;

        /// <summary>
        /// 有效结束时间
        /// </summary>
        [Column("effective_end")]
        public DateTime effective_end { get; set; } = new DateTime(3000, 12, 31);

        /// <summary>
        /// 是否时段约束
        /// </summary>
        [Column("time_range_enabled")]
        public int time_range_enabled { get; set; }

        /// <summary>
        /// 时段开始
        /// </summary>
        [Column("time_range_start")]
        public DateTime time_range_start { get; set; } = new DateTime(1900, 1, 1);

        /// <summary>
        /// 时段结束
        /// </summary>
        [Column("time_range_end")]
        public DateTime time_range_end { get; set; } = new DateTime(1900, 1, 1);

        /// <summary>
        /// 是否参与佣金计算
        /// </summary>
        [Column("commission_calculate_enabled")]
        public int commission_calculate_enabled { get; set; }

        /// <summary>
        /// 是否参与特定目标计算
        /// </summary>
        [Column("spe_target_calculate_enabled")]
        public int spe_target_calculate_enabled { get; set; }

        /// <summary>
        /// 是否参与业绩金额计算
        /// </summary>
        [Column("performance_amount_enabled")]
        public int performance_amount_enabled { get; set; }

        /// <summary>
        /// 按周期重复
        /// </summary>
        [Column("repeat_enabled")]
        public int repeat_enabled { get; set; } = 1;

        /// <summary>
        /// 适用人群
        /// </summary>
        [Column("apply_crowd_id")]
        public int apply_crowd_id { get; set; }

        /// <summary>
        /// 活动基准价
        /// </summary>
        [Column("benchmark_price_id")]
        public int benchmark_price_id { get; set; }

        /// <summary>
        /// 活动参与次数
        /// </summary>
        [Column("per_max_times")]
        public int per_max_times { get; set; }

        /// <summary>
        /// 活动等级
        /// </summary>
        [Column("activity_grade_id")]
        public int activity_grade_id { get; set; }

        /// <summary>
        /// 活动描述
        /// </summary>
        [Column("act_description")]
        public string act_description { get; set; } = string.Empty;

        /// <summary>
        /// 备注
        /// </summary>
        [Column("remark")]
        public string remark { get; set; } = string.Empty;

        /// <summary>
        /// 参与商品-促销商品设置方式
        /// </summary>
        [Column("apply_product_modelid")]
        public int apply_product_modelid { get; set; }

        /// <summary>
        /// 店铺范围（0指定 1不限制 2排除）
        /// </summary>
        [Column("apply_all_shop")]
        public int apply_all_shop { get; set; } = 1;

        /// <summary>
        /// 状态
        /// </summary>
        [Column("status")]
        public int status { get; set; }

        /// <summary>
        /// 审核人
        /// </summary>
        [Column("checker")]
        public string checker { get; set; } = string.Empty;

        /// <summary>
        /// 审核时间
        /// </summary>
        [Column("check_time")]
        public DateTime check_time { get; set; } = DateTime.Now;

        /// <summary>
        /// 开单人id
        /// </summary>
        [Column("creater_id")]
        public int creater_id { get; set; }

        /// <summary>
        /// 适用场景
        /// </summary>
        [Column("activity_scene")]
        public int activity_scene { get; set; }

        /// <summary>
        /// 是否开启优惠分摊
        /// </summary>
        [Column("preferential_divide_enabled")]
        public int preferential_divide_enabled { get; set; }

        /// <summary>
        /// 第三方推送状态
        /// </summary>
        [Column("push_third_flag")]
        public int push_third_flag { get; set; }

        /// <summary>
        /// 第三方推送时间
        /// </summary>
        [Column("push_third_time")]
        public DateTime push_third_time { get; set; } = new DateTime(3000, 12, 31);

        /// <summary>
        /// 推送次数
        /// </summary>
        [Column("push_times")]
        public int push_times { get; set; }

        /// <summary>
        /// 约束换购商品零售金额小于等于参与商品零售金额
        /// </summary>
        [Column("exch_price_enabled")]
        public int exch_price_enabled { get; set; }

        /// <summary>
        /// 券类型 0=代金券,1=商场券
        /// </summary>
        [Column("coupon_type_id")]
        public int coupon_type_id { get; set; }

        /// <summary>
        /// 商场业绩折扣
        /// </summary>
        [Column("mall_performance_discount")]
        public decimal mall_performance_discount { get; set; } = 1.000000m;

        /// <summary>
        /// 未添加换购商品弹窗提示
        /// </summary>
        [Column("popup_enabled")]
        public int popup_enabled { get; set; }

        /// <summary>
        /// 删除人ID
        /// </summary>
        [Column("deleted_id")]
        public int deleted_id { get; set; }

        /// <summary>
        /// 修改人ID
        /// </summary>
        [Column("modified_id")]
        public int modified_id { get; set; }

        /// <summary>
        /// 是否引用
        /// </summary>
        [Column("is_reference")]
        public int is_reference { get; set; }

        /// <summary>
        /// 是否已使用通知功能
        /// </summary>
        [Column("is_notify_record")]
        public int is_notify_record { get; set; }
    }
}