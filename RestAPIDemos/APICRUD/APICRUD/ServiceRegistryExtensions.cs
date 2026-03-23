using Consul;

namespace TraineeService
{
    public static class ServiceRegistryExtensions
    {
        public static IServiceCollection AddConsulConfig(this IServiceCollection services,IConfiguration config)
        {
            services.AddSingleton<IConsulClient, ConsulClient>(options=> new ConsulClient(consulconfig=>
            {
                consulconfig.Address = new Uri( config["ConsulConfig:ConsulServer"]);
            }
            ));
            return services;
        }


        public static IApplicationBuilder UseConsul(this IApplicationBuilder app,IConfiguration config)
        {
           var consulclient= app.ApplicationServices.GetRequiredService<IConsulClient>();

            var registration = new AgentServiceRegistration()
            {
                ID = config["ConsulConfig:ServiceName"],
                Name = config["ConsulConfig:ServiceName"],
                Address = config["ConsulConfig:ServiceHost"],
                Port =int.Parse( config["ConsulConfig:ServicePort"])
            };

            //consulclient.Agent.ServiceDeregister(registration.ID).ConfigureAwait(true);
            consulclient.Agent.ServiceRegister(registration).ConfigureAwait(true);

            return app;
        }
    }
}
