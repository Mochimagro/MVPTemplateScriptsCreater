using UnityEngine;
using Zenject;

namespace MVPTemplate.Game.Installer
{
	public class InGameSampleInstaller : MonoInstaller 
	{
		public override void InstallBindings()
		{
            Container.Bind<Model.InGameSampleModel>().FromNew().AsCached();
            Container.Bind<Presenter.InGameSamplePresenter>().AsCached().NonLazy();
		}
	}
}