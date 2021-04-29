using System;
using System.Collections.Generic;
using UnityEngine;
using UniRx;

namespace MVPTemplate.Game.Presenter
{
	using Model;
	using View;
	public class CommonSamplePresenter
	{
		private CommonSampleView _commonSampleView = null;
		private CommonSampleModel _commonSampleModel = null;

		public CommonSamplePresenter(CommonSampleView view,CommonSampleModel model) 
		{
			_commonSampleView = view ?? throw new ArgumentNullException(nameof(view));
			_commonSampleModel = model ?? throw new ArgumentNullException(nameof(model));
			

			_commonSampleView.Sample(model.TextValue);
			

			Bind();
		}
		
		private void Bind () 
		{
			

		}
	}
}