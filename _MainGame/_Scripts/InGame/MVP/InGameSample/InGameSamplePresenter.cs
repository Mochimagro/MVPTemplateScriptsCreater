using System;
using System.Collections.Generic;
using UnityEngine;
using UniRx;

namespace MVPTemplateEditor.Game.Presenter
{
	using Model;
	using View;

	public interface IInGameSamplePresenter
	{
		
	}

	public class InGameSamplePresenter : IInGameSamplePresenter
	{
		private IInGameSampleView _inGameSampleView = null;
		private IInGameSampleModel _inGameSampleModel = null;

		public InGameSamplePresenter(IInGameSampleView view,IInGameSampleModel model) 
		{
			_inGameSampleView = view ?? throw new ArgumentNullException(nameof(view));
			_inGameSampleModel = model ?? throw new ArgumentNullException(nameof(model));
			

			_inGameSampleView.Sample(_inGameSampleModel.TextValue);
			

			Bind();
		}
		
		private void Bind () 
		{
			

		}
	}
}