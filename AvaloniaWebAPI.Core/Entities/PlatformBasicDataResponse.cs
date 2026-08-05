namespace AvaloniaWebAPI.Core.Entities
{
    /// <summary>
    /// 统一 API 响应格式（泛型）
    /// </summary>
    public class PlatformBasicDataResponse<T>
    {
        /// <summary>
        /// 状态码：0=成功，其他=失败
        /// </summary>
        public int code { get; set; } = 0;

        /// <summary>
        /// 消息
        /// </summary>
        public string msg { get; set; } = "success";

        /// <summary>
        /// 返回数据
        /// </summary>
        public T? resultInfo { get; set; }
    }
     
    /// <summary>
    /// 统一 API 响应格式（非泛型）
    /// </summary>
    public class PlatformBasicDataResponse
    {
        /// <summary>
        /// 状态码：0=成功，其他=失败
        /// </summary>
        public int code { get; set; } = 0;

        /// <summary>
        /// 消息
        /// </summary>
        public string msg { get; set; } = "success";

        /// <summary>
        /// 返回数据
        /// </summary>
        public object? resultInfo { get; set; }
    }
   
}