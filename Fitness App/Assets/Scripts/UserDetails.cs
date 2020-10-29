using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using Proyecto26;
using UnityEngine.SceneManagement;

public class UserDetails : MonoBehaviour
{
    public InputField password;
    public InputField email;
    public InputField sign_password;
    public InputField sign_email;
    public static string emails;
    public static string passwords;
    float calories = 0;
    float waterintake = 0;
    public TextMeshProUGUI wat;
    public TextMeshProUGUI cal;
    public TextMeshProUGUI err;
    bool bool_login = false;

    
    // Start is called before the first frame update
    void Start()
    {
        password.asteriskChar = "*"[0];
    }

    // Update is called once per frame
    void Update()
    {
        wat.text= waterintake / 1000 + " Litres";
        cal.text = calories + " Cal";
    }

    public void signupinfo()
    {

    }
     public void waterplus()
    {
        waterintake += 250;
    }
    public void waterminus()
    {
        waterintake -= 250;
    }
    public void caloriesadd(int n)
    {
        calories += n;
    }

    public void login()
    {
        user u = new user();
        
        RestClient.Get<user>("https://hack-c11eb.firebaseio.com/" + email.text + ".json").Then(response =>
        {
            u = response;
            err.text = "here";
            if (u.EMAIL == email.text && u.Password == password.text)
            {
                SceneManager.LoadScene(2);
            }
            else
            {
                err.text = "Incorrect";
            }
        });
        
    }

    public void signup()
    {
        emails = sign_email.text;
        passwords = sign_password.text;
        user un = new user();
        RestClient.Put("https://hack-c11eb.firebaseio.com/" + emails + ".json", un);
    }
}
