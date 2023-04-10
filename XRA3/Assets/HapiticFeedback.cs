// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;
// using UnityEngine.UI;

// public class HapiticFeedback : MonoBehaviour
// {
//     public AudioClip audio;
//     // Start is called before the first frame update
//     void Start()
//     {
//         ApplyHapticFeedback(XRI.Controller.LTouch, audio);
//     }

//     void ApplyHapticFeedback(OVRInput.Controller controller, AudioClip haptic){
//         OVRHapticsClip hapticsClip= new OVRHapticsClip(haptic);
//         if(controller == OVRInput.Controller.LTouch){
//             OVRHaptics.LeftChannel.Preempt(hapticsClip);
//         }
//         else{
//             OVRHaptics.RightChannel.Preempt(hapticsClip);

//         }
//     }
 
// }
