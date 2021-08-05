using System;
using System.Collections.Generic;
using UnityEngine;
using UniRx;

namespace MVPTemplateEditor.Game.Model
{
	public interface ICommonSampleModel
    {
        string TextValue { get; }
    }


	public class CommonSampleModel : ICommonSampleModel
	{
		string _textValue = default;
		public string TextValue { get => _textValue; }

		public CommonSampleModel()
		{
			

		}

	}
}