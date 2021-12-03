using System;
using UnityEngine;
using Microsoft.MixedReality.Toolkit;

namespace Services
{
	[MixedRealityServiceProfile(typeof(IMyDemoService))]
	[CreateAssetMenu(fileName = "MyDemoServiceProfile", menuName = "MixedRealityToolkit/MyDemoService Configuration Profile")]
	public class MyDemoServiceProfile : BaseMixedRealityProfile
	{
		[SerializeField]
		private string serviceDescription;

		[SerializeField]
		private Color color;

		public string ServiceDescription => serviceDescription;

		public Color Color => color;
	}
}