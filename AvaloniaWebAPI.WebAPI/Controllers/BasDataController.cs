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
                var materials = await _materialService.GetAllMaterialsAsync(ModifyDTM);

                var materialList = materials.ToList();
                _logger.LogInformation($"获取货号列表成功，共 {materialList.Count} 条记录");
                return Ok(new
                {
                    success = true,
                    message = "获取货号列表成功",
                    data = materialList, // 直接返回对象，避免手动序列化为字符串
                    count = materialList.Count,
                    queryTime = DateTime.Now
                });
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "获取货号列表失败，参数 ModifyDTM: {ModifyDTM}", ModifyDTM);
                return StatusCode(500, new
                {
                    success = false,
                    message = "获取货号列表失败，请稍后重试",
                    error = ex.Message
                });
            }
        }

        #endregion

        #region 促销活动 
        /// <summary> 
        /// 获取所有促销活动
        /// </summary>
        [HttpGet("GetAllSalPromotionsAsync")]
        public async Task<IActionResult> GetAllSalPromotionsAsync(string? ModifyDTM = null)
        {
            try
            {
                _logger.LogInformation($"开始获取促销活动列表，参数 ModifyDTM: {ModifyDTM ?? "null"}");
                var materials = await _salPromotionService.GetAllSalPromotionsAsync(ModifyDTM);

                var materialList = materials.ToList();
                _logger.LogInformation($"获取促销活动列表成功，共 {materialList.Count} 条记录");
                return Ok(new
                {
                    success = true,
                    message = "获取促销活动列表成功",
                    data = materialList, // 直接返回对象，避免手动序列化为字符串
                    count = materialList.Count,
                    queryTime = DateTime.Now
                });
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "获取促销活动列表失败，参数 ModifyDTM: {ModifyDTM}", ModifyDTM);
                return StatusCode(500, new
                {
                    success = false,
                    message = "获取促销活动列表失败，请稍后重试",
                    error = ex.Message
                });
            }
        }
        #endregion

        #region 用户资料
        /// <summary>
        ///获取所有有户
        /// </summary>
        [HttpGet("GetAllUsersAsync")]
        public async Task<IActionResult> GetAllUsersAsync()
        {
            var user = await _userService.GetAllUsersAsync();

            return Ok(new
            {
                success = true,
                message = "获取用户信息成功",
                data = user.ToList(),
            });
        }
        #endregion
    }
}