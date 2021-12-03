using Microsoft.MixedReality.Toolkit;
using UnityEngine;
using UnityEngine.Events;

namespace Services
{
	public interface IMyDemoService : IMixedRealityExtensionService
	{
		// Expose service features and abilities here

		string ServiceDescription{ get; }
		
		Color Color { get; }	
		
		bool IsVisible { get; }

		void SetVisible(bool visible);

		UnityEvent VisibleChanged { get;}
	}
}