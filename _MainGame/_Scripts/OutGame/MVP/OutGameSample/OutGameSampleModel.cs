using System;
using System.Collections.Generic;
using UnityEngine;
using UniRx;

namespace MVPTemplateEditor.Game.Model
{
	public interface IOutGameSampleModel
    {
        string TextValue { get; }
    }


	public class OutGameSampleModel : IOutGameSampleModel
	{
		string _textValue = default;
		public string TextValue { get => _textValue; }

		public OutGameSampleModel()
		{
			

		}

	}
}