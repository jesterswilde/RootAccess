using UnityEngine;

public class NodeFocuser : MonoBehaviour
{
    [SerializeField]
    float lerpSpeed = 1;
    bool isLerping;
    float lerp = 0;
    Vector3 lastPos;
    Vector3 targetPos;
    void FocusNode(Node node)
    {
        lastPos = transform.position;
        targetPos = node.transform.position;
        isLerping = true;
        lerp = 0;
    }
    private void Update()
    {
        if (!isLerping)
            return;
        lerp += Time.deltaTime * lerpSpeed;
        lerp = Mathf.Min(lerp, 1);
        transform.position = Vector3.Lerp(lastPos, targetPos, lerp);
        if(lerp >= 1)
        {
            isLerping = false;
        }
    }
    private void Start()
    {
        Terminal.T.OnNodeChange += FocusNode;
    }
}
