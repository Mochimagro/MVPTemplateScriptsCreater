using System;
using System.Collections.Generic;
using UnityEngine;
using UniRx;

namespace MVPTemplateEditor.Game.Presenter
{
	using Model;
	using View;
	public class InGameSamplePresenter
	{
		private IInGameSampleView inGameSampleView = null;
		private IInGameSampleModel inGameSampleModel = null;

		public InGameSamplePresenter(IInGameSampleView view,IInGameSampleModel model) 
		{
			inGameSampleView = view ?? throw new ArgumentNullException(nameof(view));
			inGameSampleModel = model ?? throw new ArgumentNullException(nameof(model));
			

			inGameSampleView.Sample(inGameSampleModel.TextValue);
			

			Bind();
		}
		
		private void Bind () 
		{
			

		}
	}
}