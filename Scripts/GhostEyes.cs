using UnityEngine;

[RequireComponent(typeof(SpriteRenderer))]
public class GhostEyes : MonoBehaviour
{
    public SpriteRenderer spriteRenderer { get; private set; }
    public Sprite up;
    public Sprite down;
    public Sprite left;
    public Sprite right;

    public Movement movement { get; private set; }

    private void Awake()
    {
        this.spriteRenderer = GetComponent<SpriteRenderer>();
        this.movement = GetComponentInParent<Movement>();
    }

    private void Update()
    {
        if (this.movement.direction == Vector2.up)
        {
            spriteRenderer.sprite = this.up;
        }
        else if (this.movement.direction == Vector2.down)
        {
            spriteRenderer.sprite = this.down;
        }
        else if (this.movement.direction == Vector2.left)
        {
            spriteRenderer.sprite = this.left;
        }
        else if (this.movement.direction == Vector2.right)
        {
            spriteRenderer.sprite = this.right;
        }
    }

}
