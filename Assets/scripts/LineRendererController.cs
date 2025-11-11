using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineRendererController : MonoBehaviour
{
    [SerializeField] List<LineRenderer> lineRederers = new List<LineRenderer>();
    public void SetPosition(Transform startPos, Transform endPos)
    {
        if (lineRederers.Count > 0)
        {
            for (int i = 0; i < lineRederers.Count; i++)
            {
                if (lineRederers[i].positionCount >= 2)
                {
                    lineRederers[i].SetPosition(0, startPos.position);
                    lineRederers[i].SetPosition(1,endPos.position);
                }
                else
                {
                    Debug.Log("해당 렌더러는 2개의 점이 있어야 합니다.");
                }
            }
        }
    }
}
