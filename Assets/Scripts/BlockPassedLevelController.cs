using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockPassedLevelController : MonoBehaviour
{

    [SerializeField]
    public bool ForLevel1 = false;
    [SerializeField]
    public bool ForLevel2 = false;
    // Start is called before the first frame update

    private Collider2D col;

    void Start()
    {

        col = GetComponent<Collider2D>();
        col.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (ForLevel1 && GameManager.IsPassedLevel1())
            col.enabled = true;
        if (ForLevel2 && GameManager.IsPassedLevel2())
            col.enabled = true;
    }
}
