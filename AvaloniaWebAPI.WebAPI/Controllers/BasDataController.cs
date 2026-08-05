using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using AvaloniaWebAPI.Core.Entities;
using AvaloniaWebAPI.Core.Interfaces;
using System.Security.Claims;
using System.Text.Json;

namespace AvaloniaWebAPI.WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    //[Authorize] 
    public class BasDataController : ControllerBase
    {
        private readonly IUserService _userService;
        private readonly IMaterialService _materialService;
        private readonly ISalPromotionService _salPromotionService;
        private readonly ILogger<BasDataController> _logger;
        public BasDataController(IUserService userService, IMaterialService materialService, ILogger<BasDataController> logger, ISalPromotionService salPromotionService)
        {
            _userService = userService;
            _materialService = materialService;
            _logger = logger;
            _salPromotionService = salPromotionService;
        }

        #region 货品资料
        /// <summary> 
        /// 获取所有货号
        /// </summary>
        [HttpGet("GetAllMaterials")]
        public async Task<IActionResult> GetAllMaterials(string? ModifyDTM = null)
        {
            try
            {
                _logger.LogInformation($"开始获取货号列表，参数 ModifyDTM: {ModifyDTM ?? "null"}");

                // 获取已构造好的分页结果
                var result = await _materialService.GetAllMaterialsAsync(ModifyDTM);

                _logger.LogInformation($"获取货号列表成功，共 {result.totalCount} 条记录");

                return Ok(new ApiResponse<object>
                {
                    code = 0,
                    msg = "获取货号列表成功",
                    resultInfo = result
                });
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "获取货号列表失败，参数 ModifyDTM: {ModifyDTM}", ModifyDTM);
                return Ok(new ApiResponse<object>
                {
                    code = -1,
                    msg = $"获取货号列表失败：{ex.Message}",
                    resultInfo = null
                });
            }
        }

        #endregion

        #region 促销活动

        /// <summary> 
        /// 获取所有促销活动
        /// </summary>
        [HttpGet("GetAllSalPromotions")]
        public async Task<IActionResult> GetAllSalPromotions(string? ModifyDTM = null)
        {
            try
            {
                _logger.LogInformation($"开始获取促销活动列表，参数 ModifyDTM: {ModifyDTM ?? "null"}");

                // 获取促销活动数据
                var result = await _salPromotionService.GetAllSalPromotionsAsync(ModifyDTM);

                _logger.LogInformation($"获取促销活动成功，共 {result.totalCount} 条记录");
                return Ok(new ApiResponse<object>
                {
                    code = 0,
                    msg = "获取促销活动信息成功",
                    resultInfo = result
                });
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "获取促销活动失败");
                return Ok(new ApiResponse<object>
                {
                    code = -1,
                    msg = $"获取用户失败：{ex.Message}",
                    resultInfo = null
                });
            }
        }

        #endregion

        #region 用户资料

        /// <summary>
        /// 获取所有用户
        /// </summary>
        [HttpGet("GetAllUsers")]
        public async Task<IActionResult> GetAllUsers()
        {
            try
            {
                _logger.LogInformation("开始获取所有用户");

                var result = await _userService.GetAllUsersAsync();

                _logger.LogInformation($"获取用户成功，共 {result.totalCount} 条记录");

                return Ok(new ApiResponse<object>
                {
                    code = 0,
                    msg = "获取用户信息成功",
                    resultInfo = result
                });
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "获取用户失败");
                return Ok(new ApiResponse<object>
                {
                    code = -1,
                    msg = $"获取用户失败：{ex.Message}",
                    resultInfo = null
                });
            }
        }

        #endregion

        /// <summary>
        /// 获取平台基础数据（品牌沟通）
        /// </summary>
        [HttpPost("GetAllPlatformBasicData")]
        public async Task<IActionResult> GetAllPlatformBasicData([FromBody] PlatformBasicDataRequest request)
        {
            try
            {
                _logger.LogInformation("开始获取{DataMethod}，参数: {@Request}", request.DataMethod, request);

                object result = null;
                int totalCount = 0;
                string dataType = request.DataMethod ?? "未知";

                switch (request.DataMethod)
                {
                    case "GetAllMaterials":
                        var materialResult = await _materialService.GetAllMaterialsAsync(request);
                        result = materialResult;
                        totalCount = materialResult?.totalCount ?? 0;
                        break;
                    default:
                        _logger.LogWarning("未知的DataMethod: {DataMethod}", request.DataMethod);
                        return Ok(new ApiResponse<object>
                        {
                            code = -1,
                            msg = $"不支持的数据类型: {request.DataMethod}",
                            resultInfo = null
                        });
                }

                _logger.LogInformation("获取{DataMethod}成功，共 {TotalCount} 条记录", dataType, totalCount);

                return Ok(new ApiResponse<object>
                {
                    code = 0,
                    msg = $"获取{dataType}成功",
                    resultInfo = result
                });
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "获取{DataMethod}失败，参数: {@Request}", request.DataMethod, request);
                return Ok(new ApiResponse<object>
                {
                    code = -1,
                    msg = $"获取数据失败：{ex.Message}",
                    resultInfo = null
                });
            }
        }






    }

}