using UnityEngine;

[RequireComponent(typeof(LineRenderer))]
public sealed class TrajectoryRenderer : MonoBehaviour
{
    [SerializeField] private LineRenderer _lineRenderer;

    public void Draw(Vector2 origin, Vector2 speed)
    {
        _lineRenderer.positionCount = 100;
        Vector3[] points = new Vector3[100];
        for (int i = 0; i < points.Length; i++)
        {
            float time = i * 0.1f;
            points[i] = origin + speed * time + 0.5f * time * time * Physics2D.gravity;
        }

        _lineRenderer.SetPositions(points);
    }

    public void Hide()
    {
        _lineRenderer.positionCount = 0;
    }
}
