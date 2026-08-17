using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AvaloniaWebAPI.Core.Entities
{
    /// <summary>
    /// 收银台打印明细表
    /// </summary>
    [Table("bas_counter_print")]
    public class bas_counter_print
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
        /// 收银台id
        /// </summary>
        [Column("counter_id")]
        public int counter_id { get; set; }

        /// <summary>
        /// 打印场景
        /// </summary>
        [Column("print_scene")]
        public string print_scene { get; set; } = string.Empty;

        /// <summary>
        /// 模板类型：0：出餐标签 1：厨打小票
        /// </summary>
        [Column("template_type")]
        public int template_type { get; set; }

        /// <summary>
        /// PC打印机
        /// </summary>
        [Column("pc_print")]
        public string pc_print { get; set; } = string.Empty;

        /// <summary>
        /// PC打印模板id
        /// </summary>
        [Column("pc_template_id")]
        public int pc_template_id { get; set; }

        /// <summary>
        /// APP打印机
        /// </summary>
        [Column("app_print")]
        public string app_print { get; set; } = string.Empty;

        /// <summary>
        /// APP打印模板id
        /// </summary>
        [Column("app_template_id")]
        public int app_template_id { get; set; }

        /// <summary>
        /// APP打印机端口
        /// </summary>
        [Column("app_print_port")]
        public string app_print_port { get; set; } = string.Empty;

        /// <summary>
        /// 打印份数
        /// </summary>
        [Column("print_count")]
        public int print_count { get; set; }

        /// <summary>
        /// 结算自动打印（0否，1是）
        /// </summary>
        [Column("is_settlement_print")]
        public int is_settlement_print { get; set; }

        /// <summary>
        /// 商品范围（是否所有商品，0否，1是）
        /// </summary>
        [Column("apply_all_product")]
        public int apply_all_product { get; set; }

        /// <summary>
        /// 排序
        /// </summary>
        [Column("seq")]
        public int seq { get; set; }

        /// <summary>
        /// 删除标记（0未删除，1已删除）
        /// </summary>
        [Column("is_deleted")]
        public int is_deleted { get; set; }
    }
}