using AvaloniaWebAPI.Core.Entities;
using AvaloniaWebAPI.Core.Entities.AvaloniaWebAPI.Core.Entities;
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

                object? result = null;
                int totalCount = 0;
                string dataType = request.DataMethod ?? "未知";

                switch (request.DataMethod)
                {
                    // ===== 基础资料 =====
                    case "GetBrand":
                        //var brandResult = await _basBrandService.GetBrandsAsync(request);
                        request.TableName = "bas_brand";
                        var brandResult = await _getBasicDataService.GetBasicDataAsync<bas_brand>(request);
                        result = brandResult;
                        totalCount = brandResult?.totalCount ?? 0;
                        break;

                    case "GetCategory":
                        request.TableName = "bas_category";
                        var categoryResult = await _getBasicDataService.GetBasicDataAsync<bas_category>(request);
                        result = categoryResult;
                        totalCount = categoryResult?.totalCount ?? 0;
                        break;

                    case "GetClass":
                        request.TableName = "bas_class";
                        var classResult = await _getBasicDataService.GetBasicDataAsync<bas_class>(request);
                        result = classResult;
                        totalCount = classResult?.totalCount ?? 0;
                        break;

                    case "GetCounter":
                        request.TableName = "bas_counter";
                        var counterResult = await _getBasicDataService.GetBasicDataAsync<bas_counter>(request);
                        result = counterResult;
                        totalCount = counterResult?.totalCount ?? 0;
                        break;

                    case "GetCounterPrint":
                        request.TableName = "bas_counter_print";
                        var counterPrintResult = await _getBasicDataService.GetBasicDataAsync<bas_counter_print>(request);
                        result = counterPrintResult;
                        totalCount = counterPrintResult?.totalCount ?? 0;
                        break;
                    case "GetCurrency":
                        request.TableName = "bas_currency";
                        var currencyResult = await _getBasicDataService.GetBasicDataAsync<bas_currency>(request);
                        result = currencyResult;
                        totalCount = currencyResult?.totalCount ?? 0;
                        break;

                    case "GetCustomProduct":
                        request.TableName = "bas_custom_product";
                        var customProductResult = await _getBasicDataService.GetBasicDataAsync<bas_custom_product>(request);
                        result = customProductResult;
                        totalCount = customProductResult?.totalCount ?? 0;
                        break;

                    case "GetCustomPropertyValue":
                        request.TableName = "bas_custom_property_value";
                        var customPropertyValueResult = await _getBasicDataService.GetBasicDataAsync<bas_custom_property_value>(request);
                        result = customPropertyValueResult;
                        totalCount = customPropertyValueResult?.totalCount ?? 0;
                        break;

                    case "GetDict":
                        request.TableName = "bas_dict";
                        var dictResult = await _getBasicDataService.GetBasicDataAsync<bas_dict>(request);
                        result = dictResult;
                        totalCount = dictResult?.totalCount ?? 0;
                        break;

                    case "GetDictItem":
                        request.TableName = "bas_dict_item";
                        var dictItemResult = await _getBasicDataService.GetBasicDataAsync<bas_dict_item>(request);
                        result = dictItemResult;
                        totalCount = dictItemResult?.totalCount ?? 0;
                        break;

                    case "GetEmployee":
                        request.TableName = "bas_employee";
                        var employeeResult = await _getBasicDataService.GetBasicDataAsync<bas_employee>(request);
                        result = employeeResult;
                        totalCount = employeeResult?.totalCount ?? 0;
                        break;

                    case "GetEmployeeShop":
                        request.TableName = "bas_employee_shop";
                        var employeeShopResult = await _getBasicDataService.GetBasicDataAsync<bas_employee_shop>(request);
                        result = employeeShopResult;
                        totalCount = employeeShopResult?.totalCount ?? 0;
                        break;

                    case "GetOu":
                        request.TableName = "bas_ou";
                        var ouResult = await _getBasicDataService.GetBasicDataAsync<bas_ou>(request);
                        result = ouResult;
                        totalCount = ouResult?.totalCount ?? 0;
                        break;

                    case "GetPackage":
                        request.TableName = "bas_package";
                        var packageResult = await _getBasicDataService.GetBasicDataAsync<bas_package>(request);
                        result = packageResult;
                        totalCount = packageResult?.totalCount ?? 0;
                        break;

                    case "GetPackageProduct":
                        request.TableName = "bas_packagt_product";
                        var packageProductResult = await _getBasicDataService.GetBasicDataAsync<bas_packagt_product>(request);
                        result = packageProductResult;
                        totalCount = packageProductResult?.totalCount ?? 0;
                        break;

                    case "GetPara":
                        request.TableName = "bas_para";
                        var paraResult = await _getBasicDataService.GetBasicDataAsync<bas_para>(request);
                        result = paraResult;
                        totalCount = paraResult?.totalCount ?? 0;
                        break;

                    case "GetPayment":
                        request.TableName = "bas_payment";
                        var paymentResult = await _getBasicDataService.GetBasicDataAsync<bas_payment>(request);
                        result = paymentResult;
                        totalCount = paymentResult?.totalCount ?? 0;
                        break;

                    case "GetPaymentChannelApply":
                        request.TableName = "bas_payment_channelapply";
                        var paymentChannelResult = await _getBasicDataService.GetBasicDataAsync<bas_payment_channelapply>(request);
                        result = paymentChannelResult;
                        totalCount = paymentChannelResult?.totalCount ?? 0;
                        break;

                    case "GetPaymentOuApply":
                        request.TableName = "bas_payment_ouapply";
                        var paymentOuResult = await _getBasicDataService.GetBasicDataAsync<bas_payment_ouapply>(request);
                        result = paymentOuResult;
                        totalCount = paymentOuResult?.totalCount ?? 0;
                        break;

                    case "GetProduct":
                        request.TableName = "bas_product";
                        var productResult = await _getBasicDataService.GetBasicDataAsync<bas_product>(request);
                        result = productResult;
                        totalCount = productResult?.totalCount ?? 0;
                        break;

                    case "GetProductSpec":
                        request.TableName = "bas_product_spec";
                        var productSpecResult = await _getBasicDataService.GetBasicDataAsync<bas_product_spec>(request);
                        result = productSpecResult;
                        totalCount = productSpecResult?.totalCount ?? 0;
                        break;

                    case "GetProductSpecValue":
                        request.TableName = "bas_product_spec_value";
                        var productSpecValueResult = await _getBasicDataService.GetBasicDataAsync<bas_product_spec_value>(request);
                        result = productSpecValueResult;
                        totalCount = productSpecValueResult?.totalCount ?? 0;
                        break;

                    case "GetProperty":
                        request.TableName = "bas_property";
                        var propertyResult = await _getBasicDataService.GetBasicDataAsync<bas_property>(request);
                        result = propertyResult;
                        totalCount = propertyResult?.totalCount ?? 0;
                        break;

                    case "GetReturnReason":
                        request.TableName = "bas_return_reason";
                        var returnReasonResult = await _getBasicDataService.GetBasicDataAsync<bas_return_reason>(request);
                        result = returnReasonResult;
                        totalCount = returnReasonResult?.totalCount ?? 0;
                        break;

                    case "GetShop":
                        request.TableName = "bas_shop";
                        var shopResult = await _getBasicDataService.GetBasicDataAsync<bas_shop>(request);
                        result = shopResult;
                        totalCount = shopResult?.totalCount ?? 0;
                        break;

                    case "GetShopBrand":
                        request.TableName = "bas_shop_brand";
                        var shopBrandResult = await _getBasicDataService.GetBasicDataAsync<bas_shop_brand>(request);
                        result = shopBrandResult;
                        totalCount = shopBrandResult?.totalCount ?? 0;
                        break;

                    case "GetShopProperty":
                        request.TableName = "bas_shop_property";
                        var shopPropertyResult = await _getBasicDataService.GetBasicDataAsync<bas_shop_property>(request);
                        result = shopPropertyResult;
                        totalCount = shopPropertyResult?.totalCount ?? 0;
                        break;

                    case "GetSku":
                        request.TableName = "bas_sku";
                        var skuResult = await _getBasicDataService.GetBasicDataAsync<bas_sku>(request);
                        result = skuResult;
                        totalCount = skuResult?.totalCount ?? 0;
                        break;

                    case "GetSkuSpecValue":
                        request.TableName = "bas_sku_spec_value";
                        var skuSpecResult = await _getBasicDataService.GetBasicDataAsync<bas_sku_spec_value>(request);
                        result = skuSpecResult;
                        totalCount = skuSpecResult?.totalCount ?? 0;
                        break;

                    case "GetSkuPrice":
                        request.TableName = "bas_skuPrice";
                        var skuPriceResult = await _getBasicDataService.GetBasicDataAsync<bas_skuPrice>(request);
                        result = skuPriceResult;
                        totalCount = skuPriceResult?.totalCount ?? 0;
                        break;

                    case "GetSkuVipPrice":
                        request.TableName = "bas_skuVIPPrice";
                        var skuVipPriceResult = await _getBasicDataService.GetBasicDataAsync<bas_skuVIPPrice>(request);
                        result = skuVipPriceResult;
                        totalCount = skuVipPriceResult?.totalCount ?? 0;
                        break;

                    case "GetSpec":
                        request.TableName = "bas_spec";
                        var specResult = await _getBasicDataService.GetBasicDataAsync<bas_spec>(request);
                        result = specResult;
                        totalCount = specResult?.totalCount ?? 0;
                        break;

                    case "GetSpecValue":
                        request.TableName = "bas_spec_value";
                        var specValueResult = await _getBasicDataService.GetBasicDataAsync<bas_spec_value>(request);
                        result = specValueResult;
                        totalCount = specValueResult?.totalCount ?? 0;
                        break;

                    case "GetSpecGroup":
                        request.TableName = "bas_specgroup";
                        var specGroupResult = await _getBasicDataService.GetBasicDataAsync<bas_specgroup>(request);
                        result = specGroupResult;
                        totalCount = specGroupResult?.totalCount ?? 0;
                        break;

                    case "GetUniqueCode":
                        request.TableName = "bas_unique_code";
                        var uniqueCodeResult = await _getBasicDataService.GetBasicDataAsync<bas_unique_code>(request);
                        result = uniqueCodeResult;
                        totalCount = uniqueCodeResult?.totalCount ?? 0;
                        break;

                    case "GetUser":
                        request.TableName = "scy_user";
                        var userResult = await _getBasicDataService.GetBasicDataAsync<scy_user>(request);
                        result = userResult;
                        totalCount = userResult?.totalCount ?? 0;
                        break;

                    case "GetParaConfig":
                        request.TableName = "bas_para";
                        var paraConfigResult = await _getBasicDataService.GetBasicDataAsync<bas_para_config>(request);
                        result = paraConfigResult;
                        totalCount = paraConfigResult?.totalCount ?? 0;
                        break;

                    case "GetYgouDiscount":
                        request.TableName = "sd_ygou_discount";
                        var ygouDiscountResult = await _getBasicDataService.GetBasicDataAsync<sd_ygou_discount>(request);
                        result = ygouDiscountResult;
                        totalCount = ygouDiscountResult?.totalCount ?? 0;
                        break;

                    case "GetYgouDiscountRole":
                        request.TableName = "sd_ygou_discount_role";
                        var ygouDiscountRoleResult = await _getBasicDataService.GetBasicDataAsync<sd_ygou_discount_role>(request);
                        result = ygouDiscountRoleResult;
                        totalCount = ygouDiscountRoleResult?.totalCount ?? 0;
                        break;

                    case "GetOpArea":
                        request.TableName = "bas_op_area";
                        var opAreaResult = await _getBasicDataService.GetBasicDataAsync<bas_op_area>(request);
                        result = opAreaResult;
                        totalCount = opAreaResult?.totalCount ?? 0;
                        break;

                    case "GetBundleAct":
                        request.TableName = "mc_bundle_act";
                        var bundleActResult = await _getBasicDataService.GetBasicDataAsync<mc_bundle_act>(request);
                        result = bundleActResult;
                        totalCount = bundleActResult?.totalCount ?? 0;
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