using Abp.AutoMapper;
using prototipo.caliset.Authentication.External;

namespace prototipo.caliset.Models.TokenAuth
{
    [AutoMapFrom(typeof(ExternalLoginProviderInfo))]
    public class ExternalLoginProviderInfoModel
    {
        public string Name { get; set; }

        public string ClientId { get; set; }
    }
}
