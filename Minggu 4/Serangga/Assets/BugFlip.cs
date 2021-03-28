using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BugFlip : MonoBehaviour
{
    private bool facingRight = true;
    // Start is called before the first frame update

    // Update is called once per frame
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow) && facingRight) Flip();
        if (Input.GetKeyDown(KeyCode.RightArrow) && !facingRight) Flip();
    }

    void Flip()
    {
        facingRight = !facingRight;
        Vector3 theScale = transform.localScale;
        theScale.x *= -1;
        transform.localScale = theScale;
    }
}
