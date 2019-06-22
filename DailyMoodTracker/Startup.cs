using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DailyMoodTracker.Startup))]
namespace DailyMoodTracker
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
