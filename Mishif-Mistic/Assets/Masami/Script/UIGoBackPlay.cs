﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIGoBackPlay : MonoBehaviour
{
    private CriAtomSource atomSrc;

    // Start is called before the first frame update
    void Start()
    {
        //CriAtomSourceを取得
        atomSrc = (CriAtomSource)GetComponent("CriAtomSource");
    }

    public void PlaySound()
    {
        if (atomSrc != null)
        {
            atomSrc.Play();
        }
    }

    public void PlayAndStopSound()
    {
        if (atomSrc != null)
        {
            //CriAtomSourceの状態を取得
            CriAtomSource.Status status = atomSrc.status;
            if ((status == CriAtomSource.Status.Stop) || (status == CriAtomSource.Status.PlayEnd))
            {
                //停止状態なので再生
                atomSrc.Play();
            }
            else
            {
                //再生中なので停止
                atomSrc.Stop();
            }
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}

