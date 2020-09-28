using Abp.Web.Mvc.Views;

namespace sep2020.Web.Views
{
    public abstract class sep2020WebViewPageBase : sep2020WebViewPageBase<dynamic>
    {

    }

    public abstract class sep2020WebViewPageBase<TModel> : AbpWebViewPage<TModel>
    {
        protected sep2020WebViewPageBase()
        {
            LocalizationSourceName = sep2020Consts.LocalizationSourceName;
        }
    }
}