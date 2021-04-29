using UnityEngine;
using Zenject;

namespace MVPTemplate.Game.Installer
{
	public class OutGameSampleInstaller : MonoInstaller 
	{
		public override void InstallBindings()
		{
            Container.Bind<Model.OutGameSampleModel>().FromNew().AsCached();
            Container.Bind<Presenter.OutGameSamplePresenter>().AsCached().NonLazy();
		}
	}
}