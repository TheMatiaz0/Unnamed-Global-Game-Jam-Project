﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TypeReferences;
using UnityEngine;

public class Bug : Collectable
{
    public override bool IsBad => true;

    protected override void OnCollect()
	{
		PlayerController.Instance.PushBugs(GlitchEffect.GetRandomGlitchEffect());

	}

}
