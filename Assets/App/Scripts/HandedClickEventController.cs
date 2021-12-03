using Microsoft.MixedReality.Toolkit.Input;
using Microsoft.MixedReality.Toolkit.UI;
using Microsoft.MixedReality.Toolkit.Utilities;
using UnityEngine;
using UnityEngine.Events;

namespace HandPressDetectionDemo
{
    [RequireComponent(typeof(Interactable))]
    public class HandedClickEventController : MonoBehaviour, IMixedRealityTouchHandler
    {
        private Handedness lastTouch;
        
        public UnityEvent<Handedness> OnClick = new UnityEvent<Handedness>();
        
        private void Start()
        {
            GetComponent<Interactable>().OnClick.AddListener(() => OnClick.Invoke(lastTouch));    
        }
        
        public void OnTouchStarted(HandTrackingInputEventData eventData)
        {
            lastTouch = eventData.Handedness;
        }

        public void OnTouchCompleted(HandTrackingInputEventData eventData)
        {
        }

        public void OnTouchUpdated(HandTrackingInputEventData eventData)
        {
        }
    }
}
