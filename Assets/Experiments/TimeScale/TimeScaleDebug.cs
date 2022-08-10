using Foundation.Managers.TimeScaleManager;
using UnityEngine;
using Zenject;

namespace Experiments.TimeScale
{
    public class TimeScaleDebug : MonoBehaviour
    {
        public float scale = 0.5f;
        [Inject] ITimeScaleManager _timeScaleManager;
        TimeScaleHandle _timeScaleHandle;

        void Awake()
        {
            enabled = false;
        }

        void OnEnable()
        {
            _timeScaleHandle = _timeScaleManager.BeginTimeScale(scale);
        }

        void OnDisable()
        {
            _timeScaleManager.EndTimeScale(_timeScaleHandle);
        }
    }
}
