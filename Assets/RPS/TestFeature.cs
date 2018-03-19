using UnityEngine;
using Entitas;
using System.Collections.Generic;

public class TestFeature : Feature {

	public TestFeature(Contexts c) : base ("TestFeature") {
		Add(new TestSystem(c));
        c.game.CreateEntity().AddTest("sdf");
	}

}
