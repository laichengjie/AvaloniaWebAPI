using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AvaloniaWebAPI.Core.Entities
{
    /// <summary>
    /// 组织单元表
    /// </summary>
    [Table("bas_ou")]
    public class bas_ou
    {
        /// <summary>
        /// 组织单元ID（自增主键）
        /// </summary>
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }

        /// <summary>
        /// 集团ID
        /// </summary>
        [Column("group_id")]
        public int? group_id { get; set; }

        /// <summary>
        /// 层级编号
        /// </summary>
        [Column("level_no")]
        public int? level_no { get; set; }

        /// <summary>
        /// 上级组织ID
        /// </summary>
        [Column("ou_parentid")]
        public int? ou_parentid { get; set; }

        /// <summary>
        /// 组织代码
        /// </summary>
        [Column("ou_code")]
        public string? ou_code { get; set; }

        /// <summary>
        /// 组织名称
        /// </summary>
        [Column("ou_name")]
        public string? ou_name { get; set; }

        /// <summary>
        /// 组织全称
        /// </summary>
        [Column("ou_fullname")]
        public string? ou_fullname { get; set; }

        /// <summary>
        /// 外文名称
        /// </summary>
        [Column("foreign_name")]
        public string? foreign_name { get; set; }

        /// <summary>
        /// 全路径ID
        /// </summary>
        [Column("ou_fullpath_id")]
        public string? ou_fullpath_id { get; set; }

        /// <summary>
        /// 全路径名称
        /// </summary>
        [Column("ou_fullpath_name")]
        public string? ou_fullpath_name { get; set; }

        /// <summary>
        /// 助记码
        /// </summary>
        [Column("mnemonic")]
        public string? mnemonic { get; set; }

        /// <summary>
        /// 会计期间方案ID
        /// </summary>
        [Column("acc_scheme_id")]
        public int? acc_scheme_id { get; set; }

        /// <summary>
        /// 会计期间明细ID
        /// </summary>
        [Column("bas_accepterid_content_id")]
        public int? bas_accepterid_content_id { get; set; }

        /// <summary>
        /// 本位币ID
        /// </summary>
        [Column("base_currency_id")]
        public int? base_currency_id { get; set; }

        /// <summary>
        /// 所属公司ID
        /// </summary>
        [Column("company_ou_id")]
        public int? company_ou_id { get; set; }

        /// <summary>
        /// 行政区域ID
        /// </summary>
        [Column("area_id")]
        public int? area_id { get; set; }

        /// <summary>
        /// 联系人
        /// </summary>
        [Column("contact_person")]
        public string? contact_person { get; set; }

        /// <summary>
        /// 地址
        /// </summary>
        [Column("address")]
        public string? address { get; set; }

        /// <summary>
        /// 电话
        /// </summary>
        [Column("phone")]
        public string? phone { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        [Column("remark")]
        public string? remark { get; set; }

        /// <summary>
        /// 启用状态（1启用，0禁用）
        /// </summary>
        [Column("status")]
        public int? status { get; set; } = 1;

        /// <summary>
        /// 有效开始时间（可为空）
        /// </summary>
        [Column("effective_start")]
        public DateTime? effective_start { get; set; }

        /// <summary>
        /// 有效结束时间（可为空）
        /// </summary>
        [Column("effective_end")]
        public DateTime? effective_end { get; set; }

        /// <summary>
        /// 创建人
        /// </summary>
        [Column("created_by")]
        public string? created_by { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [Column("created_time")]
        public DateTime? created_time { get; set; }

        /// <summary>
        /// 修改人
        /// </summary>
        [Column("modified_by")]
        public string? modified_by { get; set; }

        /// <summary>
        /// 修改时间
        /// </summary>
        [Column("modified_time")]
        public DateTime? modified_time { get; set; }

        /// <summary>
        /// 组织性质(字典: OuWorkProperty)
        /// </summary>
        [Column("shop_work_property")]
        public int? shop_work_property { get; set; }

        /// <summary>
        /// 外部公司编码
        /// </summary>
        [Column("ext_company_code")]
        public string? ext_company_code { get; set; }
    }
}