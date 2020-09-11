using System;

namespace Facade
{
    public static class TestFacade
    {
        public static void Main(string[] args)
        {
            IScheduleServer scheduleServer = new ScheduleServerImpl();
            ScheduleServerFacade facadeServer = new ScheduleServerFacade(scheduleServer);
            
            facadeServer.StartServer();
            Console.WriteLine("Start working......");
            Console.WriteLine("After the work has been completed.........");
            facadeServer.StopServer();
        }
    }
}