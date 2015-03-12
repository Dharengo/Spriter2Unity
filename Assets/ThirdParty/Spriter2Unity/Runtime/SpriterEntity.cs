using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Spriter2Unity.Runtime
{
    public class SpriterEntity : MonoBehaviour
    {
        public Material SpriteMaterial;

        public void ApplyMaterial()
        {
            var renderers = gameObject.GetComponentsInChildren<SpriteRenderer>(true);
            foreach(var renderer in renderers)
            {
                renderer.material = SpriteMaterial;
            }
        }
    }
}
