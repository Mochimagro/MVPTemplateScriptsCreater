using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MVPTemplateEditor.Game.Component
{
	public interface IInGameSampleComponent
	{
		void Init();
    }


	public class InGameSampleComponent : MonoBehaviour ,IInGameSampleComponent
	{
		public void Init () 
		{
			

		}
		
	}
}