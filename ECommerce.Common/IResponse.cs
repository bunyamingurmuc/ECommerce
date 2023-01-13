using ECommerce.Common.Enums;

namespace ECommerce.Common
{
    public interface IResponse
    {
        string Message { get; set; }
        ResponseType ResponseType { get; set; }
    }
}
