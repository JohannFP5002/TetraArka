using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UIElements;
using TMPro;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    GameObject Start,Options,Exit,OptionsMenu,BackgroundMenu,TituloGame,GameOver;
    [SerializeField]
    LeanTweenType animcurve;
    [SerializeField]
    float timeanim;
    [SerializeField]
    float timeanimjuego;
    [SerializeField]
    TextMeshPro Contador;
    public void animacionUIStart()
    {
        LeanTween.moveLocalX(Start, 1200f, timeanim).setOnComplete(() =>
        {
            LeanTween.moveLocalX(Options, 1200f, timeanim).setOnComplete(() =>
            {
                LeanTween.moveLocalX(Exit, 1200f, timeanim).setOnComplete(() =>
                {
                    BackgroundMenu.SetActive(false);
                    GameOver.SetActive(false);
                    TituloGame.SetActive(true);
                });
            });
        });
        
    }
    public void animacionUIOPtions()
    {
        LeanTween.moveLocalX(Options, 1200f, timeanim).setOnComplete(() =>
        {
            LeanTween.moveLocalX(Start, 1200f, timeanim);
            LeanTween.moveLocalX(Exit, 1200f, timeanim);
        });
        LeanTween.moveLocalY(OptionsMenu, 0f, timeanim);
    }
    public void BotonExitOptions()
    {
        LeanTween.moveLocalY(OptionsMenu, -900f, timeanim);
        LeanTween.moveLocalX(Options, 640f, timeanim).setOnComplete(() =>
        {
            LeanTween.moveLocalX(Start, 640f, timeanim);
            LeanTween.moveLocalX(Exit, 640f, timeanim);
        });
    }
    public void animacionUIExit()
    {
        LeanTween.moveLocalX(Exit, 1200f, timeanim).setOnComplete(() =>
        {
            LeanTween.moveLocalX(Options, 1200f, timeanim).setOnComplete(() =>
            {
                LeanTween.moveLocalX(Start, 1200f, timeanim);
            });
        });
    }
    
}
