using UnityEngine;
using Zenject;

namespace MVPTemplateEditor.Game.Installer
{
	public class CommonSampleInstaller : MonoInstaller 
	{
		public override void InstallBindings()
		{
            Container.BindInterfacesAndSelfTo<Model.CommonSampleModel>().FromNew().AsCached();
            Container.Bind<Presenter.CommonSamplePresenter>().AsCached().NonLazy();
		}
	}
}