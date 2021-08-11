using UnityEngine;
using Zenject;

namespace MVPTemplateEditor.Game.Installer
{
	public class InGameSampleInstaller : MonoInstaller 
	{
		public override void InstallBindings()
		{
            Container.BindInterfacesAndSelfTo<Model.InGameSampleModel>().FromNew().AsCached();
            Container.Bind<Presenter.InGameSamplePresenter>().AsCached().NonLazy();
		}
	}
}