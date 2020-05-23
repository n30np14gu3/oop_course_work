namespace oop_sdk.net
{
    public enum RequestMethods
    {
        RequestSendSettings = 0,
        RequestStartEmulation,
        RequestStopEmulation,

        EmulationEntityEvent = 100,
        EmulationEventHourTick,
        EmulationEventNewDay,
        EmulationStatus
    }
}