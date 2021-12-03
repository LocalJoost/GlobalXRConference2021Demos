using System;
using Microsoft.MixedReality.Toolkit;
using Microsoft.MixedReality.Toolkit.UI;
using Microsoft.MixedReality.Toolkit.Utilities;
using Services;
using TMPro;
using UnityEngine;

namespace HandPressDetectionDemo
{
    public class ObjectDisplayController : MonoBehaviour
    {
        private IMyDemoService demoService;

        private IMyDemoService DemoService => 
            demoService ??= MixedRealityToolkit.Instance.GetService<IMyDemoService>();
        
        private void Start()
        {
            SyncWithService();
            DemoService.VisibleChanged.AddListener(SyncWithService);
        }
        
        private void SyncWithService()
        {
            var r = gameObject.GetComponent<Renderer>();
            r.enabled = DemoService.IsVisible;
            r.material.color = DemoService.Color;
        }
    }
}
