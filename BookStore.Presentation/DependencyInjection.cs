
using Microsoft.Extensions.DependencyInjection;

namespace BookStore.Presentation
{
    public static class DependencyInjection
    {
        public static IServiceCollection InjectPresentationDependencies(this IServiceCollection services)
        {
            return services;
        }
    }
}
