using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AvaloniaWebAPI.Core.Entities
{
    /// <summary>
    /// 商品套餐表
    /// </summary>
    [Table("bas_package")]
    public class bas_package
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
        /// 业务组织
        /// </summary>
        [Column("ou_id")]
        public int ou_id { get; set; }

        /// <summary>
        /// 类目ID
        /// </summary>
        [Column("category_id")]
        public int category_id { get; set; } = 1;

        /// <summary>
        /// 商品套餐编码
        /// </summary>
        [Column("package_code")]
        public string package_code { get; set; } = string.Empty;

        /// <summary>
        /// 商品套餐名称
        /// </summary>
        [Column("package_name")]
        public string package_name { get; set; } = string.Empty;

        /// <summary>
        /// 套餐售价
        /// </summary>
        [Column("price")]
        public decimal price { get; set; }

        /// <summary>
        /// 启用状态
        /// </summary>
        [Column("status")]
        public int status { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        [Column("remark")]
        public string remark { get; set; } = string.Empty;

        /// <summary>
        /// 套餐描述
        /// </summary>
        [Column("description")]
        public string description { get; set; } = string.Empty;

        /// <summary>
        /// 套餐图片地址
        /// </summary>
        [Column("package_url")]
        public string package_url { get; set; } = string.Empty;

        /// <summary>
        /// 修改人ID
        /// </summary>
        [Column("modified_id")]
        public int modified_id { get; set; }

        /// <summary>
        /// 商品商品方式(1商品级别；2.SKU)
        /// </summary>
        [Column("apply_product_type")]
        public int apply_product_type { get; set; }

        /// <summary>
        /// 店铺范围(是否所有店铺):0 指定 1不限制 2排除
        /// </summary>
        [Column("apply_all_shop")]
        public int apply_all_shop { get; set; } = 1;

        /// <summary>
        /// 修改时间
        /// </summary>
        [Column("modified_time")]
        public DateTime modified_time { get; set; } = DateTime.Now;
    }
}