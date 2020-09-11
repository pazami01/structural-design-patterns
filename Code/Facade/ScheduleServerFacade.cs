namespace Facade
{
    public class ScheduleServerFacade
    {
        private IScheduleServer scheduleServer;

        public ScheduleServerFacade(IScheduleServer scheduleServer)
        {
            this.scheduleServer = scheduleServer;
        }

        public void StartServer()
        {
            scheduleServer.StartBooting();
            scheduleServer.ReadSystemConfigFile();
            scheduleServer.Init();
            scheduleServer.InitializeContext();
            scheduleServer.InitializeListeners();
            scheduleServer.CreateSystemObjects();
        }

        public void StopServer()
        {
            scheduleServer.ReleaseProcesses();
            scheduleServer.Destroy();
            scheduleServer.DestroySystemObjects();
            scheduleServer.DestroyListeners();
            scheduleServer.DestroyContext();
            scheduleServer.Shutdown();
        }
    }
}