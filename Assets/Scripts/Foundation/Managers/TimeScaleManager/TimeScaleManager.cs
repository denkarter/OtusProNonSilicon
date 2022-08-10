using System.Collections.Generic;
using UnityEngine;
using Zenject;

namespace Foundation.Managers.TimeScaleManager
{
    public sealed class TimeScaleManager : AbstractManager<ITimeScaleManager>, ITimeScaleManager
    {
        private List<TimeScaleHandle> handles = new List<TimeScaleHandle>(10);
        public float CurrentTimeScale { get; private set; } = 1.0f;

        private void Awake()
        {
            Time.timeScale = 1.0f;
        }

        void UpdateTimeScale()
        {
            float scale = 1.0f;
            foreach (var handle in handles) 
                scale *= handle.Scale;
            Time.timeScale = CurrentTimeScale = scale;
        }

        public TimeScaleHandle BeginTimeScale(float scale)
        {
            var handle = new TimeScaleHandle(scale);
            handles.Add(handle);
            UpdateTimeScale();
            return handle;
        }

        public void EndTimeScale(TimeScaleHandle handle)
        {
            handles.Remove(handle);
            UpdateTimeScale();
        }
    }
}