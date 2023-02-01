using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Preloader : MonoBehaviour
{
    private CanvasGroup fadeGroup;
    private float loadTime;
    private float minimumLogoTime = 3.0f;

    private void Start() {
        fadeGroup = FindObjectOfType<CanvasGroup>();

        fadeGroup.alpha = 1;

    //Carregar assets do game 
//     //progress bar from firebase storage
//     //https://gamedev.stackexchange.com/questions/192162/download-progress-bar-from-firebase-storage
//     if (CheckConnectivity) //if the device is connected to the internet, initiate download.
//         {
//            // Debug.Log("Initiating download of: " + platform + _file);
//             if (!File.Exists(localPath))
//             {
//             Task task = storageRef.GetFileAsync(localPath,
//             new StorageProgress<DownloadState>(state => {
//                     // called periodically during the download
//                 Debug.Log(String.Format(
//                 "Progress: % bytes transferred.",
//                 100 * state.BytesTransfered/state.TotalByteCount));
//             }), CancellationToken.None);

//                 await storageRef.Child(_child).Child(_file).GetFileAsync(localPath).ContinueWithOnMainThread(files =>
//                 {
//                     if (!files.IsFaulted && !files.IsCanceled) //if download is successful.
//                     {
//                         Debug.Log("file saved as " + localPath);
                       
//                     }
//                     else //otherwise report error.
//                     {
//                         Debug.Log(files.Exception.ToString());
//                     }
//                 });
//             }
//             else
//             {
//                 Debug.Log("files Exist");
//             }
           
//         }
//         else //otherwise don't bother.
//         {
//             Debug.Log("Cannot Download file due to lack of connectivity!");
//         }
//     }

        if (Time.time < minimumLogoTime)
        {
            loadTime = minimumLogoTime;
        } else {
            loadTime = Time.time;
        }
    }

    private void Update()
    {
        //Fade-in
        if (Time.time < minimumLogoTime)
        {
            fadeGroup.alpha = 1 - Time.time;
            Debug.Log("Tempo: " + Time.time);
            Debug.Log("Alpha: " + fadeGroup.alpha);
        }

        //Fade-out
        if (Time.time >= minimumLogoTime & loadTime != 0)
        {
            fadeGroup.alpha = Time.time - minimumLogoTime;
            if (fadeGroup.alpha >= 1)
            {
                SceneManager.LoadScene("PlayerView");
            }
        }
    }
    

}
