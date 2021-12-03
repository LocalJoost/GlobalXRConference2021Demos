using System.Numerics;
using Microsoft.MixedReality.Toolkit.Utilities;
using Microsoft.MixedReality.Toolkit;
using UnityEngine;
using UnityEngine.Events;

namespace Services
{
	[MixedRealityExtensionService(SupportedPlatforms.WindowsStandalone|SupportedPlatforms.MacStandalone|SupportedPlatforms.LinuxStandalone|SupportedPlatforms.WindowsUniversal)]
	public class MyDemoService : BaseExtensionService, IMyDemoService, IMixedRealityExtensionService
	{
		private MyDemoServiceProfile myDemoServiceProfile;

		public MyDemoService(string name,  uint priority,  BaseMixedRealityProfile profile) : base(name, priority, profile) 
		{
			myDemoServiceProfile = (MyDemoServiceProfile)profile;
		}

		public Color Color => myDemoServiceProfile.Color;

		public string ServiceDescription => myDemoServiceProfile.ServiceDescription;

		public bool IsVisible { get; private set; }

		public void SetVisible(bool visible)
		{
			IsVisible = visible;
			VisibleChanged.Invoke();
		}
		
		public UnityEvent VisibleChanged { get; } = new UnityEvent();

	}
}
