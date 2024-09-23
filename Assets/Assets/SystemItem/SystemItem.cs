using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class SystemItem : MonoBehaviour
{
    private UIDocument document;

    private void Update()
    {
        document = GetComponent<UIDocument>();
    }


}
