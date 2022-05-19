using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetClothes : MonoBehaviour
{
    public GameObject[] meshes_;

    // Update is called once per frame
    public void SettingButton(int mesh_ID)
    {
        meshes_[mesh_ID].SetActive(true);
        if(mesh_ID == 0) meshes_[1].SetActive(false);
        else if(mesh_ID == 1) meshes_[0].SetActive(false);
        else if (mesh_ID == 2) meshes_[3].SetActive(false);
        else if (mesh_ID == 3) meshes_[2].SetActive(false);
        else if (mesh_ID == 4) meshes_[5].SetActive(false);
        else if (mesh_ID == 5) meshes_[4].SetActive(false);
    }
}
