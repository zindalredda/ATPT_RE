using Unity.Collections;
using UnityEngine;

namespace Alice
{
    public class BtnAnimation : MonoBehaviour
    {
        [SerializeField] private Sprite defaultSprite;
        [SerializeField] private Sprite highlightSprite;
        [ReadOnly] [SerializeField] private BoxCollider2D boxCollider;

        private void Awake()
        {
            boxCollider = GetComponent<BoxCollider2D>() ?? gameObject.AddComponent<BoxCollider2D>();
        }
    }
}
