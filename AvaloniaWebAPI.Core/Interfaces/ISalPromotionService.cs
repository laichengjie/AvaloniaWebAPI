using AvaloniaWebAPI.Core.Entities;
using System.Linq.Expressions;

namespace AvaloniaWebAPI.Core.Interfaces
{
    public interface ISalPromotionService
    {
        Task<PlatformBasicDataResult<SD_Pos_SalPromotion>>  GetSalPromotionsAsync(string? ModifyDTM);
    }
}