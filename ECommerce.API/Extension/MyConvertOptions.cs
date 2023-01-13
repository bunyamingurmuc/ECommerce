using Wkhtmltopdf.NetCore.Options;
using Wkhtmltopdf.NetCore;

namespace ECommerce.API.Extension
{
    public class MyConvertOptions : ConvertOptions
    {

        [OptionFlag("--footer-center")]
        public string FooterCenter { get; set; }
        [OptionFlag("--header-html")]
        public string HeaderHtml { get; set; }

        [OptionFlag("--enable-local-file-access")]
        public bool EnableLocalAccess { get; set; }
    }
}
