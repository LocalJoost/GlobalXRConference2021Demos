#if UNITY_EDITOR
using System;
using Microsoft.MixedReality.Toolkit.Editor;
using Microsoft.MixedReality.Toolkit;
using UnityEngine;
using UnityEditor;

namespace Services.Editor
{	
	[MixedRealityServiceInspector(typeof(IMyDemoService))]
	public class MyDemoServiceInspector : BaseMixedRealityServiceInspector
	{
		public override void DrawInspectorGUI(object target)
		{
			MyDemoService service = (MyDemoService)target;
			
			// Draw inspector here
		}
	}
}

#endif