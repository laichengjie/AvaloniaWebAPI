using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AvaloniaWebAPI.Core.Entities
{
    /// <summary>
    /// 店铺基础资料表
    /// </summary>
    [Table("bas_shop")]
    public class bas_shop
    {
        /// <summary>
        /// 店铺ID（自增主键）
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
        /// 所属组织单元ID
        /// </summary>
        [Column("ou_id")]
        public int ou_id { get; set; }

        /// <summary>
        /// 组织代码
        /// </summary>
        [Column("ou_code")]
        public string ou_code { get; set; } = string.Empty;

        /// <summary>
        /// 组织名称
        /// </summary>
        [Column("ou_name")]
        public string ou_name { get; set; } = string.Empty;

        /// <summary>
        /// 组织全路径ID
        /// </summary>
        [Column("ou_fullpath_id")]
        public string ou_fullpath_id { get; set; } = string.Empty;

        /// <summary>
        /// 组织全路径名称
        /// </summary>
        [Column("ou_fullpath_name")]
        public string ou_fullpath_name { get; set; } = string.Empty;

        /// <summary>
        /// 本位币ID
        /// </summary>
        [Column("base_currency_id")]
        public int base_currency_id { get; set; }

        /// <summary>
        /// 店铺编码
        /// </summary>
        [Column("shop_code")]
        public string shop_code { get; set; } = string.Empty;

        /// <summary>
        /// 店铺名称
        /// </summary>
        [Column("shop_name")]
        public string shop_name { get; set; } = string.Empty;

        /// <summary>
        /// 店铺类型
        /// </summary>
        [Column("shop_typeid")]
        public int shop_typeid { get; set; }

        /// <summary>
        /// 店铺性质
        /// </summary>
        [Column("shop_work_propertyid")]
        public int shop_work_propertyid { get; set; }

        /// <summary>
        /// 经营方式
        /// </summary>
        [Column("shop_work_mode_id")]
        public int shop_work_mode_id { get; set; }

        /// <summary>
        /// 店铺等级
        /// </summary>
        [Column("shop_gradeid")]
        public int shop_gradeid { get; set; }

        /// <summary>
        /// 对应仓库
        /// </summary>
        [Column("stock_id")]
        public int stock_id { get; set; }

        /// <summary>
        /// 业务地区
        /// </summary>
        [Column("op_area_id")]
        public int op_area_id { get; set; }

        /// <summary>
        /// 地区代码
        /// </summary>
        [Column("area_code")]
        public string area_code { get; set; } = string.Empty;

        /// <summary>
        /// 地区名称
        /// </summary>
        [Column("area_name")]
        public string area_name { get; set; } = string.Empty;

        /// <summary>
        /// 地区全路径ID
        /// </summary>
        [Column("area_full_path_id")]
        public string area_full_path_id { get; set; } = string.Empty;

        /// <summary>
        /// 地区全路径名称
        /// </summary>
        [Column("area_full_path_name")]
        public string area_full_path_name { get; set; } = string.Empty;

        /// <summary>
        /// 店铺地址
        /// </summary>
        [Column("shop_address")]
        public string shop_address { get; set; } = string.Empty;

        /// <summary>
        /// 手机
        /// </summary>
        [Column("modbile")]
        public string modbile { get; set; } = "0";

        /// <summary>
        /// 电话
        /// </summary>
        [Column("phone")]
        public string phone { get; set; } = string.Empty;

        /// <summary>
        /// 经度
        /// </summary>
        [Column("Longitude")]
        public string Longitude { get; set; } = string.Empty;

        /// <summary>
        /// 纬度
        /// </summary>
        [Column("Latitude")]
        public string Latitude { get; set; } = string.Empty;

        /// <summary>
        /// 启用状态（1启用）
        /// </summary>
        [Column("status")]
        public int status { get; set; } = 1;

        /// <summary>
        /// 营业状态
        /// </summary>
        [Column("operating_status")]
        public int operating_status { get; set; }

        /// <summary>
        /// 商品属性
        /// </summary>
        [Column("shop_property")]
        public int shop_property { get; set; }

        /// <summary>
        /// 商场ID
        /// </summary>
        [Column("mall_id")]
        public int mall_id { get; set; }

        /// <summary>
        /// 修改人
        /// </summary>
        [Column("modified_by")]
        public string modified_by { get; set; } = string.Empty;

        /// <summary>
        /// 修改时间
        /// </summary>
        [Column("modified_time")]
        public DateTime modified_time { get; set; } = DateTime.Now;
    }
}