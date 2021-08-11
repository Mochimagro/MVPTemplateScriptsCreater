using UnityEngine;
using Zenject;

namespace MVPTemplateEditor.Game.Installer
{
	public class OutGameSampleInstaller : MonoInstaller 
	{
		public override void InstallBindings()
		{
            Container.BindInterfacesAndSelfTo<Model.OutGameSampleModel>().FromNew().AsCached();
            Container.Bind<Presenter.OutGameSamplePresenter>().AsCached().NonLazy();
		}
	}
}