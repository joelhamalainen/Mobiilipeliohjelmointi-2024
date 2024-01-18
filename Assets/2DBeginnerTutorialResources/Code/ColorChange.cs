using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Mobiiliesimerkki
{
    /// <summary>
    /// Tämä skripti vaihtaa spriten väriä.
    /// </summary>
    public class ColorChange : MonoBehaviour
    {
        // Luokan jäsenmuuttujat
        private SpriteRenderer _spriteRenderer;
        [SerializeField]
        private Color[] _colours;
        // Start is called before the first frame update
        void Start()
        {
            // Haetaan viittaus SpriteRenderer-komponenttiin.
            // GetComponent palauttaa tässä GameObjectissa olevan SpriteRenderer-komponentin.

            _spriteRenderer = GetComponent<SpriteRenderer>();

            _spriteRenderer.color = _colours[0];
            
        }

        // Update is called once per frame
        void Update()
        {
            int index = (int)(Time.time % _colours.Length);
            _spriteRenderer.color = _colours[index];
        }
    }
}