using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectableTyrantPlayer : Selectable
{
    [SerializeField]
    private Material def, hover, selected;
    private bool isSelected = false;
    public Animator anim;
    public int poseNum;
    public AudioSource sound;

    void Start() {
        gameObject.GetComponent<MeshRenderer>().material = def;
    }

    // This method should set the pose parameter in the animator to poseNum 
    public override GameObject OnSelect()
    {
        // TODO:
        // Set the animator pose value here:
        // Set the object's mesh renderer to the selected material
        // Play the Tyrant's sound clip 

        if (!isSelected) {
            sound.Play();
            isSelected = true;
            gameObject.GetComponent<MeshRenderer>().material = selected;
            anim.SetInteger("pose", poseNum);
        }
        return this.gameObject;
    }

    public override GameObject OnHover()
    {
        if (gameObject.GetComponent<MeshRenderer>().material != hover && !isSelected)
        {
            gameObject.GetComponent<MeshRenderer>().material = hover;
        }
        return this.gameObject;
    }

    public override void OnDeselect()
    {
        isSelected = false;
        // TODO:
        // Set the animator's pose value to 0
        // Set the object's mesh renderer to the def material
        
        anim.SetInteger("pose", 0);
        gameObject.GetComponent<MeshRenderer>().material = def;
        isSelected = false;
    }
}
