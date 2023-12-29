using UnityEngine;

public sealed class GroundEnemy : BaseEnemy
{
    public override void Say(string sentense)
    {
        sentense = sentense.Replace('a', 'k');
        Debug.LogError(sentense);
    }
}

