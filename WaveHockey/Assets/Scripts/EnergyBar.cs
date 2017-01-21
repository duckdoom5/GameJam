using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnergyBar : MonoBehaviour {
    
    public float barDisplay;
    public Vector2 pos = new Vector2(20, 40);
    public Vector2 size = new Vector2(60,20);
    public Texture2D emptyTex;
    public Texture2D fullTex;

    private void OnGUI()
    {
        GUI.BeginGroup(new Rect(pos.x, pos.y, size.x, size.y));
        GUI.Box(new Rect(0, 0, size.x, size.y),emptyTex);
        GUI.EndGroup();

        GUI.BeginGroup(new Rect(0, 0, size.x * barDisplay, size.y));
        GUI.Box(new Rect(0, 0, size.x, size.y), fullTex);

        GUI.EndGroup();
    }

    // Update is called once per frame
    void Update () {
        barDisplay = GetComponentInParent<Shoot>().energy;
	}
}
