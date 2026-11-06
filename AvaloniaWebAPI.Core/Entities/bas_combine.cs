using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AvaloniaWebAPI.Core.Entities
{
    /// <summary>
    /// 组合商品
    /// </summary>
    [Table("bas_combine")]
    public class bas_combine
    {
        /// <summary>
        /// 主键
        /// </summary>
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }

        /// <summary>
        /// 创建人
        /// </summary>
        [Column("created_by")]
        public string created_by { get; set; } = string.Empty;

        /// <summary>
        /// 创建时间
        /// </summary>
        [Column("created_time")]
        public DateTime created_time { get; set; }

        /// <summary>
        /// 修改人
        /// </summary>
        [Column("modified_by")]
        public string modified_by { get; set; } = string.Empty;

        /// <summary>
        /// 修改时间
        /// </summary>
        [Column("modified_time")]
        public DateTime modified_time { get; set; }

        /// <summary>
        /// 删除标记（0/1）
        /// </summary>
        [Column("is_deleted")]
        public int is_deleted { get; set; }

        /// <summary>
        /// 删除人
        /// </summary>
        [Column("deleted_by")]
        public string deleted_by { get; set; } = string.Empty;

        /// <summary>
        /// 删除时间
        /// </summary>
        [Column("deleted_time")]
        public DateTime deleted_time { get; set; }

        /// <summary>
        /// 集团ID
        /// </summary>
        [Column("group_id")]
        public int group_id { get; set; }

        /// <summary>
        /// 组合商品编码
        /// </summary>
        [Column("combine_code")]
        public string combine_code { get; set; } = string.Empty;

        /// <summary>
        /// 组合商品名称
        /// </summary>
        [Column("combine_name")]
        public string combine_name { get; set; } = string.Empty;

        /// <summary>
        /// 条码
        /// </summary>
        [Column("bar_code")]
        public string bar_code { get; set; } = string.Empty;

        /// <summary>
        /// 价格
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
        /// 哈希码
        /// </summary>
        [Column("hash_code")]
        public string hash_code { get; set; } = string.Empty;

        /// <summary>
        /// 业务组织
        /// </summary>
        [Column("ou_id")]
        public int ou_id { get; set; }

        /// <summary>
        /// 类目ID
        /// </summary>
        [Column("category_id")]
        public int category_id { get; set; }

        /// <summary>
        /// 参考失效日期
        /// </summary>
        [Column("reference_expiration_date")]
        public DateTime reference_expiration_date { get; set; } = new DateTime(3000, 12, 31);

        /// <summary>
        /// 基本单位
        /// </summary>
        [Column("unit_id")]
        public int unit_id { get; set; }

        /// <summary>
        /// 创建人ID
        /// </summary>
        [Column("creater_id")]
        public int creater_id { get; set; }

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
    }
}