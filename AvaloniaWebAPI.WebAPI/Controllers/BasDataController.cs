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
        private readonly IBasCategoryService _basCategoryService;
        private readonly IGetBasicDataService _getBasicDataService;
        public BasDataController(IUserService userService, IMaterialService materialService, ILogger<BasDataController> logger, ISalPromotionService salPromotionService, IBasBrandService basBrandService,
            IBasCategoryService basCategoryService,
            IGetBasicDataService getBasicDataService
            )
        {
            _userService = userService;
            _materialService = materialService;
            _logger = logger;
            _salPromotionService = salPromotionService;
            _basBrandService = basBrandService;
            _basCategoryService = basCategoryService;
            _getBasicDataService = getBasicDataService;
        }


        /// <summary>
        /// 获取平台基础数据（品牌沟通）
        /// </summary>
        [HttpGet("GetAllPlatformBasicData")]
        public async Task<IActionResult> GetAllPlatformBasicData([FromQuery] PlatformBasicDataRequest request)
        {
            try
            {
                _logger.LogInformation("开始获取{DataMethod}，参数: {@Request}", request.DataMethod, request);

                object result = null;
                int totalCount = 0;
                string dataType = request.DataMethod ?? "未知";

                switch (request.DataMethod)
                {
                    case "GetBrand":
                        var brandResult = await _basBrandService.GetBrandsAsync(request);
                        result = brandResult;
                        totalCount = brandResult?.totalCount ?? 0;
                        break;
                    case "GetCategory":
                        //var categoryResult = await _basCategoryService.GetAllCategoriesAsync(request);
                        request.TableName = "bas_category";
                        var categoryResult =  await _getBasicDataService.GetClassAsync<bas_category>(request);
                        result = categoryResult;
                        totalCount = categoryResult?.totalCount ?? 0;
                        break;
                    case "GetClass":
                        request.TableName = "bas_class";
                        var classResult = await _getBasicDataService.GetClassAsync<bas_class>(request);
                        result = classResult;
                        totalCount = classResult?.totalCount ?? 0;
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