namespace AvaloniaWebAPI.Core.Entities
{
    /// <summary>
    /// 分页响应数据
    /// </summary>
    public class PlatformBasicDataResult<T>
    {
        /// <summary> 
        /// 数据列表
        /// </summary>
        public List<T> items { get; set; } = new List<T>();

        /// <summary>
        /// 总记录数
        /// </summary>
        public int totalCount { get; set; }

        /// <summary>
        /// 查询时间
        /// </summary>
        public DateTime? queryTime { get; set; }
    }
}