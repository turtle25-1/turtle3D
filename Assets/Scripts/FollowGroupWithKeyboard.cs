using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class FollowGroupWithKeyboard : MonoBehaviour
{
    public Transform keyboardAsset;  // ������ �Ǵ� Ű���� ����
    public Transform gridCube;
    public Transform window1;
    public Transform window2;
    public Transform window3;

    private Vector3 offsetGridCube;
    private Vector3 offsetWindow1;
    private Vector3 offsetWindow2;
    private Vector3 offsetWindow3;

    private XRGrabInteractable grabInteractable;

    void Start()
    {
        // �ʱ� ��� ��ġ ���
        offsetGridCube = gridCube.position - keyboardAsset.position;
        offsetWindow1 = window1.position - keyboardAsset.position;
        offsetWindow2 = window2.position - keyboardAsset.position;
        offsetWindow3 = window3.position - keyboardAsset.position;

        // GrabInteractable ����
        grabInteractable = keyboardAsset.GetComponent<XRGrabInteractable>();
    }

    void LateUpdate()
    {
        // Ű���带 ������ ��� ���� ���� ����
        if (grabInteractable != null && grabInteractable.isSelected)
        {
            gridCube.position = keyboardAsset.position + offsetGridCube;
            window1.position = keyboardAsset.position + offsetWindow1;
            window2.position = keyboardAsset.position + offsetWindow2;
            window3.position = keyboardAsset.position + offsetWindow3;
        }
    }
}
