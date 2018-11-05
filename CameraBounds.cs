using UnityEngine;

public class CameraBounds : MonoBehaviour {
    [SerializeField]
    private Transform Player;
    [SerializeField]
    private Vector2 Margin;
    [SerializeField]
    private Vector2 Smoothing;
    [SerializeField]
    private BoxCollider2D Bounds;

    private Vector3 min;
    private Vector3 max;

    public bool IsFollowing { get; set; }

    public void Start() {
        min = Bounds.bounds.min;
        max = Bounds.bounds.max;
        IsFollowing = true;
    }

    public void Update() {
        var x = transform.position.x;
        var y = transform.position.y;
        if (IsFollowing) {
            if (Mathf.Abs(x - Player.position.x) > Margin.x)
                x = Mathf.Lerp(x, Player.position.x, Smoothing.x * Time.deltaTime);

            if (Mathf.Abs(y - Player.position.y) > Margin.y)
                y = Mathf.Lerp(y, Player.position.y, Smoothing.y * Time.deltaTime);
        }

        var cameraHalfWidth = GetComponent<Camera>().orthographicSize * ((float)Screen.width / Screen.height);

        x = Mathf.Clamp(x, min.x + cameraHalfWidth, max.x - cameraHalfWidth);
        y = Mathf.Clamp(y, min.y + GetComponent<Camera>().orthographicSize, max.y - GetComponent<Camera>().orthographicSize);

        transform.position = new Vector3(x, y, transform.position.z);


    }


}
