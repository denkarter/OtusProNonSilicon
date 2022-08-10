namespace Foundation.Managers.TimeScaleManager
{
    public interface ITimeScaleManager
    {
        TimeScaleHandle BeginTimeScale(float scale);
        void EndTimeScale(TimeScaleHandle handle);
    }
}