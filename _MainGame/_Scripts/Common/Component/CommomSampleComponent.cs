﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MVPTemplateEditor.Game.Component
{
	public interface ICommomSampleComponent
    {
		void Init();
    }


	public class CommomSampleComponent : MonoBehaviour ,ICommomSampleComponent
	{
		public void Init () 
		{
			

		}
		
	}
}