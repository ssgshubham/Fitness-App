using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class user
{
    public string EMAIL;
    public string Password;

    public user()
    {
        EMAIL = UserDetails.emails;
        Password = UserDetails.passwords;
    }
}