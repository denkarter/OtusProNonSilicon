using TMPro;
using UnityEngine;

namespace Experiments.TimeScale
{
    public class TimeScaleDebugIndicator : MonoBehaviour
    {
        TextMeshProUGUI text;

        void Awake()
        {
            text = GetComponent<TextMeshProUGUI>();
        }

        void Update()
        {
            text.text = $"TimeScale: {Time.timeScale}";
        }
    }
}
