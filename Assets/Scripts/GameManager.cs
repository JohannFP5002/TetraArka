using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UIElements;
using TMPro;

public class GameManager : MonoBehaviour
{
    HUDjuego  corriendo;
    [SerializeField]
    GameObject Start,NewGame,Options,Exit,OptionsMenu,BackgroundMenu,TituloGame,GameOver,Victory;
    [SerializeField]
    LeanTweenType animcurve;
    [SerializeField]
    float timeanim;

    public void animacionUIStart()
    {
        LeanTween.moveLocalY(TituloGame, 490f, timeanim);
        LeanTween.moveLocalX(Start, 1200f, timeanim).setOnComplete(() =>
        {
            LeanTween.moveLocalX(NewGame, 1200f, timeanim).setOnComplete(() =>
            { 
                LeanTween.moveLocalX(Options, 1200f, timeanim).setOnComplete(() =>
                {
                    LeanTween.moveLocalX(Exit, 1200f, timeanim).setOnComplete(() =>
                    {
                        BackgroundMenu.SetActive(false);
                        GameOver.SetActive(false);
                        Victory.SetActive(false);
                    });
                });
            });
        });
    }
    public void animacionUIOPtions()
    {
        LeanTween.moveLocalX(NewGame, 1200f, timeanim);
        LeanTween.moveLocalX(Options, 1200f, timeanim).setOnComplete(() =>
        {
            LeanTween.moveLocalX(Start, 1200f, timeanim);
            LeanTween.moveLocalX(Exit, 1200f, timeanim);
        });
        LeanTween.moveLocalY(OptionsMenu, 0f, timeanim);
    }
    public void BotonUINewgame()
    {
        LeanTween.moveLocalX(NewGame, 1200f, timeanim);
        LeanTween.moveLocalY(TituloGame, 490f, timeanim);
        LeanTween.moveLocalX(Options, 1200f, timeanim).setOnComplete(() =>
        {
            LeanTween.moveLocalX(Start, 1200f, timeanim);
            LeanTween.moveLocalX(Exit, 1200f, timeanim).setOnComplete(() =>
            {
                BackgroundMenu.SetActive(false);
                GameOver.SetActive(false);
                Victory.SetActive(false);
            });
        });
    
    }
    public void BotonExitOptions()
    {
        LeanTween.moveLocalY(OptionsMenu, -900f, timeanim);
        LeanTween.moveLocalX(NewGame, 640f, timeanim);
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
                LeanTween.moveLocalX(NewGame, 1200f, timeanim).setOnComplete(() =>
                {
                    LeanTween.moveLocalX(Start, 1200f, timeanim);
            });
        });
    });
}
}
