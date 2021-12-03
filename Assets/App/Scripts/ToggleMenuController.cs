using System;
using Microsoft.MixedReality.Toolkit;
using Microsoft.MixedReality.Toolkit.UI;
using Microsoft.MixedReality.Toolkit.Utilities;
using Services;
using TMPro;
using UnityEngine;

namespace HandPressDetectionDemo
{
    public class ToggleMenuController : MonoBehaviour
    {
        [SerializeField]
        private Interactable interactable;

        private IMyDemoService demoService;

        private IMyDemoService DemoService => 
            demoService ??= MixedRealityToolkit.Instance.GetService<IMyDemoService>();
        
        private void Start()
        {
            interactable.IsToggled = DemoService.IsVisible;
        }
        
        public void TogglePressed()
        {
            DemoService.SetVisible(interactable.IsToggled);
        }
    }
}
