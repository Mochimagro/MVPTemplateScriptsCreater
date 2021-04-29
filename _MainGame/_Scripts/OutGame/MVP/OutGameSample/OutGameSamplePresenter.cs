using System;
using System.Collections.Generic;
using UnityEngine;
using UniRx;

namespace MVPTemplate.Game.Presenter
{
	using Model;
	using View;
	public class OutGameSamplePresenter
	{
		private OutGameSampleView _outGameSampleView = null;
		private OutGameSampleModel _outGameSampleModel = null;

		public OutGameSamplePresenter(OutGameSampleView view,OutGameSampleModel model) 
		{
			_outGameSampleView = view ?? throw new ArgumentNullException(nameof(view));
			_outGameSampleModel = model ?? throw new ArgumentNullException(nameof(model));
			

			_outGameSampleView.Sample(model.TextValue);
			

			Bind();
		}
		
		private void Bind () 
		{
			

		}
	}
}