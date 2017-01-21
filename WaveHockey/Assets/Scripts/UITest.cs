using UnityEngine;
using System.Collections;

public class UITest : MonoBehaviour
{
    public GameObject _cooldownBar;
    public GameObject _player;
    private RectTransform trans;

    private void Start()
    {
        trans = _cooldownBar.GetComponentInChildren<RectTransform>();
    }

    void Update()
    {
        trans.offsetMin = new Vector2(trans.offsetMin.x, 0);
    }
}