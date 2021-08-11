using System;
using System.Collections.Generic;
using UnityEngine;
using UniRx;

namespace MVPTemplateEditor.Game.Presenter
{
	using Model;
	using View;
	public class OutGameSamplePresenter
	{
		private IOutGameSampleView outGameSampleView = null;
		private IOutGameSampleModel outGameSampleModel = null;

		public OutGameSamplePresenter(IOutGameSampleView view,IOutGameSampleModel model) 
		{
			outGameSampleView = view ?? throw new ArgumentNullException(nameof(view));
			outGameSampleModel = model ?? throw new ArgumentNullException(nameof(model));
			

			outGameSampleView.Sample(outGameSampleModel.TextValue);
			

			Bind();
		}
		
		private void Bind () 
		{
			

		}
	}
}