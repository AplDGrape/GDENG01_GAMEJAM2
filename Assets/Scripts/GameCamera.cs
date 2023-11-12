using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class GameCamera : MonoBehaviour
{
    //public CinemachineVirtualCamera[] cameras;

    [SerializeField] List<CinemachineVirtualCamera> cameras = new List<CinemachineVirtualCamera>();
    [SerializeField] CinemachineVirtualCamera GameCam;

    public static CinemachineVirtualCamera ActiveCamera = null;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(OpeningScene(GameCam));
    }

    public void SwitchCamera(CinemachineVirtualCamera camera)
    {
        camera.Priority = 20;
        ActiveCamera = camera;

        foreach (CinemachineVirtualCamera c in cameras)
        {
            if (c != camera)
                c.Priority = 0;
        }
    }

    IEnumerator OpeningScene(CinemachineVirtualCamera Cam)
    {
        Time.timeScale = 0.55f;
        SwitchCamera(Cam);
        yield return new WaitForSeconds(1);
        Time.timeScale = 1.0f;
    }
}
