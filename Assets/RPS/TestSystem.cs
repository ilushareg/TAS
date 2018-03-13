using Entitas;
using UnityEngine;
using System.Collections.Generic;

public class TestSystem : ReactiveSystem<GameEntity>
{
	readonly GameContext _context;

	public TestSystem(Contexts contexts) : base(contexts.game)
	{
		_context = contexts.game;
	}

	public void Execute()
	{
		//Debug.Log ("asd");
//		if (Input.GetMouseButtonDown(0))
//		{
//			_context.CreateEntity().AddDebugMessage("Left Mouse Button Clicked");
//		}
//
//		if (Input.GetMouseButtonDown(1))
//		{
//			_context.CreateEntity().AddDebugMessage("Right Mouse Button Clicked");
//		}
	}



	protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context)
	{
		var res = context.CreateCollector(GameMatcher.Test);
		return res;
	}

	protected override bool Filter(GameEntity entity)
	{
		return entity.hasTest;
	}

	protected override void Execute(List<GameEntity> entities)
	{
		foreach (var e in entities)
		{
			Debug.Log(e.test.message);
		}
	}
}
