using Avalonia.Web.Blazor;

namespace SukiUiTest.Web;

public partial class App
{
    protected override void OnParametersSet()
    {
        base.OnParametersSet();

        WebAppBuilder.Configure<SukiUiTest.App>()
            .SetupWithSingleViewLifetime();
    }
}