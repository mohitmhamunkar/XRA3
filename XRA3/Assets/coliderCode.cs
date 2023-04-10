using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class coliderCode : MonoBehaviour
{
    public GameObject brokenPiecesMdium;
    public string sceneName;
    List<string> controllers = new List<string>() { "LeftController", "RightController" ,"GameController"};
    public float delayTime = 1f;

    //private void InstantiateObjectAndDestroy(Collision other)
    //{
    //    GameObject createdObject = Instantiate(brokenPiecesMdium, transform.position, transform.rotation);
    //    createdObject.gameObject.transform.localScale = gameObject.transform.localScale;
    //    MeshRenderer[] brokenMeshRendere = createdObject.GetComponentsInChildren<MeshRenderer>();

    //    foreach (MeshRenderer render in brokenMeshRendere)
    //    {
    //        render.material = GetComponent<MeshRenderer>().material;
    //    }
    //    createdObject.SetActive(true);


    //    Rigidbody[] brokenPiecesRigidbodies = createdObject.GetComponentsInChildren<Rigidbody>();
    //    foreach (Rigidbody rigidbody in brokenPiecesRigidbodies)
    //    {
    //        rigidbody.AddForce(UnityEngine.Random.insideUnitSphere * 5f, ForceMode.Impulse);
    //    }
    //    Destroy(createdObject, 1f);
    //}

    //public void LoadSceneWithDelay(string sceneName)
    //{
    //    StartCoroutine(LoadSceneDelayed(sceneName, delayTime));
    //}

    //private IEnumerator LoadSceneDelayed(string sceneName, float delayTime)
    //{
    //    yield return new WaitForSeconds(delayTime);
    //    SceneManager.LoadScene(sceneName);
    //}

    //private void OnCollisionEnter(Collision other)
    //{

    //    if (controllers.Contains(other.gameObject.tag))
    //    {
    //        InstantiateObjectAndDestroy(other);
    //        LoadSceneWithDelay(sceneName);

    //    }
    //}
    

}
