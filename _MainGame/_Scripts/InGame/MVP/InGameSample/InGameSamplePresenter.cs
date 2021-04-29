using System;
using System.Collections.Generic;
using UnityEngine;
using UniRx;

namespace MVPTemplate.Game.Presenter
{
	using Model;
	using View;
	public class InGameSamplePresenter
	{
		private InGameSampleView _inGameSampleView = null;
		private InGameSampleModel _inGameSampleModel = null;

		public InGameSamplePresenter(InGameSampleView view,InGameSampleModel model) 
		{
			_inGameSampleView = view ?? throw new ArgumentNullException(nameof(view));
			_inGameSampleModel = model ?? throw new ArgumentNullException(nameof(model));
			

			_inGameSampleView.Sample(model.TextValue);
			

			Bind();
		}
		
		private void Bind () 
		{
			

		}
	}
}