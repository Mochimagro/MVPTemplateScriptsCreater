using System;
using System.Collections.Generic;
using UnityEngine;
using UniRx;

namespace MVPTemplateEditor.Game.Presenter
{
	using Model;
	using View;

	public interface ICommonSamplePresenter
	{
		
	}

	public class CommonSamplePresenter : ICommonSamplePresenter
	{
		private ICommonSampleView _commonSampleView = null;
		private ICommonSampleModel _commonSampleModel = null;

		public CommonSamplePresenter(ICommonSampleView view,ICommonSampleModel model) 
		{
			_commonSampleView = view ?? throw new ArgumentNullException(nameof(view));
			_commonSampleModel = model ?? throw new ArgumentNullException(nameof(model));
			

			_commonSampleView.Sample(_commonSampleModel.TextValue);
			

			Bind();
		}
		
		private void Bind () 
		{
			

		}
	}
}