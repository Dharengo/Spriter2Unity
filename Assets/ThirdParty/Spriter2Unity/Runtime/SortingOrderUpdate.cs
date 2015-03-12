using UnityEngine;
using System.Collections;

namespace Spriter2Unity.Runtime
{
    [ExecuteInEditMode]
    public class SortingOrderUpdate : MonoBehaviour
    {
        public float SortingOrder = 0;

        private Renderer cachedRenderer;

        private void Start()
        {
            cachedRenderer = GetComponent<Renderer>();
            if (!cachedRenderer)
            {
                Destroy(this);
            }
        }

        private void Update()
        {
            cachedRenderer.sortingOrder = (int)SortingOrder;
        }
    }
}