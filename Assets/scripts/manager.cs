using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.UI;

public class manager : MonoBehaviour
{
    //public GameObject item1,item1black,item2,item2black,item3,item3black,inventario;
    //private GameObject menu, n1,n2,n3,n4,n5,n6,n7;
    //Vector2 item1initial,item2initial,item3initial;
    //Vector2 item1initialscale,item2initialscale,item3initialscale;
    //AudioSource src;
    //public AudioClip winClip;
    //float distancia,tiempo;
    //bool item1correct,item2correct,item3correct,gano,cambianivel;
    //int count;
    //public TextMeshProUGUI txtlevel;



    //void resetinventario(){
    //    item1.transform.position = item1initial;
    //    item2.transform.position = item2initial;
    //    item3.transform.position = item3initial;

    //    item1.transform.localScale = item1initialscale;
    //    item2.transform.localScale = item2initialscale;
    //    item3.transform.localScale = item3initialscale;
    //}

    //void Start()
    //{   
    //    //menu = GameObject.Find("Menu");
    //    txtlevel.text="";
        //n1 = GameObject.Find("Nivel1");
        //n2 = GameObject.Find("Nivel2");
        //n3 = GameObject.Find("Nivel3");
        //n4 = GameObject.Find("Nivel4");
        //n5 = GameObject.Find("Nivel5");
        //n6 = GameObject.Find("Nivel6");


        //item1initial = item1.transform.position;
        //item2initial = item2.transform.position;
        //item3initial = item3.transform.position;

        //item1initialscale = item1.transform.localScale;
        //item2initialscale = item2.transform.localScale;
        //item3initialscale = item3.transform.localScale;

    //    src = GetComponent<AudioSource>();
    //    distancia=200;
    //    tiempo = 0.0f;
    //    gano=false;
    //}

    //void Update()
    //{
        //txtlevel.text="Nivel: "+ LevelManager.levelcount;

        //if (item1correct && item2correct && item3correct)
        //{
        //    src.PlayOneShot(winClip,1);
        //    item1correct=false;
        //    item2correct=false;
        //    item3correct=false;
        //    gano=true;
        //    cambianivel=true;
        //    inventario.SetActive(false);
        //    LevelManager.instance.NextScene();
        //}

    //    if(gano){
    //        tiempo += Time.deltaTime;
    //        if(tiempo >= 5 && cambianivel==true)
    //        {
                
    //            inventario.SetActive(true);
    //            LevelManager.instance.NextScene();                
    //            cambianivel=false;
    //            gano=false;
    //            tiempo=0;
    //        }
    //    }
    //}



    //public void Dragitem1(){
    //    if(item1correct==false){
    //        item1.transform.position = Input.mousePosition;
    //    }

    //    //ponerlo como primer capa
    //}

    //public void Dragitem2(){
    //    if(item2correct==false){
    //        item2.transform.position = Input.mousePosition;
    //    }
    //}

    //public void Dragitem3(){
    //    if(item3correct==false){
    //        item3.transform.position = Input.mousePosition;
    //    }
    //}



    //public void Dropitem1(){
    //    float distance = Vector3.Distance(item1.transform.position,item1black.transform.position);
    //    if(item1correct==false){
    //        if (distance < distancia){
    //            item1.transform.position = new Vector3(item1black.transform.position.x + 2.0f,item1black.transform.position.y - 2.0f,item1black.transform.position.z);
    //            item1.transform.localScale = item1black.transform.localScale;
    //            src.Play();
    //            item1correct = true;

    //        }
    //        else{
    //            item1.transform.position = item1initial;
    //        }
    //    }
        
    //}

    //public void Dropitem2(){
    //    float distance = Vector3.Distance(item2.transform.position,item2black.transform.position);
        
    //    if(item2correct==false){
    //        if (distance < distancia && item2correct==false){
    //            item2.transform.position = new Vector3(item2black.transform.position.x + 2.0f,item2black.transform.position.y - 2.0f,item2black.transform.position.z);
    //            item2.transform.localScale = item2black.transform.localScale;
    //            src.Play();
    //            item2correct = true;
                
    //        }
    //        else{
    //            item2.transform.position = item2initial;
    //        }
    //    }

    //}

    //public void Dropitem3(){
    //    float distance = Vector3.Distance(item3.transform.position,item3black.transform.position);
    //    if(item3correct==false){
    //        if (distance < distancia && item3correct==false){
    //            item3.transform.position = new Vector3(item3black.transform.position.x + 2.0f,item3black.transform.position.y - 2.0f,item3black.transform.position.z);
    //            item3.transform.localScale = item3black.transform.localScale;
    //            src.Play();
    //            item3correct = true;
    //        }
    //        else{
    //            item3.transform.position = item3initial;
    //        }
    //    }
    //}

}
