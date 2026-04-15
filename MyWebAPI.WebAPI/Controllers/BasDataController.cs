using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MyWebAPI.Core.Entities;
using MyWebAPI.Core.Interfaces;
using System.Security.Claims;
using System.Text.Json;

namespace MyWebAPI.WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    //[Authorize]
    public class BasDataController : ControllerBase
    {
        private readonly IUserService _userService;
        private readonly IMaterialService _materialService;
        private readonly ILogger<BasDataController> _logger;
        public BasDataController(IUserService userService, IMaterialService materialService, ILogger<BasDataController> logger)
        {
            _userService = userService;
            _materialService = materialService;
            _logger = logger;
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

        /// <summary>
        /// 根据ID获取货号
        /// </summary>
        [HttpGet("GetMaterialById")]
        public async Task<IActionResult> GetMaterialById(string materialId)
        {
            try
            {
                var material = await _materialService.GetMaterialByIdAsync(materialId);
                if (material == null)
                {
                    return NotFound(new { success = false, message = $"货号不存在: {materialId}" });
                }

                return Ok(new
                {
                    success = true,
                    message = "获取货号成功",
                    data = material
                });
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "获取货号失败");
                return StatusCode(500, new { success = false, message = ex.Message });
            }
        }

        /// <summary>
        /// 分页查询货号
        /// </summary>
        [HttpGet("GetPagedMaterials")]
        public async Task<IActionResult> GetPagedMaterials(
            [FromQuery] int page = 1,
            [FromQuery] int pageSize = 20,
            [FromQuery] string? searchKey = null,
            [FromQuery] int? yearNo = null,
            [FromQuery] string? seasonId = null,
            [FromQuery] bool? proAllowUsed = null)
        {
            try
            {
                var (items, total) = await _materialService.GetPagedMaterialsAsync(
                    page, pageSize, searchKey, yearNo, seasonId, proAllowUsed);

                return Ok(new
                {
                    success = true,
                    message = "查询成功",
                    data = items,
                    pagination = new
                    {
                        page,
                        pageSize,
                        total,
                        totalPages = (int)Math.Ceiling(total / (double)pageSize)
                    }
                });
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "分页查询失败");
                return StatusCode(500, new { success = false, message = ex.Message });
            }
        }

        /// <summary>
        /// 根据货号编码查询
        /// </summary>
        [HttpGet("GetMaterialsByCode")]
        public async Task<IActionResult> GetMaterialsByCode(string materialCode)
        {
            try
            {
                var materials = await _materialService.GetMaterialsByCodeAsync(materialCode);
                return Ok(new
                {
                    success = true,
                    message = "查询成功",
                    data = materials,
                    count = materials.Count()
                });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { success = false, message = ex.Message });
            }
        }

        /// <summary>
        /// 根据货号名称查询
        /// </summary>
        [HttpGet("GetMaterialsByName")]
        public async Task<IActionResult> GetMaterialsByName(string materialName)
        {
            try
            {
                var materials = await _materialService.GetMaterialsByNameAsync(materialName);
                return Ok(new
                {
                    success = true,
                    message = "查询成功",
                    data = materials,
                    count = materials.Count()
                });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { success = false, message = ex.Message });
            }
        }
        /// <summary>
        /// 创建货号
        /// </summary>
        [HttpPost]
        public async Task<IActionResult> CreateMaterial([FromBody] SD_Mat_Material material)
        {
            try
            {
                if (string.IsNullOrEmpty(material.MaterialID))
                {
                    return BadRequest(new { success = false, message = "MaterialID 不能为空" });
                }

                var created = await _materialService.CreateMaterialAsync(material);
                return Ok(new
                {
                    success = true,
                    message = "创建货号成功",
                    data = created
                });
            }
            catch (InvalidOperationException ex)
            {
                return Conflict(new { success = false, message = ex.Message });
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "创建货号失败");
                return StatusCode(500, new { success = false, message = ex.Message });
            }
        }

        /// <summary>
        /// 更新货号
        /// </summary>
        [HttpPut]
        public async Task<IActionResult> UpdateMaterial([FromBody] SD_Mat_Material material)
        {
            try
            {
                await _materialService.UpdateMaterialAsync(material);
                return Ok(new
                {
                    success = true,
                    message = "更新货号成功"
                });
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "更新货号失败");
                return StatusCode(500, new { success = false, message = ex.Message });
            }
        }

        /// <summary>
        /// 删除货号
        /// </summary>
        [HttpDelete("DeleteMaterial")]
        public async Task<IActionResult> DeleteMaterial(string materialId)
        {
            try
            {
                var exists = await _materialService.MaterialExistsAsync(materialId);
                if (!exists)
                {
                    return NotFound(new { success = false, message = $"货号不存在: {materialId}" });
                }

                await _materialService.DeleteMaterialAsync(materialId);
                return Ok(new
                {
                    success = true,
                    message = "删除货号成功"
                });
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "删除货号失败");
                return StatusCode(500, new { success = false, message = ex.Message });
            }
        }

        /// <summary>
        /// 获取货号总数
        /// </summary>
        [HttpGet("GetMaterialsCountAsync")]
        public async Task<IActionResult> GetMaterialsCountAsync()
        {
            try
            {
                var count = await _materialService.GetMaterialsCountAsync();
                return Ok(new
                {
                    success = true,
                    message = "获取总数成功",
                    count = count
                });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { success = false, message = ex.Message });
            }
        }

        /// <summary>
        /// 测试接口
        /// </summary>
        [HttpGet("GetTest")]
        public IActionResult GetTest()
        {
            return Ok(new
            {
                success = true,
                message = "Material API 测试成功",
                code = 200,
                timestamp = DateTime.Now
            });
        }


        #endregion




        /// <summary>
        /// 根据ID获取当个用户 
        /// </summary>
        [HttpGet("GetUserByIdAsync")]
        public async Task<IActionResult> GetUserByIdAsync()
        {
            var user = await _userService.GetUserByIdAsync("000");

            if (user == null)
            {
                return NotFound(new { message = "用户不存在" });
            }
            return Ok(new
            {
                success = true,
                message = "获取用户信息成功",
                data = new
                {
                    userId = user.UserID,
                    userCode = user.UserCode,
                    userName = user.UserName,
                    companyId = user.CompanyID,
                    personnelId = user.PersonnelID,
                    authType = user.AuthType,
                    allowUsed = user.AllowUsed,
                    adAccount = user.ADAccount,
                    userNote = user.UserNote,
                    ableTime = user.AbleTime,
                    disableTime = user.DisableTime,
                    isInit = user.IsInit,
                    modifyDTM = user.ModifyDTM,
                    modifyPwdDTM = user.ModifyPwdDTM
                }
            });
        }

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
    }
}