using Autofac;
using System.Web.Mvc;
using Autofac.Integration.Mvc;
using TicketReservationSystem.Data.Repositories;
using TicketReservationSystem.Data.DbContexts;

namespace TicketReservationSystem.Web
{
    public class AutofacConfig
    {
        internal static void Configure()
        {
            var builder = new ContainerBuilder();

            builder.RegisterControllers(typeof(MvcApplication).Assembly);
            builder.RegisterType<TicketReservationSystemContext>().InstancePerRequest();
            builder.RegisterType<HotelRepository>().As<IHotelRepository>().InstancePerRequest();
            builder.RegisterType<BookingRepository>().As<IBookingRepository>().InstancePerRequest();

            var container = builder.Build();
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
        }
    }
}