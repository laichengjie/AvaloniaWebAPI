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

                    // ===== 捆绑促销活动 =====
                    case "GetBundleAct":
                        request.TableName = "mc_bundle_act";
                        var bundleActResult = await _getBasicDataService.GetBasicDataAsync<mc_bundle_act>(request);
                        result = bundleActResult;
                        totalCount = bundleActResult?.totalCount ?? 0;
                        break;
                    case "GetBundleActCoupon":
                        request.TableName = "mc_bundle_act_coupon";
                        var bundleActCouponResult = await _getBasicDataService.GetBasicDataAsync<mc_bundle_act_coupon>(request);
                        result = bundleActCouponResult;
                        totalCount = bundleActCouponResult?.totalCount ?? 0;
                        break;
                    case "GetBundleActDiscount":
                        request.TableName = "mc_bundle_act_discount";
                        var bundleActDiscountResult = await _getBasicDataService.GetBasicDataAsync<mc_bundle_act_discount>(request);
                        result = bundleActDiscountResult;
                        totalCount = bundleActDiscountResult?.totalCount ?? 0;
                        break;
                    case "GetBundleActExch":
                        request.TableName = "mc_bundle_act_exch";
                        var bundleActExchResult = await _getBasicDataService.GetBasicDataAsync<mc_bundle_act_exch>(request);
                        result = bundleActExchResult;
                        totalCount = bundleActExchResult?.totalCount ?? 0;
                        break;
                    case "GetBundleActExchProduct":
                        request.TableName = "mc_bundle_act_exch_product";
                        var bundleActExchProductResult = await _getBasicDataService.GetBasicDataAsync<mc_bundle_act_exch_product>(request);
                        result = bundleActExchProductResult;
                        totalCount = bundleActExchProductResult?.totalCount ?? 0;
                        break;
                    case "GetBundleActGradedPromoPgroup":
                        request.TableName = "mc_bundle_act_graded_promo_pgroup";
                        var bundleActGradedPromoPgroupResult = await _getBasicDataService.GetBasicDataAsync<mc_bundle_act_graded_promo_pgroup>(request);
                        result = bundleActGradedPromoPgroupResult;
                        totalCount = bundleActGradedPromoPgroupResult?.totalCount ?? 0;
                        break;
                    case "GetBundleActGradedPromo":
                        request.TableName = "mc_bundle_act_graded_promo";
                        var bundleActGradedPromoResult = await _getBasicDataService.GetBasicDataAsync<mc_bundle_act_graded_promo>(request);
                        result = bundleActGradedPromoResult;
                        totalCount = bundleActGradedPromoResult?.totalCount ?? 0;
                        break;
                    case "GetBundleActArea":
                        request.TableName = "mc_bundle_act_area";
                        var bundleActAreaResult = await _getBasicDataService.GetBasicDataAsync<mc_bundle_act_area>(request);
                        result = bundleActAreaResult;
                        totalCount = bundleActAreaResult?.totalCount ?? 0;
                        break;
                    case "GetBundleActMember":
                        request.TableName = "mc_bundle_act_member";
                        var bundleActMemberResult = await _getBasicDataService.GetBasicDataAsync<mc_bundle_act_member>(request);
                        result = bundleActMemberResult;
                        totalCount = bundleActMemberResult?.totalCount ?? 0;
                        break;
                    case "GetBundleActMemberGrade":
                        request.TableName = "mc_bundle_act_member_grade";
                        var bundleActMemberGradeResult = await _getBasicDataService.GetBasicDataAsync<mc_bundle_act_member_grade>(request);
                        result = bundleActMemberGradeResult;
                        totalCount = bundleActMemberGradeResult?.totalCount ?? 0;
                        break;
                    case "GetBundleActPgroup":
                        request.TableName = "mc_bundle_act_pgroup";
                        var bundleActPgroupResult = await _getBasicDataService.GetBasicDataAsync<mc_bundle_act_pgroup>(request);
                        result = bundleActPgroupResult;
                        totalCount = bundleActPgroupResult?.totalCount ?? 0;
                        break;
                    case "GetBundleActPresentValue":
                        request.TableName = "mc_bundle_act_present_value";
                        var bundleActPresentValueResult = await _getBasicDataService.GetBasicDataAsync<mc_bundle_act_present_value>(request);
                        result = bundleActPresentValueResult;
                        totalCount = bundleActPresentValueResult?.totalCount ?? 0;
                        break;
                    case "GetBundleActProduct":
                        request.TableName = "mc_bundle_act_product";
                        var bundleActProductResult = await _getBasicDataService.GetBasicDataAsync<mc_bundle_act_product>(request);
                        result = bundleActProductResult;
                        totalCount = bundleActProductResult?.totalCount ?? 0;
                        break;
                    case "GetBundleActRepeat":
                        request.TableName = "mc_bundle_act_repeat";
                        var bundleActRepeatResult = await _getBasicDataService.GetBasicDataAsync<mc_bundle_act_repeat>(request);
                        result = bundleActRepeatResult;
                        totalCount = bundleActRepeatResult?.totalCount ?? 0;
                        break;
                    case "GetBundleActShop":
                        request.TableName = "mc_bundle_act_shop";
                        var bundleActShopResult = await _getBasicDataService.GetBasicDataAsync<mc_bundle_act_shop>(request);
                        result = bundleActShopResult;
                        totalCount = bundleActShopResult?.totalCount ?? 0;
                        break;

                    // ===== 通用活动 =====
                    case "GetGeneralAct":
                        request.TableName = "mc_general_act";
                        var generalActResult = await _getBasicDataService.GetBasicDataAsync<mc_general_act>(request);
                        result = generalActResult;
                        totalCount = generalActResult?.totalCount ?? 0;
                        break;
                    case "GetGeneralActArea":
                        request.TableName = "mc_general_act_area";
                        var generalActAreaResult = await _getBasicDataService.GetBasicDataAsync<mc_general_act_area>(request);
                        result = generalActAreaResult;
                        totalCount = generalActAreaResult?.totalCount ?? 0;
                        break;
                    case "GetGeneralActCoupon":
                        request.TableName = "mc_general_act_coupon";
                        var generalActCouponResult = await _getBasicDataService.GetBasicDataAsync<mc_general_act_coupon>(request);
                        result = generalActCouponResult;
                        totalCount = generalActCouponResult?.totalCount ?? 0;
                        break;
                    case "GetGeneralActExch":
                        request.TableName = "mc_general_act_exch";
                        var generalActExchResult = await _getBasicDataService.GetBasicDataAsync<mc_general_act_exch>(request);
                        result = generalActExchResult;
                        totalCount = generalActExchResult?.totalCount ?? 0;
                        break;
                    case "GetGeneralActExchPgroup":
                        request.TableName = "mc_general_act_exch_pgroup";
                        var generalActExchPgroupResult = await _getBasicDataService.GetBasicDataAsync<mc_general_act_exch_pgroup>(request);
                        result = generalActExchPgroupResult;
                        totalCount = generalActExchPgroupResult?.totalCount ?? 0;
                        break;
                    case "GetGeneralActExchProduct":
                        request.TableName = "mc_general_act_exch_product";
                        var generalActExchProductResult = await _getBasicDataService.GetBasicDataAsync<mc_general_act_exch_product>(request);
                        result = generalActExchProductResult;
                        totalCount = generalActExchProductResult?.totalCount ?? 0;
                        break;
                    case "GetGeneralActMember":
                        request.TableName = "mc_general_act_member";
                        var generalActMemberResult = await _getBasicDataService.GetBasicDataAsync<mc_general_act_member>(request);
                        result = generalActMemberResult;
                        totalCount = generalActMemberResult?.totalCount ?? 0;
                        break;
                    case "GetGeneralActMemberGrade":
                        request.TableName = "mc_general_act_member_grade";
                        var generalActMemberGradeResult = await _getBasicDataService.GetBasicDataAsync<mc_general_act_member_grade>(request);
                        result = generalActMemberGradeResult;
                        totalCount = generalActMemberGradeResult?.totalCount ?? 0;
                        break;
                    case "GetGeneralActProduct":
                        request.TableName = "mc_general_act_product";
                        var generalActProductResult = await _getBasicDataService.GetBasicDataAsync<mc_general_act_product>(request);
                        result = generalActProductResult;
                        totalCount = generalActProductResult?.totalCount ?? 0;
                        break;
                    case "GetGeneralActRepeat":
                        request.TableName = "mc_general_act_repeat";
                        var generalActRepeatResult = await _getBasicDataService.GetBasicDataAsync<mc_general_act_repeat>(request);
                        result = generalActRepeatResult;
                        totalCount = generalActRepeatResult?.totalCount ?? 0;
                        break;
                    case "GetGeneralActShop":
                        request.TableName = "mc_general_act_shop";
                        var generalActShopResult = await _getBasicDataService.GetBasicDataAsync<mc_general_act_shop>(request);
                        result = generalActShopResult;
                        totalCount = generalActShopResult?.totalCount ?? 0;
                        break;

                    // ===== 联赠促销活动 =====
                    case "GetJointGiftAct":
                        request.TableName = "mc_joint_gift_act";
                        var jointGiftActResult = await _getBasicDataService.GetBasicDataAsync<mc_joint_gift_act>(request);
                        result = jointGiftActResult;
                        totalCount = jointGiftActResult?.totalCount ?? 0;
                        break;
                    case "GetJointGiftActCoupon":
                        request.TableName = "mc_joint_gift_act_coupon";
                        var jointGiftActCouponResult = await _getBasicDataService.GetBasicDataAsync<mc_joint_gift_act_coupon>(request);
                        result = jointGiftActCouponResult;
                        totalCount = jointGiftActCouponResult?.totalCount ?? 0;
                        break;
                    case "GetJointGiftActMember":
                        request.TableName = "mc_joint_gift_act_member";
                        var jointGiftActMemberResult = await _getBasicDataService.GetBasicDataAsync<mc_joint_gift_act_member>(request);
                        result = jointGiftActMemberResult;
                        totalCount = jointGiftActMemberResult?.totalCount ?? 0;
                        break;
                    case "GetJointGiftActShopArea":
                        request.TableName = "mc_joint_gift_act_shop_area";
                        var jointGiftActShopAreaResult = await _getBasicDataService.GetBasicDataAsync<mc_joint_gift_act_shop_area>(request);
                        result = jointGiftActShopAreaResult;
                        totalCount = jointGiftActShopAreaResult?.totalCount ?? 0;
                        break;
                    case "GetJointGiftActMemberGrade":
                        request.TableName = "mc_joint_gift_act_member_grade";
                        var jointGiftActMemberGradeResult = await _getBasicDataService.GetBasicDataAsync<mc_joint_gift_act_member_grade>(request);
                        result = jointGiftActMemberGradeResult;
                        totalCount = jointGiftActMemberGradeResult?.totalCount ?? 0;
                        break;
                    case "GetJointGiftActRepeat":
                        request.TableName = "mc_joint_gift_act_repeat";
                        var jointGiftActRepeatResult = await _getBasicDataService.GetBasicDataAsync<mc_joint_gift_act_repeat>(request);
                        result = jointGiftActRepeatResult;
                        totalCount = jointGiftActRepeatResult?.totalCount ?? 0;
                        break;
                    case "GetJointGiftActShop":
                        request.TableName = "mc_joint_gift_act_shop";
                        var jointGiftActShopResult = await _getBasicDataService.GetBasicDataAsync<mc_joint_gift_act_shop>(request);
                        result = jointGiftActShopResult;
                        totalCount = jointGiftActShopResult?.totalCount ?? 0;
                        break;

                    // ===== 整单促销活动 =====
                    case "GetWholeAct":
                        request.TableName = "mc_whole_act";
                        var wholeActResult = await _getBasicDataService.GetBasicDataAsync<mc_whole_act>(request);
                        result = wholeActResult;
                        totalCount = wholeActResult?.totalCount ?? 0;
                        break;
                    case "GetWholeActArea":
                        request.TableName = "mc_whole_act_area";
                        var wholeActAreaResult = await _getBasicDataService.GetBasicDataAsync<mc_whole_act_area>(request);
                        result = wholeActAreaResult;
                        totalCount = wholeActAreaResult?.totalCount ?? 0;
                        break;
                    case "GetWholeActConfig":
                        request.TableName = "mc_whole_act_config";
                        var wholeActConfigResult = await _getBasicDataService.GetBasicDataAsync<mc_whole_act_config>(request);
                        result = wholeActConfigResult;
                        totalCount = wholeActConfigResult?.totalCount ?? 0;
                        break;
                    case "GetWholeActConfigExchProduct":
                        request.TableName = "mc_whole_act_config_exchproduct";
                        var wholeActConfigExchProductResult = await _getBasicDataService.GetBasicDataAsync<mc_whole_act_config_exchproduct>(request);
                        result = wholeActConfigExchProductResult;
                        totalCount = wholeActConfigExchProductResult?.totalCount ?? 0;
                        break;
                    case "GetWholeActConfigPgroup":
                        request.TableName = "mc_whole_act_config_pgroup";
                        var wholeActConfigPgroupResult = await _getBasicDataService.GetBasicDataAsync<mc_whole_act_config_pgroup>(request);
                        result = wholeActConfigPgroupResult;
                        totalCount = wholeActConfigPgroupResult?.totalCount ?? 0;
                        break;
                    case "GetWholeActCoupon":
                        request.TableName = "mc_whole_act_coupon";
                        var wholeActCouponResult = await _getBasicDataService.GetBasicDataAsync<mc_whole_act_coupon>(request);
                        result = wholeActCouponResult;
                        totalCount = wholeActCouponResult?.totalCount ?? 0;
                        break;
                    case "GetWholeActDiscount":
                        request.TableName = "mc_whole_act_discount";
                        var wholeActDiscountResult = await _getBasicDataService.GetBasicDataAsync<mc_whole_act_discount>(request);
                        result = wholeActDiscountResult;
                        totalCount = wholeActDiscountResult?.totalCount ?? 0;
                        break;
                    case "GetWholeActExch":
                        request.TableName = "mc_whole_act_exch";
                        var wholeActExchResult = await _getBasicDataService.GetBasicDataAsync<mc_whole_act_exch>(request);
                        result = wholeActExchResult;
                        totalCount = wholeActExchResult?.totalCount ?? 0;
                        break;
                    case "GetWholeActMember":
                        request.TableName = "mc_whole_act_member";
                        var wholeActMemberResult = await _getBasicDataService.GetBasicDataAsync<mc_whole_act_member>(request);
                        result = wholeActMemberResult;
                        totalCount = wholeActMemberResult?.totalCount ?? 0;
                        break;
                    case "GetWholeActMemberGrade":
                        request.TableName = "mc_whole_act_member_grade";
                        var wholeActMemberGradeResult = await _getBasicDataService.GetBasicDataAsync<mc_whole_act_member_grade>(request);
                        result = wholeActMemberGradeResult;
                        totalCount = wholeActMemberGradeResult?.totalCount ?? 0;
                        break;
                    case "GetWholeActPgroup":
                        request.TableName = "mc_whole_act_pgroup";
                        var wholeActPgroupResult = await _getBasicDataService.GetBasicDataAsync<mc_whole_act_pgroup>(request);
                        result = wholeActPgroupResult;
                        totalCount = wholeActPgroupResult?.totalCount ?? 0;
                        break;
                    case "GetWholeActProduct":
                        request.TableName = "mc_whole_act_product";
                        var wholeActProductResult = await _getBasicDataService.GetBasicDataAsync<mc_whole_act_product>(request);
                        result = wholeActProductResult;
                        totalCount = wholeActProductResult?.totalCount ?? 0;
                        break;
                    case "GetWholeActRepeat":
                        request.TableName = "mc_whole_act_repeat";
                        var wholeActRepeatResult = await _getBasicDataService.GetBasicDataAsync<mc_whole_act_repeat>(request);
                        result = wholeActRepeatResult;
                        totalCount = wholeActRepeatResult?.totalCount ?? 0;
                        break;
                    case "GetWholeActShop":
                        request.TableName = "mc_whole_act_shop";
                        var wholeActShopResult = await _getBasicDataService.GetBasicDataAsync<mc_whole_act_shop>(request);
                        result = wholeActShopResult;
                        totalCount = wholeActShopResult?.totalCount ?? 0;
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