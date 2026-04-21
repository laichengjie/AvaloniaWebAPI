using AvaloniaWebAPI.Core.Entities;
using System.Linq.Expressions;

namespace AvaloniaWebAPI.Core.Interfaces
{
    public interface ISalPromotionService
    {
        Task<IEnumerable<SD_Pos_SalPromotion>> GetAllSalPromotionsAsync(string ModifyDTM);
        
    }
} 