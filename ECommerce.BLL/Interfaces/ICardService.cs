using ECommerce.Common;
using ECommerce.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.BLL.Interfaces
{
    public interface ICardService:IService<Card>
    {
        IResponse<Card> CalculateAndCreate(Card card);
        Task<IResponse<Card>> CalculateAndCreateAsync(Card card);
    }
}
