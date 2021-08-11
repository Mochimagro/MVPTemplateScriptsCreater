using System;
using System.Collections.Generic;
using UnityEngine;
using UniRx;

namespace MVPTemplateEditor.Game.Model
{
	public interface IInGameSampleModel
    {
        string TextValue { get; }
    }


	public class InGameSampleModel : IInGameSampleModel
	{
		string _textValue = "Default";
		public string TextValue { get => _textValue; }

		public InGameSampleModel()
		{
			

		}

	}
}