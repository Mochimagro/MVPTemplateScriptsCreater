using System;
using System.Collections.Generic;
using UnityEngine;
using UniRx;

namespace MVPTemplateEditor.Game.Presenter
{
	using Model;
	using View;
	public class CommonSamplePresenter
	{
		private ICommonSampleView commonSampleView = null;
		private ICommonSampleModel commonSampleModel = null;

		public CommonSamplePresenter(ICommonSampleView view,ICommonSampleModel model) 
		{
			commonSampleView = view ?? throw new ArgumentNullException(nameof(view));
			commonSampleModel = model ?? throw new ArgumentNullException(nameof(model));
			

			commonSampleView.Sample(commonSampleModel.TextValue);
			

			Bind();
		}
		
		private void Bind () 
		{
			

		}
	}
}