using UnityEngine;

public sealed class FlyingEnemy : BaseEnemy
{
    public override void Say(string sentense)
    {
        Debug.Log(sentense);
    }
}

