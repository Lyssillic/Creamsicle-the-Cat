using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using cakeslice;
using TMPro;

namespace cakeslice
{
    public class OutlineAnimation : MonoBehaviour
    {
        public GameObject player;
        public GameObject remote;
        public TextMeshProUGUI Message;
        private float distance = 0.0f;
        bool pingPong = false;

        void Update()
        {
            Color c = GetComponent<OutlineEffect>().lineColor0;

            distance = Vector3.Distance(remote.transform.position, player.transform.position);
            if (distance < 3.0f)
            {
                Message.text = "Press E to Interact";
                if (pingPong)
                {
                    c.a += Time.deltaTime;

                    if (c.a >= 1)
                        pingPong = false;
                }
                else
                {
                    c.a -= Time.deltaTime;

                    if (c.a <= 0)
                        pingPong = true;
                }
            } 
            else
            {
                Message.text = "";
                c.a = 0;
            }

            c.a = Mathf.Clamp01(c.a);
            GetComponent<OutlineEffect>().lineColor0 = c;
            GetComponent<OutlineEffect>().UpdateMaterialsPublicProperties();
        }
    }
}