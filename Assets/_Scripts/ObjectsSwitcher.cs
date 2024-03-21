using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectsSwitcher
{

    private List<GameObject> _objs = new List<GameObject>();
    // controll switch index
    private int _objsIndex = 0;

    // get all GameObjects
    public void InitialObjectsSwitcher(List<GameObject> objs)
    {

        _objs = objs;

        for (int i = 0; i < _objs.Count; i++) {

            Debug.Log("Camera counts :" + (i + 1));


            if (i == 0)
            {

                _objs[0].SetActive(true);

            }
            else
            {

                _objs[i].SetActive(false);
            }


        }       


    }

    // switch objects, and the first one is default active
    public void SwitchObjects()
    {
        _objsIndex++;
        Debug.Log("Change the view !!!!");

        if (_objsIndex >= _objs.Count) {

            _objsIndex = 0;

        }

        for (int i = 0; i < _objs.Count; i++)
        {
                       
            if (i == _objsIndex)
            {

                _objs[i].SetActive(true);

            }
            else
            {

                _objs[i].SetActive(false);
            }


        }

    }
}
