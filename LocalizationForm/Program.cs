using LocalizationForm.Interfaces;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace LocalizationForm;
class Program
{
    public static IServiceProvider ServiceProvider { get; private set; }

    [STAThread]
    static void Main()
    {
        ApplicationConfiguration.Initialize();
        Application.EnableVisualStyles();
        
        var serviceCollection = new ServiceCollection();
        ConfigureServices(serviceCollection);

        ServiceProvider = serviceCollection.BuildServiceProvider();
        Application.Run(ServiceProvider.GetRequiredService<JsonLocalizator>());
    }   
    private static void ConfigureServices(ServiceCollection services)
    {
        services.AddTransient<ICastJObject, CastJObject>();
        services.AddTransient<ICreateJson, JsonCreator>();
        services.AddTransient<IGetFileText, GetFileText>();
        services.AddTransient<ITranslate, JsonTranslator>();

        services.AddTransient<JsonLocalizator>();
    }
}