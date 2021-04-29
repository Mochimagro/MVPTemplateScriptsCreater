using System;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UniRx;
using UnityEngine.UI;
using Zenject;

namespace MVPTemplate.Game.View
{
	[RequireComponent(typeof(ZenjectBinding))]
	public class CommonSampleView : MonoBehaviour 
	{
		[SerializeField] private Text _sampleText = null;

		public void Init()
		{
			

		}
		
		public void Sample(string value)
        {
			_sampleText.text = value;
        }
	}
}