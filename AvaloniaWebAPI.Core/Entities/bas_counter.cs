using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AvaloniaWebAPI.Core.Entities
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    namespace AvaloniaWebAPI.Core.Entities
    {
        /// <summary>
        /// 收银台基础资料表
        /// </summary>
        [Table("bas_counter")]
        public class bas_counter
        {
            /// <summary>
            /// 收银台ID（主键）
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
            /// 店铺ID
            /// </summary>
            [Column("shop_id")]
            public int shop_id { get; set; }

            /// <summary>
            /// 收银台编码
            /// </summary>
            [Column("counter_code")]
            public string counter_code { get; set; } = string.Empty;

            /// <summary>
            /// 收银台名称
            /// </summary>
            [Column("counter_name")]
            public string counter_name { get; set; } = string.Empty;

            /// <summary>
            /// 收银台地址
            /// </summary>
            [Column("terminal_address")]
            public string terminal_address { get; set; } = string.Empty;

            /// <summary>
            /// 终端号
            /// </summary>
            [Column("terminal_no")]
            public string terminal_no { get; set; } = string.Empty;

            /// <summary>
            /// 票据打印模板id
            /// </summary>
            [Column("ticket_template_id")]
            public int ticket_template_id { get; set; }

            /// <summary>
            /// 票据打印数量
            /// </summary>
            [Column("ticket_printing_number")]
            public int ticket_printing_number { get; set; }

            /// <summary>
            /// 商品显示方式(1 列表显示 2 卡片显示)
            /// </summary>
            [Column("product_display_mode")]
            public int product_display_mode { get; set; } = 1;

            /// <summary>
            /// 启用自定义查询
            /// </summary>
            [Column("custom_query_enabled")]
            public int custom_query_enabled { get; set; }

            /// <summary>
            /// 是否默认
            /// </summary>
            [Column("is_default")]
            public int is_default { get; set; }

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
            /// 客显型号(字典：BAS_CustomerModel)
            /// </summary>
            [Column("customer_model")]
            public int customer_model { get; set; }

            /// <summary>
            /// 客显端口(字典：BAS_CustomerPort)
            /// </summary>
            [Column("customer_port")]
            public int customer_port { get; set; }

            /// <summary>
            /// 打印机型号(字典：BAS_PrinterModel)
            /// </summary>
            [Column("printer_model")]
            public int printer_model { get; set; }

            /// <summary>
            /// 打印机端口号（1.COM1  2. COM2  3. COM3  4.COM4）
            /// </summary>
            [Column("print_port")]
            public int print_port { get; set; }

            /// <summary>
            /// 发票打印模板id
            /// </summary>
            [Column("invoice_template_id")]
            public int invoice_template_id { get; set; }

            /// <summary>
            /// 发票本ID
            /// </summary>
            [Column("invoice_book")]
            public int invoice_book { get; set; }

            /// <summary>
            /// 发票字轨
            /// </summary>
            [Column("invoice_track")]
            public string invoice_track { get; set; } = string.Empty;

            /// <summary>
            /// 开始号码
            /// </summary>
            [Column("start_number")]
            public string start_number { get; set; } = string.Empty;

            /// <summary>
            /// 结束号码
            /// </summary>
            [Column("end_number")]
            public string end_number { get; set; } = string.Empty;

            /// <summary>
            /// 使用期别(申报期别ID)
            /// </summary>
            [Column("declaration_period_id")]
            public int declaration_period_id { get; set; }

            /// <summary>
            /// 通联扫码终端号
            /// </summary>
            [Column("allinpay_terminal_number")]
            public string allinpay_terminal_number { get; set; } = string.Empty;

            /// <summary>
            /// 启用钱箱
            /// </summary>
            [Column("cash_box_enabled")]
            public int cash_box_enabled { get; set; }

            /// <summary>
            /// 钱箱端口
            /// </summary>
            [Column("cash_box_prot")]
            public string cash_box_prot { get; set; } = string.Empty;

            /// <summary>
            /// 结算自动开钱箱
            /// </summary>
            [Column("is_open_cash_box")]
            public int is_open_cash_box { get; set; }

            /// <summary>
            /// 刷卡机型号（字典：BAS_CardMachineModel）
            /// </summary>
            [Column("card_machine_model")]
            public int card_machine_model { get; set; }

            /// <summary>
            /// 刷卡机连接端口（字典：BAS_CardMachinePort）
            /// </summary>
            [Column("card_machine_port")]
            public int card_machine_port { get; set; }

            /// <summary>
            /// 收银台类型(字典：BAS_CounterType)
            /// </summary>
            [Column("counter_type")]
            public int counter_type { get; set; }

            /// <summary>
            /// 小票打印机
            /// </summary>
            [Column("small_ticket_printer")]
            public string small_ticket_printer { get; set; } = string.Empty;

            /// <summary>
            /// 发票明细连打模板id
            /// </summary>
            [Column("invoice_detail_template_id")]
            public int invoice_detail_template_id { get; set; }

            /// <summary>
            /// 明细联模板id
            /// </summary>
            [Column("detail_template_id")]
            public int detail_template_id { get; set; }

            /// <summary>
            /// 发票联打模板id
            /// </summary>
            [Column("invoice_link_template_id")]
            public int invoice_link_template_id { get; set; }

            /// <summary>
            /// 改成样式设置(字典：SD_StyleSetting)
            /// </summary>
            [Column("style_setting")]
            public int style_setting { get; set; }

            /// <summary>
            /// 出餐打印机
            /// </summary>
            [Column("foor_ticket_printer")]
            public string foor_ticket_printer { get; set; } = string.Empty;

            /// <summary>
            /// 出餐打印模板id
            /// </summary>
            [Column("foor_template_id")]
            public int foor_template_id { get; set; }

            /// <summary>
            /// 出餐打印数量
            /// </summary>
            [Column("foor_printing_number")]
            public int foor_printing_number { get; set; }

            /// <summary>
            /// 出餐打印尺码
            /// </summary>
            [Column("foor_printing_size")]
            public string foor_printing_size { get; set; } = string.Empty;

            /// <summary>
            /// POS 机分店号
            /// </summary>
            [Column("pos_branch_no")]
            public string pos_branch_no { get; set; } = string.Empty;

            /// <summary>
            /// POS 机款台号
            /// </summary>
            [Column("pos_terminal_no")]
            public string pos_terminal_no { get; set; } = string.Empty;

            /// <summary>
            /// POS 统计-打印模板id
            /// </summary>
            [Column("pos_stat_template_id")]
            public int pos_stat_template_id { get; set; }

            /// <summary>
            /// POS 统计-打印机
            /// </summary>
            [Column("pos_stat_ticket_printer")]
            public string pos_stat_ticket_printer { get; set; } = string.Empty;

            /// <summary>
            /// POS统计-打印份数
            /// </summary>
            [Column("pos_stat_print_count")]
            public int pos_stat_print_count { get; set; }

            /// <summary>
            /// rfid端口
            /// </summary>
            [Column("rfid_terminal_number")]
            public string rfid_terminal_number { get; set; } = string.Empty;

            /// <summary>
            /// rfid波特率序号(字典：SD_BaudRateSerialNumber)
            /// </summary>
            [Column("baud_rate_serial_number")]
            public int baud_rate_serial_number { get; set; }

            /// <summary>
            /// 汇来米扫码终端号
            /// </summary>
            [Column("hlm_terminal_number")]
            public string hlm_terminal_number { get; set; } = string.Empty;

            /// <summary>
            /// POS 挂单-打印模板id
            /// </summary>
            [Column("pos_cache_template_id")]
            public int pos_cache_template_id { get; set; }

            /// <summary>
            /// POS 挂单-打印机
            /// </summary>
            [Column("pos_cache_ticket_printer")]
            public string pos_cache_ticket_printer { get; set; } = string.Empty;

            /// <summary>
            /// POS 挂单-打印份数
            /// </summary>
            [Column("pos_cache_print_count")]
            public int pos_cache_print_count { get; set; }

            /// <summary>
            /// 预收单开立-打印模板id
            /// </summary>
            [Column("prereceipt_template_id")]
            public int prereceipt_template_id { get; set; }

            /// <summary>
            /// 预收单开立-打印机
            /// </summary>
            [Column("prereceipt_ticket_printer")]
            public string prereceipt_ticket_printer { get; set; } = string.Empty;

            /// <summary>
            /// 预收单开立-打印份数
            /// </summary>
            [Column("prereceipt_print_count")]
            public int prereceipt_print_count { get; set; }

            /// <summary>
            /// 预售单提货-打印模板id
            /// </summary>
            [Column("pickup_template_id")]
            public int pickup_template_id { get; set; }

            /// <summary>
            /// 预售单提货-打印机
            /// </summary>
            [Column("pickup_ticket_printer")]
            public string pickup_ticket_printer { get; set; } = string.Empty;

            /// <summary>
            /// 预售单提货-打印份数
            /// </summary>
            [Column("pickup_print_count")]
            public int pickup_print_count { get; set; }

            /// <summary>
            /// 次卡使用-打印模板id
            /// </summary>
            [Column("svrproduct_template_id")]
            public int svrproduct_template_id { get; set; }

            /// <summary>
            /// 次卡使用-打印机
            /// </summary>
            [Column("svrproduct_ticket_printer")]
            public string svrproduct_ticket_printer { get; set; } = string.Empty;

            /// <summary>
            /// 次卡使用-打印份数
            /// </summary>
            [Column("svrproduct_print_count")]
            public int svrproduct_print_count { get; set; }

            /// <summary>
            /// POS保证金-打印模板id
            /// </summary>
            [Column("margin_template_id")]
            public int margin_template_id { get; set; }

            /// <summary>
            /// POS保证金-打印份数
            /// </summary>
            [Column("margin_print_count")]
            public int margin_print_count { get; set; }

            /// <summary>
            /// 自动选择促销
            /// </summary>
            [Column("is_auto_act")]
            public int is_auto_act { get; set; }
        }
    }
}




