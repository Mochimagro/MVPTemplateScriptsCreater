using System;
using System.Collections.Generic;
using UnityEngine;
using UniRx;

namespace MVPTemplateEditor.Game.Presenter
{
	using Model;
	using View;

	public interface IOutGameSamplePresenter
	{
		
	}

	public class OutGameSamplePresenter : IOutGameSamplePresenter
	{
		private IOutGameSampleView _outGameSampleView = null;
		private IOutGameSampleModel _outGameSampleModel = null;

		public OutGameSamplePresenter(IOutGameSampleView view,IOutGameSampleModel model) 
		{
			_outGameSampleView = view ?? throw new ArgumentNullException(nameof(view));
			_outGameSampleModel = model ?? throw new ArgumentNullException(nameof(model));
			

			_outGameSampleView.Sample(_outGameSampleModel.TextValue);
			

			Bind();
		}
		
		private void Bind () 
		{
			

		}
	}
}