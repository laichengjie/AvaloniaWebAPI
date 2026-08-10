using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AvaloniaWebAPI.Core.Entities
{
    /// <summary>
    /// 唯一码档案表
    /// </summary>
    [Table("bas_unique_code")]
    public class bas_unique_code
    {
        /// <summary>
        /// ID（自增主键）
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
        /// 组织id
        /// </summary>
        [Column("ou_id")]
        public int ou_id { get; set; }

        /// <summary>
        /// 商品唯一码
        /// </summary>
        [Column("product_unique_code")]
        public string product_unique_code { get; set; } = string.Empty;

        /// <summary>
        /// skuID
        /// </summary>
        [Column("sku_id")]
        public int sku_id { get; set; }

        /// <summary>
        /// 仓库id
        /// </summary>
        [Column("stock_id")]
        public int stock_id { get; set; }

        /// <summary>
        /// 来源单号
        /// </summary>
        [Column("s_bill_no")]
        public string s_bill_no { get; set; } = string.Empty;

        /// <summary>
        /// 库存状态
        /// </summary>
        [Column("Inventory_status")]
        public int Inventory_status { get; set; }

        /// <summary>
        /// 流水号
        /// </summary>
        [Column("serial_no")]
        public int serial_no { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        [Column("remark")]
        public string remark { get; set; } = string.Empty;

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
        /// 审核时间
        /// </summary>
        [Column("check_time")]
        public DateTime check_time { get; set; } = DateTime.Now;

        /// <summary>
        /// 销售店铺
        /// </summary>
        [Column("sale_shop_id")]
        public int sale_shop_id { get; set; }

        /// <summary>
        /// 使用店铺
        /// </summary>
        [Column("use_shop_id")]
        public int use_shop_id { get; set; }

        /// <summary>
        /// 销售时间
        /// </summary>
        [Column("sale_time")]
        public DateTime sale_time { get; set; } = new DateTime(3000, 12, 31);

        /// <summary>
        /// 使用时间
        /// </summary>
        [Column("use_time")]
        public DateTime use_time { get; set; } = new DateTime(3000, 12, 31);

        /// <summary>
        /// 入场时间
        /// </summary>
        [Column("entry_time")]
        public DateTime entry_time { get; set; } = new DateTime(3000, 12, 31);

        /// <summary>
        /// 离场时间
        /// </summary>
        [Column("exit_time")]
        public DateTime exit_time { get; set; } = new DateTime(3000, 12, 31);

        /// <summary>
        /// 过期时间
        /// </summary>
        [Column("expiration_time")]
        public DateTime expiration_time { get; set; } = new DateTime(3000, 12, 31);

        /// <summary>
        /// 作废时间
        /// </summary>
        [Column("invalidation_time")]
        public DateTime invalidation_time { get; set; } = new DateTime(3000, 12, 31);
    }
}