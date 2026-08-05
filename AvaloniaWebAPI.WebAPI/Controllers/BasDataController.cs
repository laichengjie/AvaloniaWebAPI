using AvaloniaWebAPI.Core.Entities;
using AvaloniaWebAPI.Core.Interfaces;
using AvaloniaWebAPI.Service.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
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
        private readonly IBasBrandService _basBrandService;
        public BasDataController(IUserService userService, IMaterialService materialService, ILogger<BasDataController> logger, ISalPromotionService salPromotionService, IBasBrandService basBrandService)
        {
            _userService = userService;
            _materialService = materialService;
            _logger = logger;
            _salPromotionService = salPromotionService;
            _basBrandService = basBrandService;
        }

        

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
                var result = await _salPromotionService.GetSalPromotionsAsync(ModifyDTM);

                _logger.LogInformation($"获取促销活动成功，共 {result.totalCount} 条记录");
                return Ok(new PlatformBasicDataResponse<object>
                {
                    code = 0,
                    msg = "获取促销活动信息成功",
                    resultInfo = result
                });
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "获取促销活动失败");
                return Ok(new PlatformBasicDataResponse<object>
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

                var result = await _userService.GetUsersAsync();

                _logger.LogInformation($"获取用户成功，共 {result.totalCount} 条记录");

                return Ok(new PlatformBasicDataResponse<object>
                {
                    code = 0,
                    msg = "获取用户信息成功",
                    resultInfo = result
                });
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "获取用户失败");
                return Ok(new PlatformBasicDataResponse<object>
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
                    case "GetMaterials":
                        var materialResult = await _materialService.GetMaterialsAsync(request);
                        result = materialResult;
                        totalCount = materialResult?.totalCount ?? 0;
                        break;
                    case "GetBrands":
                        var brandResult = await _basBrandService.GetBrandsAsync(request);
                        result = brandResult;
                        totalCount = brandResult?.totalCount ?? 0;
                        break;
                    default:
                        _logger.LogWarning("未知的DataMethod: {DataMethod}", request.DataMethod);
                        return Ok(new PlatformBasicDataResponse<object>
                        {
                            code = -1,
                            msg = $"不支持的数据类型: {request.DataMethod}",
                            resultInfo = null
                        });
                }

                _logger.LogInformation("获取{DataMethod}成功，共 {TotalCount} 条记录", dataType, totalCount);

                return Ok(new PlatformBasicDataResponse<object>
                {
                    code = 0,
                    msg = $"获取{dataType}成功",
                    resultInfo = result
                });
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "获取{DataMethod}失败，参数: {@Request}", request.DataMethod, request);
                return Ok(new PlatformBasicDataResponse<object>
                {
                    code = -1,
                    msg = $"获取数据失败：{ex.Message}",
                    resultInfo = null
                });
            }
        }






    }

}