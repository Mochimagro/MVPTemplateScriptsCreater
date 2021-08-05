using System;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UniRx;
using UnityEngine.UI;
using Zenject;

namespace MVPTemplateEditor.Game.View
{
	
	public interface IOutGameSampleView
    {
        void Sample(string value);

	}

	[RequireComponent(typeof(ZenjectBinding))]
	public class OutGameSampleView : MonoBehaviour ,IOutGameSampleView
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