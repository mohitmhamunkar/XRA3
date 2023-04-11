using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class ControllerColision : MonoBehaviour
{
    public AudioSource audiosource;
    public GameObject brokenPiecesSmall;
    public GameObject brokenPiecesMdium;
    public GameObject brokenPiecesLarge;
    public TextMeshProUGUI score_text;
    public TextMeshProUGUI endLevelText;
    public GameObject endGameObject;
    GameObject hitObject;
    public static bool endGame=false;
    public static int score=0;

    public Light pLight;




    public float delayTime = 0f;

   
    private void Start()
    {
        score = 0;
        endGame = false;
    }

    void Update()
    {
        if (score >= 0)
        {

            score_text.text = score.ToString();
        }
        else {
            
            endLevelText.text = "Level Failed";
            endGame = true;
            score = 0;
        }
        endGameObject.SetActive(endGame);

    }

    public void LoadSceneWithDelay(string sceneName)
    {
        StartCoroutine(LoadSceneDelayed(sceneName, delayTime));
    }

    private IEnumerator LoadSceneDelayed(string sceneName, float delayTime)
    {
        yield return new WaitForSeconds(delayTime);
        SceneManager.LoadScene(sceneName);
    }
    private void InstantiateObjectAndDestroy(Collision other)
    {
        GameObject createdObject = Instantiate(brokenPiecesMdium, other.gameObject.transform.position, other.gameObject.transform.rotation);
        createdObject.gameObject.transform.localScale = other.gameObject.transform.localScale;
        MeshRenderer[] brokenMeshRendere = createdObject.GetComponentsInChildren<MeshRenderer>();

        foreach (MeshRenderer render in brokenMeshRendere)
        {
            render.material = other.gameObject.GetComponent<MeshRenderer>().material;
        }
        createdObject.SetActive(true);


        Rigidbody[] brokenPiecesRigidbodies = createdObject.GetComponentsInChildren<Rigidbody>();
        foreach (Rigidbody rigidbody in brokenPiecesRigidbodies)
        {
            rigidbody.AddForce(UnityEngine.Random.insideUnitSphere * 5f, ForceMode.Impulse);
        }
        Destroy(createdObject, 1f);
        Destroy(other.gameObject);
    }

    private void OnCollisionEnter(Collision other)
    {
        audiosource.Play();
        List<string> objects = new List<string>() { "Left", "Right" };

        if (other.gameObject.tag == "100Bills")
        {
            InstantiateObjectAndDestroy(other);
            LoadSceneWithDelay("PlayScene");
        }
        else if (other.gameObject.tag == "TheFatRat")
        {
            InstantiateObjectAndDestroy(other);
            LoadSceneWithDelay("PlayScene");
        }
        else if (other.gameObject.tag == "Balearic")
        {
            InstantiateObjectAndDestroy(other);
            LoadSceneWithDelay("PlayScene");
        }
        else if (other.gameObject.tag == "Back") {
            InstantiateObjectAndDestroy(other);
            LoadSceneWithDelay("StartScene");

        }
        else if (other.gameObject.tag == "Play")
        {
            InstantiateObjectAndDestroy(other);
            LoadSceneWithDelay("PlayScene");
        }








        else if (!endGame) {

            pLight.color = other.gameObject.GetComponent<Renderer>().material.color;


            if (gameObject.CompareTag(other.gameObject.tag + "Controller"))
            {
                Vector3 velocity;
                other.gameObject.GetComponent<MoveForward>().enabled = false;
                if (other.gameObject.tag == "Right")
                {
                    velocity = OVRInput.GetLocalControllerVelocity(OVRInput.Controller.RTouch);
                }
                else
                {
                    velocity = OVRInput.GetLocalControllerVelocity(OVRInput.Controller.LTouch);
                }


                float magnitude = velocity.magnitude;
                if (magnitude > 0.5 && magnitude <= 1)
                {
                    hitObject = brokenPiecesSmall;
                }
                else if (magnitude > 1 && magnitude <= 2)
                {
                    hitObject = brokenPiecesMdium;
                }
                else if (magnitude > 2)
                {
                    hitObject = brokenPiecesLarge;

                }
                else
                {
                    return;
                }
                score += 50;
                GameObject createdObject = Instantiate(hitObject, other.gameObject.transform.position, other.gameObject.transform.rotation);
                createdObject.gameObject.transform.localScale = other.gameObject.transform.localScale;
                MeshRenderer[] brokenMeshRendere = createdObject.GetComponentsInChildren<MeshRenderer>();

                foreach (MeshRenderer render in brokenMeshRendere)
                {
                    render.material = other.gameObject.GetComponent<MeshRenderer>().material;
                }
                createdObject.SetActive(true);

                float force = velocity.magnitude * 1f;

                Rigidbody[] brokenPiecesRigidbodies = createdObject.GetComponentsInChildren<Rigidbody>();
                foreach (Rigidbody rigidbody in brokenPiecesRigidbodies)
                {
                    rigidbody.AddForce(UnityEngine.Random.insideUnitSphere * 5f, ForceMode.Impulse);
                    //rigidbody.AddForce(velocity.normalized * force, ForceMode.Impulse);
                }

                Destroy(createdObject, 1f);
                Destroy(other.gameObject);


            }
            else if (objects.Contains(other.gameObject.tag))
            {
                other.gameObject.GetComponent<MoveForward>().enabled = false;
                if (other.gameObject.tag == "Right")
                {

                    Vector3 velocity = OVRInput.GetLocalControllerVelocity(OVRInput.Controller.LTouch); // get the velocity of the controller
                    float force = velocity.magnitude * 2f; // calculate the force based on the velocity
                    other.gameObject.GetComponent<Rigidbody>().AddForce(velocity.normalized * force, ForceMode.Impulse);
                    float magnitude = velocity.magnitude;

                    if (magnitude > 0.5 && magnitude <= 1)
                    {
                        score -= 25;
                    }
                    else if (magnitude > 1 && magnitude <= 2)
                    {
                        score -= 50;
                    }
                    else if (magnitude > 2)
                    {
                        score -= 75;

                    }
                    else
                    {
                        score -= 15;
                    }
                    Destroy(other.gameObject, 1f);

                }
                else
                {
                    score -= 25;
                    Vector3 velocity = OVRInput.GetLocalControllerVelocity(OVRInput.Controller.RTouch); // get the velocity of the controller
                    float force = velocity.magnitude * 2f; // calculate the force based on the velocity
                    other.gameObject.GetComponent<Rigidbody>().AddForce(velocity.normalized * force, ForceMode.Impulse);
                    Destroy(other.gameObject, 1f);
                    float magnitude = velocity.magnitude;

                    if (magnitude > 0.5 && magnitude <= 1)
                    {
                        score -= 25;
                    }
                    else if (magnitude > 1 && magnitude <= 2)
                    {
                        score -= 50;
                    }
                    else if (magnitude > 2)
                    {
                        score -= 75;

                    }
                    else
                    {
                        score -= 15;
                    }
                }

            }
            //else if (other.gameObject.tag == "NonColiderDoor") {
            //    return;
            //}
            else if (other.gameObject.tag == "Door")
            {
                score -= 100;
            }


        }



    }
}
