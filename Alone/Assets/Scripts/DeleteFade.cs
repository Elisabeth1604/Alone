using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleteFade : MonoBehaviour
{
   public GameObject fade;
    void Delete()
    {
        Destroy(fade);
    }
}
